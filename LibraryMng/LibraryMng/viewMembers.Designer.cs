namespace LibraryMng
{
    partial class viewMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewMembers));
            this.memberTable = new System.Windows.Forms.DataGridView();
            this.searchMembers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.allMembersViewBackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.memberTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // memberTable
            // 
            this.memberTable.BackgroundColor = System.Drawing.Color.Moccasin;
            this.memberTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberTable.Location = new System.Drawing.Point(12, 168);
            this.memberTable.Name = "memberTable";
            this.memberTable.ReadOnly = true;
            this.memberTable.RowHeadersWidth = 51;
            this.memberTable.RowTemplate.Height = 24;
            this.memberTable.Size = new System.Drawing.Size(1002, 360);
            this.memberTable.TabIndex = 0;
            // 
            // searchMembers
            // 
            this.searchMembers.BackColor = System.Drawing.Color.Moccasin;
            this.searchMembers.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.searchMembers.Location = new System.Drawing.Point(639, 132);
            this.searchMembers.Name = "searchMembers";
            this.searchMembers.Size = new System.Drawing.Size(339, 30);
            this.searchMembers.TabIndex = 1;
            this.searchMembers.TextChanged += new System.EventHandler(this.searchMembers_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Moccasin;
            this.label1.Location = new System.Drawing.Point(257, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "All Signed Up Members";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(984, 132);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // allMembersViewBackBtn
            // 
            this.allMembersViewBackBtn.BackColor = System.Drawing.Color.Transparent;
            this.allMembersViewBackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("allMembersViewBackBtn.BackgroundImage")));
            this.allMembersViewBackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.allMembersViewBackBtn.FlatAppearance.BorderSize = 0;
            this.allMembersViewBackBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.allMembersViewBackBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.allMembersViewBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allMembersViewBackBtn.ForeColor = System.Drawing.Color.Transparent;
            this.allMembersViewBackBtn.Location = new System.Drawing.Point(12, 543);
            this.allMembersViewBackBtn.Name = "allMembersViewBackBtn";
            this.allMembersViewBackBtn.Size = new System.Drawing.Size(54, 54);
            this.allMembersViewBackBtn.TabIndex = 18;
            this.allMembersViewBackBtn.UseVisualStyleBackColor = false;
            this.allMembersViewBackBtn.Click += new System.EventHandler(this.allMembersViewBackBtn_Click);
            // 
            // viewMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1026, 609);
            this.Controls.Add(this.allMembersViewBackBtn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchMembers);
            this.Controls.Add(this.memberTable);
            this.Name = "viewMembers";
            this.Text = "viewMembers";
            this.Load += new System.EventHandler(this.viewMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView memberTable;
        private System.Windows.Forms.TextBox searchMembers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button allMembersViewBackBtn;
    }
}