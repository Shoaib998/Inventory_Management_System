using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace IMS
{
    public partial class SalesReturnWindow : Sample2
    {
        public SalesReturnWindow()
        {
            InitializeComponent();
        }
        retrieval r = new retrieval();
        Regex rg = new Regex("^[0-9]+$");
        Hashtable ht = new Hashtable();
        insertion i = new insertion();
        updation u  = new updation();

        private void enterSalesIDTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            if (enterSalesIDTB.Text != "")
            {
                if (rg.Match(enterSalesIDTB.Text).Success)
                {
                    r.showSalesDataViaID(Convert.ToInt64(enterSalesIDTB.Text), dataGridView1, salesIDGV, barcodeGV, productGV, quantityGV, proPriceGV, perProductDiscountGV,
                        perProductTotalGV, totalDiscountGV, totalAmountGV, amountGivenGV, amountReturnedGV, dateGV, userGV, paymentTypeGV, proIDGV,productDiscount);
                    if (dataGridView1.RowCount > 0)
                    {                    
                        dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[0].Cells["dateGV"].Value);
                        UserTB.Text = dataGridView1.Rows[0].Cells["userGV"].Value.ToString();
                        payTypeTB.Text = dataGridView1.Rows[0].Cells["paymentTypeGV"].Value.ToString();
                    }
                }
                else
                {
                    enterSalesIDTB.Text = "";
                    enterSalesIDTB.Focus();
                    dateTimePicker1.Value = DateTime.Now;
                    UserTB.Text = "";
                    payTypeTB.Text = "";
                }
            }
            else
            {
                dateTimePicker1.Value = DateTime.Now;
                UserTB.Text = "";
                payTypeTB.Text = "";
            }
        }
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (AmountToRefundTB.Text != "" && ht.Count> 0 && enterSalesIDTB.Text != "")
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to Proceed?", "Question", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (TransactionScope sc  = new TransactionScope())
                    {
                        int x = 0;
                        foreach (DictionaryEntry de in ht)
                        {
                            x += i.insertRefundReturn(Convert.ToInt64(enterSalesIDTB.Text),DateTime.Now, retrieval.USER_ID,Convert.ToInt64(de.Key),Convert.ToInt16(de.Value),Convert.ToInt32(de.Value)); //Convert.ToInt32("proPriceGV")
                            int currentQuantity = (int)r.getProductQuantity(Convert.ToInt64(de.Key));
                            int finalQuantity = currentQuantity - Convert.ToInt16(de.Value);
                            u.updateStock(Convert.ToInt64(de),finalQuantity);
                        }
                        if (x > 0)
                        {
                            DialogResult drr = MainClass.ShowMSG("Return and Refund Successfull", "Success", "Success");
                            if (drr == DialogResult.Yes)
                            {
                                SalesReturnReceiptWindow obj = new SalesReturnReceiptWindow();
                                obj.ShowDialog();
                            }
                            x = 0;
                            ht.Clear();
                        }
                        sc.Complete();
                    }
                }
            }
            else
            {
                MainClass.ShowMSG("Please Provide Complete details", "Error", "Error");
            }
        }
        float amount_refund = 0;
        private void enterBarcodeTB_Validating(object sender, CancelEventArgs e)
        {
            if (enterBarcodeTB.Text != "")
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    using (TransactionScope sc = new TransactionScope())
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (enterBarcodeTB.Text == row.Cells["barcodeGV"].Value.ToString())
                            {
                                DialogResult dr = MessageBox.Show("Are you sure you want to return " + row.Cells["productGV"].Value.ToString() + "?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (dr == DialogResult.Yes)
                                {
                                    Int64 product_id = Convert.ToInt64(row.Cells["proIDGV"].Value.ToString());
                                    float product_price = Convert.ToSingle(row.Cells["proPriceGV"].Value.ToString());

                                    int product_quantity = Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()) -1;
                                    amount_refund += product_price;

                                    AmountToRefundTB.Text = Math.Round(amount_refund, 0).ToString();
                                    if (product_quantity == 0)
                                    {
                                        if (ht.ContainsKey(row.Cells["proIDGV"].Value))
                                        {
                                            Int64 proIDht = Convert.ToInt64(row.Cells["proIDGV"].Value.ToString());
                                            ht[proIDht] = Convert.ToInt32(ht[proIDht])-1;
                                        }
                                        else
                                        {
                                            ht.Add(row.Cells["proIDGV"].Value, 1);
                                        }
                                        dataGridView1.Rows.Remove(row);
                                    }
                                    else
                                    {
                                        row.Cells["quantityGV"].Value = product_quantity;
                                        row.Cells["perProductTotalGV"].Value = (Convert.ToSingle(row.Cells["proPriceGV"].Value.ToString()) * Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()));
                                        if (ht.ContainsKey(row.Cells["proIDGV"].Value))
                                        {
                                            Int64 proIDht = Convert.ToInt64(row.Cells["proIDGV"].Value.ToString());
                                            ht[proIDht] = Convert.ToInt32(ht[proIDht]) + 1;
                                        }
                                        else
                                        {
                                            ht.Add(row.Cells["proIDGV"].Value, 1);
                                        }
                                    }
                                }
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
