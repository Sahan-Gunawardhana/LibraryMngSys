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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //login button block for the librarian 
        private void librarianLogin_Click(object sender, EventArgs e)
        {
            Librarian_Login librarian_Login = new Librarian_Login();
            this.Hide();
            librarian_Login.Show();
        }

        //librarian login back button acctiono
        private void memberMain_Click(object sender, EventArgs e)
        {
            Member_Login member_Login = new Member_Login();
            this.Hide();
            member_Login.Show();
        }
    }
}
