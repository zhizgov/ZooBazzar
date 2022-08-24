namespace ZooBazzar_Group03
{
    partial class Schedule
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
            this.lblTimeSloth = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbFirstCaretaker = new System.Windows.Forms.ComboBox();
            this.cmbTimeSloth = new System.Windows.Forms.ComboBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAnimalType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSecondCaretaker = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbHelperCaretaker = new System.Windows.Forms.ComboBox();
            this.lbCages = new System.Windows.Forms.ListBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTimeSloth
            // 
            this.lblTimeSloth.AutoSize = true;
            this.lblTimeSloth.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeSloth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimeSloth.Location = new System.Drawing.Point(19, 133);
            this.lblTimeSloth.Name = "lblTimeSloth";
            this.lblTimeSloth.Size = new System.Drawing.Size(95, 28);
            this.lblTimeSloth.TabIndex = 0;
            this.lblTimeSloth.Text = "Time slot:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(19, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 28);
            this.label7.TabIndex = 13;
            this.label7.Text = "First main caretaker: ";
            // 
            // cmbFirstCaretaker
            // 
            this.cmbFirstCaretaker.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cmbFirstCaretaker.FormattingEnabled = true;
            this.cmbFirstCaretaker.Location = new System.Drawing.Point(19, 241);
            this.cmbFirstCaretaker.Name = "cmbFirstCaretaker";
            this.cmbFirstCaretaker.Size = new System.Drawing.Size(275, 28);
            this.cmbFirstCaretaker.TabIndex = 12;
            // 
            // cmbTimeSloth
            // 
            this.cmbTimeSloth.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cmbTimeSloth.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.cmbTimeSloth.FormattingEnabled = true;
            this.cmbTimeSloth.Items.AddRange(new object[] {
            "6:00 - 8:00",
            "12:00 - 14:00",
            "20:00 - 22:00"});
            this.cmbTimeSloth.Location = new System.Drawing.Point(19, 168);
            this.cmbTimeSloth.Name = "cmbTimeSloth";
            this.cmbTimeSloth.Size = new System.Drawing.Size(275, 28);
            this.cmbTimeSloth.TabIndex = 17;
            this.cmbTimeSloth.SelectedIndexChanged += new System.EventHandler(this.cmbTimeSloth_SelectedIndexChanged);
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(358, 352);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(203, 57);
            this.btnAssign.TabIndex = 18;
            this.btnAssign.Text = "Assign employee";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Location = new System.Drawing.Point(596, 352);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(203, 57);
            this.btnEditEmployee.TabIndex = 21;
            this.btnEditEmployee.Text = "Edit employee";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "Type of animals: ";
            // 
            // cmbAnimalType
            // 
            this.cmbAnimalType.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cmbAnimalType.FormattingEnabled = true;
            this.cmbAnimalType.Items.AddRange(new object[] {
            "Mammal",
            "Bird",
            "Fish",
            "Reptile",
            "Insect",
            "Amphibian"});
            this.cmbAnimalType.Location = new System.Drawing.Point(19, 85);
            this.cmbAnimalType.Name = "cmbAnimalType";
            this.cmbAnimalType.Size = new System.Drawing.Size(275, 28);
            this.cmbAnimalType.TabIndex = 22;
            this.cmbAnimalType.SelectedIndexChanged += new System.EventHandler(this.cmbAnimalType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 28);
            this.label2.TabIndex = 25;
            this.label2.Text = "Second main caretaker:";
            // 
            // cmbSecondCaretaker
            // 
            this.cmbSecondCaretaker.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cmbSecondCaretaker.FormattingEnabled = true;
            this.cmbSecondCaretaker.Location = new System.Drawing.Point(19, 317);
            this.cmbSecondCaretaker.Name = "cmbSecondCaretaker";
            this.cmbSecondCaretaker.Size = new System.Drawing.Size(275, 28);
            this.cmbSecondCaretaker.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 28);
            this.label3.TabIndex = 27;
            this.label3.Text = "Helper caretaker:";
            // 
            // cmbHelperCaretaker
            // 
            this.cmbHelperCaretaker.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cmbHelperCaretaker.FormattingEnabled = true;
            this.cmbHelperCaretaker.Location = new System.Drawing.Point(19, 403);
            this.cmbHelperCaretaker.Name = "cmbHelperCaretaker";
            this.cmbHelperCaretaker.Size = new System.Drawing.Size(275, 28);
            this.cmbHelperCaretaker.TabIndex = 26;
            // 
            // lbCages
            // 
            this.lbCages.FormattingEnabled = true;
            this.lbCages.ItemHeight = 20;
            this.lbCages.Location = new System.Drawing.Point(358, 84);
            this.lbCages.Name = "lbCages";
            this.lbCages.Size = new System.Drawing.Size(450, 224);
            this.lbCages.TabIndex = 28;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblDate.Location = new System.Drawing.Point(360, 47);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(13, 20);
            this.lblDate.TabIndex = 29;
            this.lblDate.Text = "!";
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZooBazzar_Group03.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(865, 478);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lbCages);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbHelperCaretaker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSecondCaretaker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAnimalType);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.cmbTimeSloth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbFirstCaretaker);
            this.Controls.Add(this.lblTimeSloth);
            this.Name = "Schedule";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.Schedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTimeSloth;
        private Label label7;
        private ComboBox cmbTimeSloth;
        public ComboBox cmbFirstCaretaker;
        public Button btnAssign;
        public Button btnEditEmployee;
        private Label label1;
        public ComboBox cmbAnimalType;
        private Label label2;
        public ComboBox cmbSecondCaretaker;
        private Label label3;
        public ComboBox cmbHelperCaretaker;
        private ListBox lbCages;
        private Label lblDate;
    }
}