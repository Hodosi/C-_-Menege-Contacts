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
    public partial class Add_Contact : Form
    {
        public Add_Contact()
        {
            InitializeComponent();
        }

        CONTACT contact = new CONTACT();
        GROUP group = new GROUP();

        private void Add_Contact_Load(object sender, EventArgs e)
        {
            this.comboBox_group.DataSource = group.getGroup(GLOBAL.GlobalUserId);
            this.comboBox_group.DisplayMember = "Name";
            this.comboBox_group.ValueMember = "IdGroup";
        }

        private void button_addContact_Click(object sender, EventArgs e)
        {
            //if (verifyFields("register"))
            //{
            //    MemoryStream pic = new MemoryStream();
            //    this.pictureBox_profile_img.Image.Save(pic, this.pictureBox_profile_img.Image.RawFormat);

            //    if (!user.usernameExists(usrn, "register", GLOBAL.GlobalUserId))
            //    {

            try
            {
                string fname = this.textBox_fname.Text;
                string lname = this.textBox_lname.Text;
                int gr_id = Convert.ToInt32(this.comboBox_group.SelectedValue.ToString());
                string phone = this.textBox_phone.Text;
                string email = this.textBox_email.Text;
                string address = this.textBox_address.Text;
                MemoryStream img = new MemoryStream();
                this.pictureBox1.Image.Save(img, this.pictureBox1.Image.RawFormat);
                int user_id = GLOBAL.GlobalUserId;

                if (contact.insertContact(fname, lname, gr_id, phone, email, address, img, user_id))
                {
                    MessageBox.Show("Contact Added Successfully", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Something Wrong", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("One or More Empty Fields", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }   
                //}
                //    else
                //    {
                //        MessageBox.Show("This Username already exists, try another one", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("Required Fields: Username,Password,Picture", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
        }

        private void button_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.git)|*.jpg;*.png;*.git";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
