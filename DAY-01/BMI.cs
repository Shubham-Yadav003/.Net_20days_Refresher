using System;

namespace DAY_01
{
    public class BMI
    {
        static void Main(string[] args)
        {
            double weight;
            double height;

            while (true)
            {
                Console.Write("Enter your weight in kilograms: ");
                if (double.TryParse(Console.ReadLine(), out weight) && weight > 0)
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a valid positive number for weight.\n");
            }

            while (true)
            {
                Console.Write("Enter your height in meters: ");
                if (double.TryParse(Console.ReadLine(), out height) && height > 0)
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a valid positive number for height.\n");
            }

            double bmi = weight / (height * height);
            bmi = Math.Round(bmi, 2);

            if(bmi < 18.5)
            {
                Console.WriteLine("You are underweight.");
            }
            else if(bmi >= 18.5 && bmi < 24.9)
            {
                Console.WriteLine("You have a normal weight.");
            }
            else if(bmi >= 25 && bmi < 29.9)
            {
                Console.WriteLine("You are overweight.");
            }
            else
            {
                Console.WriteLine("You are obese.");
            }
        }
    }
}