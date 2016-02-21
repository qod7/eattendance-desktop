using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace eattendance_desktop
{
    class Common
    {
        public static String username;
        public static String token;

        public static List<Device> Devices = new List<Device>();
        public static int iMaxDeviceNumber = 0;
        public static DataGridViewCellStyle OnlineStyle = new DataGridViewCellStyle();
        public static DataGridViewCellStyle OfflineStyle = new DataGridViewCellStyle();
        public static DataGridViewCellStyle BoldCellStyle = new DataGridViewCellStyle();

        public static Regex ipRegex = new Regex(@"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
        public static Regex portRegex = new Regex(@"^0*(?:6553[0-5]|655[0-2][0-9]|65[0-4][0-9]{2}|6[0-4][0-9]{3}|[1-5][0-9]{4}|[1-9][0-9]{1,3}|[0-9])$");

        public static String dbPass = "";

        public static String[] UserPrivilege = new String[] { "User", "Enroller", "Administrator", "Super Administrator"};
        public static String[] VerifyMethods = new String[] { "Password", "Fingerprint", "Card" };
        public static String[] MultiVerifyMethods = new String[] {"FP_OR_PW_OR_RF", "FP", "PIN", "PW", "RF", "FP_OR_PW", "FP_OR_RF", "PW_OR_RF", 
            "PIN_AND_FP", "FP_AND_PW", "FP_AND_RF", "PW_AND_RF", "FP_AND_PW_AND_RF", "PIN_AND_FP_AND_PW", "FP_AND_RF_OR_PIN"};
    }

    public enum ExitIntent { CLOSE, LOGOUT }
}
