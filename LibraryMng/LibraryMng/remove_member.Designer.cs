namespace LibraryMng
{
    partial class remove_member
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(remove_member));
            this.removeMemberTable = new System.Windows.Forms.DataGridView();
            this.removeMember = new System.Windows.Forms.Button();
            this.memberToRemove = new System.Windows.Forms.Label();
            this.memberIdToRemove = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchMember = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.removeMemberBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.removeMemberTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // removeMemberTable
            // 
            this.removeMemberTable.BackgroundColor = System.Drawing.Color.Moccasin;
            this.removeMemberTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.removeMemberTable.Location = new System.Drawing.Point(12, 150);
            this.removeMemberTable.Name = "removeMemberTable";
            this.removeMemberTable.RowHeadersWidth = 51;
            this.removeMemberTable.RowTemplate.Height = 24;
            this.removeMemberTable.Size = new System.Drawing.Size(1002, 323);
            this.removeMemberTable.TabIndex = 0;
            // 
            // removeMember
            // 
            this.removeMember.BackColor = System.Drawing.Color.Moccasin;
            this.removeMember.FlatAppearance.BorderSize = 0;
            this.removeMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeMember.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.removeMember.Location = new System.Drawing.Point(720, 529);
            this.removeMember.Name = "removeMember";
            this.removeMember.Size = new System.Drawing.Size(294, 68);
            this.removeMember.TabIndex = 1;
            this.removeMember.Text = "Remove Member";
            this.removeMember.UseVisualStyleBackColor = false;
            this.removeMember.Click += new System.EventHandler(this.removeMember_Click);
            // 
            // memberToRemove
            // 
            this.memberToRemove.AutoSize = true;
            this.memberToRemove.Location = new System.Drawing.Point(219, 373);
            this.memberToRemove.Name = "memberToRemove";
            this.memberToRemove.Size = new System.Drawing.Size(0, 16);
            this.memberToRemove.TabIndex = 2;
            // 
            // memberIdToRemove
            // 
            this.memberIdToRemove.BackColor = System.Drawing.Color.Moccasin;
            this.memberIdToRemove.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.memberIdToRemove.Location = new System.Drawing.Point(639, 493);
            this.memberIdToRemove.Name = "memberIdToRemove";
            this.memberIdToRemove.Size = new System.Drawing.Size(375, 30);
            this.memberIdToRemove.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Moccasin;
            this.label1.Location = new System.Drawing.Point(292, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 53);
            this.label1.TabIndex = 4;
            this.label1.Text = "Remove a Member";
            // 
            // searchMember
            // 
            this.searchMember.BackColor = System.Drawing.Color.Moccasin;
            this.searchMember.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.searchMember.ForeColor = System.Drawing.Color.Black;
            this.searchMember.Location = new System.Drawing.Point(639, 114);
            this.searchMember.Name = "searchMember";
            this.searchMember.Size = new System.Drawing.Size(339, 30);
            this.searchMember.TabIndex = 5;
            this.searchMember.TextChanged += new System.EventHandler(this.searchMember_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(984, 114);
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
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label2.ForeColor = System.Drawing.Color.Moccasin;
            this.label2.Location = new System.Drawing.Point(352, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 34);
            this.label2.TabIndex = 18;
            this.label2.Text = "Remove Member ID";
            // 
            // removeMemberBtn
            // 
            this.removeMemberBtn.BackColor = System.Drawing.Color.Transparent;
            this.removeMemberBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeMemberBtn.BackgroundImage")));
            this.removeMemberBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.removeMemberBtn.FlatAppearance.BorderSize = 0;
            this.removeMemberBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.removeMemberBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.removeMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeMemberBtn.ForeColor = System.Drawing.Color.Transparent;
            this.removeMemberBtn.Location = new System.Drawing.Point(13, 540);
            this.removeMemberBtn.Name = "removeMemberBtn";
            this.removeMemberBtn.Size = new System.Drawing.Size(54, 54);
            this.removeMemberBtn.TabIndex = 19;
            this.removeMemberBtn.UseVisualStyleBackColor = false;
            this.removeMemberBtn.Click += new System.EventHandler(this.removeMemberBtn_Click);
            // 
            // remove_member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1026, 609);
            this.Controls.Add(this.removeMemberBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.searchMember);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.memberIdToRemove);
            this.Controls.Add(this.memberToRemove);
            this.Controls.Add(this.removeMember);
            this.Controls.Add(this.removeMemberTable);
            this.Name = "remove_member";
            this.Text = "remove_member";
            this.Load += new System.EventHandler(this.remove_member_Load);
            ((System.ComponentModel.ISupportInitialize)(this.removeMemberTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView removeMemberTable;
        private System.Windows.Forms.Button removeMember;
        private System.Windows.Forms.Label memberToRemove;
        private System.Windows.Forms.TextBox memberIdToRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchMember;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button removeMemberBtn;
    }
}