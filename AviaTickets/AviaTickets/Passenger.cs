using System;

namespace AviaTickets {
    
    public class GetPassengerData {
        private static void PersonalData() {
            Console.Write("Имя: ");
            string _firstName = Console.ReadLine();
            
            Console.Write("Фамилия: ");
            string _secondName = Console.ReadLine();
            
            Console.Write("Год рождения: ");
            int _yearOfBirth = int.Parse(Console.ReadLine());

            while (_yearOfBirth < 1920) {
                Console.WriteLine("Вы ввели некорректный год рождения. Повторите попытку");
                Console.Write("Год рождения: ");
                _yearOfBirth = int.Parse(Console.ReadLine());
            }
            while (_yearOfBirth > 2021) {
                Console.WriteLine("Вы ввели некорректный год рождения. Повторите попытку");
                Console.Write("Год рождения: ");
                _yearOfBirth = int.Parse(Console.ReadLine());
            }
        }
    }
}