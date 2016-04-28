//Created by Tyler Dailey, Copyright 4/28/2016, StudyAid Version 1.0
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashCardWindow
{

    /// <summary>
    /// Represents a Flash Card with the ability to cycle between the provided dictionary
    /// of cards (key is card number, value is term '\t' definition).
    /// </summary>
    public partial class FlashCardWindow : Form
    {
        private Dictionary<int, string> setTerms;
        private List<int> cardNumbers;
        private int currentCard;
        private string nextDisplay;
        private Color termColor;
        private Color definitionColor;


        /// <summary>
        /// Initialize the FlashCardWindow.
        /// </summary>
        public FlashCardWindow()
        {
            InitializeComponent();
            this.CardBox.TextAlign = HorizontalAlignment.Center;
            this.termColor = Color.Aquamarine;
            this.definitionColor = Color.Goldenrod;
        }

        /// <summary>
        /// Initialize the FlashCardWindow with the given dictionary(the key is an int cardNumber, and
        /// the string value is a term and definition separated by a '\t' character.
        /// </summary>
        /// <param name="d"></param>
        public void initializeWindow(Dictionary<int, string> d)
        {
            this.setTerms = d;
            this.currentCard = 0;
            this.cardNumbers = new List<int>();

            for(int i = 0; i < d.Count; i++)
            {
                this.cardNumbers.Add(i);
            }


            Shuffle();

            string s = "";
            string s1 = "";
            string s2 = "";
            this.nextDisplay = "";
            if (setTerms.TryGetValue(cardNumbers[currentCard], out s))
            {
                string[] terms = s.Split('\t');
                s1 = terms[0];
                s2 = terms[1];

                //Set the display to the term
                this.CardBox.Text = s1;
                this.CardBox.BackColor = termColor;
                this.nextDisplay = s2;
            }
        }

        /// <summary>
        /// Called when the right arrow button on the form is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RightButton_Click(object sender, EventArgs e)
        {
            //Currently on the definition of a card, go to the next term
            if(this.nextDisplay == "")
            {
                
                string s = "";

                if(currentCard + 1 < cardNumbers.Count && setTerms.TryGetValue((cardNumbers[currentCard + 1]), out s))
                {
                    this.currentCard++;
                    string[] term = s.Split('\t');

                    //Set the display to the term
                    this.CardBox.Text = term[0];
                    this.nextDisplay = term[1];
                    this.CardBox.BackColor = termColor;

                }
            }
            else
            {
                //Set the display to the definition
                this.CardBox.Text = this.nextDisplay;
                this.nextDisplay = "";
                this.CardBox.BackColor = definitionColor;
            }
        }

        /// <summary>
        /// Called when the left button on the form is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LeftButton_Click(object sender, EventArgs e)
        {
            //If nextDisplay is empty that means we are on the 
            //definition of the current card
            if(this.nextDisplay == "")
            {
                string s = "";
                if(this.setTerms.TryGetValue((cardNumbers[currentCard]), out s))
                {
                    string[] term = s.Split('\t');

                    //Set the display to the term
                    this.CardBox.Text = term[0];
                    this.nextDisplay = term[1];
                    this.CardBox.BackColor = termColor;
                }               
            }
            //If there is something in nextDisplay that means we are on the term of the
            //Current Card, go to the definition of the previous card
            else
            {
                
                string s = "";
                if (this.currentCard - 1 >= 0 && this.setTerms.TryGetValue(cardNumbers[currentCard], out s))
                {
                    this.currentCard--;
                    string[] term = s.Split('\t');

                    //Set the display to the definition
                    this.CardBox.Text = term[1];
                    this.nextDisplay = "";
                    this.CardBox.BackColor = definitionColor;
                }

            }
        }

        private Random rng = new Random();

        public void Shuffle()
        {
            int n = this.cardNumbers.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int value = this.cardNumbers[k];
                this.cardNumbers[k] = this.cardNumbers[n];
                this.cardNumbers[n] = value;
            }
        }

        /// <summary>
        /// Change the back color for the window when a term is being displayed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void termColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            termColor = colorDialog1.Color;
            if (this.nextDisplay != "")
            {
                this.CardBox.BackColor = termColor;
            }
        }

        /// <summary>
        /// Change the color for the window when a definition is being displayed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void definitionColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            definitionColor = colorDialog1.Color;

            if(this.nextDisplay == "")
            {
                this.CardBox.BackColor = definitionColor;
            }
        }

        /// <summary>
        /// Change the color of the font.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.CardBox.ForeColor = colorDialog1.Color;
        }

        /// <summary>
        /// Changes the font in the card display window, as well as the left and right arrows, 
        /// the arrows will not change size however.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();

            this.CardBox.Font = fontDialog1.Font;
            this.LeftButton.Font = new Font(fontDialog1.Font.FontFamily, 35);
            this.RightButton.Font = new Font(fontDialog1.Font.FontFamily, 35);
        }

        /// <summary>
        /// Close the window when the CLose option is selected from the file menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }
    }
}
