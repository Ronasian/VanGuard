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
            this.vansDGV = new System.Windows.Forms.DataGridView();
            this.Addbtn = new System.Windows.Forms.Button();
            this.VanIDtextbox = new System.Windows.Forms.TextBox();
            this.VanIDlabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vansDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 49);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(358, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 48);
            this.label1.TabIndex = 13;
            this.label1.Text = "Home";
            // 
            // vansDGV
            // 
            this.vansDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vansDGV.Location = new System.Drawing.Point(12, 106);
            this.vansDGV.Name = "vansDGV";
            this.vansDGV.Size = new System.Drawing.Size(776, 332);
            this.vansDGV.TabIndex = 14;
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(732, 83);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(56, 20);
            this.Addbtn.TabIndex = 15;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // VanIDtextbox
            // 
            this.VanIDtextbox.Location = new System.Drawing.Point(623, 83);
            this.VanIDtextbox.Name = "VanIDtextbox";
            this.VanIDtextbox.Size = new System.Drawing.Size(103, 20);
            this.VanIDtextbox.TabIndex = 16;
            // 
            // VanIDlabel
            // 
            this.VanIDlabel.AutoSize = true;
            this.VanIDlabel.Location = new System.Drawing.Point(574, 87);
            this.VanIDlabel.Name = "VanIDlabel";
            this.VanIDlabel.Size = new System.Drawing.Size(43, 13);
            this.VanIDlabel.TabIndex = 17;
            this.VanIDlabel.Text = "Van ID:";
            // 
            // ManagerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VanIDlabel);
            this.Controls.Add(this.VanIDtextbox);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.vansDGV);
            this.Controls.Add(this.panel1);
            this.Name = "ManagerHomePage";
            this.Text = "ManagerHomePage";
            this.Load += new System.EventHandler(this.ManagerHomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vansDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView vansDGV;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.TextBox VanIDtextbox;
        private System.Windows.Forms.Label VanIDlabel;
    }
}