using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QTracker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Get Reference to the current Process
            Process[] pname = Process.GetProcessesByName("QTracker");
            if (pname.Length > 1) {
                // If ther is more than one, than it is already running.
                MessageBox.Show("Application is already running.");
                Application.Exit();
                return;
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }
    }
}
