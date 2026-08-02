using System;

public class LargestNo
{
    public int FindLargest(int a, int b, int c)
    {
        int largest = a;

        if (b > largest)
            largest = b;

        if (c > largest)
            largest = c;

        return largest;
    }
}

public class LargestNoTest
{
    public static void Run()
    {
        LargestNo format = new LargestNo();

        int result = format.FindLargest(10, 25, 15);

        Console.WriteLine(result);
    }
}