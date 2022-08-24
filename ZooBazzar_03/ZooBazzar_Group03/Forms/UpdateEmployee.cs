using DataAccessLayer;
using Entities;
using LogicLayer;

namespace ZooBazzar_Group03.Forms
{
    public partial class UpdateEmployee : Form
    {
        //Fields
        private Employee employee;
        private EmployeeManagment managment = new EmployeeManagment(new EmployeeDB());

        //Constructor
        public UpdateEmployee(int index)
        {
            InitializeComponent();

            cbSpecialization.DataSource = Enum.GetValues(typeof(Specialization));
            cbPosition.DataSource = new[] { "Caretaker", "Manager", "Resourceplanner","Salesman" };

            employee = managment.Employees[index];
            tbName.Text = employee.Name;
            tbLastname.Text = employee.Lastname;
            tbAddress.Text = employee.Address;
            tbEmail.Text = employee.Email;
            tbPhone.Text = employee.Phone;
            tbEmergencyCon.Text = employee.EmargencyContact;
            dtpDateOfBirth.Value = employee.Birthdate;
            tbBSN.Text = employee.Bsn;
            cbPosition.SelectedText = employee.WorkingPosition;           

            if (employee is Caretaker)
            {
                Caretaker caretaker = (Caretaker)employee;
                cbSpecialization.Text = caretaker.GetSpecialization().ToString();
                cbPosition.SelectedText = "Caretaker";
            }
        }

        //Events
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {

                if (cbPosition.SelectedItem.ToString() == "Caretaker")
                {
                    Specialization specialization = (Specialization)Enum.Parse(typeof(Specialization), cbSpecialization.SelectedItem.ToString());
                    employee = new Caretaker(employee.Account, tbName.Text, tbLastname.Text, tbAddress.Text, dtpDateOfBirth.Value, tbEmail.Text, tbPhone.Text, tbEmergencyCon.Text, tbBSN.Text, "Caretaker", specialization);
                }
                else
                {
                    employee = new Employee(employee.Account, tbName.Text, tbLastname.Text, tbAddress.Text, dtpDateOfBirth.Value, tbEmail.Text, tbPhone.Text, tbEmergencyCon.Text, tbBSN.Text, $"{cbPosition.Text}");

                }
                managment.UpdateEmployee(employee);

            }
            else
            {
                MessageBox.Show("You naughty nauhty you teasing meee, you naughty naughty!!!Enter all fields ;)");
            }
        }

        //Methods
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
