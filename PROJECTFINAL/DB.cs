using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PROJECTFINAL
{
    class DB
    {
        private MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=;database= login ");

        // function for open the connection
        public void openConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed);
            {
                con.Open();  
                     
            }
        }

        // function for close the connection
        public void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open) ;
            {
                con.Close();

            }
        }

        // function for return to the connection
        public MySqlConnection getconnection()
        {
            return con;
        }
    }
   
}
