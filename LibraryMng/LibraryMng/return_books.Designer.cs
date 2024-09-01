namespace LibraryMng
{
    partial class return_books
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(return_books));
            this.LoanTable = new System.Windows.Forms.DataGridView();
            this.searchReturnBook = new System.Windows.Forms.TextBox();
            this.returnBookID = new System.Windows.Forms.TextBox();
            this.returnBook = new System.Windows.Forms.Button();
            this.returnBookBackBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LoanTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // LoanTable
            // 
            this.LoanTable.BackgroundColor = System.Drawing.Color.Moccasin;
            this.LoanTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoanTable.Location = new System.Drawing.Point(12, 163);
            this.LoanTable.Name = "LoanTable";
            this.LoanTable.RowHeadersWidth = 51;
            this.LoanTable.RowTemplate.Height = 24;
            this.LoanTable.Size = new System.Drawing.Size(1002, 318);
            this.LoanTable.TabIndex = 0;
            // 
            // searchReturnBook
            // 
            this.searchReturnBook.BackColor = System.Drawing.Color.Moccasin;
            this.searchReturnBook.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.searchReturnBook.Location = new System.Drawing.Point(639, 127);
            this.searchReturnBook.Name = "searchReturnBook";
            this.searchReturnBook.Size = new System.Drawing.Size(339, 30);
            this.searchReturnBook.TabIndex = 1;
            this.searchReturnBook.TextChanged += new System.EventHandler(this.searchReturnBook_TextChanged);
            // 
            // returnBookID
            // 
            this.returnBookID.BackColor = System.Drawing.Color.Moccasin;
            this.returnBookID.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.returnBookID.Location = new System.Drawing.Point(644, 489);
            this.returnBookID.Name = "returnBookID";
            this.returnBookID.Size = new System.Drawing.Size(370, 30);
            this.returnBookID.TabIndex = 2;
            // 
            // returnBook
            // 
            this.returnBook.BackColor = System.Drawing.Color.Moccasin;
            this.returnBook.FlatAppearance.BorderSize = 0;
            this.returnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBook.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.returnBook.Location = new System.Drawing.Point(720, 527);
            this.returnBook.Name = "returnBook";
            this.returnBook.Size = new System.Drawing.Size(294, 68);
            this.returnBook.TabIndex = 3;
            this.returnBook.Text = "Return Book";
            this.returnBook.UseVisualStyleBackColor = false;
            this.returnBook.Click += new System.EventHandler(this.returnBook_Click);
            // 
            // returnBookBackBtn
            // 
            this.returnBookBackBtn.BackColor = System.Drawing.Color.Transparent;
            this.returnBookBackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("returnBookBackBtn.BackgroundImage")));
            this.returnBookBackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.returnBookBackBtn.FlatAppearance.BorderSize = 0;
            this.returnBookBackBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.returnBookBackBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.returnBookBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBookBackBtn.ForeColor = System.Drawing.Color.Transparent;
            this.returnBookBackBtn.Location = new System.Drawing.Point(12, 541);
            this.returnBookBackBtn.Name = "returnBookBackBtn";
            this.returnBookBackBtn.Size = new System.Drawing.Size(54, 54);
            this.returnBookBackBtn.TabIndex = 4;
            this.returnBookBackBtn.UseVisualStyleBackColor = false;
            this.returnBookBackBtn.Click += new System.EventHandler(this.returnBookBackBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Moccasin;
            this.label1.Location = new System.Drawing.Point(335, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 53);
            this.label1.TabIndex = 5;
            this.label1.Text = "Return a Book";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(984, 127);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Moccasin;
            this.label2.Location = new System.Drawing.Point(395, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "Enter the Book ID";
            // 
            // return_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1026, 609);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnBookBackBtn);
            this.Controls.Add(this.returnBook);
            this.Controls.Add(this.returnBookID);
            this.Controls.Add(this.searchReturnBook);
            this.Controls.Add(this.LoanTable);
            this.Name = "return_books";
            this.Text = "return_books";
            this.Load += new System.EventHandler(this.return_books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoanTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LoanTable;
        private System.Windows.Forms.TextBox searchReturnBook;
        private System.Windows.Forms.TextBox returnBookID;
        private System.Windows.Forms.Button returnBook;
        private System.Windows.Forms.Button returnBookBackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
    }
}