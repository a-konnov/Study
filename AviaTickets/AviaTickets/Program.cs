using System;

namespace AviaTickets {
    internal class Program {
        public static void Main(string[] args) {
            UserInterface();
            Console.ReadLine();
        }

        private static void UserInterface() {
            Console.Write("******************************************************\n");
            Console.Write("\t\t Покупка билетов");
            Console.Write("\n******************************************************\n");
            //Console.WriteLine("Ведите ИМЯ, ФАМИЛИЮ и ГОД РОЖДЕНИЯ");
        }
    }
}