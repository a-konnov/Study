using System;

namespace AviaTickets {
    public static class IdentificationCreator {
        private static int CurrentId = 0;
        public static int GenerateNewID() {
            CurrentId++;
            return CurrentId;
        }

        /*public static string GenerateNewCityID(string name, float latitude, float longitude) {
            var latitudeInt = Math.Truncate(latitude);
            var longitudeInt = Math.Truncate(longitude);
            string cityID = $"{name}{latitudeInt}{longitudeInt}";
            
            
            return cityID.ToUpper();
        }*/
    }
}