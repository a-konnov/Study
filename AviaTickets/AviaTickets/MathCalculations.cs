using System;

namespace AviaTickets {
    public static class MathCalculations {
        const int EARTH_RADIUS = 6372795;

        public static double CalculateDistance(float latitude_Departure, float longitude_Departure, float latitude_Arrive, float longitude_Arrive) {
            latitude_Departure = ConvertToRadian(latitude_Departure);
            longitude_Departure = ConvertToRadian(longitude_Departure);
            latitude_Arrive = ConvertToRadian(latitude_Arrive);
            longitude_Arrive = ConvertToRadian(longitude_Arrive);

            var deltaLatitude = Math.Abs(latitude_Departure - latitude_Arrive);
            var deltaLongitude = Math.Abs(longitude_Departure - longitude_Arrive);
            
            var centerAngle = 2 * Math.Asin(Math.Sqrt(Math.Pow(Math.Sin(deltaLatitude / 2), 2) + (Math.Cos(latitude_Departure) * Math.Cos(latitude_Arrive) * Math.Pow(Math.Sin(deltaLongitude / 2), 2)))); // ответ получается в радианах
            var distance = Math.Round(centerAngle * EARTH_RADIUS / 1000); // переводим в километры
            
            return distance;
        }

        private static float ConvertToRadian(float angle) {
            return angle * (3.14f / 180); // по формуле перевода градусов в радианы
        }
    }
}