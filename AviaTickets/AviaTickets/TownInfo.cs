using System;
using System.Numerics;

namespace AviaTickets {
    public class TownInfo {
        public string Name { get; }
        public float Latitude { get; private set; }
        public float Longitude { get; private set; }

        public TownInfo(string name, float latitude, float longitude) {
            Latitude = latitude;
            Longitude = longitude;
            Name = name;
        }
    }
}