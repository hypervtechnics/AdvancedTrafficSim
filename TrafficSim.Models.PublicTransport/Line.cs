using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficSim.Models.PublicTransport
{
    public class Line
    {
        private string label;
        private long iD;
        private bool regularLine;
        private VehicleType vehicle;
        private LineRun direction1;
        private LineRun direction2;

        public Line(string label, long iD, bool regularLine, VehicleType vehicle, LineRun direction1, LineRun direction2)
        {
            Label = label;
            ID = iD;
            RegularLine = regularLine;
            Vehicle = vehicle;
            Direction1 = direction1;
            Direction2 = direction2;
        }

        public string Label { get => label; set => label = value; }
        public long ID { get => iD; set => iD = value; }
        public bool RegularLine { get => regularLine; set => regularLine = value; }
        public VehicleType Vehicle { get => vehicle; set => vehicle = value; }
        public LineRun Direction1 { get => direction1; set => direction1 = value; }
        public LineRun Direction2 { get => direction2; set => direction2 = value; }
    }
}
