using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            login();
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
            // Validate with Server
            Cursor = Cursors.WaitCursor;
                // TODO run some api calls with handlers
                // TODO save credentials and token to database
            // now allow login
            Cursor = Cursors.Default;
            login();
        }

        private void login()
        {
            this.Hide();
            var mainWindow = new MainWindow();
            mainWindow.Closed += (s, args) => this.Close();
            mainWindow.Show();
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
