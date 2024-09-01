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
    public partial class viewMembers : Form
    {
        private string loggedInAdmin;
        Library library;
        public viewMembers(string username)
        {
            
            InitializeComponent();
            this.loggedInAdmin = username;
            library = new Library();
        }
        //loads members to the table 
        private void viewMembers_Load(object sender, EventArgs e)
        {
            DataTable memberDataTable = library.LoadMembersToTable();
            memberTable.DataSource = memberDataTable;
           
            memberTable.BackgroundColor = Color.Moccasin;
            memberTable.DefaultCellStyle.BackColor = Color.Moccasin;
            memberTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        //filters the members 
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
                        break; // Once a match is found, no need to continue checking other columns
                    }
                }
            }
            return filteredDataTable;
        }
        //searching members 
        private void searchMembers_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchMembers.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                // Cast the DataSource to DataTable and filter based on search text
                DataTable memberDataTable = (DataTable)memberTable.DataSource;
                DataTable filteredDataTable = FilterDataTable(memberDataTable, searchText);

                memberTable.DataSource = filteredDataTable;
            }
            else
            {
                // If search text is empty, reload all data
                memberTable.DataSource = library.LoadMembersToTable();
            }
        }
        //redirects to the menu 
        private void allMembersViewBackBtn_Click(object sender, EventArgs e)
        {
            Librarian_Menu librarian_Menu = new Librarian_Menu(loggedInAdmin);
            librarian_Menu.Show();  
            this.Hide();
        }
    }
}
