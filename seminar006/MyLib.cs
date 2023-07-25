namespace MyLib
{
    public static class MyLibClass
    {
        public static int Input(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void FillArray(int[] integers, int minValue = -9, int maxValue = 9)
        {
            maxValue++;
            Random random = new Random();
            for (int i = 0; i < integers.Length; i++)
                integers[i] = random.Next(minValue, maxValue);
        }

        public static void PrintArray(int[] integers)
        {
            Console.Write("[");
            foreach (int i in integers)
            {
                Console.Write($"{i} ");
            }
            Console.Write("\b]");
        }

        public static void ReverseArray(int[] integers)
        {
            for (int i = 0; i < integers.Length / 2; i++)
            {
                // int temp = integers[i];
                // integers[i] = integers[integers.Length - 1 - i];
                // integers[integers.Length - 1 - i] = temp;

                (integers[i], integers[integers.Length - 1 - i]) = (integers[integers.Length - 1 - i], integers[i]);
            }

            Console.Write(" -> ");
            PrintArray(integers);
        }

        public static bool IsTriangle(int a, int b, int c)
        {
            if (a < (b + c) && b < (c + a) && c < (a + b))
                return true;
            return false;
        }

        public static int[] ConvertDecimalToBinary(int number)
        {
            int size = 0;
            int k = number;
            while (k > 0)
            {
                k /= 2;
                size++;
            }

            int[] binary = new int[size];
            for (int i = size - 1; i >= 0; i--)
            {
                binary[i] = number % 2;
                number /= 2;
            }
            return binary;
        }

        public static void PrintFibonacciNumbers(int n)
        {
            int[] fibonacciNumbers = new int[n];
            fibonacciNumbers[0] = 0;
            fibonacciNumbers[1] = 1;
            for (int i = 2; i < fibonacciNumbers.Length; i++)
            {
                fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
            }

            Console.Write("Fibonacci numbers for N elements is ");
            PrintArray(fibonacciNumbers);
        }

        public static void CopyArray(int[] array)
        {
            int[] arrayCopy = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
                arrayCopy[i] = array[i];
            Console.Write("Origin array ");
            PrintArray(array);
            Console.Write(" -> array copy ");
            PrintArray(arrayCopy);
        }

    }
}