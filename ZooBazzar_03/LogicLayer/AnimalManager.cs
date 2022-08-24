using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace LogicLayer
{
    public class AnimalManager
    {
        //Fields
        private IAnimalDB<Animal> crud;
        private List<Animal> animals;
        private IAutoIncrementable autoIncrement;

        //Properties
        public IList<Animal> Animals { get { return animals.AsReadOnly(); } }

        //Constructor
        public AnimalManager(IAnimalDB<Animal> crud, IAutoIncrementable autoIncrement)
        {
            this.crud = crud;
            this.autoIncrement = autoIncrement;
            animals = crud.GetAnimals();
        }

        //Methods
        public void AddAnimal(Animal animal)
        {
            //Create the animal with the next ID from the database
            Animal newAnimal = new Animal(animal.AnimalCode, autoIncrement.GetNexID(), animal.CageNumber, animal.Name, animal.Gender, animal.ReasonForArrival, animal.ReasonForDeparture, animal.Diet, animal.AnimalType, animal.Specie, animal.YearOfArrival, animal.YearOfDeparture, animal.Birthdate, animal.Specialization, animal.FeedingTimes, animal.WeeklyFeedingIteration, animal.Notes);
            crud.AddAnimalToDB(newAnimal);
            animals.Add(newAnimal);
        }

        public void UpdateAnimal(Animal animal)
        {
            crud.UpdateAnimalInDB(animal);
            animals.Remove(animals.First(x=>x.Id==animal.Id));
            animals.Add(animal);
        }

        //only sets its reason for departure without deleting the data of the animal
        public void DeleteAnimal(Animal animal)
        {
            crud.DeleteAnimalFromDB(animal);
        }

        public void AssignFeedingTimes()
        {
            for (int i = 0; i < animals.Count; i++)
            {
                animals[i].FeedingTimes = crud.GetFeeding(animals[i]);
            }
        }

        public void AssignNotes(Animal animal)
        {
            for (int i = 0; i < animals.Count; i++)
            {
                animal.Notes = crud.GetNotes(animal);
            }
        }

        public void AddNote(int id, string note)
        {
            crud.AddNote(id, note);
        }

    }
}
