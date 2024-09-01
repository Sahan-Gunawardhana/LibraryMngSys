using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LibraryMng.Library;

namespace LibraryMng
{
    public partial class Librarian_Menu : Form
    {
        private string loggedInAdmin;
        public Librarian_Menu(string username)
        {
            this.loggedInAdmin = username;
            InitializeComponent();
        }

        //ibraran menu back action
        private void libMenuBackBTN_Click(object sender, EventArgs e)
        {
            Librarian_Login librarian_Login = new Librarian_Login();
            this.Hide();
            librarian_Login.Show();
        }
        //add book button 
        private void addBookMenu_Click(object sender, EventArgs e)
        {
            add_or_remove add_Or_Remove = new add_or_remove(loggedInAdmin);
            this.Hide();
            add_Or_Remove.Show();

            
        }
        //display all members for the librarians
        private void lViewAllMembers_Click(object sender, EventArgs e)
        {
            viewMembers viewMembers = new viewMembers(loggedInAdmin);
            this.Hide();
            viewMembers.Show();
            
        }

        //removing mebers with the click 
        private void removeMember_Click(object sender, EventArgs e)
        {
            remove_member remove_Member_ = new remove_member(loggedInAdmin);
            this.Hide();
            remove_Member_.Show();
        }

        //returning the book button 
        private void rtrnBook_Click(object sender, EventArgs e)
        {
            return_books return_Books = new return_books(loggedInAdmin);
            this.Hide();
            return_Books.Show();
        }

        private void lViewAllLoans_Click(object sender, EventArgs e)
        {
            view_all_loans view_All_Loans = new view_all_loans(loggedInAdmin);
            this.Hide();
            view_All_Loans.Show();
        }
    }
}
