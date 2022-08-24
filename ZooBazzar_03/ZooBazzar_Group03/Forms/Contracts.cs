using DataAccessLayer;
using Entities;
using LogicLayer;


namespace ZooBazzar_Group03.Forms
{
    public partial class Contracts : Form
    {
        private List<Employee> employees;
        private ContractManager cm;
        public Contracts(List<Employee> employees)
        {
            InitializeComponent();

            this.employees = employees;
            this.cm = new ContractManager(new ContractDB());
            this.cbEmployee.DataSource = employees;
            this.lbContracts.DataSource = cm.GetContracts();
        }

        private void btnCreateContract_Click(object sender, EventArgs e)
        {
            //Nqma da raboti tuk! trqbva druga proverka
            Employee employee = employees.FirstOrDefault(e => e.Name + " " + e.Id == cbEmployee.SelectedItem.ToString());
            EmployeeContract ec = new EmployeeContract(employee.Id, dtpStartDate.Value, dtpEndDate.Value, Convert.ToDouble(tbFte.Text), tbReason.Text, true);
            cm.AddContract(ec, employee);
        }

        private void btnDisableContract_Click(object sender, EventArgs e)
        {
            if (lbContracts.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a contract");
                return;
            }

            EmployeeContract ec = (EmployeeContract)lbContracts.SelectedItem;

            cm.DisableContract(ec);
            MessageBox.Show($"Successful disabling the conract with id : {ec.Id}");
        }

        private void lbContracts_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lbContracts_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show($"{(EmployeeContract)lbContracts.SelectedItem}");
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

        private void Contracts_Load(object sender, EventArgs e)
        {
            LoadTheame();
        }
    }
}
