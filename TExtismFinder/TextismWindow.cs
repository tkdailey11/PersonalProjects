using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TExtismFinder
{
    public partial class TextismWindow : Form
    {
        private List<string> enDictionary;
        public TextismWindow()
        {
            InitializeComponent();
            StreamReader read = new StreamReader(@"C:\Users\Tyler\Source\Repos\PersonalProjects\TExtismFinder\wordsEn.txt");
            string dict = read.ReadToEnd();
            string[] dictArr = dict.Split(' ', '\n', '\t');
            enDictionary = dictArr.ToList();
        }

        private List<string> totalAbbreviations;
        private List<string> category1;
        private List<string> category2;
        private List<string> toBeAnalyzed;

        private void NewFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = "C://";

            int totalWords = 0;
            int totalTweets = 0;

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.Yes || result == DialogResult.OK)
            {
                string s;
                using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                {

                    Regex twitterHandle = new Regex(@"\@.*");
                    s = sr.ReadToEnd();
                    totalTweets++;
                    string[] list = s.Split(' ', '\n', '\t');
                    foreach (string t in list)
                    {
                        if (!enDictionary.Contains(t))
                        {
                            if (!twitterHandle.IsMatch(t))
                            {
                                toBeAnalyzed.Add(t);
                            }
                        }
                    }
                }

                sortWindow wind = new sortWindow();
                wind.Show();
                foreach (string x in toBeAnalyzed)
                {
                    wind.setWordBox(x);
                    string t = wind.returnCategory();
                }
            }
        }
    }
}
