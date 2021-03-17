using System;

namespace AviaTickets {
    public class EnterPassengerData {
        public string _firstName;
        public string _secondName;
        public int _yearOfBirth;
        
        public void SavePassengerData(string firstName, string secondName, int yearOfBirth) {
            _firstName = firstName;
            _secondName = secondName;
            
            Passenger passenger = new Passenger(_firstName, _secondName, _yearOfBirth);
        }

        public bool VerifyInputData(int yearOfBirth) {
            _yearOfBirth = yearOfBirth;
            if (_yearOfBirth < 1920 || _yearOfBirth > 2021) {
                return false;
            }
            return true;
        }
    }
}