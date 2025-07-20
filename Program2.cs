
using System;
using System.Collections.Generic;

namespace Task_003_2;

class Book
{
    public string Title;
    public string Author;
    public string ISBN;
    public bool Availability;

    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        Availability = true;
    }

    public string DisplayBook()
    {
        return "Title: " + Title + ", Author: " + Author + ", ISBN: " + ISBN + ", Availability: " + Availability;
    }
}

class Library
{
    public List<Book> books = new List<Book>();

    public string AddBook()
    {
        Console.Write("Enter Title: ");
        string title = Console.ReadLine();

        Console.Write("Enter Author: ");
        string author = Console.ReadLine();

        Console.Write("Enter ISBN: ");
        string isbn = Console.ReadLine();

        Book book = new Book(title, author, isbn);
        books.Add(book);
        return "Book added.";
    }

    public string SearchBook()
    {
        Console.Write("Enter Title or Author to search: ");
        string s = Console.ReadLine();

        int index = 0;
        string result = "";
        while (index < books.Count)
        {
            if (books[index].Title.Contains(s) || books[index].Author.Contains(s))
            {
                result += books[index].DisplayBook() + "\n";
            }
            index++;
        }

        if (result == "")
        {
            return "No books found.";
        }

        return result;
    }

    public string BorrowBook()
    {
        Console.Write("Enter Title to borrow: ");
        string s = Console.ReadLine();

        int index = 0;
        while (index < books.Count)
        {
            if (books[index].Title == s && books[index].Availability == true)
            {
                books[index].Availability = false;
                return "Book borrowed.";
            }
            index++;
        }

        return "Book not available.";
    }

    public string ReturnBook()
    {
        Console.Write("Enter Title to return: ");
        string s = Console.ReadLine();

        int index = 0;
        while (index < books.Count)
        {
            if (books[index].Title == s && books[index].Availability == false)
            {
                books[index].Availability = true;
                return "Book returned.";
            }
            index++;
        }

        return "Book not found or already returned.";
    }
}

class Program
{
    static int Main(string[] args)
    {
        Library lib = new Library();
        bool run = true;

        while (run)
        {
            Console.WriteLine("\n1 - AddBook");
            Console.WriteLine("2 - SearchBook");
            Console.WriteLine("3 - BorrowBook");
            Console.WriteLine("4 - ReturnBook");
            Console.WriteLine("5 - Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            string msg = "";

            if (choice == 1)
            {
                msg = lib.AddBook();
            }
            else if (choice == 2)
            {
                msg = lib.SearchBook();
            }
            else if (choice == 3)
            {
                msg = lib.BorrowBook();
            }
            else if (choice == 4)
            {
                msg = lib.ReturnBook();
            }
            else if (choice == 5)
            {
                run = false;
                msg = "Goodbye.";
            }
            else
            {
                msg = "Wrong choice.";
            }

            Console.WriteLine(msg);
        }

        return 0;
    }
}
