using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMng
{
    public partial class Member_Login : Form
    {
        Library library;
        private string conn = ConfigurationManager.ConnectionStrings["LibraryConnectionString"].ConnectionString;
        public Member_Login()
        {
            InitializeComponent();
        }

        //redirects users to the sign up menu
        private void memberSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Hide();
            signUp.Show();
        }

        //logs in the member 
        private void memerLoginBackBTN_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        //checks if the credentials are valid with the member login
        private void memberLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(memberUserName.Text) || string.IsNullOrEmpty(memberPassword.Text))
            {
                MessageBox.Show("Please Enter Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string username = memberUserName.Text;
                string password = memberPassword.Text;

                using (SqlConnection sqlConn = new SqlConnection(conn))
                {
                    sqlConn.Open();
                    string qry = "SELECT * FROM Members WHERE Member_Username = @username AND Member_Password = @password";
                    using (SqlCommand cmd = new SqlCommand(qry, sqlConn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Member_Menu member_Menu = new Member_Menu(username);
                                this.Hide();
                                member_Menu.Show();
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
    }
}
