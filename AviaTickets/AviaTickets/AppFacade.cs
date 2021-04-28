using System.Reflection.Emit;

namespace AviaTickets {
    public static class AppFacade {
        public static CitiesManager CitiesManager = new CitiesManager();
        public static TicketManager TicketManager = new TicketManager();
        public static PasssengerManager PasssengerManager = new PasssengerManager();
    }
}