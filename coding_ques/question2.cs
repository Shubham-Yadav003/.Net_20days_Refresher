using System;

namespace Banksys
{
    public class Account
    {
        private string name;
        private double balance;

        public Account(string name, double balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public void deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }

        public double getBalance()
        {
            return balance;
        }

        public void setName(string newName)
        {
            name = newName;
        }

        public string getName()
        {
            return name;
        }
    }

    class SecondProgram
    {
        public static void Question2()
        {
            Account account1 = new Account("Alok Mittal", 1250.00);
            Console.WriteLine(account1.getBalance());

            account1.setName("John Doe");
            Console.WriteLine(account1.getName());

            account1.deposit(500.00);
            Console.WriteLine(account1.getBalance());

            Account account2 = new Account("Riya Amit Mehta", 1250.50);
            Console.WriteLine(account2.getBalance());
            Console.WriteLine(account2.getBalance());
            Console.WriteLine(account2.getName());
        }
    }
}