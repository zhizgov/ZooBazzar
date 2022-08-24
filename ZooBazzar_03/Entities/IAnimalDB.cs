using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IAnimalDB<Animal>
    {
       public List<Animal> GetAnimals();
       public void AddAnimalToDB(Animal animal);
       public void UpdateAnimalInDB(Animal animal);
       public void DeleteAnimalFromDB(Animal animal);
       public List<string> GetFeeding(Animal animal);
       public List<string> GetNotes(Animal animal);
       public void AddNote(int id, string note);

    }
}
