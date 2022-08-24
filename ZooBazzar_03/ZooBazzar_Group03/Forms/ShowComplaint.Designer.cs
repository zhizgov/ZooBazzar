namespace ZooBazzar_Group03.Forms
{
    partial class ShowComplaint
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
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbComplaint = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTitle
            // 
            this.tbTitle.Enabled = false;
            this.tbTitle.Location = new System.Drawing.Point(41, 78);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(285, 23);
            this.tbTitle.TabIndex = 0;
            // 
            // tbComplaint
            // 
            this.tbComplaint.Location = new System.Drawing.Point(41, 121);
            this.tbComplaint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbComplaint.Multiline = true;
            this.tbComplaint.Name = "tbComplaint";
            this.tbComplaint.ReadOnly = true;
            this.tbComplaint.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbComplaint.Size = new System.Drawing.Size(285, 177);
            this.tbComplaint.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(243, 315);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 22);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ShowComplaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(395, 362);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbComplaint);
            this.Controls.Add(this.tbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ShowComplaint";
            this.Text = "ShowComplaint";
            this.Load += new System.EventHandler(this.ShowComplaint_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbTitle;
        private TextBox tbComplaint;
        private Button btnClose;
    }
}