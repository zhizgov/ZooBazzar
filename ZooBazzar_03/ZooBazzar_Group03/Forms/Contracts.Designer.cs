namespace ZooBazzar_Group03.Forms
{
    partial class Contracts
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
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblFTE = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.tbReason = new System.Windows.Forms.TextBox();
            this.tbFte = new System.Windows.Forms.TextBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnCreateContract = new System.Windows.Forms.Button();
            this.btnDisableContract = new System.Windows.Forms.Button();
            this.lbContracts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbEmployee
            // 
            this.cbEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(310, 299);
            this.cbEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(183, 28);
            this.cbEmployee.TabIndex = 35;
            // 
            // lblReason
            // 
            this.lblReason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(310, 136);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(60, 20);
            this.lblReason.TabIndex = 34;
            this.lblReason.Text = "Reason:";
            // 
            // lblFTE
            // 
            this.lblFTE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFTE.AutoSize = true;
            this.lblFTE.Location = new System.Drawing.Point(29, 276);
            this.lblFTE.Name = "lblFTE";
            this.lblFTE.Size = new System.Drawing.Size(38, 20);
            this.lblFTE.TabIndex = 33;
            this.lblFTE.Text = "FTEs";
            // 
            // lblEndDate
            // 
            this.lblEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(28, 206);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(70, 20);
            this.lblEndDate.TabIndex = 32;
            this.lblEndDate.Text = "End Date";
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(29, 136);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(76, 20);
            this.lblStartDate.TabIndex = 31;
            this.lblStartDate.Text = "Start Date";
            // 
            // tbReason
            // 
            this.tbReason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReason.Location = new System.Drawing.Point(310, 160);
            this.tbReason.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbReason.Multiline = true;
            this.tbReason.Name = "tbReason";
            this.tbReason.Size = new System.Drawing.Size(183, 107);
            this.tbReason.TabIndex = 30;
            // 
            // tbFte
            // 
            this.tbFte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFte.Location = new System.Drawing.Point(29, 300);
            this.tbFte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFte.Name = "tbFte";
            this.tbFte.Size = new System.Drawing.Size(183, 27);
            this.tbFte.TabIndex = 29;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEndDate.Location = new System.Drawing.Point(28, 230);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(267, 27);
            this.dtpEndDate.TabIndex = 28;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStartDate.Location = new System.Drawing.Point(28, 160);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(267, 27);
            this.dtpStartDate.TabIndex = 27;
            // 
            // btnCreateContract
            // 
            this.btnCreateContract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateContract.Location = new System.Drawing.Point(28, 357);
            this.btnCreateContract.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateContract.Name = "btnCreateContract";
            this.btnCreateContract.Size = new System.Drawing.Size(465, 44);
            this.btnCreateContract.TabIndex = 26;
            this.btnCreateContract.Text = "Create Contract";
            this.btnCreateContract.UseVisualStyleBackColor = true;
            this.btnCreateContract.Click += new System.EventHandler(this.btnCreateContract_Click);
            // 
            // btnDisableContract
            // 
            this.btnDisableContract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisableContract.Location = new System.Drawing.Point(543, 357);
            this.btnDisableContract.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDisableContract.Name = "btnDisableContract";
            this.btnDisableContract.Size = new System.Drawing.Size(162, 44);
            this.btnDisableContract.TabIndex = 25;
            this.btnDisableContract.Text = "Disable";
            this.btnDisableContract.UseVisualStyleBackColor = true;
            this.btnDisableContract.Click += new System.EventHandler(this.btnDisableContract_Click);
            // 
            // lbContracts
            // 
            this.lbContracts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbContracts.FormattingEnabled = true;
            this.lbContracts.ItemHeight = 20;
            this.lbContracts.Location = new System.Drawing.Point(543, 33);
            this.lbContracts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbContracts.Name = "lbContracts";
            this.lbContracts.Size = new System.Drawing.Size(379, 304);
            this.lbContracts.TabIndex = 24;
            this.lbContracts.SelectedIndexChanged += new System.EventHandler(this.lbContracts_SelectedIndexChanged);
            this.lbContracts.DoubleClick += new System.EventHandler(this.lbContracts_DoubleClick);
            // 
            // Contracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 477);
            this.Controls.Add(this.cbEmployee);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.lblFTE);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.tbReason);
            this.Controls.Add(this.tbFte);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.btnCreateContract);
            this.Controls.Add(this.btnDisableContract);
            this.Controls.Add(this.lbContracts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Contracts";
            this.Text = "Contracts";
            this.Load += new System.EventHandler(this.Contracts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbEmployee;
        private Label lblReason;
        private Label lblFTE;
        private Label lblEndDate;
        private Label lblStartDate;
        private TextBox tbReason;
        private TextBox tbFte;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private Button btnCreateContract;
        private Button btnDisableContract;
        private ListBox lbContracts;
    }
}