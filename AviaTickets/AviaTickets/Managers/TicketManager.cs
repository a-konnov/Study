using System.Collections.Generic;
using System.Text;

namespace AviaTickets {
    public class TicketManager {
        private Dictionary<int, TicketData> _tickets = new Dictionary<int, TicketData>();
        
        public void AddTicket(TicketData ticketData) { }

        public TicketData GetUserTickets(int ticketID) {
            return _tickets[ticketID];
        }

        public void RemoveTicket(int ticketID) {
            _tickets.Remove(ticketID);
        }
    }
}