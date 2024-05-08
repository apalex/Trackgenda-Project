using System;
using System.Drawing;
using System.Windows.Forms;

namespace Trackgenda
{
    public partial class NotesForm : Form
    {
        private int uid;
        private int notesIndex = -1;
        private DatabaseConnection dbConn;

        public NotesForm(int uid)
        {
            UID = uid;
            dbConn = new DatabaseConnection();
            dbConn.OpenConnection();
            InitializeComponent();
        }

        private int UID
        {
            get { return uid; }
            set { uid = value; }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NotesForm_Load(object sender, EventArgs e)
        {
            exitButton.Select();
            changeThemeMode();
        }

        private void addRemoveButton_Click(object sender, EventArgs e)
        {
            if (addRemoveButton.Text == "Add")
            {
                if (noteTextBox.TextLength > 0)
                {
                    addNote();
                }
                else
                {
                    MessageBox.Show("Please enter text in the box below before adding a note!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                removeNote();
            }
        }

        private void addNote()
        {
            if (dbConn.addNote(uid, noteTextBox.Text))
            {
                MessageBox.Show("Note successfully added!");
                noteTextBox.Text = "";
            }
        }

        private void removeNote()
        {
            if (dbConn.deleteNote(uid,notesIndex))
            {
                MessageBox.Show("Note successfully deleted!");
                noteTextBox.Text = "";
                notesIndex = -1;
                addRemoveButton.Text = "Add";
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (!dbConn.checkExistNote(uid))
            {
                MessageBox.Show("There are no existing Notes! Please create a Note first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                if (dbConn.getNoteCount(uid) - 1 != notesIndex)
                {
                    notesIndex++;
                    addRemoveButton.Text = "Remove";
                    noteTextBox.Text = $"{dbConn.getNoteDesc(uid, notesIndex)}";
                } else
                {
                    MessageBox.Show("End of Notes reached!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void NotesForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DraggeableForms.Drag(this.Handle);
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (!dbConn.checkExistNote(uid))
            {
                MessageBox.Show("There are no existing Notes! Please create a Note first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (notesIndex != -1)
                {
                    notesIndex--;
                    if (notesIndex == -1)
                    {
                        noteTextBox.Text = "";
                        addRemoveButton.Text = "Add";
                    } else
                    {
                        noteTextBox.Text = $"{dbConn.getNoteDesc(uid, notesIndex)}";
                    }
                }
                else
                {
                    MessageBox.Show("Beginning of Notes reached!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            noteTextBox.Text = "";
            notesIndex = -1;
            addRemoveButton.Text = "Add";
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (notesIndex == -1)
            {
                MessageBox.Show("Please select a Note to Update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                if (noteTextBox.TextLength != 0)
                {
                    updateNote();
                } else
                {
                    MessageBox.Show("Please write anything before updating the Note!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void updateNote()
        {
            if (dbConn.updateNote(uid,notesIndex,noteTextBox.Text))
            {
                MessageBox.Show("Note successfully updated!");
                noteTextBox.Text = $"{dbConn.getNoteDesc(uid, notesIndex)}";
            }
        }

        private string checkThemeMode()
        {
            return dbConn.getUserTheme(uid);
        }

        private void changeThemeMode()
        {
            if (checkThemeMode() == "Light")
            {
                changeLightMode();
            }
            else
            {
                changeDarkMode();
            }
        }

        private void changeLightMode()
        {
            this.BackColor = Color.WhiteSmoke;
            label1.ForeColor = Color.Black;
            exitButton.BackColor = Color.White;
            exitButton.ForeColor = Color.Black;
            clearButton.BackColor = Color.White;
            clearButton.ForeColor = Color.Black;
            previousButton.BackColor = Color.White;
            previousButton.ForeColor = Color.Black;
            updateButton.BackColor = Color.White;
            updateButton.ForeColor = Color.Black;
            addRemoveButton.BackColor = Color.White;
            addRemoveButton.ForeColor = Color.Black;
            nextButton.BackColor = Color.White;
            nextButton.ForeColor = Color.Black;
            noteTextBox.BackColor = Color.White;
            noteTextBox.ForeColor = Color.Black;
        }

        private void changeDarkMode()
        {
            this.BackColor = Color.Gray;
            label1.ForeColor = Color.Black;
            exitButton.BackColor = Color.DarkGray;
            exitButton.ForeColor = Color.Black;
            clearButton.BackColor = Color.DarkGray;
            clearButton.ForeColor = Color.Black;
            previousButton.BackColor = Color.DarkGray;
            previousButton.ForeColor = Color.Black;
            updateButton.BackColor = Color.DarkGray;
            updateButton.ForeColor = Color.Black;
            addRemoveButton.BackColor = Color.DarkGray;
            addRemoveButton.ForeColor = Color.Black;
            nextButton.BackColor = Color.DarkGray;
            nextButton.ForeColor = Color.Black;
            noteTextBox.BackColor = Color.DarkGray;
            noteTextBox.ForeColor = Color.Black;
        }
    }
}
