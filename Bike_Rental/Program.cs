using System;
using System.Collections.Generic;

public class Bike
{
    public string Model { get; set; }
    public int PricePerDay { get; set; }
    public string Brand { get; set; }
}

public class BikeUtility
{
    public void AddBikeDetails(string model, string brand, int pricePerDay)
    {
        int key = Program.bikeDetails.Count + 1;
        Program.bikeDetails.Add(key, new Bike { Model = model, Brand = brand, PricePerDay = pricePerDay });
    }

    public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
    {
        SortedDictionary<string, List<Bike>> groupedBikes = new SortedDictionary<string, List<Bike>>();

        foreach (var entry in Program.bikeDetails.Values)
        {
            if (!groupedBikes.ContainsKey(entry.Brand))
            {
                groupedBikes[entry.Brand] = new List<Bike>();
            }
            groupedBikes[entry.Brand].Add(entry);
        }

        return groupedBikes;
    }
}

public class Program
{
    public static SortedDictionary<int, Bike> bikeDetails = new SortedDictionary<int, Bike>();

    public static void Main(string[] args)
    {
        BikeUtility utility = new BikeUtility();

        while (true)
        {
            Console.WriteLine("1. Add Bike Details");
            Console.WriteLine("2. Group Bikes By Brand");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            
            string input = Console.ReadLine();
            int choice;
            if (!int.TryParse(input, out choice))
            {
                continue;
            }

            if (choice == 1)
            {
                Console.Write("Enter the model: ");
                string model = Console.ReadLine();

                Console.Write("Enter the brand: ");
                string brand = Console.ReadLine();

                Console.Write("Enter the price per day: ");
                int price = int.Parse(Console.ReadLine());

                utility.AddBikeDetails(model, brand, price);
                Console.WriteLine("Bike details added successfully");
            }
            else if (choice == 2)
            {
                SortedDictionary<string, List<Bike>> grouped = utility.GroupBikesByBrand();
                foreach (var group in grouped)
                {
                    foreach (var bike in group.Value)
                    {
                        Console.WriteLine($"{bike.Brand} {bike.Model}");
                    }
                }
            }
            else if (choice == 3)
            {
                break;
            }
        }
    }
}