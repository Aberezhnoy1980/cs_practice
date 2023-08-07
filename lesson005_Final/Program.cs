using ListMaster;

namespace lesson005_Final;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        ArrayMaster arrayMaster = new();
        for (int i = 0; i < 10; i++)
        {
            arrayMaster.Add(random.Next(1, 5));
        }

        Console.WriteLine(arrayMaster.GetLength());

        for (int i = 0; i < arrayMaster.GetLength(); i++)
        {
            Console.Write($"{arrayMaster.GetValue(i)} ");
        }
    }
}
