namespace LibraryMng
{
    partial class view_all_loans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view_all_loans));
            this.viewAllLoans = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.currentLoansBackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewAllLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // viewAllLoans
            // 
            this.viewAllLoans.BackgroundColor = System.Drawing.Color.Moccasin;
            this.viewAllLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewAllLoans.Location = new System.Drawing.Point(12, 101);
            this.viewAllLoans.Name = "viewAllLoans";
            this.viewAllLoans.RowHeadersWidth = 51;
            this.viewAllLoans.RowTemplate.Height = 24;
            this.viewAllLoans.Size = new System.Drawing.Size(1002, 419);
            this.viewAllLoans.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Moccasin;
            this.label1.Location = new System.Drawing.Point(360, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Loans";
            // 
            // currentLoansBackBtn
            // 
            this.currentLoansBackBtn.BackColor = System.Drawing.Color.Transparent;
            this.currentLoansBackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("currentLoansBackBtn.BackgroundImage")));
            this.currentLoansBackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.currentLoansBackBtn.FlatAppearance.BorderSize = 0;
            this.currentLoansBackBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.currentLoansBackBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.currentLoansBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currentLoansBackBtn.Location = new System.Drawing.Point(12, 543);
            this.currentLoansBackBtn.Name = "currentLoansBackBtn";
            this.currentLoansBackBtn.Size = new System.Drawing.Size(54, 54);
            this.currentLoansBackBtn.TabIndex = 2;
            this.currentLoansBackBtn.UseVisualStyleBackColor = false;
            this.currentLoansBackBtn.Click += new System.EventHandler(this.currentLoansBackBtn_Click);
            // 
            // view_all_loans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1026, 609);
            this.Controls.Add(this.currentLoansBackBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewAllLoans);
            this.Name = "view_all_loans";
            this.Text = "View All Loans";
            this.Load += new System.EventHandler(this.view_all_loans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewAllLoans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView viewAllLoans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button currentLoansBackBtn;
    }
}