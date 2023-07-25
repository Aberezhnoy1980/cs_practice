namespace lesson004_RecursionAlgorithm;

class Program
{
    static void Main(string[] args)
    {
        string[,] table = new string[2, 5];
        table[1, 2] = "word";

        // for (int rows = 0; rows < 2; rows++)
        // {
        //     for (int columns = 0; columns < 5; columns++)
        //         Console.WriteLine($"[{table[rows, columns]}]");
        // }

        void PrintArray(int[,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Console.Write($"{matr[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        void FillArray(int[,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    matr[i, j] = new Random().Next(1, 10);
                }
            }
        }

        int[,] matrix = new int[3, 4];

        // PrintArray(matrix);
        // FillArray(matrix);
        // Console.WriteLine();
        // PrintArray(matrix);

        int GetFactorial(int n)
        {
            if (n == 1) return 1;
            else return GetFactorial(n - 1) * n;
        }

        // Console.Write(GetFactorial(5));

        // f(1) = 1
        // f(2) = 1
        // f(n) = f(n - 1) + f(n - 2)

        double Fibonacci(int n)
        {
            if (n == 1 || n == 2) return 1;
            else return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        // for (int i = 1; i < 40; i++)
        // {
        //     Console.WriteLine($"f({i}) = {Fibonacci(i)} ");
        // }

        
    }
}
