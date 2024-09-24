using Basics.Models;
using System;

class Program
{
    static void Main()
    {
        //Random random = new Random();
        //int number = random.Next(1, 100);  // Computer picks a random number between 1 and 100
        //int guess = 0;

        //Console.WriteLine("I'm thinking of a number between 1 and 100. Can you guess it?");

        //while (guess != number)
        //{
        //    guess = int.Parse(Console.ReadLine());  // Get the guess from the player

        //    if (guess < number)
        //    {
        //        Console.WriteLine("Too low! Try again.");
        //    }
        //    else if (guess > number)
        //    {
        //        Console.WriteLine("Too high! Try again.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Yay! You guessed it!");
        //    }
        //}

        Library library = new Library();

        // Add some books to the library
        library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald"));
        library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee"));
        library.AddBook(new Book("1984", "George Orwell"));

        // Register some members
        library.RegisterMember(new Members("Alice"));
        library.RegisterMember(new Members("Bob"));

        // Borrow books
        library.BorrowBook("1984", "Alice");

        // Display available books
        library.DisplayAvailableBooks();

        // Return a book
        library.ReturnBook("1984", "Alice");

        // Display available books again
        library.DisplayAvailableBooks();

        // Display members and their borrowed books
        library.DisplayMembers();
    }
}
