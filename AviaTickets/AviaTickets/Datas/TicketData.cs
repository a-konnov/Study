namespace AviaTickets {
    public class TicketData {
        public PassengerData Passenger { get; }
        public CityData DepartureCity { get; }
        public CityData ArriveCity { get; }
        public double Distance { get; }

        public TicketData(PassengerData passenger, CityData departureCity, CityData arriveCity, double distance) {
            Passenger = passenger;
            DepartureCity = departureCity;
            ArriveCity = arriveCity;
            Distance = distance;
        }
    }
}