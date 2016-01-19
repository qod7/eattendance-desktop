using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace eattendance_desktop
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginWindow_Shown(object sender, EventArgs e)
        {
            // TODO: Check local database for credentials and tokens
            // if token exists
            //login();
            // Additional: if certain amount of days have past since last server communication,
            // delete token. Force login again.
            // Since no data in the server can be updated without a valid token, 
            // even if the desktop app is logged in with an outdated token, it doesn't matter much.
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Clear any error messages
            errorProvider1.Clear();
            // Get text
            String username = txtUsername.Text.Trim();
            String password = txtPassword.Text.Trim();
            // Validate locally
            if (String.IsNullOrEmpty(username))
            {
                errorProvider1.SetError(txtUsername, "Username field cannot be empty.");
                return;
            }
            if (String.IsNullOrEmpty(password))
            {
                errorProvider1.SetError(txtPassword, "Password field cannot be empty.");
                return;
            }
            Cursor = Cursors.WaitCursor;
            // Validate with Server
                // TODO run some api calls with handlers
            String token = "some goddamn token";
            String hash = password; // TODO do something here
            
            // now save credentials and token to database
            saveLoginInfoToMDB(username, token, hash);


            // now allow login
            Cursor = Cursors.Default;
            login();
        }

        private void saveLoginInfoToMDB(String username, String token, String hash) {
            String DBPath = Application.StartupPath + "\\data\\eattendance.mdb";
            if (!File.Exists(DBPath))
            {
                if (!Directory.Exists(Application.StartupPath + "\\data"))
                    Directory.CreateDirectory(Application.StartupPath + "\\data");
                ADOX.Catalog cat = new ADOX.Catalog();
                cat.Create("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBPath);
                cat = null;
            }
            string sql;
            String connString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBPath;
            OleDbConnection conn = new OleDbConnection(connString);
            conn.Open();
            try
            {
                sql = "create table loginCredentials (Name varchar(64) not null, Token varchar(64) not null," +
                             "Hash varchar(64) not null);";
                (new OleDbCommand(sql, conn)).ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                // table already created. ignore.
            }

            sql = "delete * from loginCredentials";
            (new OleDbCommand(sql, conn)).ExecuteNonQuery();
            sql = String.Format("insert into loginCredentials values(\"{0}\", \"{1}\", \"{2}\");", username, token, hash);
            (new OleDbCommand(sql, conn)).ExecuteNonQuery();

            conn.Close();
        }

        private void login()
        {
            this.Hide();

            using (var mainWindow = new MainWindow())
            {
                mainWindow.ShowDialog();
                ExitIntent returnedValue = mainWindow.exitIntent;
                switch (returnedValue)
                {
                    case ExitIntent.CLOSE:
                        this.Close();
                        break;
                    case ExitIntent.LOGOUT:
                        this.Show();
                        break;
                }
            }
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
