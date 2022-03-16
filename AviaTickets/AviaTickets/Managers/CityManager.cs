using System;
using System.Collections.Generic;

namespace AviaTickets {
    public class CityManager {
        private readonly Dictionary<int, CityData> _cities = new Dictionary<int, CityData>();

        public void AddCity(string name, float latitude, float longitude, int id) {
            CityData newCityData = new CityData(name, latitude, longitude, id);
            if (!IsCityAlreadyAdded(newCityData)) {
                _cities.Add(id, newCityData);
            } else {
                throw new Exception("This city is already added");
            }
        }

        public CityData GetData(int cityId) {
            return _cities.ContainsKey(cityId) ? _cities[cityId] : throw new Exception("Doesn't contains this ID");
        }

        public void RemoveCity(int cityId) {
            if (_cities.ContainsKey(cityId)) {
                _cities.Remove(cityId);
            }

            throw new Exception("Doesn't contains this ID");
        }

        private bool IsCityAlreadyAdded(CityData cityData) {
            foreach (var addedCity in _cities) {
                if (cityData.Latitude == addedCity.Value.Latitude && cityData.Longitude == addedCity.Value.Longitude) {
                    return true;
                }
            }

            return false;
        }
    }
}