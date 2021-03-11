using System;

namespace AviaTickets {
    public class CalculateDistance {
        public float LatitudeDepartureCity;
        public float LongitudeDepartureCity;
        
        public float LatitudeArriveCity;
        public float LongitudeArriveCity;

        public CalculateDistance(float latitude_A, float longitude_A, float latitude_B, float longitude_B) {
            LatitudeDepartureCity = ConvertToRadian(latitude_A);
            LongitudeDepartureCity = ConvertToRadian(longitude_A);
            LatitudeArriveCity = ConvertToRadian(latitude_B);
            LongitudeArriveCity = ConvertToRadian(longitude_B);

            Console.WriteLine(Calcul() + " km");
        }

        private float ConvertToRadian(float angle) {
            return angle * (3.14f / 180);
        }

        private double GetSinusAngle(float angle) {
            return Math.Sin(angle);
        }
        
        private double GetCosineAngle(float angle) {
            return Math.Cos(angle);
        }

        private float DeltaLatitude() {
            return Math.Abs(LatitudeDepartureCity - LatitudeArriveCity);
        }

        private float DeltaLongitude() {
            return Math.Abs(LongitudeDepartureCity - LongitudeArriveCity);
        }

        private double Calcul() {
            var asin = 2 * Math.Asin(Math.Sqrt(Math.Pow(GetSinusAngle(DeltaLatitude() / 2), 2) + (GetCosineAngle(LatitudeDepartureCity) * GetCosineAngle(LatitudeArriveCity) * Math.Pow(GetSinusAngle(DeltaLongitude() / 2), 2)))); // ответ получается в радианах
            var distanceKm = Math.Round(asin * 6372795 / 1000);
            return distanceKm;
        }
    }
}