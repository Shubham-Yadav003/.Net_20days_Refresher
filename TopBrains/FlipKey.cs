using System;

public class FlipKey
{
    public string CleanseAndInvert(string input)
    {
        if (string.IsNullOrEmpty(input) || input.Length < 6)
            return "Invalid Input";

        foreach (char c in input)
        {
            if (!char.IsLetter(c))
                return "Invalid Input";
        }

        input = input.ToLower();

        string result = "";

        foreach (char c in input)
        {
            if (c % 2 != 0)
                result += c;
        }

        string reversed = "";

        for (int i = result.Length - 1; i >= 0; i--)
        {
            reversed += result[i];
        }

        char[] finalResult = reversed.ToCharArray();

        for (int i = 0; i < finalResult.Length; i += 2)
        {
            finalResult[i] = char.ToUpper(finalResult[i]);
        }

        return new string(finalResult);
    }

    public static void Demo()
    {
        FlipKey solution = new FlipKey();

        string input = Console.ReadLine();

        string result = solution.CleanseAndInvert(input);

        Console.WriteLine(result);
    }
}