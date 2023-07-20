namespace seminar004;

class Program
{
    static void Main(string[] args)
    {
        int Input(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        void GetSumFromOneToN()
        {
            int n = Input("Enter any integer: ");
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i} + ");
                sum += i;
            }

            Console.Write("\b\b= ");
            Console.WriteLine(sum);
        }

        void GetNumberDigitCount()
        {
            int number = Input("Enter any integer: ");
            int digitCount = 0;

            for (int i = number; i > 0; i /= 10)
            {
                digitCount++;
            }

            Console.WriteLine($"The number {number} contains {digitCount} digits");
        }

        void GetProductFromOneToN()
        {
            int number = Input("Enter any integer: ");
            int result = 1;

            int MultiplyFromOneToN(int number)
            {
                for (int i = 1; i <= number; i++)
                {
                    result *= i;
                }
                return result;
            }

            Console.WriteLine($"Product of numbers from 1 to {number} = {MultiplyFromOneToN(number)}");
        }

        void PrintArrayWithRndOneAndZero()
        {
            int length = Input("Enter array size: ");

            int[] arr = new int[length];

            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                arr[i] = rnd.Next(2);
                Console.Write($"{arr[i]} ");
            }
        }

        void Menu()
        {
            int choice = Input("Please, select a task number to run:\n* 24 - get sum from 1 to N\n* 26 - get digit count of number\n* 28 - get product of numbers from 1 to N\n* 30 - print array with random 0 & 1\n* ");

            switch (choice)
            {
                case 24:
                    GetSumFromOneToN();
                    break;
                case 26:
                    GetNumberDigitCount();
                    break;
                case 28:
                    GetProductFromOneToN();
                    break;
                case 30:
                    PrintArrayWithRndOneAndZero();
                    break;
                default:
                    Console.WriteLine("Incorrect input, please try again\n");
                    Menu();
                    break;
            }
        }

        Menu();
    }
}
