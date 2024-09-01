namespace LibraryMng
{
    partial class borrow_books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(borrow_books));
            this.borrowDataGrid = new System.Windows.Forms.DataGridView();
            this.bookIDtoBorrow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBookIDtoBorrow = new System.Windows.Forms.TextBox();
            this.borrowBook = new System.Windows.Forms.Button();
            this.borrowBackButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.borrowDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // borrowDataGrid
            // 
            this.borrowDataGrid.BackgroundColor = System.Drawing.Color.Moccasin;
            this.borrowDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borrowDataGrid.Location = new System.Drawing.Point(12, 188);
            this.borrowDataGrid.Name = "borrowDataGrid";
            this.borrowDataGrid.RowHeadersWidth = 51;
            this.borrowDataGrid.RowTemplate.Height = 24;
            this.borrowDataGrid.Size = new System.Drawing.Size(1002, 289);
            this.borrowDataGrid.TabIndex = 1;
            // 
            // bookIDtoBorrow
            // 
            this.bookIDtoBorrow.BackColor = System.Drawing.Color.Black;
            this.bookIDtoBorrow.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.bookIDtoBorrow.ForeColor = System.Drawing.Color.Moccasin;
            this.bookIDtoBorrow.Location = new System.Drawing.Point(636, 489);
            this.bookIDtoBorrow.Name = "bookIDtoBorrow";
            this.bookIDtoBorrow.Size = new System.Drawing.Size(378, 30);
            this.bookIDtoBorrow.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label1.ForeColor = System.Drawing.Color.Moccasin;
            this.label1.Location = new System.Drawing.Point(242, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter the ID to borrow Book";
            // 
            // searchBookIDtoBorrow
            // 
            this.searchBookIDtoBorrow.BackColor = System.Drawing.Color.Black;
            this.searchBookIDtoBorrow.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.searchBookIDtoBorrow.ForeColor = System.Drawing.Color.Moccasin;
            this.searchBookIDtoBorrow.Location = new System.Drawing.Point(639, 149);
            this.searchBookIDtoBorrow.Name = "searchBookIDtoBorrow";
            this.searchBookIDtoBorrow.Size = new System.Drawing.Size(339, 30);
            this.searchBookIDtoBorrow.TabIndex = 4;
            this.searchBookIDtoBorrow.TextChanged += new System.EventHandler(this.searchBookIDtoBorrow_TextChanged);
            // 
            // borrowBook
            // 
            this.borrowBook.BackColor = System.Drawing.Color.Black;
            this.borrowBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowBook.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.borrowBook.ForeColor = System.Drawing.Color.Moccasin;
            this.borrowBook.Location = new System.Drawing.Point(720, 529);
            this.borrowBook.Name = "borrowBook";
            this.borrowBook.Size = new System.Drawing.Size(294, 68);
            this.borrowBook.TabIndex = 5;
            this.borrowBook.Text = "Borrow";
            this.borrowBook.UseVisualStyleBackColor = false;
            this.borrowBook.Click += new System.EventHandler(this.borrowBook_Click);
            // 
            // borrowBackButton
            // 
            this.borrowBackButton.BackColor = System.Drawing.Color.Transparent;
            this.borrowBackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("borrowBackButton.BackgroundImage")));
            this.borrowBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.borrowBackButton.FlatAppearance.BorderSize = 0;
            this.borrowBackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.borrowBackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.borrowBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowBackButton.ForeColor = System.Drawing.Color.Transparent;
            this.borrowBackButton.Location = new System.Drawing.Point(12, 543);
            this.borrowBackButton.Name = "borrowBackButton";
            this.borrowBackButton.Size = new System.Drawing.Size(54, 54);
            this.borrowBackButton.TabIndex = 6;
            this.borrowBackButton.UseVisualStyleBackColor = false;
            this.borrowBackButton.Click += new System.EventHandler(this.borrowBackButton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(984, 149);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Moccasin;
            this.label2.Location = new System.Drawing.Point(323, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 53);
            this.label2.TabIndex = 18;
            this.label2.Text = "Borrow a Book";
            // 
            // borrow_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1026, 609);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.borrowBackButton);
            this.Controls.Add(this.borrowBook);
            this.Controls.Add(this.searchBookIDtoBorrow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookIDtoBorrow);
            this.Controls.Add(this.borrowDataGrid);
            this.Name = "borrow_books";
            this.Text = "Borrow Books";
            this.Load += new System.EventHandler(this.borrow_books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.borrowDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView borrowDataGrid;
        private System.Windows.Forms.TextBox bookIDtoBorrow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBookIDtoBorrow;
        private System.Windows.Forms.Button borrowBook;
        private System.Windows.Forms.Button borrowBackButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
    }
}