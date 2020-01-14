using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
    }
}
