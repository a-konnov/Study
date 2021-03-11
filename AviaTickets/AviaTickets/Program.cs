using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace AviaTickets {
    internal class Program {
        private static Cities _cities = new Cities();
        private static Ticket _ticket = new Ticket();

        public static void Main(string[] args) {
            Cities cities = new Cities();
            UserInterface();
            ShowAllCities();
            SelectRouteCities();
            Console.ReadLine();
        }
        private static void UserInterface() {
            Console.Write("******************************************************\n");
            Console.Write("\t\t Покупка билетов");
            Console.Write("\n******************************************************\n");
        }

        private static void ShowAllCities() {
            Console.WriteLine("Отобразить список доступных городов ?\n 1 - Да \t 0 - Нет");
            int answer = int.Parse(Console.ReadLine());
            if (answer == 1) {
                Console.Clear();
                UserInterface();
                _cities.PrintAllCities();
            }
        }

        private static void SelectRouteCities() {
            Console.WriteLine("Выберите номер города отправления");
            int selectedDepartureNumber = int.Parse(Console.ReadLine());
            string selectedDepartureCity = _cities.AllCitiesInfo[selectedDepartureNumber - 1].Name;
            Console.WriteLine($"Город отправления - {selectedDepartureCity}");
            
            
            Console.WriteLine("Выберите номер города прибытия");
            int selectedArriveNumber = int.Parse(Console.ReadLine());
            string selectedArriveCity = _cities.AllCitiesInfo[selectedArriveNumber - 1].Name;
            Console.WriteLine($"Город прибытия - {selectedArriveCity}");

            new CalculateDistance(_cities.AllCitiesInfo[selectedDepartureNumber - 1].Coordinates.X, _cities.AllCitiesInfo[selectedDepartureNumber - 1].Coordinates.Y, _cities.AllCitiesInfo[selectedArriveNumber - 1].Coordinates.X, _cities.AllCitiesInfo[selectedArriveNumber - 1].Coordinates.Y);
            
            Console.WriteLine(_ticket.ShowTicketInfo("bb", "dd", selectedDepartureCity, selectedArriveCity));
        }
    }
}