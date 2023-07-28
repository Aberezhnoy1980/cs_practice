namespace lesson005_RecursionForDirectory;

class Program
{
    static void Main(string[] args)
    {
        string path = @"/Users/alex/Documents/Study/Library/CS/practice/lesson005_Recursion";
        void CatalogInfo(string path, string indent = "")
        {
            DirectoryInfo catalog = new DirectoryInfo(path);

            DirectoryInfo[] catalogs = catalog.GetDirectories();
            for (int i = 0; i < catalogs.Length; i++)
            {
                Console.WriteLine($"{indent}{catalogs[i].Name}");
                CatalogInfo(catalogs[i].FullName, indent + "  ");
            }

            FileInfo[] files = catalog.GetFiles();

            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine($"{indent}{files[i].Name}");
            }
        }

        CatalogInfo(path);
    }
}
