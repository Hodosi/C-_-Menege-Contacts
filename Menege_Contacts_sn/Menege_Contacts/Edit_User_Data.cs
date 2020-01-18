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

namespace Menege_Contacts.MyForms
{
    public partial class Edit_User_Data : Form
    {
        public Edit_User_Data()
        {
            InitializeComponent();
        }

        USER user = new USER();
        private void Edit_User_Data_Load(object sender, EventArgs e)
        {
            DataTable table = user.getUserData(GLOBAL.GlobalUserId);
            //--i am here---
            this.textBox_firstname.Text = table.Rows[0][1].ToString();
            this.textBox_lastname.Text = table.Rows[0][2].ToString();
            this.textBox_username.Text = table.Rows[0][3].ToString();
            this.textBox_password.Text = table.Rows[0][4].ToString();

            byte[] pic = (byte[])table.Rows[0]["Picture"];
            MemoryStream picture = new MemoryStream(pic);
            this.pictureBox1.Image = Image.FromStream(picture);
        }

        private void button_Close_login_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_min_login_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button_edit_img_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.git)|*.jpg;*.png;*.git";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void button_Edit_user_Data_Click(object sender, EventArgs e)
        {
            string fname = this.textBox_firstname.Text.Trim();
            string lname = this.textBox_lastname.Text.Trim();
            string usrn = this.textBox_username.Text.Trim();
            string pass = this.textBox_password.Text.Trim();

            MemoryStream pic = new MemoryStream();
            this.pictureBox1.Image.Save(pic, this.pictureBox1.Image.RawFormat);

            if (usrn != "" && pass !="" && this.pictureBox1.Image != null)
            {
                if (user.usernameExists(usrn, "edit", GLOBAL.GlobalUserId))
                {
                    MessageBox.Show("This Username already exists, try another one", "Edit Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (user.updateClients(GLOBAL.GlobalUserId, fname, lname, usrn, pass, pic))
                {
                    MessageBox.Show("User Data Updated Successfully", "Edit Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Something Wrong", "Edit Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Required Fields: Username,Password,Picture", "Edit Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
