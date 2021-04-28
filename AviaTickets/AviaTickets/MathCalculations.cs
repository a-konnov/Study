using System;

namespace AviaTickets {
    public static class MathCalculations {
        const int EARTH_RADIUS = 6372795;
        const float DEGREE_TO_RADIAN = 3.14f / 180;

        public static double CalculateDistance(float latitudeDeparture, float longitudeDeparture, float latitudeArrive, float longitudeArrive) {
            latitudeDeparture = ConvertToRadian(latitudeDeparture);
            longitudeDeparture = ConvertToRadian(longitudeDeparture);
            latitudeArrive = ConvertToRadian(latitudeArrive);
            longitudeArrive = ConvertToRadian(longitudeArrive);

            var deltaLatitude = Math.Abs(latitudeDeparture - latitudeArrive);
            var deltaLongitude = Math.Abs(longitudeDeparture - longitudeArrive);
            
            var centerAngle = 2 * Math.Asin(Math.Sqrt(Math.Pow(Math.Sin(deltaLatitude / 2), 2) + (Math.Cos(latitudeDeparture) * Math.Cos(latitudeArrive) * Math.Pow(Math.Sin(deltaLongitude / 2), 2)))); // ответ получается в радианах
            var distance = Math.Round(centerAngle * EARTH_RADIUS / 1000); // переводим в километры
            
            return distance;
        }

        private static float ConvertToRadian(float degree) {
            return degree * DEGREE_TO_RADIAN; // по формуле перевода градусов в радианы
        }
    }
}