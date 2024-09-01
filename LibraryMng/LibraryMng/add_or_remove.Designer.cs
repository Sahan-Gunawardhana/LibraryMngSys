namespace LibraryMng
{
    partial class add_or_remove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_or_remove));
            this.addBook = new System.Windows.Forms.Button();
            this.rmvBook = new System.Windows.Forms.Button();
            this.displayBooks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.addOrRemoveBackBtn = new System.Windows.Forms.Button();
            this.searchBookCat = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.displayBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // addBook
            // 
            this.addBook.BackColor = System.Drawing.Color.Moccasin;
            this.addBook.FlatAppearance.BorderSize = 0;
            this.addBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBook.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBook.Location = new System.Drawing.Point(406, 515);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(294, 65);
            this.addBook.TabIndex = 0;
            this.addBook.Text = "Add Books";
            this.addBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBook.UseVisualStyleBackColor = false;
            this.addBook.Click += new System.EventHandler(this.addBook_Click);
            // 
            // rmvBook
            // 
            this.rmvBook.BackColor = System.Drawing.Color.Moccasin;
            this.rmvBook.FlatAppearance.BorderSize = 0;
            this.rmvBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rmvBook.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmvBook.Location = new System.Drawing.Point(721, 515);
            this.rmvBook.Name = "rmvBook";
            this.rmvBook.Size = new System.Drawing.Size(294, 65);
            this.rmvBook.TabIndex = 1;
            this.rmvBook.Text = "Remove Books";
            this.rmvBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rmvBook.UseVisualStyleBackColor = false;
            this.rmvBook.Click += new System.EventHandler(this.rmvBook_Click);
            // 
            // displayBooks
            // 
            this.displayBooks.BackgroundColor = System.Drawing.Color.Moccasin;
            this.displayBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayBooks.Location = new System.Drawing.Point(13, 185);
            this.displayBooks.Name = "displayBooks";
            this.displayBooks.ReadOnly = true;
            this.displayBooks.RowHeadersWidth = 51;
            this.displayBooks.RowTemplate.Height = 24;
            this.displayBooks.Size = new System.Drawing.Size(1002, 324);
            this.displayBooks.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Moccasin;
            this.label1.Location = new System.Drawing.Point(300, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 53);
            this.label1.TabIndex = 3;
            this.label1.Text = "Library Catalogue";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Moccasin;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(645, 524);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Moccasin;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(960, 524);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // addOrRemoveBackBtn
            // 
            this.addOrRemoveBackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addOrRemoveBackBtn.BackColor = System.Drawing.Color.Transparent;
            this.addOrRemoveBackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addOrRemoveBackBtn.BackgroundImage")));
            this.addOrRemoveBackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addOrRemoveBackBtn.FlatAppearance.BorderSize = 0;
            this.addOrRemoveBackBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addOrRemoveBackBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addOrRemoveBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addOrRemoveBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOrRemoveBackBtn.ForeColor = System.Drawing.Color.Black;
            this.addOrRemoveBackBtn.Location = new System.Drawing.Point(12, 526);
            this.addOrRemoveBackBtn.Name = "addOrRemoveBackBtn";
            this.addOrRemoveBackBtn.Size = new System.Drawing.Size(54, 54);
            this.addOrRemoveBackBtn.TabIndex = 14;
            this.addOrRemoveBackBtn.UseVisualStyleBackColor = false;
            this.addOrRemoveBackBtn.Click += new System.EventHandler(this.addOrRemoveBackBtn_Click);
            // 
            // searchBookCat
            // 
            this.searchBookCat.BackColor = System.Drawing.Color.Moccasin;
            this.searchBookCat.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.searchBookCat.Location = new System.Drawing.Point(639, 149);
            this.searchBookCat.Name = "searchBookCat";
            this.searchBookCat.Size = new System.Drawing.Size(339, 30);
            this.searchBookCat.TabIndex = 15;
            this.searchBookCat.TextChanged += new System.EventHandler(this.searchBookCat_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(984, 149);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // add_or_remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1026, 609);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.searchBookCat);
            this.Controls.Add(this.addOrRemoveBackBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayBooks);
            this.Controls.Add(this.rmvBook);
            this.Controls.Add(this.addBook);
            this.Name = "add_or_remove";
            this.Text = "Add or Remove Books";
            this.Load += new System.EventHandler(this.add_or_remove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBook;
        private System.Windows.Forms.Button rmvBook;
        private System.Windows.Forms.DataGridView displayBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button addOrRemoveBackBtn;
        private System.Windows.Forms.TextBox searchBookCat;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}