using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Student_chemistry
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.SplashImageForm());
        }
    }

   // System.Windows.Forms.Form.ShowDialog();
}
