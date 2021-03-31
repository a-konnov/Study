using System;

namespace AviaTickets {
    internal class Program {
        private static Ticket _ticket = new Ticket();

        public static void Main(string[] args) {
            UserInterface();
            ShowAllCities();
            SelectRouteCities();
            InputPassengerData();
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
                Console.WriteLine(CitiesManager.PrintAllCities());
            }
        }

        private static void SelectRouteCities() {
            Console.WriteLine("Выберите номер города отправления");
            int selectedDepartureNumber = int.Parse(Console.ReadLine());
            string selectedDepartureCity = CitiesManager.AllCitiesInfo[selectedDepartureNumber - 1].Name;
            Console.WriteLine($"Город отправления - {selectedDepartureCity}");
            
            
            Console.WriteLine("Выберите номер города прибытия");
            int selectedArriveNumber = int.Parse(Console.ReadLine());
            string selectedArriveCity = CitiesManager.AllCitiesInfo[selectedArriveNumber - 1].Name;
            Console.WriteLine($"Город прибытия - {selectedArriveCity}");

            var distance = MathCalculations.CalculateDistance(
                CitiesManager.AllCitiesInfo[selectedDepartureNumber - 1].Coordinates.X, 
                CitiesManager.AllCitiesInfo[selectedDepartureNumber - 1].Coordinates.Y, 
                CitiesManager.AllCitiesInfo[selectedArriveNumber - 1].Coordinates.X, 
                CitiesManager.AllCitiesInfo[selectedArriveNumber - 1].Coordinates.Y);
            Console.WriteLine(distance + "km.");

            Console.WriteLine(_ticket.ShowTicketInfo("bb", "dd", selectedDepartureCity, selectedArriveCity));
        }

        private static void InputPassengerData() {
            EnterPassenger enterPassenger = new EnterPassenger();
            
            Console.Write("Имя: ");
            string firstName = Console.ReadLine();
            Console.Write("Фамилия: ");
            string secondName = Console.ReadLine();
            Console.Write("Год рождения: ");
            int yearOfBirth = int.Parse(Console.ReadLine());

            while (!enterPassenger.VerifyInputData(yearOfBirth)) {
                Console.WriteLine("Вы ввели некорректный год рождения. Повторите попытку"); 
                Console.Write("Год рождения: ");
                yearOfBirth = int.Parse(Console.ReadLine());
            }

            enterPassenger.SavePassengerData(firstName, secondName, yearOfBirth);
        }
    }
}