namespace AviaTickets {
    public class PassengerData { // Моя предполагаемая Model из MVC. Для пассажиров  
        public string FirstName { get; }
        public string SecondName { get; }
        public int YearOfBirth { get; }

        public PassengerData(string firstName, string secondName, int yearOfBirth) {
            FirstName = firstName;
            SecondName = secondName;
            YearOfBirth = yearOfBirth;
        }
        
        public static bool VerifyInputBirthday(int yearOfBirth) {
            return yearOfBirth > 1920 && yearOfBirth <= 2021;
        }
        
        
    }
}