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
            this.SuspendLayout();
            // 
            // AppTitle
            // 
            this.AppTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppTitle.AutoSize = true;
            this.AppTitle.Font = new System.Drawing.Font("Myanmar Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AppTitle.Location = new System.Drawing.Point(161, 94);
            this.AppTitle.Name = "AppTitle";
            this.AppTitle.Size = new System.Drawing.Size(160, 51);
            this.AppTitle.TabIndex = 0;
            this.AppTitle.Text = "VanGuard";
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
            this.LPpanel.Size = new System.Drawing.Size(977, 53);
            this.LPpanel.TabIndex = 4;
            this.LPpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LPpanel_Paint);
            // 
            // StartingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(972, 673);
            this.Controls.Add(this.LPpanel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.AppDescription);
            this.Controls.Add(this.AppTitle);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "StartingPage";
            this.Text = "VanGuard";
            this.Load += new System.EventHandler(this.StartingPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppTitle;
        private System.Windows.Forms.TextBox AppDescription;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel LPpanel;
    }
}

