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
    public partial class view_all_books : Form
    {
        Library library;
        private string loggedInUser;
        public view_all_books(string username)
        {
            InitializeComponent();
            library = new Library();
            this.loggedInUser = username;
        }
           //loads all the books
        private void view_all_books_Load(object sender, EventArgs e)
        {
            DataTable booksDataTable = library.LoadBooksToTable();
            DisplayAllBooks.DataSource = booksDataTable;

            DisplayAllBooks.DataSource = booksDataTable;
            DisplayAllBooks.BackgroundColor = Color.Black;
            DisplayAllBooks.DefaultCellStyle.BackColor = Color.Black;
            DisplayAllBooks.DefaultCellStyle.ForeColor = Color.Moccasin;
            DisplayAllBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        //searches the data table according to the text 
        private void searchBooks_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchBooks.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                
                DataTable booksDataTable = (DataTable)DisplayAllBooks.DataSource;
                DataTable filteredDataTable = FilterDataTable(booksDataTable, searchText);

                DisplayAllBooks.DataSource = filteredDataTable;
            }
            else
            {
                
                DisplayAllBooks.DataSource = library.LoadBooksToTable();
            }
        }
        //filters data table 
        private DataTable FilterDataTable(DataTable originalDataTable, string searchText)
        {
            DataTable filteredDataTable = originalDataTable.Clone();

            foreach (DataRow row in originalDataTable.Rows)
            {
                foreach (DataColumn col in originalDataTable.Columns)
                {
                    if (row[col.ColumnName].ToString().Contains(searchText))
                    {
                        filteredDataTable.ImportRow(row);
                        break;
                    }
                }
            }
            return filteredDataTable;
        }
        //tajes the member to member menu 
        private void catalogBackBtn_Click(object sender, EventArgs e)
        {
            Member_Menu member_Menu = new Member_Menu(loggedInUser);
            this.Hide();
            member_Menu.Show();
        }
    }
}
