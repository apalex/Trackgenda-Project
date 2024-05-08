using System;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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

        public string getUserTheme(int uid)
        {
            string theme = "";
            query = $"SELECT theme FROM user_settings WHERE uid = {uid};";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            var reader = cmd.ExecuteScalar();
            if (reader != null)
            {
                theme = Convert.ToString(reader);
                return theme;
            }
            return theme;
        }

        // Registration
        public bool InsertUser(string firstName, string lastName, string email, string username, string password)
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
        public bool addMonthlyEvent(int uid, string date, string eventDesc, string background)
        {
            query = $"INSERT INTO monthly_event (uid,mevent_date,mevent_desc,mevent_background) VALUES ('{uid}','{date}','{eventDesc}','{background}');";
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

        public int getEventLength(int uid, string date)
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

        public string getEventDesc(int uid, int index, string date)
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

        public bool setEventDesc(int uid, int index, string date, string newDesc, string background)
        {
            query = $"UPDATE monthly_event SET mevent_desc = '{newDesc}', mevent_background = '{background}' WHERE meventid = (SELECT meventid FROM monthly_event WHERE uid = {uid} AND mevent_date = '{date}' ORDER BY meventid LIMIT 1 OFFSET {index});";
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

        public bool checkExistMonthlyEvent(int uid, string event_date)
        {
            query = $"SELECT * FROM monthly_event WHERE uid = {uid} AND mevent_date = '{event_date}';";
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

        public string getMonthlyBackground(int uid, string event_date)
        {
            string background = "";
            query = $"SELECT mevent_background FROM monthly_event WHERE uid = {uid} AND mevent_date = '{event_date}';";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            var reader = cmd.ExecuteScalar();
            if (reader != null)
            {
                background = Convert.ToString(reader);
                return background;
            }
            return background;
        }

        // Change Background
        public bool resetBackgroundImage(int uid)
        {
            query = $"UPDATE user_settings SET backgroundimage = '' WHERE uid = {uid};";
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

        public bool insertBackgroundImage(int uid,string path)
        {
            query = $"UPDATE user_settings SET backgroundimage = '{path}' WHERE uid = {uid};";
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

        public string getBackgroundPath(int uid)
        {
            string backgroundPath = "";
            query = $"SELECT backgroundimage FROM user_settings WHERE uid = {uid};";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            var reader = cmd.ExecuteScalar();
            if (reader != null)
            {
                backgroundPath = Convert.ToString(reader);
                return backgroundPath;
            }
            return backgroundPath;
        }

        // Weekly Calendar
        public string getWeeklyBackground(int uid, string event_date)
        {
            string background = "";
            query = $"SELECT wevent_background FROM weekly_event WHERE uid = {uid} AND wevent_date = '{event_date}';";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            var reader = cmd.ExecuteScalar();
            if (reader != null)
            {
                background = Convert.ToString(reader);
                return background;
            }
            return background;
        }

        public bool checkExistWeeklyEvent(int uid, string event_date)
        {
            query = $"SELECT * FROM weekly_event WHERE uid = {uid} AND wevent_date = '{event_date}';";
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

        public string getWeeklyEventDesc(int uid, string date)
        {
            string eventDesc = "";
            query = $"SELECT wevent_desc FROM weekly_event WHERE uid = {uid} AND wevent_date = '{date}';";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            var reader = cmd.ExecuteScalar();
            if (reader != null)
            {
                eventDesc = Convert.ToString(reader);
                return eventDesc;
            }
            return eventDesc;
        }

        public bool addWeeklyEvent(int uid, string date, string eventDesc, string eventBackground)
        {
            query = $"INSERT INTO weekly_event (uid,wevent_date,wevent_desc,wevent_background) VALUES ('{uid}','{date}','{eventDesc}','{eventBackground}');";
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

        public bool editWeeklyEvent(int uid,string newDesc, string background,string date)
        {
            query = $"UPDATE weekly_event SET wevent_desc = '{newDesc}',wevent_background = '{background}' WHERE uid = {uid} AND wevent_date = '{date}';";
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

        // Settings
        public bool checkExistEmail(int uid, string email)
        {
            query = $"SELECT * FROM user_info WHERE uid = {uid} AND u_email = '{email}';";
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

        public bool updateEmail(int uid, string email)
        {
            query = $"UPDATE user_info SET u_email = '{email}' WHERE uid = {uid};";
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

        public bool checkPassword(int uid, string password)
        {
            query = $"SELECT * FROM user_info WHERE uid = {uid} AND u_password = '{password}';";
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

        public bool updatePassword(int uid, string password)
        {
            query = $"UPDATE user_info SET u_password = '{password}' WHERE uid = {uid};";
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

        public bool changeTheme(int uid, string theme)
        {
            query = $"UPDATE user_settings SET theme = '{theme}' WHERE uid = {uid};";
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

        // Notes
        public bool checkExistNote(int uid)
        {
            query = $"SELECT * FROM notes WHERE uid = {uid};";
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

        public bool addNote(int uid, string details)
        {
            query = $"INSERT INTO notes (uid,note_details) VALUES ('{uid}','{details}');";
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

        public string getNoteDesc(int uid, int index)
        {
            string noteDesc = "";
            query = $"SELECT note_details FROM notes WHERE uid = {uid} ORDER BY noteid LIMIT 1 OFFSET {index};";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            var reader = cmd.ExecuteScalar();
            if (reader != null)
            {
                noteDesc = Convert.ToString(reader);
                return noteDesc;
            }
            return noteDesc;
        }

        public int getNoteCount(int uid)
        {
            int numEvents = 0;
            query = $"SELECT COUNT(noteid) FROM notes WHERE uid = {uid} GROUP BY uid;";
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

        public bool updateNote(int uid, int index, string note)
        {
            note = note.Replace("'","''");
            query = $"UPDATE notes SET note_details = '{note}' WHERE noteid = (SELECT noteid FROM (SELECT noteid FROM notes WHERE uid = {uid} ORDER BY noteid LIMIT 1 OFFSET {index}) AS subquery);";
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

        public bool deleteNote(int uid, int index)
        {
            query = $"DELETE FROM notes WHERE noteid = (SELECT noteid FROM (SELECT noteid FROM notes WHERE uid = {uid} ORDER BY noteid LIMIT 1 OFFSET {index}) AS subquery);";
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
    }
}
