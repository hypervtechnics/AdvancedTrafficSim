using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedTrafficSim.Data.Model.Geographic
{
    public class Point
    {
        public Point(long iD, double x, double y, double z = double.NaN)
        {
            this.ID = iD;
            this.X = x;
            this.Y = y;
            this.Z = (z == double.NaN ? new double?() : z);
        }

        /// <summary>
        /// Identifies the <see cref="Point"/> (combination of X, Y, Z is unique)
        /// </summary>
        public long ID { get; set; }

        /// <summary>
        /// The x coordinate
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// The y coordinate
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// The z coordinate, if given
        /// </summary>
        public double? Z { get; set; }
    }
}
