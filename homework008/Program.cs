using MyLib;

namespace homework008;

class Program
{
    static void Main(string[] args)
    {
        void SortDescArrayRows(int[,] array)
        {
            int lastIndex = array.GetLength(1) - 1;
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < lastIndex; j++)
                {
                    for (int k = 0; k < array.GetLength(1) - 1 - j; k++)
                    {
                        if (array[i, k] < array[i, k + 1])
                            (array[i, k], array[i, k + 1]) = (array[i, k + 1], array[i, k]);
                    }
                }
        }

        void Task54()
        {
            int n = MyLibClass.Input("Enter row size: ");
            int m = MyLibClass.Input("Enter column size: ");
            int[,] ints = new int[n, m];

            MyLibClass.FillArray(ints);
            MyLibClass.PrintArray(ints);

            SortDescArrayRows(ints);
            Console.WriteLine("Sorted array rows by descending: ");
            MyLibClass.PrintArray(ints);
        }

        // Task54();

        int GetRowIndexWithMinSum(int[,] array)
        {
            int index = 0;
            int currentRowSum = 0;
            int minSum = int.MaxValue;

            int[] sums = new int[array.GetLength(0)];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    currentRowSum += array[i, j];
                }
                if (currentRowSum < minSum)
                {
                    minSum = currentRowSum;
                    index = i;
                }
                currentRowSum = 0;
            }
            return index;
        }

        void Task56()
        {
            int n = MyLibClass.Input("Enter row length: ");
            int m = MyLibClass.Input("Enter column length: ");
            int[,] ints;
            if (n != m && n > 0 && m > 0)
                ints = new int[n, m];
            else
            {
                Console.Write("Incorrect inputs, please try again.");
                return;
            }

            MyLibClass.FillArray(ints);
            MyLibClass.PrintArray(ints);

            Console.Write($"Row index with minimal sum is {GetRowIndexWithMinSum(ints)}");
        }

        // Task56();

        void FillArrayInSpiral(int[,] array)
        {
            int elementValue = 1;
            int dimension = array.GetLength(0);

            for (int i = 0; i < dimension; i++)
            {
                array[0, i] = elementValue;
                elementValue++;
            }
            for (int j = 1; j < dimension; j++)
            {
                array[j, dimension - 1] = elementValue;
                elementValue++;
            }
            for (int i = dimension - 2; i >= 0; i--)
            {
                array[dimension - 1, i] = elementValue;
                elementValue++;
            }
            for (int j = dimension - 2; j > 0; j--)
            {
                array[j, 0] = elementValue;
                elementValue++;
            }

            int iIndex = 1;
            int jIndex = 1;

            while (elementValue < dimension * dimension)
            {
                while (array[iIndex, jIndex + 1] == 0)
                {
                    array[iIndex, jIndex] = elementValue;
                    elementValue++;
                    jIndex++;
                }
                while (array[iIndex + 1, jIndex] == 0)
                {
                    array[iIndex, jIndex] = elementValue;
                    elementValue++;
                    iIndex++;
                }
                while (array[iIndex, jIndex - 1] == 0)
                {
                    array[iIndex, jIndex] = elementValue;
                    elementValue++;
                    jIndex--;
                }
                while (array[iIndex - 1, jIndex] == 0)
                {
                    array[iIndex, jIndex] = elementValue;
                    elementValue++;
                    iIndex--;
                }
            }
            for (int i = 0; i < dimension; i++)
                for (int j = 0; j < dimension; j++)
                {
                    if (array[i, j] == 0)
                        array[i, j] = elementValue;
                }
        }

        void Task58()
        {
            int n = MyLibClass.Input("Enter array dimension: ");
            int m = n;
            int[,] spiral = new int[n, m];

            FillArrayInSpiral(spiral);
            MyLibClass.PrintArray(spiral);
        }

        // Task58();

        int[,] GetProductOfMatriсes(int[,] matrix1, int[,] matrix2)
        {
            int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
            int currentElement;
            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                currentElement = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        currentElement += matrix1[i, k] * matrix2[k, j];
                    }
                    resultMatrix[i, j] = currentElement;
                }
            }
            return resultMatrix;
        }

        void Task61()
        {
            int n = MyLibClass.Input("Enter matrix 1 rows count: ");
            int m = MyLibClass.Input("Enter matrix 1 columns count: ");
            int[,] matrix1;

            int k = MyLibClass.Input("Enter matrix 2 rows count: ");
            int l = MyLibClass.Input("Enter matrix 2 columns count: ");
            int[,] matrix2;

            if (m == k)
            {
                matrix1 = new int[Math.Abs(n), Math.Abs(m)];
                matrix2 = new int[Math.Abs(k), Math.Abs(l)];
            }
            else
            {
                Console.Write("These matrices cannot be multiplied. Please try again.");
                return;
            }

            MyLibClass.FillArray(matrix1, -3, 3);
            MyLibClass.FillArray(matrix2, -3, 3);
            MyLibClass.PrintArray(matrix1);
            Console.WriteLine();
            MyLibClass.PrintArray(matrix2);
            Console.WriteLine("Product of matrix 1 and matrix 2 is: ");
            MyLibClass.PrintArray(GetProductOfMatriсes(matrix1, matrix2));
        }

        Task61();
    }
}