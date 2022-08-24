namespace ZooBazzar_Group03
{
    partial class fmDeleteAnimal
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.tbReasonForDeparture = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(9, 178);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(196, 46);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Myanmar Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(9, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(241, 36);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Please specify a reason!";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Myanmar Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblQuestion.Location = new System.Drawing.Point(-5, 1);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(440, 36);
            this.lblQuestion.TabIndex = 6;
            this.lblQuestion.Text = "Are you sure you want to delete this animal?";
            // 
            // tbReasonForDeparture
            // 
            this.tbReasonForDeparture.Location = new System.Drawing.Point(9, 97);
            this.tbReasonForDeparture.Multiline = true;
            this.tbReasonForDeparture.Name = "tbReasonForDeparture";
            this.tbReasonForDeparture.Size = new System.Drawing.Size(196, 63);
            this.tbReasonForDeparture.TabIndex = 5;
            // 
            // fmDeleteAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZooBazzar_Group03.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(430, 236);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.tbReasonForDeparture);
            this.DoubleBuffered = true;
            this.Name = "fmDeleteAnimal";
            this.Text = "fmDeleteAnimal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmDeleteAnimal_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRemove;
        private Label lblTitle;
        private Label lblQuestion;
        private TextBox tbReasonForDeparture;
    }
}