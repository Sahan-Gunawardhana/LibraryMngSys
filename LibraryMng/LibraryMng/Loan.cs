using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMng
{
    public class Loan
    {
       public string Loan_ID {  get; set; }

        public string Book_ID {  get; set; }

        public string Book_Name { get; set; }
        public string Member_ID { get; set; }
        
        public string Name { get; set; }
        
        public DateTime IssueDate {  get; set; }
        public DateTime DueDate { get; set; }

        public static List<Loan> LoanList { get; set; } = new List<Loan>();

        private string conn = ConfigurationManager.ConnectionStrings["LibraryConnectionString"].ConnectionString;

        public Loan(string loanID, string bookID, string title, string memberID, string name, DateTime issueDate, DateTime dueDate)
        {
            Loan_ID = loanID;
            Book_ID = bookID;
            Book_Name = title;
            Member_ID = memberID;
            Name = name;
            IssueDate = issueDate;
            DueDate = dueDate;
        }
    }
}
