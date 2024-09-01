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
    
    public partial class add_or_remove : Form
    {
        Library library;
        private string loggedInAdmin;
        public add_or_remove(string username)
        {
            library = new Library();
            InitializeComponent();
            this.loggedInAdmin = username;
        }

        //opens add book menu 
        private void addBook_Click(object sender, EventArgs e)
        {
            addBook addbook = new addBook(loggedInAdmin);
            this.Hide();
            addbook.Show();
        }
        //opens remove book form
        private void rmvBook_Click(object sender, EventArgs e)
        {
            removeBook removeBook = new removeBook(loggedInAdmin);
            this.Hide();
            removeBook.Show();
        }

        //loads books into the data table when the form loads 
        private void add_or_remove_Load(object sender, EventArgs e)
        {
            DataTable booksDataTable = library.LoadBooksToTable();
            displayBooks.DataSource = booksDataTable;
            displayBooks.BackgroundColor = Color.Moccasin;
            displayBooks.DefaultCellStyle.BackColor = Color.Moccasin;
            displayBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //back to the librarian menu 
        private void addOrRemoveBackBtn_Click(object sender, EventArgs e)
        {
            Librarian_Menu librarian_Menu = new Librarian_Menu(loggedInAdmin);
            librarian_Menu.Show();
            this.Hide();
        }
        //filters the daa table according to the search 
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

        //search books text field event
        private void searchBookCat_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchBookCat.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {

                DataTable booksDataTable = (DataTable)displayBooks.DataSource;
                DataTable filteredDataTable = FilterDataTable(booksDataTable, searchText);

                displayBooks.DataSource = filteredDataTable;
            }
            else
            {

                displayBooks.DataSource = library.LoadBooksToTable();
            }
        }
    }
}
