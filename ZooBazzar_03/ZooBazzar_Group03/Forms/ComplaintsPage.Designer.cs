namespace ZooBazzar_Group03.Forms
{
    partial class ComplaintsPage
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
            this.lblComplaints = new System.Windows.Forms.ListBox();
            this.btnComplaints = new System.Windows.Forms.Button();
            this.pContent = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblComplaints
            // 
            this.lblComplaints.FormattingEnabled = true;
            this.lblComplaints.ItemHeight = 20;
            this.lblComplaints.Location = new System.Drawing.Point(167, 85);
            this.lblComplaints.Name = "lblComplaints";
            this.lblComplaints.Size = new System.Drawing.Size(353, 384);
            this.lblComplaints.TabIndex = 0;
            this.lblComplaints.DoubleClick += new System.EventHandler(this.lblComplaints_DoubleClick);
            // 
            // btnComplaints
            // 
            this.btnComplaints.Location = new System.Drawing.Point(12, 216);
            this.btnComplaints.Name = "btnComplaints";
            this.btnComplaints.Size = new System.Drawing.Size(127, 77);
            this.btnComplaints.TabIndex = 1;
            this.btnComplaints.Text = "Load complaints";
            this.btnComplaints.UseVisualStyleBackColor = true;
            this.btnComplaints.Click += new System.EventHandler(this.btnComplaints_Click);
            // 
            // pContent
            // 
            this.pContent.Location = new System.Drawing.Point(541, 1);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(440, 570);
            this.pContent.TabIndex = 46;
            // 
            // ComplaintsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 571);
            this.Controls.Add(this.pContent);
            this.Controls.Add(this.btnComplaints);
            this.Controls.Add(this.lblComplaints);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComplaintsPage";
            this.Text = "ComplaintsPage";
            this.Load += new System.EventHandler(this.ComplaintsPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lblComplaints;
        private Button btnComplaints;
        private Panel pContent;
    }
}