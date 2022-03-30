using System;
using System.Data;

namespace AviaTickets {
    public class PassengerData {
        public int Id { get; }
        public string FirstName { get; }
        public string SecondName { get; }
        public int YearOfBirth { get; }

        public PassengerData(string firstName, string secondName, int yearOfBirth, int passengerId) {
            Id = passengerId;
            FirstName = firstName;
            SecondName = secondName;

            if (VerifyInputBirthday(yearOfBirth)) {
                YearOfBirth = yearOfBirth;
            } else {
                Console.WriteLine("Incorrect year");
                YearOfBirth = 1920;
            }
        }
        
        public static bool VerifyInputBirthday(int yearOfBirth) {
            DateTime currentDateTime = new DateTime();
            return yearOfBirth > 1920 && yearOfBirth <= currentDateTime.Year;
        }
    }
}