using eattendance_desktop.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eattendance_desktop
{
    class DatabaseHandler
    {
        private static String APPDIR = AppDomain.CurrentDomain.BaseDirectory;
        private static String DBPATH = APPDIR + "\\data\\eattendance.sqlite";
        private static SQLiteConnection DBCONN;

        public DatabaseHandler()
        {
            // constructor
        }

        #region general
        public bool initDatabase() {
            try
            {
                // create database if not exists
                if (!Directory.Exists(APPDIR + "\\data"))
                    Directory.CreateDirectory(APPDIR + "\\data");
                if (!File.Exists(DBPATH))
                {
                    SQLiteConnection.CreateFile(DBPATH);
                    // set DB connection object
                    DBCONN = new SQLiteConnection("Data Source=" + DBPATH);
                    // set DB password
                    DBCONN.Open();
                    DBCONN.ChangePassword(Common.dbPass);
                    DBCONN.Close();
                    // now create the tables
                    initTables();
                }
                else
                {
                    // database file already exists.
                    // TODO check database integrity
                        // delete and initDatabase() if needed
                }
                // reinitialize DBCONN with set password
                DBCONN = new SQLiteConnection(String.Format("Data Source={0};Password={1};", DBPATH, Common.dbPass));
            }
            catch (Exception ex)
            {
                // TODO write ex into logs
                System.Diagnostics.Debug.Write(ex.Message);
                return false;
            }
            return true;
        }

        public void initTables()
        {
            // this is only executed right after the new database file is created.
            DBCONN.Open();
            SQLiteCommand cmd;
            
            // TABLE loginCredentials
            String sql = "create table loginCredentials (name varchar(64) not null, token varchar(64) not null, hash varchar(64) not null);";
            cmd = new SQLiteCommand(sql, DBCONN);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            // TABLE devices

            // TABLE users

            // TABLE usergroups
            
            DBCONN.Close();
        }

        public bool clearTables()
        {
            // execute delete * from tables
            return true;
        }
        #endregion

        #region logincredential
        public LoginCredential getLoginCredential()
        {
            LoginCredential loginCredential = null;
            try
            {
                DBCONN.Open();

                String sql = "select * from loginCredentials;";

                SQLiteCommand cmd = new SQLiteCommand(sql, DBCONN);
                SQLiteDataReader reader = cmd.ExecuteReader();
                reader.Read();

                loginCredential = new LoginCredential(reader["name"].ToString(),
                    reader["hash"].ToString(), reader["token"].ToString());

                cmd.Dispose();
                reader.Dispose();
            }
            catch (Exception ex)
            {
                // SQL exception of something. todo: print exception to log
                System.Diagnostics.Debug.Write(ex.Message);
                throw;
            }
            finally
            {
                if (DBCONN != null && DBCONN.State != ConnectionState.Closed)
                    DBCONN.Close();
            }
            return loginCredential;
        }

        public bool setLoginCredential(LoginCredential loginCredential)
        {
            try
            {
                return setLoginCredential(loginCredential.username, loginCredential.hash, loginCredential.token);
            }
            catch
            {
                throw;
            }
        }
        public bool setLoginCredential(String username, String hash, String token)
        {
            try
            {
                // clear old credentials if any (must only have one record max)
                this.clearLoginCredential();

                DBCONN.Open();
                String sqlInsertData = String.Format("insert into loginCredentials values(\"{0}\", \"{1}\", \"{2}\");", username, hash, token);

                SQLiteCommand cmdInsertData = new SQLiteCommand(sqlInsertData, DBCONN);
                cmdInsertData.ExecuteNonQuery();
                cmdInsertData.Dispose();
            }
            catch (IOException ex)
            {
                System.Diagnostics.Debug.Write(ex.Message);
                throw new Exception("Error accessing local database", ex);
            }
            catch (SQLiteException ex)
            {
                System.Diagnostics.Debug.Write(ex.Message);
                throw new Exception("Database has been tampered with", ex);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message);
                throw new Exception("Some error occurred", ex);
            }
            finally
            {
                if (DBCONN != null && DBCONN.State != ConnectionState.Closed)
                    DBCONN.Close();
            }
            return true;
        }

        public bool clearLoginCredential()
        {
            try
            {
                DBCONN.Open();
                String sqlEmptyTable = "delete from loginCredentials";
                SQLiteCommand cmdEmptyTable = new SQLiteCommand(sqlEmptyTable, DBCONN);
                cmdEmptyTable.ExecuteNonQuery();
                cmdEmptyTable.Dispose();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (DBCONN != null && DBCONN.State != ConnectionState.Closed)
                    DBCONN.Close();
            }
            return true;
        }
        #endregion

        #region devices
        #endregion

        #region user
        #endregion

    }
}
