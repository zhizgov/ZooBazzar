namespace ZooBazzar_Group03.Forms
{
    partial class AnimalsPage
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
            this.cbAnimalType = new System.Windows.Forms.ComboBox();
            this.btnFilterByType = new System.Windows.Forms.Button();
            this.btnAnimalName = new System.Windows.Forms.Button();
            this.tbAnimalName = new System.Windows.Forms.TextBox();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.btnShowAllAnimals = new System.Windows.Forms.Button();
            this.flpAnimals = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // cbAnimalType
            // 
            this.cbAnimalType.BackColor = System.Drawing.Color.Ivory;
            this.cbAnimalType.FormattingEnabled = true;
            this.cbAnimalType.Location = new System.Drawing.Point(49, 171);
            this.cbAnimalType.Name = "cbAnimalType";
            this.cbAnimalType.Size = new System.Drawing.Size(161, 28);
            this.cbAnimalType.TabIndex = 17;
            // 
            // btnFilterByType
            // 
            this.btnFilterByType.BackColor = System.Drawing.Color.SeaGreen;
            this.btnFilterByType.Font = new System.Drawing.Font("Footlight MT Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFilterByType.ForeColor = System.Drawing.Color.Ivory;
            this.btnFilterByType.Location = new System.Drawing.Point(216, 169);
            this.btnFilterByType.Name = "btnFilterByType";
            this.btnFilterByType.Size = new System.Drawing.Size(161, 29);
            this.btnFilterByType.TabIndex = 16;
            this.btnFilterByType.Text = "By type";
            this.btnFilterByType.UseVisualStyleBackColor = false;
            this.btnFilterByType.Click += new System.EventHandler(this.btnFilterByType_Click);
            // 
            // btnAnimalName
            // 
            this.btnAnimalName.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAnimalName.Font = new System.Drawing.Font("Footlight MT Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnimalName.ForeColor = System.Drawing.Color.Ivory;
            this.btnAnimalName.Location = new System.Drawing.Point(216, 117);
            this.btnAnimalName.Name = "btnAnimalName";
            this.btnAnimalName.Size = new System.Drawing.Size(161, 29);
            this.btnAnimalName.TabIndex = 14;
            this.btnAnimalName.Text = "Search by name";
            this.btnAnimalName.UseVisualStyleBackColor = false;
            this.btnAnimalName.Click += new System.EventHandler(this.btnAnimalName_Click);
            // 
            // tbAnimalName
            // 
            this.tbAnimalName.BackColor = System.Drawing.Color.Ivory;
            this.tbAnimalName.Location = new System.Drawing.Point(49, 120);
            this.tbAnimalName.Name = "tbAnimalName";
            this.tbAnimalName.Size = new System.Drawing.Size(161, 27);
            this.tbAnimalName.TabIndex = 13;
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddAnimal.Font = new System.Drawing.Font("Footlight MT Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddAnimal.ForeColor = System.Drawing.Color.Ivory;
            this.btnAddAnimal.Location = new System.Drawing.Point(49, 320);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(328, 29);
            this.btnAddAnimal.TabIndex = 12;
            this.btnAddAnimal.Text = "Add an animal";
            this.btnAddAnimal.UseVisualStyleBackColor = false;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // btnShowAllAnimals
            // 
            this.btnShowAllAnimals.BackColor = System.Drawing.Color.SeaGreen;
            this.btnShowAllAnimals.Font = new System.Drawing.Font("Footlight MT Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShowAllAnimals.ForeColor = System.Drawing.Color.Ivory;
            this.btnShowAllAnimals.Location = new System.Drawing.Point(49, 285);
            this.btnShowAllAnimals.Name = "btnShowAllAnimals";
            this.btnShowAllAnimals.Size = new System.Drawing.Size(328, 29);
            this.btnShowAllAnimals.TabIndex = 11;
            this.btnShowAllAnimals.Text = "Show all animals";
            this.btnShowAllAnimals.UseVisualStyleBackColor = false;
            this.btnShowAllAnimals.Click += new System.EventHandler(this.btnShowAllAnimals_Click);
            // 
            // flpAnimals
            // 
            this.flpAnimals.AutoScroll = true;
            this.flpAnimals.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpAnimals.Location = new System.Drawing.Point(495, 0);
            this.flpAnimals.Name = "flpAnimals";
            this.flpAnimals.Size = new System.Drawing.Size(485, 571);
            this.flpAnimals.TabIndex = 18;
            // 
            // AnimalsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 571);
            this.Controls.Add(this.flpAnimals);
            this.Controls.Add(this.cbAnimalType);
            this.Controls.Add(this.btnFilterByType);
            this.Controls.Add(this.btnAnimalName);
            this.Controls.Add(this.tbAnimalName);
            this.Controls.Add(this.btnAddAnimal);
            this.Controls.Add(this.btnShowAllAnimals);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnimalsPage";
            this.Text = "Animals";
            this.Load += new System.EventHandler(this.AnimalsPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbAnimalType;
        private Button btnFilterByType;
        private Button btnAnimalName;
        private TextBox tbAnimalName;
        private Button btnAddAnimal;
        private Button btnShowAllAnimals;
        private FlowLayoutPanel flpAnimals;
    }
}