using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                r.showPurchaseInvoiceDetails(Convert.ToInt64(selectPurchaseInvoiceDD.SelectedValue.ToString()),dataGridView1, proIDGV, proNameGV, quantityGV, perunitpriceGV, totalGV);
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    gt += Convert.ToSingle(row.Cells["totalGV"].Value.ToString());
                }
                grossamountLbl.Text = gt.ToString();
                gt = 0;
            }
        }
    }
    
}
