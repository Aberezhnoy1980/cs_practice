namespace homework003;

class Program
{
    static void Main(string[] args)
    {
        int IntInput(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        string StringInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        void IsNumberPalindrom()
        {
            int number = IntInput("Enter any integer: ");
            int digitCount = (int)Math.Log10(Math.Abs(number)) + 1;

            int GetLeftDigit(int digitIndex)
            {
                int leftDigit = number / (int)Math.Pow(10, digitCount - 1 - digitIndex) % 10;
                return leftDigit;
            }

            int GetRightDigit(int digitIndex)
            {
                int rightDigit = number / (int)Math.Pow(10, digitIndex) % 10;
                return rightDigit;
            }

            for (int i = 0; i < digitCount / 2; i++)
            {
                if (GetLeftDigit(i) != GetRightDigit(i))
                {
                    Console.Write($"The number {number} isn't palindrome");
                    return;
                }
            }
            Console.Write($"The number {number} is palindrome");
        }

        // The simplest solution
        void Task19()
        {
            string number = StringInput("Enter a five-digit number: ");

            if (number.Length == 5)
            {
                if (number[0].Equals(number[4]) && number[1].Equals(number[3]))
                    Console.Write($"The number {number} is palindrome");
                else
                    Console.Write($"The number {number} isn't palindrome");
            }
            else
                Console.Write($"Input is incorrect: {number} isn't five-digit number");
        }

        void Task21()
        {
            int x1 = IntInput("Enter X coordinate for A: ");
            int y1 = IntInput("Enter Y coordinate for A: ");
            int z1 = IntInput("Enter Z coordinate for A: ");
            int x2 = IntInput("Enter X coordinate for B: ");
            int y2 = IntInput("Enter Y coordinate for B: ");
            int z2 = IntInput("Enter Z coordinate for B: ");

            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

            Console.Write($"The distance between A({x1}, {y1}, {z1}) & B({x2}, {y2}, {z2}) is {Math.Round(distance, 2)} ");
        }

        void Task23()
        {
            int n = IntInput("Enter any positive integer: ");
            int res = 1;

            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    res = (int)Math.Pow(i, 3);
                    Console.WriteLine($"{i}^3 = {res}");
                }
            }
            else
            {
                Console.Write("Incorrect input. Please try again. ");
                Task23();
            }
        }

        void Menu()
        {
            // Console.Clear();
            int choice = IntInput("Please select a task number to run:\n* 19 - check if five-digit number is palindrome (use string)\n* 191 - check if any number is palindrome (use int)\n* 21 - find the distance between two points in 3D\n* 23 - get a table of cubes.\n* 0 - exit menu.\n");

            switch (choice)
            {
                case 19:
                    Task19();
                    break;
                case 191:
                    IsNumberPalindrom();
                    break;
                case 21:
                    Task21();
                    break;
                case 23:
                    Task23();
                    break;
                case 0:
                    return;
                default:
                    Console.Write("Incorrect input, please try again or type 0 to exit\n");
                    Menu();
                    break;
            }
        }

        Menu();
    }
}
