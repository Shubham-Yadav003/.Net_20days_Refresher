using System;

namespace DAY_01
{
    public class Warehouse
    {
        static void Main(string[] args)
        {
            double length;
            double width;
            double height;

            while (true)
            {
                Console.WriteLine("Enter the Length of the package: ");
                if (double.TryParse(Console.ReadLine(), out length) && length > 0)
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a valid positive number for length.\n");
            }

            while (true)
            {
                Console.WriteLine("Enter the Width of the package: ");
                if (double.TryParse(Console.ReadLine(), out width) && width > 0)
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a valid positive number for width.\n");
            }

            while (true)
            {
                Console.WriteLine("Enter the Height of the package: ");
                if (double.TryParse(Console.ReadLine(), out height) && height > 0)
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a valid positive number for height.\n");
            }

            double volume = length * width * height;
            volume = Math.Round(volume, 2);
            Console.WriteLine($"The volume of the package is: {volume} cubic units.");
        }
    }
}