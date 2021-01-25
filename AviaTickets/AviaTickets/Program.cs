using System;

namespace AviaTickets {
    internal class Program {
        public static void Main(string[] args) {
            UserInterface();
            PersonData();
            Console.ReadLine();
        }

        private static void UserInterface() {
            Console.WriteLine("******************************************************\n\t\t Покупка билетов  \n******************************************************");
            //Console.WriteLine("Ведите ИМЯ, ФАМИЛИЮ и ГОД РОЖДЕНИЯ");
        }

        private static void PersonData() {
            Console.Write("Имя: ");
            string _name = Console.ReadLine();
            
            Console.Write("Фамилия: ");
            string _surname = Console.ReadLine();
            
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
            
            Ticket ticket = new Ticket();
            ticket.TicketInfo(_name, _surname, _yearOfBirth);
        }
    }
}