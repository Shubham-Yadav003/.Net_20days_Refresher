using System;

class Swapping
{
     static void SwapRef(ref int a, ref int b)
    {
        a = a + b;
        b = a - b;
        a = a - b;
    }

    static void SwapOut(int a, int b, out int x, out int y)
    {
        x = b;
        y = a;
    }

    public static void Swap()
    {
        int a = 10, b = 20;

        Console.WriteLine($"Before ref: a = {a}, b = {b}");
        SwapRef(ref a, ref b);
        Console.WriteLine($"After ref: a = {a}, b = {b}");

        int x, y;

        Console.WriteLine($"Before out: a = {a}, b = {b}");
        SwapOut(a, b, out x, out y);
        Console.WriteLine($"After out: a = {x}, b = {y}");
    }
}