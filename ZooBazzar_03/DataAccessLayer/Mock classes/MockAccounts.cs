using Entities;

namespace DataAccessLayer
{
    public class MockAccounts : ICRU<Account>, IAccount
    {
        public void Add(Account obj)
        {
            
        }

        public void ChangePassword(string username, string password)
        {
            
        }

        public void Delete(int id)
        {
            
        }

        public Account GetAccountByUsername(string username)
        {
            return null;
        }

        public string GetEmployeeWorkPositionByAccount(string username)
        {
            return " ";
        }

        public int GetNextID()
        {
            return 0;
        }

        public List<Account> Read()
        {
            return null;
        }
        public void Update(Account obj)
        {
            
        }
    }
}
