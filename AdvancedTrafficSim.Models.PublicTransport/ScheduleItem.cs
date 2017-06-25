using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTrafficSim.Models.PublicTransport
{
    public class ScheduleItem
    {
        private ScheduleTime startTime;
        private int lineRunID;
        private long iD;

        public ScheduleItem(ScheduleTime startTime, int lineRunID, long iD)
        {
            StartTime = startTime;
            LineRunID = lineRunID;
            ID = iD;
        }

        public ScheduleTime StartTime { get => startTime; set => startTime = value; }
        public int LineRunID { get => lineRunID; set => lineRunID = value; }
        public long ID { get => iD; set => iD = value; }
    }
}
