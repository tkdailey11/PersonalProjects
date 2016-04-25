using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingWindow
{
    public partial class MatchingWindow : Form
    {

        private TextBox[] Letters;
        private TextBox[] Terms;
        private List<string> termList;
        private Dictionary<string, string> defTermDictionary;
        private int numTerms;
        private string[] answers;
        private Dictionary<string, string> answerDictionary;
        private string[] TermArray;

        public MatchingWindow()
        {
            InitializeComponent();
            numTerms = 20;
            Letters = new TextBox[numTerms];
            Terms = new TextBox[numTerms];
            TermArray = new string[numTerms];
            termList = new List<string>();
            defTermDictionary = new Dictionary<string, string>();
            answerDictionary = new Dictionary<string, string>();
            lettersTextBoxes();
            termsTextBoxes();
        }

        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
        }

        public void initializeBoxes(Dictionary<int, string> d)
        {
            string s = "";
            
            numTerms = d.Count;
            answers = new string[numTerms];

            for(int i = 0; i < numTerms; i++)
            {
                if(d.TryGetValue(i, out s))
                {
                    termList.Add(s);
                }

            }


            Shuffle();

            //Add all terms for the matching dictionary
            for(int j = 0; j < numTerms; j++)
            {
                string[] termDef = termList[j].Split('\t');
                defTermDictionary.Add(termDef[1], termDef[0]);
            }

            TermArray = defTermDictionary.Values.ToArray();

            ShuffleArray(TermArray);

            for(int k = 0; k < numTerms; k++)
            {
                Terms[k].Text = TermArray[k];
            }

            string[] keyArray = defTermDictionary.Keys.ToArray();
            for (int n = 0; n < numTerms; n++)
            {
                int charNum = 97 + n;
                string letter = char.ConvertFromUtf32(charNum);

                string def = keyArray[n];

                this.DefinitionBox.AppendText(letter + '\t' + def + '\n' + '\n');

                string key = "";

                if(defTermDictionary.TryGetValue(def, out key))
                {
                    answerDictionary.Add(letter, key);
                }
            }

        }

        private void ShuffleArray(string[] arr)
        {
            Random rng = new Random();
            int n = arr.Length;
            while(n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string value = arr[k];
                arr[k] = arr[n];
                arr[n] = value;
            }
        }

        private void Shuffle()
        {
            Random rng = new Random();
            int n = this.termList.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string value = this.termList[k];
                this.termList[k] = this.termList[n];
                this.termList[n] = value;
            }
        }

        private void termsTextBoxes()
        {

            Terms[0] = textBox2;
            Terms[1] = textBox4;
            Terms[2] = textBox6;
            Terms[3] = textBox8;
            Terms[4] = textBox10;
            Terms[5] = textBox12;
            Terms[6] = textBox14;
            Terms[7] = textBox16;
            Terms[8] = textBox18;
            Terms[9] = textBox20;
            Terms[10] = textBox22;
            Terms[11] = textBox24;
            Terms[12] = textBox26;
            Terms[13] = textBox28;
            Terms[14] = textBox30;
            Terms[15] = textBox32;
            Terms[16] = textBox34;
            Terms[17] = textBox36;
            Terms[18] = textBox38;
            Terms[19] = textBox40;
        }


        private void lettersTextBoxes()
        {
            Letters[0] = textBox1;
            Letters[1] = textBox5;
            Letters[2] = textBox7;
            Letters[3] = textBox9;
            Letters[4] = textBox11;
            Letters[5] = textBox13;
            Letters[6] = textBox15;
            Letters[7] = textBox17;
            Letters[8] = textBox19;
            Letters[9] = textBox21;
            Letters[10] = textBox23;
            Letters[11] = textBox25;
            Letters[12] = textBox27;
            Letters[13] = textBox29;
            Letters[14] = textBox31;
            Letters[15] = textBox33;
            Letters[16] = textBox35;
            Letters[17] = textBox37;
            Letters[18] = textBox39;
            Letters[19] = textBox41;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            string[] answersProvided = new string[numTerms];
            for(int i = 0; i < numTerms; i++)
            {
                answersProvided[i] = Letters[i].Text;
            }

            int correct = 0;

            for(int j = 0; j < numTerms; j++)
            {
                if (answerDictionary[answersProvided[j]] == TermArray[j])
                {
                    correct++;
                }
            }

            if (correct == numTerms)
            {
                CorrectBox.Text = correct.ToString();
                totalBox.Text = numTerms.ToString();
                MessageBox.Show("Congratulations, you have gotten 100% correct!", "100% Correct", MessageBoxButtons.OK);
            }
            else
            {
                CorrectBox.Text = correct.ToString();
                totalBox.Text = numTerms.ToString();

                MessageBox.Show("You got fewer than 100% correct, please try again.", "Incorrect Answer(s)", MessageBoxButtons.OK);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }
    }
}
