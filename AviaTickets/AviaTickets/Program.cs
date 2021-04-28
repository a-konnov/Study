using System;

namespace AviaTickets {
    internal class Program {
        private static InputData _inputData = new InputData();
        public static void Main(string[] args) {
            UserInterface();
            ShowAllCities();
            SelectRouteCities();
            InputPassengerData();
            SaveInputDataInTicket();
            Console.ReadLine();
        }
        private static void UserInterface() {
            Console.Write("******************************************************\n");
            Console.Write("\t\t Покупка билетов");
            Console.Write("\n******************************************************\n");
        }

        private static void ShowAllCities() {
            Console.WriteLine("Отобразить список доступных городов ?\n 1 - Да \t 0 - Нет");
            var answer = int.Parse(Console.ReadLine());
            if (answer == 1) {
                Console.Clear();
                UserInterface();
                Console.WriteLine(AppFacade.CitiesManager.GetCitiesList());
            }
        }

        private static void SelectRouteCities() {
            Console.WriteLine("Выберите номер города отправления");
            var selectedDepartureNumber = int.Parse(Console.ReadLine());
            var selectedDepartureCity = AppFacade.CitiesManager.AllCitiesInfo[selectedDepartureNumber - 1].Name;
            _inputData.SelectedDepartureCity = selectedDepartureCity;
            Console.WriteLine($"Город отправления - {selectedDepartureCity}");
            
            
            Console.WriteLine("Выберите номер города прибытия");
            var selectedArrivalNumber = int.Parse(Console.ReadLine());
            var selectedArrivalCity = AppFacade.CitiesManager.AllCitiesInfo[selectedArrivalNumber - 1].Name;
            _inputData.SelectedArrivalCity = selectedArrivalCity;
            Console.WriteLine($"Город прибытия - {selectedArrivalCity}");

            var departureCoordinats = AppFacade.CitiesManager.AllCitiesInfo[selectedDepartureNumber - 1];
            var arrivalCoordinats = AppFacade.CitiesManager.AllCitiesInfo[selectedArrivalNumber - 1];
            
            var distance = MathCalculations.CalculateDistance(
                departureCoordinats.Coordinates.X, 
                departureCoordinats.Coordinates.Y,
                arrivalCoordinats.Coordinates.X, 
                arrivalCoordinats.Coordinates.Y);
            _inputData.Distance = distance;
        }

        private static void InputPassengerData() {
            Console.Write("Имя: ");
            var firstName = Console.ReadLine();
            _inputData.FirstName = firstName;
            
            Console.Write("Фамилия: ");
            var secondName = Console.ReadLine();
            _inputData.SecondName = secondName;
            
            Console.Write("Год рождения: ");
            var yearOfBirth = int.Parse(Console.ReadLine());

            while (!PassengerData.VerifyInputBirthday(yearOfBirth)) {
                Console.WriteLine("Вы ввели некорректный год рождения. Повторите попытку");
                Console.Write("Год рождения: ");
                yearOfBirth = int.Parse(Console.ReadLine());
                _inputData.YearOfBirth = yearOfBirth;
            }
            
            AppFacade.PasssengerManager.Init().SavePassengerData(firstName, secondName, yearOfBirth);
        }

        private static void SaveInputDataInTicket() {
            var ticket = AppFacade.TicketManager.ShowTicketInfo(_inputData.FirstName, _inputData.SecondName, _inputData.SelectedDepartureCity, _inputData.SelectedArrivalCity, _inputData.Distance);
            Console.WriteLine(ticket);
        }
    }
}