using System;

public class Format
{
    public string Calculate(string expression)
    {
        string[] parts = expression.Split(' ');

        if (parts.Length != 3)
            return "Error:InvalidExpression";

        if (!int.TryParse(parts[0], out int a) || !int.TryParse(parts[2], out int b))
            return "Error:InvalidNumber";

        string op = parts[1];

        if (op == "/" && b == 0)
            return "Error:DivideByZero";

        switch (op)
        {
            case "+":
                return (a + b).ToString();

            case "-":
                return (a - b).ToString();

            case "*":
                return (a * b).ToString();

            case "/":
                return (a / b).ToString();

            default:
                return "Error:UnknownOperator";
        }
    }
}

public class ArithmeticTest
{
    public static void Run()
    {
        Format format = new Format();

        Console.WriteLine(format.Calculate("10 + 5"));
        Console.WriteLine(format.Calculate("10 / 0"));
        Console.WriteLine(format.Calculate("10 abc 5"));
        Console.WriteLine(format.Calculate("10 + abc"));
        Console.WriteLine(format.Calculate("10+5"));
    }
}