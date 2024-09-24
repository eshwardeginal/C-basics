using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Models
{
    public class Members
    {
        public string Name { get; set; }
        public List<Book> ListOfBookBorrowed { get; set; }

        public Members(string name)
        {
            Name = name;
            ListOfBookBorrowed = new List<Book>();  // Initialize the list of borrowed books
        }

        // Method to display member information and their borrowed books
        public void DisplayMemberInfo()
        {
            Console.WriteLine($"Member: {Name}");
            Console.WriteLine("Borrowed Books:");
            if (ListOfBookBorrowed.Count > 0)
            {
                foreach (var book in ListOfBookBorrowed)
                {
                    Console.WriteLine($"- {book.Title}");
                }
            }
            else
            {
                Console.WriteLine("No books borrowed.");
            }
        }
    }
}
