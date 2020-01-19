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
        CONTACT contact = new CONTACT();

        private void Form1_Load(object sender, EventArgs e)
        {
            getImageAndUsername();
            getGroups();
        }

        public void getGroups()
        {
            this.comboBox_editGroup1.DataSource = group.getGroup(GLOBAL.GlobalUserId);
            comboBox_editGroup1.DisplayMember = "Name";
            comboBox_editGroup1.ValueMember = "IdGroup";

            this.comboBox_DeleteGroup1.DataSource = group.getGroup(GLOBAL.GlobalUserId);
            comboBox_DeleteGroup1.DisplayMember = "Name";
            comboBox_DeleteGroup1.ValueMember = "IdGroup";
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

        private void label_Refresh_Click(object sender, EventArgs e)
        {
            getImageAndUsername();
        }

        private void button_addNewGroup_Click(object sender, EventArgs e)
        {
            string gname = this.textBox_addGroupName1.Text;

            if (!gname.Trim().Equals(""))
            {
                if (!group.groupExists(gname, "add", GLOBAL.GlobalUserId))
                {
                    if (group.insertGroup(gname, GLOBAL.GlobalUserId))
                    {
                        getGroups();
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

        private void button_editGroup_Click(object sender, EventArgs e)
        {
            try
            {
                string new_gname = this.textBox_newGropuname1.Text;
                int group_id = Convert.ToInt32(this.comboBox_editGroup1.SelectedValue.ToString());

                if (!new_gname.Trim().Equals(""))
                {
                    if (!group.groupExists(new_gname, "edit", GLOBAL.GlobalUserId, group_id))
                    {
                        if (group.updateGroup(new_gname, group_id, GLOBAL.GlobalUserId))
                        {
                            getGroups();
                            MessageBox.Show("Group Edited Successfully", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Something Wrong", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This Group Name already exists, try another one", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a group name", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Please Select a Group", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        

        private void button_DeleteGroup_Click(object sender, EventArgs e)
        {
            try
            {
                int group_id = Convert.ToInt32(this.comboBox_DeleteGroup1.SelectedValue.ToString());

                if (MessageBox.Show("Are you sure?", "Delete Group", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (group.deleteGroup(group_id))
                    {
                        getGroups();
                        MessageBox.Show("Group Deleted Successfully", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Delete Error", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Select a Group", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_AddContact_Click(object sender, EventArgs e)
        {
            Menege_Contacts.MyForms.Add_Contact cont = new Menege_Contacts.MyForms.Add_Contact();
            cont.Show(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button_addNewGroup_Click(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button_editGroup_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button_DeleteGroup_Click(sender, e);
        }

        private void button_EditContact_Click(object sender, EventArgs e)
        {
            Edit_Contact ec = new Edit_Contact();
            ec.ShowDialog();
        }

        private void button_SelContact_Click(object sender, EventArgs e)
        {
            Select_Contact_Form sc = new Select_Contact_Form();
            sc.ShowDialog();

            int idContact = Convert.ToInt32(sc.dataGridView1.CurrentRow.Cells[0].Value.ToString());

            this.textBox_ci.Text = idContact.ToString();
        }

        private void button_RemoveContact_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.textBox_ci.Text.Trim().Equals(""))
                {
                    int c_id = Convert.ToInt32(this.textBox_ci.Text);
                    if (contact.deleteContact(c_id))
                    {
                            MessageBox.Show("Group Edited Successfully", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Error", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please Select a Contact", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Please Select a Contact", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_Show_Contacts_Click(object sender, EventArgs e)
        {
            Contact_List cl = new Contact_List();
            cl.ShowDialog();
        }
    }
}
