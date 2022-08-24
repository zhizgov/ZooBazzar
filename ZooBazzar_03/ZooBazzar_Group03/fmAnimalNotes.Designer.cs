namespace ZooBazzar_Group03
{
    partial class fmAnimalNotes
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
            this.flpNotes = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpNotes
            // 
            this.flpNotes.AutoScroll = true;
            this.flpNotes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpNotes.Location = new System.Drawing.Point(14, 22);
            this.flpNotes.Name = "flpNotes";
            this.flpNotes.Size = new System.Drawing.Size(614, 282);
            this.flpNotes.TabIndex = 0;
            // 
            // fmAnimalNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 338);
            this.Controls.Add(this.flpNotes);
            this.Name = "fmAnimalNotes";
            this.Text = "fmAnimalNotes";
            this.Load += new System.EventHandler(this.fmAnimalNotes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flpNotes;
    }
}