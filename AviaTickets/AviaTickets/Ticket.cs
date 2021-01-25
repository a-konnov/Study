using System;

namespace AviaTickets {
    public class Ticket {
        public void TicketInfo(string name, string surname, int yearOfBirth) {
            string _name = name;
            string _surname = surname;
            int _yearOfBirth = yearOfBirth;
            
            Console.WriteLine($"******************************************************\n Пассажир: {_name} {_surname} \n******************************************************");
        }
    }
}