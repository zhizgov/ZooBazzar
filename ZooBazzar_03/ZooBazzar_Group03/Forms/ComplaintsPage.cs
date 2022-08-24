using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;
using DataAccessLayer;
using Entities;

namespace ZooBazzar_Group03.Forms
{
    public partial class ComplaintsPage : Form
    {

        private ComplaintsManager complaintsManager = new ComplaintsManager(new ComplaintsDB());
        private Form activeForm;
        public ComplaintsPage()
        {
            InitializeComponent();
        }

        private void btnComplaints_Click(object sender, EventArgs e)
        {
            lblComplaints.DataSource = complaintsManager.Complaints;
        }

        private void lblComplaints_DoubleClick(object sender, EventArgs e)
        {
            Complaint complaint = (Complaint)lblComplaints.SelectedItem;
            openChildForm(new ShowComplaint(this.pContent, complaint), sender);
        }

        private void openChildForm(Form form, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }


            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.pContent.Controls.Add(form);
            this.pContent.Tag = form;
            form.BringToFront();
            form.Show();

        }

        private void LoadTheame()
        {

            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ColorThemeHandler.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ColorThemeHandler.SecondaryColor;
                }
                else if (btns.GetType() == typeof(Label))
                {
                    btns.BackColor = ColorThemeHandler.PrimaryColor;
                    btns.ForeColor = Color.White;
                }

            }

        }

        private void ComplaintsPage_Load(object sender, EventArgs e)
        {
            LoadTheame();
        }
    }
}
