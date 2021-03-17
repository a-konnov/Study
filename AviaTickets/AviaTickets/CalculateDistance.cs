using System;

namespace AviaTickets {
    public class CalculateDistance {
        private float _latitudeDepartureCity;
        private float _longitudeDepartureCity;
        
        private float _latitudeArriveCity;
        private float _longitudeArriveCity;
        
        private float _deltaLatitude;
        private float _deltaLongitude;
        
        const int EARTH_RADIUS = 6372795;

        public CalculateDistance(float latitude_A, float longitude_A, float latitude_B, float longitude_B) {
            _latitudeDepartureCity = ConvertToRadian(latitude_A);
            _longitudeDepartureCity = ConvertToRadian(longitude_A);
            _latitudeArriveCity = ConvertToRadian(latitude_B);
            _longitudeArriveCity = ConvertToRadian(longitude_B);

            _deltaLatitude = Math.Abs(_latitudeDepartureCity - _latitudeArriveCity);
            _deltaLongitude = Math.Abs(_longitudeDepartureCity - _longitudeArriveCity);
            
            Console.WriteLine(GetDistanceResult() + " km");
        }

        private float ConvertToRadian(float angle) {
            return angle * (3.14f / 180); // по формуле перевода градусов в радианы
        }

        private double GetSinusAngle(float angle) {
            return Math.Sin(angle);
        }
        
        private double GetCosineAngle(float angle) {
            return Math.Cos(angle);
        }

        private double GetDistanceResult() { //знаю, что формула расчета сложночитаема
            var centerAngle = 2 * Math.Asin(Math.Sqrt(Math.Pow(GetSinusAngle(_deltaLatitude / 2), 2) + (GetCosineAngle(_latitudeDepartureCity) * GetCosineAngle(_latitudeArriveCity) * Math.Pow(GetSinusAngle(_deltaLongitude / 2), 2)))); // ответ получается в радианах
            var distance = Math.Round(centerAngle * EARTH_RADIUS / 1000); // переводим в километры
            return distance;
        }
    }
}