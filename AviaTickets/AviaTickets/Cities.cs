using System;
using System.Collections.Generic;

namespace AviaTickets {
    public class Cities {
        public List<TownInfo> AllCitiesInfo = new List<TownInfo>() {
            new TownInfo("Moscow", 56.09410195361169f, 37.84530536044455f), 
            new TownInfo("New York", 40.718744217455395f, -74.007840764363f), 
            new TownInfo("Madrid", 40.49287589129243f, -3.7369265373655787f),
            new TownInfo("Oslo", 59.997046969420914f, 10.748720954716243f), 
            new TownInfo("London", 51.75730281069607f, -0.23045256277914639f), 
            new TownInfo("Tbilisi", 41.878758218043686f, 44.72068437454439f) 
        };

        public void PrintAllCities() {
             int numberOfCity = 1;
            foreach (var city in AllCitiesInfo) {
                Console.WriteLine($"{numberOfCity} - {city.Name}");
                numberOfCity++;
            }
        }
    }
}