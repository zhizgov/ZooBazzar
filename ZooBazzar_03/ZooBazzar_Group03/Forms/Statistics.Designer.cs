namespace ZooBazzar_Group03.Forms
{
    partial class Statistics
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
            this.panelStatistics = new System.Windows.Forms.Panel();
            this.btnGetStatistics = new System.Windows.Forms.Button();
            this.rbWeeklyStats = new System.Windows.Forms.RadioButton();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.rbMonthlyStats = new System.Windows.Forms.RadioButton();
            this.rbYearlyStats = new System.Windows.Forms.RadioButton();
            this.btnGetIncome = new System.Windows.Forms.Button();
            this.btnNrOfVisitors = new System.Windows.Forms.Button();
            this.btnGetNumberOfVisitors = new System.Windows.Forms.Button();
            this.btnLiveStatistics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelStatistics
            // 
            this.panelStatistics.Location = new System.Drawing.Point(295, 26);
            this.panelStatistics.Name = "panelStatistics";
            this.panelStatistics.Size = new System.Drawing.Size(575, 296);
            this.panelStatistics.TabIndex = 0;
            // 
            // btnGetStatistics
            // 
            this.btnGetStatistics.Location = new System.Drawing.Point(21, 188);
            this.btnGetStatistics.Name = "btnGetStatistics";
            this.btnGetStatistics.Size = new System.Drawing.Size(251, 33);
            this.btnGetStatistics.TabIndex = 1;
            this.btnGetStatistics.Text = "Get number of tickets sold";
            this.btnGetStatistics.UseVisualStyleBackColor = true;
            this.btnGetStatistics.Click += new System.EventHandler(this.btnGetStatistics_Click);
            // 
            // rbWeeklyStats
            // 
            this.rbWeeklyStats.AutoSize = true;
            this.rbWeeklyStats.Location = new System.Drawing.Point(43, 26);
            this.rbWeeklyStats.Name = "rbWeeklyStats";
            this.rbWeeklyStats.Size = new System.Drawing.Size(137, 24);
            this.rbWeeklyStats.TabIndex = 2;
            this.rbWeeklyStats.TabStop = true;
            this.rbWeeklyStats.Text = "Weekly statistics";
            this.rbWeeklyStats.UseVisualStyleBackColor = true;
            this.rbWeeklyStats.CheckedChanged += new System.EventHandler(this.rbWeeklyStats_CheckedChanged);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(487, 367);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(250, 27);
            this.dtp.TabIndex = 3;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // rbMonthlyStats
            // 
            this.rbMonthlyStats.AutoSize = true;
            this.rbMonthlyStats.Location = new System.Drawing.Point(43, 76);
            this.rbMonthlyStats.Name = "rbMonthlyStats";
            this.rbMonthlyStats.Size = new System.Drawing.Size(136, 24);
            this.rbMonthlyStats.TabIndex = 4;
            this.rbMonthlyStats.TabStop = true;
            this.rbMonthlyStats.Text = "Montly statistics";
            this.rbMonthlyStats.UseVisualStyleBackColor = true;
            this.rbMonthlyStats.CheckedChanged += new System.EventHandler(this.rbMonthlyStats_CheckedChanged);
            // 
            // rbYearlyStats
            // 
            this.rbYearlyStats.AutoSize = true;
            this.rbYearlyStats.Location = new System.Drawing.Point(43, 128);
            this.rbYearlyStats.Name = "rbYearlyStats";
            this.rbYearlyStats.Size = new System.Drawing.Size(129, 24);
            this.rbYearlyStats.TabIndex = 5;
            this.rbYearlyStats.TabStop = true;
            this.rbYearlyStats.Text = "Yearly statistics";
            this.rbYearlyStats.UseVisualStyleBackColor = true;
            this.rbYearlyStats.CheckedChanged += new System.EventHandler(this.rbYearlyStats_CheckedChanged);
            // 
            // btnGetIncome
            // 
            this.btnGetIncome.Location = new System.Drawing.Point(21, 227);
            this.btnGetIncome.Name = "btnGetIncome";
            this.btnGetIncome.Size = new System.Drawing.Size(251, 33);
            this.btnGetIncome.TabIndex = 8;
            this.btnGetIncome.Text = "Get income";
            this.btnGetIncome.UseVisualStyleBackColor = true;
            this.btnGetIncome.Click += new System.EventHandler(this.btnGetIncome_Click);
            // 
            // btnNrOfVisitors
            // 
            this.btnNrOfVisitors.Location = new System.Drawing.Point(21, 273);
            this.btnNrOfVisitors.Name = "btnNrOfVisitors";
            this.btnNrOfVisitors.Size = new System.Drawing.Size(251, 49);
            this.btnNrOfVisitors.TabIndex = 9;
            this.btnNrOfVisitors.Text = "Get avarage number of visitors per day";
            this.btnNrOfVisitors.UseVisualStyleBackColor = true;
            this.btnNrOfVisitors.Click += new System.EventHandler(this.btnNrOfVisitors_Click);
            // 
            // btnGetNumberOfVisitors
            // 
            this.btnGetNumberOfVisitors.Location = new System.Drawing.Point(21, 328);
            this.btnGetNumberOfVisitors.Name = "btnGetNumberOfVisitors";
            this.btnGetNumberOfVisitors.Size = new System.Drawing.Size(251, 29);
            this.btnGetNumberOfVisitors.TabIndex = 11;
            this.btnGetNumberOfVisitors.Text = "Get visitors";
            this.btnGetNumberOfVisitors.UseVisualStyleBackColor = true;
            this.btnGetNumberOfVisitors.Click += new System.EventHandler(this.btnGetNumberOfVisitors_Click);
            // 
            // btnLiveStatistics
            // 
            this.btnLiveStatistics.Location = new System.Drawing.Point(21, 368);
            this.btnLiveStatistics.Name = "btnLiveStatistics";
            this.btnLiveStatistics.Size = new System.Drawing.Size(251, 29);
            this.btnLiveStatistics.TabIndex = 12;
            this.btnLiveStatistics.Text = "Get live number of visitors";
            this.btnLiveStatistics.UseVisualStyleBackColor = true;
            this.btnLiveStatistics.Click += new System.EventHandler(this.btnLiveStatistics_Click);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 430);
            this.Controls.Add(this.btnLiveStatistics);
            this.Controls.Add(this.btnGetNumberOfVisitors);
            this.Controls.Add(this.btnNrOfVisitors);
            this.Controls.Add(this.btnGetIncome);
            this.Controls.Add(this.rbYearlyStats);
            this.Controls.Add(this.rbMonthlyStats);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.rbWeeklyStats);
            this.Controls.Add(this.btnGetStatistics);
            this.Controls.Add(this.panelStatistics);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelStatistics;
        private Button btnGetStatistics;
        private RadioButton rbWeeklyStats;
        private DateTimePicker dtp;
        private RadioButton rbMonthlyStats;
        private RadioButton rbYearlyStats;
        private Button btnGetIncome;
        private Button btnNrOfVisitors;
        private Button btnGetNumberOfVisitors;
        private Button btnLiveStatistics;
    }
}