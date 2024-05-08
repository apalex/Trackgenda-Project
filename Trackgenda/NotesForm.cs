using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trackgenda
{
    public partial class NotesForm : Form
    {
        private int uid;
        private int notesIndex = 0;
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
        }

        private void addRemoveButton_Click(object sender, EventArgs e)
        {
            if (addRemoveButton.Text == "Add")
            {
                if (noteTextBox.TextLength > 0)
                {
                    if (dbConn.addNote(uid,noteTextBox.Text))
                    {
                        MessageBox.Show("Note successfully added!");
                        noteTextBox.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Please enter text in the box below before adding a note!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Remove Here
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (!dbConn.checkExistNote(uid))
            {
                MessageBox.Show("There are no existing Notes! Please create a Note first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                previousButton.Visible = true;
                notesIndex++;
                addRemoveButton.Text = "Remove";
                // Make string = note_details, also make it so if reaches end of notes, then show warning sign.
            }
        }

        private void NotesForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DraggeableForms.Drag(this.Handle);
            }
        }
    }
}
