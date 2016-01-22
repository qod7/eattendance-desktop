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
            initCommon();
            Application.Run(loginWindow);
        }

        private static void initCommon()
        {
            var md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            var sha1 = new System.Security.Cryptography.SHA1CryptoServiceProvider();

            var md5data = md5.ComputeHash(System.Text.Encoding.ASCII.GetBytes(Common.ipRegex.ToString()));
            var md6data = md5.ComputeHash(sha1.ComputeHash(System.Text.Encoding.ASCII.GetBytes(Common.portRegex.ToString())));
            var sha2data = md5.ComputeHash(md5data.Concat(md6data).ToArray());
            //Common.dbPass = Convert.ToBase64String(sha2data);
        }
    }
}
