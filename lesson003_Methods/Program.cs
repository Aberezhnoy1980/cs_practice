namespace lesson003_Methods;

class Program
{
    static void Main(string[] args)
    {
        void Method1()
        {
            Console.WriteLine("Author ...");
        }

        // Method1();

        void Method2(string message)
        {
            Console.WriteLine(message);
        }

        // Method2(message: "Message text");

        void Method21(string message, int count)
        {
            int i = 0;
            while (i < count)
            {
                Console.WriteLine(message);
                i++;
            }
        }

        // Method21(message: "Text", count: 4);

        // Method21(count: 2, message: "New text");

        int Method3()
        {
            return DateTime.Now.Year;
        }

        int year = Method3();
        // Console.WriteLine(year);

        string Method4(int count, string text)
        {
            int i = 0;
            string result = String.Empty;

            while (i < count)
            {
                result = result + text;
                i++;
            }
            return result;

        }

        string Method41(int count, string text)
        {
            string result = String.Empty;

            for (int i = 0; i < count; i++)
            {
                result += text;
            }
            return result;
        }

        string res = Method41(10, "qwerty");
        // Console.WriteLine(res);

        for (int i = 2; i <= 10; i++)
        {
            for (int j = 2; j <= 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
            Console.WriteLine();
        }
    }
}
