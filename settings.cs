using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class settings : Sample
    {
        public settings()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string s;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if(ISCB.Checked)
            {
                if (serverTB.Text != "" && dbTB.Text != "")
                {
                    s = "Data Source=" + serverTB.Text + ";Initial Catalog=" + dbTB.Text + ";Integrated Security=true;MultipleActiveResultSets=true;";
                    File.WriteAllText(path+"\\connect", s);
                    DialogResult dr = MessageBox.Show("Settings Save Successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        login login = new login();
                        MainClass.showWindow(login, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please give complete data to continue...");
                }
            }
            else
            {
                if (serverTB.Text != "" && dbTB.Text != "" && useridTB.Text != "" && passwordTB.Text != "")
                {
                    s = "Data Source=" + serverTB.Text + ";Initial Catalog=" + dbTB.Text + ";User Id=" + useridTB.Text + ";Password=" + passwordTB.Text + ";MultipleActiveResultSets=true;";
                    File.WriteAllText(path+"\\connect", s);
                    DialogResult dr = MessageBox.Show("Settings Save Successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        login login = new login();
                        MainClass.showWindow(login, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please give complete data to continue...");
                }
            }
           
            
        }

        private void ISCB_CheckedChanged(object sender, EventArgs e)
        {
            if (ISCB.Checked)
            {
                useridTB.Enabled = false;
                passwordTB.Enabled = false;
                useridTB.Text = "";
                passwordTB.Text = "";
            }
            else
            {
                useridTB.Enabled = true;
                passwordTB.Enabled = true;
            }
        }
    }
}
