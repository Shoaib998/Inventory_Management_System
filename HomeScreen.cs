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
    }
}
