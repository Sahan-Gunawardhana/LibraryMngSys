using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMng
{
    public class Book
    {
        public string BookID { get; }
        public string Title { get; }
        public string Author { get; }
        public long ISBN { get; }

        public string Availability { get; set; }

        public Book(string bookID, string title, string author, long iSBN)
        {
            BookID = bookID;
            Title = title;
            Author = author;
            ISBN = iSBN;
            Availability = "Available";
        }
    }
}
