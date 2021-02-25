using System;

namespace AviaTickets {
    public class Ticket {
        public void TicketInfo(string firstName, string secondName, string departure, string destination) {
            Console.Clear();
            Console.Write("******************************************************\n");
            Console.Write("\t\t Данные вашего билета");
            Console.Write("\n******************************************************\n");
            Console.Write("******************************************************\n");
            Console.WriteLine($"Пассажир: {firstName} {secondName} ");
            Console.WriteLine($"От: {departure} \t До: {destination}");
            Console.Write("\n******************************************************");
        }
    }
}