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

        public bool updateGroup(string gname, int group_id, int uid)
        {
            string query = "UPDATE Groups SET Name=@gn WHERE UserId=@uid and IdGroup=@ig";
            SqlCommand command = new SqlCommand(query, db.getConnection());

            command.Parameters.Add("gn", SqlDbType.VarChar).Value = gname;
            command.Parameters.Add("uid", SqlDbType.Int).Value = uid;
            command.Parameters.Add("ig", SqlDbType.Int).Value = group_id;

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

        public bool deleteGroup(int gi)
        {
            string query = "DELETE FROM Groups WHERE IdGroup = @gi";
            SqlCommand command = new SqlCommand(query, db.getConnection());

            command.Parameters.Add("gi", SqlDbType.Int).Value = gi;

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

        public bool groupExists(string gname, string operation, int userid = 0, int gid = 0)
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
                query = "select * from Groups where Name = @gn and UserId = @uid and IdGroup <> @gid ";
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

        public DataTable getGroup(int id)
        {
            string query = "SELECT * FROM Groups where UserId=@id";
            SqlCommand command = new SqlCommand(query, db.getConnection());

            command.Parameters.Add("id", SqlDbType.Int).Value = id;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;

        }
    }
}
