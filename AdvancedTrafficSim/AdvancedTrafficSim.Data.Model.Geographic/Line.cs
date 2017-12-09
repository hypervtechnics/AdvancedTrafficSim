using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedTrafficSim.Data.Model.Geographic
{
    public class Line
    {
        public Line(long iD, List<Point> points)
        {
            this.ID = iD;
            this.Points = points;
        }

        /// <summary>
        /// Identifies the <see cref="Line"/>
        /// </summary>
        public long ID { get; set; }

        /// <summary>
        /// Ordered <see cref="List{T}"/> with points
        /// </summary>
        public List<Point> Points { get; set; }
    }
}
