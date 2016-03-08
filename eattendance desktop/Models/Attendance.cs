using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eattendance_desktop.Models
{
    class Attendance
    {
        private int _attid;
        private String _userid;
        private DateTime _datetime;
        private String _device;
        private String _entryMethod;

        public Attendance(int attid, String userid, DateTime datetime, String device = null, String entryMethod = null)
        {
            this._attid = attid;
            this._userid = userid;
            this._datetime = datetime;
            this._device = device;
            this._entryMethod = entryMethod;
        }

        public Attendance(int attid, String userid, Double unixTimeStamp, String device, String entryMethod)
            : this(attid, userid, Common.UnixTimeStampToDateTime(unixTimeStamp), device, entryMethod) { }

        public Attendance(String userid, DateTime datetime, String device = null, String entryMethod = null) :
            this(-1, userid, datetime, device, entryMethod) { }

        public Attendance(String userid) : this(userid, DateTime.Now) { }

        public Attendance(String userid, Double unixTimeStamp, String device, String entryMethod)
            : this(userid, Common.UnixTimeStampToDateTime(unixTimeStamp), device, entryMethod) { }

        public Attendance(String userid, Double unixTimeStamp)
            : this(userid, Common.UnixTimeStampToDateTime(unixTimeStamp)) { }

        public int attid
        {
            get { return _attid; }
            set { _attid = value; }
        }

        public String userid
        {
            get { return _userid; }
            set { _userid = value; }
        }

        public String device
        {
            get { return _device; }
            set { _device = value; }
        }

        public String entryMethod
        {
            get { return _entryMethod; }
            set { _entryMethod = value; }
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
