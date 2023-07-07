void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}


void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);

void GetSecondNumber()
{
    Console.WriteLine("input three-digit number");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number >= 100 && number < 1000)
    {
        int secondDigit = (number % 100 - number % 10) / 10;
        Console.WriteLine("The second digit in " + number + " is " + secondDigit);
    }
    else Console.WriteLine("Your number isn't thhree-digit");
}

GetSecondNumber();