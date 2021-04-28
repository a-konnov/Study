using System.Collections.Generic;
using System.Text;

namespace AviaTickets {
    public class TicketManager {
        private string _devidingLine = "******************************************************";
        private StringBuilder _ticketInfo = new StringBuilder();

        public static Dictionary<int, TicketInfo> tickets = new Dictionary<int, TicketInfo>();

        public static List<TicketInfo> AllTicketsInfo;
        
        public void Init() {
            AllTicketsInfo = new List<TicketInfo>() {
                new TicketInfo("Ivan", "Ivanov", "Moscow", "London", 1234.1234)
            };
        }
        
        public string ShowTicketInfo(string firstName, string secondName, string departure, string arrive, double distance) {
            _ticketInfo.Append("\t\t Данные вашего билета");
            
            _ticketInfo.Append($"\n{_devidingLine}\n");
            _ticketInfo.Append($"Пассажир: {firstName} {secondName} ");
            _ticketInfo.Append($"\nОт: {departure} \t До: {arrive}");
            _ticketInfo.Append($"\tРасстояние: {distance} km. \t Время в пути: ");
            _ticketInfo.Append($"\n{_devidingLine}");

            return _ticketInfo.ToString();
        }
        
        public void AddTicket(string firstName, string secondName, string departure, string arrive, double distance) {
            AllTicketsInfo.Add(new   TicketInfo(firstName, secondName, departure, arrive, distance));
            tickets.Add(tickets.Count + 1, new TicketInfo(firstName, secondName, departure, arrive, distance));
        }
        
        public void RemoveTicket(int id) {
            AllTicketsInfo.Remove(AllTicketsInfo[id - 1]);
        }
    }
}