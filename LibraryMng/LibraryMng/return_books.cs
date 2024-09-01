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
    public partial class return_books : Form
    {
        Library library;
        private string loggedInAdmin;
        public return_books(string loggedInAdmin)
        {
            InitializeComponent();
            library = new Library();
            this.loggedInAdmin = loggedInAdmin;
        }
        //loads the loans to the table 
        private void return_books_Load(object sender, EventArgs e)
        {
            DataTable booksDataTable = library.LoadLoansToTable();
            LoanTable.DataSource = booksDataTable;            
            LoanTable.DefaultCellStyle.BackColor = Color.Moccasin;
            LoanTable.DefaultCellStyle.ForeColor = Color.Black;
            LoanTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //filters the loans
        private void searchReturnBook_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchReturnBook.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {

                DataTable booksDataTable = (DataTable)LoanTable.DataSource;
                DataTable filteredDataTable = FilterDataTable(booksDataTable, searchText);

                LoanTable.DataSource = filteredDataTable;
            }
            else
            {

                LoanTable.DataSource = library.LoadLoansToTable();
            }
        }
        //filtering the data 
        private DataTable FilterDataTable(DataTable originalDataTable, string searchText)
        {
            DataTable filteredDataTable = originalDataTable.Clone();

            // Specify the name of the table you want to filter (e.g., "Loans")
            string tableName = "Loans";

            foreach (DataRow row in originalDataTable.Rows)
            {
                // Check if the column belongs to the specified table
                if (row.Table.TableName == tableName)
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
            }
            return filteredDataTable;
        }
        //returns the bookk
        private void returnBook_Click(object sender, EventArgs e)
        {
            string bookID = returnBookID.Text;

            if (string.IsNullOrEmpty(bookID))
            {
                MessageBox.Show("Please Enter a Book ID", "Empty BookID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string memberID = library.GetMemberIDFromBookID(bookID);

            Loan loan = library.GetMemberLoans(memberID).FirstOrDefault(b=>b.Book_ID == bookID);
            if (loan == null)
            {
                MessageBox.Show("Book with Entered ID is not found in Member's Loans", "No Book Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double overdueCharges = calculateOverdue(loan.DueDate);

            
            library.RemoveLoanFromDB(bookID);

          
            Book book = library.AvailableBooks.Find(b => b.BookID == bookID);
            if (book != null)
            {
                book.Availability = "Available";
                library.UpdateBookAvailability(book);
            }

           
            library.updateOverDue(memberID, overdueCharges);

            
            LoanTable.DataSource = null;
            LoanTable.DataSource = library.LoadLoansToTable();

            
            MessageBox.Show("Book Returned Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            ClearInputs();


        }
        private void ClearInputs()
        {
            returnBookID.Clear();
        }
        //calculates  member overdue at the return 
        private float calculateOverdue(DateTime dueDate)
        {
            double fine = 100;
            TimeSpan duration = DateTime.Now - dueDate;
            if (duration.TotalDays > 0)
            {
                return (float)(duration.TotalDays * fine); ;
            }
            return 0;
        }
        //loads the previous menu 
        private void returnBookBackBtn_Click(object sender, EventArgs e)
        {
            Librarian_Menu librarian_Menu = new Librarian_Menu(loggedInAdmin);
            librarian_Menu.Show();
            this.Hide();
        }
    }
}
