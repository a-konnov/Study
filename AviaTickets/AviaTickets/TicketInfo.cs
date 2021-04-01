namespace AviaTickets {
    public class TicketInfo {
        public string FirstName { get; private set; }
        public string SecondName { get; private set; }
        public string Departure { get; private set; }
        public string Arrive { get; private set; }
        public double Distance { get; private set; }

        public TicketInfo(string firstName, string secondName, string departure, string arrive, double distance) {
            FirstName = firstName;
            SecondName = secondName;
            Departure = departure;
            Arrive = arrive;
            Distance = distance;
        }
    }
}