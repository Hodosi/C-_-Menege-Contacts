using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Menege_Contacts
{
    public partial class Edit_Contact : Form
    {
        public Edit_Contact()
        {
            InitializeComponent();
        }
        CONTACT contact = new CONTACT();
        GROUP group = new GROUP();
        private void Edit_Contact_Load(object sender, EventArgs e)
        {
            this.comboBox_group.DataSource = group.getGroup(GLOBAL.GlobalUserId);
            this.comboBox_group.DisplayMember = "Name";
            this.comboBox_group.ValueMember = "IdGroup";
        }
        private void button_Contact_Click(object sender, EventArgs e)
        {
            Select_Contact_Form sc = new Select_Contact_Form();
            sc.ShowDialog();

            int idContact = Convert.ToInt32(sc.dataGridView1.CurrentRow.Cells[0].Value.ToString());

            DataTable table = contact.getContactbyId(idContact);

            this.textBox_selectedId.Text = idContact.ToString();
            this.textBox_fname.Text = table.Rows[0][0].ToString();
            this.textBox_lname.Text = table.Rows[0][1].ToString();
            this.comboBox_group.SelectedValue = table.Rows[0][2];
            this.textBox_phone.Text = table.Rows[0][3].ToString();
            this.textBox_email.Text = table.Rows[0][4].ToString();
            this.textBox_address.Text = table.Rows[0][5].ToString();

            byte[] pic = (byte[])table.Rows[0][6];
            MemoryStream picture = new MemoryStream(pic);
            this.pictureBox1.Image = Image.FromStream(picture);




        }

        private void button_EditContact_Click(object sender, EventArgs e)
        {
            try
            {
                int cont_id = Convert.ToInt32(this.textBox_selectedId.Text);
                string fname = this.textBox_fname.Text;
                string lname = this.textBox_lname.Text;
                int g_id = Convert.ToInt32(this.comboBox_group.SelectedValue.ToString());
                string phone = this.textBox_phone.Text;
                string email = this.textBox_email.Text;
                string address = this.textBox_address.Text;
                MemoryStream img = new MemoryStream();
                this.pictureBox1.Image.Save(img, this.pictureBox1.Image.RawFormat);
                //int user_id = GLOBAL.GlobalUserId;

                if (contact.editContact(cont_id, fname, lname,g_id,phone,email,address,img))
                {
                    MessageBox.Show("Contact Updated Successfully", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Something Wrong", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("One or More Empty Fields", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
