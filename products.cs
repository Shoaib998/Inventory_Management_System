using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IMS
{
    public partial class products : Sample2
    {
        int edit = 0; //This 0 is an andication to save operation and 1 is andication to update operstion
        int prodID;
        public products()
        {
            InitializeComponent();
        }
        retrieval r = new retrieval();
        private void products_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
            r.getCategoriesList("st_getCategoriesList", categoryDD, "Category", "ID");
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
            if (productTB.Text == "") { productnameLbl.Visible = true; } else { productnameLbl.Visible = false; }
            if (barcodeTB.Text == "") { barcodeerrorLbl.Visible = true; } else { barcodeerrorLbl.Visible = false; }
            if (expiryPicker.Value < DateTime.Now) { expiryerrorLbl.Visible = true; expiryerrorLbl.Text = "Invalid Date"; } else { expiryerrorLbl.Visible = false; }
            if(expiryPicker.Value.Date == DateTime.Now.Date) { expiryerrorLbl.Visible = false; }
            if (priceTB.Text == "") { priceerrorLbl.Visible = true; } else { priceerrorLbl.Visible = false; }
            if (categoryDD.SelectedIndex == -1 || categoryDD.SelectedIndex == 0) { categoryerrorLbl.Visible = true; } else { categoryerrorLbl.Visible = false; }

            if (productnameerrorLbl.Visible || barcodeerrorLbl.Visible || expiryerrorLbl.Visible || priceerrorLbl.Visible || categoryerrorLbl.Visible)
            {
                MainClass.ShowMSG("Fields with * is mendatory", "Stop", "Error"); // Error is the type of msg
            }
            else
            {
                if (edit == 0) // Code for SAVE Operation
                {
                    insertion i = new insertion();
                    if (expiryPicker.Value.Date == DateTime.Now.Date)
                    {
                        i.insertProduct(productTB.Text, barcodeTB.Text, Convert.ToSingle(priceTB.Text), Convert.ToInt32(categoryDD.SelectedValue));
                    }
                    else
                    {
                        i.insertProduct(productTB.Text, barcodeTB.Text, Convert.ToSingle(priceTB.Text), Convert.ToInt32(categoryDD.SelectedValue), expiryPicker.Value);
                    }
                    r.showProducts(dataGridView1, proIDGV, proNameGV, expiryGV, catGV, priceGV, barcodeGV, catIDGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1) // Cde For UPDATE Operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to update the record?", "Qusetion...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        updation u = new updation();
                        if (expiryPicker.Value.Date == DateTime.Now.Date)
                        {
                            u.updateProduct(prodID, productTB.Text, barcodeTB.Text, Convert.ToSingle(priceTB.Text), Convert.ToInt32(categoryDD.SelectedValue));
                        }
                        else
                        {
                            u.updateProduct(prodID, productTB.Text, barcodeTB.Text, Convert.ToSingle(priceTB.Text), Convert.ToInt32(categoryDD.SelectedValue), expiryPicker.Value);
                        }
                        r.showProducts(dataGridView1, proIDGV, proNameGV, expiryGV, catGV, priceGV, barcodeGV, catIDGV);
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
                    d.delete(prodID, "st_productDelete", "@proID");
                    r.showProducts(dataGridView1, proIDGV, proNameGV, expiryGV, catGV, priceGV, barcodeGV, catIDGV);
                }
            }
        }

        public override void searchTB_TextChanged(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showProducts(dataGridView1, proIDGV, proNameGV, expiryGV, catGV, priceGV, barcodeGV, catIDGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                prodID = Convert.ToInt32(row.Cells["proIDGV"].Value.ToString());
                productTB.Text = row.Cells["proNameGV"].Value.ToString();
                barcodeTB.Text = row.Cells["barcodeGV"].Value.ToString();
                priceTB.Text = row.Cells["priceGV"].Value.ToString();
                if (row.Cells["expiryGV"].FormattedValue.ToString()  == "")
                {
                    expiryPicker.Value = DateTime.Now;
                }
                else
                {
                    expiryPicker.Value = Convert.ToDateTime(row.Cells["expiryGV"].Value.ToString());
                }
                categoryDD.SelectedValue = row.Cells["catIDGV"].Value.ToString();
                MainClass.disable(leftPanel);

            }
        }
    }
}
