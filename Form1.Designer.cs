namespace GroupProject
{
    partial class Form1
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
            this.CreateAccount = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.LPpanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // AppTitle
            // 
            this.AppTitle.AutoSize = true;
            this.AppTitle.Font = new System.Drawing.Font("Myanmar Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AppTitle.Location = new System.Drawing.Point(216, 153);
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
            this.AppDescription.Location = new System.Drawing.Point(225, 207);
            this.AppDescription.Multiline = true;
            this.AppDescription.Name = "AppDescription";
            this.AppDescription.ReadOnly = true;
            this.AppDescription.Size = new System.Drawing.Size(225, 70);
            this.AppDescription.TabIndex = 1;
            this.AppDescription.Text = "A thoughtful combination of design and function to support your everyday movement" +
    ". Limited stocks. Shop now.";
            // 
            // CreateAccount
            // 
            this.CreateAccount.BackColor = System.Drawing.Color.OrangeRed;
            this.CreateAccount.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccount.Location = new System.Drawing.Point(225, 301);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Size = new System.Drawing.Size(132, 31);
            this.CreateAccount.TabIndex = 2;
            this.CreateAccount.Text = "create account";
            this.CreateAccount.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(374, 301);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(132, 31);
            this.Login.TabIndex = 3;
            this.Login.Text = "log in";
            this.Login.UseVisualStyleBackColor = true;
            // 
            // LPpanel
            // 
            this.LPpanel.BackColor = System.Drawing.Color.OrangeRed;
            this.LPpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LPpanel.Location = new System.Drawing.Point(0, 0);
            this.LPpanel.Name = "LPpanel";
            this.LPpanel.Size = new System.Drawing.Size(800, 49);
            this.LPpanel.TabIndex = 4;
            this.LPpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LPpanel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LPpanel);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.CreateAccount);
            this.Controls.Add(this.AppDescription);
            this.Controls.Add(this.AppTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppTitle;
        private System.Windows.Forms.TextBox AppDescription;
        private System.Windows.Forms.Button CreateAccount;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Panel LPpanel;
    }
}

