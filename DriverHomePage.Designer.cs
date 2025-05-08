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
            this.label1 = new System.Windows.Forms.Label();
            this.Vanscombobox = new System.Windows.Forms.ComboBox();
            this.btnAssignVan = new System.Windows.Forms.Button();
            this.Vanslabel = new System.Windows.Forms.Label();
            this.Exteriorcheckbox = new System.Windows.Forms.CheckBox();
            this.Lightscheckbox = new System.Windows.Forms.CheckBox();
            this.Enginecheckbox = new System.Windows.Forms.CheckBox();
            this.notestextBox = new System.Windows.Forms.TextBox();
            this.Noteslabel = new System.Windows.Forms.Label();
            this.btnInspect = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 49);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(350, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 51);
            this.label1.TabIndex = 8;
            this.label1.Text = "Home";
            // 
            // Vanscombobox
            // 
            this.Vanscombobox.FormattingEnabled = true;
            this.Vanscombobox.Location = new System.Drawing.Point(333, 90);
            this.Vanscombobox.Name = "Vanscombobox";
            this.Vanscombobox.Size = new System.Drawing.Size(122, 21);
            this.Vanscombobox.TabIndex = 8;
            // 
            // btnAssignVan
            // 
            this.btnAssignVan.Location = new System.Drawing.Point(461, 90);
            this.btnAssignVan.Name = "btnAssignVan";
            this.btnAssignVan.Size = new System.Drawing.Size(99, 21);
            this.btnAssignVan.TabIndex = 9;
            this.btnAssignVan.Text = "Assign";
            this.btnAssignVan.UseVisualStyleBackColor = true;
            this.btnAssignVan.Click += new System.EventHandler(this.btnAssignVan_Click);
            // 
            // Vanslabel
            // 
            this.Vanslabel.AutoSize = true;
            this.Vanslabel.Location = new System.Drawing.Point(263, 94);
            this.Vanslabel.Name = "Vanslabel";
            this.Vanslabel.Size = new System.Drawing.Size(64, 13);
            this.Vanslabel.TabIndex = 10;
            this.Vanslabel.Text = "Active Vans";
            // 
            // Exteriorcheckbox
            // 
            this.Exteriorcheckbox.AutoSize = true;
            this.Exteriorcheckbox.Location = new System.Drawing.Point(266, 135);
            this.Exteriorcheckbox.Name = "Exteriorcheckbox";
            this.Exteriorcheckbox.Size = new System.Drawing.Size(137, 17);
            this.Exteriorcheckbox.TabIndex = 11;
            this.Exteriorcheckbox.Text = "Visible Exterior Damage";
            this.Exteriorcheckbox.UseVisualStyleBackColor = true;
            // 
            // Lightscheckbox
            // 
            this.Lightscheckbox.AutoSize = true;
            this.Lightscheckbox.Location = new System.Drawing.Point(266, 174);
            this.Lightscheckbox.Name = "Lightscheckbox";
            this.Lightscheckbox.Size = new System.Drawing.Size(113, 17);
            this.Lightscheckbox.TabIndex = 12;
            this.Lightscheckbox.Text = "Lights Broken/Out";
            this.Lightscheckbox.UseVisualStyleBackColor = true;
            // 
            // Enginecheckbox
            // 
            this.Enginecheckbox.AutoSize = true;
            this.Enginecheckbox.Location = new System.Drawing.Point(266, 214);
            this.Enginecheckbox.Name = "Enginecheckbox";
            this.Enginecheckbox.Size = new System.Drawing.Size(125, 17);
            this.Enginecheckbox.TabIndex = 13;
            this.Enginecheckbox.Text = "Engine Noise/Failure";
            this.Enginecheckbox.UseVisualStyleBackColor = true;
            // 
            // notestextBox
            // 
            this.notestextBox.Location = new System.Drawing.Point(266, 269);
            this.notestextBox.Name = "notestextBox";
            this.notestextBox.Size = new System.Drawing.Size(294, 20);
            this.notestextBox.TabIndex = 14;
            // 
            // Noteslabel
            // 
            this.Noteslabel.AutoSize = true;
            this.Noteslabel.Location = new System.Drawing.Point(263, 253);
            this.Noteslabel.Name = "Noteslabel";
            this.Noteslabel.Size = new System.Drawing.Size(38, 13);
            this.Noteslabel.TabIndex = 15;
            this.Noteslabel.Text = "Notes:";
            // 
            // btnInspect
            // 
            this.btnInspect.Location = new System.Drawing.Point(359, 307);
            this.btnInspect.Name = "btnInspect";
            this.btnInspect.Size = new System.Drawing.Size(103, 25);
            this.btnInspect.TabIndex = 16;
            this.btnInspect.Text = "Submit Inspection";
            this.btnInspect.UseVisualStyleBackColor = true;
            this.btnInspect.Click += new System.EventHandler(this.btnInspect_Click);
            // 
            // DriverHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInspect);
            this.Controls.Add(this.Noteslabel);
            this.Controls.Add(this.notestextBox);
            this.Controls.Add(this.Enginecheckbox);
            this.Controls.Add(this.Lightscheckbox);
            this.Controls.Add(this.Exteriorcheckbox);
            this.Controls.Add(this.Vanslabel);
            this.Controls.Add(this.btnAssignVan);
            this.Controls.Add(this.Vanscombobox);
            this.Controls.Add(this.panel1);
            this.Name = "DriverHomePage";
            this.Text = "VanGuard";
            this.Load += new System.EventHandler(this.DriverHomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Vanscombobox;
        private System.Windows.Forms.Button btnAssignVan;
        private System.Windows.Forms.Label Vanslabel;
        private System.Windows.Forms.CheckBox Exteriorcheckbox;
        private System.Windows.Forms.CheckBox Lightscheckbox;
        private System.Windows.Forms.CheckBox Enginecheckbox;
        private System.Windows.Forms.TextBox notestextBox;
        private System.Windows.Forms.Label Noteslabel;
        private System.Windows.Forms.Button btnInspect;
    }
}