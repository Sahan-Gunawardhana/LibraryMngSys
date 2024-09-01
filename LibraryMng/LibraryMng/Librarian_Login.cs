using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace LibraryMng
{
    public partial class Librarian_Login : Form
    {
        private string conn = ConfigurationManager.ConnectionStrings["LibraryConnectionString"].ConnectionString;

        public Librarian_Login()
        {
            InitializeComponent();
        }

        //librarian login 
        private void librarianLogin_Click(object sender, EventArgs e)
        {
            string username = adminUserName.Text;
            string password = adminPassword.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Enter your username and password", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection sqlConn = new SqlConnection(conn))
                {
                    sqlConn.Open();
                    string qry = "SELECT *FROM librarians WHERE Admin_Username = @username AND Admin_Password = @password";
                    using (SqlCommand cmd = new SqlCommand(qry, sqlConn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue ("@password", password);
                        using (SqlDataReader  reader = cmd.ExecuteReader())
                        {
                            if(reader.Read())
                            {
                                Librarian_Menu librarian_Menu = new Librarian_Menu(username);
                                this.Hide();
                                librarian_Menu.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                    }


                }
            }
        }

        //librarian login back action 
        private void libloginBackBN_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
