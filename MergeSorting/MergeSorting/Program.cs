using System;

namespace MergeSorting {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine($"Not sorting \t{string.Join(", ",a)}");
            Sorting(a);
            Console.WriteLine($"Sorting \t{string.Join(", ",a)}");
            Console.ReadLine();
        }

        private static int[] a = new int[] {3,7,8,4,5,5,1,7,8,3,9,2};
        private static int[] _auxiliaryArray;
        
        private static void Sorting(int[] array) {
            _auxiliaryArray = new int[array.Length];
            SortingProcess(array, 0, array.Length - 1);
        }

        private static void SortingProcess(int[] array, int low, int high) {
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
            for (int i = low; i <= high ; i++) {
                _auxiliaryArray[i] = array[i];
            }

            for (int i = low; i <= high; i++) {
                if (leftHalfIndex > middle) {
                    a[i] = _auxiliaryArray[rightHalfIndex];
                    rightHalfIndex++;
                } else if (rightHalfIndex > high) {
                    a[i] = _auxiliaryArray[leftHalfIndex];
                    leftHalfIndex++;
                } else if (_auxiliaryArray[rightHalfIndex] <= _auxiliaryArray[leftHalfIndex]) {
                    a[i] = _auxiliaryArray[rightHalfIndex];
                    rightHalfIndex++;
                } else {
                    a[i] = _auxiliaryArray[leftHalfIndex];
                    leftHalfIndex++;
                }
            }
        }
    }
}