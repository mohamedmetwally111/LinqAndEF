using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public int AuthorID { get; set; }
        public Author Author { get; set; }

        public List<Loan> Loans { get; set; }

    }
}
