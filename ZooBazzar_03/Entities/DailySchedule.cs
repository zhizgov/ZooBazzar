using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class DailySchedule
    {
        private int id;
        private string date;
        private Caretaker mainCaretakerFir;
        private Caretaker mainCaretakerSec;
        private Caretaker helpCaretaker;
        private string timeSlot;
        private AnimalType type;

        public int Id { get { return id; } }
        public string Date { get { return date; } }
        public string TimeSlot { get { return timeSlot; } }
        public Caretaker MainCaretakerFir { get { return mainCaretakerFir; } }
        public Caretaker MainCaretakerSec { get { return mainCaretakerSec; } }
        public Caretaker HelpCaretaker { get { return helpCaretaker; } }
        public AnimalType Type { get { return type; } }


        private void CheckCaretakers(AnimalType type, Caretaker c1, Caretaker c2, Caretaker c3)
        {
            switch (type)
            {
                case AnimalType.Mammal:
                    if (c1.GetSpecialization() != Specialization.Mammalogist || c2.GetSpecialization() != Specialization.Mammalogist || (c3 != null && c3.GetSpecialization() != Specialization.Mammalogist))
                    {
                        throw new Exception("You can only assign spezialized caretakers!");
                    }
                    break;
                case AnimalType.Bird:
                    if (c1.GetSpecialization() != Specialization.Ornithologist || c2.GetSpecialization() != Specialization.Ornithologist || (c3 != null && c3.GetSpecialization() != Specialization.Ornithologist))
                    {
                        throw new Exception("You can only assign spezialized caretakers!");
                    }
                    break;
                case AnimalType.Fish:
                    if (c1.GetSpecialization() != Specialization.Ichthyologist || c2.GetSpecialization() != Specialization.Ichthyologist || (c3 != null && c3.GetSpecialization() != Specialization.Ichthyologist))
                    {
                        throw new Exception("You can only assign spezialized caretakers!");
                    }
                    break;
                case AnimalType.Insect:
                    if (c1.GetSpecialization() != Specialization.Entomologist || c2.GetSpecialization() != Specialization.Ichthyologist || (c3 != null && c3.GetSpecialization() != Specialization.Ichthyologist))
                    {
                        throw new Exception("You can only assign spezialized caretakers!");
                    }
                    break;
                case AnimalType.Reptile:
                    if (c1.GetSpecialization() != Specialization.Herprtologist || c2.GetSpecialization() != Specialization.Herprtologist || (c3 != null && c3.GetSpecialization() != Specialization.Herprtologist))
                    {
                        throw new Exception("You can only assign spezialized caretakers!");
                    }
                    break;
                case AnimalType.Amphibian:
                    if (c1.GetSpecialization() != Specialization.Herprtologist || c2.GetSpecialization() != Specialization.Herprtologist || (c3 != null && c3.GetSpecialization() != Specialization.Herprtologist))
                    {
                        throw new Exception("You can only assign spezialized caretakers!");
                    }
                    break;
                default:
                    throw new Exception("How did u get here");
                    break;
            }
        }
        public DailySchedule(int id, AnimalType type, string date, Caretaker mainFirst, Caretaker mainSecond, Caretaker helpCaretaker, string timeSlot)
        {
            CheckCaretakers(type, mainFirst, mainSecond, helpCaretaker);
            this.id = id;
            this.type = type;
            this.date = date;
            this.mainCaretakerFir = mainFirst;
            this.mainCaretakerSec = mainSecond;
            this.helpCaretaker = helpCaretaker;
            this.timeSlot = timeSlot;
        }

    }
}
