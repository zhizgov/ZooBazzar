using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using Entities;
using LogicLayer;

namespace ZooBazzar_Group03
{
    public partial class AnimalPic : UserControl
    {
        private Animal animal;             
        private string workposition;
        private FlowLayoutPanel panel;
        private AnimalManager manager;

        public AnimalPic(Animal animal, string workposition, FlowLayoutPanel panel, AnimalManager manager)
        {
            InitializeComponent();

            this.animal = animal;        
            this.workposition = workposition;
            this.panel = panel;
            this.BackColor = ColorThemeHandler.PrimaryColor;
            this.manager = manager;
            if (workposition != "Manager")
            {
                btnRemoveAnimal.Visible = false;
            }
        }

        private void AnimalPic_Load(object sender, EventArgs e)
        {
            lblName.Text = animal.Name;
            //if (animalManager.HasImage(animal))
            //{
            //    MemoryStream ms = animalManager.GetMemoryStream(animal.AnimalCode);
            //    pbAnimal.Image = Image.FromStream(ms);
            //}
        }

        private void pbAnimal_Click(object sender, EventArgs e)
        {
            if (workposition == "Manager")
            {
                AnimalInfo animalInfo = new AnimalInfo(animal,panel, manager); ;
                animalInfo.Show();
                
            }
        }

        private void btnRemoveAnimal_Click(object sender, EventArgs e)
        {
            fmDeleteAnimal deleteAnimal = new fmDeleteAnimal(this.animal, manager);
            deleteAnimal.Show();
        }
    }
}
