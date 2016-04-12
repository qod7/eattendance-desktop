using eattendance_desktop.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eattendance_desktop
{
    class DatabaseHandler
    {
        public static String APPDIR = AppDomain.CurrentDomain.BaseDirectory;
        private static String DBPATH = APPDIR + "\\data\\eattendance.sqlite";
        private static SQLiteConnection DBCONN;
        // TODO add more here
        private String[] tables = { "loginCredentials", "devices", "attendances", "staffs", "departments"};

        public DatabaseHandler()
        {
            // constructor
        }

        #region general
        /// <summary>
        /// Creates database file if it doesn't exist.
        /// Initializes/Checks tables.
        /// </summary>
        /// <returns></returns>
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
                    // reinitialize DBCONN with set password
                    DBCONN = new SQLiteConnection(String.Format("Data Source={0};Password={1};", DBPATH, Common.dbPass));
                    // now create the tables
                    initTables();
                }
                else
                {
                    // reinitialize DBCONN with set password
                    DBCONN = new SQLiteConnection(String.Format("Data Source={0};Password={1};", DBPATH, Common.dbPass));
                    // database file already exists.
                    checkTableIntegrity();
                }
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
            String sql;
            SQLiteCommand cmd;
            
            // TABLE loginCredentials
            sql = @"CREATE TABLE loginCredentials (
                        name  VARCHAR (64) NOT NULL,
                        token VARCHAR (64) NOT NULL,
                        hash  VARCHAR (64) NOT NULL
                    );";
            cmd = new SQLiteCommand(sql, DBCONN);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            // TABLE devices
            sql = @"CREATE TABLE devices (
                        name    VARCHAR (64) NOT NULL,
                        ip      VARCHAR (64) NOT NULL,
                        port    VARCHAR (64) NOT NULL,
                        remarks VARCHAR (64) NOT NULL,
                        PRIMARY KEY (ip, port)
                    );";
            cmd = new SQLiteCommand(sql, DBCONN);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            // TABLE staffs
            sql = @"CREATE TABLE staffs (
                        name             TEXT     NOT NULL,
                        accountNumber    INTEGER  NOT NULL UNIQUE,
                        password         INTEGER  NOT NULL,
                        privilege        INTEGER  DEFAULT 0,
                        cardNumber       INTEGER,
                        fingerprints     TEXT,
                        email            TEXT,
                        pk               INTEGER,
                        department_id    INTEGER,
                        contact          TEXT,
                        gender           TEXT,
                        address          TEXT,
                        dateOfBirth      INTEGER,
                        image            TEXT,
                        title            TEXT,
                        post             TEXT,
                        dateOfEmployment INTEGER,
                        nationality      TEXT,
                        homeAddress      TEXT,
                        officeTel        TEXT,
                        homeTel          TEXT,
                        mobile1          TEXT,
                        mobile2          TEXT,
                        extras           TEXT
                   );";
            cmd = new SQLiteCommand(sql, DBCONN);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            // TABLE departments
            sql = @"CREATE TABLE departments (
                        id      INTEGER      PRIMARY KEY,
                        name    VARCHAR (64) NOT NULL,
                        pk      INTEGER
                    );";
            cmd = new SQLiteCommand(sql, DBCONN);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            // TABLE attendances
            sql = @"CREATE TABLE attendances (
                    attid       INTEGER      PRIMARY KEY AUTOINCREMENT,
                    userid      VARCHAR (64) NOT NULL,
                    timestamp   INTEGER      NOT NULL,
                    device      VARCHAR (64) NOT NULL,
                    entrymethod VARCHAR (64) NOT NULL
                );";
            cmd = new SQLiteCommand(sql, DBCONN);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            DBCONN.Close();

            // for development purpose. TODO remove this later
            addDummyData();
        }

        public void checkTableIntegrity()
        {
            // this is only executed everytime the app is opened.
            DBCONN.Open();
            SQLiteCommand cmd;
            try
            {
                foreach (String table in tables)
                {
                    cmd = new SQLiteCommand(String.Format("SELECT * FROM {0};", table), DBCONN);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                // You can also check for the columns
                DBCONN.Close();
            }
            catch (SQLiteException)
            {
                DBCONN.Close();
                // maybe the table isn't there. maybe someone tampered with it. just wipe the database
                this.dropAllTables();
                this.initTables();
            }

        }

        public bool clearTables()
        {
            DBCONN.Open();
            SQLiteCommand cmd;
            try
            {
                foreach (String table in tables)
                {
                    cmd = new SQLiteCommand(String.Format("DELETE FROM {0};", table), DBCONN);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                DBCONN.Close();
            }
            return true;
        }

        public bool dropAllTables()
        {
            DBCONN.Open();
            SQLiteCommand cmd;
            try
            {
                foreach (String table in tables)
                {
                    cmd = new SQLiteCommand(String.Format("DROP TABLE IF EXISTS {0};", table), DBCONN);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                DBCONN.Close();
            }
            return true;
        }

        private void addDummyData() 
        {
            // Devices
            this.insertDevice("Main Gate", "192.168.2.130", "4370", "");
            this.insertDevice("Back Gate", "192.168.2.131", "4370", "");
            this.insertDevice("Canteen", "192.168.2.132", "4370", "Shut down for maintenance");
            
            // Staffs
            Staff staff = new Staff("Aaron", 700, 12345678);
            staff.extras.Add("Maiden Name", "Rama Kumari");
            staff.extras.Add("Weight", "80 Kg");
            this.insertStaff(staff);
            this.insertStaff(new Staff("Baron", 701, 12345678));
            this.insertStaff(new Staff("Caron", 702, 12345678));

            // Departments
            this.insertDepartment(new Department(1, "Sales"));
            this.insertDepartment(new Department(2, "Marketing"));
            this.insertDepartment(new Department(3, "Accounts"));

        }
        #endregion

        #region logincredential
        public LoginCredential getLoginCredential()
        {
            LoginCredential loginCredential = null;
            try
            {
                DBCONN.Open();

                String sql = "SELECT * FROM loginCredentials;";

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
                String sqlInsertData = String.Format("INSERT INTO loginCredentials VALUES(\"{0}\", \"{1}\", \"{2}\");", username, hash, token);

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
        public List<Device> getDevicesIntoMemory()
        {
            Common.Devices = new List<Device>();
            try
            {
                DBCONN.Open();

                String sql = "SELECT * FROM devices;";

                SQLiteCommand cmd = new SQLiteCommand(sql, DBCONN);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Common.Devices.Add(new Device((String)reader["name"], ++Common.iMaxDeviceNumber, (String)reader["ip"], 
                        (String)reader["port"], (String)reader["remarks"]));
                }

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
            return Common.Devices;
        }

        public void insertDevice(Device device)
        {
            try
            {
                this.insertDevice(device.name, device.IP, device.port, device.remarks);
            }
            catch
            {
                throw;
            }
        }

        public void insertDevice(String name, String ip, String port, String remarks)
        {
            try
            {
                DBCONN.Open();

                String sql = String.Format("INSERT INTO devices VALUES(\"{0}\", \"{1}\", \"{2}\", \"{3}\");", name, ip, port, remarks);

                SQLiteCommand cmd = new SQLiteCommand(sql, DBCONN);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (SQLiteException ex)
            {
                if (ex.ErrorCode == 19)
                {
                    throw new Exception("A device with same IP:Port combination already exists.", ex);
                }
                else
                {
                    throw new Exception("Error accessing local database", ex);
                }
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

        }

        public Device getDevice(String ip, String port)
        {
            Device device = null;
            try
            {
                DBCONN.Open();

                String sql = String.Format("SELECT * FROM devices WHERE ip=\"{0}\" AND port=\"{1}\";", ip, port);

                SQLiteCommand cmd = new SQLiteCommand(sql, DBCONN);
                SQLiteDataReader r = cmd.ExecuteReader();
                r.Read();
                device = new Device((String)r["name"], (String)r["ip"], (String)r["port"], (String)r["remarks"]);

                cmd.Dispose();
                r.Dispose();
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
            return device;
        }

        public void deleteDevice(String ip, String port)
        {
            try
            {
                DBCONN.Open();

                String sql = String.Format("DELETE FROM devices WHERE ip=\"{0}\" AND port=\"{1}\";", ip, port);

                SQLiteCommand cmd = new SQLiteCommand(sql, DBCONN);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
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
        }
        
        public void deleteAllDevices()
        {
            try
            {
                DBCONN.Open();

                String sql = "DELETE FROM devices;";

                SQLiteCommand cmd = new SQLiteCommand(sql, DBCONN);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
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
        }

        public void updateDevice(Device oldDevice, Device newDevice)
        {
            try
            {
                this.updateDevice(oldDevice.IP, oldDevice.port, newDevice);
            }
            catch
            {
                throw;
            }
        }

        public void updateDevice(String oldIP, String oldPort, Device nd)
        {
            try
            {
                DBCONN.Open();

                String sql = String.Format(@"UPDATE devices SET
                                            name=""{0}"", port=""{1}"", ip=""{2}"", remarks=""{3}""
                                            WHERE ip=""{4}"" and port=""{5}"";", nd.name, nd.port, nd.IP, nd.remarks, oldIP, oldPort);
                SQLiteCommand cmd = new SQLiteCommand(sql, DBCONN);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
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
        }

        #endregion

        #region staff

        public void insertStaff(Staff staff)
        {
            try
            {
                this.insertStaff(staff.name, staff.accountNumber, staff.password, staff.privilege, staff.cardNumber,
                                staff.fingerprints, staff.email, staff.pk, staff.department_id, staff.contact,
                                staff.gender, staff.address, staff.dateOfBirth, staff.image, staff.title, staff.post,
                                staff.dateOfEmployment, staff.nationality, staff.homeAddress, staff.officeTel,
                                staff.homeTel, staff.mobile1, staff.mobile2, staff.extras);
            }
            catch
            {
                throw;
            }
        }

        public void insertStaff(String name, int accountNumber, int password, int privilege = 0, int? cardNumber = null,
                                Dictionary<String, String> fingerprints = null, String email = null, int? pk = null,
                                int? department_id = null, String contact = null, String gender = null,
                                String address = null, DateTime? dateOfBirth = null, String image = null,
                                String title = null, String post = null, DateTime? dateOfEmployment = null,
                                String nationality = null, String homeAddress = null, String officeTel = null,
                                String homeTel = null, String mobile1 = null, String mobile2 = null,
                                Dictionary<String, String> extras = null)
        {
            try
            {
                DBCONN.Open();
                String sql = String.Format(@"INSERT INTO staffs VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}',
                                            '{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}',
                                            '{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}');",
                                            name, accountNumber, password, privilege, cardNumber, Common.DictToJSON(fingerprints), 
                                            email, pk, department_id, contact, gender, address, 
                                            Common.DateTimeToUnixTimeStamp(dateOfBirth), image, title, post,
                                            Common.DateTimeToUnixTimeStamp(dateOfEmployment), nationality, homeAddress, 
                                            officeTel, homeTel, mobile1, mobile2, Common.DictToJSON(extras));
                //sql = sql.Replace("\"\"", "NULL");
                SQLiteCommand cmd = new SQLiteCommand(sql, DBCONN);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (SQLiteException ex)
            {
                if (ex.ErrorCode == 19)
                {
                    throw new Exception("The account number has to be unique. A duplicate already exists. Entry not saved", ex);
                }
                else
                {
                    throw new Exception("Error accessing local database", ex);
                }
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
        }

        public Staff getStaff(int accountNumber)
        {
            Staff staff = null;
            try
            {
                DBCONN.Open();

                String sql = String.Format("SELECT * FROM staffs WHERE accountNumber=\"{0}\";", accountNumber);

                SQLiteCommand cmd = new SQLiteCommand(sql, DBCONN);
                SQLiteDataReader r = cmd.ExecuteReader();
                r.Read();

                staff = new Staff((String)r["name"],
                        Convert.ToInt32(r["accountNumber"]),
                        Convert.ToInt32(r["password"]),
                        Convert.ToInt32(r["privilege"]),
                        Convert.ToInt32(r["cardNumber"]),
                        Common.JSONToDict((String)r["fingerprints"]),
                        (String)r["email"],
                        Convert.ToInt32(r["pk"]),
                        Convert.ToInt32(r["department_id"]),
                        (String)r["contact"],
                        (String)r["gender"],
                        (String)r["address"],
                        Common.UnixTimeStampToDateTime(Convert.ToInt32(r["dateOfBirth"])),
                        (String)r["image"],
                        (String)r["title"],
                        (String)r["post"],
                        Common.UnixTimeStampToDateTime(Convert.ToInt32(r["dateOfEmployment"])),
                        (String)r["nationality"],
                        (String)r["homeAddress"],
                        (String)r["officeTel"],
                        (String)r["homeTel"],
                        (String)r["mobile1"],
                        (String)r["mobile2"],
                        Common.JSONToDict((String)r["extras"]));

                cmd.Dispose();
                r.Dispose();
            }
            catch (Exception ex)
            {
                // SQL exception of something. todo: print exception to log
                System.Diagnostics.Debug.Write(ex.Message);
            }
            finally
            {
                if (DBCONN != null && DBCONN.State != ConnectionState.Closed)
                    DBCONN.Close();
            }
            return staff;
        }

        public List<List<string>> getStaffData(int? dept_id = null)
        {
            List<List<string>> rows = new List<List<string>>();
            try
            {
                DBCONN.Open();
                String sql;
                if (dept_id == null)
                    sql = @"select accountNumber as ""Account No"", name as Name, privilege as Privilege, cardNumber as ""Card Number"", 
                    email as Email, department_id as Department, contact as Contact, gender as Gender, address as Address, title as Title, 
                    post as Post, nationality as Nationality, homeAddress as ""Home Address"", officeTel as ""Office Tel."", 
                    homeTel as ""Home Tel."", mobile1 as Mobile1, mobile2 as Mobile2 from staffs;";
                else
                    sql = String.Format(@"select accountNumber as ""Account No"", name as Name, privilege as Privilege, cardNumber as ""Card Number"", 
                    email as Email, department_id as Department, contact as Contact, gender as Gender, address as Address, title as Title, 
                    post as Post, nationality as Nationality, homeAddress as ""Home Address"", officeTel as ""Office Tel."", 
                    homeTel as ""Home Tel."", mobile1 as Mobile1, mobile2 as Mobile2 from staffs where department_id={0};", dept_id);

                SQLiteCommand cmd = new SQLiteCommand(sql, DBCONN);
                SQLiteDataReader r = cmd.ExecuteReader();
                var columnNames = new List<string>();
                for (int i = 0; i < r.FieldCount; i++)
                {
                    columnNames.Add(r.GetName(i));
                }
                List<string> row;
                while (r.HasRows && r.Read())
                {
                    row = new List<string>();
                    for (int i = 0; i < r.FieldCount; i++)
                    {
                        row.Add(r[columnNames[i]].ToString());
                    }
                    rows.Add(row);
                }
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
            return rows;
        }

        public int getMaxAccountNumber()
        {
            int max = 0;
            try
            {
                DBCONN.Open();

                String sql = "SELECT MAX(accountNumber) FROM staffs;";
                SQLiteCommand cmd = new SQLiteCommand(sql, DBCONN);
                max = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
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
            return max;
        }

        public void deleteStaff(int accountNumber)
        {
            try
            {
                // Delete the staff image
                Staff staff = getStaff(accountNumber);
                if (staff.image != null)
                    File.Delete(staff.image);
            }
            catch { }
            try
            {
                DBCONN.Open();

                // Now remove the record
                String sql = String.Format("DELETE FROM staffs WHERE accountNumber=\"{0}\";", accountNumber);

                SQLiteCommand cmd = new SQLiteCommand(sql, DBCONN);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
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
        }

        public void deleteAllStaffs()
        {
            try
            {
                // delete all images
                Directory.Delete(APPDIR + "\\data\\images", true);

                // now delete all records
                DBCONN.Open();

                String sql = "DELETE FROM staffs;";

                SQLiteCommand cmd = new SQLiteCommand(sql, DBCONN);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
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
        }

        public void updateStaff(Staff oldStaff, Staff newStaff)
        {
            try
            {
                this.updateStaff(oldStaff.accountNumber, newStaff);
            }
            catch
            {
                throw;
            }
        }

        public void updateStaff(int accountNumber, Staff newStaff)
        {
            Staff staff = newStaff;
            try
            {
                DBCONN.Open();

                String sql = String.Format(@"UPDATE staffs SET
                                            name = '{1}',
                                            password = '{2}',
                                            privilege = '{3}',
                                            cardNumber = '{4}',
                                            fingerprints = '{5}',
                                            email = '{6}',
                                            pk = '{7}',
                                            department_id = '{8}',
                                            contact = '{9}',
                                            gender = '{10}',
                                            address = '{11}',
                                            dateOfBirth = '{12}',
                                            image = '{13}',
                                            title = '{14}',
                                            post = '{15}',
                                            dateOfEmployment = '{16}',
                                            nationality = '{17}',
                                            homeAddress = '{18}',
                                            officeTel = '{19}',
                                            homeTel = '{20}',
                                            mobile1 = '{21}',
                                            mobile2 = '{22}',
                                            extras = '{23}'
                                            WHERE accountNumber='{0}';",
                                            accountNumber, staff.name, staff.password, staff.privilege, staff.cardNumber,
                                            Common.DictToJSON(staff.fingerprints), staff.email, staff.pk, staff.department_id, 
                                            staff.contact, staff.gender, staff.address, 
                                            Common.DateTimeToUnixTimeStamp(staff.dateOfBirth), staff.image, 
                                            staff.title, staff.post, Common.DateTimeToUnixTimeStamp(staff.dateOfEmployment), 
                                            staff.nationality, staff.homeAddress, 
                                            staff.officeTel, staff.homeTel, staff.mobile1, staff.mobile2, Common.DictToJSON(staff.extras));

                SQLiteCommand cmd = new SQLiteCommand(sql, DBCONN);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
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
        }

        #endregion

        #region department

        public void insertDepartment(Department department)
        {
            try
            {
                this.insertDepartment(department.id, department.name, department.pk);
            }
            catch
            {
                throw;
            }
        }

        public void insertDepartment(int id, string name, int? pk)
        {
            try
            {
                DBCONN.Open();

                String sql = String.Format("INSERT INTO departments VALUES(\"{0}\", \"{1}\", \"{2}\");", id, name, pk);

                SQLiteCommand cmd = new SQLiteCommand(sql, DBCONN);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (SQLiteException ex)
            {
                if (ex.ErrorCode == 19)
                {
                    throw new Exception("A department with same id already exists.", ex);
                }
                else
                {
                    throw new Exception("Error accessing local database", ex);
                }
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

        }

        public int getMaxDepartmentID()
        {
            int max = 0;
            try
            {
                DBCONN.Open();

                String sql = "SELECT MAX(id) FROM departments;";
                SQLiteCommand cmd = new SQLiteCommand(sql, DBCONN);
                max = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
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
            return max;
        }

        public List<Department> getDepartments()
        {
            List<Department> departments = new List<Department>();
            try
            {
                DBCONN.Open();

                String sql = "SELECT * FROM departments;";

                SQLiteCommand cmd = new SQLiteCommand(sql, DBCONN);
                SQLiteDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    departments.Add(new Department(Convert.ToInt32(r["id"]), 
                        (String)r["name"], Convert.ToInt32(r["pk"])));
                }
                cmd.Dispose();
                r.Dispose();
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
            return departments;
        }

        public Department getDepartment(int id)
        {
            Department department = null;
            try
            {
                DBCONN.Open();

                String sql = String.Format("SELECT * FROM departments WHERE id=\"{0}\";", id);

                SQLiteCommand cmd = new SQLiteCommand(sql, DBCONN);
                SQLiteDataReader r = cmd.ExecuteReader();
                r.Read();
                department = new Department(Convert.ToInt32(r["id"]), (String)r["name"], Convert.ToInt32(r["pk"]));

                cmd.Dispose();
                r.Dispose();
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
            return department;
        }

        public void deleteDepartment(int id)
        {
            try
            {
                DBCONN.Open();

                String sql = String.Format("DELETE FROM departments WHERE id=\"{0}\";", id);

                SQLiteCommand cmd = new SQLiteCommand(sql, DBCONN);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                // update staffs for the deleted department
                sql = String.Format("UPDATE staffs SET department_id='' where department_id={0};", id);

                cmd = new SQLiteCommand(sql, DBCONN);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
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
        }

        public void deleteAllDepartments()
        {
            try
            {
                DBCONN.Open();

                String sql = "DELETE FROM departments;";

                SQLiteCommand cmd = new SQLiteCommand(sql, DBCONN);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                // update staffs for the deleted department
                sql = "UPDATE staffs SET department_id='';";

                cmd = new SQLiteCommand(sql, DBCONN);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
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
        }

        public void updateDepartment(Department oldDepartment, Department newDepartment)
        {
            try
            {
                this.updateDepartment(oldDepartment.id, newDepartment);
            }
            catch
            {
                throw;
            }
        }

        public void updateDepartment(int id, Department nd)
        {
            try
            {
                DBCONN.Open();

                String sql = String.Format(@"UPDATE departments SET
                                            name=""{0}"", pk=""{1}""
                                            WHERE id=""{2}"";", nd.name, nd.pk, id);
                SQLiteCommand cmd = new SQLiteCommand(sql, DBCONN);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
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
        }

        #endregion

        #region attendances
        public List<Attendance> getAttendances()
        {
            List<Attendance> attendances = new List<Attendance>();
            try
            {
                DBCONN.Open();

                String sql = "SELECT * FROM attendances;";

                SQLiteCommand cmd = new SQLiteCommand(sql, DBCONN);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    attendances.Add(new Attendance(reader.GetInt32(0), reader.GetString(1), reader.GetInt64(2),
                        reader.GetString(3), reader.GetString(4)));
                }

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
            return attendances;
        }

        public void insertAttendance(Attendance attendance)
        {
            try
            {
                DBCONN.Open();
                String sql = String.Format("INSERT INTO attendances (userid, timestamp, device, entrymethod) VALUES(\"{0}\", {1}, \"{2}\", \"{3}\");",
                    attendance.userid, Common.DateTimeToUnixTimeStamp(attendance.datetime), attendance.device, attendance.entryMethod);

                SQLiteCommand cmd = new SQLiteCommand(sql, DBCONN);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (SQLiteException ex)
            {
                throw new Exception("Error accessing local database", ex);
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

        }

        public void deleteAllAttendances()
        {
            try
            {
                DBCONN.Open();

                String sql = String.Format("DELETE FROM attendances;");

                SQLiteCommand cmd = new SQLiteCommand(sql, DBCONN);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
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
        }

        public void deleteAttendance(int attendanceID)
        {
            try
            {
                DBCONN.Open();

                String sql = String.Format("DELETE FROM attendances WHERE attid={0};", attendanceID);

                SQLiteCommand cmd = new SQLiteCommand(sql, DBCONN);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
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
        }

        public void deleteAttendance(Attendance attendance)
        {
            try
            {
                deleteAttendance(attendance.attid);
            }
            catch
            {
                throw;
            }
        }

        #endregion

    }
}
