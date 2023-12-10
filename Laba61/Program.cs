//средний 3
﻿class Program
{
    static int SumOfDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number = number / 10;
        }
        return sum;
    }

    static void Main()
    {
        for (int i = 1000; i <= 9999; i++)
        {
            int firstTwoDigits = i / 100;
            int lastTwoDigits = i % 100;
            if (SumOfDigits(firstTwoDigits) == SumOfDigits(lastTwoDigits))
            {
                Console.WriteLine(i);
            }
        }
    }
}
