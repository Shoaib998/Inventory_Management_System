using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    internal class retrieval
    {
        public void showUsers(DataGridView gv, DataGridViewColumn userIDGV, DataGridViewColumn NameGV, DataGridViewColumn UsernameGV, DataGridViewColumn PasswordGV, DataGridViewColumn EmailGV, DataGridViewColumn PhoneGV, DataGridViewColumn StatusGV, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getUsersData", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getUsersDataLike", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                userIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                NameGV.DataPropertyName = dt.Columns["Name"].ToString();
                UsernameGV.DataPropertyName = dt.Columns["User Name"].ToString();
                PasswordGV.DataPropertyName = dt.Columns["Password"].ToString();
                EmailGV.DataPropertyName = dt.Columns["Email"].ToString();
                PhoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                StatusGV.DataPropertyName = dt.Columns["Status"].ToString();

                gv.DataSource = dt;
            }
            catch (Exception)
            {

            }
        }
        public void showCategories(DataGridView gv, DataGridViewColumn catIDGV, DataGridViewColumn catNameGV, DataGridViewColumn StatusGV)
        {
            try
            {
                
                SqlCommand cmd = new SqlCommand("st_getCategoriesData", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                catIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                catNameGV.DataPropertyName = dt.Columns["Category"].ToString();
                StatusGV.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.ShowMSG("Unable to load categories data","Error","Error");
            }
        }
        public void getCategoriesList(string proc, ComboBox cb, string displayMember, string valueMember)
        {
            try
            {
                cb.Items.Clear();
                //cb.DataSource = null;
                //cb.Items.Insert(0, "Select...");
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();  
                dr.ItemArray = new object[] { 0, "Select..." };
                dt.Rows.InsertAt(dr, 0);
                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;
                //cb.Items.Insert(0, "Select...");
                cb.DataSource = dt;
                
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void showProducts(DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn proNameGV, DataGridViewColumn expiryGV, DataGridViewColumn catGV, DataGridViewColumn priceGV, DataGridViewColumn barcodeGV, DataGridViewColumn catIDGV)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_getProductsData", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                proNameGV.DataPropertyName = dt.Columns["Product"].ToString();
                barcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                expiryGV.DataPropertyName = dt.Columns["Expiry"].ToString();
                priceGV.DataPropertyName = dt.Columns["Price"].ToString();
                catGV.DataPropertyName = dt.Columns["Category"].ToString();
                catIDGV.DataPropertyName = dt.Columns["Category ID"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.ShowMSG("Unable to load categories data", "Error", "Error");
            }
        }

    }
}