namespace AviaTickets {
    public class TicketData {
        public int PassengerId { get; }
        public int DepartureCityId { get; }
        public int ArriveCityId { get; }
        public int DistanceId { get; }
        public int Id { get; }

        public TicketData(int passengerId, int departureCityId, int arriveCityId, int distanceId, int ticketId) {
            PassengerId = passengerId;
            DepartureCityId = departureCityId;
            ArriveCityId = arriveCityId;
            DistanceId = distanceId;
            Id = ticketId;
        }
        
        public override string ToString() {
            return $"Пассажир: {PassengerId} \n Город отправления:{DepartureCityId} \n Город прибытия: {ArriveCityId} \n Расстояние: {DistanceId}";
        }
    }
}