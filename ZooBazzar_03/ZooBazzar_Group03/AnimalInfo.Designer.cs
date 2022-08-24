namespace ZooBazzar_Group03
{
    partial class AnimalInfo
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblCageNumber = new System.Windows.Forms.Label();
            this.lblAnimalCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDiet = new System.Windows.Forms.Label();
            this.lblAnimalType = new System.Windows.Forms.Label();
            this.lblSpecie = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbCageNumber = new System.Windows.Forms.TextBox();
            this.tbAnimalCode = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSpecie = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblReasonForArrival = new System.Windows.Forms.Label();
            this.lblYearOfArrival = new System.Windows.Forms.Label();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.tbReasonForArrival = new System.Windows.Forms.TextBox();
            this.tbYearOfArrival = new System.Windows.Forms.TextBox();
            this.tbBirthdate = new System.Windows.Forms.TextBox();
            this.cbAnimalType = new System.Windows.Forms.ComboBox();
            this.cbDiet = new System.Windows.Forms.ComboBox();
            this.btnShowNotes = new System.Windows.Forms.Button();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(99, 54);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 20);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // lblCageNumber
            // 
            this.lblCageNumber.AutoSize = true;
            this.lblCageNumber.Location = new System.Drawing.Point(34, 113);
            this.lblCageNumber.Name = "lblCageNumber";
            this.lblCageNumber.Size = new System.Drawing.Size(101, 20);
            this.lblCageNumber.TabIndex = 1;
            this.lblCageNumber.Text = "Cage number:";
            // 
            // lblAnimalCode
            // 
            this.lblAnimalCode.AutoSize = true;
            this.lblAnimalCode.Location = new System.Drawing.Point(39, 165);
            this.lblAnimalCode.Name = "lblAnimalCode";
            this.lblAnimalCode.Size = new System.Drawing.Size(96, 20);
            this.lblAnimalCode.TabIndex = 2;
            this.lblAnimalCode.Text = "Animal code:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(74, 223);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // lblDiet
            // 
            this.lblDiet.AutoSize = true;
            this.lblDiet.Location = new System.Drawing.Point(86, 277);
            this.lblDiet.Name = "lblDiet";
            this.lblDiet.Size = new System.Drawing.Size(40, 20);
            this.lblDiet.TabIndex = 4;
            this.lblDiet.Text = "Diet:";
            // 
            // lblAnimalType
            // 
            this.lblAnimalType.AutoSize = true;
            this.lblAnimalType.Location = new System.Drawing.Point(34, 323);
            this.lblAnimalType.Name = "lblAnimalType";
            this.lblAnimalType.Size = new System.Drawing.Size(92, 20);
            this.lblAnimalType.TabIndex = 5;
            this.lblAnimalType.Text = "Animal type:";
            // 
            // lblSpecie
            // 
            this.lblSpecie.AutoSize = true;
            this.lblSpecie.Location = new System.Drawing.Point(419, 47);
            this.lblSpecie.Name = "lblSpecie";
            this.lblSpecie.Size = new System.Drawing.Size(56, 20);
            this.lblSpecie.TabIndex = 6;
            this.lblSpecie.Text = "Specie:";
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(158, 54);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(125, 27);
            this.tbID.TabIndex = 7;
            // 
            // tbCageNumber
            // 
            this.tbCageNumber.Location = new System.Drawing.Point(158, 113);
            this.tbCageNumber.Name = "tbCageNumber";
            this.tbCageNumber.Size = new System.Drawing.Size(125, 27);
            this.tbCageNumber.TabIndex = 8;
            // 
            // tbAnimalCode
            // 
            this.tbAnimalCode.Location = new System.Drawing.Point(158, 165);
            this.tbAnimalCode.Name = "tbAnimalCode";
            this.tbAnimalCode.Size = new System.Drawing.Size(125, 27);
            this.tbAnimalCode.TabIndex = 9;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(158, 216);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(125, 27);
            this.tbName.TabIndex = 10;
            // 
            // tbSpecie
            // 
            this.tbSpecie.Location = new System.Drawing.Point(499, 51);
            this.tbSpecie.Name = "tbSpecie";
            this.tbSpecie.Size = new System.Drawing.Size(125, 27);
            this.tbSpecie.TabIndex = 13;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(122, 408);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(413, 63);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit animal details";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblReasonForArrival
            // 
            this.lblReasonForArrival.AutoSize = true;
            this.lblReasonForArrival.Location = new System.Drawing.Point(347, 105);
            this.lblReasonForArrival.Name = "lblReasonForArrival";
            this.lblReasonForArrival.Size = new System.Drawing.Size(128, 20);
            this.lblReasonForArrival.TabIndex = 16;
            this.lblReasonForArrival.Text = "Reason for arrival:";
            // 
            // lblYearOfArrival
            // 
            this.lblYearOfArrival.AutoSize = true;
            this.lblYearOfArrival.Location = new System.Drawing.Point(368, 165);
            this.lblYearOfArrival.Name = "lblYearOfArrival";
            this.lblYearOfArrival.Size = new System.Drawing.Size(103, 20);
            this.lblYearOfArrival.TabIndex = 18;
            this.lblYearOfArrival.Text = "Year of arrival:";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(398, 218);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(73, 20);
            this.lblBirthdate.TabIndex = 20;
            this.lblBirthdate.Text = "Birthdate:";
            // 
            // tbReasonForArrival
            // 
            this.tbReasonForArrival.Location = new System.Drawing.Point(499, 106);
            this.tbReasonForArrival.Name = "tbReasonForArrival";
            this.tbReasonForArrival.Size = new System.Drawing.Size(125, 27);
            this.tbReasonForArrival.TabIndex = 21;
            // 
            // tbYearOfArrival
            // 
            this.tbYearOfArrival.Location = new System.Drawing.Point(499, 165);
            this.tbYearOfArrival.Name = "tbYearOfArrival";
            this.tbYearOfArrival.Size = new System.Drawing.Size(125, 27);
            this.tbYearOfArrival.TabIndex = 23;
            // 
            // tbBirthdate
            // 
            this.tbBirthdate.Location = new System.Drawing.Point(499, 216);
            this.tbBirthdate.Name = "tbBirthdate";
            this.tbBirthdate.Size = new System.Drawing.Size(125, 27);
            this.tbBirthdate.TabIndex = 25;
            // 
            // cbAnimalType
            // 
            this.cbAnimalType.FormattingEnabled = true;
            this.cbAnimalType.Location = new System.Drawing.Point(158, 319);
            this.cbAnimalType.Name = "cbAnimalType";
            this.cbAnimalType.Size = new System.Drawing.Size(125, 28);
            this.cbAnimalType.TabIndex = 28;
            // 
            // cbDiet
            // 
            this.cbDiet.FormattingEnabled = true;
            this.cbDiet.Location = new System.Drawing.Point(158, 270);
            this.cbDiet.Name = "cbDiet";
            this.cbDiet.Size = new System.Drawing.Size(125, 28);
            this.cbDiet.TabIndex = 29;
            // 
            // btnShowNotes
            // 
            this.btnShowNotes.Location = new System.Drawing.Point(398, 270);
            this.btnShowNotes.Name = "btnShowNotes";
            this.btnShowNotes.Size = new System.Drawing.Size(226, 57);
            this.btnShowNotes.TabIndex = 30;
            this.btnShowNotes.Text = "Show notes";
            this.btnShowNotes.UseVisualStyleBackColor = true;
            this.btnShowNotes.Click += new System.EventHandler(this.btnShowNotes_Click);
            // 
            // btnAddNote
            // 
            this.btnAddNote.Location = new System.Drawing.Point(398, 333);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(226, 57);
            this.btnAddNote.TabIndex = 31;
            this.btnAddNote.Text = "Add note";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // AnimalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZooBazzar_Group03.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(671, 496);
            this.Controls.Add(this.btnAddNote);
            this.Controls.Add(this.btnShowNotes);
            this.Controls.Add(this.cbDiet);
            this.Controls.Add(this.cbAnimalType);
            this.Controls.Add(this.tbBirthdate);
            this.Controls.Add(this.tbYearOfArrival);
            this.Controls.Add(this.tbReasonForArrival);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.lblYearOfArrival);
            this.Controls.Add(this.lblReasonForArrival);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tbSpecie);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbAnimalCode);
            this.Controls.Add(this.tbCageNumber);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lblSpecie);
            this.Controls.Add(this.lblAnimalType);
            this.Controls.Add(this.lblDiet);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAnimalCode);
            this.Controls.Add(this.lblCageNumber);
            this.Controls.Add(this.lblID);
            this.DoubleBuffered = true;
            this.Name = "AnimalInfo";
            this.Text = "a";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnimalInfo_FormClosing);
            this.Load += new System.EventHandler(this.AnimalInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblID;
        private Label lblCageNumber;
        private Label lblAnimalCode;
        private Label lblName;
        private Label lblDiet;
        private Label lblAnimalType;
        private Label lblSpecie;
        private TextBox tbID;
        private TextBox tbCageNumber;
        private TextBox tbAnimalCode;
        private TextBox tbName;
        private TextBox tbSpecie;
        private Button btnEdit;
        private Label lblReasonForArrival;
        private Label lblYearOfArrival;
        private Label lblBirthdate;
        private TextBox tbReasonForArrival;
        private TextBox tbYearOfArrival;
        private TextBox tbBirthdate;
        private ComboBox cbAnimalType;
        private ComboBox cbDiet;
        private Button btnShowNotes;
        private Button btnAddNote;
    }
}