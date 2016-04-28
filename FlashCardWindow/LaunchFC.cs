//Created by Tyler Dailey, Copyright 4/28/2016, StudyAid Version 1.0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashCardWindow
{
    static class LaunchFC
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FlashCardWindow());
        }
    }
}
