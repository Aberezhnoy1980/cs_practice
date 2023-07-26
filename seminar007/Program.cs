using MyLib;

namespace seminar007;

class Program
{
    static void Main(string[] args)
    {
        void Task46()
        {
            // Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
            int n = MyLibClass.Input("Enter size n: ");
            int m = MyLibClass.Input("Enter size m: ");
            int[,] matrix = new int[m, n];

            MyLibClass.FillArray(matrix);
            MyLibClass.PrintArray(matrix);
        }

        Console.Clear();
        // Task46();

        void FillArrayWithMultiIndexes(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = i + j;
                }
            }
        }

        void Task48()
        {
            int n = MyLibClass.Input("Enter size n: ");
            int m = MyLibClass.Input("Enter size m: ");
            int[,] matrix = new int[m, n];

            FillArrayWithMultiIndexes(matrix);
            MyLibClass.PrintArray(matrix);
        }

        // Task48();

        void FillArrayWithPowForEvenIndexes(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i += 2)
            {
                for (int j = 0; j < matrix.GetLength(1); j += 2)
                {
                    if (i % 2 == 0 && j % 2 == 0)
                        matrix[i, j] *= matrix[i, j];
                }
            }
        }

        void Task49()
        {
            // Задайте двумерный массив. Найдите элементы, у
            // которых оба индекса чётные, и замените эти элементы на их квадраты.
            int n = MyLibClass.Input("Enter size n: ");
            int m = MyLibClass.Input("Enter size m: ");
            int[,] matrix = new int[m, n];

            MyLibClass.FillArray(matrix);
            MyLibClass.PrintArray(matrix);
            Console.WriteLine("=============");

            FillArrayWithPowForEvenIndexes(matrix);
            MyLibClass.PrintArray(matrix);
        }

        // Task49();

        int GetSumForDiagonal(int[,] matrix)
        {
            int sum = 0;
            int limit = Math.Min(matrix.GetLength(0), matrix.GetLength(1));
            for (int i = 0; i < limit; i++)
            {
                sum += matrix[i, i];
            }
            return sum;
        }
        void Task51()
        {
            // Задайте двумерный массив. Найдите сумму
            // элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
            int n = MyLibClass.Input("Enter size n: ");
            int m = MyLibClass.Input("Enter size m: ");
            int[,] matrix = new int[m, n];

            MyLibClass.FillArray(matrix);
            MyLibClass.PrintArray(matrix);
            Console.WriteLine("=============");
            Console.Write($"Sum for diagonal elements is {GetSumForDiagonal(matrix)}");
        }

        Task51();
    }
}
