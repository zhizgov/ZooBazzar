using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Cage
    {
        //Fields
        private List<Animal> cageAnimals = new List<Animal>();

        private int cageNumber;
        private int capacity;
        private int animalsOutside;
        private int animalsInside;
        private string species;
        private AnimalType type;

        //Properties
        public List<Animal> CageAnimals { get { return cageAnimals; } set { cageAnimals = value; } }
        public int Capacity { get { return capacity; } }
        public int AnimalsOutside { get { return animalsOutside; } }
        public int AnimalsInside { get { return animalsInside; } }
        public int CageNumber { get { return cageNumber; } }
        public AnimalType AnimalType { get { return type; } }

        public Cage(int cageNumber, int capacity, int animalsOutside, int animalsInside, AnimalType type, string species)
        {
            this.cageNumber = cageNumber;
            this.capacity = capacity;
            this.animalsOutside = animalsOutside;
            this.animalsInside = animalsInside;
            this.type = type;
            this.species = species;
        }

        public Cage(int cageNr)
        {
            this.cageNumber = cageNr;
        }

        public string GetSpecie()
        {
            return cageAnimals[0].Specie;
        }

        public override string ToString()
        {
            return $"Cage number: {this.CageNumber}\tSpecies: {this.CageAnimals[0].Specie}";
        }
    }
}
