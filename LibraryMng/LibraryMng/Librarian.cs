using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMng
{
    public class Librarian : Person
    {
        public string LibrarianID { get; set; }
        private string AdUsername { get; set; }
        private string AdPassword { get; set; }

        public Librarian(string librarianID, string adUsername, string adPassword, string name, string gender, string address, DateTime dOB) : base(name, gender,address, dOB)
        {
            LibrarianID = librarianID;
            AdUsername = adUsername;
            AdPassword = adPassword;
        }
    }
}
