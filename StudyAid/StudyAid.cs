//Created by Tyler Dailey, Copyright 4/28/2016, StudyAid Version 1.0
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace StudyAid
{
    /// <summary>
    /// Allows the user to enter terms and corresponding definitions, and then allows them to 
    /// play matching games or provides flashcards to aid in the study process.
    /// </summary>
    public partial class StudyAid : Form
    {

        private Dictionary<int, string> terms;
        private int cardNumber;
        private string sessionID;
        private bool hasBeenSaved;
        private string StudyAidConnectionString;

        /// <summary>
        /// Initialize the StudyAid Window.
        /// </summary>
        public StudyAid()
        {
            InitializeComponent();

            terms = new Dictionary<int, string>();
            cardNumber = 0;
            hasBeenSaved = true;

            while(sessionID == null || sessionID == "")
            {
                sessionID = Prompt.ShowDialog();
                if(sessionID == null || sessionID == "")
                {
                    MessageBox.Show("Please enter a session name between 1-50 characters", "Empty Session ID", MessageBoxButtons.OK);
                }
            }

            StudyAidConnectionString = ConfigurationManager.ConnectionStrings["StudyAidConnectionString"].ConnectionString;
            Console.Read();
        }

        /// <summary>
        /// Adds a new item to the terms dictionary.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (termBox.Text == null || termBox.Text == "" || definitionBox.Text == null || definitionBox.Text == "")
            {
                MessageBox.Show("Invalid entry in one or more box, please enter something in each box before continuing.", "Invalid Entry", MessageBoxButtons.RetryCancel);
            }
            else
            {
                string s = termBox.Text + '\t' + definitionBox.Text;
                terms.Add(cardNumber, s);
                cardNumber++;
                this.termBox.Text = "";
                this.definitionBox.Text = "";
            }

            hasBeenSaved = false;
        }

        /// <summary>
        /// Clear out the cardNumber and terms fields.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Continuing will result in the loss of any unsaved data, do you wish to continue?", "New Session Warning", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                terms = new Dictionary<int, string>();
                cardNumber = 0;
            }
        }

        /// <summary>
        /// Open a FlashCard window for the current session.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void flashcardItem_Click(object sender, EventArgs e)
        {
            if (terms.Count <= 0)
            {
                MessageBox.Show("Please enter at least one term/definition pair before continuing", "Empty Term List", MessageBoxButtons.OK);
            }
            else {
                FlashCardWindow.FlashCardWindow window = new FlashCardWindow.FlashCardWindow();
                window.initializeWindow(terms);
                window.Visible = true;
            }
        }

        /// <summary>
        /// Save the current session to the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(StudyAidConnectionString))
            {
                conn.Open();

                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    using (SqlCommand command = new SqlCommand("INSERT INTO EntriesTable(SessionName,Term, Definition) VALUES (@SessionName,@Term,@Definition)", conn, trans))
                    {

                        int n = 0;
                        foreach (string s in terms.Values)
                        {
                            command.Parameters.AddWithValue("@SessionName", this.sessionID);
                            string[] arr = s.Split('\t');
                            command.Parameters.AddWithValue("@Term", arr[0]);
                            command.Parameters.AddWithValue("@Definition", arr[1]);



                            n += command.ExecuteNonQuery();

                            command.Parameters.Clear();

                        }

                        if (n == terms.Values.Count)
                        {
                            trans.Commit();
                            hasBeenSaved = true;

                            MessageBox.Show("Save Successful", "Save", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Fire the add button event handler when the enter button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                addButton_Click(sender, e);
            }
        }

        /// <summary>
        /// Open a matching window for the current session.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void matchingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (terms.Count <= 0)
            {
                MessageBox.Show("Please enter at least one term/definition pair before continuing", "Empty Term List", MessageBoxButtons.OK);
            }
            else {
                MatchingWindow.MatchingWindow window = new MatchingWindow.MatchingWindow();
                window.initializeBoxes(terms);
                window.Visible = true;
            }
        }

        /// <summary>
        /// Event Handler for when the open item is selected from the File Menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openItem_Click(object sender, EventArgs e)
        {
            bool wantsToContinue = true;
            if (!hasBeenSaved)
            {
                DialogResult saveWarning = MessageBox.Show("There is unsaved data, if you continue, this data will be lost. Do you still want to continue?", "Unsaved Data", MessageBoxButtons.YesNo);

                if (saveWarning == DialogResult.Yes)
                {
                    wantsToContinue = true;
                }
            }


            if (wantsToContinue)
            {
                List<string> sessions = new List<string>();
                using (SqlConnection conn = new SqlConnection(StudyAidConnectionString))
                {
                    conn.Open();

                    using (SqlTransaction trans = conn.BeginTransaction())
                    {
                        //Get list of all Session Names
                        using (SqlCommand command = new SqlCommand("select * from EntriesTable", conn, trans))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string s = (string)reader["SessionName"];
                                    if (!sessions.Contains(s))
                                    {
                                        sessions.Add(s);
                                    }
                                }
                            }
                        }

                        if (sessions.Count == 0)
                        {
                            MessageBox.Show("There are no saved sessions to display.", "", MessageBoxButtons.OK);
                        }
                        else
                        {
                            //Add a form here to get the desired session name from the user
                            string selected = OpenDialog.ShowDialog(sessions);

                            //Add an SqlCommand here to get all terms and definitions from the database
                            using (SqlCommand command = new SqlCommand("select * from EntriesTable where SessionName = @SessionName", conn, trans))
                            {
                                terms.Clear();

                                command.Parameters.AddWithValue("@SessionName", selected);

                                using (SqlDataReader reader = command.ExecuteReader())
                                {
                                    int n = 0;
                                    while (reader.Read())
                                    {
                                        string term = reader[2].ToString();
                                        term += ('\t' + reader[3].ToString());
                                        terms.Add(n, term);
                                        n++;
                                    }
                                }
                            }
                        }

                        trans.Commit();
                    }
                }
            }
        }

        /// <summary>
        /// Prompts the User to input a Session ID/Name.
        /// </summary>
        public static class Prompt
        {
            /// <summary>
            /// Show the prompt asking for a session ID/Name.
            /// </summary>
            /// <returns></returns>
            public static string ShowDialog()
            {
                Form prompt = new Form();
                prompt.Width = 500;
                prompt.Height = 200;
                prompt.Text = "Session ID";
                Label textLabel = new Label() { Width = 400, Left = 50, Top = 20, Text = "Please enter a session name (50 characters or less):" };                
                TextBox inputBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
                Button confirmation = new Button() { Text = "OK", Left = 100, Width = 300, Top = 100 , Height = 50};
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(inputBox);
                prompt.ShowDialog();
                return inputBox.Text;
            }
        }

        /// <summary>
        /// Open a dialog window asking the user to select from the saved session ID's.
        /// </summary>
        public static class OpenDialog
        {
            /// <summary>
            /// Open the dialog window for the form.
            /// </summary>
            /// <param name="items"></param>
            /// <returns></returns>
            public static string ShowDialog(List<string> items)
            {
                Form dialog = new Form() { Width = 500, Height = 600, Text = "Choose Session to Open"};
                ListBox listOfItems = new ListBox() { Top = 50, Left = 50, Width = 400, Height = 400 };

                foreach(string s in items)
                {
                    listOfItems.Items.Add(s);
                }

                Button confirmation = new Button() { Text = "OK", Left = 175, Top = 500, Height = 50, Width = 150};
                confirmation.Click += (sender, e) => { dialog.Close(); };
                dialog.Controls.Add(confirmation);
                dialog.Controls.Add(listOfItems);
                dialog.ShowDialog();

                return listOfItems.SelectedItem.ToString();
            }
        }
    }
}
