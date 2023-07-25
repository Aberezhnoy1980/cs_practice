namespace MyLib;

class MyLibClass
{
    public static int Input(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }
    public static void FillArray(int[] integers, int minValue = -100, int maxValue = 100)
    {
        maxValue++;
        Random random = new Random();

        for (int i = 0; i < integers.Length; i++)
            integers[i] = random.Next(minValue, maxValue);
    }
    public static void FillArray(double[] doubles, int minValue = -100, int maxValue = 100)
    {
        maxValue++;
        Random random = new Random();

        for (int i = 0; i < doubles.Length; i++)
            doubles[i] = Math.Round(random.NextDouble() * random.Next(minValue, maxValue), 2);
    }

    public static void PrintArray(int[] integers)
    {
        Console.Write("[");
        foreach (int i in integers)
            Console.Write($"{i} ");
        Console.Write("\b]");
    }
    public static void PrintArray(double[] doubles)
    {
        Console.Write("[");
        foreach (double i in doubles)
            Console.Write($"{i} ");
        Console.Write("\b]");
    }

    public static int GetEvenElementsCountInArray(int[] ints)
    {
        int count = 0;
        for (int i = 0; i < ints.Length; i++)
        {
            if (ints[i] % 2 == 0) count++;
        }
        return count;
    }

    public static void GetSumOfElementsWithOddIndexes(int[] numbers)
    {
        int sum = 0;

        for (int i = 1; i < numbers.Length; i += 2)
        {
            sum += numbers[i];
        }

        Console.Write("Sum of elements with odd indexes in array ");
        PrintArray(numbers);
        Console.WriteLine($" is {sum}");
    }

    public static void GetMinMaxDifference(double[] doubles)
    {
        double difference = 0;
        double min = doubles[0];
        double max = doubles[0];
        for (int i = 0; i < doubles.Length; i++)
        {
            if (doubles[i] > max) max = doubles[i];
            else if (doubles[i] < min) min = doubles[i];
        }
        difference = max - min;
        Console.Write($"Difference between maximum [{max}] and minimum [{min}] in array ");
        PrintArray(doubles);
        Console.WriteLine($" is {difference}");
    }
}