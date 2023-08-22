// Просуммировать максимумы по колонкам в матрице

int[,] array = {{ 3, 27, 11, 4, 2, 15, 23, 4, 21, 14, 5, 2, 19, 25, 24, 10, 10, 14, 15, 16 },
                { 17, 12, 11, 10, 4, 2, 4, 30, 6, 26, 27, 6, 27, 25, 14, 18, 13, 11, 20, 13 },
                { 4, 14, 11, 13, 19, 17, 16, 27, 22, 30, 11, 18, 10, 3, 16, 21, 4, 13, 16, 12 },
                { 19, 26, 12, 20, 5, 5, 22, 14, 24, 5, 25, 18, 12, 17, 30, 8, 10, 28, 20, 18 },
                { 12, 25, 30, 17, 31, 6, 22, 24, 18, 9, 11, 17, 20, 27, 26, 7, 6, 31, 13, 31 },
                { 15, 20, 31, 22, 12, 24, 14, 5, 9, 17, 26, 30, 5, 4, 18, 7, 11, 6, 3, 12 },
                { 8, 27, 17, 11, 26, 22, 17, 15, 3, 2, 20, 2, 13, 4, 24, 3, 18, 11, 17, 25 },
                { 4, 5, 4, 13, 21, 2, 10, 2, 22, 16, 22, 12, 29, 14, 26, 12, 26, 24, 25, 12 },
                { 8, 3, 7, 27, 9, 27, 7, 6, 25, 26, 4, 17, 24, 6, 9, 30, 26, 3, 7, 27 },
                { 22, 15, 24, 13, 4, 26, 3, 17, 7, 14, 19, 25, 31, 5, 23, 7, 27, 30, 15, 4 }};

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void PrintMaxesSums(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
}

int[] FindMaxesByColumns(int[,] array)
{
    int[] maximumsByColumns = new int[array.GetLength(1)];
    int max = 0;
    int maxSum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            if (array[j, i] > max)
            {
                max = array[j, i];
                maxSum = max;
            }
            else if (array[j, i] == max) maxSum += max;
        }
        maximumsByColumns[i] = maxSum;
        maxSum = 0;
        max = 0;
    }

    return maximumsByColumns;
}

int FindSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        sum += array[i];
    return sum;
}

PrintArray(array);
Console.WriteLine();
PrintMaxesSums(FindMaxesByColumns(array));
Console.WriteLine();
Console.WriteLine($"Sum of maximums by columns is {FindMaxesByColumns(array).Sum()}");
