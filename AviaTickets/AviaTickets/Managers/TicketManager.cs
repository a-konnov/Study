using System;
using System.Collections.Generic;
using System.Text;

namespace AviaTickets {
    public class TicketManager {
        private readonly Dictionary<int, TicketData> _tickets = new Dictionary<int, TicketData>();

        private PassengerManager _passengerManager = AppFacade.PassengerManager;
        private CityManager _cityManager = AppFacade.CityManager;

        public void AddTicket(int passengerId, int departureCityId, int arriveCityId, int ticketId) {
            TicketData newTicketData = new TicketData(passengerId, departureCityId, arriveCityId, ticketId);
            
        }
        
        public bool HasData(int ticketId) {
            return _tickets.ContainsKey(ticketId);
        }

        public TicketData GetData(int ticketId) {
            return _tickets.ContainsKey(ticketId) ? _tickets[ticketId] : null;
        }
        
        public int GetTicketsCount() {
            return _tickets.Count;
        }
        
        public void PrintData(int ticketId) {
            var ticketData = _tickets[ticketId];
            
            var passengerData = _passengerManager.GetData(ticketData.PassengerId);
            var departureCityData = _cityManager.GetData(ticketData.DepartureCityId);
            var arrivalCityData = _cityManager.GetData(ticketData.ArrivalCityId);
            var distance = _cityManager.GetDistance(ticketData.DepartureCityId, ticketData.ArrivalCityId);

            Console.WriteLine($"Passenger: {passengerData.FirstName} {passengerData.SecondName} \n " +
                              $"Year Of Birth: {passengerData.YearOfBirth} \n " +
                              $"DepartureCity: {departureCityData.Name} \n " +
                              $"ArrivalCity: {arrivalCityData.Name} \n " +
                              $"Distance: {distance}");
        }
    }
}