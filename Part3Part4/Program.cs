using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; set; }
    public int Pages { get; set; }
    public int PublicationYear { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Book> books = new List<Book>();

        // Read book information from user
        while (true)
        {
            Console.Write("Name: ");
            string title = Console.ReadLine();

            if (string.IsNullOrEmpty(title))
            {
                break;
            }

            Console.Write("Pages: ");
            int pages = int.Parse(Console.ReadLine());

            Console.Write("Publication year: ");
            int publicationYear = int.Parse(Console.ReadLine());

            Book book = new Book
            {
                Title = title,
                Pages = pages,
                PublicationYear = publicationYear
            };

            books.Add(book);
        }

        // Ask user what to print
        Console.Write("What information will be printed? ");
        string input = Console.ReadLine();

        if (input == "everything")
        {
            // Print all book details
            foreach (Book book in books)
            {
                Console.WriteLine("{0}, {1} pages, {2}", book.Title, book.Pages, book.PublicationYear);
            }
        }
        else if (input == "title")
        {
            // Print only book titles
            foreach (Book book in books)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}