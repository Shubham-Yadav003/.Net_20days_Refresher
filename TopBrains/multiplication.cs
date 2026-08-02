using System;

class Multiplication
{
    static int[] MultiplicationTable(int n, int upto)
    {
        int[] row = new int[upto];

        for (int i = 1; i <= upto; i++)
        {
            row[i - 1] = n * i;
        }

        return row;
    }

    public static void Demo()
    {
        int n = int.Parse(Console.ReadLine());
        int upto = int.Parse(Console.ReadLine());

        int[] result = MultiplicationTable(n, upto);

        Console.WriteLine(string.Join(",", result));
    }
}