using MyLib;

namespace homework007;

class Program
{
    static void Main(string[] args)
    {
        void Task47()
        {
            int m = MyLibClass.Promt("Enter m size: ");
            int n = MyLibClass.Promt("Enter n size: ");

            double[,] doubles;
            if (MyLibClass.ValidateArray(m, n))
                doubles = new double[m, n];
            else
            {
                Console.WriteLine("Incorrect sizes. Please try again");
                return;
            }

            MyLibClass.FillArray(doubles);
            MyLibClass.PrintArray(doubles);
        }

        // Task47();

        void FindElementByIndex(int[,] array, int row, int col)
        {
            int value = 0;
            if (row >= array.GetLength(0) || col >= array.GetLength(1) || row < 0 || col < 0)
            {
                Console.Write($"The element with indexes [{row}, {col}] is array out of bound");
            }
            else
            {
                Console.Write($"The element with indexes [{row}, {col}] is {array[row, col]}");
            }
        }

        void Task50()
        {
            int m = MyLibClass.Promt("Enter m size: ");
            int n = MyLibClass.Promt("Enter n size: ");

            int[,] ints;
            if (MyLibClass.ValidateArray(m, n))
                ints = new int[m, n];
            else
            {
                Console.WriteLine("Incorrect sizes. Please try again");
                return;
            }

            MyLibClass.FillArray(ints);
            MyLibClass.PrintArray(ints);

            int row = MyLibClass.Promt("Enter row searching index: ");
            int col = MyLibClass.Promt("Enter column searching index: ");

            FindElementByIndex(ints, row, col);
        }

        // Task50();

        void PrintAverages(double[] avgs)
        {
            Console.WriteLine("Average values for each column:");
            Console.Write($"col index:   |\t");
            for (int i = 0; i < avgs.Length; i++)
            {
                Console.Write($"{i} \t|\t");
            }
            Console.WriteLine();
            Console.Write($"averages:    |\t");
            for (int i = 0; i < avgs.Length; i++)
                Console.Write(avgs[i] + "\t|\t");
        }

        double[] GetAverages(int[,] array)
        {
            double[] avgs = new double[array.GetLength(1)];
            double sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    sum += array[i, j];
                }
                avgs[j] = Math.Abs(sum / array.GetLength(0));
                sum = 0;
            }
            return avgs;
        }

        void Task52()
        {
            int m = MyLibClass.Promt("Enter m size: ");
            int n = MyLibClass.Promt("Enter n size: ");

            int[,] ints;
            if (MyLibClass.ValidateArray(m, n))
                ints = new int[m, n];
            else
            {
                Console.WriteLine("Incorrect sizes. Please try again");
                return;
            }

            MyLibClass.FillArray(ints);
            MyLibClass.PrintArray(ints);

            PrintAverages(GetAverages(ints));
        }

        Task52();
    }
}
