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
    public partial class SignUp : Form
    {
        private string conn = ConfigurationManager.ConnectionStrings["LibraryConnectionString"].ConnectionString;
        public SignUp()
        {
            InitializeComponent();
        }
        //gets the member count 
        private int memberCount()
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                string qry = "SELECT TOP 1 Member_ID FROM Members ORDER BY Member_ID DESC";
                using (SqlCommand command = new SqlCommand(qry, connection))
                {
                    object obj = command.ExecuteScalar();
                    if (obj != null && obj != DBNull.Value)
                    {
                        string memID = obj.ToString();
                        string numId = memID.Substring(1);
                        int newMem = int.Parse(numId);
                        return newMem;

                    }
                    else
                    {
                        return 0;
                    }

                }
            }
        }
        //generates the member id 
        private string genMemID()
        {
            int memCount = memberCount() + 1;
            return "M" + memCount.ToString("D3");
        }
        //signs up the memnber 
        private void sup_Click(object sender, EventArgs e)
        {
            string username = userName.Text;
            string password = Password.Text;
            string name = NameInput.Text;
            string address = Address.Text;
            string gendr = (MaleRadio.Checked) ? "Male" : "Female";
            DateTime dateTime = DOB.Value;
            string memId = genMemID();

            string qry = "INSERT INTO Members(Member_ID,Member_Username, Member_Password, Name, Gender, MemAddress, DOB) " +
                "VALUES(@memId, @username, @password, @name, @gender, @memAdd, @dob)";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(qry, connection))
                {
                    cmd.Parameters.AddWithValue("@memId", memId);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@gender", gendr);
                    cmd.Parameters.AddWithValue("@memAdd", address);
                    cmd.Parameters.AddWithValue("@dob", dateTime);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sign Up Successfull", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Member_Login member_Login = new Member_Login();
                    this.Hide();
                    member_Login.Show();
                }
            }
        }

        //takes te member back to the member login
        private void memSignUpBackBTN_Click(object sender, EventArgs e)
        {
            Member_Login member_Login = new Member_Login();
            this.Hide();
            member_Login.Show();
        }
    }
}
