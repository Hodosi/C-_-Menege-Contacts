using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Menege_Contacts
{
    class USER
    {
        MY_DB db = new MY_DB();

        public bool usernameExists(string username,string operation,int userid=0)
        {
            string query = "";
            SqlCommand command = new SqlCommand();
            if (operation == "register")
            {
                query = "select * from Users where Username = @un ";
                command = new SqlCommand(query, db.getConnection());
            }
            else if(operation == "edit")
            {
                query = "select * from Users where Username = @un and IdUser <> @id ";
                command = new SqlCommand(query, db.getConnection());
                command.Parameters.Add("@id", SqlDbType.Int).Value = userid;
            }

            //command.Parameters.Add("@id", SqlDbType.Int).Value = userid;
            command.Parameters.Add("un", SqlDbType.VarChar).Value = username;

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

        public bool ExistUser(string usrn, string pass)
        {
            string query = "select * from Users where Username = @un  and Password = @pass";
            SqlCommand command = new SqlCommand(query, db.getConnection());

            command.Parameters.Add("un", SqlDbType.VarChar).Value = usrn;
            command.Parameters.Add("pass", SqlDbType.VarChar).Value = pass;

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
        public int GlobalUser(string usrn, string pass)
        {
            string query = "select * from Users where Username = @un  and Password = @pass";
            SqlCommand command = new SqlCommand(query, db.getConnection());

            command.Parameters.Add("un", SqlDbType.VarChar).Value = usrn;
            command.Parameters.Add("pass", SqlDbType.VarChar).Value = pass;

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return Convert.ToInt32(table.Rows[0][0].ToString());

        }

        public bool insertClients(string fn, string ln, string un, string pass, MemoryStream pic)
        {
            string query = "INSERT INTO Users(First_Name,Last_Name,Username,Password,Picture) VALUES(@fn,@ln,@us,@pass,@pic)";
            SqlCommand command = new SqlCommand(query, db.getConnection());

            command.Parameters.Add("fn", SqlDbType.VarChar).Value = fn;
            command.Parameters.Add("ln", SqlDbType.VarChar).Value = ln;
            command.Parameters.Add("us", SqlDbType.VarChar).Value = un;
            command.Parameters.Add("pass", SqlDbType.VarChar).Value = pass;
            command.Parameters.Add("pic", SqlDbType.Image).Value = pic.ToArray();

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

        public bool updateClients(int id,string fn, string ln, string un, string pass, MemoryStream pic)
        {
            string query = "UPDATE Users SET First_Name=@fn,Last_Name=@ln,Username=@us,Password=@pass,Picture=@pic WHERE IdUser=@usid";
            SqlCommand command = new SqlCommand(query, db.getConnection());

            command.Parameters.Add("fn", SqlDbType.VarChar).Value = fn;
            command.Parameters.Add("ln", SqlDbType.VarChar).Value = ln;
            command.Parameters.Add("us", SqlDbType.VarChar).Value = un;
            command.Parameters.Add("pass", SqlDbType.VarChar).Value = pass;
            command.Parameters.Add("pic", SqlDbType.Image).Value = pic.ToArray();
            command.Parameters.Add("usid", SqlDbType.Int).Value = id;

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

        public DataTable getUserData(int id)
        {
            string query = "select * from Users where IdUser=@id";
            SqlCommand command = new SqlCommand(query, db.getConnection());

            command.Parameters.Add("id", SqlDbType.VarChar).Value = id;

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
    }
}
