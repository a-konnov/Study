using System;
using System.Collections.Generic;

namespace AviaTickets {
    public class Cities {
        private string _name;
        private int _xCoordinate;
        private int _yCoordinate;
        
        public int numberOfCity = 1;
        
        public List<string> ListCities = new List<string>() {
            "Moscow",
            "New York",
            "Madrid",
            "Oslo",
            "London",
            "Tbilisi"
        };

        private void GetRouteData() {
            Console.Write("Откуда:");
            string _departure = Console.ReadLine();
            Console.Write("Куда:");
            string _destination = Console.ReadLine();
        }

        public void PrintAllCities() {
            
            foreach (var city in ListCities) {
                Console.WriteLine($"{numberOfCity} - {city}");
                numberOfCity++;
            }
        }
    }
}