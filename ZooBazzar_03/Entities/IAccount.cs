using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IAccount
    {
        public int GetNextID();
        public void Delete(int id);
        public void ChangePassword(string username, string password);
        public string GetEmployeeWorkPositionByAccount(string username);
        public Account GetAccountByUsername(string username);
    }
}
