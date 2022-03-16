namespace AviaTickets {
    public class DataLoader {
        private CityManager CityManager = new CityManager();
        private PassengerManager PassengerManager = new PassengerManager();
        public TicketManager TicketManager = new TicketManager();

        public void Load() {
            CityManager = new CityManager();
            PassengerManager = new PassengerManager();
            TicketManager = new TicketManager();
            
            LoadCities();
            LoadPassengers();
        }

        private void LoadCities() {
            CityManager.AddCity("Moscow", 55.75f, 37.61f, IdentificationCreator.GenerateNewID());
            CityManager.AddCity("New York", 40.71f, -74.00f, IdentificationCreator.GenerateNewID());
            CityManager.AddCity("Madrid", 40.49f, -3.73f, IdentificationCreator.GenerateNewID());
            CityManager.AddCity("Oslo", 59.99f, 10.74f, IdentificationCreator.GenerateNewID());
            CityManager.AddCity("London", 51.75f, -0.23f, IdentificationCreator.GenerateNewID());
            CityManager.AddCity("Tbilisi", 41.87f, 44.72f, IdentificationCreator.GenerateNewID());
        }

        private void LoadPassengers() {
            PassengerManager.AddPassenger("Ivan", "Ivanov", 1970, IdentificationCreator.GenerateNewID());
            PassengerManager.AddPassenger("Petr", "Petrov", 1980, IdentificationCreator.GenerateNewID());
            PassengerManager.AddPassenger("Aleksandr", "Aleksandrov", 1990, IdentificationCreator.GenerateNewID());
            PassengerManager.AddPassenger("Alexey", "Alexeev", 2000, IdentificationCreator.GenerateNewID());
        }
    }
}