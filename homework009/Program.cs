namespace homework009;

class Program
{
    static void Main(string[] args)
    {
        int Input(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        void Task64()
        {
            int m = Input("Enter range from: ");
            int n = Input("Enter range to: ");

            void GetMultiplesOfThree(int m, int n)
            {
                if (m > n) return;
                if (m % 3 == 0) Console.Write($"{m}, ");
                GetMultiplesOfThree(m + 1, n);
            }
            Console.Write($"Numbers that are multiples of three in range from {m} to {n} are [");
            GetMultiplesOfThree(m, n);
            Console.Write("\b\b]");
        }

        // Task64();

        void Task66()
        {
            int m = Input("Enter range from: ");
            int n = Input("Enter range to: ");

            int GetSumInRange(int m, int n, int sum = 0)
            {
                if (m > n) return sum;
                sum += m;
                m++;
                return GetSumInRange(m, n, sum);
            }

            Console.Write($"The sum of numbers in range from {m} to {n} is {GetSumInRange(m, n)}");
        }

        // Task66();

        void Task68()
        {
            int m = Input("Enter a number m: ");
            int n = Input("Enter a number n: ");

            int GetAckermanFunctionResult(int m, int n)
            {
                if (m == 0) return n + 1;
                else if (n == 0) return GetAckermanFunctionResult(m - 1, 1);
                else return GetAckermanFunctionResult(m - 1, GetAckermanFunctionResult(m, n - 1));
            }

            Console.Write($"Ackerman function A(m, n) for m = {m} and n = {n} is {GetAckermanFunctionResult(m, n)}");
        }

        Task68();
    }
}
