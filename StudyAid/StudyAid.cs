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

        public StudyAid()
        {
            InitializeComponent();

            terms = new Dictionary<int, string>();
            cardNumber = 0;

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
            FlashCardWindow.FlashCardWindow window = new FlashCardWindow.FlashCardWindow();
            window.initializeWindow(terms);
            window.Visible = true;
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
            MatchingWindow.MatchingWindow window = new MatchingWindow.MatchingWindow();
            window.initializeBoxes(terms);
            window.Visible = true;
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
            }
            catch (Exception e2)
            {
            }

            string[] terms_ = file.Split();

            foreach(string s in terms_)
            {
                string[] arr = s.Split('\t');
                terms.Add(Int32.Parse(arr[0]), arr[1]);
            }

        }
    }
}
