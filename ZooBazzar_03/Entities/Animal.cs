using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities
{
    public class Animal
    {
        private int id;
        private string animalCode;
        private string name;
        private string gender;
        private AnimalType type;
        private string specie;
        private int cageNumber;
        private string birthDate;
        private string reasonForArrival;
        private string yearOfArrival;
        private string yearOfDeparture;
        private string reasonForDeparture;
        private Diet diet;
        int weeklyFeedingIteration;
        private Specialization specialization;
        List<string> feedingTimes = new List<string>();
        List<string> notes = new List<string>();
        


        public int Id { get { return id; } }
        public int CageNumber { get { return cageNumber; } }
        public string Name { get { return name; } }
        public string Gender { get { return gender; } }
        public string Specie { get { return specie; } }
        public string AnimalCode { get { return animalCode; } }
        public string Birthdate { get { return birthDate; } }
        public string ReasonForArrival { get { return reasonForArrival; } }
        public string YearOfArrival { get { return yearOfArrival; } }
        public string YearOfDeparture { get { return yearOfDeparture; } }
        public string ReasonForDeparture { get { return reasonForDeparture; } set { reasonForDeparture = value; } }
        public List<string> FeedingTimes { get { return feedingTimes; } set { feedingTimes = value; } }
        public List<string> Notes { get { return notes; } set { notes = value; } }
        public Specialization Specialization { get { return specialization; } }

        public Diet Diet { get { return diet; } set { diet = value; } }
        public AnimalType AnimalType { get { return type; } set { type = value; } }
        public int WeeklyFeedingIteration{ get { return weeklyFeedingIteration; } }

        public Animal(string animalCode, int id, int cageNumber, string name, string gender, string reasonForArrival, string reasonForDeparture, Diet diet, AnimalType type, string specie, string yearOfArrival, string yearOfDeparture, string birthdate, Specialization specialization, List<string> feedingTimes, int weeklyFeeding, List<string> notes)
        {
            this.id = id;
            this.cageNumber = cageNumber;
            this.name = name;
            this.reasonForArrival = reasonForArrival;
            this.reasonForDeparture = reasonForDeparture;
            this.diet = diet;
            this.type = type;
            this.specie = specie;
            this.yearOfArrival = yearOfArrival;
            this.yearOfDeparture = yearOfDeparture;
            this.birthDate = birthdate;
            this.animalCode = animalCode;
            this.gender = gender;
            this.specialization = specialization;
            this.feedingTimes = feedingTimes;
            this.weeklyFeedingIteration = weeklyFeeding;
            this.notes = notes;
        }


        public Animal(int cageNumber, string animalCode, string name, Diet diet, AnimalType type, string gender, Specialization specialization, string specie, string reasonForArrival, string yearOfArrival, string birthDate, int weeklyFeeding, List<string> feedingTimes)
        {
            ValidateData(weeklyFeeding);
            this.cageNumber = cageNumber;
            this.animalCode = animalCode;
            this.name = name;
            this.diet = diet;
            this.type = type;
            this.gender = gender;
            this.specialization = specialization;
            this.specie = specie;
            this.reasonForArrival = reasonForArrival;
            this.yearOfArrival = yearOfArrival;
            this.birthDate = birthDate;
            this.weeklyFeedingIteration = weeklyFeeding;
            this.feedingTimes = feedingTimes;
        }
        public Animal(string animalCode, int cageNumber, Diet diet, AnimalType type, string specie, int weeklyFeedingIteration)
        {
            this.cageNumber = cageNumber;
            this.diet = diet;
            this.type = type;
            this.specie = specie;
            this.animalCode = animalCode;
            this.weeklyFeedingIteration = weeklyFeedingIteration;
        }

        public void ValidateData(int weeklyFeeding)
        {
            if (weeklyFeeding<1)
            {
                throw new Exception("The animal must be fed at least once per week");
            }

        }


        public string GetInfo()
        {
            return $"id: {this.id}, name:{this.name}";
        }

        public void SetNotes(List<string> notes)
        {
            this.notes = notes;
        }
    }
}
