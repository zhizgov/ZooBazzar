using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace LogicLayer
{
    public class CageManager
    {
        private static List<Cage> cages;

        public List<Cage> Cages { get { return cages; } }
        ICageDB<Cage> crud;
        public CageManager(ICageDB<Cage> crud)
        {
            this.crud = crud;
            cages = crud.GetCages();
            InsertAnimalsInCage();

        }

        public void AddAnimalToCage(Animal animal, Cage cage)
        {
            if (cage.CageAnimals.Count==cage.Capacity)
            {
                throw new Exception("This cage is full");
            }

            if (cage.AnimalType!=animal.AnimalType)
            {
                throw new Exception("You cant add this animal to this cage");
            }
            
        }

        public void GetCages()
        {
            if (cages != null)
            {
                cages.Clear();
            }
            cages = crud.GetCages();
        }

        public Cage GetCageByCageNr(int cageNr)
        {
            return cages.Find(x => x.CageNumber == cageNr);
        }
        

        public void InsertAnimalsInCage()
        {
            
            for (int i = 0; i < cages.Count; i++)
            {
                cages[i].CageAnimals = crud.GetAnimalsInCage(cages[i].CageNumber);
                for (int j = 0; j < cages[i].CageAnimals.Count; j++)
                {
                    cages[i].CageAnimals[j].FeedingTimes = crud.GetFeedingTimes(cages[i].CageAnimals[j].AnimalCode);
                }
            }


        }

        public AnimalType? GetCurrentType(Cage cage)
        {
            if (cage.CageAnimals.Count > 0)
            {
                return cage.CageAnimals[0].AnimalType;
            }

            return null;
        }

        
    }
}
