namespace lesson003_ArrayMinMaxSort;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 9, 5, 7, 2, 4, 2, 3, 1 };

        void PrintArray(int[] array)
        {
            int length = array.Length;

            for (int i = 0; i < length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        void SortArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int minPosition = i;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[minPosition]) minPosition = j;
                }
                int temp = numbers[i];
                numbers[i] = numbers[minPosition];
                numbers[minPosition] = temp;

            }
        }

        void ReverseSortArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int maxPosition = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] > numbers[maxPosition])
                        maxPosition = j;
                }
                int temp = numbers[i];
                numbers[i] = numbers[maxPosition];
                numbers[maxPosition] = temp;

            }
        }

        PrintArray(numbers);
        SortArray(numbers);
        PrintArray(numbers);
        ReverseSortArray(numbers);
        PrintArray(numbers);
    }
}
