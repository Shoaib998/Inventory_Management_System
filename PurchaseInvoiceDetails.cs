using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace IMS
{
    public partial class PurchaseInvoiceDetails : Sample2
    {
        public PurchaseInvoiceDetails()
        {
            InitializeComponent();
        }
        retrieval r = new retrieval();
        insertion i = new insertion();
        updation u = new updation();
        deletion d = new deletion();
        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            r.getListWithTwoParameters("st_getPurchaseInvoiceList", selectPurchaseInvoiceDD, "Company", "ID", "@month",datePicker.Value.Month, "@year",datePicker.Value.Year);
        }
        public override void backBtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoice obj = new PurchaseInvoice();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }

        private void PurchaseInvoiceDetails_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns =false;
            r.getListWithTwoParameters("st_getPurchaseInvoiceList", selectPurchaseInvoiceDD, "Company", "ID", "@month", datePicker.Value.Month, "@year", datePicker.Value.Year);
        }

        private void selectPurchaseInvoiceDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectPurchaseInvoiceDD.SelectedIndex != -1 && selectPurchaseInvoiceDD.SelectedIndex != 0)
            {
                float gt=0;
                r.showPurchaseInvoiceDetails(Convert.ToInt64(selectPurchaseInvoiceDD.SelectedValue.ToString()),dataGridView1, mPIDGV, proIDGV, proNameGV, quantityGV, perunitpriceGV, totalGV);
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    gt += Convert.ToSingle(row.Cells["totalGV"].Value.ToString());
                }
                grossamountLbl.Text = gt.ToString();
                gt = 0;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 6)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    DialogResult dr = MessageBox.Show("Are you sure you want to delete" + row.Cells["proNameGV"].Value.ToString()+"from purchase invoice\n\t\t\t WARNING?\n DELETION OF PRODUCT WILL EFFECT STOCK", "Question...", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                     int q;
                    if (dr == DialogResult.Yes)
                    {
                        using (TransactionScope sc = new TransactionScope())
                        {
                            i.insertDeletedItems(Convert.ToInt64(selectPurchaseInvoiceDD.SelectedIndex.ToString()), Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()), retrieval.USER_ID, DateTime.Today);

                            object ob = r.getProductQuantity(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()));
                            if (ob != null)
                            {
                                q = Convert.ToInt32(ob);
                                q -= Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                                u.updateStock(Convert.ToInt32(row.Cells["proIDGV"].Value.ToString()), q);
                                float total = Convert.ToSingle(grossamountLbl.Text) - Convert.ToSingle(row.Cells["totalGV"].Value.ToString());
                                grossamountLbl.Text = total.ToString();
                                d.delete(Convert.ToInt64( row.Cells["mPIDGV"].Value.ToString()), "st_deleteProductFromPID", "@mPID");
                                dataGridView1.Rows.Remove(row);
                            }
                            sc.Complete();
                        }
                      
                    }
                }
            }
        }
    }
    
}
