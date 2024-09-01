using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMng
{
    public partial class addBook : Form
    {
        private string loggedInAdmin;
        private string conn = ConfigurationManager.ConnectionStrings["LibraryConnectionString"].ConnectionString;
        public addBook(string username)
        {
            this.loggedInAdmin = username;
            InitializeComponent();
        }

        private void addBookToDB_Click(object sender, EventArgs e)
        {
            if (addBookID.Text == "" || addTitle.Text == "" || addAuthor.Text == "" || addISBN.Text == "")
            {
                MessageBox.Show("Please fill in all the fields", "Error Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string bookid = addBookID.Text;
            string Title = addTitle.Text;
            string Author = addAuthor.Text;
            long isbn;
            if (!long.TryParse(addISBN.Text, out isbn))
            {
                MessageBox.Show("Invalid ISBN Please Enter Numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connection  = new SqlConnection(conn))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO Books (Book_ID,Book_Name,Book_Author,ISBN) VALUES (@ID,@Title,@Author,@ISBN)"; ;
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", bookid);
                        command.Parameters.AddWithValue("@Title", Title);
                        command.Parameters.AddWithValue("@Author", Author);
                        command.Parameters.AddWithValue("@ISBN", isbn);

                        int rows = command.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Book added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Librarian_Menu librarian_Menu = new Librarian_Menu(loggedInAdmin);
                            librarian_Menu.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the book. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void addBookBackBtn_Click(object sender, EventArgs e)
        {
            Librarian_Menu librarian_Menu = new Librarian_Menu(loggedInAdmin);
            librarian_Menu.Show();
            this.Close();
        }
    }
}
