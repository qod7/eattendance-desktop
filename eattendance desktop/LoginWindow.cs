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
                saveLoginInfoToSqliteDB(username, token, hash);
                // now allow login, if no exception was thrown
                attemptLogin();
            }
            catch
            {
                // Exception messages have already been shown. Just smile and ignore. 
                return;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void saveLoginInfoToSqliteDB(String username, String token, String hash)
        {
            String DBPath = Application.StartupPath + "\\data\\eattendance.sqlite";
            SQLiteConnection dbConn = null;
            try
            {
                dbConn = new SQLiteConnection(String.Format("Data Source={0};Password={1};", DBPath, Common.dbPass));
                dbConn.Open();

                String sqlEmptyTable = "delete from loginCredentials";
                String sqlInsertData = String.Format("insert into loginCredentials values(\"{0}\", \"{1}\", \"{2}\");", username, token, hash);

                SQLiteCommand cmdEmptyTable = new SQLiteCommand(sqlEmptyTable, dbConn);
                cmdEmptyTable.ExecuteNonQuery();
                cmdEmptyTable.Dispose();

                SQLiteCommand cmdInsertData = new SQLiteCommand(sqlInsertData, dbConn);
                cmdInsertData.ExecuteNonQuery();
                cmdInsertData.Dispose();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error accessing local database");
                throw ex;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "Database has been tampered with");
                throw ex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Some error occurred");
                throw ex;
            }
            finally
            {
                if (dbConn != null && dbConn.State != ConnectionState.Closed)
                    dbConn.Close();
            }
        }

        private void initializeDatabase(String DBPath)
        {
            // this is only executed right after the database file is created.

            SQLiteConnection dbConn = new SQLiteConnection("Data Source=" + DBPath);
            dbConn.Open();

            // first set the password
            dbConn.ChangePassword(Common.dbPass);

            // now create tables
            String sqlCreateTable = "create table loginCredentials (name varchar(64) not null, token varchar(64) not null, hash varchar(64) not null);";
            SQLiteCommand cmdCreateTable = new SQLiteCommand(sqlCreateTable, dbConn);
            cmdCreateTable.ExecuteNonQuery();
            cmdCreateTable.Dispose();

            dbConn.Close();

        }

        private void attemptLogin()
        {
            Cursor = Cursors.WaitCursor;
            // Check if local database exists
            String DBPath = Application.StartupPath + "\\data\\eattendance.sqlite";
            if (!Directory.Exists(Application.StartupPath + "\\data"))
                Directory.CreateDirectory(Application.StartupPath + "\\data");
            if (!File.Exists(DBPath))
            {
                SQLiteConnection.CreateFile(DBPath);
                initializeDatabase(DBPath);
            }
            // Check local database for credentials and tokens
            SQLiteConnection dbConn = null;
            try
            {
                dbConn = new SQLiteConnection(String.Format("Data Source={0};Password={1};", DBPath, Common.dbPass));
                dbConn.Open();

                String sqlGetData = "select * from loginCredentials;";

                SQLiteCommand cmdGetData = new SQLiteCommand(sqlGetData, dbConn);
                SQLiteDataReader reader = cmdGetData.ExecuteReader();
                // save credentials // validate if necessary TODO?
                reader.Read();
                Common.username = reader["name"].ToString();
                Common.token = reader["token"].ToString();
                //System.Diagnostics.Debug.Write("Name: " + Common.username + "\tToken: " + Common.token);

                cmdGetData.Dispose();
                reader.Dispose();
                // finally allow login()
                login();
            }
            catch
            {
                // No database file present, no table present, or no data in table, or database corrupted.
                // In any case, no need to log in
                // if not logged_in, show this window
                this.Opacity = 1;
            }
            finally
            {
                if (dbConn != null && dbConn.State != ConnectionState.Closed)
                    dbConn.Close();
                Cursor = Cursors.Default;
            }
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
