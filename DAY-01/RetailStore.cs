using System;

namespace DAY_01
{
    public class RetailStore
    {
        static void Main(string[] args)
        {
            double itemPrice;
            int itemQuantity;
            double discountPercentage;

            while (true)
            {
                Console.Write("Enter the item price: ");
                if(double.TryParse(Console.ReadLine(), out itemPrice) && itemPrice >= 0)
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a valid non-negative number.\n");
            }

            while (true)
            {
                Console.Write("Enter the item quantity: ");
                if(int.TryParse(Console.ReadLine(), out itemQuantity) && itemQuantity >= 0)
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a valid number of items.\n");
            }

            while (true)
            {
                Console.Write("Enter the discount percentage: ");
                if(double.TryParse(Console.ReadLine(), out discountPercentage) && discountPercentage >= 0 && discountPercentage <= 100)
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a discount between 0 to 100.\n");
            }

            double subTotal = itemPrice * itemQuantity;
            subTotal = Math.Round(subTotal, 2);
            double discountAmount = subTotal * (discountPercentage / 100);
            discountAmount = Math.Round(discountAmount, 2);
            double finalPayableAmount = subTotal - discountAmount;
            finalPayableAmount = Math.Round(finalPayableAmount, 2);

            Console.WriteLine($"Price of the item: {itemPrice:F2}");
            Console.WriteLine($"Quantity of the item: {itemQuantity}");
            Console.WriteLine($"Discount percentage: {discountPercentage:F2}%");
            Console.WriteLine($"Subtotal: {subTotal:F2}");
            Console.WriteLine($"Discount amount: {discountAmount:F2}");
            Console.WriteLine($"Final payable amount: {finalPayableAmount:F2}");
        }
    }
}
