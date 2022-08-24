namespace ZooBazzar_Group03.Forms
{
    partial class Description
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
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.btnAddDescription = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.lbDescriptions = new System.Windows.Forms.ListBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.rbDisabled = new System.Windows.Forms.RadioButton();
            this.tbReadyDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDescriptionsByDate = new System.Windows.Forms.Label();
            this.lblCurrDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDescription.Location = new System.Drawing.Point(93, 135);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(186, 219);
            this.tbDescription.TabIndex = 0;
            // 
            // btnAddDescription
            // 
            this.btnAddDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDescription.Location = new System.Drawing.Point(4, 170);
            this.btnAddDescription.Name = "btnAddDescription";
            this.btnAddDescription.Size = new System.Drawing.Size(83, 49);
            this.btnAddDescription.TabIndex = 1;
            this.btnAddDescription.Text = "Add Description";
            this.btnAddDescription.UseVisualStyleBackColor = true;
            this.btnAddDescription.Click += new System.EventHandler(this.btnAddDescription_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDisable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisable.Location = new System.Drawing.Point(4, 255);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(83, 49);
            this.btnDisable.TabIndex = 2;
            this.btnDisable.Text = "Disable Description";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // lbDescriptions
            // 
            this.lbDescriptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDescriptions.FormattingEnabled = true;
            this.lbDescriptions.ItemHeight = 15;
            this.lbDescriptions.Location = new System.Drawing.Point(401, 125);
            this.lbDescriptions.Name = "lbDescriptions";
            this.lbDescriptions.ScrollAlwaysVisible = true;
            this.lbDescriptions.Size = new System.Drawing.Size(123, 229);
            this.lbDescriptions.TabIndex = 3;
            this.lbDescriptions.DoubleClick += new System.EventHandler(this.lbDescriptions_DoubleClick);
            // 
            // rbAll
            // 
            this.rbAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(313, 170);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(39, 19);
            this.rbAll.TabIndex = 4;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // rbActive
            // 
            this.rbActive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(312, 225);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(58, 19);
            this.rbActive.TabIndex = 5;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Active";
            this.rbActive.UseVisualStyleBackColor = true;
            this.rbActive.CheckedChanged += new System.EventHandler(this.rbActive_CheckedChanged);
            // 
            // rbDisabled
            // 
            this.rbDisabled.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbDisabled.AutoSize = true;
            this.rbDisabled.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbDisabled.Location = new System.Drawing.Point(313, 275);
            this.rbDisabled.Name = "rbDisabled";
            this.rbDisabled.Size = new System.Drawing.Size(70, 17);
            this.rbDisabled.TabIndex = 6;
            this.rbDisabled.TabStop = true;
            this.rbDisabled.Text = "Disabled";
            this.rbDisabled.UseVisualStyleBackColor = true;
            this.rbDisabled.CheckedChanged += new System.EventHandler(this.rbDisabled_CheckedChanged);
            // 
            // tbReadyDescription
            // 
            this.tbReadyDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbReadyDescription.Location = new System.Drawing.Point(625, 125);
            this.tbReadyDescription.Multiline = true;
            this.tbReadyDescription.Name = "tbReadyDescription";
            this.tbReadyDescription.ReadOnly = true;
            this.tbReadyDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbReadyDescription.Size = new System.Drawing.Size(186, 219);
            this.tbReadyDescription.TabIndex = 7;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.ForeColor = System.Drawing.Color.Black;
            this.lblDescription.Location = new System.Drawing.Point(68, 115);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(233, 17);
            this.lblDescription.TabIndex = 71;
            this.lblDescription.Text = "Enter your new description below:";
            // 
            // lblDescriptionsByDate
            // 
            this.lblDescriptionsByDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescriptionsByDate.AutoSize = true;
            this.lblDescriptionsByDate.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescriptionsByDate.ForeColor = System.Drawing.Color.Black;
            this.lblDescriptionsByDate.Location = new System.Drawing.Point(359, 105);
            this.lblDescriptionsByDate.Name = "lblDescriptionsByDate";
            this.lblDescriptionsByDate.Size = new System.Drawing.Size(209, 17);
            this.lblDescriptionsByDate.TabIndex = 72;
            this.lblDescriptionsByDate.Text = "Select a description by its date:";
            // 
            // lblCurrDescription
            // 
            this.lblCurrDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrDescription.AutoSize = true;
            this.lblCurrDescription.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrDescription.ForeColor = System.Drawing.Color.Black;
            this.lblCurrDescription.Location = new System.Drawing.Point(625, 91);
            this.lblCurrDescription.Name = "lblCurrDescription";
            this.lblCurrDescription.Size = new System.Drawing.Size(86, 17);
            this.lblCurrDescription.TabIndex = 73;
            this.lblCurrDescription.Text = "Description:";
            // 
            // Description
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 479);
            this.Controls.Add(this.lblCurrDescription);
            this.Controls.Add(this.lblDescriptionsByDate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.tbReadyDescription);
            this.Controls.Add(this.rbDisabled);
            this.Controls.Add(this.rbActive);
            this.Controls.Add(this.rbAll);
            this.Controls.Add(this.lbDescriptions);
            this.Controls.Add(this.btnDisable);
            this.Controls.Add(this.btnAddDescription);
            this.Controls.Add(this.tbDescription);
            this.Name = "Description";
            this.Text = "Description";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbDescription;
        private Button btnAddDescription;
        private Button btnDisable;
        private ListBox lbDescriptions;
        private RadioButton rbAll;
        private RadioButton rbActive;
        private RadioButton rbDisabled;
        private TextBox tbReadyDescription;
        private Label lblDescription;
        private Label lblDescriptionsByDate;
        private Label lblCurrDescription;
    }
}