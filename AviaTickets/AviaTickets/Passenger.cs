using System;

namespace AviaTickets {
    public class Passenger {
        public string _firstName;
        public string _secondName;
        public int _yearOfBirth;

        public Passenger(string firstName, string secondName, int yearOfBirth) {
            _firstName = firstName;
            _secondName = secondName;
            _yearOfBirth = yearOfBirth;
        }
    }
}