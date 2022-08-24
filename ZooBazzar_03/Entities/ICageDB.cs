using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface ICageDB<Cage>
    {
         List<Cage> GetCages();
         List<Animal> GetAnimalsInCage(int cageNumber);

         List<string> GetFeedingTimes(string animalCode);

    }
}
