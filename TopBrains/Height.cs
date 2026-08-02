using System;

public class HeightTest
{
    public string GetHeightCategory(int heightCm)
    {
        if (heightCm < 150)
            return "Short";

        if (heightCm < 180)
            return "Average";

        return "Tall";
    }
}

public class Height
{
    public static void Run()
    {
        HeightTest format = new HeightTest();

        Console.WriteLine(format.GetHeightCategory(175));
    }
}