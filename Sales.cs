using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class Sales : Sample2
    {
        public Sales()
        {
            InitializeComponent();
        }
        retrieval r = new retrieval();
        insertion i = new insertion();
        float GROSS = 0;
        string[] prodARR = new string[6];
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        private void Sales_Load(object sender, EventArgs e)
        {

        }
        private void barcodeTB_TextChanged(object sender, EventArgs e)
        {
          
        }
        public override void viewBtn_Click(object sender, EventArgs e)
        {
            viewSalesInvoices vsi = new viewSalesInvoices();
            MainClass.showWindow(vsi, this, MDI.ActiveForm);
        }
        bool productCheck;
        private void barcodeTB_Validating(object sender, CancelEventArgs e)
        {
            if (barcodeTB.Text != "")
            {
                grossTotalTB.Text = "";
                totalDiscountTB.Text = "";
                amountGivenTB.Text = "";
                changeToGiveTB.Text = "";
                int qCount = 0, sQuant = 0, nCount = 0;
                prodARR = r.getProductsWRTBarcode(barcodeTB.Text);
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    if (prodARR[0] == row.Cells["proIDGV"].Value.ToString())
                    {
                        qCount = qCount + Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                    }
                }
                sQuant = Convert.ToInt32( r.getProductQuantity(Convert.ToInt64(prodARR[0])));
                //remainingStockTB.Text = (sQuant -1).ToString();
                nCount = sQuant - qCount;
                if (nCount <= 0)
                {

                }
                else
                {
                    if (dataGridView1.Rows.Count == 0)
                    {
                        dataGridView1.Rows.Add(Convert.ToInt32(prodARR[0]), prodARR[1], 1, Convert.ToSingle(prodARR[3]), Math.Round(Convert.ToSingle( prodARR[4]),2), Convert.ToSingle(prodARR[3]));
                    }
                    else
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["proIDGV"].Value.ToString() == prodARR[0])
                            {
                                productCheck = true;
                                break;
                            }
                            else
                            {
                                productCheck = false;
                                // dataGridView1.Rows.Add(Convert.ToInt32(prodARR[0]), prodARR[1], 1, Convert.ToSingle(prodARR[3]), prodARR[4], Convert.ToSingle(prodARR[5]));
                            }

                        }
                        if (productCheck == true)
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Cells["proIDGV"].Value.ToString() == prodARR[0])
                                {
                                    float disc = 0;
                                    row.Cells["quantityGV"].Value = Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()) + 1;
                                    if (row.Cells["discountGV"].Value.ToString() != null)
                                    {
                                        disc = Convert.ToSingle(prodARR[4]) * Convert.ToSingle(row.Cells["quantityGV"].Value.ToString());
                                        row.Cells["discountGV"].Value = Math.Round( disc,2);
                                    }
                                    float tot = (Convert.ToSingle(row.Cells["perunitpriceGV"].Value.ToString()) * Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()));
                                    row.Cells["totalGV"].Value = tot;
                                }

                            }
                        }
                        else
                        {
                            dataGridView1.Rows.Add(Convert.ToInt32(prodARR[0]), prodARR[1], 1, Convert.ToSingle(prodARR[3]), Math.Round(Convert.ToSingle(prodARR[4]), 2), Convert.ToSingle(prodARR[3]));
                        }
                    }

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        GROSS += Convert.ToSingle(row.Cells["totalGV"].Value.ToString());
                    }
                    grossamountLbl.Text = Math.Round(GROSS,2).ToString();
                    GROSS = 0;
                    barcodeTB.Focus();
                    barcodeTB.Text = "";
                }
                
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 6)
                {
                    grossTotalTB.Text = "";
                    totalDiscountTB.Text = "";
                    amountGivenTB.Text = "";
                    changeToGiveTB.Text = "";
                    float gt, tot, dis;
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    int q = Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                    if (q == 1)
                    {
                        float itemTotal = Convert.ToSingle(row.Cells["totalGV"].Value.ToString());
                        float itemDiscount = Convert.ToSingle(row.Cells["discountGV"].Value.ToString());

                        // Update Gross Total
                        gt = Convert.ToSingle(grossamountLbl.Text) - itemTotal;
                        grossamountLbl.Text = Math.Ceiling(gt).ToString();

                        // Update Discount Total
                        float currentDiscount = string.IsNullOrWhiteSpace(totalDiscountTB.Text) ? 0 : Convert.ToSingle(totalDiscountTB.Text);

                        currentDiscount -= itemDiscount;
                        totalDiscountTB.Text = currentDiscount.ToString();

                        dataGridView1.Rows.Remove(row);
                        
                        // ye youtube wala 18no.video code hai uper gpt
                        //gt = Convert.ToSingle(grossamountLbl.Text);
                        //gt = gt - Convert.ToSingle(row.Cells["totalGV"].Value.ToString());
                        //grossamountLbl.Text = gt.ToString();
                        //dataGridView1.Rows.Remove(row);
                    }
                    else
                    {
                        q--;
                        row.Cells["quantityGV"].Value = q;

                        // Get Per Unit Discount
                        float unitDiscount = Convert.ToSingle(row.Cells["discountGV"].Value.ToString()) / (q + 1);

                        // Subtract from total discount
                        dis = Convert.ToSingle(row.Cells["discountGV"].Value.ToString()) - unitDiscount;
                        row.Cells["discountGV"].Value = dis;

                        // Calculate new total
                        tot = (Convert.ToSingle(row.Cells["quantityGV"].Value.ToString()) * Convert.ToSingle(row.Cells["perunitpriceGV"].Value.ToString()));
                        row.Cells["totalGV"].Value = tot;

                        // Update Gross Amount
                        foreach (DataGridViewRow item in dataGridView1.Rows)
                        {
                            GROSS += Convert.ToSingle(item.Cells["totalGV"].Value.ToString());
                        }
                        grossamountLbl.Text = Math.Ceiling(GROSS).ToString();
                        GROSS = 0;

                        //ye youtube wala code 18 no.video hai upder wala gpt
                        //q--;
                        //row.Cells["quantityGV"].Value = q;
                        //dis = Convert.ToSingle(row.Cells["discountGV"].Value.ToString()) - Convert.ToSingle(prodARR[4]);
                        //row.Cells["discountGV"].Value = dis;
                        //tot = Convert.ToSingle(row.Cells["quantityGV"].Value.ToString()) * Convert.ToSingle(row.Cells["perunitpriceGV"].Value.ToString());
                        //row.Cells["totalGV"].Value = tot;
                        //foreach (DataGridViewRow item in dataGridView1.Rows)
                        //{
                        //    GROSS += Convert.ToSingle(item.Cells["totalGV"].Value.ToString());
                        //}
                        //grossamountLbl.Text = Math.Round (GROSS,0).ToString();
                        //GROSS = 0;
                    }
                }
            }
        }

        private void checkOutBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                double dis = 0, gross = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dis += Convert.ToSingle(row.Cells["discountGV"].Value.ToString());
                    gross += Convert.ToSingle(row.Cells["totalGV"].Value.ToString());
                }
                grossTotalTB.Text = Math.Round(gross, 0).ToString();
                totalDiscountTB.Text = dis.ToString();
            }
        }

        private void amountGivenTB_TextChanged(object sender, EventArgs e)
        {
            if (amountGivenTB.Text != "")
            {
                if (!rg.Match(amountGivenTB.Text).Success)
                {
                    amountGivenTB.Text = "";
                    amountGivenTB.Focus();
                }
                else
                {
               
                }
            }
            else
            {
                changeToGiveTB.Text = "";
            }
        }

        private void amountGivenTB_Validating(object sender, CancelEventArgs e)
        {
            if(amountGivenTB.Text != "" && grossTotalTB.Text != "")
            {
                if (!(Convert.ToSingle(grossTotalTB.Text) <= Convert.ToSingle(amountGivenTB.Text)))
                {
                    amountGivenTB.Text = "";
                    changeToGiveTB.Text = "";
                    amountGivenTB.Focus();
                }
                else
                {
                    float amountGiven = Convert.ToSingle(amountGivenTB.Text);
                    float amounttoreturn = amountGiven - Convert.ToSingle(grossTotalTB.Text);
                    changeToGiveTB.Text = Math.Ceiling(amounttoreturn).ToString();
                }
            }
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            if (grossTotalTB.Text != "" && totalDiscountTB.Text != "" && paymnetTypeDD.SelectedIndex != -1 && amountGivenTB.Text != "" && changeToGiveTB.Text != "")
            {
                DialogResult dr = MessageBox.Show("\n\t Total Amount : "+ grossTotalTB.Text+ "\n\t Total Discount : "+totalDiscountTB.Text+ "\n\t Amount Given : "+amountGivenTB.Text+ "\n\t Amount to Return :"+changeToGiveTB.Text+ "\n\n Are you sure, to Save Current Sales?\n", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    i.insertSales(dataGridView1, "proIDGV", "quantityGV", "perunitpriceGV", "discountGV", retrieval.USER_ID, DateTime.Now, Convert.ToSingle(grossTotalTB.Text), Convert.ToSingle(totalDiscountTB.Text), Convert.ToSingle(amountGivenTB.Text), Convert.ToSingle(changeToGiveTB.Text),paymnetTypeDD.SelectedItem.ToString());
                    MainClass.enable_reset(paymentGB);
                    dataGridView1.Rows.Clear();
                    grossamountLbl.Text = "0.00";
                    SalesReport sr = new SalesReport();
                    sr.Show();
                }
                
            }
        }
    }
}
