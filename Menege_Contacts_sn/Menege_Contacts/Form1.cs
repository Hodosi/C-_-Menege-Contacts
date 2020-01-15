using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Menege_Contacts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MY_DB db = new MY_DB();
        USER user = new USER();
        GROUP group = new GROUP();

        private void Form1_Load(object sender, EventArgs e)
        {
            getImageAndUsername();
        }

        private void button_Close_login_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_min_login_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public void getImageAndUsername()
        {
            string query = "select * from Users where IdUser = @id";
            SqlCommand command = new SqlCommand(query, db.getConnection());

            command.Parameters.Add("id", SqlDbType.VarChar).Value = GLOBAL.GlobalUserId;

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                byte[] pic = (byte[])table.Rows[0]["Picture"];
                MemoryStream stream = new MemoryStream(pic);
                this.pictureBox1.Image = Image.FromStream(stream);

                label_curent_username.Text = table.Rows[0]["Username"].ToString();

            }
            else
            {
                
            }
        }

        private void label_Edit_Info_Click(object sender, EventArgs e)
        {
            Menege_Contacts.MyForms.Edit_User_Data user_Data = new Menege_Contacts.MyForms.Edit_User_Data();
            user_Data.ShowDialog();
        }

        private void button_addNewGroup_Click(object sender, EventArgs e)
        {
            string gname = this.textBox_addGroupName.Text;

            if (!gname.Trim().Equals(""))
            {
                if (!group.groupExists(gname, "add", GLOBAL.GlobalUserId))
                {
                    if (group.insertGroup(gname, GLOBAL.GlobalUserId))
                    {
                        MessageBox.Show("Group Added Successfully", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Something Wrong", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("This Group already exists, try another one", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter a group name", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
