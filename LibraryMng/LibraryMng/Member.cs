using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMng
{
    public class Member : Person
    {
        public string Member_ID { get; }
        private string UserName { get; }
        private string Password { get; }

        public double Overdue { get; set; }

        public List<Loan> PersonalLoans { get; set; } = new List<Loan>();

        public Member(string memberID, string userName, string password, string name, double overdue, string gender,string address, DateTime dOB) : base(name, gender, address, dOB)
        {
            Member_ID = memberID;
            UserName = userName;
            Password = password;
            Overdue = overdue;
           
        }
        //getting the username as its set to private 
        public string getUserName()
        {
            return UserName;
        }
        //getting the get passwrod as its set to private
        public string getPassword()
        {
            return Password;
        }
    }
}
