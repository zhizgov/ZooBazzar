using MySql.Data.MySqlClient;
using Entities;

namespace DataAccessLayer
{
    public  class CageDBMock : ICageDB<Cage>
    {
        public List<Cage> GetCages()
        {
            return new List<Cage>();
        }

        public List<Animal> GetAnimalsInCage(int cageNumber)
        {
            return new List<Animal>();
        }

        public List<string> GetFeedingTimes(string animalCode)
        {
            return new List<string>();
        }


    }
}
