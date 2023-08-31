using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Connection
    {
        public string connectionString = "Server=localhost;Database=banco_de_dados;Uid=root;Port=3307;";

        public MySqlConnection connection = null;

        public Connection()
        {
            connection = new MySqlConnection(connectionString); 
        }


        public void openConnection()
        {
            try
            {
                connection.Open();
                MessageBox.Show("Conectado com sucesso!");
            }
            catch(Exception e) {
                MessageBox.Show("Erro no servidor. " + e.Message);
            }
        }

        public void closeConnection()
        {
            try
            {
                connection.Close(); 
            }
            catch(Exception e) {
                MessageBox.Show("Servidor não encontrado. " + e.Message );
            }

        }
    }
}
