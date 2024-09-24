using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool isBorrowed { get; set; }

        public Book(string title, string author, bool isBorrowed)
        {
            Title = title;
            Author = author;
            this.isBorrowed = false;
        }

        public void getAllBooksToDisplay()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Available: {!isBorrowed}");
        }
    }
}
