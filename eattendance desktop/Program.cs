using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace eattendance_desktop
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
            var loginWindow = new LoginWindow();
            //loginWindow.ShowInTaskbar = true;
            //loginWindow.Visible = false;
            Application.Run(loginWindow);
        }
    }
}
