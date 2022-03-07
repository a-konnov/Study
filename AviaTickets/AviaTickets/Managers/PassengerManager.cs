using System.Collections.Generic;

namespace AviaTickets {
    public class PassengerManager {
        private Dictionary<int, PassengerData> Passengers = new Dictionary<int, PassengerData>();

        private int _passengerID = 1;

        public void AddPassenger(PassengerData passengerData) {
            Passengers.Add(_passengerID, passengerData);

            _passengerID++;
        }

        public PassengerData GetPassengerInfo(int passengerID) {
            return Passengers[passengerID];
        }

        public void RemovePassenger(int passengerID) {
            Passengers.Remove(passengerID);
        }
    }
}