using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Menege_Contacts
{
    class MY_DB
    {
        //static public string connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Desktop\Menege Contacts\Menege_Contacts_sn\Menege_Contacts\bin\Debug\Menege_Clients_db.mdf;Integrated Security = True; Connect Timeout = 30";
        static public string connstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Menege_Clients_db.mdf;Integrated Security = True; Connect Timeout = 30";
        SqlConnection conn = new SqlConnection(connstring);

        public SqlConnection getConnection()
        {
            return conn;
        }

        public void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void clsoeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}

