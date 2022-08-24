using Entities;
using LogicLayer;
using ZooBazzar_Group03;

namespace ZooBazzar_Group03.Forms
{
    public partial class HomePage : Form
    {
        private List<Employee> employees;
        public HomePage(List<Employee> employees)
        {
            InitializeComponent();

            this.employees = employees;
            cbWorkPosition.DataSource = Enum.GetValues(typeof(Specialization));
            updateUX(employees);
        }

        private void updateUX(List<Employee> employees)
        {
            if (employees != null)
            {
                flpEmployees.Controls.Clear();
                foreach (Employee emp in employees)
                {
                    flpEmployees.Controls.Add(new ucEmployee(emp));
                }

            }
        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            updateUX(employees);
        }

        private void btnWorkPosition_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbWorkPosition.SelectedText))
                updateUX(employees.FindAll(e => e.WorkingPosition == cbWorkPosition.SelectedText));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSearch.Text))
                updateUX(employees.FindAll(e => e.Name.Contains(tbSearch.Text) || e.Lastname.Contains(tbSearch.Text)));
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            LoadTheame();
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
    }
}
