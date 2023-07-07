
// Task 1 (2): get maximum from two values
ExecuteTaskOne();

// Task 2 (4): get maximum from three values
ExecuteTaskTwo();

// Task 3 (6): determine if a number is even
ExecuteTaskThree();

// Task 4 (8): find all even values in a range
ExecuteTaskFour();

void ExecuteTaskOne()
{
    Console.WriteLine("First exercise: get maximum from two values.\n\nHi, my little buddy! I'm an electro shaitan machine. Let me try to define the biggest number you give me.\nInput the first number, please");
    int value1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input the second one");
    int value2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Maximum is " + GetMaxWithSimpleIfElse(value1, value2) + "\n=====================\n");

    int GetMaxValueFromTwoValues(int value1, int value2)
    {
        int max;
        // Console.WriteLine(value1 > value2 ? max = value1 : max = value2); // for void method - it's procedure
        return max = value1 > value2 ? max = value1 : max = value2; // for returnable method - it's function
    }

    int GetMaxWithSimpleIfElse(int value1, int value2)
    {
        int max;
        if (value1 > value2)
        {
            max = value1;
        }
        else max = value2;
        return max;
    }
}

void ExecuteTaskTwo()
{
    Console.WriteLine("Second exercise: get maximum from three values.\n\nIt's me again. I'm going to enslave humanity soon. Now I show you another trick with three numbers.\nPlease, input the first number");
    int value1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the second value");
    int value2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the third number");
    int value3 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Maximum is " + GetMaxValueFromThreeValues(value1, value2, value3) + "\n=====================\n");

    int GetMaxValueFromThreeValues(int value1, int value2, int value3)
    {
        int max = value1;
        if (max < value2 && value2 > value3) max = value2;
        else if (max < value3) max = value3;
        return max;
    }
}

void ExecuteTaskThree()
{
    Console.WriteLine("Third exercise: determine if a number is even.\n\nHi there! In this time I'll try to determine is a number you give me is even. Let's go!\nPlease, type a number");
    int value = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Is your value is even? - " + CheckValueForEven(value) + "\n=====================\n");

    bool CheckValueForEven(int value)
    {
        if (value % 2 == 0) return true;
        return false;
    }
}

void ExecuteTaskFour()
{
    Console.WriteLine("Fourth exercise: find all even values in a range.\n\nHow is going bro? I'm ready for the final challenge! Let's find all even values in the range you give me. Let's do it!\nPlease, insert a value");
    int range = Convert.ToInt32(Console.ReadLine());

    ShowAllEvenValuesInRange(range);

    void ShowAllEvenValuesInRange(int range)
    {
        int counter = 1;
        while (counter <= range)
        {
            if (counter % 2 == 0)
                Console.Write(counter + " ");
            counter++;
        }
    }
}