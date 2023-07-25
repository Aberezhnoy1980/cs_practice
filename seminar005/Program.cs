using System;
using MyLib;

namespace seminar005;

class Program
{
    static void Main(string[] args)
    {
        void Task31()
        {
            int length = MyLibClass.Input("Enter array size: ");
            int[] numbers = new int[length];

            MyLibClass.FillArray(numbers);
            MyLibClass.GetNegativeAndPositiveSums(numbers);
        }

        // Task31();

        void Task32()
        {
            int length = MyLibClass.Input("Enter array size: ");
            int[] numbers = new int[length];

            MyLibClass.FillArray(numbers);

            Console.Write($"Array ");
            MyLibClass.PrintArray(numbers);
            Console.Write($" after replacing positive elements with negative ones and vice versa will be as follows: ");
            MyLibClass.PrintArray(MyLibClass.SwapPositiveAndNegativeArrayElements(numbers));
        }

        // Task32();

        void Task33()
        {
            int length = MyLibClass.Input("Enter array size: ");
            int number = MyLibClass.Input("Enter the number you want to search for: ");
            int[] numbers = new int[length];
            MyLibClass.FillArray(numbers);

            Console.Write($"Array ");
            MyLibClass.PrintArray(numbers);
            Console.WriteLine($" contains {number}. It's {MyLibClass.CheckArrayForNumber(numbers, number)}");
        }

        // Task33();

        void Task35()
        {
            int [] numbers = new int[10];
            MyLibClass.FillArray(numbers, 0, 1000);
            int fromIndex = MyLibClass.Input("Enter the start of the range: ");
            int toIndex = MyLibClass.Input("Enter the end of the range: ");

            Console.Write("The array ");
            MyLibClass.PrintArray(numbers);
            MyLibClass.FindElementsCountInRange(numbers, fromIndex, toIndex);
        }

        // Task35();

        void Task37()
        {
            int length = MyLibClass.Input("Enter array size: ");
            int[] numbers = new int[length];
            MyLibClass.FillArray(numbers, 0, 6);
            int[] newArray = MyLibClass.CreateArrayContainsProductOfElementsPairs(numbers);

            Console.Write("Array ");
            MyLibClass.PrintArray(numbers);
            Console.Write($" generates a new array of extrem elements pairs products ");
            MyLibClass.PrintArray(newArray);
        }

        Task37();

    }
}
