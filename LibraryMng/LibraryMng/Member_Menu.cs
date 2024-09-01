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
    public partial class Member_Menu : Form
    {
        private string conn = ConfigurationManager.ConnectionStrings["LibraryConnectionString"].ConnectionString;

        private string loggedInUser;
        Library library;
        public Member_Menu(string username)
        {
            InitializeComponent();
            this.library = new Library();
            this.loggedInUser = username;
            LoadUserDetails();
            
        }
        //takes the member back to the main menu
        private void memMenuBackBTN_Click(object sender, EventArgs e)
        {
            Member_Login member_Login = new Member_Login();
            this.Hide();
            member_Login.Show();
        }

        //viewing all the books
        private void mViewBooks_Click(object sender, EventArgs e)
        {
            view_all_books view_All_Books = new view_all_books(loggedInUser);
            this.Hide();
            view_All_Books.Show();
        }

        //takes the user to the borrow books menu 
        private void borrowBookBtn_Click(object sender, EventArgs e)
        {
            borrow_books borrow_Books = new borrow_books(loggedInUser);
            this.Hide();
            borrow_Books.Show();
        }

        //loads mebers in to the table 
        private void Member_Menu_Load(object sender, EventArgs e)
        {
            LoadMemberLoans();
        }
        //loads user details 
        private void LoadUserDetails()
        {
            
            WelcomeUser.TextAlign = ContentAlignment.MiddleCenter;
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                string qry = "SELECT * FROM Members WHERE Member_Username = @Username";
                using (SqlCommand cmd = new SqlCommand(qry, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", loggedInUser);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            WelcomeUser.Text = "Welcome " + reader["Name"].ToString() + "!";
                            username.Text = "Username: " + reader["Member_Username"].ToString();
                            memberID.Text = reader["Member_ID"].ToString();
                            Overdue.Text = "LKR "+ reader["Overdue"].ToString() + ".00";
                            DateTime dobDate = Convert.ToDateTime(reader["DOB"]);
                            dob.Text = "Date of Birth: " + dobDate.ToString("yyyy-MM-dd");
                        }
                    }
                }
            }
        }
        //gets member loans into the table 
        private DataTable getMemberLoansfromID(string memberID)
        {
            DataTable loansTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();
                    string qry = "SELECT Book_Name AS 'Book Name', Due_Date AS 'Due Date' FROM Loans WHERE Member_ID = @memberID";
                    using (SqlCommand cmd = new SqlCommand(qry, connection))
                    {
                        cmd.Parameters.AddWithValue("@memberID", memberID);
                        SqlDataReader reader = cmd.ExecuteReader();
                        loansTable.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to establish a connection: " + ex.Message, "Connection Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return loansTable;
        }
        //loading member loans 
        private void LoadMemberLoans()
        {
            string memberID = this.memberID.Text;
            DataTable loansTable = getMemberLoansfromID(memberID);

            personalLoans.DataSource = loansTable;
            personalLoans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Set cell style
            personalLoans.DefaultCellStyle.ForeColor = Color.Moccasin;
            personalLoans.DefaultCellStyle.BackColor = Color.Black;
        }
    }
}
