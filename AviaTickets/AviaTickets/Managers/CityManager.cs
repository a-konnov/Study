using System;
using System.Collections.Generic;

namespace AviaTickets {
    public class CityManager {
        private Dictionary<int, CityData> Cities = new Dictionary<int, CityData>();

        private int cityID = 1;

        public void AddCity(CityData cityData) {
            Cities.Add(cityID, cityData);

            cityID++;
        }

        public CityData GetCityInfo(int cityID) {
            return Cities[cityID];
        }

        public void RemoveCity(int cityID) {
            Cities.Remove(cityID);
        }
    }
}