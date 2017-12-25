using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedTrafficSim.Data.Model.Roads
{
    public class WayInfo
    {
        public int Type { get; set; }
        public Dictionary<string, string> Tags { get; set; }
    }
}
