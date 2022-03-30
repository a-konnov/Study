namespace AviaTickets {
    public class DataLoader {
        public void Load() {
            LoadCities();
            LoadPassengers();
            LoadTickets();
        }

        private void LoadCities() {
            var cityManager = AppFacade.CityManager;
            
            cityManager.AddCity("Moscow", 55.75f, 37.61f, cityManager.GetCitiesCount());
            cityManager.AddCity("New York", 40.71f, -74.00f, cityManager.GetCitiesCount());
            cityManager.AddCity("Madrid", 40.49f, -3.73f, cityManager.GetCitiesCount());
            cityManager.AddCity("Oslo", 59.99f, 10.74f, cityManager.GetCitiesCount());
            cityManager.AddCity("London", 51.75f, -0.23f, cityManager.GetCitiesCount());
            cityManager.AddCity("Tbilisi", 41.87f, 44.72f, cityManager.GetCitiesCount());
        }

        private void LoadPassengers() {
            var passengerManager = AppFacade.PassengerManager;
            
            passengerManager.AddPassenger("Ivan", "Ivanov", 1970, passengerManager.GetPassengersCount());
            passengerManager.AddPassenger("Petr", "Petrov", 1980, passengerManager.GetPassengersCount());
            passengerManager.AddPassenger("Aleksandr", "Aleksandrov", 1990, passengerManager.GetPassengersCount());
            passengerManager.AddPassenger("Alexey", "Alexeev", 2000, passengerManager.GetPassengersCount());
            passengerManager.AddPassenger("Maksim", "Maksimov", 2010, passengerManager.GetPassengersCount());
            passengerManager.AddPassenger("Pavel", "Pavlov", 2020, passengerManager.GetPassengersCount());
        }

        private void LoadTickets() {
            var ticketManager = AppFacade.TicketManager;
            
            ticketManager.AddTicket(0,0,1,ticketManager.GetTicketsCount());
            ticketManager.AddTicket(1,1,2,ticketManager.GetTicketsCount());
            ticketManager.AddTicket(2,2,3,ticketManager.GetTicketsCount());
            ticketManager.AddTicket(3,3,4,ticketManager.GetTicketsCount());
            ticketManager.AddTicket(4,4,5,ticketManager.GetTicketsCount());
            ticketManager.AddTicket(5,5,0,ticketManager.GetTicketsCount());
        }
    }
}