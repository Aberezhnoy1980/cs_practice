namespace homework002;

class Program
{
    static void Main(string[] args)
    {
        int input(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        void GetSecondDigitFromNumber()
        {
            Console.Clear();
            int value = input("Please, enter three-digit number ");
            if (value >= 100 && value < 1000)
            {
                int secondDiigt = value % 100 / 10;
                Console.Write($"Second digit in {value} is " + secondDiigt);
            }
            else Console.Write($"Entered value {value} is invalid");
        };

        void getNDigitFromNumber()
        {
            Console.Clear();
            int value = input("Please, enter any integer ");
            int digitIndex = input("Inter search index of digit ");

            int GetReducedValue(int value)
            {
                while (value >= (int)Math.Pow(10, digitIndex))
                {
                    value /= 10;
                }
                return value - value / 10 * 10; // value % 10
            }

            if (value >= (int)Math.Pow(10, digitIndex - 1))
            {
                // int bitDepth = value.ToString().ToCharArray().Length;
                // double n = bitDepth - digitIndex;
                // int thirdDigit = value / (int) Math.Pow(10, n) - value / (int) Math.Pow(10, n + 1) * 10;
                Console.Write($"Digit n#{digitIndex} in {value} is " + GetReducedValue(value));
            }
            else
                Console.Write($"Number {value} doesn't have a digit#{digitIndex}");
        }

        void SecondTaskAlmostInOneAction()
        {
            Console.Clear();
            int value = input("Please, enter any integer ");
            int digitIndex = input("Inter search index of digit ");
            if (value >= (int)Math.Pow(10, digitIndex - 1))
                Console.Write($"Digit #{digitIndex} in {value} is " + value.ToString().ToCharArray()[digitIndex - 1]);
            else
                Console.Write($"Number {value} doesn't have a digit#{digitIndex}");
        }

        void CheckIsDayOffByDayIndex()
        {
            Console.Clear();
            int dayIndex = input("Please, enter the number of the day of the week ");
            Console.Write(dayIndex == 6 || dayIndex == 7 ? "Yes, this day is a day off" : "No, this day is a working day");
        }

        void CheckIsTriangleIsosceles()
        {
            Console.Clear();
            int a = input("Enter a length of side \"a\" ");
            int b = input("Enter a length of side \"b\" ");
            int c = input("Enter a length of side \"c\" ");

            if (a == b || b == c || c == a)
                Console.Write("Bingo! this triangle is isosceles");
            else
                Console.Write("Sorry(, this triangle isn't isosceles");
        }

        void GetPersonAge()
        {
            Console.Clear();
            int dayOfBirth = input("Enter the day of your birth, like \"31\" ");
            int monthOfBirth = input("Enter the month of your birth, like \"11\" ");
            int yearOfBirth = input("Enter the year of your birth, like \"1980\" ");
            DateTime endPoint = new DateTime(2022, 7, 1);

            int CalculateTotalDays(int yearOfBirth, int monthOfBirth, int dayOfBirth, DateTime finalDate)
            {
                DateTime personDayOfBirth = new DateTime(yearOfBirth, monthOfBirth, dayOfBirth);
                TimeSpan ageOfThePerson = finalDate.Subtract(personDayOfBirth);
                int totalDays = Convert.ToInt32(ageOfThePerson.ToString().Split(".")[0]);
                return totalDays;
            }

            int totalDays = CalculateTotalDays(yearOfBirth, monthOfBirth, dayOfBirth, endPoint);
            int yearCount = totalDays / 365;
            int monthCount = totalDays % 365 / 30;
            int daysCount = totalDays % 365 % 30 - CalculateLeapYear(yearOfBirth, endPoint.Year);

            int CalculateLeapYear(int start, int end)
            {
                int leapYearsCount = 0;
                while (start <= end)
                {
                    if (start % 4 == 0)
                        leapYearsCount++;
                    start++;
                }
                return leapYearsCount;
            }

            Console.Write($"The person age is {totalDays} days, or {yearCount} year, {monthCount} month, {daysCount} days");
        }

        void GetDepositAmountAfterNMonth()
        {
            Console.Clear();
            int duration = input("Enter the number of months for your deposit ");
            double monthlyInterestOnDeposit = 0.015;
            double startDepo = 1000;
            double endDepo = startDepo;
            int currentMonth = 1;
            while (currentMonth <= duration)
            {
                endDepo *= (1 + 0.015);
                currentMonth++;
            }
            Console.Write($"Your total deposit after {duration} will be {Math.Round(endDepo, 2)}");
        }

        void GetFirstExtremumFromDigitsThatNumberConsist()
        {
            Console.Clear();
            int value = input("Please, enter any integer ");

            char[] chars = value.ToString().ToCharArray();
            int[] digits = new int[chars.Length];

            int minIndex = 0;
            int maxIndex = 0;
            int max = int.Parse(chars[0].ToString());
            int min = int.Parse(chars[0].ToString());

            for (int i = 0; i < digits.Length; i++)
            {
                digits[i] = chars[i] - '0';
                if (digits[i] > max)
                {
                    max = digits[i];
                    maxIndex = i;
                }
                else if (digits[i] < min)
                {
                    min = digits[i];
                    minIndex = i;
                }
            }

            if (minIndex == maxIndex)
                Console.Write("Error! All digits are the same");
            else
                Console.Write(minIndex < maxIndex ? "To the left is the minimum" : "To the left is the maximum");
        }

        // GetSecondDigitFromNumber();
        // getNDigitFromNumber();
        // SecondTaskAlmostInOneAction();
        // CheckIsDayOffByDayIndex();
        // CheckIsTriangleIsosceles();
        // GetPersonAge();
        // GetDepositAmountAfterNMonth();
        GetFirstExtremumFromDigitsThatNumberConsist();
    }
}
