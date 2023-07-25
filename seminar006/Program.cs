using MyLib;

namespace seminar006;

class Program
{
    static void Main(string[] args)
    {
        void Task39()
        {
            int length = MyLibClass.Input("Enter array size: ");
            int[] ints = new int[length];

            MyLibClass.FillArray(ints, 0, length);
            MyLibClass.PrintArray(ints);
            MyLibClass.ReverseArray(ints);
        }

        // Task39();

        void Task40()
        {
            int a = MyLibClass.Input("Enter length for a: ");
            int b = MyLibClass.Input("Enter length for b: ");
            int c = MyLibClass.Input("Enter length for c: ");

            Console.Write(MyLibClass.IsTriangle(a, b, c));
        }

        // Task40();

        void Task42()
        {
            int number = MyLibClass.Input("Enter any integer: ");

            Console.Write($"Binary for {number} is ");
            MyLibClass.PrintArray(MyLibClass.ConvertDecimalToBinary(number));
        }

        // Task42();

        void Task44()
        {
            int n = MyLibClass.Input("Enter any integer: ");

            MyLibClass.PrintFibonacciNumbers(n);
        }

        // Task44();

        void Task45()
        {
            int length = MyLibClass.Input("Enter array size: ");
            int[] array = new int[length];

            MyLibClass.FillArray(array);

            MyLibClass.CopyArray(array);
        }

        Task45();
    }
}
