using System.Text;

namespace AviaTickets {
    public class Ticket {
        private string _devidingLine = "******************************************************";
        private StringBuilder _ticketInfo = new StringBuilder();
        public string ShowTicketInfo(string firstName, string secondName, string departure, string arrive) {
            _ticketInfo.Append("\t\t Данные вашего билета");
            
            _ticketInfo.Append($"\n{_devidingLine}\n");
            _ticketInfo.Append($"Пассажир: {firstName} {secondName} ");
            _ticketInfo.Append($"От: {departure} \t До: {arrive}");
            _ticketInfo.Append($"\n{_devidingLine}");

            return _ticketInfo.ToString();
        }
    }
}