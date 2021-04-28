namespace AviaTickets {
    public class TicketInfo {
        public string FirstName { get; }
        public string SecondName { get; }
        public string Departure { get; }
        public string Arrive { get; }
        public double Distance { get; }

        public TicketInfo(string firstName, string secondName, string departure, string arrive, double distance) {
            FirstName = firstName;
            SecondName = secondName;
            Departure = departure;
            Arrive = arrive;
            Distance = distance;
        }
    }
}