using System;
using System.Text;

namespace AviaTickets {
    public class Ticket {
        private StringBuilder _ticketInfo = new StringBuilder();
        public string ShowTicketInfo(string firstName, string secondName, string departure, string arrive) {
            _ticketInfo.Append("******************************************************\n");
            _ticketInfo.Append("\t\t Данные вашего билета");
            _ticketInfo.Append("\n******************************************************\n");
            _ticketInfo.Append("******************************************************\n");
            _ticketInfo.Append($"Пассажир: {firstName} {secondName} ");
            _ticketInfo.Append($"От: {departure} \t До: {arrive}");
            _ticketInfo.Append("\n******************************************************");

            return _ticketInfo.ToString();
        }
        
        
    }
}