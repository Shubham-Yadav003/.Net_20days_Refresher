using System;

public class Quest
{
    public int CountLuckyNumbers(int m, int n)
    {
        int count = 0;

        for (int i = m; i <= n; i++)
        {
            if (!IsPrime(i) && DigitSum(i * i) == DigitSum(i) * DigitSum(i))
                count++;
        }

        return count;
    }

    private bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    private int DigitSum(int number)
    {
        int sum = 0;

        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }

        return sum;
    }
}

public class Programming
{
    public static void Run()
    {
        Quest format = new Quest();

        Console.WriteLine(format.CountLuckyNumbers(20, 30));
    }
}