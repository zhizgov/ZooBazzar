namespace ZooBazzar_Group03.Forms
{
    partial class HomePage
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
            this.flpEmployees = new System.Windows.Forms.FlowLayoutPanel();
            this.cbWorkPosition = new System.Windows.Forms.ComboBox();
            this.btnWorkPosition = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpEmployees
            // 
            this.flpEmployees.AutoScroll = true;
            this.flpEmployees.Location = new System.Drawing.Point(554, 0);
            this.flpEmployees.Name = "flpEmployees";
            this.flpEmployees.Size = new System.Drawing.Size(410, 525);
            this.flpEmployees.TabIndex = 0;
            // 
            // cbWorkPosition
            // 
            this.cbWorkPosition.FormattingEnabled = true;
            this.cbWorkPosition.Location = new System.Drawing.Point(88, 173);
            this.cbWorkPosition.Name = "cbWorkPosition";
            this.cbWorkPosition.Size = new System.Drawing.Size(173, 28);
            this.cbWorkPosition.TabIndex = 0;
            // 
            // btnWorkPosition
            // 
            this.btnWorkPosition.Location = new System.Drawing.Point(293, 163);
            this.btnWorkPosition.Name = "btnWorkPosition";
            this.btnWorkPosition.Size = new System.Drawing.Size(156, 47);
            this.btnWorkPosition.TabIndex = 2;
            this.btnWorkPosition.Text = "by specilization";
            this.btnWorkPosition.UseVisualStyleBackColor = true;
            this.btnWorkPosition.Click += new System.EventHandler(this.btnWorkPosition_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(293, 235);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(156, 47);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(88, 245);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(173, 27);
            this.tbSearch.TabIndex = 4;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(88, 303);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(361, 61);
            this.btnAll.TabIndex = 5;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 524);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnWorkPosition);
            this.Controls.Add(this.cbWorkPosition);
            this.Controls.Add(this.flpEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flpEmployees;
        private ComboBox cbWorkPosition;
        private Button btnWorkPosition;
        private Button btnSearch;
        private TextBox tbSearch;
        private Button btnAll;
    }
}