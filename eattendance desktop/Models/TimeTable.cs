using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eattendance_desktop.Models
{
    class TimeTable
    {
        public TimeSpan from;
        public TimeSpan to;

        public int offsetFrom;
        public int offsetTo;

        public int offsetUnit { get; set;  }

        public TimeTable(TimeSpan from, TimeSpan to)
        {
            this.from = from;
            this.to = to;

            this.offsetFrom = 0;
            this.offsetTo = 0;
            this.offsetUnit = -1;
        }

        public int OffsetFrom
        {
            get { return offsetFrom; }
            set { 
                offsetFrom = value;

                if (offsetUnit == -1) offsetUnit = OFFSET_MINUTES;
            }
        }

        public int OffsetTo
        {
            get { return offsetTo; }
            set
            {
                offsetTo = value;

                if (offsetUnit == -1) offsetUnit = OFFSET_MINUTES;
            }
        }
        
        public static const int OFFSET_MINUTES = 1,
            OFFSET_HOURS = 2;

    }
}
