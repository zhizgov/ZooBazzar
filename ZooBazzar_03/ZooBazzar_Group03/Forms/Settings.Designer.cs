namespace ZooBazzar_Group03.Forms
{
    partial class Settings
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
            this.btnSavePassword = new System.Windows.Forms.Button();
            this.tbPasswordSettings = new System.Windows.Forms.TextBox();
            this.tbUsernameSettings = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSavePassword
            // 
            this.btnSavePassword.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSavePassword.Location = new System.Drawing.Point(309, 306);
            this.btnSavePassword.Name = "btnSavePassword";
            this.btnSavePassword.Size = new System.Drawing.Size(312, 48);
            this.btnSavePassword.TabIndex = 10;
            this.btnSavePassword.Text = "Save";
            this.btnSavePassword.UseVisualStyleBackColor = false;
            this.btnSavePassword.Click += new System.EventHandler(this.btnSavePassword_Click);
            // 
            // tbPasswordSettings
            // 
            this.tbPasswordSettings.Location = new System.Drawing.Point(309, 248);
            this.tbPasswordSettings.Name = "tbPasswordSettings";
            this.tbPasswordSettings.Size = new System.Drawing.Size(311, 27);
            this.tbPasswordSettings.TabIndex = 9;
            // 
            // tbUsernameSettings
            // 
            this.tbUsernameSettings.Location = new System.Drawing.Point(309, 162);
            this.tbUsernameSettings.Name = "tbUsernameSettings";
            this.tbUsernameSettings.ReadOnly = true;
            this.tbUsernameSettings.Size = new System.Drawing.Size(311, 27);
            this.tbUsernameSettings.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "username:";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 477);
            this.Controls.Add(this.btnSavePassword);
            this.Controls.Add(this.tbPasswordSettings);
            this.Controls.Add(this.tbUsernameSettings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSavePassword;
        private TextBox tbPasswordSettings;
        private TextBox tbUsernameSettings;
        private Label label2;
        private Label label1;
    }
}