namespace ZooBazzar_Group03
{
    partial class fmAddNote
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
            this.tbNote = new System.Windows.Forms.TextBox();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(12, 12);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(275, 137);
            this.tbNote.TabIndex = 0;
            // 
            // btnAddNote
            // 
            this.btnAddNote.Location = new System.Drawing.Point(12, 171);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(94, 29);
            this.btnAddNote.TabIndex = 1;
            this.btnAddNote.Text = "Add";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // fmAddNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 221);
            this.Controls.Add(this.btnAddNote);
            this.Controls.Add(this.tbNote);
            this.Name = "fmAddNote";
            this.Text = "fmAddNote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbNote;
        private Button btnAddNote;
    }
}