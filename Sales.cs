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
    public partial class Sales : Sample2
    {
        public Sales()
        {
            InitializeComponent();
        }
        retrieval r = new retrieval();
        float GROSS;
        string[] prodARR = new string[4];
        private void Sales_Load(object sender, EventArgs e)
        {

        }
        private void barcodeTB_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void barcodeTB_Validating(object sender, CancelEventArgs e)
        {
            if (barcodeTB.Text != "")
            {
                prodARR = r.getProductsWRTBarcode(barcodeTB.Text);
                dataGridView1.Rows.Add(Convert.ToInt32(prodARR[0]), prodARR[1], 1, Convert.ToSingle(prodARR[2]), prodARR[2]);
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    GROSS += Convert.ToSingle(row.Cells["totalGV"].Value.ToString());
                }
                grossamountLbl.Text = GROSS.ToString();
                GROSS = 0;
                barcodeTB.Focus();
                barcodeTB.Text = "";
            }
        }
    }
}
