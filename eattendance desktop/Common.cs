using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eattendance_desktop
{
    class Common
    {
        public static List<Device> Devices = new List<Device>();
        public static int iMaxDeviceNumber = 0;
        public static DataGridViewCellStyle OnlineStyle = new DataGridViewCellStyle();
        public static DataGridViewCellStyle OfflineStyle = new DataGridViewCellStyle();
    }
}
