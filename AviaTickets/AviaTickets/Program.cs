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
            string selectedDepartureCity = _cities.ListCities[selectedDepartureNumber - 1];
            Console.WriteLine($"Город отправления - {selectedDepartureCity}");
            
            Console.WriteLine("Выберите номер города прибытия");
            int selectedArriveNumber = int.Parse(Console.ReadLine());
            string selectedArriveCity = _cities.ListCities[selectedArriveNumber - 1];
            Console.WriteLine($"Город прибытия - {selectedArriveCity}");
            
            _ticket.TicketInfo("bb", "dd", selectedDepartureCity, selectedArriveCity);
        }
    }
}