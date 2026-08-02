using System;

public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public double BasePrice { get; set; }
    public int Quantity { get; set; }
    public bool IsPremiumCustomer { get; set; }
}

public class PricingEngine
{
    public void Calculate(Product product, string strategy, Func<Product, double> calculator)
    {
        double price = calculator(product);

        Console.WriteLine("========= PRICE CALCULATION =========");
        Console.WriteLine("Product  : " + product.Name);
        Console.WriteLine("Strategy : " + strategy);
        Console.WriteLine("Price    : " + price);
        Console.WriteLine("-----------------------------------");
        Console.WriteLine();
    }
}

public class Dynamic
{
    public static void Run()
    {
        Product product = new Product
        {
            ProductId = 901,
            Name = "Laptop",
            BasePrice = 60000,
            Quantity = 12,
            IsPremiumCustomer = true
        };

        Func<Product, double> festivalPricing =
            p => p.BasePrice - (p.BasePrice * 0.20);

        Func<Product, double> premiumPricing =
            p => p.BasePrice - (p.BasePrice * 0.15);

        Func<Product, double> bulkPricing =
            p => p.BasePrice - (p.BasePrice * 0.25);

        PricingEngine engine = new PricingEngine();

        engine.Calculate(product, "Festival", festivalPricing);
        engine.Calculate(product, "Premium", premiumPricing);
        engine.Calculate(product, "Bulk", bulkPricing);
    }
}