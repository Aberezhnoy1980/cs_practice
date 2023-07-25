using MyLib;

namespace homework005;

class Program
{
    static void Main(string[] args)
    {
        void Task34()
        {
            int length = MyLibClass.Input("Enter array size: ");
            int[] ints = new int[length];
            MyLibClass.FillArray(ints, 100, 999);

            Console.Write("Array ");
            MyLibClass.PrintArray(ints);
            Console.WriteLine($" contains {MyLibClass.GetEvenElementsCountInArray(ints)} even elements");
        }

        // Task34();

        void Task36()
        {
            int length = MyLibClass.Input("Enter array size: ");
            int[] numbers = new int[length];
            MyLibClass.FillArray(numbers, -9, 9);

            MyLibClass.GetSumOfElementsWithOddIndexes(numbers);
        }

        // Task36();

        void Task38()
        {
            int length = MyLibClass.Input("Enter array length: ");
            double[] doubles = new double[length];
            MyLibClass.FillArray(doubles);

            MyLibClass.GetMinMaxDifference(doubles);
        }

        Task38();
    }
}
