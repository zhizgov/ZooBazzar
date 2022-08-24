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
    public partial class FormAddAnimal : Form
    {
        private AnimalManager animalManager;
        private List<string> feedingTimes;

        private FlowLayoutPanel panel;
        public FormAddAnimal(FlowLayoutPanel panel, AnimalManager animalManager)
        {
            InitializeComponent();

            this.panel = panel;            
            this.animalManager = animalManager;
            this.feedingTimes = new List<string>();
            this.cbGender.DataSource = new string[] { "Male", "Female" };
                       
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbMorning.Checked)
            {
                feedingTimes.Add("morning");
            }
            if (cbAfternoon.Checked)
            {
                feedingTimes.Add("aftermoon");
            }
            if (cbEvening.Checked)
            {
                feedingTimes.Add("evening");
            }
            Animal newAnimal = new Animal(Convert.ToInt32(tbCageNumber.Text), tbAnimalCode.Text, tbName.Text, (Diet)cbDiet.SelectedItem, (AnimalType)cbAnimalType.SelectedItem, cbGender.SelectedItem.ToString(), (Specialization)cbSpecialist.SelectedItem, tbSpecie.Text, tbReasonForArrival.Text, tbYearOfArrival.Text, tbBirthdate.Text, Convert.ToInt32(tbWeeklyFeedIteration.Text), feedingTimes);
            try
            {
                animalManager.AddAnimal(newAnimal);
                MessageBox.Show("Added an animal successfully");
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //panel.Controls.Add(new AnimalPic());
        }

        private void FormAddAnimal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void FormAddAnimal_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(AnimalType)))
            {
                cbAnimalType.Items.Add(item);
            }

            foreach (var item in Enum.GetValues(typeof(Diet)))
            {
                cbDiet.Items.Add(item);
            }
            foreach (var item in Enum.GetValues(typeof(Specialization)))
            {
                cbSpecialist.Items.Add(item);
            }
        }

        
    }
}
