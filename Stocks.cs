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
    public partial class Stocks : Sample2
    {
        public Stocks()
        {
            InitializeComponent();
        }
        retrieval r = new retrieval();
        private void Stocks_Load(object sender, EventArgs e)
        {
            base.addBtn.Enabled = false;
            base.saveBtn.Enabled = false;
            base.editBtn.Enabled = false;
            base.deleteBtn.Enabled = false;

        }
        public override void addBtn_Click(object sender, EventArgs e)
        {

        }

        public override void editBtn_Click(object sender, EventArgs e)
        {

        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {

        }

        public override void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        public override void searchTB_TextChanged(object sender, EventArgs e)
        {

        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showStockDetails(dataGridView1,proIDGV,proNameGV,barcodeGV,expiryGV,buyingPriceGV,sellingPriceGV,catGV,quantityGV,finalGV,StatusGV);
        }
    }
}
