using System;

namespace AviaTickets {
    public static class IdentificationCreator {
        public static string GenerateNewID() {
            return Guid.NewGuid().ToString("N");
        }

        public static string GenerateNewCityID(string name, float latitude, float longitude) {
            var latitudeInt = Math.Truncate(latitude);
            var longitudeInt = Math.Truncate(longitude);
            string cityID = $"{name}{latitudeInt}{longitudeInt}";
            
            
            return cityID.ToUpper();
        }
    }
}