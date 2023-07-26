namespace homework006;

class Program
{
    static void Main(string[] args)
    {
        int Input(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        void FillArrayByUser(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Input($"Input value for {i + 1} elemnet: ");
            }
        }

        int GetCountOfElementsGreaterZero(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                    count++;
            }
            return count;
        }

        void PrintArray(int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");
            Console.Write("\b]");
        }

        void Task41()
        {
            // Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
            int length = Input("Enter element count: ");
            int[] ints = new int[length];

            FillArrayByUser(ints);

            int positiveElementsCounnt = GetCountOfElementsGreaterZero(ints);

            Console.Write("Array ");
            PrintArray(ints);
            Console.Write($" contains {positiveElementsCounnt} greater than zero elements");
        }

        // Task41();

        bool ValidateLines(double[] line1, double[] line2)
        {
            if (line1[0] == line2[0])
            {
                return false;
            }
            return true;
        }

        double[] GetCoordinates(double[] line1, double[] line2)
        {
            double[] coordinates = new double[2];
            coordinates[0] = (line1[1] - line2[1]) / (line2[0] - line1[0]);
            coordinates[1] = line1[0] * coordinates[0] + line1[1];
            return coordinates;
        }

        void Task43()
        {
            /* Напишите программу, которая найдёт точку пересечения двух прямых, 
            заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем. */

            double[] line1 = { Input("Enter k1 for line 1: "), Input("Enter b1 for line 1: ") };
            double[] line2 = { Input("Enter k2 for line 2: "), Input("Enter b2 for line 2: ") };

            if (ValidateLines(line1, line2))
            {
                double[] coordinates = GetCoordinates(line1, line2);
                Console.Write($"Intersection point for line 1 described as [Y = {line1[0]}X + {line1[1]}] " +
                $"with line 2 described as [Y = {line2[0]}X + {line2[1]}] " +
                $"has coordinates [X = {coordinates[0]}, Y = {coordinates[1]}]");
            }
            else Console.Write("Lines don't intersect");
        }

        Task43();
    }
}
