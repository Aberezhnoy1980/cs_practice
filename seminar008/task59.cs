// int rows = 5;
// int columns = 6;
// int[,] numbers = new int[rows, columns];

// MyLibClass.FillArray(numbers, -100, 100);
// MyLibClass.PrintArray(numbers);

// int rowsResult = rows - 1;
// int columnsResult = columns - 1;
// int[,] result = new int[rowsResult, columnsResult];

// int minValue = numbers[0, 0];
// int i_min = 0;
// int j_min = 0;

// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         if (numbers[i, j] < minValue)
//         {
//             minValue = numbers[i, j];
//             i_min = i;
//             j_min = j;
//         }
//     }
// }
// Console.WriteLine();
// Console.WriteLine($"Минимальное значение {minValue} находится в позиции {i_min + 1}, {j_min + 1}");

// int bias_i = 0;
// int bias_j = 0;
// for (int i = 0; i < rowsResult; i++)
// {
//     if (i == i_min) bias_i++;
//     bias_j = 0;
//     for (int j = 0; j < columnsResult; j++)
//     {
//         if (j == j_min) bias_j++;
//         result[i, j] = numbers[i + bias_i, j + bias_j];
//     }

// }
// Console.WriteLine();
// MyLibClass.PrintArray(result);