namespace lesson005_RecursionForBiTree;

class Program
{
    static void Main(string[] args)
    {
        // ((4 - 2) * (1 + 3)) / 10
        string emp = String.Empty;
        string[] biTree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
        //                   0    1    2     3    4    5    6    7    8    9    10   11
        void InOrderTraversal(int pos = 1)
        {
            if (pos < biTree.Length)
            {
                int left = 2 * pos;
                int right = 2 * pos + 1;
                if (left < biTree.Length && !String.IsNullOrEmpty(biTree[left])) InOrderTraversal(left);
                Console.Write(biTree[pos] + " ");
                if (right < biTree.Length && !String.IsNullOrEmpty(biTree[right])) InOrderTraversal(right);
            }
        }  

        InOrderTraversal();
    }
}
