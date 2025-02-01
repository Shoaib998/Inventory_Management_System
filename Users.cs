using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class Users : Sample2
    {
        int edit = 0; //This 0 is an andication to save operation and 1 is andication to update operstion
        int userID;
        short stat;
        public Users()
        {
            InitializeComponent();
        }
        retrieval r = new retrieval();

        private void Users_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
           
        }
        public override void addBtn_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftPanel);
            edit = 0;
        }

        public override void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(leftPanel);
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (nameTB.Text == "") { nameerrorLbl.Visible = true; } else { nameerrorLbl.Visible = false; }
            if (usernameTB.Text == "") { usernameerrorLbl.Visible = true; } else { usernameerrorLbl.Visible = false; }
            if (passwordTB.Text == "") { passworderrorLbl.Visible = true; } else { passworderrorLbl.Visible = false; }
            if (phoneTB.Text == "") { phoneerrorLbl.Visible = true; } else { phoneerrorLbl.Visible = false; }
            if (emailTB.Text == "") { emailerrorLbl.Visible = true; } else { emailerrorLbl.Visible = false; }
            if (statusDD.SelectedIndex == -1) { statuserrorLbl.Visible = true; } else { statuserrorLbl.Visible = false; }

            if (nameerrorLbl.Visible || usernameerrorLbl.Visible || passworderrorLbl.Visible || phoneerrorLbl.Visible || emailerrorLbl.Visible || statuserrorLbl.Visible )
            {
                MainClass.ShowMSG("Fields with * is mendatory", "Stop", "Error"); // Error is the type of msg
            }
            else
            {
               
                if (statusDD.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (statusDD.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (edit == 0) // Code for SAVE Operation
                {
                    
                    insertion i = new insertion();

                    i.insertUser(nameTB.Text, usernameTB.Text, passwordTB.Text, phoneTB.Text, emailTB.Text, stat);
                    r.showUsers(dataGridView1, userIDGV, NameGV, UsernameGV, PasswordGV, EmailGV, PhoneGV, StatusGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if(edit == 1) // Cde For UPDATE Operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to update the record?", "Qusetion...", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        updation u = new updation();
                        u.updateUser(userID, nameTB.Text, usernameTB.Text, passwordTB.Text, phoneTB.Text, emailTB.Text, stat);
                        r.showUsers(dataGridView1, userIDGV, NameGV, UsernameGV, PasswordGV, EmailGV, PhoneGV, StatusGV);
                        MainClass.disable_reset(leftPanel);
                    }
                   
                }
            }
        }
        public override void deleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {

                DialogResult dr = MessageBox.Show("Are you sure, you want to delete the record?", "Qusetion...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    deletion d = new deletion();
                    d.delete(userID, "st_deleteUser", "@id");
                    r.showUsers(dataGridView1, userIDGV, NameGV, UsernameGV, PasswordGV, EmailGV, PhoneGV, StatusGV);
                }       
            }
        }

        public override void searchTB_TextChanged(object sender, EventArgs e)
        {
            if(searchTB.Text != "")
            {
                r.showUsers(dataGridView1, userIDGV, NameGV, UsernameGV, PasswordGV, EmailGV, PhoneGV, StatusGV,searchTB.Text);
            }
            else
            {
                r.showUsers(dataGridView1, userIDGV, NameGV, UsernameGV, PasswordGV, EmailGV, PhoneGV, StatusGV);
            }
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showUsers(dataGridView1, userIDGV, NameGV, UsernameGV, PasswordGV, EmailGV, PhoneGV, StatusGV);
        }

        private void nameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                userID = Convert.ToInt32(row.Cells["userIDGV"].Value.ToString());
                nameTB.Text = row.Cells["NameGV"].Value.ToString();
                usernameTB.Text = row.Cells["UsernameGV"].Value.ToString();
                passwordTB.Text = row.Cells["PasswordGV"].Value.ToString();
                phoneTB.Text = row.Cells["PhoneGV"].Value.ToString();
                emailTB.Text = row.Cells["EmailGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                MainClass.disable(leftPanel);

            }
        }
    }
}
