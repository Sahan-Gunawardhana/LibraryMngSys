namespace LibraryMng
{
    partial class Member_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member_Menu));
            this.mViewBooks = new System.Windows.Forms.Button();
            this.borrowBookBtn = new System.Windows.Forms.Button();
            this.personalData = new System.Windows.Forms.PictureBox();
            this.dashboad = new System.Windows.Forms.Label();
            this.memMenuBackBTN = new System.Windows.Forms.Button();
            this.WelcomeUser = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.Overdue = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.Label();
            this.memberID = new System.Windows.Forms.Label();
            this.personalLoans = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personalData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // mViewBooks
            // 
            this.mViewBooks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mViewBooks.BackColor = System.Drawing.Color.Black;
            this.mViewBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mViewBooks.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.mViewBooks.ForeColor = System.Drawing.Color.Moccasin;
            this.mViewBooks.Location = new System.Drawing.Point(398, 527);
            this.mViewBooks.Name = "mViewBooks";
            this.mViewBooks.Size = new System.Drawing.Size(294, 68);
            this.mViewBooks.TabIndex = 0;
            this.mViewBooks.Text = "View All Books";
            this.mViewBooks.UseVisualStyleBackColor = false;
            this.mViewBooks.Click += new System.EventHandler(this.mViewBooks_Click);
            // 
            // borrowBookBtn
            // 
            this.borrowBookBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borrowBookBtn.BackColor = System.Drawing.Color.Black;
            this.borrowBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowBookBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.borrowBookBtn.ForeColor = System.Drawing.Color.Moccasin;
            this.borrowBookBtn.Location = new System.Drawing.Point(720, 527);
            this.borrowBookBtn.Name = "borrowBookBtn";
            this.borrowBookBtn.Size = new System.Drawing.Size(294, 68);
            this.borrowBookBtn.TabIndex = 2;
            this.borrowBookBtn.Text = "Borrow Books ";
            this.borrowBookBtn.UseVisualStyleBackColor = false;
            this.borrowBookBtn.Click += new System.EventHandler(this.borrowBookBtn_Click);
            // 
            // personalData
            // 
            this.personalData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.personalData.BackColor = System.Drawing.Color.Transparent;
            this.personalData.Image = ((System.Drawing.Image)(resources.GetObject("personalData.Image")));
            this.personalData.Location = new System.Drawing.Point(17, 103);
            this.personalData.Name = "personalData";
            this.personalData.Size = new System.Drawing.Size(117, 109);
            this.personalData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.personalData.TabIndex = 4;
            this.personalData.TabStop = false;
            // 
            // dashboad
            // 
            this.dashboad.AutoSize = true;
            this.dashboad.BackColor = System.Drawing.Color.Transparent;
            this.dashboad.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboad.ForeColor = System.Drawing.Color.White;
            this.dashboad.Location = new System.Drawing.Point(616, 86);
            this.dashboad.Name = "dashboad";
            this.dashboad.Size = new System.Drawing.Size(0, 15);
            this.dashboad.TabIndex = 5;
            // 
            // memMenuBackBTN
            // 
            this.memMenuBackBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.memMenuBackBTN.BackColor = System.Drawing.Color.Transparent;
            this.memMenuBackBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("memMenuBackBTN.BackgroundImage")));
            this.memMenuBackBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.memMenuBackBTN.FlatAppearance.BorderSize = 0;
            this.memMenuBackBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.memMenuBackBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.memMenuBackBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memMenuBackBTN.ForeColor = System.Drawing.Color.Transparent;
            this.memMenuBackBTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.memMenuBackBTN.Location = new System.Drawing.Point(12, 546);
            this.memMenuBackBTN.Name = "memMenuBackBTN";
            this.memMenuBackBTN.Size = new System.Drawing.Size(51, 51);
            this.memMenuBackBTN.TabIndex = 6;
            this.memMenuBackBTN.UseVisualStyleBackColor = false;
            this.memMenuBackBTN.Click += new System.EventHandler(this.memMenuBackBTN_Click);
            // 
            // WelcomeUser
            // 
            this.WelcomeUser.AutoSize = true;
            this.WelcomeUser.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeUser.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeUser.ForeColor = System.Drawing.Color.Moccasin;
            this.WelcomeUser.Location = new System.Drawing.Point(12, 34);
            this.WelcomeUser.Name = "WelcomeUser";
            this.WelcomeUser.Size = new System.Drawing.Size(120, 32);
            this.WelcomeUser.TabIndex = 7;
            this.WelcomeUser.Text = "Welcome";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Moccasin;
            this.username.Location = new System.Drawing.Point(12, 252);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(67, 26);
            this.username.TabIndex = 9;
            this.username.Text = "label2";
            // 
            // Overdue
            // 
            this.Overdue.AutoSize = true;
            this.Overdue.BackColor = System.Drawing.Color.Transparent;
            this.Overdue.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Overdue.ForeColor = System.Drawing.Color.Moccasin;
            this.Overdue.Location = new System.Drawing.Point(12, 317);
            this.Overdue.Name = "Overdue";
            this.Overdue.Size = new System.Drawing.Size(67, 26);
            this.Overdue.TabIndex = 10;
            this.Overdue.Text = "label1";
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.BackColor = System.Drawing.Color.Transparent;
            this.dob.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.ForeColor = System.Drawing.Color.Moccasin;
            this.dob.Location = new System.Drawing.Point(12, 348);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(67, 26);
            this.dob.TabIndex = 12;
            this.dob.Text = "label1";
            // 
            // memberID
            // 
            this.memberID.AutoSize = true;
            this.memberID.BackColor = System.Drawing.Color.Transparent;
            this.memberID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberID.ForeColor = System.Drawing.Color.Moccasin;
            this.memberID.Location = new System.Drawing.Point(151, 282);
            this.memberID.Name = "memberID";
            this.memberID.Size = new System.Drawing.Size(67, 26);
            this.memberID.TabIndex = 13;
            this.memberID.Text = "label1";
            // 
            // personalLoans
            // 
            this.personalLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personalLoans.Location = new System.Drawing.Point(398, 86);
            this.personalLoans.Name = "personalLoans";
            this.personalLoans.RowHeadersWidth = 51;
            this.personalLoans.RowTemplate.Height = 24;
            this.personalLoans.Size = new System.Drawing.Size(616, 357);
            this.personalLoans.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Moccasin;
            this.label1.Location = new System.Drawing.Point(14, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Member ID: ";
            // 
            // Member_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1026, 609);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personalLoans);
            this.Controls.Add(this.memberID);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.Overdue);
            this.Controls.Add(this.username);
            this.Controls.Add(this.WelcomeUser);
            this.Controls.Add(this.memMenuBackBTN);
            this.Controls.Add(this.dashboad);
            this.Controls.Add(this.personalData);
            this.Controls.Add(this.borrowBookBtn);
            this.Controls.Add(this.mViewBooks);
            this.Name = "Member_Menu";
            this.Text = "Member";
            this.Load += new System.EventHandler(this.Member_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personalData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalLoans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mViewBooks;
        private System.Windows.Forms.Button borrowBookBtn;
        private System.Windows.Forms.PictureBox personalData;
        private System.Windows.Forms.Label dashboad;
        private System.Windows.Forms.Button memMenuBackBTN;
        private System.Windows.Forms.Label WelcomeUser;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label Overdue;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.Label memberID;
        private System.Windows.Forms.DataGridView personalLoans;
        private System.Windows.Forms.Label label1;
    }
}