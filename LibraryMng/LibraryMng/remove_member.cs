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
    public partial class remove_member : Form
    {
        Library library;
        private string loggedInAdmin;
        public remove_member(string loggedInAdmin)
        {
            library = new Library();
            InitializeComponent();
            this.loggedInAdmin = loggedInAdmin;
        }

        //loads member details into the table 
        private void remove_member_Load(object sender, EventArgs e)
        {
            DataTable memberDataTable = library.LoadMembersToTable();
            removeMemberTable.DataSource = memberDataTable;
            removeMemberTable.BackgroundColor = Color.Moccasin;
            removeMemberTable.DefaultCellStyle.BackColor = Color.Moccasin;
            removeMemberTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
        //removes the member when clicked 
        private void removeMember_Click(object sender, EventArgs e)
        {
            string memberToRemove = memberIdToRemove.Text;
            if (string.IsNullOrEmpty(memberToRemove))
            {
                MessageBox.Show("Please Enter a Member Id to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                bool exisitngMember = library.Members.Any(m => m.Member_ID == memberToRemove);
                if (!exisitngMember)
                {
                    MessageBox.Show("This member does not exist in this library", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool memberRemoved = library.removeMember(memberToRemove);
                    if (memberRemoved)
                    {
                        MessageBox.Show("Member was removed from Database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        removeMemberTable.DataSource = library.LoadMembersToTable();
                        clearints();
                    }
                    else
                    {
                        MessageBox.Show("Failed to remove member from Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clearints();
                    }
                }
            }
        }
        //clears te inputs 
        public void clearints()
        {
            memberIdToRemove.Clear();
        }
        //takes the text change to filter the data 
        private void searchMember_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchMember.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                DataTable booksDataTable = (DataTable)removeMemberTable.DataSource;
                DataTable filteredDataTable = FilterDataTable(booksDataTable, searchText);

                removeMemberTable.DataSource = filteredDataTable;
            }
            else
            {
                removeMemberTable.DataSource = library.LoadMembersToTable();
            }
        }
        //takes the libraria back to the librarian menu 
        private void removeMemberBtn_Click(object sender, EventArgs e)
        {
            Librarian_Menu librarian_Menu = new Librarian_Menu(loggedInAdmin);
            librarian_Menu.Show();
            this.Hide();
        }
    }
}
