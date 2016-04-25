﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyAid
{
    public partial class Form1 : Form
    {

        private Dictionary<int, string> terms;
        private int cardNumber;

        public Form1()
        {
            InitializeComponent();

            terms = new Dictionary<int, string>();
            cardNumber = 0;

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string s = termBox.Text + '\t' + definitionBox.Text;
            terms.Add(cardNumber, s);
            cardNumber++;
            this.termBox.Text = "";
            this.definitionBox.Text = "";
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
                sb.Append(n + '\t' + s);
            }

            
        }
    }
}
