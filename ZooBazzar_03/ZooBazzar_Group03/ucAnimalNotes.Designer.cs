namespace ZooBazzar_Group03
{
    partial class ucAnimalNotes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbNote = new System.Windows.Forms.TextBox();
            this.btnDeleteNote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(15, 14);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.ReadOnly = true;
            this.tbNote.Size = new System.Drawing.Size(309, 104);
            this.tbNote.TabIndex = 0;
            // 
            // btnDeleteNote
            // 
            this.btnDeleteNote.Location = new System.Drawing.Point(15, 143);
            this.btnDeleteNote.Name = "btnDeleteNote";
            this.btnDeleteNote.Size = new System.Drawing.Size(94, 29);
            this.btnDeleteNote.TabIndex = 1;
            this.btnDeleteNote.Text = "Remove";
            this.btnDeleteNote.UseVisualStyleBackColor = true;
            this.btnDeleteNote.Click += new System.EventHandler(this.btnDeleteNote_Click);
            // 
            // ucAnimalNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.btnDeleteNote);
            this.Controls.Add(this.tbNote);
            this.Name = "ucAnimalNotes";
            this.Size = new System.Drawing.Size(343, 196);
            this.Load += new System.EventHandler(this.ucAnimalNotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbNote;
        private Button btnDeleteNote;
    }
}
