namespace ZooBazzar_Group03
{
    partial class TicketForm
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
            this.lbTickets = new System.Windows.Forms.ListBox();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblTickets = new System.Windows.Forms.Label();
            this.btnCheckTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTickets
            // 
            this.lbTickets.FormattingEnabled = true;
            this.lbTickets.ItemHeight = 15;
            this.lbTickets.Location = new System.Drawing.Point(354, 56);
            this.lbTickets.Name = "lbTickets";
            this.lbTickets.Size = new System.Drawing.Size(386, 349);
            this.lbTickets.TabIndex = 0;
            // 
            // tbBarcode
            // 
            this.tbBarcode.Location = new System.Drawing.Point(96, 56);
            this.tbBarcode.Multiline = true;
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(139, 33);
            this.tbBarcode.TabIndex = 1;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBarcode.Location = new System.Drawing.Point(12, 59);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(67, 20);
            this.lblBarcode.TabIndex = 2;
            this.lblBarcode.Text = "Barcode:";
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTickets.Location = new System.Drawing.Point(354, 33);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(57, 20);
            this.lblTickets.TabIndex = 3;
            this.lblTickets.Text = "Tickets:";
            // 
            // btnCheckTicket
            // 
            this.btnCheckTicket.Location = new System.Drawing.Point(113, 146);
            this.btnCheckTicket.Name = "btnCheckTicket";
            this.btnCheckTicket.Size = new System.Drawing.Size(103, 38);
            this.btnCheckTicket.TabIndex = 4;
            this.btnCheckTicket.Text = "Check Ticket";
            this.btnCheckTicket.UseVisualStyleBackColor = true;
            this.btnCheckTicket.Click += new System.EventHandler(this.btnCheckTicket_Click);
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheckTicket);
            this.Controls.Add(this.lblTickets);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.tbBarcode);
            this.Controls.Add(this.lbTickets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketForm";
            this.Text = "TicketForm";
            this.Load += new System.EventHandler(this.TicketForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbTickets;
        private TextBox tbBarcode;
        private Label lblBarcode;
        private Label lblTickets;
        private Button btnCheckTicket;
    }
}