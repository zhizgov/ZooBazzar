using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Account
    {
        private int id;
        private string username;
        private string password;
        private string salt;

        public int Id { get { return id; }}
        public string Username { get { return username; } }
        public string Password { get { return password; }}
        public string Salt { get { return salt; } }

        public Account(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public Account (string username,string password,int id)
        {
            this.username = username;
            this.password = password;
            this.id = id;
        }
        public Account(string username, string password,string salt,int id)
        {
            this.username = username;
            this.password = password;
            this.salt = salt;
            this.id= id;
        }
        public Account(string username, string password, string salt)
        {
            this.username = username;
            this.password = password;
            this.salt = salt;
          
        }

        public Account(int id, string username)
        {
            this.id = id;
            this.username = username;
        }
    }
}
