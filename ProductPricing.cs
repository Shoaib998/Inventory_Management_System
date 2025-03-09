using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class ProductPricing : Sample2
    {
        retrieval r = new retrieval();
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        updation u = new updation();
        public ProductPricing()
        {
            InitializeComponent();
            r.getList("st_getCategoriesList", categoryDD, "Category", "ID");
        }

        private void categoryDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryDD.SelectedIndex != -1 && categoryDD.SelectedIndex != 0)
            {
                r.showProductWRTCategory(Convert.ToInt32(categoryDD.SelectedValue.ToString()), dataGridView1, proIDGV, proNameGV, buyingPriceGV, finalPriceGV, discountGV, profitMarginGV);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (row.Cells["profitMarginGV"].Value != null && rg.Match(row.Cells["profitMarginGV"].Value.ToString()).Success)
                {
                    float buyingPrice = Convert.ToSingle(row.Cells["buyingPriceGV"].Value.ToString());
                    float profitMargin = Convert.ToSingle(row.Cells["profitMarginGV"].Value.ToString()) / 100;
                    float amountToIncrease = profitMargin * buyingPrice;
                   
                    float finalSellingPrice = buyingPrice + amountToIncrease;
                    float discountPercentage;

                    if (row.Cells["discountGV"].Value != null && rg.Match(row.Cells["discountGV"].Value.ToString()).Success)
                    {
                        discountPercentage = finalSellingPrice * (Convert.ToSingle(row.Cells["discountGV"].Value.ToString()) / 100);
                    }
                    else
                    {
                        discountPercentage = 0;
                    }
                    row.Cells["finalPriceGV"].Value = finalSellingPrice - discountPercentage;
                }
                else
                {
                    row.Cells["finalPriceGV"].Value = null;
                    row.Cells["discountGV"].Value = null;
                    row.Cells["profitMarginGV"].Value = null;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
          if (dataGridView1.CurrentCell.ColumnIndex == 4)
          {
             dataGridView1.BeginEdit(true);
          }
   
        }

        public override void addBtn_Click(object sender, EventArgs e)
        {

        }

        public override void editBtn_Click(object sender, EventArgs e)
        {

        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            int check = 0;
            if (categoryDD.SelectedIndex != -1 && categoryDD.SelectedIndex != 0)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if ((bool)row.Cells["selectGV"].FormattedValue == true)
                    {
                        check++;
                        float discount, profitMargin, buyingPrice, sellingPrice;
                        Int64 proID;
                        proID = Convert.ToInt32(row.Cells["proIDGV"].Value.ToString());
                        object[] arr = r.checkProductPriceExistance(proID);
                        buyingPrice = Convert.ToSingle(row.Cells["buyingPriceGV"].Value.ToString());
                        discount = row.Cells["discountGV"].Value == null ? 0 : Convert.ToSingle(row.Cells["discountGV"].Value.ToString());
                        profitMargin = row.Cells["profitMarginGV"].Value == null ? 0 : Convert.ToSingle(row.Cells["profitMarginGV"].Value.ToString());
                        if (discount == 0 && profitMargin == 0)
                        {
                            sellingPrice = buyingPrice;
                        }
                        else
                        {
                            sellingPrice = Convert.ToSingle(row.Cells["finalPriceGV"].Value.ToString());
                        }
                        if (arr.Length > 0)
                        {
                            u.updateProductPrice(proID, buyingPrice, sellingPrice, discount, profitMargin);
                        }
                       // u.updateProductPrice(proID, buyingPrice, sellingPrice,discount, profitMargin);    ye yahan tha me isko uper likh raha hun check krny k leye                   
                    }
                }
                if (check > 0)
                {
                    MainClass.ShowMSG("Product Pricing Updated Successfully...", "Success", "Success");
                    check = 0;
                }
                else
                {
                    MainClass.ShowMSG("Please select any product first...", "Error", "Error");
                    check = 0;
                } 
            }
        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public override void searchTB_TextChanged(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {

        }

        private void ProductPricing_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
