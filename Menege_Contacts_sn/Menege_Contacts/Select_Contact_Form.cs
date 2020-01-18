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
    public partial class Select_Contact_Form : Form
    {
        public Select_Contact_Form()
        {
            InitializeComponent();
        }

        CONTACT contact = new CONTACT();
        private void Select_Contact_Form_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT IdContact,FirstName,LastName,Group_Id as Group_Id FROM Contacts WHERE User_Id=@uid";
            command.Parameters.Add("@uid", SqlDbType.Int).Value = GLOBAL.GlobalUserId;

            this.dataGridView1.DataSource = contact.selectContactList(command);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
