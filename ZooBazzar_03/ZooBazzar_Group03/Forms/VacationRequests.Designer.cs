namespace ZooBazzar_Group03.Forms
{
    partial class VacationRequests
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
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnDeny = new System.Windows.Forms.Button();
            this.lbVacations = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(103, 196);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(250, 58);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnDeny
            // 
            this.btnDeny.Location = new System.Drawing.Point(103, 281);
            this.btnDeny.Name = "btnDeny";
            this.btnDeny.Size = new System.Drawing.Size(250, 58);
            this.btnDeny.TabIndex = 1;
            this.btnDeny.Text = "Deny";
            this.btnDeny.UseVisualStyleBackColor = true;
            this.btnDeny.Click += new System.EventHandler(this.btnDeny_Click);
            // 
            // lbVacations
            // 
            this.lbVacations.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbVacations.FormattingEnabled = true;
            this.lbVacations.ItemHeight = 20;
            this.lbVacations.Location = new System.Drawing.Point(461, 0);
            this.lbVacations.Name = "lbVacations";
            this.lbVacations.Size = new System.Drawing.Size(519, 571);
            this.lbVacations.TabIndex = 2;
            // 
            // VacationRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 571);
            this.Controls.Add(this.lbVacations);
            this.Controls.Add(this.btnDeny);
            this.Controls.Add(this.btnAccept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VacationRequests";
            this.Text = "VacationRequests";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAccept;
        private Button btnDeny;
        private ListBox lbVacations;
    }
}