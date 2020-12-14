using System;
using System.Collections.Generic;

namespace TicTacToe {
    internal class Program {
        private static bool _canInput;
        static char[,] _table;
        private static int _inputsCount = 0;
        private static bool[] _occupiedCells;
        private static int _cellsAmount = 9;
        private static Random _randomInput;
        
        public static void Main(string[] args) {
            _canInput = true;
            _randomInput = new Random();
            _table = new char[3, 3];
            _occupiedCells = new bool[_cellsAmount];
            GameField();
            
            while (_inputsCount <= _cellsAmount && _canInput) {
                InputPlayer();
            }
        }

        public static void GameField() {
            Console.WriteLine("\t***Крестики - Нолики***\n- игрок ходит крестиком 'X' \n- для хода использовать цифры на клавиатуре от 1 до 9");
            int index = 1;
            for (int i = 0; i < 3; i++) {
                for (int j = 2; j >= 0; j--) {
                    _table[i, j] = (char)(58 - index);
                    index++;
                }
            }
            StructureGameField();
        }

        public static void StructureGameField() {
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    Console.Write("| " + _table[i, j] + " ");
                }
                Console.WriteLine("|");
            }
        }

        public static void InputPlayer() {
            Console.WriteLine("Введите номер ячейки:");
            int number = int.Parse(Console.ReadLine());
            if (number > 0 && number < 10) {
                number -= 1;
                var position = CalculatePosition(number);

                if (!_occupiedCells[number]) {
                    _table[position.row, position.column] = 'X';
                    _occupiedCells[number] = true;
                    RefreshTable(_table);
                    _inputsCount++;

                    if (CheckWin('X')) {
                        Console.WriteLine("ВЫ ПОБЕДИЛИ\n");
                        _canInput = false;
                        return;
                    }
                    else if (CheckDraw()) {
                        Console.WriteLine("НИЧЬЯ!\n");
                        _canInput = false;
                        return;
                    }
                    else InputComputer();

                }
                else Console.WriteLine("ВЫБРАННАЯ ЯЧЕЙКА УЖЕ ИСПОЛЬЗУЕТСЯ. УКАЖИТЕ ПУСТУЮ!\n");

            }
            else {
                RefreshTable(_table);
                Console.WriteLine("ВЫ УКАЗАЛИ НЕСУЩЕСТВУЮЩУЮ ЯЧЕЙКУ, ПОВТОРИТЕ ВВОД\n");
            }
        }

        public static void InputComputer() {
            var availableIndexes = GetAvailableIndexes();
            int randomIndex = availableIndexes[_randomInput.Next(availableIndexes.Count)];
            var position = CalculatePosition(randomIndex);
            _table[position.row, position.column] = 'O';
            _occupiedCells[randomIndex] = true;
            RefreshTable(_table);
            _inputsCount++;

            if (CheckWin('O')) {
                Console.WriteLine("ПОБЕДИЛ КОМПЬЮТЕР\n");
                _canInput = false;
            }
            else if (CheckDraw()) {
                Console.WriteLine("НИЧЬЯ!\n");
                _canInput = false;
            }
        }

        public static List<int> GetAvailableIndexes() {
            var availableСells = new List<int>();
            for (var i = 0; i < _cellsAmount; i++) {
                if (!_occupiedCells[i]) {
                    availableСells.Add(i);
                }
            }

            return availableСells;
        }

        static (int row, int column) CalculatePosition(int number) {
            int column = number % _table.GetLength(0);
            int row = ((_table.GetLength(0) - 1) - number / _table.GetLength(0));

            return (row, column);
        }

        public static void RefreshTable(char[,] array) {
            Console.Clear();
            Console.WriteLine("\t***Крестики - Нолики***\n- игрок ходит крестиком 'X' \n- для хода использовать цифры на клавиатуре от 1 до 9");
            StructureGameField();
        }

        public static Boolean CheckWin(char symbol) {
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

        public static Boolean CheckDraw() {
            int countOccupiedCell = 0;
            for (int i = 0; i < _occupiedCells.Length; i++) {
                if (_occupiedCells[i]) {
                    countOccupiedCell++;
                }
            }

            if (countOccupiedCell == _cellsAmount ) {
                return true;
            }

            return false;
        }
    }
}