using System;
using System.Collections.Generic;
namespace TicTacToe {
    internal class Program {
        private static bool gameRun;
        static char[,] _table;
        private static int moveCount = 0;
        private static bool[] occupiedCells;
        private static int _cellsAmount = 9;
        private static Random rnd;
        
        public static void Main(string[] args) {
            gameRun = true;
            rnd = new Random();
            _table = new char[3, 3];
            occupiedCells = new bool[_cellsAmount];
            GameField();
            
            while (moveCount <= _cellsAmount && gameRun) {
                InputPlayer();
            }
            Console.ReadLine();
        }
        static void GameField() {
            Console.WriteLine("\t***Крестики - Нолики***");
            Console.WriteLine("- игрок ходит крестиком 'X' \n- для хода использовать цифры на клавиатуре от 1 до 9");
            int index = 1;
            for (int i = 0; i < 3; i++) {
                for (int j = 2; j >= 0; j--) {
                    _table[i,j] = (char)(58 - index);
                    index++;
                }
            }
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    Console.Write("| " + _table[i, j] + " ");
                }
                Console.WriteLine("|");
            }
        } 
        
        static void InputPlayer() {
            Console.WriteLine("Введите номер ячейки:");
            int number = int.Parse(Console.ReadLine());
            if (number > 0 && number < 10) {
                number -= 1;
                int column = number % _table.GetLength(0);
                int row = ((_table.GetLength(0) - 1) - number / _table.GetLength(0));
                if (!occupiedCells[number]) {
                    _table[row, column] = 'X';
                    occupiedCells[number] = true;
                    RefreshTable(_table);
                    moveCount++;
                    if (CheckWin('X')) {
                        Console.WriteLine("ВЫ ПОБЕДИЛИ\n");
                        gameRun = false;
                    }
                    else if (CheckDraw()) {
                        Console.WriteLine("НИЧЬЯ!\n");
                        gameRun = false;
                    }
                    else InputComputer();
                } else {
                    Console.WriteLine("ВЫБРАННАЯ ЯЧЕЙКА УЖЕ ИСПОЛЬЗУЕТСЯ. УКАЖИТЕ ПУСТУЮ!\n");
                }
            } else {
                RefreshTable(_table);
                Console.WriteLine("ВЫ УКАЗАЛИ НЕСУЩЕСТВУЮЩУЮ ЯЧЕЙКУ, ПОВТОРИТЕ ВВОД\n");
            }
            
        }
        
        static void InputComputer() {
            var availableIndexes = GetAvailableIndexes();
            int randomIndex = availableIndexes[rnd.Next(availableIndexes.Count)];
            int column = randomIndex % _table.GetLength(0);
            int row = ((_table.GetLength(0) - 1) - randomIndex / _table.GetLength(0));
            _table[row, column] = 'O';
            occupiedCells[randomIndex] = true;
            RefreshTable(_table);
            moveCount++;
            if (CheckWin('O')) {
                Console.WriteLine("ПОБЕДИЛ КОМПЬЮТЕР\n");
                gameRun = false;
            }
            else if (CheckDraw()) {
                Console.WriteLine("НИЧЬЯ!\n");
                gameRun = false;
            }
        }
        
        private static List<int> GetAvailableIndexes() {
            var availableСells = new List<int>();
            for (var i = 0; i < _cellsAmount; i++) {
                if (!occupiedCells[i]) {
                    availableСells.Add(i);
                }
            }
            return availableСells;
        }
        
        static void RefreshTable(char[,] array) {
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("\t***Крестики - Нолики***");
            Console.WriteLine("- игрок ходит крестиком 'X' \n- для хода использовать цифры на клавиатуре от 1 до 9");
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    Console.Write("| " + _table[i, j] + " ");
                }
                Console.WriteLine("|");
            }
        }
        
        static Boolean CheckWin(char symbol) {
            for (int i = 0; i < 3; i++) {
                if ((_table[i, 0] == symbol && _table[i, 1] == symbol && _table[i, 2] == symbol) || (_table[0, i] == symbol && _table[1, i] == symbol && _table[2, i] == symbol)) {
                    return true;
                }
                if ((_table[0, 0] == symbol && _table[1, 1] == symbol && _table[2, 2] == symbol) || (_table[2, 0] == symbol && _table[1, 1] == symbol && _table[0, 2] == symbol)) {
                    return true;
                }
            }
            return false;
        }

        static Boolean CheckDraw() {
            int countOccupiedCell = 0;
            for (int i = 0; i < occupiedCells.Length; i++) {
                if (occupiedCells[i]) {
                    countOccupiedCell++;
                }
            }
            if (countOccupiedCell == _cellsAmount && !CheckWin('X') && !CheckWin('O')) {
                return true;
            } 
            return false;
        }
    }
}