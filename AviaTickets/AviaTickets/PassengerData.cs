namespace AviaTickets {
    public class PassengerData { // Моя предполагаемая Model из MVC. Для пассажиров  
        public string _firstName { get; private set; }
        public string _secondName { get; private set; }
        public int _yearOfBirth { get; private set; }

        public PassengerData(string firstName, string secondName, int yearOfBirth) {
            _firstName = firstName;
            _secondName = secondName;
            _yearOfBirth = yearOfBirth;
        }
    }
}