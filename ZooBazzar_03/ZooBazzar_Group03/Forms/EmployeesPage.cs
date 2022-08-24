using Entities;
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
    public partial class EmployeesPage : Form
    {
        private List<Employee> employees;
        private List<EmployeeContract> contracts;
        private Employee tempEmployee;
        private Form activeForm;

        public EmployeesPage(List<Employee> employees, List<EmployeeContract> contracts)
        {
            InitializeComponent();

            this.employees = employees;
            this.contracts = contracts;
            this.updateUXemployee(employees);
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            openChildForm(new AddAccount(this.pContent), sender);
        }

                    

        private void updateUXemployee(IList<Employee> employees)
        {
            lbEmployees.Items.Clear();
            foreach (Employee employee in employees)
            {
                lbEmployees.Items.Add(employee);
            }
        }

       

        private void lbEmployees_DoubleClick(object sender, EventArgs e)
        {
            //Why ? :D
            Employee employee = (Employee)lbEmployees.SelectedItem;
        
            foreach (EmployeeContract ec in contracts.FindAll(c => c.Id ==  employee.Id))
            {
                MessageBox.Show(ec.ToString());
            }
        }

        private void lbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if(lbEmployees.SelectedIndex >= 0)
            {
              openChildForm(new UpdateEmployee(lbEmployees.SelectedIndex), sender);
            }
        }
    }
}
