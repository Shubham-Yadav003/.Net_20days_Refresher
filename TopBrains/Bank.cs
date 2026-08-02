using System;

public class Bank1
{
    public int FinalBalance(int initialBalance, int[] transactions)
    {
        int balance = initialBalance;

        foreach (int transaction in transactions)
        {
            if (transaction >= 0)
            {
                balance += transaction;
            }
            else if (balance >= -transaction)
            {
                balance += transaction;
            }
        }

        return balance;
    }
}

public class Bank
{
    public static void Run()
    {
        Bank1 format = new Bank1();

        int[] transactions = { 500, -200, -1000, 300 };

        Console.WriteLine(format.FinalBalance(1000, transactions));
    }
}