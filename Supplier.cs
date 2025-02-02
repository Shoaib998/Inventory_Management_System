using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IMS
{
    public partial class Supplier : Sample2
    {
        public Supplier()
        {
            InitializeComponent();
        }
        int edit = 0; //This 0 is an andication to save operation and 1 is andication to update operstion
        int supplierID;
        short stat;
        retrieval r = new retrieval();
        private void Supplier_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
        }
        public override void addBtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftPanel);
            edit = 0;
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(leftPanel);
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (suppliercompanyTB.Text == "") { suppliernameerrorLbl.Visible = true; } else { suppliernameerrorLbl.Visible = false; }
            if (personnameTB.Text == "") { personnameerrorLbl.Visible = true; } else { personnameerrorLbl.Visible = false; }
            if (phone1TB.Text == "") { phone1errorLbl.Visible = true; } else { phone1errorLbl.Visible = false; }
            if (addressTB.Text == "") { addresserrorLbl.Visible = true; } else { addresserrorLbl.Visible = false; }
            if (statusDD.SelectedIndex == -1) { statuserrorLbl.Visible = true; } else { statuserrorLbl.Visible = false; }

            if (suppliernameerrorLbl.Visible || personnameerrorLbl.Visible || phone1errorLbl.Visible || addresserrorLbl.Visible || statuserrorLbl.Visible)
            {
                MainClass.ShowMSG("Fields with * is mendatory", "Stop", "Error"); // Error is the type of msg
            }
            else
            {

                if (statusDD.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (statusDD.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (edit == 0) // Code for SAVE Operation
                {

                    insertion i = new insertion();
                    if (phone2TB.Text == "" && ntnTB.Text != "")
                    {
                        i.insertSupplier(suppliercompanyTB.Text, personnameTB.Text, phone1TB.Text, addressTB.Text, stat, null, ntnTB.Text);
                    }
                    else if(phone2TB.Text != "" && ntnTB.Text == "")
                    {
                        i.insertSupplier(suppliercompanyTB.Text, personnameTB.Text, phone1TB.Text, addressTB.Text, stat,phone2TB.Text, null);
                    }
                    else if (phone2TB.Text == "" && ntnTB.Text == "")
                    {
                        i.insertSupplier(suppliercompanyTB.Text, personnameTB.Text, phone1TB.Text, addressTB.Text, stat, null, null);
                    }
                    else
                    {
                        i.insertSupplier(suppliercompanyTB.Text, personnameTB.Text, phone1TB.Text, addressTB.Text, stat, phone2TB.Text, ntnTB.Text);
                    }
                    r.showSuppliers(dataGridView1, suppIDGV, companyNameGV, personNameGV, phone1GV, phone2GV, addressGV, ntnGV, StatusGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1) // Cde For UPDATE Operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to update the record?", "Qusetion...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        updation u = new updation();
                        if (statusDD.SelectedIndex == 0)
                        {
                            stat = 1;
                        }
                        else if (statusDD.SelectedIndex == 1)
                        {
                            stat = 0;
                        }
                        if (phone2TB.Text == "" && ntnTB.Text != "")
                        {
                            u.updateSupplier(supplierID, suppliercompanyTB.Text, personnameTB.Text, phone1TB.Text, addressTB.Text, stat,null, ntnTB.Text);
                        }
                        else if (phone2TB.Text != "" && ntnTB.Text == "")
                        {
                            u.updateSupplier(supplierID, suppliercompanyTB.Text, personnameTB.Text, phone1TB.Text, addressTB.Text, stat, phone2TB.Text, null);
                        }
                        else if (phone2TB.Text == "" && ntnTB.Text == "")
                        {
                            u.updateSupplier(supplierID, suppliercompanyTB.Text, personnameTB.Text, phone1TB.Text, addressTB.Text,stat, null, null);
                        }
                        else
                        {
                            u.updateSupplier(supplierID, suppliercompanyTB.Text, personnameTB.Text, phone1TB.Text, addressTB.Text, stat, phone2TB.Text, ntnTB.Text);
                        }
                        r.showSuppliers(dataGridView1, suppIDGV, companyNameGV, personNameGV, phone1GV, phone2GV, addressGV, ntnGV, StatusGV);
                        MainClass.disable_reset(leftPanel);
                    }

                }
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {

                DialogResult dr = MessageBox.Show("Are you sure, you want to delete the record?", "Qusetion...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    deletion d = new deletion();
                    d.delete(supplierID, "st_deleteSupplier", "@suppID");
                    r.showSuppliers(dataGridView1, suppIDGV, companyNameGV, personNameGV, phone1GV, phone2GV, addressGV, ntnGV, StatusGV);
                }
            }
        }

        public override void searchTB_TextChanged(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showSuppliers(dataGridView1, suppIDGV, companyNameGV, personNameGV, phone1GV, phone2GV, addressGV, ntnGV, StatusGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                supplierID = Convert.ToInt32(row.Cells["suppIDGV"].Value.ToString());
                suppliercompanyTB.Text = row.Cells["companyNameGV"].Value.ToString();
                personnameTB.Text = row.Cells["personNameGV"].Value.ToString();
                phone1TB.Text = row.Cells["phone1GV"].Value.ToString();
                phone2TB.Text = row.Cells["phone2GV"].Value.ToString();
                addressTB.Text = row.Cells["addressGV"].Value.ToString();
                ntnTB.Text = row.Cells["ntnGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                MainClass.disable(leftPanel);

            }
        }
    }
}
