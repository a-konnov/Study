using System;
using System.Collections.Generic;

namespace AviaTickets {
    public class CityManager {
        private readonly Dictionary<int, CityData> _cities = new Dictionary<int, CityData>();

        public void AddCity(string name, float latitude, float longitude, int id) {
            CityData newCityData = new CityData(name, latitude, longitude, id);
            _cities.Add(id, newCityData);
        }

        public bool HasData(int cityId) {
            return _cities.ContainsKey(cityId);
        }
        
        public CityData GetData(int cityId) {
            return _cities.ContainsKey(cityId) ? _cities[cityId] : null;
        }

        public int GetCitiesCount() {
            return _cities.Count;
        }

        public void GetAvailableCitiesList() {
            int counter = 1;
            foreach (var city in _cities) {
                Console.WriteLine($"{counter}. {city.Value.Name}");
                counter++;
            }
        }

        public double GetDistance(int departureCityId, int arriveCityId) {
            var departureCity = _cities[departureCityId];
            var arriveCity = _cities[arriveCityId];
            var distance = MathCalculations.CalculateDistance(departureCity.Longitude, departureCity.Latitude, arriveCity.Longitude, arriveCity.Latitude);

            return distance;
        }

        public void PrintData(int cityId) {
            var cityData = _cities[cityId];
            
            Console.WriteLine($"City: {cityData.Name} \n Coordinates: {cityData.Latitude}{cityData.Longitude}");
        }
    }
}