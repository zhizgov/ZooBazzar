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
    public partial class AnimalInfo : Form
    {
        private Animal animal;    
        private FlowLayoutPanel panel;
        private AnimalManager manager;

        public AnimalInfo(Animal animal, FlowLayoutPanel panel, AnimalManager manager)
        {
            InitializeComponent();

            this.animal = animal;
            this.panel = panel;
            this.manager = manager;
        }

        private void AnimalInfo_Load(object sender, EventArgs e)
        {
            tbID.Text = animal.Id.ToString(); ;
            tbCageNumber.Text = animal.CageNumber.ToString();
            tbAnimalCode.Text = animal.AnimalCode;
            tbName.Text = animal.Name;
            tbSpecie.Text = animal.Specie;
            tbReasonForArrival.Text = animal.ReasonForArrival;
            tbYearOfArrival.Text = animal.YearOfArrival;
            tbBirthdate.Text = animal.Birthdate;

            cbAnimalType.DataSource = Enum.GetValues(typeof(AnimalType));
            cbDiet.DataSource = Enum.GetValues(typeof(Diet));

            cbAnimalType.Text = animal.AnimalType.ToString();
            cbDiet.Text = animal.Diet.ToString();

        }

        private void AnimalInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Animal updatedAnimal = new Animal(tbAnimalCode.Text, animal.Id, Convert.ToInt32(tbCageNumber.Text), tbName.Text, animal.Gender, tbReasonForArrival.Text, animal.ReasonForDeparture, (Diet)cbDiet.SelectedItem, (AnimalType)cbAnimalType.SelectedItem, tbSpecie.Text, tbYearOfArrival.Text, animal.YearOfDeparture, tbBirthdate.Text, animal.Specialization, animal.FeedingTimes, animal.WeeklyFeedingIteration, animal.Notes);
            try
            {
                manager.UpdateAnimal(updatedAnimal);
                MessageBox.Show("Updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //animalManager.DeleteAnimalByID(animal.Id);
        }

        private void btnShowNotes_Click(object sender, EventArgs e)
        {
            //animalManager.AssignNotes(animal);
            fmAnimalNotes animalNotes = new fmAnimalNotes(animal.Notes);
            animalNotes.Show();
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            fmAddNote fmAddNote = new fmAddNote(animal.Id);
            fmAddNote.Show();
        }
    }
}
