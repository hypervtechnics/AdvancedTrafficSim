using AdvancedTrafficSim.Data.Model.Geographic;
using System;

namespace AdvancedTrafficSim.Data.Model.Roads
{
    public class Section
    {
        public Section(long iD, Point first, Point second)
        {
            this.ID = iD;
            this.First = first;
            this.Second = second;
        }

        /// <summary>
        /// Identifies the <see cref="Section"/> inside of <see cref="Way"/> (not globally)
        /// </summary>
        public long ID { get; set; }

        /// <summary>
        /// The starting point of section
        /// </summary>
        public Point First { get; set; }

        /// <summary>
        /// The end point of section
        /// </summary>
        public Point Second { get; set; }
    }
}
