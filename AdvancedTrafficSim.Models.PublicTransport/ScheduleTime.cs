using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTrafficSim.Models.PublicTransport
{
    public class ScheduleTime
    {
        private int day, hour, minute;

        public ScheduleTime(int day, int hour, int minute)
        {
            Day = day;
            Hour = hour;
            Minute = minute;
        }

        public int Day { get => day; set => day = value; }
        public int Hour { get => hour; set => hour = value; }
        public int Minute { get => minute; set => minute = value; }
    }
}
