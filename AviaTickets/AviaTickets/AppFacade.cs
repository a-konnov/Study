using System.Reflection.Emit;

namespace AviaTickets {
    public static class AppFacade {
        public static CityManager CityManager = new CityManager();
        public static TicketManager TicketManager = new TicketManager();
        public static PassengerManager PassengerManager = new PassengerManager();
    }
}