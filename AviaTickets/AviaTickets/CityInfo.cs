using System;
using System.Numerics;

namespace AviaTickets {
    public class CityInfo {
        public string Name { get; }
        public float Latitude { get; private set; }
        public float Longitude { get; private set; }

        public CityInfo(string name, float latitude, float longitude) {
            Latitude = latitude;
            Longitude = longitude;
            Name = name;
        }
    }
}