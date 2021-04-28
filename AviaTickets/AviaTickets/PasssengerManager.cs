namespace AviaTickets {
    public class PasssengerManager { // Мой предполагаемый Controller из MVC. Для пассажиров
        public PasssengerManager Init() {
            return new PasssengerManager();
        }
        
        public void SavePassengerData(string firstName, string secondName, int yearOfBirth) {
            if (PassengerData.VerifyInputBirthday(yearOfBirth)) {
                new PassengerData(firstName, secondName, yearOfBirth);
            }
        }
    }
}