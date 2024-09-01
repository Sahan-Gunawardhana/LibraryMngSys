using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using System.Drawing;
using System.Runtime.InteropServices;

namespace LibraryMng
{
    public class Library
    {
        public List<Book> AvailableBooks { get; set; }
        public List<Member> Members { get; set; }
        public List<Librarian> Librarians { get; set; }

        public List<Loan> Loans { get; set; }

        public Library()
        {
            Members = LoadMemberFromDB();
            AvailableBooks = LoadBooksFromDB();
            Loans = LoadLoansFromDB();
            Librarians = new List<Librarian>();
        }
        private string conn = ConfigurationManager.ConnectionStrings["LibraryConnectionString"].ConnectionString;

        //getting laons to a list 
        public List<Loan>GetMemberLoans(string memberID)
        {
            return Loans.Where(PersonalLoan=>PersonalLoan.Member_ID == memberID).ToList();
        }
        public int GetLoanCount()
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                string qry = "SELECT TOP 1 Loan_ID FROM Loans ORDER BY Loan_ID DESC";
                using (SqlCommand command = new SqlCommand(qry, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        string newLoanID = result.ToString();
                        string num = newLoanID.Substring(3);
                        int newLoan = int.Parse(num);
                        return newLoan;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        //generating the laon id 
        public string GenerateLoanID()
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                string qry = "SELECT MAX(CAST(SUBSTRING(Loan_ID, 4, LEN(Loan_ID) - 3) AS INT)) FROM Loans WHERE ISNUMERIC(SUBSTRING(Loan_ID, 4, LEN(Loan_ID) - 3)) = 1";
                using (SqlCommand cmd = new SqlCommand(qry, connection))
                {
                    object obj = cmd.ExecuteScalar();
                    if (obj != null && obj != DBNull.Value)
                    {
                        int maxLoanID = (int)obj;
                        int newLoanID = maxLoanID + 1;
                        return "LID" + newLoanID.ToString("000");
                    }
                    else
                    {
                        return "LID001";
                    }
                }
            }
        }
        //checking if the book is on loan 
        public bool IsBookonLoan(string bookID)
        {
            return Loans.Any(loan => loan.Book_ID == bookID);
        }

        //checking if the book exists 
        public bool exisitingBook(string bookID)
        {
            return AvailableBooks.Any(b => b.BookID == bookID);
        }
        //removing a book id using the book 
        public bool removeBook(string bookID)
        {
            try
            {
                string removeQuery = "DELETE FROM Books WHERE Book_ID = @BookID";
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(removeQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@BookID", bookID);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // Return true if rows were affected (i.e., book was removed)
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to remove book from the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Error occurred while removing book
            }
        }
        //removing the member using member id 
        public bool removeMember(string memberID)
        {
            try
            {
                string remQry = "DELETE FROM Members WHERE Member_ID = @MemberID";
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(remQry, connection))
                    {
                        cmd.Parameters.AddWithValue("@MemberID", memberID);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to remove member from the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //loading books from the data base 
        public List<Book> LoadBooksFromDB()
        {
            List<Book> books = new List<Book>();

            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Books", connection);
                    SqlDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                    {
                        Book book = new Book(read["Book_ID"].ToString(), read["Book_Name"].ToString(), read["Book_Author"].ToString(), Convert.ToInt64(read["ISBN"].ToString()))
                        {
                            Availability = read["Availability"].ToString()
                        };
                        books.Add(book);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading members from the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return books;
        }
        //loading members from the data base 
        public List<Member> LoadMemberFromDB()
        {
            List<Member> members = new List<Member>();

            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Members", connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Member member = new Member(
                            reader["Member_ID"].ToString(),
                            reader["Member_Username"].ToString(),
                            reader["Member_Password"].ToString(),
                            reader["Name"].ToString(),
                            Convert.ToDouble(reader["Overdue"].ToString()),
                            reader["Gender"].ToString(),
                            reader["MemAddress"].ToString(),
                            Convert.ToDateTime(reader["DOB"].ToString())
                        );
                        members.Add(member);
                    }
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("An error occurred while loading members from the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return members;
        }

        //loading all the loans to a list 
        public List<Loan> LoadLoansFromDB()
        {
            List<Loan> loans = new List<Loan>();
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    string qry = "SELECT * FROM Loans";
                    using (SqlCommand cmd = new SqlCommand(qry, connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Loan loan = new Loan(reader["Loan_ID"].ToString(), reader["Book_ID"].ToString(), reader["Book_Name"].ToString(), reader["Member_ID"].ToString(), reader["Name"].ToString(), Convert.ToDateTime(reader["Issue_Date"].ToString()), Convert.ToDateTime(reader["Due_Date"].ToString()));
                            loans.Add(loan);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to establish a connection" + ex.Message, "Connection Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return loans;
        }
        //load loans into a table 
        public DataTable LoadLoansToTable()
        {
            DataTable loans = new DataTable();
            try
            {
                using(SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    string qry = "SELECT Loan_ID, Book_ID, Book_Name,Member_ID, Name, Issue_Date, Due_Date FROM Loans";
                    using ( SqlCommand cmd = new SqlCommand(qry, connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        loans.Load(reader);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to establish a connection" + ex.Message, "Connection Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return loans;
        }

        //loading members into a table 
        public DataTable LoadMembersToTable()
        {
            DataTable memberTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT Member_ID AS [Member ID], Name, Gender, MemAddress AS [Member Address], DOB AS [Date of Birth], Overdue FROM Members", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                memberTable.Load(reader);
            }
            return memberTable;
        }
        //loading books to a table 
        public DataTable LoadBooksToTable()
        {
            DataTable bookTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT Book_ID AS [Book ID], Book_Name AS [Book Name], Book_Author AS [Book Author], ISBN, Availability FROM Books", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                bookTable.Load(reader);
            }
            return bookTable;
        }
        //updating the book avaialability when the book is borrowed or returned
        public void UpdateBookAvailability(Book book)
        {
            string qry = "UPDATE Books SET Availability = @Availability Where Book_ID = @BookID AND Book_Name = @Title";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(qry, connection))
                {
                    cmd.Parameters.AddWithValue("@BookID", book.BookID);
                    cmd.Parameters.AddWithValue("@Title", book.Title);
                    cmd.Parameters.AddWithValue("@Availability", book.Availability);
                    cmd.ExecuteNonQuery();
                }
                Book updateStatus = AvailableBooks.Find(b => b.BookID == book.BookID);
                if (updateStatus != null)
                {
                    updateStatus.Availability = book.Availability;
                }
            }
        }
        //adding the loan to the data base 
        public void AddLoanToDB(Loan loan)
        {
            string qry = "INSERT INTO Loans (Loan_ID, Book_ID, Book_Name,Member_ID, Name, Issue_Date, Due_Date) " +
                 "VALUES (@LoanID, @MemberID, @Name, @BookID, @BookName, @IssueDate, @DueDate)";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(qry, connection))
                {
                    cmd.Parameters.AddWithValue("@LoanID", loan.Loan_ID);
                    cmd.Parameters.AddWithValue("@MemberID", loan.Member_ID);
                    cmd.Parameters.AddWithValue("@Name", loan.Name);
                    cmd.Parameters.AddWithValue("@BookID", loan.Book_ID);
                    cmd.Parameters.AddWithValue("@BookName", loan.Book_Name);
                    cmd.Parameters.AddWithValue("@IssueDate", loan.IssueDate);
                    cmd.Parameters.AddWithValue("@DueDate", loan.DueDate);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        //removing the loan from the data base when returned
        public void RemoveLoanFromDB(string bookID)
        {
            string dltqry = "DELETE FROM Loans Where Book_ID = @BookID";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(dltqry, connection))
                {
                    cmd.Parameters.AddWithValue("@BookID", bookID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //updating the overdue
        public void updateOverDue(string memberID, double overdue)
        {
            string qry = "UPDATE Members SET OVERDUE = @Overdue WHERE Member_ID = @MemberID";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(qry, connection))
                {
                    cmd.Parameters.AddWithValue("@Ovverdue", overdue);
                    cmd.Parameters.AddWithValue("@MemberID", memberID);
                }
            }
        }
        //retreiving the overdue 
        public Double getOverDue(string username)
        {
            Member loggedInMember = Members.FirstOrDefault(m => m.getUserName() == username);

            if (loggedInMember == null)
            {
                return loggedInMember.Overdue;
            }
            return 0;
        }
        //get member specific overdue 
        public double getMemberOverDue(string memberID)
        {
            Member loggedInMember = Members.FirstOrDefault(m =>m.Member_ID == memberID);
            if (loggedInMember == null)
            {
                return loggedInMember.Overdue;
            }
            return 0;
        }
        
        //getting the member id using the booking id when returning 
        public string GetMemberIDFromBookID(string bookID)
        {
            try
            {
               
                foreach (Loan loan in Loans)
                {
                    if (loan.Book_ID == bookID)
                    {
                        
                        return loan.Member_ID;
                    }
                }
                throw new Exception("No loan found for the provided book ID.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Loan Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }

}
