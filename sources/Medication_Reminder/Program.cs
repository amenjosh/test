using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Medication_Reminder
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // This is comes from Feature branch on dev//
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
