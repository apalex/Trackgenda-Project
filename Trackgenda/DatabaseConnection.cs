using System;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Trackgenda
{
    public class DatabaseConnection
    {
        private MySqlConnection conn;
        private string server = "localhost";
        private string database = "trackgenda";
        private string uid = "root";
        private string password = "";
        private string query;

        public DatabaseConnection()
        {
            Initialize();
        }

        private void Initialize()
        {
            string connString = $"server={server};database={database};uid={uid};password={password};";
            conn = new MySqlConnection(connString);
        }

        public bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException e)
            {
                switch (e.Number)
                {
                    case 0:
                        MessageBox.Show("Connection to server failed!");
                        break;
                    case 1045:
                        MessageBox.Show("Server username or password is incorrect!");
                        break;
                }
                return false;
            }
        }

        public void CloseConnection()
        {
            try
            {
                conn.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show($"Failed to close connection: {e.Message}");
            }
        }

        public MySqlConnection GetConnection()
        {
            return conn;
        }

        // Registration
        public bool InsertUser(string firstName,string lastName, string email,string username, string password)
        {
            query = $"INSERT INTO user_info (first_name,last_name,u_email,username,u_password) VALUES ('{firstName}','{lastName}','{email}','{username}','{password}');";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception E)
                {
                    return false;
                }
            }
            catch (Exception E)
            {
                return false;
            }
        }

        public bool isEmailInUse(string email)
        {
            query = $"SELECT * FROM user_info WHERE u_email = '{email}'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                return true;
            }
            reader.Close();
            return false;
        }

        public bool isUsernameInUse(string username)
        {
            query = $"SELECT * FROM user_info WHERE username = '{username}'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                return true;
            }
            reader.Close();
            return false;
        }

        public bool InsertDefaultSettings(int uid)
        {
            query = $"INSERT INTO user_settings (uid,theme,backgroundimage) VALUES ('{uid}','Light','');";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.ToString());
                    return false;
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
                return false;
            }
        }

        // Login
        public bool IsLogin(string username, string password)
        {
            query = $"SELECT * FROM user_info WHERE username = '{username}' AND u_password = '{password}';";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                reader.Close();
                return true;
            }

            reader.Close();
            return false;
        }
        public int getUID(string username)
        {
            int uid = 0;
            query = $"SELECT uid FROM user_info WHERE username = '{username}';";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                uid = reader.GetInt32(0);
                reader.Close();
                return uid;
            }
            reader.Close();
            return uid;
        }

        // Forgot Password
        public bool checkExistInDB(string username, string u_email)
        {
            query = $"SELECT * FROM user_info WHERE username = '{username}' AND u_email = '{u_email}';";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                return true;
            }
            reader.Close();
            return false;
        }

        public bool isPassChanged(string username, string password)
        {
            query = $"UPDATE user_info SET u_password = '{password}' WHERE username = '{username}';";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.ToString());
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
            return false;
        }

        // Monthly Calendar
        public bool addMonthlyEvent(int uid, string date, string eventDesc)
        {
            query = $"INSERT INTO monthly_event (uid,mevent_date,mevent_desc) VALUES ('{uid}','{date}','{eventDesc}');";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception E)
                {
                    return false;
                }
            }
            catch (Exception E)
            {
                return false;
            }
        }

        public int getEventLength(int uid,string date)
        {
            int numEvents = 0;
            query = $"SELECT COUNT(mevent_date) FROM monthly_event WHERE uid = {uid} AND mevent_date = '{date}' GROUP BY uid;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                numEvents = reader.GetInt32(0);
                reader.Close();
                return numEvents;
            }
            reader.Close();
            return numEvents;
        }

        public string getEventDesc(int uid,int index,string date)
        {
            string eventDesc = "";
            query = $"SELECT mevent_desc FROM monthly_event WHERE uid = {uid} AND mevent_date = '{date}' ORDER BY meventid LIMIT 1 OFFSET {index};";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            var reader = cmd.ExecuteScalar();
            if (reader != null)
            {
                eventDesc = Convert.ToString(reader);
                return eventDesc;
            }
            return eventDesc;
        }
    }
}
