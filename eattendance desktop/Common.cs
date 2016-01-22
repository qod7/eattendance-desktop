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
    }

    public enum ExitIntent { CLOSE, LOGOUT }
}
