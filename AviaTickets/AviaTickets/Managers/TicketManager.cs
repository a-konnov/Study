using System;
using System.Collections.Generic;
using System.Text;

namespace AviaTickets {
    public class TicketManager {
        private readonly Dictionary<int, TicketData> _tickets = new Dictionary<int, TicketData>();

        public void AddTicket(int passengerId, int departureCityId, int arriveCityId, int distanceId, int ticketId) {
            TicketData newTicketData = new TicketData(passengerId, departureCityId, arriveCityId, distanceId, ticketId);
        }

        public TicketData GetData(int ticketId) {
            return _tickets.ContainsKey(ticketId) ? _tickets[ticketId] : throw new Exception("Doesn't contains this ID");
        }

        public void RemoveTicket(int ticketId) {
            if (_tickets.ContainsKey(ticketId)) {
                _tickets.Remove(ticketId);
            }

            throw new Exception("Doesn't contains this ID");
        }
    }
}