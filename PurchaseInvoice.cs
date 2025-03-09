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
using System.Transactions;

namespace IMS
{
    public partial class PurchaseInvoice : Sample2
    {
        public PurchaseInvoice()
        {
            InitializeComponent();
        }
        retrieval r = new retrieval();
        int productID;
        float gt, tot;
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        public override void addBtn_Click(object sender, EventArgs e)
        {

        }

        public override void editBtn_Click(object sender, EventArgs e)
        {

        }
        int co;
        updation u = new updation();
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count >0)
            {
                Int64 purchaseInvoiceID;
               insertion i = new insertion();
               using (TransactionScope sc = new TransactionScope())
              {
                  purchaseInvoiceID = i.insertPurchaseInvoice(DateTime.Today, retrieval.USER_ID, Convert.ToInt32(supplierDD.SelectedValue));

                   foreach (DataGridViewRow row in dataGridView1.Rows)
                   {
                       co += i.insertPurchaseInvoiceDetails(purchaseInvoiceID, Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()), Convert.ToSingle(row.Cells["totalGV"].Value.ToString()));
                       object[] arr = (object[])r.checkProductPriceExistance(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()));
                       if (arr[3] != null)
                       {
                            float disPercentage = Convert.ToSingle(row.Cells["perunitpriceGV"].Value.ToString()) * Convert.ToSingle(arr[3].ToString())/100;
                            float profitPercentage = Convert.ToSingle(row.Cells["perunitpriceGV"].Value.ToString()) * Convert.ToSingle(arr[4].ToString()) / 100;
                            float totalAmount = Convert.ToSingle(row.Cells["perunitpriceGV"].Value.ToString()) + profitPercentage - disPercentage;
                            u.updateProductPrice(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToSingle(row.Cells["perunitpriceGV"].Value.ToString()),totalAmount);
                       }
                       else
                       {
                           i.insertProductPrice(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToSingle(row.Cells["perunitpriceGV"].Value.ToString()));
                       }

                       int q;
                       object ob = r.getProductQuantity(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()));
                       if (ob != null)
                       {
                            q = Convert.ToInt32(ob);
                            q += Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                            u.updateStock(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), q);
                       }
                       else
                        {
                           i.insertStock(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()));
                       }

                   }
                   if (co > 0)
                   {
                       MainClass.ShowMSG("Purchase Invoice Created Successfully!", "Success", "Success");
                   }
                  else
                  {
                      MainClass.ShowMSG("Unable to create purchase Invoice!", "Error", "Error");
                  }
                  sc.Complete();
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
            PurchaseInvoiceDetails pid = new PurchaseInvoiceDetails();
            MainClass.showWindow(pid, this, MDI.ActiveForm);
        }
        private void PurchaseInvoice_Load(object sender, EventArgs e)
        {
            r.getList("st_getSupplierList", supplierDD, "Company", "ID");
        }
        string[] prodARR = new string[4];

        private void barcodeTB_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void quatityTB_TextChanged(object sender, EventArgs e)
        {
          if(quatityTB.Text != "")
            {
                if (rg.Match(quatityTB.Text).Success)
                {
                    float quan, price, tot;
                    quan = Convert.ToSingle(quatityTB.Text);
                    price = Convert.ToSingle(perunitpiceTB.Text);
                    tot = quan * price;
                    amoutLbl.Text = tot.ToString("############.##");
                }
                else
                {
                    quatityTB.SelectAll();
                }
            }
          else
            {
                amoutLbl.Text = "0.00";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 5)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    gt -= Convert.ToSingle(row.Cells["totalGV"].Value.ToString());
                    grossamountLbl.Text = gt.ToString();
                    dataGridView1.Rows.Remove(row);
                }
            }
        }

        private void perunitpiceTB_TextChanged(object sender, EventArgs e)
        {
            if (perunitpiceTB.Text != "")
            {
                if (!rg.Match(perunitpiceTB.Text).Success)
                {
                    perunitpiceTB.Text = "";
                    perunitpiceTB.Focus();
                }
            }
        }

        private void barcodeTB_Validating(object sender, CancelEventArgs e)
        {
            if (barcodeTB.Text != "")
            {
                prodARR = r.getProductsWRTBarcode(barcodeTB.Text);
                productID = Convert.ToInt32(prodARR[0]);
                productnameTB.Text = prodARR[1];
                string barcode = prodARR[2];
                productnameTB.Enabled = false;
                if (barcode != null)
                {
                    perunitpiceTB.Focus();
                }
            }
            else
            {
                productID = 0;
                productnameTB.Text = "";
                perunitpiceTB.Text = "";
                Array.Clear(prodARR, 0, prodARR.Length);
            }
        }

        private void addtocartBtn_Click(object sender, EventArgs e)
        {      
           if (supplierDD.SelectedIndex == -1) { suppliererrorLbl.Visible = true; } else { suppliererrorLbl.Visible = false; }
           if (quatityTB.Text == "") { quantityerrorLbl.Visible = true; } else { quantityerrorLbl.Visible = false; }
           if (barcodeTB.Text == "") { barcodeerrorLbl.Visible = true; } else { barcodeerrorLbl.Visible = false; }

           if (suppliererrorLbl.Visible || quantityerrorLbl.Visible || barcodeerrorLbl.Visible)
           {
             MainClass.ShowMSG("Fields with * is mendatory", "Stop", "Error"); // Error is the type of msg
           }
           else
            {    
                dataGridView1.Rows.Add(productID, productnameTB.Text, quatityTB.Text, perunitpiceTB.Text, amoutLbl.Text);
                gt += Convert.ToSingle(amoutLbl.Text);
                grossamountLbl.Text = gt.ToString();
                productID = 0;
                productnameTB.Text = "";
                perunitpiceTB.Text = "";
                barcodeTB.Text = "";
                amoutLbl.Text = "0.00";
                quatityTB.Text = "";
                Array.Clear(prodARR, 0, prodARR.Length);
            }
        }   
    }
}
