using System;

namespace MergeSorting {
    class Program {
        public static int[] a = new int[] { 3, 7, 8, 4, 5, 5, 1, 7, 8, 3, 9, 2 };
        
        static void Main(string[] args) {
            Console.WriteLine($"Unsorted \t{string.Join(", ", a)}");
            a.ArraySorting();
            Console.WriteLine($"Sorted \t{string.Join(", ", a)}");
            Console.ReadKey();
        }
    }

    public static class ArrayExtension {
        public static int[] _auxiliaryArray;
        
        public static void ArraySorting(this int[] array) {
            Sorting(array);
        }

        private static void Sorting(int[] array) {
            _auxiliaryArray = new int[array.Length];
            SortingProcess(array, 0, array.Length - 1);
        }

        public static void SortingProcess(int[] array, int low, int high) {
            if (high <= low)
                return;
            int middle = low + (high - low) / 2;
            SortingProcess(array, low, middle); //Левый подмассив
            SortingProcess(array, middle + 1, high); //Правый подмассив
            Merge(array, low, middle, high);
        }

        private static void Merge(int[] array, int low, int middle, int high) {
            int leftHalfIndex = low;
            int rightHalfIndex = middle + 1;
            for (int i = low; i <= high; i++) {
                _auxiliaryArray[i] = array[i];
            }

            for (int i = low; i <= high; i++) {
                if (leftHalfIndex > middle) {
                    array[i] = _auxiliaryArray[rightHalfIndex];
                    rightHalfIndex++;
                } else if (rightHalfIndex > high) {
                    array[i] = _auxiliaryArray[leftHalfIndex];
                    leftHalfIndex++;
                } else if (_auxiliaryArray[rightHalfIndex] <= _auxiliaryArray[leftHalfIndex]) {
                    array[i] = _auxiliaryArray[rightHalfIndex];
                    rightHalfIndex++;
                } else {
                    array[i] = _auxiliaryArray[leftHalfIndex];
                    leftHalfIndex++;
                }
            }
        }
    }
}