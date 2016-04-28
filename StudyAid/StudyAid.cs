using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyAid
{
    public partial class StudyAid : Form
    {

        private Dictionary<int, string> terms;
        private int cardNumber;
        private string sessionID;

        public StudyAid()
        {
            InitializeComponent();

            terms = new Dictionary<int, string>();
            cardNumber = 0;

            while(sessionID == null || sessionID == "")
            {
                sessionID = Prompt.ShowDialog();
                if(sessionID == null || sessionID == "")
                {
                    MessageBox.Show("Please enter a session name between 1-50 characters", "Empty Session ID", MessageBoxButtons.OK);
                }
            }

        }

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
        }

        private void newItem_Click(object sender, EventArgs e)
        {
            terms = new Dictionary<int, string>();
            cardNumber = 0;
        }

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

        private void saveItem_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach(int n in terms.Keys)
            {
                string s = "";
                terms.TryGetValue(n, out s);
                sb.Append(n + '\t' + s + '\n');
            }

            saveFileDialog1.Filter = "Txt Files|*.txt";
            saveFileDialog1.ShowDialog();

            StreamWriter file = new StreamWriter(saveFileDialog1.FileName);

            file.Write(sb.ToString());
            file.Close();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                addButton_Click(sender, e);
            }
        }

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

        private void openItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Txt Files|*.txt";
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            string file = "";
            try
            {   
                using (StreamReader sr = new StreamReader(filename))
                { 
                    file = sr.ReadToEnd();
                }

                string[] terms_ = file.Split();

                foreach (string s in terms_)
                {
                    string[] arr = s.Split('\t');
                    terms.Add(Int32.Parse(arr[0]), arr[1]);
                }

            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message, "File Not Found", MessageBoxButtons.OK);
            }

        }


        private void saveSession()
        {

        }

        private void openSession()
        {

        }



        public static class Prompt
        {
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

    }
}
