using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTrafficSim.Models.PublicTransport
{
    public class Platform
    {
        private int iD;
        private Coordinates3D coordinates;
        private Dictionary<Vehicles, List<Track>> stopPositions;
        private bool hasShed;
        private bool hasBank;
        private bool hasBin;
        private bool hasBlindLeading;

        public Platform(int iD, Coordinates3D coordinates, Dictionary<Vehicles, List<Track>> stopPosition, bool hasShed, bool hasBank, bool hasBin, bool hasBlindLeading)
        {
            ID = iD;
            Coordinates = coordinates;
            StopPositions = stopPosition;
            HasShed = hasShed;
            HasBank = hasBank;
            HasBin = hasBin;
            HasBlindLeading = hasBlindLeading;
        }

        public int ID { get => iD; set => iD = value; }
        public Coordinates3D Coordinates { get => coordinates; set => coordinates = value; }
        public Dictionary<Vehicles, List<Track>> StopPositions { get => stopPositions; set => stopPositions = value; }
        public bool HasShed { get => hasShed; set => hasShed = value; }
        public bool HasBank { get => hasBank; set => hasBank = value; }
        public bool HasBin { get => hasBin; set => hasBin = value; }
        public bool HasBlindLeading { get => hasBlindLeading; set => hasBlindLeading = value; }
    }
}
