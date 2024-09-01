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
    public partial class borrow_books : Form
    {
        Library library;
        private string loggedInUser;

        public borrow_books(string username)
        {
            InitializeComponent();
            library = new Library();
            this.loggedInUser = username;
        }

        private void borrow_books_Load(object sender, EventArgs e)
        {
            DataTable booksDataTable = library.LoadBooksToTable();
            borrowDataGrid.DataSource = booksDataTable;

            // Set DataGridView to span across the whole table
            borrowDataGrid.BackgroundColor = Color.Black;
            borrowDataGrid.DefaultCellStyle.ForeColor = Color.Moccasin;
            borrowDataGrid.DefaultCellStyle.BackColor = Color.Black;
            borrowDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }
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

        private void searchBookIDtoBorrow_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchBookIDtoBorrow.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {

                DataTable booksDataTable = (DataTable)borrowDataGrid.DataSource;
                DataTable filteredDataTable = FilterDataTable(booksDataTable, searchText);

                borrowDataGrid.DataSource = filteredDataTable;
            }
            else
            {

                borrowDataGrid.DataSource = library.LoadBooksToTable();
            }
        }

        private void borrowBook_Click(object sender, EventArgs e)
        {
            string bookID = bookIDtoBorrow.Text;
            if (string.IsNullOrEmpty(bookID))
            {
                MessageBox.Show("Please Enter a BookID to borrow a Book", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the book is already on loan
            if (library.IsBookonLoan(bookID))
            {
                MessageBox.Show("Book with entered ID is already on loan. Please choose another book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Book selectedBook = library.AvailableBooks.Find(b => b.BookID == bookID);
            if (selectedBook == null)
            {
                MessageBox.Show("Book with entered ID does not exist. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Member loggedInMember = library.Members.Find(m => m.getUserName() == loggedInUser);
            if (loggedInMember == null)
            {
                MessageBox.Show("Failed to retrieve logged-in member information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string loanID = library.GenerateLoanID();
            DateTime issueDate = DateTime.Now;
            DateTime dueDate = DateTime.Now.AddDays(14);

            Loan newLoan = new Loan(loanID, loggedInMember.Member_ID, loggedInMember.Name, selectedBook.BookID, selectedBook.Title, issueDate, dueDate);

            selectedBook.Availability = "On Loan";
            library.AddLoanToDB(newLoan);
            library.UpdateBookAvailability(selectedBook);
            library.AvailableBooks = library.LoadBooksFromDB();

            library.Loans.Add(newLoan);

            // Refresh data grid view
            borrowDataGrid.DataSource = null;
            borrowDataGrid.DataSource = library.LoadBooksToTable();

            MessageBox.Show("Book borrowed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear the book ID text box
            this.Hide();
            Member_Menu member_Menu = new Member_Menu(loggedInUser);
            member_Menu.Show();
        }

        private void borrowBackButton_Click(object sender, EventArgs e)
        {
            Member_Menu member_Menu = new Member_Menu(loggedInUser);
            this.Hide();
            member_Menu.Show();

        }
    }
}

