using System;

namespace AviaTickets {
    public class Ticket {
        public void TicketInfo(string firstName, string secondName, string departure, string destination) {
            string _firstName = firstName;
            string _secondName = secondName;
            string _departure = departure;
            string _destination = destination;

            Console.Clear();
            Console.Write("******************************************************\n");
            Console.WriteLine($"Пассажир: {_firstName} {_secondName} ");
            Console.WriteLine($"От: {_departure} \t До: {_destination}");
            Console.Write("\n******************************************************");
        }
    }
}