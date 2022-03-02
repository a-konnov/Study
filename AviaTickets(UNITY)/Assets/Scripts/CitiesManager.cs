using System;
using System.Collections.Generic;

namespace AviaTickets {
    public class CitiesManager {
        public List<CityInfo> AllCitiesInfo = new List<CityInfo>() {
            new CityInfo("Moscow", 56.09410195361169f, 37.84530536044455f),
            new CityInfo("New York", 40.718744217455395f, -74.007840764363f),
            new CityInfo("Madrid", 40.49287589129243f, -3.7369265373655787f),
            new CityInfo("Oslo", 59.997046969420914f, 10.748720954716243f),
            new CityInfo("London", 51.75730281069607f, -0.23045256277914639f),
            new CityInfo("Tbilisi", 41.878758218043686f, 44.72068437454439f)
        };

        public Dictionary<string, CityInfo> CitiesList = new Dictionary<string, CityInfo>();

        public string GetCitiesList1() {
            var numberOfCity = 1;
            var cityName = "";
            foreach (var city in AllCitiesInfo) {
                cityName += numberOfCity + ". " + city.Name + "\n";
                numberOfCity++;
            }
            return cityName;
        }

        public string GetCitiesList() {
            var listNumber = 1;
            var cityName = "";
            foreach (var city in CitiesList) {
                cityName += $"{listNumber}. {city.Value.Name} \n";
                listNumber++;
            }
            return cityName;
        }

        public void AddCity(string name, float latitude, float longitude) {
            var newCityID = IdentificationCreator.GenerateNewCityID(name, latitude, longitude);
            //AllCitiesInfo.Add(new TownInfo(name, latitude, longitude));

            if (!IsCityAlreadyAdded(newCityID)) {
                CitiesList.Add(newCityID, new CityInfo(name, latitude, longitude));
            } else {
                Console.WriteLine("Город уже существует в списке");
            }

        }
        
        public void RemoveCity(int id) {
            AllCitiesInfo.Remove(AllCitiesInfo[id - 1]);
        }

        private bool IsCityAlreadyAdded(string cityID) {
            return CitiesList.ContainsKey(cityID);
        }
    }
}