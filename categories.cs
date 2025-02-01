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
    public partial class categories : Sample2
    {
        int edit = 0; //This 0 is an andication to save operation and 1 is andication to update operstion
        int catID;
        short stat;
        retrieval r = new retrieval();
        public categories()
        {
            InitializeComponent();
        }

        private void categories_Load(object sender, EventArgs e)
        {
            MainClass.disable(leftPanel);
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
            if (catogorynameTB.Text == "") { categorynameerrorLbl.Visible = true; } else { categorynameerrorLbl.Visible = false; }
            if (activeDD.SelectedIndex == -1) { isactiveerrorLbl.Visible = true; } else { isactiveerrorLbl.Visible = false; }

            if (categorynameerrorLbl.Visible || isactiveerrorLbl.Visible)
            {
                MainClass.ShowMSG("Fields with * is mendatory", "Stop", "Error"); // Error is the type of msg
            }
            else
            {

                if (activeDD.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (activeDD.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (edit == 0) // Code for SAVE Operation
                {
                    insertion i = new insertion();
                    i.insertCat(catogorynameTB.Text, stat);
                    r.showCategories(dataGridView1, catIDGV, NameGV, StatusGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1) // Cde For UPDATE Operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure, you want to update the record?", "Qusetion...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        updation u = new updation();
                        u.updateCat(catID, catogorynameTB.Text, stat);
                        r.showCategories(dataGridView1, catIDGV, NameGV, StatusGV);
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
                    d.delete(catID, "st_deleteCategory", "@id");
                    r.showCategories(dataGridView1, catIDGV, NameGV, StatusGV);
                }
            }
        }

        public override void searchTB_TextChanged(object sender, EventArgs e)
        {
            //if (searchTB.Text != "")
            //{
            //    r.showCategories(dataGridView1, catIDGV, NameGV, StatusGV, searchTB.Text);
            //}
            //else
            //{
            //    r.showCategories(dataGridView1, catIDGV, NameGV, StatusGV);
            //}
        }

        public override void viewBtn_Click(object sender, EventArgs e)
        {
            r.showCategories(dataGridView1, catIDGV, NameGV, StatusGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                catID = Convert.ToInt32(row.Cells["catIDGV"].Value.ToString());
                catogorynameTB.Text = row.Cells["NameGV"].Value.ToString();
                activeDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                MainClass.disable(leftPanel);

            }
        }
    }
}
