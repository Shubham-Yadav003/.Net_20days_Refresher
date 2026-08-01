using System;

namespace ConsoleAssignments
{
    class Question2
    {
        public static void Run()
        {
            double weight, height;

            
            Console.Write("Enter Weight (kg): ");

            if (!double.TryParse(Console.ReadLine(), out weight))
            {
                Console.WriteLine("Invalid weight. Please enter a numeric value.");
                return;
            }

            if (weight <= 0)
            {
                Console.WriteLine("Weight must be greater than zero.");
                return;
            }

            
            Console.Write("Enter Height (meters): ");

            if (!double.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Invalid height. Please enter a numeric value.");
                return;
            }

            if (height <= 0)
            {
                Console.WriteLine("Height must be greater than zero.");
                return;
            }

           
            double bmi = weight / (height * height);
            bmi = Math.Round(bmi, 2);

           
            string category;

            if (bmi < 18.5)
            {
                category = "Underweight";
            }
            else if (bmi < 25)
            {
                category = "Normal Weight";
            }
            else if (bmi < 30)
            {
                category = "Overweight";
            }
            else
            {
                category = "Obese";
            }

            
            Console.WriteLine($"Weight       : {weight} kg");
            Console.WriteLine($"Height       : {height} m");
            Console.WriteLine($"BMI          : {bmi}");
            Console.WriteLine($"Category     : {category}");
        }
    }
}