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

    public partial class FlashCardWindow : Form
    {
        private Dictionary<int, string> setTerms;
        private int currentCard;
        private string nextDisplay;

        /// <summary>
        /// Represents a Flash Card with the ability to cycle between the provided dictionary
        /// of cards (key is card number, value is term '\t' definition). If a term is displayed,
        /// the backColor is Color.AliceBlue, if a definition is displayed the backColor is 
        /// Color.lightGoldenrodYellow
        /// </summary>
        /// <param name="d"></param>
        public FlashCardWindow()
        {
            InitializeComponent();
            this.CardBox.TextAlign = HorizontalAlignment.Center;
        }

        public void initializeWindow(Dictionary<int, string> d)
        {
            this.setTerms = d;
            this.currentCard = 0;

            string s = "";
            string s1 = "";
            string s2 = "";
            this.nextDisplay = "";
            if (setTerms.TryGetValue(currentCard, out s))
            {
                string[] terms = s.Split('\t');
                s1 = terms[0];
                s2 = terms[1];

                //Set the display to the term
                this.CardBox.Text = s1;
                this.CardBox.BackColor = Color.AliceBlue;
                this.nextDisplay = s2;
            }
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            if(this.nextDisplay == "")
            {
                
                string s = "";

                if(setTerms.TryGetValue((this.currentCard + 1), out s))
                {
                    this.currentCard++;
                    string[] term = s.Split('\t');

                    //Set the display to the term
                    this.CardBox.Text = term[0];
                    this.nextDisplay = term[1];
                    this.CardBox.BackColor = Color.AliceBlue;

                }
            }
            else
            {
                //Set the display to the definition
                this.CardBox.Text = this.nextDisplay;
                this.nextDisplay = "";
                this.CardBox.BackColor = Color.LightGoldenrodYellow;
            }
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            //If nextDisplay is empty that means we are on the 
            //definition of the current card
            if(this.nextDisplay == "")
            {
                string s = "";
                if(this.setTerms.TryGetValue(currentCard, out s))
                {
                    string[] term = s.Split('\t');

                    //Set the display to the term
                    this.CardBox.Text = term[0];
                    this.nextDisplay = term[1];
                    this.CardBox.BackColor = Color.AliceBlue;
                }               
            }
            //If there is something in nextDisplay that means we are on the term of the
            //Current Card, go to the definition of the previous card
            else
            {
                this.currentCard--;
                string s = "";
                if (this.setTerms.TryGetValue(currentCard, out s))
                {
                    string[] term = s.Split('\t');

                    //Set the display to the definition
                    this.CardBox.Text = term[1];
                    this.nextDisplay = "";
                    this.CardBox.BackColor = Color.LightGoldenrodYellow;
                }

            }
        }
    }
}
