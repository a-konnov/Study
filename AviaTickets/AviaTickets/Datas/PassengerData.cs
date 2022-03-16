using System;
using System.Data;

namespace AviaTickets {
    public class PassengerData {
        public string FirstName { get; }
        public string SecondName { get; }
        public int YearOfBirth { get; }
        public int Id { get; }

        public PassengerData(string firstName, string secondName, int yearOfBirth, int passengerId) {
            FirstName = firstName;
            SecondName = secondName;

            if (VerifyInputBirthday(yearOfBirth)) {
                YearOfBirth = yearOfBirth;
            } else {
                throw new Exception("Doesn't contains this ID");
            }
            
            Id = passengerId;
        }
        
        public static bool VerifyInputBirthday(int yearOfBirth) {
            DateTime currentDateTime = new DateTime();
            return yearOfBirth > 1920 && yearOfBirth <= currentDateTime.Year;
        }
    }
}