using System;
using System.Numerics;

namespace AviaTickets {
    public class CityData {
        public string Name { get; }
        public float Latitude { get; }
        public float Longitude { get; }

        public CityData(string name, float latitude, float longitude) {
            Latitude = latitude;
            Longitude = longitude;
            Name = name;
        }
    }
}