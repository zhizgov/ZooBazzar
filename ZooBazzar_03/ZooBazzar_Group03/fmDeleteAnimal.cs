using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;
using Entities;
using DataAccessLayer;

namespace ZooBazzar_Group03
{
    public partial class fmDeleteAnimal : Form
    {
        Animal animal;
        AnimalManager manager;
        MainManu menu;

        // Need of improvment 
        public fmDeleteAnimal(Animal animal, AnimalManager manager)
        {
            InitializeComponent();
            this.animal = animal;
            this.manager = manager;
            this.menu = menu; // I delete it in order to work
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (tbReasonForDeparture.Text == String.Empty)
            {
                MessageBox.Show("Please specify a reason for removing the animal");
            }
            else
            {
                animal.ReasonForDeparture = tbReasonForDeparture.Text;
                try
                {
                    manager.DeleteAnimal(animal);
                    MessageBox.Show("Deleted successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // menu.UpdateAnimals();
            }
            this.Dispose();
        }

        private void fmDeleteAnimal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
