using System;

namespace AdvancedTrafficSim.Data.Model.Geographic
{
    public class Area
    {
        private Line mShape = null;

        public Area(long iD, Line shape)
        {
            this.ID = iD;
            this.Shape = shape;
        }

        /// <summary>
        /// Identifies the <see cref="Area"/>
        /// </summary>
        public long ID { get; set; }

        /// <summary>
        /// Gives you the <see cref="Line"/> which represents the shape of the area. If you set a <see cref="Line"/> where start and end points are not the same and there are more than 2 points the last one is added automatically.
        /// </summary>
        public Line Shape
        {
            get => mShape;

            set
            {
                if (value.Points.Count > 2)
                {
                    //Check if start == end point
                    //TODO: Implement == and != operator in Point to prevent reference comparison
                    if (value.Points[0] != value.Points[value.Points.Count - 1])
                    {
                        value.Points.Add(value.Points[0]);
                    }

                    mShape = value;
                }
                else
                {
                    throw new ArgumentException("Not a valid line.");
                }
            }
        }
    }
}
