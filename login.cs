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
    public partial class login : Sample
    {
        public login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (uNameTB.Text == "") { nameerrorLbl.Visible = true; } else { nameerrorLbl.Visible = false; }
            if (passwordTB.Text == "") { passworderrorLbl.Visible = true; } else { passworderrorLbl.Visible = false; }
            if (nameerrorLbl.Visible || passworderrorLbl.Visible)
            {
                MainClass.ShowMSG("Fields with * is mendatory", "Stop", "Error"); // Error is the type of msg
            }
            else
            {
                if (retrieval.getUserDetails(uNameTB.Text, passwordTB.Text))
                {
                    HomeScreen hm = new HomeScreen();
                    MainClass.showWindow(hm, this, MDI.ActiveForm);
                }
                else
                {

                }         
            }                  
        }

        private void uNameTB_TextChanged(object sender, EventArgs e)
        {
            if (uNameTB.Text == "") { nameerrorLbl.Visible = true; } else { nameerrorLbl.Visible = false; }
        }

        private void passwordTB_TextChanged(object sender, EventArgs e)
        {
            if (passwordTB.Text == "") { passworderrorLbl.Visible = true; } else { passworderrorLbl.Visible = false; }
        }
    }
}
