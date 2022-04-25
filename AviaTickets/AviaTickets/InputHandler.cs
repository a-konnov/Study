using System;

namespace AviaTickets {
    public class InputHandler {
        public void StartProgram() {
            Console.WriteLine("Choose your hero: \n 1 - User \n 2 - Admin");
            Console.WriteLine("Input a number");
            var chosenNumber = int.Parse(Console.ReadLine());
            
            switch (chosenNumber)
            {
                case 1:
                    UserActions();
                    break;
                case 2:
                    AdminActions();
                    break;
                default:
                    UserActions();
                    break;
            }
        }
        
        private void UserActions() {
            Console.WriteLine("Choose departure city:");
            var cityManager = AppFacade.CityManager;
            
            cityManager.GetAvailableCitiesList();
            Console.WriteLine("Input a number");
        }

        private void AdminActions() {
            Console.WriteLine("What do you want to do");
        }
    }
}