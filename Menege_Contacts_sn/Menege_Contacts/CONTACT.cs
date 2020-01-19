using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Menege_Contacts
{
    class CONTACT
    {
        MY_DB db = new MY_DB();

        public bool insertContact(string fn, string ln, int gid, string phone, string email, string address, MemoryStream pic, int user_id)
        {
            string query = "INSERT INTO Contacts(FirstName,LastName,Group_Id,Phone,Email,Address,Image,User_id) Values(@fn,@ln,@gid,@phone,@email,@address,@img,@uid)";
            SqlCommand command = new SqlCommand(query, db.getConnection());

            // fn,@ln,@gid,@phone,@email,@address,@img,@uid
            command.Parameters.Add("fn", SqlDbType.VarChar).Value = fn;
            command.Parameters.Add("ln", SqlDbType.VarChar).Value = ln;
            command.Parameters.Add("gid", SqlDbType.Int).Value = gid;
            command.Parameters.Add("phone", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("email", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("address", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("img", SqlDbType.Image).Value = pic.ToArray();
            command.Parameters.Add("uid", SqlDbType.Int).Value = user_id;

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

        public bool editContact(int id_cont, string fn, string ln, int gid, string phone, string email, string address, MemoryStream pic)
        {
            string query = "UPDATE Contacts SET FirstName=@fn,LastName=@ln,Phone=@phone,Email=@email,Address=@address,Image=@img WHERE IdContact=@idc";
            SqlCommand command = new SqlCommand(query, db.getConnection());

            // fn,@ln,@gid,@phone,@email,@address,@img,@idc
            command.Parameters.Add("idc", SqlDbType.Int).Value = id_cont;
            command.Parameters.Add("fn", SqlDbType.VarChar).Value = fn;
            command.Parameters.Add("ln", SqlDbType.VarChar).Value = ln;
            command.Parameters.Add("gid", SqlDbType.Int).Value = gid;
            command.Parameters.Add("phone", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("email", SqlDbType.VarChar).Value = email;
            command.Parameters.Add("address", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("img", SqlDbType.Image).Value = pic.ToArray();

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

        public bool deleteContact(int ci)
        {
            string query = "DELETE FROM Contacts WHERE IdContact = @gi";
            SqlCommand command = new SqlCommand(query, db.getConnection());

            command.Parameters.Add("gi", SqlDbType.Int).Value = ci;

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

        public DataTable selectContactList(SqlCommand command)
        {
            command.Connection = db.getConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getContactbyId(int contactId)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT FirstName,LastName,Group_Id,Phone,Email,Address,Image FROM Contacts WHERE IdContact=@idc";
            command.Connection = db.getConnection();
            command.Parameters.Add("idc", SqlDbType.Int).Value = contactId;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getContactByAllGroup(int uid)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT FirstName,LastName,Groups.Name as GroupName,Phone,Email,Address,Image FROM Contacts INNER JOIN Groups ON Contacts.Group_Id=Groups.IdGroup WHERE Contacts.User_Id=@uid";
            command.Connection = db.getConnection();
            command.Parameters.Add("uid", SqlDbType.Int).Value = uid;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getContactByGroup(int uid,int gi)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT FirstName,LastName,Groups.Name as GroupName,Phone,Email,Address,Image FROM Contacts INNER JOIN Groups ON Contacts.Group_Id=Groups.IdGroup WHERE Contacts.User_Id=@uid and Contacts.Group_Id=@gi";
            command.Connection = db.getConnection();
            command.Parameters.Add("uid", SqlDbType.Int).Value = uid;
            command.Parameters.Add("gi", SqlDbType.Int).Value = gi;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
