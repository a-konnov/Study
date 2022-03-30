using System;
using System.Collections.Generic;

namespace AviaTickets {
    public class PassengerManager {
        private Dictionary<int, PassengerData> _passengers = new Dictionary<int, PassengerData>();

        public void AddPassenger(string firstName, string secondName, int yearOfBirth, int passengerId) {
            var newPassengerData = new PassengerData(firstName, secondName, yearOfBirth, passengerId);
            _passengers.Add(passengerId, newPassengerData);
        }
        public bool HasData(int passengerId) {
            return _passengers.ContainsKey(passengerId);
        }

        public PassengerData GetData(int passengerId) {
            return _passengers.ContainsKey(passengerId) ? _passengers[passengerId] : null;
        }
        
        public int GetPassengersCount() {
            return _passengers.Count;
        }
        
        public void PrintData(int passengerId) {
            var passengerData = _passengers[passengerId];
            
            Console.WriteLine($"Passenger: {passengerData.FirstName} {passengerData.SecondName} \n Year Of Birth: {passengerData.YearOfBirth}");
        }
    }
}