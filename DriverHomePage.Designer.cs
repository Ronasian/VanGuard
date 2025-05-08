namespace GroupProject
{
    partial class DriverHomePage
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
            this.btnInpect = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAssignVan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 49);
            this.panel1.TabIndex = 0;
            // 
            // btnInpect
            // 
            this.btnInpect.BackColor = System.Drawing.Color.OrangeRed;
            this.btnInpect.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInpect.Location = new System.Drawing.Point(278, 259);
            this.btnInpect.Name = "btnInpect";
            this.btnInpect.Size = new System.Drawing.Size(104, 86);
            this.btnInpect.TabIndex = 3;
            this.btnInpect.Text = "BEGIN INSPECTION";
            this.btnInpect.UseVisualStyleBackColor = false;
            this.btnInpect.Click += new System.EventHandler(this.btnInspect_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.OrangeRed;
            this.button4.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(420, 259);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 86);
            this.button4.TabIndex = 4;
            this.button4.Text = "UPLOAD VEHICLE PHOTOS";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(420, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 86);
            this.button2.TabIndex = 6;
            this.button2.Text = "REASSIGN VEHICLE";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnAssignVan
            // 
            this.btnAssignVan.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAssignVan.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignVan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAssignVan.Location = new System.Drawing.Point(278, 130);
            this.btnAssignVan.Name = "btnAssignVan";
            this.btnAssignVan.Size = new System.Drawing.Size(104, 86);
            this.btnAssignVan.TabIndex = 7;
            this.btnAssignVan.Text = "ASSIGN VEHICLE";
            this.btnAssignVan.UseVisualStyleBackColor = false;
            this.btnAssignVan.Click += new System.EventHandler(this.btnAssignVan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(350, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 51);
            this.label1.TabIndex = 8;
            this.label1.Text = "Home";
            // 
            // DriverHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAssignVan);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnInpect);
            this.Controls.Add(this.panel1);
            this.Name = "DriverHomePage";
            this.Text = "VanGuard";
            this.Load += new System.EventHandler(this.DriverHomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInpect;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAssignVan;
        private System.Windows.Forms.Label label1;
    }
}