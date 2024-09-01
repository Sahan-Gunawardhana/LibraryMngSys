namespace LibraryMng
{
    partial class Member_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member_Login));
            this.memberLogin = new System.Windows.Forms.Button();
            this.memberSignUp = new System.Windows.Forms.Button();
            this.memberUserName = new System.Windows.Forms.TextBox();
            this.memberPassword = new System.Windows.Forms.TextBox();
            this.memerLoginBackBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // memberLogin
            // 
            this.memberLogin.BackColor = System.Drawing.Color.Black;
            this.memberLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memberLogin.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.memberLogin.ForeColor = System.Drawing.Color.Moccasin;
            this.memberLogin.Location = new System.Drawing.Point(404, 334);
            this.memberLogin.Name = "memberLogin";
            this.memberLogin.Size = new System.Drawing.Size(294, 68);
            this.memberLogin.TabIndex = 0;
            this.memberLogin.Text = "Login";
            this.memberLogin.UseVisualStyleBackColor = false;
            this.memberLogin.Click += new System.EventHandler(this.memberLogin_Click);
            // 
            // memberSignUp
            // 
            this.memberSignUp.BackColor = System.Drawing.Color.Black;
            this.memberSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memberSignUp.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.memberSignUp.ForeColor = System.Drawing.Color.Moccasin;
            this.memberSignUp.Location = new System.Drawing.Point(804, 533);
            this.memberSignUp.Name = "memberSignUp";
            this.memberSignUp.Size = new System.Drawing.Size(210, 46);
            this.memberSignUp.TabIndex = 1;
            this.memberSignUp.Text = "Sign Up";
            this.memberSignUp.UseVisualStyleBackColor = false;
            this.memberSignUp.Click += new System.EventHandler(this.memberSignUp_Click);
            // 
            // memberUserName
            // 
            this.memberUserName.BackColor = System.Drawing.Color.Black;
            this.memberUserName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.memberUserName.ForeColor = System.Drawing.Color.Moccasin;
            this.memberUserName.Location = new System.Drawing.Point(381, 227);
            this.memberUserName.Name = "memberUserName";
            this.memberUserName.Size = new System.Drawing.Size(339, 30);
            this.memberUserName.TabIndex = 2;
            // 
            // memberPassword
            // 
            this.memberPassword.BackColor = System.Drawing.Color.Black;
            this.memberPassword.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.memberPassword.ForeColor = System.Drawing.Color.Moccasin;
            this.memberPassword.Location = new System.Drawing.Point(381, 289);
            this.memberPassword.Name = "memberPassword";
            this.memberPassword.Size = new System.Drawing.Size(339, 30);
            this.memberPassword.TabIndex = 3;
            // 
            // memerLoginBackBTN
            // 
            this.memerLoginBackBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.memerLoginBackBTN.BackColor = System.Drawing.Color.Transparent;
            this.memerLoginBackBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("memerLoginBackBTN.BackgroundImage")));
            this.memerLoginBackBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.memerLoginBackBTN.FlatAppearance.BorderSize = 0;
            this.memerLoginBackBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.memerLoginBackBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.memerLoginBackBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memerLoginBackBTN.ForeColor = System.Drawing.Color.Transparent;
            this.memerLoginBackBTN.Location = new System.Drawing.Point(12, 543);
            this.memerLoginBackBTN.Name = "memerLoginBackBTN";
            this.memerLoginBackBTN.Size = new System.Drawing.Size(54, 54);
            this.memerLoginBackBTN.TabIndex = 5;
            this.memerLoginBackBTN.UseVisualStyleBackColor = false;
            this.memerLoginBackBTN.Click += new System.EventHandler(this.memerLoginBackBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Moccasin;
            this.label1.Location = new System.Drawing.Point(218, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Moccasin;
            this.label2.Location = new System.Drawing.Point(220, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Moccasin;
            this.label3.Location = new System.Drawing.Point(365, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 53);
            this.label3.TabIndex = 8;
            this.label3.Text = "Member Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Moccasin;
            this.label4.Location = new System.Drawing.Point(857, 582);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Not a member yet?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Moccasin;
            this.label5.Location = new System.Drawing.Point(250, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(541, 34);
            this.label5.TabIndex = 10;
            this.label5.Text = "Please provide your user credentials to begin";
            // 
            // Member_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1026, 609);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.memerLoginBackBTN);
            this.Controls.Add(this.memberPassword);
            this.Controls.Add(this.memberUserName);
            this.Controls.Add(this.memberSignUp);
            this.Controls.Add(this.memberLogin);
            this.Name = "Member_Login";
            this.Text = "Library Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button memberLogin;
        private System.Windows.Forms.Button memberSignUp;
        private System.Windows.Forms.TextBox memberUserName;
        private System.Windows.Forms.TextBox memberPassword;
        private System.Windows.Forms.Button memerLoginBackBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}