using DataAccessLayer;
using LogicLayer;
using Entities;

namespace ZooBazzar_Group03.Forms
{
    public partial class AddContract : Form
    {
        private ContractManager contractManager = new ContractManager(new ContractDB());
        private Employee employee;
        public AddContract(Employee employee)
        {
            InitializeComponent();

            this.employee = employee;
        }

        private void btnCreateContract_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                EmployeeContract employeeContract = new EmployeeContract(employee.Id, dtpStartDate.Value, dtpEndDate.Value, Convert.ToDouble(tbFte.Text), tbReason.Text, true);
                contractManager.AddContract(employeeContract, employee);
                MessageBox.Show("Successful creation of Contract!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
