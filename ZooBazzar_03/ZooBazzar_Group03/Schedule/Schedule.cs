using LogicLayer;
using Entities;
using DataAccessLayer;

namespace ZooBazzar_Group03
{
    public partial class Schedule : Form
    {
        public Schedule(string date)
        {
            InitializeComponent();
            this.date = date;
            this.currentDate = DateTime.ParseExact(date, "d MMM yyyy", null);
            sm.GetWeeklySchedule(currentDate, 0);
        }
        string date;

        ScheduleManager sm = new ScheduleManager(new ScheduleDB(), new EmployeeDB(), new CageDB(), new ContractDB(), new ScheduleDB());

        DateTime currentDate;
        AnimalType currentType;
        string timeSlot;

        

        private void Schedule_Load(object sender, EventArgs e)
        {
            if (currentDate.CompareTo(DateTime.Today) < 1)
            {
                btnAssign.Enabled = false;
                btnEditEmployee.Enabled = false;
            }
            lblDate.Text = date;  
        }

        private void cmbTimeSloth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTimeSloth.SelectedIndex > -1)
            {
                string time = cmbTimeSloth.SelectedItem.ToString();
                if (time == "6:00 - 8:00")
                {
                    timeSlot = "morning";
                }

                if (time == "12:00 - 14:00")
                {
                    timeSlot = "afternoon";
                }

                if (time == "20:00 - 22:00")
                {
                    timeSlot = "evening";
                }
                GetCaretakers(currentType);
                GetCages();
            }
        }


        private bool AssignedCaretaker()
        {
            cmbFirstCaretaker.Text = "";
            cmbFirstCaretaker.SelectedIndex = -1;
            cmbSecondCaretaker.Text = "";
            cmbSecondCaretaker.SelectedIndex = -1;
            cmbHelperCaretaker.Text = "";

            DailySchedule ds = sm.AssignedCaretakers(timeSlot, date, currentType);

            if (ds != null)
            {
                cmbFirstCaretaker.SelectedItem = ds.MainCaretakerFir.ToString();
                cmbFirstCaretaker.Text = ds.MainCaretakerFir.ToString();
                cmbSecondCaretaker.SelectedItem = ds.MainCaretakerSec.ToString();
                cmbSecondCaretaker.Text = ds.MainCaretakerSec.ToString();

                if (ds.HelpCaretaker != null)
                {
                    cmbHelperCaretaker.Text = ds.HelpCaretaker.ToString();
                }

                if (currentDate.CompareTo(DateTime.Today) > 0)
                {
                    btnAssign.Enabled = false;
                    btnEditEmployee.Enabled = true;
                }

                return true;
            }
            else
            {

                if (currentDate.CompareTo(DateTime.Today) > 0)
                {
                    btnAssign.Enabled = true;
                    btnEditEmployee.Enabled = false;
                }
                

                return false;
            }
        }


        private void cmbAnimalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((AnimalType)Enum.Parse(typeof(AnimalType), cmbAnimalType.SelectedItem.ToString()))
            {
                case AnimalType.Mammal:
                    currentType = AnimalType.Mammal;
                    break;
                case AnimalType.Insect:
                    currentType = AnimalType.Insect;
                    break;
                case AnimalType.Reptile:
                    currentType = AnimalType.Reptile;
                    break;
                case AnimalType.Fish:
                    currentType = AnimalType.Fish;
                    break;
                case AnimalType.Amphibian:
                    currentType = AnimalType.Amphibian;
                    break;
                case AnimalType.Bird:
                    currentType = AnimalType.Bird;
                    break;
            }
        }


        public void GetCaretakers(AnimalType type)
        {

            AssignedCaretaker();


            List<Caretaker> fullShift = sm.GetFreeCaretakers(type, date, timeSlot);



            cmbFirstCaretaker.Items.Clear();
            cmbSecondCaretaker.Items.Clear();
            cmbHelperCaretaker.Items.Clear();



            for (int i = 0; i < fullShift.Count; i++)
            {
                cmbFirstCaretaker.Items.Add(fullShift[i]);
                cmbSecondCaretaker.Items.Add(fullShift[i]);
                cmbHelperCaretaker.Items.Add(fullShift[i]);
            }


        }


        public bool ChosenCaretaker()
        {
            if (cmbFirstCaretaker.SelectedItem != cmbSecondCaretaker.SelectedItem && cmbSecondCaretaker.SelectedItem != cmbHelperCaretaker.SelectedItem && cmbHelperCaretaker.SelectedItem != cmbFirstCaretaker.SelectedItem)
            {
                return true;
            }
            return false;
        }

        private void GetCages()
        {
            lbCages.Items.Clear();

            List<Cage> cages = sm.GetCages(timeSlot, currentType, currentDate);

            if (cages.Count > 0)
            {
                for (int i = 0; i < cages.Count; i++)
                {
                    lbCages.Items.Add(cages[i]);
                }
            }
            else
            {
                lbCages.Items.Add("There are no animals that must be fed in this time slot!");
                btnAssign.Enabled = false;
                btnEditEmployee.Enabled = false;
            }
        }



        public void btnAssign_Click(object sender, EventArgs e)
        {
            if (ChosenCaretaker())
            {
                Caretaker caretaker1 = (Caretaker)cmbFirstCaretaker.SelectedItem;
                Caretaker caretaker2 = (Caretaker)cmbSecondCaretaker.SelectedItem;
                Caretaker caretaker3;

                if (cmbHelperCaretaker.SelectedIndex > -1)
                {
                    caretaker3 = (Caretaker)cmbHelperCaretaker.SelectedItem;
                }
                else
                {
                    caretaker3 = null;
                }

                if (sm.Insert(new DailySchedule(sm.GetId(), (AnimalType)Enum.Parse(typeof(AnimalType), cmbAnimalType.SelectedItem.ToString()), date, caretaker1, caretaker2, caretaker3, timeSlot)))
                {
                    MessageBox.Show("Fortunately, thanks to my great coding skills you were able to successfully assign a caretaker to the animal");
                    btnAssign.Enabled = false;
                    btnEditEmployee.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Unfortunately, under unknown circumstances you sadly didn't do anythyng useful!!!");
                }
            }
            else
            {
                MessageBox.Show("U chose the same employee");
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            Caretaker caretaker1 = (Caretaker)cmbFirstCaretaker.SelectedItem;
            Caretaker caretaker2 = (Caretaker)cmbSecondCaretaker.SelectedItem;
            Caretaker caretaker3;

            if (ChosenCaretaker())
            {
                if (cmbHelperCaretaker.SelectedIndex > -1)
                {
                    caretaker3 = (Caretaker)cmbHelperCaretaker.SelectedItem;
                }
                else
                {
                    caretaker3 = null;
                }


                if (sm.Update(new DailySchedule(sm.GetId(), currentType, date, caretaker1, caretaker2, caretaker3, timeSlot)))
                {
                    MessageBox.Show("Fortunately, thanks to my great coding skills you were able to successfully edit the assigned caretaker to the animal");
                }
                else
                {
                    MessageBox.Show("Unfortunately, under unknown circumstances you sadly didn't do anythyng useful!!!");
                }
            }
            else
            {
                MessageBox.Show("You chose the same employee!");
            }
            
        }


    }
}
