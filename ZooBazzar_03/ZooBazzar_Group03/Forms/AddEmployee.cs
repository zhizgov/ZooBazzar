using Entities;
using LogicLayer;
using DataAccessLayer;

namespace ZooBazzar_Group03.Forms
{
    public partial class AddEmployee : Form
    {
        private Account account;
        private EmployeeManagment managment = new EmployeeManagment(new EmployeeDB());
        private Employee employee;
        private Panel panel;

        public AddEmployee(Account account, Panel panel)
        {
            InitializeComponent();

            this.panel = panel;
            this.account = account;
            this.cbPosition.DataSource = new string[] {"Caretaker","Manager","ResourcePlanner","Salesman"};
            this.cbSpecialization.DataSource = Enum.GetValues(typeof(Specialization));
            this.cbSpecialization.Visible = false;
        }
        
        private bool checkInput()
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {

                if (this.Controls[i] is TextBox)
                {
                    if (!DataValidation.CheckTextBox((TextBox)this.Controls[i]))
                    {
                        return false;
                    }

                }
                else if (this.Controls[i] is DateTimePicker)
                {
                    if (DataValidation.CheckFutureDate((DateTimePicker)this.Controls[i]))
                    {
                        return false;
                    }

                }


            }
            return true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                if (cbPosition.SelectedItem.ToString() == "Caretaker")
                {
                    Specialization specialization = (Specialization)Enum.Parse(typeof(Specialization), cbSpecialization.SelectedItem.ToString());
                    employee = new Caretaker(account, tbName.Text, tbLastname.Text, tbAddress.Text, dtpDateOfBirth.Value, tbEmail.Text, tbPhone.Text, tbEmergencyCon.Text, tbBSN.Text, "Caretaker", specialization);
                }
                else
                {
                    employee = new Employee(account, tbName.Text, tbLastname.Text, tbAddress.Text, dtpDateOfBirth.Value, tbEmail.Text, tbPhone.Text, tbEmergencyCon.Text, tbBSN.Text, $"{cbPosition.Text}");

                }
                

                managment.AddEmployee(employee);
                AddContract contractForm = new AddContract(managment.Employees.First(e => e.Name == employee.Name && e.Birthdate == employee.Birthdate ));
                contractForm.TopLevel = false;
                contractForm.FormBorderStyle = FormBorderStyle.None;
                contractForm.Dock = DockStyle.Fill;
                panel.Controls.Clear();
                panel.Controls.Add(contractForm);
                panel.Tag = contractForm;
                contractForm.BringToFront();
                contractForm.Show();
               

                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbPosition.Text == "Caretaker")
            {
                cbSpecialization.Visible = true;
            }
            else
            {
                cbSpecialization.Visible = false;
            }
        }
    }
}
