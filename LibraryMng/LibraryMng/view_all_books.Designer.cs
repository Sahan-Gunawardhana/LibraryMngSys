namespace LibraryMng
{
    partial class view_all_books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view_all_books));
            this.label1 = new System.Windows.Forms.Label();
            this.DisplayAllBooks = new System.Windows.Forms.DataGridView();
            this.searchBooks = new System.Windows.Forms.TextBox();
            this.catalogBackBtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayAllBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Moccasin;
            this.label1.Location = new System.Drawing.Point(337, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Catalog ";
            // 
            // DisplayAllBooks
            // 
            this.DisplayAllBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayAllBooks.Location = new System.Drawing.Point(11, 143);
            this.DisplayAllBooks.Name = "DisplayAllBooks";
            this.DisplayAllBooks.ReadOnly = true;
            this.DisplayAllBooks.RowHeadersWidth = 51;
            this.DisplayAllBooks.RowTemplate.Height = 24;
            this.DisplayAllBooks.Size = new System.Drawing.Size(1002, 366);
            this.DisplayAllBooks.TabIndex = 1;
            // 
            // searchBooks
            // 
            this.searchBooks.BackColor = System.Drawing.Color.Black;
            this.searchBooks.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.searchBooks.ForeColor = System.Drawing.Color.Moccasin;
            this.searchBooks.Location = new System.Drawing.Point(638, 107);
            this.searchBooks.Name = "searchBooks";
            this.searchBooks.Size = new System.Drawing.Size(339, 30);
            this.searchBooks.TabIndex = 2;
            this.searchBooks.TextChanged += new System.EventHandler(this.searchBooks_TextChanged);
            // 
            // catalogBackBtn
            // 
            this.catalogBackBtn.BackColor = System.Drawing.Color.Transparent;
            this.catalogBackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("catalogBackBtn.BackgroundImage")));
            this.catalogBackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.catalogBackBtn.FlatAppearance.BorderSize = 0;
            this.catalogBackBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.catalogBackBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.catalogBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catalogBackBtn.ForeColor = System.Drawing.Color.Transparent;
            this.catalogBackBtn.Location = new System.Drawing.Point(12, 543);
            this.catalogBackBtn.Name = "catalogBackBtn";
            this.catalogBackBtn.Size = new System.Drawing.Size(54, 54);
            this.catalogBackBtn.TabIndex = 3;
            this.catalogBackBtn.UseVisualStyleBackColor = false;
            this.catalogBackBtn.Click += new System.EventHandler(this.catalogBackBtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(983, 107);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // view_all_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1026, 609);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.catalogBackBtn);
            this.Controls.Add(this.searchBooks);
            this.Controls.Add(this.DisplayAllBooks);
            this.Controls.Add(this.label1);
            this.Name = "view_all_books";
            this.Text = "View All Books";
            this.Load += new System.EventHandler(this.view_all_books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayAllBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DisplayAllBooks;
        private System.Windows.Forms.TextBox searchBooks;
        private System.Windows.Forms.Button catalogBackBtn;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}