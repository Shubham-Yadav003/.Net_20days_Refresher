using System;

namespace DAY_01
{
    public class BankAccount
    {
        static void Main(string[] args)
        {
            double balance;
            double depositAmount;
            double withdrawalAmount;

            while (true)
            {
                Console.Write("Enter the opening balance: ");
                if (double.TryParse(Console.ReadLine(), out balance) && balance >= 0)
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a valid non-negative number for the opening balance.\n");
            }

            while (true)
            {
                Console.Write("Enter the deposit amount: ");
                if (double.TryParse(Console.ReadLine(), out depositAmount) && depositAmount >= 0)
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a valid non-negative number for the deposit amount.\n");
            }

            while (true)
            {
                Console.Write("Enter the withdrawal amount: ");
                if (double.TryParse(Console.ReadLine(), out withdrawalAmount) && withdrawalAmount >= 0)
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a valid non-negative number for the withdrawal amount.\n");
            }

            double UpdatedBalance = balance + depositAmount;

            if(UpdatedBalance < withdrawalAmount)
            {
                Console.WriteLine("Insufficient funds. Withdrawal not allowed.");
            }
            else
            {
                UpdatedBalance -= withdrawalAmount;
            }

            Console.WriteLine($"Updated balance: {UpdatedBalance:F2}");
        }
    }
}
