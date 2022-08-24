using DataAccessLayer;
using Entities;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooBazzar_Group03.Forms
{
    public partial class Request : Form
    {
        private RequestManager requestManager = new RequestManager(new RequestedEmployeeDB());
        private List<Employee> employees = new List<Employee>();
        public Request()
        {
            InitializeComponent();
            updateUXrequest(lbEmployeesWithNewCredentials, requestManager.Read());
            LoadOldUser();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (lbEmployeesWithNewCredentials.SelectedIndex <= -1)
            {
                MessageBox.Show("Please, select the employee!");
                return;
            }
            else
            {
                RequestedEmployee re = (RequestedEmployee)lbEmployeesWithNewCredentials.SelectedItem;
                requestManager.ChangeCredentials(re);
                requestManager.Delete(re);
                MessageBox.Show("Employee's been changed!");
                lbEmployeesWithNewCredentials.Items.Remove(re);
                updateUXrequest(lbEmployeesWithNewCredentials, requestManager.Read());
                LoadOldUser();

                return;
            }
        }

        private void updateUXrequest(ListBox lb, List<RequestedEmployee> requests)
        {
            lb.Items.Clear();
            lb.DataSource = requests;
        }

        private void LoadOldUser()
        {
            lbEmployeesWithOldCredentials.Items.Clear();
            foreach (RequestedEmployee re in requestManager.Read())
            {
                List<Employee> emp = employees.FindAll(e => e.Id == re.Id);
                foreach (Employee employee in emp)
                {
                    lbEmployeesWithOldCredentials.Items.Add(emp);

                }
            }
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            if (lbEmployeesWithNewCredentials.SelectedIndex < 0)
            {
                MessageBox.Show("Please first select the request!");
                return;
            }

            RequestedEmployee re = (RequestedEmployee)lbEmployeesWithNewCredentials.SelectedItem;
            Employee employee = (Employee)lbEmployeesWithOldCredentials.SelectedItem;
            MessageBox.Show("Employee's not been changed!");
            requestManager.Delete(re);

            updateUXrequest(lbEmployeesWithNewCredentials, requestManager.Read());
            LoadOldUser();
        }
    }
}
