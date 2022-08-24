using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class ConnectionDB
    {
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection("Server = studmysql01.fhict.local; Uid = dbi481796; Database = dbi481796; Pwd = sql7915");
        }
    }
}
