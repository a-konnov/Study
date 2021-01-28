using System;

namespace AviaTickets {
    public class Cities {
        private string _name;
        private int _xCoordinate;
        private int _yCoordinate;

        private void GetRouteData() {
            Console.Write("Откуда:");
            string _departure = Console.ReadLine();
            Console.Write("Куда:");
            string _destination = Console.ReadLine();
        }
    }
}