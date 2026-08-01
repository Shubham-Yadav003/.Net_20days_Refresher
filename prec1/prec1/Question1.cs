using System;

namespace RetailStorePractice
{
    class Question1
    {
        public static void Run()
        {
            double price;
            int quantity;
            double discount;

            
            Console.Write("Enter Item Price: ");

            if (!double.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine("Invalid Price. Please enter a numeric value.");
                return;
            }

            if (price < 0)
            {
                Console.WriteLine("Price cannot be negative.");
                return;
            }

            
            Console.Write("Enter Quantity: ");

            if (!int.TryParse(Console.ReadLine(), out quantity))
            {
                Console.WriteLine("Invalid Quantity. Please enter a whole number.");
                return;
            }

            if (quantity < 0)
            {
                Console.WriteLine("Quantity cannot be negative.");
                return;
            }

            
            Console.Write("Enter Discount Percentage: ");

            if (!double.TryParse(Console.ReadLine(), out discount))
            {
                Console.WriteLine("Invalid Discount. Please enter a numeric value.");
                return;
            }

            if (discount < 0)
            {
                Console.WriteLine("Discount cannot be negative.");
                return;
            }

            
            double subtotal = price * quantity;
            double discountAmount = subtotal * discount / 100;
            double finalAmount = subtotal - discountAmount;

            
            Console.WriteLine($"Price             : {price}");
            Console.WriteLine($"Quantity          : {quantity}");
            Console.WriteLine($"Discount (%)      : {discount}");
            Console.WriteLine($"Subtotal          : {Math.Round(subtotal, 2)}");
            Console.WriteLine($"Discount Amount   : {Math.Round(discountAmount, 2)}");
            Console.WriteLine($"Final Amount      : {Math.Round(finalAmount, 2)}");
        }
    }
}