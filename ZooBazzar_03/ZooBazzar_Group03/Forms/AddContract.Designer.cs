namespace ZooBazzar_Group03.Forms
{
    partial class AddContract
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbReason = new System.Windows.Forms.TextBox();
            this.tbFte = new System.Windows.Forms.TextBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnCreateContract = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(102, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(236, 31);
            this.lblTitle.TabIndex = 67;
            this.lblTitle.Text = "Assign a contract";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPassword.Location = new System.Drawing.Point(26, 355);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(85, 20);
            this.lblPassword.TabIndex = 66;
            this.lblPassword.Text = "End Date:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUsername.Location = new System.Drawing.Point(22, 290);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(89, 20);
            this.lblUsername.TabIndex = 65;
            this.lblUsername.Text = "Start Date:";
            // 
            // tbReason
            // 
            this.tbReason.Location = new System.Drawing.Point(22, 169);
            this.tbReason.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbReason.Multiline = true;
            this.tbReason.Name = "tbReason";
            this.tbReason.Size = new System.Drawing.Size(407, 107);
            this.tbReason.TabIndex = 72;
            // 
            // tbFte
            // 
            this.tbFte.Location = new System.Drawing.Point(356, 326);
            this.tbFte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFte.Name = "tbFte";
            this.tbFte.Size = new System.Drawing.Size(73, 27);
            this.tbFte.TabIndex = 71;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(22, 379);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(245, 27);
            this.dtpEndDate.TabIndex = 70;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(23, 324);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(245, 27);
            this.dtpStartDate.TabIndex = 69;
            // 
            // btnCreateContract
            // 
            this.btnCreateContract.Location = new System.Drawing.Point(345, 442);
            this.btnCreateContract.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateContract.Name = "btnCreateContract";
            this.btnCreateContract.Size = new System.Drawing.Size(94, 28);
            this.btnCreateContract.TabIndex = 68;
            this.btnCreateContract.Text = "Assign";
            this.btnCreateContract.UseVisualStyleBackColor = true;
            this.btnCreateContract.Click += new System.EventHandler(this.btnCreateContract_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(356, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 77;
            this.label1.Text = "FTEs :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(190, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 78;
            this.label2.Text = "Reason";
            // 
            // AddContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(451, 483);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbReason);
            this.Controls.Add(this.tbFte);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.btnCreateContract);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddContract";
            this.Text = "AddContract";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Label lblPassword;
        private Label lblUsername;
        private TextBox tbReason;
        private TextBox tbFte;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private Button btnCreateContract;
        private Label label1;
        private Label label2;
    }
}