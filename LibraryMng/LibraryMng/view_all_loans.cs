using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMng
{
    public partial class view_all_loans : Form
    {
        private string loggedInAdmin;
        Library library;
        public view_all_loans(string username)
        {

            InitializeComponent();
            library = new Library();
            this.loggedInAdmin = username;

        }
        //viewing all the loans
        private void view_all_loans_Load(object sender, EventArgs e)
        {
            DataTable loanDataTable = library.LoadLoansToTable();
            viewAllLoans.DataSource = loanDataTable;
            viewAllLoans.DataSource = loanDataTable;
            viewAllLoans.BackgroundColor = Color.Moccasin;
            viewAllLoans.DefaultCellStyle.BackColor = Color.Moccasin;
            viewAllLoans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        //goes back to the main mennu 
        private void currentLoansBackBtn_Click(object sender, EventArgs e)
        {
            Librarian_Menu librarian_Menu = new Librarian_Menu(loggedInAdmin);
            librarian_Menu.Show();
            this.Hide();
        }
    }
}
