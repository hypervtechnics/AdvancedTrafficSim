using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTrafficSim.Models.PublicTransport
{
    public partial class LineRun
    {
        private List<StationStop> stops;
        private List<LineRoute> routes;
        private long iD;
        private DirectionType direction;

        public LineRun(List<StationStop> stops, List<LineRoute> routes, long iD, DirectionType direction)
        {
            Stops = stops;
            Routes = routes;
            ID = iD;
            Direction = direction;
        }

        public List<StationStop> Stops { get => stops; set => stops = value; }
        public List<LineRoute> Routes { get => routes; set => routes = value; }
        public long ID { get => iD; set => iD = value; }
        internal DirectionType Direction { get => direction; set => direction = value; }
    }
}
