namespace MyLib
{
    class MyLibClass
    {
        public static int Input(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void FillArray(int[,] array, int minValue = -9, int maxValue = 10)
        {
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    array[i, j] = random.Next(minValue, maxValue);
        }

        public static void PrintArray(int[,] array)
        {
            Console.Write($"col index:   |\t");
            for (int i = 0; i < array.GetLength(1); i++)
            {
                Console.Write($"{i} \t|\t");
            }
            Console.WriteLine();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write($"row index: {i} |\t");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t|\t");
                }
                Console.WriteLine();
            }
        }
    }
}
