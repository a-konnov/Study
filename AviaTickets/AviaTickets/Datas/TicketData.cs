namespace AviaTickets {
    public class TicketData {
        public int Id { get; }
        public int PassengerId { get; }
        public int DepartureCityId { get; }
        public int ArrivalCityId { get; }
        
        public TicketData(int passengerId, int departureCityId, int arrivalCityId, int ticketId) {
            PassengerId = passengerId;
            DepartureCityId = departureCityId;
            ArrivalCityId = arrivalCityId;
            Id = ticketId;
        }
    }
}