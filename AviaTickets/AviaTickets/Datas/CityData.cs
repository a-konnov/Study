﻿using System;
using System.Numerics;

namespace AviaTickets {
    public class CityData {
        public int Id { get; }
        public string Name { get; }
        public float Latitude { get; }
        public float Longitude { get; }
        
        public CityData(string name, float latitude, float longitude, int id) {
            Latitude = latitude;
            Longitude = longitude;
            Name = name;
            Id = id;
        }
    }
}