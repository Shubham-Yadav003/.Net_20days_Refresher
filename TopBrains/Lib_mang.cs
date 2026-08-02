using System;
using System.Collections.Generic;
using System.Linq;

public class Lib1
{
    private List<dynamic> books = new List<dynamic>();

    public void AddBook(int id, string name, string publisher, double price)
    {
        books.Add(new
        {
            Id = id,
            Name = name,
            Publisher = publisher,
            Price = price
        });
    }

    public void UpdateBook(int id, string name, string publisher, double price)
    {
        foreach (var book in books)
        {
            if (book.Id == id)
            {
                books[books.IndexOf(book)] = new
                {
                    Id = id,
                    Name = name,
                    Publisher = publisher,
                    Price = price
                };
                return;
            }
        }
    }

    public void DeleteBook(int id)
    {
        for (int i = 0; i < books.Count; i++)
        {
            if (books[i].Id == id)
            {
                books.RemoveAt(i);
                return;
            }
        }
    }

    public void ViewAllBooks()
    {
        foreach (var book in books)
        {
            Console.WriteLine(book.Id + " - " + book.Name + " - " +
                              book.Publisher + " - " + book.Price);
        }
    }

    public void SearchByName(string name)
    {
        foreach (var book in books)
        {
            if (book.Name.ToLower().Contains(name.ToLower()))
                Console.WriteLine(book.Id + " - " + book.Name);
        }
    }

    public void SearchByPublisher(string publisher)
    {
        foreach (var book in books)
        {
            if (book.Publisher.ToLower().Contains(publisher.ToLower()))
                Console.WriteLine(book.Id + " - " + book.Name);
        }
    }

    public void HighestPriceBook()
    {
        var book = books.OrderByDescending(b => b.Price).First();

        Console.WriteLine(book.Name + " - " + book.Price);
    }

    public void LowestPriceBook()
    {
        var book = books.OrderBy(b => b.Price).First();

        Console.WriteLine(book.Name + " - " + book.Price);
    }
}

public class Lib
{
    public static void Run()
    {
        Lib1 library = new Lib1();

        library.AddBook(1, "C# Programming", "Microsoft", 500);
        library.AddBook(2, "Clean Code", "Pearson", 700);
        library.AddBook(3, "Java Basics", "Oracle", 400);

        Console.WriteLine("All Books:");
        library.ViewAllBooks();

        Console.WriteLine();
        Console.WriteLine("Search by Name:");
        library.SearchByName("C#");

        Console.WriteLine();
        Console.WriteLine("Search by Publisher:");
        library.SearchByPublisher("Pearson");

        Console.WriteLine();
        Console.WriteLine("Highest Price Book:");
        library.HighestPriceBook();

        Console.WriteLine();
        Console.WriteLine("Lowest Price Book:");
        library.LowestPriceBook();

        Console.WriteLine();
        Console.WriteLine("Updating Book:");
        library.UpdateBook(1, "Advanced C#", "Microsoft", 800);
        library.ViewAllBooks();

        Console.WriteLine();
        Console.WriteLine("Deleting Book:");
        library.DeleteBook(3);
        library.ViewAllBooks();
    }
}