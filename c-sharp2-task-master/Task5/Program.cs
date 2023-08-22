namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        int GetSecondMax(int[] array)
        {
            /* Здесь надо написать алгоритм поиска второго максимума, пример: 
                 * массив: [2, 4, 5, 3], результат: 4
                 * массив: [2, 6, 5, 3], результат: 5
                 */
            int firstMax = array[0];
            int tempMax = firstMax;
            int secondMax = int.MinValue;
            for (int i = 1; i < array.Length; i++)
            {
                if (firstMax < array[i])
                {
                    firstMax = array[i]; 
                    secondMax = tempMax;
                    tempMax = firstMax;
                }
                else if (array[i] != firstMax && array[i] > secondMax) secondMax = array[i]; // 2, 4
            }
            return secondMax;
        }

        int[] array = { -1, -2, -3, -4, -5 };
        Console.Write(GetSecondMax(array));
    }
}
