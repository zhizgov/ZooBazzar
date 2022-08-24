namespace ZooBazzar_Group03.Forms
{
    partial class Request
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
            this.lblEmployeesWithOld = new System.Windows.Forms.Label();
            this.lblEmployeesWithNew = new System.Windows.Forms.Label();
            this.lbEmployeesWithOldCredentials = new System.Windows.Forms.ListBox();
            this.btnDecline = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lbEmployeesWithNewCredentials = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblEmployeesWithOld
            // 
            this.lblEmployeesWithOld.AutoSize = true;
            this.lblEmployeesWithOld.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmployeesWithOld.Location = new System.Drawing.Point(589, 61);
            this.lblEmployeesWithOld.Name = "lblEmployeesWithOld";
            this.lblEmployeesWithOld.Size = new System.Drawing.Size(255, 23);
            this.lblEmployeesWithOld.TabIndex = 11;
            this.lblEmployeesWithOld.Text = "Employees with old Information";
            // 
            // lblEmployeesWithNew
            // 
            this.lblEmployeesWithNew.AutoSize = true;
            this.lblEmployeesWithNew.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmployeesWithNew.Location = new System.Drawing.Point(66, 61);
            this.lblEmployeesWithNew.Name = "lblEmployeesWithNew";
            this.lblEmployeesWithNew.Size = new System.Drawing.Size(263, 23);
            this.lblEmployeesWithNew.TabIndex = 10;
            this.lblEmployeesWithNew.Text = "Employees with new Information";
            // 
            // lbEmployeesWithOldCredentials
            // 
            this.lbEmployeesWithOldCredentials.FormattingEnabled = true;
            this.lbEmployeesWithOldCredentials.ItemHeight = 20;
            this.lbEmployeesWithOldCredentials.Location = new System.Drawing.Point(518, 94);
            this.lbEmployeesWithOldCredentials.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbEmployeesWithOldCredentials.Name = "lbEmployeesWithOldCredentials";
            this.lbEmployeesWithOldCredentials.Size = new System.Drawing.Size(389, 304);
            this.lbEmployeesWithOldCredentials.TabIndex = 9;
            // 
            // btnDecline
            // 
            this.btnDecline.BackgroundImage = global::ZooBazzar_Group03.Properties.Resources.reject_request;
            this.btnDecline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDecline.Location = new System.Drawing.Point(424, 261);
            this.btnDecline.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(59, 46);
            this.btnDecline.TabIndex = 8;
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackgroundImage = global::ZooBazzar_Group03.Properties.Resources.approved_request;
            this.btnAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAccept.Location = new System.Drawing.Point(424, 198);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(59, 46);
            this.btnAccept.TabIndex = 7;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lbEmployeesWithNewCredentials
            // 
            this.lbEmployeesWithNewCredentials.FormattingEnabled = true;
            this.lbEmployeesWithNewCredentials.ItemHeight = 20;
            this.lbEmployeesWithNewCredentials.Location = new System.Drawing.Point(20, 94);
            this.lbEmployeesWithNewCredentials.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbEmployeesWithNewCredentials.Name = "lbEmployeesWithNewCredentials";
            this.lbEmployeesWithNewCredentials.Size = new System.Drawing.Size(371, 304);
            this.lbEmployeesWithNewCredentials.TabIndex = 6;
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 477);
            this.Controls.Add(this.lblEmployeesWithOld);
            this.Controls.Add(this.lblEmployeesWithNew);
            this.Controls.Add(this.lbEmployeesWithOldCredentials);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lbEmployeesWithNewCredentials);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Request";
            this.Text = "Request";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEmployeesWithOld;
        private Label lblEmployeesWithNew;
        private ListBox lbEmployeesWithOldCredentials;
        private Button btnDecline;
        private Button btnAccept;
        private ListBox lbEmployeesWithNewCredentials;
    }
}