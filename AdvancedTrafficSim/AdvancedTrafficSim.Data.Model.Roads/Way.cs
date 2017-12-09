using AdvancedTrafficSim.Data.Model.Geographic;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedTrafficSim.Data.Model.Roads
{
    //TODO: Mapper for sections and wayinfos
    public class Way
    {
        public Way(long iD, List<Point> points, List<Section> sections, List<WayInfo> wayInfos, Dictionary<Section, WayInfo> sectionInfos)
        {
            this.ID = iD;
            this.Points = points;
            this.Sections = sections;
            this.WayInfos = wayInfos;
            this.SectionInfos = sectionInfos;
        }

        /// <summary>
        /// Identifies the <see cref="Way"/>
        /// </summary>
        public long ID { get; set; }

        /// <summary>
        /// The ordered <see cref="List{T}"/> of <see cref="Point"/> required to create the <see cref="Way"/>
        /// </summary>
        public List<Point> Points { get; set; }

        /// <summary>
        /// Holds the sections. Every <see cref="Point"/> in <see cref="Points"/> (except start and end point) has to be part of two <see cref="Section"/>. Start and end only one time each.
        /// </summary>
        public List<Section> Sections { get; set; }

        /// <summary>
        /// Holds the <see cref="WayInfo"/> which are used in <see cref="SectionInfos"/>
        /// </summary>
        public List<WayInfo> WayInfos { get; set; }

        /// <summary>
        /// Holds the <see cref="WayInfo"/> per <see cref="Section"/>
        /// </summary>
        public Dictionary<Section, WayInfo> SectionInfos { get; set; }
    }
}
