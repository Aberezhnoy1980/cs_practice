namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input any positive integer");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0)
            {
                mirrorArrayCreate1(num);
            }
            else Console.WriteLine("incorrect number"); 
        }

        static void mirrorArrayCreate(int num)
        {
            int[] numbers = new int[num * 2 + 1];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i < numbers.Length / 2)
                {
                    numbers[i] = -(numbers.Length / 2 - i);
                }
                else numbers[i] = i - numbers.Length / 2;
                Console.Write(numbers[i] + " ");
            }
            // Array.ForEach(numbers, Console.WriteLine);
        }

         static void mirrorArrayCreate1(int num)
        {
           num = Math.Abs(num);

           int counter = -num;

           while (counter <= num)
           {
            Console.Write(counter + " ");
            counter++;
           }
        }
    }
}