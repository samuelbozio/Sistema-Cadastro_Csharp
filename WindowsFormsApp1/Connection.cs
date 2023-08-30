using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    internal class Connection
    {
        public string connect = "SERVER-localhost; DATABASE-banco_de_dados; UID-root, PWD-; PORT-3307;";

        public MySqlConnection connection = null;
    }
}
