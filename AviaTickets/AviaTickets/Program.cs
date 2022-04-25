using System;

namespace AviaTickets {
    internal class Program {
        public static void Main(string[] args) {
            DataLoader dataLoader = new DataLoader();
            dataLoader.Load();

            InputHandler inputHandler = new InputHandler();
            inputHandler.StartProgram();
        }
    }
}