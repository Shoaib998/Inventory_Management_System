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
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void categoryBtn_Click(object sender, EventArgs e)
        {
            categories c = new categories();
            MainClass.showWindow(c, this, MDI.ActiveForm);
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            products p = new products();
            MainClass.showWindow(p, this, MDI.ActiveForm);
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            MDI m = new MDI();
            m.logoutToolStripMenuItem.Enabled = true;
            userLbl.Text = retrieval.EMP_NAME;       
        }

        private void supplierBtn_Click(object sender, EventArgs e)
        {
            Supplier s = new Supplier();
            MainClass.showWindow(s, this, MDI.ActiveForm);
        }

        private void purchaseInvBtn_Click(object sender, EventArgs e)
        {
            PurchaseInvoice pi = new PurchaseInvoice();
            MainClass.showWindow(pi, this, MDI.ActiveForm);
        }

        private void stockBtn_Click(object sender, EventArgs e)
        {
            Stocks s = new Stocks();
            MainClass.showWindow(s, this, MDI.ActiveForm);
        }

        private void salesBtn_Click(object sender, EventArgs e)
        {
            Sales s = new Sales();
            MainClass.showWindow(s, this, MDI.ActiveForm);
        }

        private void productPricingBtn_Click(object sender, EventArgs e)
        {
            ProductPricing pp = new ProductPricing();
            MainClass.showWindow(pp, this, MDI.ActiveForm);
        }

        private void salesReturnBtn_Click(object sender, EventArgs e)
        {
            SalesReturnWindow srw = new SalesReturnWindow();
            MainClass.showWindow(srw, this, MDI.ActiveForm);
        }
    }
}
