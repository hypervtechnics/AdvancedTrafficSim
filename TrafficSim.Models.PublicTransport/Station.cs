using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficSim.Models.PublicTransport
{
    public class Station
    {
        private long iD;
        private string nameShort;
        private string nameLong;
        private List<Platform> platforms;

        public Station(long iD, string nameShort, string nameLong, List<Platform> platforms)
        {
            ID = iD;
            NameShort = nameShort;
            NameLong = nameLong;
            Platforms = platforms;
        }

        public long ID { get => iD; set => iD = value; }
        public string NameShort { get => nameShort; set => nameShort = value; }
        public string NameLong { get => nameLong; set => nameLong = value; }
        public List<Platform> Platforms { get => platforms; set => platforms = value; }
    }
}
