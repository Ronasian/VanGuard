namespace GroupProject
{
    partial class StartingPage
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
            this.AppTitle = new System.Windows.Forms.Label();
            this.AppDescription = new System.Windows.Forms.TextBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.LPpanel = new System.Windows.Forms.Panel();
            this.panelCreateAccoount = new System.Windows.Forms.Panel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txt2LoginEmail = new System.Windows.Forms.TextBox();
            this.txt1LoginPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn1SignIn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.txt1Name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt1Email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt1Password = new System.Windows.Forms.TextBox();
            this.cmb1Role = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSubmitCreate = new System.Windows.Forms.Button();
            this.panelCreateAccoount.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppTitle
            // 
            this.AppTitle.AutoSize = true;
            this.AppTitle.Font = new System.Drawing.Font("Myanmar Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AppTitle.Location = new System.Drawing.Point(161, 94);
            this.AppTitle.Name = "AppTitle";
            this.AppTitle.Size = new System.Drawing.Size(160, 51);
            this.AppTitle.TabIndex = 0;
            this.AppTitle.Text = "VanGuard";
            this.AppTitle.Click += new System.EventHandler(this.AppTitle_Click);
            // 
            // AppDescription
            // 
            this.AppDescription.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AppDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AppDescription.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppDescription.ForeColor = System.Drawing.SystemColors.Control;
            this.AppDescription.Location = new System.Drawing.Point(170, 145);
            this.AppDescription.Margin = new System.Windows.Forms.Padding(4);
            this.AppDescription.Multiline = true;
            this.AppDescription.Name = "AppDescription";
            this.AppDescription.ReadOnly = true;
            this.AppDescription.Size = new System.Drawing.Size(233, 97);
            this.AppDescription.TabIndex = 1;
            this.AppDescription.Text = "Where managing your delivery fleet is made easy with reporting tools, data manage" +
    "ment, and live status update \r\nfeatures.";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCreateAccount.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.Location = new System.Drawing.Point(170, 249);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(132, 31);
            this.btnCreateAccount.TabIndex = 2;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(331, 249);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(132, 31);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LPpanel
            // 
            this.LPpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LPpanel.BackColor = System.Drawing.Color.OrangeRed;
            this.LPpanel.Location = new System.Drawing.Point(0, 0);
            this.LPpanel.Margin = new System.Windows.Forms.Padding(4);
            this.LPpanel.Name = "LPpanel";
            this.LPpanel.Size = new System.Drawing.Size(855, 53);
            this.LPpanel.TabIndex = 4;
            this.LPpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LPpanel_Paint);
            // 
            // panelCreateAccoount
            // 
            this.panelCreateAccoount.Controls.Add(this.btnSubmitCreate);
            this.panelCreateAccoount.Controls.Add(this.label9);
            this.panelCreateAccoount.Controls.Add(this.cmb1Role);
            this.panelCreateAccoount.Controls.Add(this.txt1Password);
            this.panelCreateAccoount.Controls.Add(this.label8);
            this.panelCreateAccoount.Controls.Add(this.txt1Email);
            this.panelCreateAccoount.Controls.Add(this.label7);
            this.panelCreateAccoount.Controls.Add(this.txt1Name);
            this.panelCreateAccoount.Controls.Add(this.label6);
            this.panelCreateAccoount.Controls.Add(this.linkLabel1);
            this.panelCreateAccoount.Controls.Add(this.label5);
            this.panelCreateAccoount.Controls.Add(this.label4);
            this.panelCreateAccoount.Controls.Add(this.flowLayoutPanel1);
            this.panelCreateAccoount.Location = new System.Drawing.Point(421, 71);
            this.panelCreateAccoount.Name = "panelCreateAccoount";
            this.panelCreateAccoount.Size = new System.Drawing.Size(417, 387);
            this.panelCreateAccoount.TabIndex = 5;
            this.panelCreateAccoount.Visible = false;
            this.panelCreateAccoount.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogin_Paint);
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.btn1SignIn);
            this.panelLogin.Controls.Add(this.label3);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.txt1LoginPassword);
            this.panelLogin.Controls.Add(this.txt2LoginEmail);
            this.panelLogin.Location = new System.Drawing.Point(12, 287);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(403, 272);
            this.panelLogin.TabIndex = 6;
            this.panelLogin.Visible = false;
            this.panelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCreateAccount_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(82, 44);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // txt2LoginEmail
            // 
            this.txt2LoginEmail.BackColor = System.Drawing.Color.Black;
            this.txt2LoginEmail.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2LoginEmail.Location = new System.Drawing.Point(48, 94);
            this.txt2LoginEmail.Name = "txt2LoginEmail";
            this.txt2LoginEmail.Size = new System.Drawing.Size(155, 25);
            this.txt2LoginEmail.TabIndex = 0;
            // 
            // txt1LoginPassword
            // 
            this.txt1LoginPassword.BackColor = System.Drawing.Color.Black;
            this.txt1LoginPassword.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1LoginPassword.Location = new System.Drawing.Point(48, 146);
            this.txt1LoginPassword.Name = "txt1LoginPassword";
            this.txt1LoginPassword.Size = new System.Drawing.Size(155, 25);
            this.txt1LoginPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sign In";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // btn1SignIn
            // 
            this.btn1SignIn.BackColor = System.Drawing.Color.OrangeRed;
            this.btn1SignIn.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1SignIn.ForeColor = System.Drawing.Color.Black;
            this.btn1SignIn.Location = new System.Drawing.Point(48, 181);
            this.btn1SignIn.Name = "btn1SignIn";
            this.btn1SignIn.Size = new System.Drawing.Size(118, 24);
            this.btn1SignIn.TabIndex = 5;
            this.btn1SignIn.Text = "Sign In";
            this.btn1SignIn.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(76, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 35);
            this.label4.TabIndex = 1;
            this.label4.Text = "Create New Account";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(90, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 14);
            this.label5.TabIndex = 2;
            this.label5.Text = "Alredy have an account?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(218, 43);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(60, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log in here";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(90, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Name";
            // 
            // txt1Name
            // 
            this.txt1Name.BackColor = System.Drawing.Color.Black;
            this.txt1Name.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1Name.Location = new System.Drawing.Point(93, 90);
            this.txt1Name.Name = "txt1Name";
            this.txt1Name.Size = new System.Drawing.Size(185, 25);
            this.txt1Name.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(90, 127);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt1Email
            // 
            this.txt1Email.BackColor = System.Drawing.Color.Black;
            this.txt1Email.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1Email.Location = new System.Drawing.Point(93, 147);
            this.txt1Email.Name = "txt1Email";
            this.txt1Email.Size = new System.Drawing.Size(185, 25);
            this.txt1Email.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(90, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Password";
            // 
            // txt1Password
            // 
            this.txt1Password.BackColor = System.Drawing.Color.Black;
            this.txt1Password.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1Password.Location = new System.Drawing.Point(93, 205);
            this.txt1Password.Name = "txt1Password";
            this.txt1Password.Size = new System.Drawing.Size(185, 25);
            this.txt1Password.TabIndex = 9;
            // 
            // cmb1Role
            // 
            this.cmb1Role.BackColor = System.Drawing.Color.White;
            this.cmb1Role.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb1Role.FormattingEnabled = true;
            this.cmb1Role.Items.AddRange(new object[] {
            "Driver",
            "Manager"});
            this.cmb1Role.Location = new System.Drawing.Point(93, 268);
            this.cmb1Role.Name = "cmb1Role";
            this.cmb1Role.Size = new System.Drawing.Size(158, 24);
            this.cmb1Role.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(90, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Posistion";
            // 
            // btnSubmitCreate
            // 
            this.btnSubmitCreate.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitCreate.Location = new System.Drawing.Point(93, 336);
            this.btnSubmitCreate.Name = "btnSubmitCreate";
            this.btnSubmitCreate.Size = new System.Drawing.Size(145, 23);
            this.btnSubmitCreate.TabIndex = 12;
            this.btnSubmitCreate.Text = "Create Account";
            this.btnSubmitCreate.UseVisualStyleBackColor = true;
            // 
            // StartingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(850, 571);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelCreateAccoount);
            this.Controls.Add(this.LPpanel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.AppDescription);
            this.Controls.Add(this.AppTitle);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "StartingPage";
            this.Text = "VanGuard";
            this.Load += new System.EventHandler(this.StartingPage_Load);
            this.panelCreateAccoount.ResumeLayout(false);
            this.panelCreateAccoount.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppTitle;
        private System.Windows.Forms.TextBox AppDescription;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel LPpanel;
        private System.Windows.Forms.Panel panelCreateAccoount;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txt1LoginPassword;
        private System.Windows.Forms.TextBox txt2LoginEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn1SignIn;
        private System.Windows.Forms.TextBox txt1Email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt1Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmitCreate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb1Role;
        private System.Windows.Forms.TextBox txt1Password;
        private System.Windows.Forms.Label label8;
    }
}

