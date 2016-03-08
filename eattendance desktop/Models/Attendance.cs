using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eattendance_desktop.Models
{
    class Attendance
    {
        private String _userid;
        private DateTime _datetime;

        public Attendance(String userid, DateTime datetime)
        {
            this._userid = userid;
            this._datetime = datetime;
        }

        public Attendance(String userid, Double unixTimeStamp): this(userid, Common.UnixTimeStampToDateTime(unixTimeStamp))
        { }


        public String userid
        {
            get { return _userid; }
            set { _userid = value; }
        }

        public DateTime datetime
        {
            get { return _datetime; }
            set { _datetime = value; }
        }

        public Double getTimeStamp()
        {
            return Common.DateTimeToUnixTimeStamp(_datetime);
        }

        public override string ToString()
        {
            return String.Format("{0}: {1}", _userid, _datetime.ToString("u")); 
        }

        public string FullReadable()
        {
            return String.Format("{0}: {1}", _userid, _datetime.ToString("U")); 
        }

        public string ShortReadable()
        {
            return String.Format("{0}: {1}", _userid, _datetime.ToString("hh:mm tt, MMM d")); 
        }
    }
}
