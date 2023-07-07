namespace seminar002_Main;

class Program
{
    static void Main(string[] args)
    {
        /* Task 1: Напишите программу, которая выводит случайное число из отрезка [10, 99] 
    и показывает наибольшую цифру числа. */
        // ExecuteTaskFirst();

        /* Task 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет 
        вторую цифру этого числа.*/
        // ExecuteTaskSecond();

        /* Task 3: Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе 
        число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления. */
        // ExecuteTaskThird();

        /* Task 3: Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе 
        число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления. */
        // ExecuteTaskFourth();

        /* Task 4: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23 */
        // ExecuteTaskFifth();

        /* Task 5: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно 
        число квадратом другого */
        ExecuteTaskSix();

    }
    static void ExecuteTaskFirst()
    {
        int randomNumber = new Random().Next(10, 100);
        Console.WriteLine("Max digit in random number " + randomNumber + " is " + FindMaxDigitInNumber(randomNumber));

        int FindMaxDigitInNumber(int value)
        {
            int secondDigit = value % 10;
            int firstDigit = value / 10;

            int max;
            return max = firstDigit > secondDigit ? max = firstDigit : max = secondDigit;
        }
    }

    static void ExecuteTaskSecond()
    {
        int randomNumber = new Random().Next(99, 1000);
        Console.WriteLine($"From {randomNumber} new number w/o 2-nd digit is {DeleteSecondDigitInNumber(randomNumber)}");

        int DeleteSecondDigitInNumber(int value)
        {
            int firstDigit = value / 100;
            // int secondDigit = (value % 100 % 10);
            int thirdDigit = value % 10;

            int newNumber = firstDigit * 10 + thirdDigit;
            return newNumber;
        }
    }

    static void ExecuteTaskThird()
    {
        int value1 = new Random().Next(10, 100);
        int value2 = new Random().Next(1, 10);
        Console.WriteLine($"Number {value2} is a multiply of number {value1} is {IsSecondNumberMultiplyFirstNumber(value1, value2)}");

        bool IsSecondNumberMultiplyFirstNumber(int value1, int value2)
        {
            return value1 % value2 == 0;
        }
    }

    static int input(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }

    static void ExecuteTaskFourth()
    {
        int value1 = input("Input first value\n");
        int value2 = input("Input second value\n");

        if (value1 % value2 == 0) Console.WriteLine($"Valu2 {value2} is multiply of value {value1}");
        else Console.WriteLine($"Value2 {value2} is not multiply of value {value1} and modulo is {value1 % value2}");
    }

    static void ExecuteTaskFifth()
    {
        int value = input1("Input value: ");

        if (value % 7 == 0 && value % 23 == 0) Console.Write($"The number {value} is multiply of 7 and 23");
        else Console.Write($"The number {value} is not multiply of 7 and 23");
    }

    static void ExecuteTaskSix()
    {
        int value1 = input1("Input first value: ");
        int value2 = input1("Input second value: ");

        Console.Write(value1 * value1 == value2 || value2 * value2 == value1);
    }
}