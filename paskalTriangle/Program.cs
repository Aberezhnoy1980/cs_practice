using MyTriangle;

namespace practice;

class Program
{
    static void Main(string[] args)
    {
        Triangle triangle = new Triangle(70);

        Console.ReadLine();
        triangle.FillTriangle();
        // triangle.PrintTriangle();
        Console.ReadLine();
        triangle.PrintIsoscelesTriangle();

    }
}
