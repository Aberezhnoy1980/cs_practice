using MyLib;

namespace seminar008;

class Program
{
    static void Main(string[] args)
    {
        int[,] ChangeRows(int[,] array)
        {
            int lastIndex = array.GetLength(0) - 1;
            int firstIndex = 0;

            for (int j = 0; j < array.GetLength(1); j++)
            {
                int temp = array[firstIndex, j];
                array[firstIndex, j] = array[lastIndex, j];
                array[lastIndex, j] = temp;
                // (array[i, j]) = (array[j, i]);
            }
            return array;
        }

        void Task53()
        {
            int m = MyLibClass.Promt("Enter m size: ");
            int n = MyLibClass.Promt("Enter n size: ");

            int[,] ints;
            if (MyLibClass.ValidateArray(m, n))
                ints = new int[m, n];
            else
            {
                Console.WriteLine("Incorrect sizes. Please try again");
                return;
            }

            MyLibClass.FillArray(ints);
            MyLibClass.PrintArray(ints);

            Console.WriteLine();
            MyLibClass.PrintArray(ChangeRows(ints));
        }

        // Task53();

        int[,] TurnArray(int[,] array)
        {
            int length = array.GetLength(0);
            for (int i = 0; i < length; i++)
                for (int j = i; j < length; j++)
                {
                    int temp = array[i, j];
                    array[i, j] = array[j, i];
                    array[j, i] = temp;
                }
            return array;
        }

        void Task55()
        {
            int m = MyLibClass.Promt("Enter array size: ");
            int n = m;

            int[,] ints;
            if (MyLibClass.ValidateArray(m, n))
                ints = new int[m, n];
            else
            {
                Console.WriteLine("Incorrect sizes. Please try again");
                return;
            }

            MyLibClass.FillArray(ints);
            MyLibClass.PrintArray(ints);

            Console.WriteLine();
            MyLibClass.PrintArray(TurnArray(ints));
        }

        // Task55();


        int[] GetFrequencyDictionary(int[,] array)
        {
            // int size =
            int[] dict = new int[10]; // size

            {
                for (int i = 0; i < array.GetLength(0); i++)
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        dict[array[i, j]]++;
                    }
            }
            return dict;
        }

        void Task57()
        {
            int m = MyLibClass.Promt("Enter m size: ");
            int n = MyLibClass.Promt("Enter n size: ");
            int a = MyLibClass.Promt("Enter from range: ");
            int b = MyLibClass.Promt("Enter to range: ");

            int[,] ints;
            if (MyLibClass.ValidateArray(m, n))
                ints = new int[m, n];
            else
            {
                Console.WriteLine("Incorrect sizes. Please try again");
                return;
            }

            MyLibClass.FillArray(ints, a, b);
            MyLibClass.PrintArray(ints);

            Console.WriteLine("Frequency:");
            for (int i = 0; i < GetFrequencyDictionary(ints).Length; i++)
            {
                if (GetFrequencyDictionary(ints)[i] != 0)
                    Console.Write($"Value {i} occurs {GetFrequencyDictionary(ints)[i]} times\n");
            }
        }

        int[] getIndexesForMin(int[,] array)
        {
            int i_min = 0;
            int j_min = 0;
            int minValue = array[i_min, j_min];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (minValue > array[i, j])
                    {
                        minValue = array[i, j];
                        i_min = i;
                        j_min = j;
                    }
                }
            }
            int[] minIndexes = { i_min, j_min };
            return minIndexes;
        }

        int[,] ModifiedArray(int[,] array)
        {
            int rowLength = array.GetLength(0) - 1;
            int columnLength = array.GetLength(1) - 1;
            int[,] ints = new int[rowLength, columnLength];

            int i_min = getIndexesForMin(array)[0];
            int j_min = getIndexesForMin(array)[1];
            Console.WriteLine($"Minimum value is at position [{i_min}, {j_min}]");

            int bias_i = 0;
            int bias_j = 0;
            for (int i = 0; i < rowLength; i++)
            {
                if (i == i_min) bias_i++;
                bias_j = 0;
                for (int j = 0; j < columnLength; j++)
                {
                    if (j == j_min)
                        bias_j++;
                    ints[i, j] = array[i + bias_i, j + bias_j];
                }
            }
            return ints;
        }

        // Task57(); 

        void Task59()
        {
            int m = MyLibClass.Promt("Enter m size: ");
            int n = MyLibClass.Promt("Enter n size: ");

            int[,] result = new int[m, n];

            MyLibClass.FillArray(result, -100, 100);
            MyLibClass.PrintArray(result);

            Console.WriteLine();
            MyLibClass.PrintArray(ModifiedArray(result));
        }

        Task59();
    }
}
