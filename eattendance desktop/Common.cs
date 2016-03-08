using eattendance_desktop.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace eattendance_desktop
{
    static class Common
    {
        #region GLOBAL CONSTANTS
        public static DataGridViewCellStyle OnlineStyle = new DataGridViewCellStyle() { 
            BackColor = Color.LightGreen,
            SelectionBackColor = Color.LightGreen
        };
        public static DataGridViewCellStyle OfflineStyle = new DataGridViewCellStyle() {
            BackColor = Color.LightSlateGray,
            SelectionBackColor = Color.LightSlateGray
        };
        public static DataGridViewCellStyle BoldCellStyle = new DataGridViewCellStyle() {
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold)
        };

        public static Regex ipRegex = new Regex(@"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
        public static Regex portRegex = new Regex(@"^0*(?:6553[0-5]|655[0-2][0-9]|65[0-4][0-9]{2}|6[0-4][0-9]{3}|[1-5][0-9]{4}|[1-9][0-9]{1,3}|[0-9])$");


        public static String[] UserPrivilege = new String[] { "User", "Enroller", "Administrator", "Super Administrator"};
        public static String[] VerifyMethods = new String[] { "Password", "Fingerprint", "Card" };
        public static String[] MultiVerifyMethods = new String[] {"FP_OR_PW_OR_RF", "FP", "PIN", "PW", "RF", "FP_OR_PW", "FP_OR_RF", "PW_OR_RF", 
            "PIN_AND_FP", "FP_AND_PW", "FP_AND_RF", "PW_AND_RF", "FP_AND_PW_AND_RF", "PIN_AND_FP_AND_PW", "FP_AND_RF_OR_PIN"};
        #endregion

        #region PRIVATE FUNCTIONS
        private static String generateDbPass()
        {
            var md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            var sha1 = new System.Security.Cryptography.SHA1CryptoServiceProvider();

            var md5data = md5.ComputeHash(System.Text.Encoding.ASCII.GetBytes(Common.ipRegex.ToString()));
            var md6data = md5.ComputeHash(sha1.ComputeHash(System.Text.Encoding.ASCII.GetBytes(Common.portRegex.ToString())));
            var sha2data = md5.ComputeHash(md5data.Concat(md6data).ToArray());

            return Convert.ToBase64String(sha2data);
        }
        #endregion

        #region GLOBAL PARAMETERS
        public static LoginCredential loginCredential;

        public static String dbPass = ""; //generateDbPass();

        public static List<Device> Devices = null;
        public static int iMaxDeviceNumber = 0;
        #endregion

        #region UTILITY FUNCTIONS
        public static double DateTimeToUnixTimeStamp(DateTime dateTime)
        {
            return (TimeZoneInfo.ConvertTimeToUtc(dateTime) -
                   new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc)).TotalSeconds;
        }

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            return (new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc))
                .AddSeconds(unixTimeStamp).ToLocalTime();
        }
        #endregion
    }

    public enum ExitIntent { CLOSE, LOGOUT }
}
