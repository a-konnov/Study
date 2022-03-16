using System;
using System.Collections.Generic;

namespace AviaTickets {
    public class PassengerManager {
        private Dictionary<int, PassengerData> _passengers = new Dictionary<int, PassengerData>();

        public void AddPassenger(string firstName, string secondName, int yearOfBirth, int passengerId) {
            var newPassengerData = new PassengerData(firstName, secondName, yearOfBirth, passengerId);
            _passengers.Add(passengerId, newPassengerData);
        }

        public PassengerData GetData(int passengerID) {
            return _passengers.ContainsKey(passengerID) ? _passengers[passengerID] : throw new Exception("Doesn't contains this ID");
        }

        public void RemovePassenger(int passengerID) {
            _passengers.Remove(passengerID);
            if (_passengers.ContainsKey(passengerID)) {
                _passengers.Remove(passengerID);
            }

            throw new Exception("Doesn't contains this ID");
        }
    }
}