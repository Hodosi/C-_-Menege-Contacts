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
    public partial class Contact_List : Form
    {
        public Contact_List()
        {
            InitializeComponent();
        }

        CONTACT contact = new CONTACT();
        GROUP group = new GROUP();

        private void Contact_List_Load(object sender, EventArgs e)
        {
            dataGridView1.RowTemplate.Height = 80;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();

            this.dataGridView1.DataSource = contact.getContactByAllGroup(GLOBAL.GlobalUserId);

            picCol = (DataGridViewImageColumn)dataGridView1.Columns[6];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (isOdd(i))
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.AntiqueWhite;
            }

            this.listBox1.DataSource = group.getGroup(GLOBAL.GlobalUserId);
            this.listBox1.DisplayMember = "Name";
            this.listBox1.ValueMember = "IdGroup";

            this.listBox1.SelectedItem = null;
            dataGridView1.ClearSelection();
        }


        private void label4_Click(object sender, EventArgs e)
        {
            Contact_List_Load(null, null);
        }

        private void textBox_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            try
            {
            int grouid = (int)this.listBox1.SelectedValue;
            this.dataGridView1.DataSource = contact.getContactByGroup(GLOBAL.GlobalUserId, grouid);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (isOdd(i))
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.AntiqueWhite;
            }
            }
            catch
            {
              MessageBox.Show("Error");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Contact_List_Load(null, null);
        }

        public bool isOdd(int value)
        {
            return value % 2 != 0;
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (isOdd(i))
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.AntiqueWhite;
            }
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            this.textBox_address.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
