// Подсчитать количество максимумов
int[,,] array = {{
                  {1,2,3,4,5,6,5,4,5,6,5},
                  {2,4,3,2,6,5,6,2,1,6,0},
                  {2,3,2,4,6,6,5,4,3,4,6},
                  {6,0,3,1,6,5,6,2,1,6,0},
                  {6,5,4,3,4,6,5,4,3,6,4}
                 },
                 {
                  {0,2,3,4,5,6,5,4,5,6,6},
                  {2,4,6,2,6,5,6,2,1,6,0},
                  {2,6,2,4,6,6,5,4,3,4,6},
                  {6,0,3,1,6,5,6,2,1,6,0},
                  {6,5,4,3,4,6,5,4,3,6,4}
                 },
                 {
                  {1,0,3,4,5,3,5,4,5,4,5},
                  {2,2,3,2,0,5,6,2,1,4,0},
                  {2,3,2,4,6,6,5,4,3,4,6},
                  {6,0,3,1,6,5,6,2,1,2,0},
                  {2,5,4,3,4,2,5,4,3,1,6}
                 },
                 {
                  {1,6,3,4,5,3,5,4,5,4,5},
                  {2,2,3,2,2,5,6,2,1,4,0},
                  {2,3,2,4,3,6,5,4,3,4,6},
                  {3,0,3,1,3,5,6,2,1,2,0},
                  {2,5,4,3,4,2,5,4,3,1,1}
                 }
                 };

int maxCount = 0;
int max =  array[0, 0, 0];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            {
                if (max < array[i, j, k])
                {
                    max = array[i, j, k];
                    maxCount = 1;
                }
                else if (max == array[i, j, k])
                    maxCount++;
            }
        }
    }
}

Console.WriteLine(maxCount);

// int[] testArr = { 1, -1, -2, -3, -2, -1, -2, -3, 5, 5, -2, -1, -3, -3, -4, -3, -1, -4, -5 };
// int testMax = testArr[0];
// int testMaxCount = 0;
// for (int i = 0; i < testArr.Length; i++)
// {
//     if (testMax < testArr[i])
//     {
//         testMax = testArr[i];
//         testMaxCount = 1;
//     }
//     else if (testMax == testArr[i]) testMaxCount++;
// }

// void PrintArr(int[] arr)
// {
//     Console.Write($"[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{i} ");
//     }
//     Console.Write($"\b]");
// }

// Console.Write($"max = {testMax} in array ");
// PrintArr(testArr);
// Console.Write($" occurs {testMaxCount} times)");