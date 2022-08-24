using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccessLayer
{
    public class AnimalDBMock : IAnimalDB<Animal>, IAutoIncrementable
    {
        public void AddAnimalToDB(Animal animal)
        {
            throw new NotImplementedException();
        }

        public void AddNote(int id, string note)
        {
            throw new NotImplementedException();
        }

        public void DeleteAnimalFromDB(Animal animal)
        {
            throw new NotImplementedException();
        }

        public List<Animal> GetAnimals()
        {
            throw new NotImplementedException();
        }

        public List<string> GetFeeding(Animal animal)
        {
            throw new NotImplementedException();
        }

        public int GetNexID()
        {
            throw new NotImplementedException();
        }

        public List<string> GetNotes(Animal animal)
        {
            throw new NotImplementedException();
        }

        public void UpdateAnimalInDB(Animal animal)
        {
            throw new NotImplementedException();
        }
    }
}
