using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Menege_Contacts
{
    class USER
    {
        MY_DB db = new MY_DB();

        public bool usernameExists(string username)
        {
            string query = "SELECT * FROM User WHERE Username=@un";
            SqlCommand command = new SqlCommand(query, db.getConnection);

            command.Parameters.Add("un", SqlDbType.VarChar).Value = username;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
