namespace MyLib;

class MyLibClass
{
    public static int Input(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }

    public static void FillArray(int[] numbers, int minValue = -9, int maxValue = 9)
    {
        maxValue++;
        Random rnd = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rnd.Next(minValue, maxValue);
        }
    }

    public static void PrintArray(int[] numbers)
    {
        Console.Write("[");
        foreach (var item in numbers)
        {
            Console.Write($"{item} ");
        }
        Console.Write("\b]");
    }

    public static void GetNegativeAndPositiveSums(int[] numbers)
    {
        int negativeSum = 0;
        int positiveSum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < 0) negativeSum += numbers[i];
            else positiveSum += numbers[i];
        }

        Console.Write($"In the array ");
        MyLibClass.PrintArray(numbers);
        Console.Write($" sum of positive elements is {positiveSum} and sum of negative elements {Math.Abs(negativeSum)}");
    }

    public static int[] SwapPositiveAndNegativeArrayElements(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] *= -1;
        }
        return numbers;
    }

    public static bool CheckArrayForNumber(int[] numbers, int number)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == number) return true;
        }
        return false;
    }

    public static void FindElementsCountInRange(int[] numbers, int fromIndex, int toIndex)
    {
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] >= fromIndex && numbers[i] <= toIndex) count++;
        }

        Console.WriteLine($" has {count} elements in the range [{fromIndex}, {toIndex}] ");
    }

    public static int[] CreateArrayContainsProductOfElementsPairs(int[] numbers)
    {
        int[] newArray = new int[numbers.Length / 2];

        for (int i = 0, j = numbers.Length - 1; i < numbers.Length / 2; i++, j--)
            newArray[i] = numbers[i] * numbers[j];

        return newArray;
    }
}
