namespace ZooBazzar_Group03
{
    partial class AnimalPic
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
            this.lblName = new System.Windows.Forms.Label();
            this.pbAnimal = new System.Windows.Forms.PictureBox();
            this.btnRemoveAnimal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.PaleGreen;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblName.Location = new System.Drawing.Point(12, 113);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 23);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "name";
            // 
            // pbAnimal
            // 
            this.pbAnimal.BackgroundImage = global::ZooBazzar_Group03.Properties.Resources.NoImageAvailable;
            this.pbAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAnimal.Location = new System.Drawing.Point(12, 15);
            this.pbAnimal.Name = "pbAnimal";
            this.pbAnimal.Size = new System.Drawing.Size(126, 121);
            this.pbAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnimal.TabIndex = 2;
            this.pbAnimal.TabStop = false;
            this.pbAnimal.Click += new System.EventHandler(this.pbAnimal_Click);
            // 
            // btnRemoveAnimal
            // 
            this.btnRemoveAnimal.BackgroundImage = global::ZooBazzar_Group03.Properties.Resources.closeSign;
            this.btnRemoveAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveAnimal.Location = new System.Drawing.Point(114, 0);
            this.btnRemoveAnimal.Name = "btnRemoveAnimal";
            this.btnRemoveAnimal.Size = new System.Drawing.Size(36, 34);
            this.btnRemoveAnimal.TabIndex = 5;
            this.btnRemoveAnimal.UseVisualStyleBackColor = true;
            this.btnRemoveAnimal.Click += new System.EventHandler(this.btnRemoveAnimal_Click);
            // 
            // AnimalPic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.btnRemoveAnimal);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbAnimal);
            this.Name = "AnimalPic";
            this.Load += new System.EventHandler(this.AnimalPic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblName;
        private PictureBox pbAnimal;
        private Button btnRemoveAnimal;
    }
}
