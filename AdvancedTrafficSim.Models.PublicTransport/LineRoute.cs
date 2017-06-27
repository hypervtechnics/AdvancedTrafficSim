using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTrafficSim.Models.PublicTransport
{
    public class LineRoute
    {
        private List<Track> route;
        private int timeNeeded;
        private long startStationStopID;
        private long targetStationStopID;

        public LineRoute(List<Track> route, int timeNeeded, long startStationStopID, long targetStationStopID)
        {
            Route = route;
            TimeNeeded = timeNeeded;
            StartStationStopID = startStationStopID;
            TargetStationStopID = targetStationStopID;
        }

        public List<Track> Route { get => route; set => route = value; }
        public int TimeNeeded { get => timeNeeded; set => timeNeeded = value; }
        public long StartStationStopID { get => startStationStopID; set => startStationStopID = value; }
        public long TargetStationStopID { get => targetStationStopID; set => targetStationStopID = value; }
    }
}
