namespace GroupProject
{
    partial class ManagerHomePage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.viewstatusBtn = new System.Windows.Forms.Button();
            this.addremovevanBtn = new System.Windows.Forms.Button();
            this.repairstatusBtn = new System.Windows.Forms.Button();
            this.updatestatusBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 49);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(349, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 51);
            this.label1.TabIndex = 13;
            this.label1.Text = "Home";
            // 
            // viewstatusBtn
            // 
            this.viewstatusBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.viewstatusBtn.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewstatusBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewstatusBtn.Location = new System.Drawing.Point(277, 150);
            this.viewstatusBtn.Name = "viewstatusBtn";
            this.viewstatusBtn.Size = new System.Drawing.Size(104, 86);
            this.viewstatusBtn.TabIndex = 12;
            this.viewstatusBtn.Text = "VIEW VAN STATUS";
            this.viewstatusBtn.UseVisualStyleBackColor = false;
            // 
            // addremovevanBtn
            // 
            this.addremovevanBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.addremovevanBtn.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addremovevanBtn.Location = new System.Drawing.Point(419, 150);
            this.addremovevanBtn.Name = "addremovevanBtn";
            this.addremovevanBtn.Size = new System.Drawing.Size(104, 86);
            this.addremovevanBtn.TabIndex = 11;
            this.addremovevanBtn.Text = "ADD OR REMOVE VAN";
            this.addremovevanBtn.UseVisualStyleBackColor = false;
            // 
            // repairstatusBtn
            // 
            this.repairstatusBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.repairstatusBtn.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairstatusBtn.Location = new System.Drawing.Point(419, 279);
            this.repairstatusBtn.Name = "repairstatusBtn";
            this.repairstatusBtn.Size = new System.Drawing.Size(104, 86);
            this.repairstatusBtn.TabIndex = 10;
            this.repairstatusBtn.Text = "VAN REPAIR STATUS";
            this.repairstatusBtn.UseVisualStyleBackColor = false;
            // 
            // updatestatusBtn
            // 
            this.updatestatusBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.updatestatusBtn.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatestatusBtn.Location = new System.Drawing.Point(277, 279);
            this.updatestatusBtn.Name = "updatestatusBtn";
            this.updatestatusBtn.Size = new System.Drawing.Size(104, 86);
            this.updatestatusBtn.TabIndex = 9;
            this.updatestatusBtn.Text = "UPDATE VAN STATUS";
            this.updatestatusBtn.UseVisualStyleBackColor = false;
            // 
            // ManagerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewstatusBtn);
            this.Controls.Add(this.addremovevanBtn);
            this.Controls.Add(this.repairstatusBtn);
            this.Controls.Add(this.updatestatusBtn);
            this.Controls.Add(this.panel1);
            this.Name = "ManagerHomePage";
            this.Text = "ManagerHomePage";
            this.Load += new System.EventHandler(this.ManagerHomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewstatusBtn;
        private System.Windows.Forms.Button addremovevanBtn;
        private System.Windows.Forms.Button repairstatusBtn;
        private System.Windows.Forms.Button updatestatusBtn;
    }
}