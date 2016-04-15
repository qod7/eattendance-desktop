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

using System.Reflection;
using System.Data.SQLite;
using eattendance_desktop.Models;

namespace eattendance_desktop
{
    public partial class LoginWindow : Form
    {
        DatabaseHandler DB = new DatabaseHandler();
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginWindow_Shown(object sender, EventArgs e)
        {
            attemptLogin();
            // Additional: if certain number of days has past since last server communication,
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
            try
            {
                DB.setLoginCredential(username, token, hash);
                // now allow login, if no exception was thrown
                attemptLogin();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                // todo: print error to log

                throw ex;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void attemptLogin()
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                Common.loginCredential = DB.getLoginCredential();
                // finally allow login() if everything went alright
                login();
            }
            catch
            {
                // No database file present, no table present, or no data in table, or database corrupted.
                // In any case, no need to log in; show login window now
                this.Opacity = 1;
            }
            Cursor = Cursors.Default;
        }

        private void login()
        {
            this.Hide();

            // TODO remove this block later
            //(new Forms.StaffsWindow()).ShowDialog();
            //return;
            
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
                        this.Opacity = 1;
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
