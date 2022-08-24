using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ZooBazzar_Group03;

namespace Entities
{
    public partial class ucDate : UserControl
    {
        public ucDate()
        {
            InitializeComponent();
        }

        private string currentDate;
        private void Date_Load(object sender, EventArgs e)
        {
            
        }

        public void GetDate(string date)
        {
            lblDate.Text = date;
            
            this.currentDate = date;
        }

        private void Date_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule(currentDate);
            schedule.ShowDialog();
        }
    }
}
