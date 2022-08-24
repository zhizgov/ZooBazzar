using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooBazzar_Group03.Properties;
using LogicLayer;
using Entities;

namespace ZooBazzar_Group03
{
    public partial class ucEmployee : UserControl
    {
        public ucEmployee(Employee employee)
        {
            InitializeComponent();           
            this.pbEmployee.Image = getImage(employee);
            this.lblName.Text = $"{employee.Name} {employee.Lastname}";
            this.lblSpecialization.Text = employee.WorkingPosition;
            this.lblEmail.Text = employee.Email;


        }

        private void pbEmployee_Click(object sender, EventArgs e)
        {

        }

        private Image getImage(Employee employee)
        {
            if (employee.WorkingPosition == "Caretaker")
            {
                return getImageCareTaker(((Caretaker)employee).GetSpecialization());
            }
            else if (employee.WorkingPosition == "ResourcePlanner")
            {
                return Resources.schedule;
            }
            else if(employee.WorkingPosition == "Manager")
            {
                return Resources.manager;
            }
            else
            {
                return Resources.salesman;
            }
        }

        private Image getImageCareTaker(Specialization specialization)
        {
            switch (specialization)
            {
                case Specialization.Mammalogist:
                    return Resources.monkey;
                    
                case Specialization.Ornithologist:
                    return Resources.bird;
                    
                case Specialization.Ichthyologist:
                    return Resources.fish;
                   
                case Specialization.Herprtologist:
                    return Resources.chamelion;

                case Specialization.Entomologist:
                    return Resources.butterfly;
                
            }

            return null;
        }

        private string getSpecialization(Employee employee)
        {
            if (employee is Caretaker caretaker)
            {

                return caretaker.GetSpecialization().ToString();
            }
            else if (employee.WorkingPosition == "ResourcePlanner")
            {
                return "Resource planner";
            }
            else
            {
                return "Manager";
            }
        }

        private void ucEmployee_Load(object sender, EventArgs e)
        {

        }

        
    }
}
