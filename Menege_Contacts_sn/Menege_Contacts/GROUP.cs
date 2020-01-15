using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Menege_Contacts
{
    class GROUP
    {
        MY_DB db = new MY_DB();

        public bool insertGroup(string gname, int uid)
        {
            string query = "INSERT INTO Groups(Name,UserId) VALUES(@gn,@ui)";
            SqlCommand command = new SqlCommand(query, db.getConnection());

            command.Parameters.Add("gn", SqlDbType.VarChar).Value = gname;
            command.Parameters.Add("ui", SqlDbType.Int).Value = uid;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                db.clsoeConnection();
                return true;
            }
            else
            {
                db.clsoeConnection();
                return false;
            }
        }
        public bool groupExists(string gname, string operation, int userid=0,int gid=0)
        {
            string query = "";
            SqlCommand command = new SqlCommand();
            if (operation == "add")
            {
                query = "select * from Groups where Name = @gn and UserId = @uid ";
                command = new SqlCommand(query, db.getConnection());
            }
            else if (operation == "edit")
            {
                query = "select * from Groups where Name = @gn and IdUser = @id and IdGroup <> @gid ";
                command = new SqlCommand(query, db.getConnection());
                command.Parameters.Add("gid", SqlDbType.Int).Value = gid;
            }
            command.Parameters.Add("gn", SqlDbType.VarChar).Value = gname;
            command.Parameters.Add("uid", SqlDbType.Int).Value = userid;

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            adapter.SelectCommand = command;
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
