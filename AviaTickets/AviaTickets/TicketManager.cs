using System.Collections.Generic;
using System.Text;

namespace AviaTickets {
    public class TicketManager {
        private string _devidingLine = "******************************************************";
        private StringBuilder _ticketInfo = new StringBuilder();

        public static Dictionary<int, TicketInfo> tickets = new Dictionary<int, TicketInfo>();

        private static List<TicketInfo> _allTicketsInfo;
        public static List<TicketInfo> AllTicketsInfo {
            get {
                if (_allTicketsInfo == null) {
                    _allTicketsInfo = new List<TicketInfo>() {
                        new TicketInfo("Ivan", "Ivanov", "Moscow", "London", 1234.1234)
                    };
                }
                return _allTicketsInfo;
            }
        }
        public string ShowTicketInfo(string firstName, string secondName, string departure, string arrive) {
            _ticketInfo.Append("\t\t Данные вашего билета");
            
            _ticketInfo.Append($"\n{_devidingLine}\n");
            _ticketInfo.Append($"Пассажир: {firstName} {secondName} ");
            _ticketInfo.Append($"От: {departure} \t До: {arrive}");
            _ticketInfo.Append($"Расстояние:  \t Время в пути: ");
            _ticketInfo.Append($"\n{_devidingLine}");

            return _ticketInfo.ToString();
        }
        
        public static void AddTicket(string firstName, string secondName, string departure, string arrive, double distance) {
            AllTicketsInfo.Add(new TicketInfo(firstName, secondName, departure, arrive, distance));
            tickets.Add(tickets.Count + 1, new TicketInfo(firstName, secondName, departure, arrive, distance));
        }
        
        public static void RemoveTicket(int id) {
            AllTicketsInfo.Remove(AllTicketsInfo[id - 1]);
        }
    }
}