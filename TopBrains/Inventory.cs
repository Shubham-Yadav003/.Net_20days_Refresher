using System;
using System.Collections.Generic;

class Electronics
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public string Brand { get; set; }
    public double Price { get; set; }

    public Electronics(int productId, string name, string brand, double price)
    {
        ProductId = productId;
        Name = name;
        Brand = brand;
        Price = price;
    }
}

class Grocery
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }

    public Grocery(int productId, string name, int quantity, double price)
    {
        ProductId = productId;
        Name = name;
        Quantity = quantity;
        Price = price;
    }
}

class Inventory<T>
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public List<T> GetAllItems()
    {
        return items;
    }

    public T FindItem(Predicate<T> match)
    {
        foreach (T item in items)
        {
            if (match(item))
                return item;
        }

        return default(T);
    }

    public bool RemoveItem(Predicate<T> match)
    {
        for (int i = 0; i < items.Count; i++)
        {
            if (match(items[i]))
            {
                items.RemoveAt(i);
                return true;
            }
        }

        return false;
    }
}

class Inventory
{
    public static void Demo()
    {
        Inventory<Electronics> electronics = new Inventory<Electronics>();

        electronics.AddItem(new Electronics(1, "Laptop", "Dell", 65000));
        electronics.AddItem(new Electronics(2, "Mobile", "Samsung", 30000));

        Console.WriteLine("---- Electronics Inventory ----");

        foreach (Electronics item in electronics.GetAllItems())
        {
            Console.WriteLine("ID: " + item.ProductId +
                              ", Name: " + item.Name +
                              ", Brand: " + item.Brand +
                              ", Price: " + item.Price);
        }

        Inventory<Grocery> grocery = new Inventory<Grocery>();

        grocery.AddItem(new Grocery(101, "Rice", 10, 500));
        grocery.AddItem(new Grocery(102, "Sugar", 5, 200));

        Console.WriteLine();
        Console.WriteLine("---- Grocery Inventory ----");

        foreach (Grocery item in grocery.GetAllItems())
        {
            Console.WriteLine("ID: " + item.ProductId +
                              ", Name: " + item.Name +
                              ", Qty: " + item.Quantity +
                              ", Price: " + item.Price);
        }

        Console.WriteLine();
        Console.WriteLine("---- Find Electronics Product (ID = 1) ----");

        Electronics found = electronics.FindItem(e => e.ProductId == 1);

        if (found != null)
            Console.WriteLine("Found: " + found.Name + " - " + found.Brand);

        Console.WriteLine();
        Console.WriteLine("---- Remove Grocery Product (ID = 102) ----");

        bool removed = grocery.RemoveItem(g => g.ProductId == 102);

        if (removed)
            Console.WriteLine("Product Removed Successfully");

        Console.WriteLine();
        Console.WriteLine("---- Updated Grocery Inventory ----");

        foreach (Grocery item in grocery.GetAllItems())
        {
            Console.WriteLine("ID: " + item.ProductId +
                              ", Name: " + item.Name +
                              ", Qty: " + item.Quantity +
                              ", Price: " + item.Price);
        }

        Console.WriteLine();
        Console.WriteLine("Generic Inventory System Executed Successfully");
    }
}