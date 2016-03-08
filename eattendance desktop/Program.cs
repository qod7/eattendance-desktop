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
            DatabaseHandler DB = new DatabaseHandler();
            DB.initDatabase();
            // hide the login window while logged_in check happens in background
            loginWindow.Opacity = 0;
            Application.Run(loginWindow);
        }
    }
}
