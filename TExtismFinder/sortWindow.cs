using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TExtismFinder
{



    public partial class sortWindow : Form
    {

        /// <summary>
        /// Fired when a file is chosen with a file dialog.
        /// The parameter is the chosen filename.
        /// </summary>
        public event Action<string> SubmitEvent;

        public sortWindow()
        {
            InitializeComponent();
        }

        public void setWordBox(string s)
        {
            this.DisplayWordBox.Text = s;
        }

        private string returnCategory()
        {
            if (GenAbbrevButton.Checked)
            {
                return GenAbbrevButton.Text;
            }
            else if (Cat1Button.Checked)
            {
                return Cat1Button.Text;
            }
            else if (Cat2Button.Checked)
            {
                return Cat2Button.Text;
            }
            else
            {
                return DisregardButton.Text;
            }
        }
    }
}
