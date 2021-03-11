using System.Numerics;

namespace AviaTickets {
    public class TownInfo {
        public string Name;
        public Vector2 Coordinates; // в десятичные градусы

        public TownInfo(string name, float latitude, float longitude) {
            Coordinates.X = latitude;
            Coordinates.Y = longitude;
            Name = name;
        }
    }
}