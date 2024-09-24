using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Basics.Models
{
    public class Library
    {
        public List<Book> Books { get; set; }
        public List<Members> Members { get; set; }

        public Library()
        {
            Books = new List<Book>();  // List of all books in the library
            Members = new List<Members>();  // List of all library members
        }

        // Method to add a new book to the library
        public void AddBook(Book book)
        {
            Books.Add(book);
            Console.WriteLine($"Book '{book.Title}' added to the library.");
        }

        // Method to register a new member
        public void RegisterMember(Members member)
        {
            Members.Add(member);
            Console.WriteLine($"Member '{member.Name}' registered.");
        }

        // Method to borrow a book
        public void BorrowBook(string title, string memberName)
        {
            // Find the book and member
            Book bookToBorrow = Books.FirstOrDefault(b => b.Title == title && !b.isBorrowed);
            Members member = Members.FirstOrDefault(m => m.Name == memberName);

            if (bookToBorrow != null && member != null)
            {
                bookToBorrow.isBorrowed = true;
                member.ListOfBookBorrowed.Add(bookToBorrow);
                Console.WriteLine($"{memberName} borrowed '{title}'.");
            }
            else
            {
                Console.WriteLine("Book is either not available or member not found.");
            }
        }

        // Method to return a book
        public void ReturnBook(string title, string memberName)
        {
            Members member = Members.FirstOrDefault(m => m.Name == memberName);
            if (member != null)
            {
                Book bookToReturn = member.ListOfBookBorrowed.FirstOrDefault(b => b.Title == title);
                if (bookToReturn != null)
                {
                    bookToReturn.isBorrowed = false;
                    member.ListOfBookBorrowed.Remove(bookToReturn);
                    Console.WriteLine($"{memberName} returned '{title}'.");
                }
                else
                {
                    Console.WriteLine("The book was not borrowed by this member.");
                }
            }
            else
            {
                Console.WriteLine("Member not found.");
            }
        }

        // Method to display all available books
        public void DisplayAvailableBooks()
        {
            Console.WriteLine("Available Books:");
            foreach (var book in Books.Where(b => !b.isBorrowed))
            {
                book.getAllBooksToDisplay();
            }
        }

        // Method to display all members
        public void DisplayMembers()
        {
            Console.WriteLine("Library Members:");
            foreach (var member in Members)
            {
                member.DisplayMemberInfo();
            }
        }
    }

}
