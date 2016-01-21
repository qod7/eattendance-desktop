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

        private void saveLoginInfoToSqliteDB(String username, String token, String hash) {
            String DBPath = Application.StartupPath + "\\data\\eattendance.sqlite";
            SQLiteConnection dbConn = null;
            try
            {
                if (!Directory.Exists(Application.StartupPath + "\\data"))
                    Directory.CreateDirectory(Application.StartupPath + "\\data");
                SQLiteConnection.CreateFile(DBPath);
                dbConn = new SQLiteConnection("Data Source=" + DBPath);
                dbConn.Open();

                String sqlCreateTable = "create table loginCredentials (name varchar(64) not null, token varchar(64) not null, hash varchar(64) not null);";
                String sqlEmptyTable = "delete from loginCredentials";
                String sqlInsertData = String.Format("insert into loginCredentials values(\"{0}\", \"{1}\", \"{2}\");", username, token, hash);
                
                SQLiteCommand cmdCreateTable = new SQLiteCommand(sqlCreateTable, dbConn);
                cmdCreateTable.ExecuteNonQuery();
                cmdCreateTable.Dispose();

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

        static void DbConnection_SqlListeners(string sql)
        {
            Console.WriteLine("SQL: " + sql);
            Console.WriteLine("");
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

        private void attemptLogin()
        {
            Cursor = Cursors.WaitCursor;
            // TODO: Check local database for credentials and tokens
            String DBPath = Application.StartupPath + "\\data\\eattendance.sqlite";
            SQLiteConnection dbConn = null;
            try
            {
                dbConn = new SQLiteConnection("Data Source=" + DBPath);
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
