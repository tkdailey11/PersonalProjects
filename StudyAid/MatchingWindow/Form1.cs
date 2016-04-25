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
    public partial class Form1 : Form
    {

        private TextBox[] Letters;

        public Form1()
        {
            InitializeComponent();
        }

        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
        }
    }
}
