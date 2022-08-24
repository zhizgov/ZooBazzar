using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace ZooBazzar_Group03.Forms
{
    public partial class ShowComplaint : Form
    {
        private Complaint complaint;
        public ShowComplaint(Panel panel, Complaint complaint)
        {
            InitializeComponent();
            this.complaint = complaint;
        }

        private void ShowComplaint_Load(object sender, EventArgs e)
        {
            tbTitle.Text = complaint.Title;
            tbComplaint.Text = complaint.Description;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
