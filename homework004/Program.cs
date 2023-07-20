namespace homework004;

class Program
{
    static void Main(string[] args)
    {

        int Input(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        void Task25()
        {
            // Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
            int a = Input("Enter a number: ");
            int b = Input("Enter a power: ");

            double RaiseNumberAToPowerB(int a, int b)
            {
                double result = 1.0;
                if (b == 0) return result;
                else if (a == 0) return 0;
                else if (b < 0)
                {
                    for (int i = 1; i <= Math.Abs(b); i++)
                    {
                        result /= a;
                    }
                }
                else
                {
                    for (int i = 1; i <= b; i++)
                    {
                        result *= a;
                    }
                }
                return result;
            }

            Console.Write($"The number {a} to the power of {b} is {RaiseNumberAToPowerB(a, b)}");
        }

        Task25();

        void Task27()
        {
            // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
            int number = Math.Abs(Input("Enter any integer: "));

            int GetDigitCount(int number)
            {
                int digitCount = 0;
                for (int i = number; i > 0; i /= 10)
                {
                    digitCount++;
                }
                return digitCount;
            }

            int GetDigitByIndex(int number, int index)
            {
                return number / ((int)Math.Pow(10, index)) % 10;
            }

            int GetDigitSumFromNumber(int number)
            {
                int sum = 0;
                for (int i = 0; i <= GetDigitCount(number); i++)
                {
                    sum += GetDigitByIndex(number, i);
                }
                return sum;
            }
            Console.WriteLine($"The number {number} contains {GetDigitCount(number)} digits and sum of them is {GetDigitSumFromNumber(number)}");
        }

        Task27();

        void Task29()
        {
            // Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
            Random rnd = new Random();
            int arrayLength = 8;

            int[] CreateArray(int arrayLength)
            {
                int[] arr = new int[arrayLength];
                for (int i = 0; i < arrayLength; i++)
                {
                    arr[i] = rnd.Next(-100, 100);
                }
                return arr;
            }

            void PrintArray(int[] array)
            {
                Console.Write("[");
                foreach (var item in array)
                {
                    Console.Write($"{item} ");
                }
                Console.Write("\b]");
            }

            int[] GetSortedArray(int[] array)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    int minPosition = i;
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (Math.Abs(array[j]) < Math.Abs(array[minPosition])) minPosition = j;
                    }
                    int temp = array[i];
                    array[i] = array[minPosition];
                    array[minPosition] = temp;
                }
                return array;
            }

            int[] numbers = CreateArray(arrayLength);
            Console.Write($"The random array ");
            PrintArray(numbers);
            int[] sortedArray = GetSortedArray(numbers);
            Console.Write(" after sorting is ");
            PrintArray(sortedArray);

            // PrintArray(GetSortedArray(CreateArray(arrayLength)));
        }

        Task29();
    }
}
