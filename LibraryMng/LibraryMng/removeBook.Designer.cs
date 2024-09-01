namespace LibraryMng
{
    partial class removeBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(removeBook));
            this.removeBookID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.remove_Book = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.addBookBackBtn = new System.Windows.Forms.Button();
            this.removeBookSearch = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.removeBookTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeBookTable)).BeginInit();
            this.SuspendLayout();
            // 
            // removeBookID
            // 
            this.removeBookID.BackColor = System.Drawing.Color.Moccasin;
            this.removeBookID.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.removeBookID.Location = new System.Drawing.Point(639, 479);
            this.removeBookID.Name = "removeBookID";
            this.removeBookID.Size = new System.Drawing.Size(375, 30);
            this.removeBookID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label1.ForeColor = System.Drawing.Color.Moccasin;
            this.label1.Location = new System.Drawing.Point(379, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the Book ID ";
            // 
            // remove_Book
            // 
            this.remove_Book.BackColor = System.Drawing.Color.Moccasin;
            this.remove_Book.FlatAppearance.BorderSize = 0;
            this.remove_Book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove_Book.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.remove_Book.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.remove_Book.Location = new System.Drawing.Point(720, 515);
            this.remove_Book.Name = "remove_Book";
            this.remove_Book.Size = new System.Drawing.Size(294, 68);
            this.remove_Book.TabIndex = 3;
            this.remove_Book.Text = "Remove Book";
            this.remove_Book.UseVisualStyleBackColor = false;
            this.remove_Book.Click += new System.EventHandler(this.remove_Book_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Moccasin;
            this.label2.Location = new System.Drawing.Point(156, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(696, 53);
            this.label2.TabIndex = 4;
            this.label2.Text = "Remove a Book from the Library";
            // 
            // addBookBackBtn
            // 
            this.addBookBackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addBookBackBtn.BackColor = System.Drawing.Color.Transparent;
            this.addBookBackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addBookBackBtn.BackgroundImage")));
            this.addBookBackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addBookBackBtn.FlatAppearance.BorderSize = 0;
            this.addBookBackBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addBookBackBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addBookBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBookBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookBackBtn.ForeColor = System.Drawing.Color.Black;
            this.addBookBackBtn.Location = new System.Drawing.Point(12, 543);
            this.addBookBackBtn.Name = "addBookBackBtn";
            this.addBookBackBtn.Size = new System.Drawing.Size(54, 54);
            this.addBookBackBtn.TabIndex = 16;
            this.addBookBackBtn.UseVisualStyleBackColor = false;
            this.addBookBackBtn.Click += new System.EventHandler(this.addBookBackBtn_Click);
            // 
            // removeBookSearch
            // 
            this.removeBookSearch.BackColor = System.Drawing.Color.Moccasin;
            this.removeBookSearch.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.removeBookSearch.Location = new System.Drawing.Point(639, 128);
            this.removeBookSearch.Name = "removeBookSearch";
            this.removeBookSearch.Size = new System.Drawing.Size(339, 30);
            this.removeBookSearch.TabIndex = 17;
            this.removeBookSearch.TextChanged += new System.EventHandler(this.removeBookSearch_TextChanged_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(984, 128);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // removeBookTable
            // 
            this.removeBookTable.BackgroundColor = System.Drawing.Color.Moccasin;
            this.removeBookTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.removeBookTable.GridColor = System.Drawing.Color.Black;
            this.removeBookTable.Location = new System.Drawing.Point(12, 164);
            this.removeBookTable.Name = "removeBookTable";
            this.removeBookTable.RowHeadersWidth = 51;
            this.removeBookTable.RowTemplate.Height = 24;
            this.removeBookTable.Size = new System.Drawing.Size(1002, 309);
            this.removeBookTable.TabIndex = 19;
            // 
            // removeBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1026, 609);
            this.Controls.Add(this.removeBookTable);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.removeBookSearch);
            this.Controls.Add(this.addBookBackBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.remove_Book);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeBookID);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "removeBook";
            this.Text = "removeBook";
            this.Load += new System.EventHandler(this.removeBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeBookTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox removeBookID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button remove_Book;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addBookBackBtn;
        private System.Windows.Forms.TextBox removeBookSearch;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView removeBookTable;
    }
}