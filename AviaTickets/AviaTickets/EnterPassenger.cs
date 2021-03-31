namespace AviaTickets {
    public class EnterPassenger { // Мой предполагаемый Controller из MVC. Для пассажиров
        public void SavePassengerData(string firstName, string secondName, int yearOfBirth) {
            if (VerifyInputData(yearOfBirth)) {
                new PassengerData(firstName, secondName, yearOfBirth);
            }
        }

        public bool VerifyInputData(int yearOfBirth) {
            return yearOfBirth > 1920 && yearOfBirth <= 2021;
        }
    }
}