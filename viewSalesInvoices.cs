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
    public partial class viewSalesInvoices : Sample
    {
        public viewSalesInvoices()
        {
            InitializeComponent();
        }
        retrieval r = new retrieval();
        private void loadBtn_Click(object sender, EventArgs e)
        {
            r.showDailySales(dateTimePicker1.Value, dataGridView1, saleIDGV, UserGV, totAmtGV, totDisGV, amtGivenGV, amtReturnedGV,userIDGV);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["totAmtGV"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["totAmtGV"].Value));
                row.Cells["totDisGV"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["totDisGV"].Value));
                row.Cells["amtGivenGV"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["amtGivenGV"].Value));
                row.Cells["amtReturnedGV"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["amtReturnedGV"].Value));
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Sales s = new Sales();
            MainClass.showWindow(s, this, MDI.ActiveForm);
        }
        public static int salesID = 0;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                salesID = Convert.ToInt32(row.Cells["saleIDGV"].Value.ToString());
                SalesReport sr = new SalesReport();
                sr.Show();
            }
        }
    }
}
