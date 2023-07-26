namespace MyLib;

class MyLibClass
{
    public static int Input(string message)
    {
        Console.WriteLine(message);
        return Convert.ToInt32(Console.ReadLine());
    }

    public static void FillArray(int[,] matrix, int minValue = -100, int maxValue = 100)
    {
        maxValue++;
        Random rnd = new Random();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = rnd.Next(minValue, maxValue);
            }
        }
    }

    public static void PrintArray(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            // Console.Write($"row index {i} | ");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }
    }

}