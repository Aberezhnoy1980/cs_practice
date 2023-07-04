namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

            Console.WriteLine("type day of the week number");

            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0 && num <= 7)
            {
                Console.WriteLine(days[num - 1]);
            }
            else Console.WriteLine("input correct number from 1 to 7");
        }
    }
}