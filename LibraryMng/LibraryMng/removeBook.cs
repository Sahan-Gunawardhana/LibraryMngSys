using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMng
{
    public partial class removeBook : Form
    {
        private string loggedInUser;
        Library library;
        private string conn = ConfigurationManager.ConnectionStrings["LibraryConnectionString"].ConnectionString;
        public removeBook(string loggedInUser)
        {
            library = new Library();
            InitializeComponent();
            this.loggedInUser = loggedInUser;
        }

        //removes the book on click 
        private void remove_Book_Click(object sender, EventArgs e)
        {
            string bookToRemove = removeBookID.Text;
            if (string.IsNullOrEmpty(bookToRemove) )
            {
                MessageBox.Show("Please Enter a BookID to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                bool isBookOnLoan = library.IsBookonLoan(bookToRemove);
                if (isBookOnLoan )
                {
                    MessageBox.Show("The Book is already on laon", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool existingBook = library.exisitingBook(bookToRemove);
                    if (!existingBook)
                    {
                        MessageBox.Show("That book does not exist in the library", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        bool bookRemoved =library.removeBook(bookToRemove);
                        if (bookRemoved)
                        {
                            MessageBox.Show("Book was removed from Database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            removeBookTable.DataSource = library.LoadBooksToTable();
                            clearints();
                            
                        }
                        else
                        {
                            MessageBox.Show("Book with Entered ID Does not Exist in Database", "Error Invalid BookID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clearints();
                        }
                    }
                }
            }
        }
        //clears inputs 
        private void clearints()
        {
            removeBookID.Clear();
        }
        //loads book to the table 
        private void removeBook_Load(object sender, EventArgs e)
        {
            DataTable booksDataTable = library.LoadBooksToTable();
            removeBookTable.DataSource = booksDataTable;
            removeBookTable.BackgroundColor = Color.Moccasin;
            removeBookTable.DefaultCellStyle.BackColor = Color.Moccasin;
            removeBookTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            removeBookTable.DefaultCellStyle.ForeColor = Color.Black;
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
        //takes the librarian back to the librarian menu 
        private void addBookBackBtn_Click(object sender, EventArgs e)
        {
            Librarian_Menu librarian_Menu = new Librarian_Menu(loggedInUser);
            librarian_Menu.Show();
            this.Hide();
        }

        //filters the  data table 
        private void removeBookSearch_TextChanged_1(object sender, EventArgs e)
        {
            string searchText = removeBookSearch.Text.Trim();

            DataTable originalBooksDataTable = (DataTable)removeBookTable.DataSource;

            if (!string.IsNullOrEmpty(searchText))
            {
                DataTable filteredDataTable = FilterDataTable(originalBooksDataTable, searchText);
                removeBookTable.DataSource = filteredDataTable;
            }
            else
            {
                // If the search text is empty, reset the DataSource to the original DataTable
                removeBookTable.DataSource = originalBooksDataTable;
            }
        }
    }
}
