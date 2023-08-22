// Посчитать разницу между суммой положительных и суммой отрицательных элементов
int[] array = { -2, -3, 4, 0, 4, -2, -1, -9, 4, 9, 3, 2, -4, -4, 1,
                 2, 8, 7, 5, 4, 5, -5, -2, 6, -3, 4, -1, -3, 4, 6,
                 -4, -2, 3, -4, -5, 6, 5, 4, -7, 4, -8, 4, 8, -9, 9,
                 5, 4, 4, 3, -3, -5, -2, 4, -8, 7, 9, 8, 0, 3, 0,
                 -4, -3, -3, 1, 4, 7, 3, -7, 5, 2, -8, -6, -6, 8, 9};

int negSum = 0;
int posSum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < 0) negSum += array[i];
    else posSum += array[i];
}

Console.WriteLine($"negSum = {negSum} and posSum = {posSum}. Diff = {posSum + negSum}");