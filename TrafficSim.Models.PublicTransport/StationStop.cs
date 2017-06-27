using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficSim.Models.PublicTransport
{
    public class StationStop
    {
        private long stationID;
        private int stayForMinutes;
        private int platformID;
        private long iD;

        public StationStop(long stationID, int stayForMinutes, int platformID, long iD)
        {
            StationID = stationID;
            StayForMinutes = stayForMinutes;
            PlatformID = platformID;
            ID = iD;
        }

        public long StationID { get => stationID; set => stationID = value; }
        public int StayForMinutes { get => stayForMinutes; set => stayForMinutes = value; }
        public int PlatformID { get => platformID; set => platformID = value; }
        public long ID { get => iD; set => iD = value; }
    }
}
