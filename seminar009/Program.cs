using MyLib;

namespace seminar009;

class Program
{
    static void Main(string[] args)
    {
        void Task63WithCycle()
        {
            int n = MyLibClass.Print("Enter any integer: ");
            int counter = 1;
            while (counter <= n)
            {
                Console.Write($"{counter} ");
                counter++;
            }
        }

        // Task63WithCycle();

        void Task63WithRec()
        {
            int n = MyLibClass.Print("Enter any integer: ");
            int counter = 1;

            void Recursion(int counter, int n)
            {
                if (counter > n) return;
                Console.Write($"{counter} ");
                counter++;
                Recursion(counter, n);
            }

            Recursion(counter, n);
        }

        // Task63WithRec();

        void Task65WithCycle()
        {
            int counter = MyLibClass.Print("Enter range from: ");
            int n = MyLibClass.Print("Enter range to: ");

            while (counter <= n)
            {
                Console.Write($"{counter} ");
                counter++;
            }
        }

        // Task65WithCycle(); 

        void Task65WithRec()
        {
            int counter = MyLibClass.Print("Enter range from: ");
            int n = MyLibClass.Print("Enter range to: ");

            void Recursion(int counter, int n)
            {
                if (counter > n) return;
                Console.Write($"{counter} ");
                counter++;
                Recursion(counter, n);
            }

            Recursion(counter, n);
        }

        // Task65WithRec();

        void RecursionTest(int counter, int n)
        {
            if (counter > n) return;
            Console.Write($"{counter} ");
            RecursionTest(counter + 1, n);
            Console.Write($"{counter} ");
        }

        // RecursionTest(1, 5);

        void Task67WithCycle()
        {
            int number = MyLibClass.Print("Enter any integer: ");
            int result = 0;
            while (number > 0)
            {
                result += number % 10;
                number /= 10;
            }

            Console.Write($"Sum of digits in number {number} is {result}");
        }

        // Task67WithCycle(); 

        void Task67WithRec()
        {
            int number = MyLibClass.Print("Enter any integer: ");

            int Recursion(int number, int result = 0)
            {
                if (number == 0) return result;
                result += number % 10;
                number /= 10;
                return Recursion(number, result);
            }

            Console.Write($"Sum of digits in number {number} is {Recursion(number)}");
        }

        // Task67WithRec();

        void Task69()
        {
            int number = MyLibClass.Print("Enter a number: ");
            int pow = MyLibClass.Print("Enter a pow: ");

            int Recursion(int number, int pow, int result = 1)
            {
                if (pow == 0) return result;
                result *= number;
                return Recursion(number, pow - 1, result);
            }
            Console.Write($"The number {number} to the power {pow} is {Recursion(number, pow)}");
        }

        // Task69(); 

        void Task58()
        {
            int rows = MyLibClass.Print("Enter rows count: ");
            int columns = MyLibClass.Print("Enter columns count: ");

            int[,] spiral = new int[rows, columns];

            int i = 0;
            int j = 0;

            int delta_i = 0;
            int delta_j = 1;

            int steps = columns;
            int turns = 0;

            for (int k = 0; k < spiral.Length; k++)
            {
                spiral[i, j] = k + 1;
                steps--;

                if (steps == 0)
                {
                    steps = rows * ((turns + 1) % 2) + columns * (turns % 2) - 1 - turns/2;
                    turns++;
                    int temp = - delta_i;
                    delta_i = delta_j;
                    delta_j = temp;
                }

                i += delta_i;
                j += delta_j;
            }

            MyLibClass.PrintArray(spiral);
        }

        Task58();

    }
}
