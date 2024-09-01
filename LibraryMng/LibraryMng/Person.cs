using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMng
{
    public class Person
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }

        public Person(string name, string gender, string address, DateTime dob)
        {
            Name = name;
            Gender = gender;
            Address = address;
            DOB = dob;
        }
    }
}
