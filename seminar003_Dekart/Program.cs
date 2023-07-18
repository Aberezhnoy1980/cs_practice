namespace seminar003_Dekart;

class Program
{
    static void Main(string[] args)
    {
        int Input(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        void FindPlaneThroughIfElse()
        {
            int x = Input("Enter X: ");
            int y = Input("Enter Y: ");

            if (x > 0 && y > 0) Console.WriteLine("First plane");
            else if (x < 0 && y < 0) Console.WriteLine("Third plane");
            else if (x > 0 && y < 0) Console.WriteLine("Fourth plane");
            else if (x < 0 && y > 0) Console.WriteLine("Second plane");
            else Console.WriteLine("On axis");
        }

        void FindRange()
        {
            int numberOfPlane = Input("Enter number of plane: ");

            if (numberOfPlane == 1) Console.WriteLine($"The range for {numberOfPlane} plane is x > 0 && y > 0");
            else if (numberOfPlane == 2) Console.WriteLine($"The range for {numberOfPlane} plane is x < 0 && y > 0");
            else if (numberOfPlane == 3) Console.WriteLine($"The range for {numberOfPlane} plane is x < 0 && y < 0");
            else if (numberOfPlane == 4) Console.WriteLine($"The range for {numberOfPlane} plane is x > 0 && y < 0");
            else Console.WriteLine("No range for this input");
        }

        void FindTheDistanceIn2D()
        {
            int x1 = Input("Enter X coordinate for A: ");
            int y1 = Input("Enter Y coordinate for A: ");
            int x2 = Input("Enter X coordinate for B: ");
            int y2 = Input("Enter Y coordinate for B: ");

            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y1 - y2), 2));

            Console.WriteLine($"The distance between A & B is {Math.Round(distance, 2, MidpointRounding.ToZero)}");
        }

        void GetSqrtTable()
        {
            int n = Input("Enter any integer: ");

            int res = 1;
            for (int i = 1; i <= n; i++)
            {
                // res = i * i;
                res = (int)Math.Pow(i, 2);
                Console.WriteLine($"{i}^2 = {res}");
            }
        }

        Console.Clear();
        int task = Input("Enter Task number: ");
        switch (task)
        {
            case 17:
                FindPlaneThroughIfElse();
                break;
            case 18:
                FindRange();
                break;
            case 21:
                FindTheDistanceIn2D();
                break;
            case 22:
                GetSqrtTable();
                break;
            default:
                Console.WriteLine("Enter error: task not found");
                break;
        }
    }
}
