using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Menege_Contacts.NewFolder1
{
    public partial class Login_Register_Form : Form
    {
        public Login_Register_Form()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {

        }

        private void button_register_Click(object sender, EventArgs e)
        {
            string fname = this.textBox_firstn.Text;
            string lname = this.textBox_lastn.Text;
            string usrn = this.textBox_usrn_register.Text;
            string pass = this.textBox_passw_register.Text;

            if (verifyFields("register"))
            {
                MemoryStream pic = new MemoryStream();
                this.pictureBox_profile_img.Image.Save(pic, this.pictureBox_profile_img.Image.RawFormat);
            }
        }

        private void button_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.git)|*.jpg;*.png;*.git";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox_profile_img.Image = Image.FromFile(opf.FileName);
            }
        }

        private void label_GoRegister_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label_GoLogin.Enabled = true;
            label_GoRegister.Enabled = false;
        }

        private void label_GoLogin_Click(object sender, EventArgs e)
        {
            timer2.Start();
            label_GoLogin.Enabled = false;
            label_GoRegister.Enabled = true;
        }

        private void button_Close_login_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_min_login_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //only the register part
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panel2.Location.X > -320)
            {
                panel2.Location = new Point(panel2.Location.X - 10, panel2.Location.Y);
            }
            else
            {
                timer1.Stop();
                label_GoLogin.Enabled = true;
                label_GoRegister.Enabled = false;
            }
        }


        //only the login part
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (panel2.Location.X < 0)
            {
                panel2.Location = new Point(panel2.Location.X + 10, panel2.Location.Y);
            }
            else
            {
                timer2.Stop();
                label_GoLogin.Enabled = false;
                label_GoRegister.Enabled = true;
            }
        }

        public bool verifyFields(string operation)
        {
            bool check = false;
            if (operation == "register")
            {
                if (this.textBox_usrn_register.Text.Equals("") || this.textBox_passw_register.Text.Equals("") || this.pictureBox_profile_img.Image == null)
                {
                    check = false;
                }
                else
                {
                    check = true;
                }
            }
            if (operation == "login")
            {
                if (this.textBox_usrn.Text.Equals("") || this.textBox_pssw.Text.Equals(""))
                {
                    check = false;
                }
                else
                {
                    check = true;
                }
            }
            return check;
        }
    }
}
