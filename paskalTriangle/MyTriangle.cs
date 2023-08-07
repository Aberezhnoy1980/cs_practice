namespace MyTriangle
{
    public class Triangle
    {
        private int rowsCount;
        private int[,] triangle;
        private const int cellWidth = 1;

        public Triangle(int rowsCount)
        {
            this.rowsCount = rowsCount;
            this.triangle = new int[rowsCount, rowsCount];
        }

        public void FillTriangle()
        {
            for (int i = 0; i < rowsCount; i++)
            {
                triangle[i, 0] = 1;
                triangle[i, i] = 1;
            }

            for (int i = 2; i < rowsCount; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
                }
            }
        }

        public void PrintTriangle()
        {
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < rowsCount; j++)
                {
                    if (triangle[i, j] != 0)
                        Console.Write($"{triangle[i, j],cellWidth}");
                }
                Console.WriteLine();
            }
        }

        public void PrintIsoscelesTriangle()
        {
            int col = cellWidth * rowsCount;
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.SetCursorPosition(col, i + 1);
                    // if (triangle[i, j] != 0)
                    //     Console.Write($"{triangle[i, j],cellWidth}");
                    if (triangle[i, j] % 2 != 0)
                        Console.WriteLine("*");
                    col += cellWidth * 2;

                }

                col = cellWidth * rowsCount - cellWidth * (i + 1);

                Console.WriteLine();
            }
        }
    }
}