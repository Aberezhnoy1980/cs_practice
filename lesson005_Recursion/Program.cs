namespace lesson005_Recursion;

class Program
{
    static void Main(string[] args)
    {
        string NumbersFor(int a, int b)
        {
            string result = String.Empty;
            for (int i = a; i <= b; i++)
                result += $"{i} ";
            return result;
        }

        string NumbersForReverse(int a, int b)
        {
            string result = String.Empty;
            for (int i = b; i >= a; i--)
                result += $"{i} ";
            return result;
        }

        string NumbersRec(int a, int b)
        {
            if (a < b) return $"{a} " + NumbersRec(a + 1, b);
            else return $"{a}";
        }

        string NumbersRecReverse(int a, int b)
        {
            if (a <= b) return NumbersRecReverse(a + 1, b) + $"{a} ";
            else return String.Empty;
        }

        // Console.WriteLine(NumbersFor(1, 10));
        // Console.WriteLine(NumbersForReverse(1, 10));
        // Console.WriteLine(NumbersRec(1, 10));
        // Console.WriteLine(NumbersRecReverse(1, 10));

        int SumFor(int n)
        {
            int result = 0;
            for (int i = 1; i <= n; result += i, i++) ;
            return result;
        }

        int SumRec(int n)
        {
            if (n == 1) return 1;
            else return n + SumRec(n - 1);
        }
        // Console.WriteLine(SumFor(10));
        // Console.WriteLine(SumRec(10));

        int FactorialFor(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; result *= i, i++) ;
            return result;
        }

        int FactorialRec(int n)
        {
            if (n == 1) return 1;
            else return FactorialRec(n - 1) * n;
        }
        // Console.WriteLine(FactorialFor(3));
        // Console.WriteLine(FactorialRec(3));

        int PowerFor(int a, int n)
        {
            int result = 1;
            for (int i = 1; i <= n; result *= a, i++) ;
            return result;
        }

        int PowerRec(int a, int n)
        {
            if (n == 0) return 1;
            else return a * PowerRec(a, n - 1);
        }

        int PowerMath(int a, int n)
        {
            if (n == 0) return 1;
            else if (n % 2 == 0) return PowerMath(a * a, n / 2);
            else return PowerMath(a, n - 1) * a;
        }
        // Console.WriteLine(PowerFor(3, 3));
        // Console.WriteLine(PowerRec(3, 3));
        // Console.WriteLine(PowerMath(2, 8));

        void WordBuilder(char[] chars)
        {
            int count = chars.Length;
            int n = 1;

            for (int i = 0; i < count; i++)
                for (int j = 0; j < count; j++)
                    for (int k = 0; k < count; k++)
                        for (int l = 0; l < count; l++)
                            Console.WriteLine($"{n++,-5}{chars[i]}{chars[j]}{chars[k]}{chars[l]}");
        }

        // char[] alphabet = { 'а', 'и', 'с', 'в' };
        // WordsBuilder(alphabet);

        int n = 1;
        void FindWords(string alphabet, char[] word, int length = 0)
        {
            if (length == word.Length)
            {
                Console.WriteLine($"{n++,-5} {new String(word)}");
                return;
            }
            for (int i = 0; i < alphabet.Length; i++)
            {
                word[length] = alphabet[i];
                FindWords(alphabet, word, length + 1);
            }
        }
        FindWords("аисв", new char[3]);

    }
}
