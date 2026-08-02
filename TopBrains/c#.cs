using System;

public class Csharp1
{
    public string Process(string first, string second)
    {
        string result = "";

        foreach (char character in first)
        {
            char lower = char.ToLower(character);

            bool isConsonant = "aeiou".IndexOf(lower) == -1;
            bool existsInSecond = second.ToLower().Contains(lower);

            if (isConsonant && existsInSecond)
                continue;

            if (result.Length == 0 || char.ToLower(result[result.Length - 1]) != lower)
                result += character;
        }

        return result;
    }
}

public class Csharp
{
    public static void Run()
    {
        Csharp1 format = new Csharp1();

        Console.WriteLine(format.Process("Programming", "Gaming"));
    }
}