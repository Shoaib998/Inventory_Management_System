﻿using System;
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
        public static int USER_ID
        {
            get;
            private set;
        }
        public static string EMP_NAME
        {
            get;
            private set;
        }
        private static string user_name=null, pass_word=null;
        private static bool checkLogin;
        public static bool getUserDetails(string username, string password)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getUserDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@password", password);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    checkLogin = true;
                    while (dr.Read())
                    {
                        USER_ID = Convert.ToInt32(dr["ID"].ToString());
                        EMP_NAME = dr["Name"].ToString();
                        user_name = dr["User Name"].ToString();
                        pass_word = dr["Password"].ToString();
                    }

                }
                else
                {
                    checkLogin = false;
                    if(username != null && password != null)
                    {
                        if (user_name != null && pass_word == password)
                        {
                            MainClass.ShowMSG("Invalid username", "Error", "Error");
                        }
                        else if (user_name == null && pass_word != password)
                        {
                            MainClass.ShowMSG("Invalid password", "Error", "Error");
                        }
                        else if (user_name != null && pass_word != password)
                        {
                            MainClass.ShowMSG("Invalid User Name and Password", "Error", "Error");
                        }
                    }
                }
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
                MainClass.ShowMSG("Uable to login", "Error", "Error");
            }
            return checkLogin;
        }
        public void showSuppliers(DataGridView gv, DataGridViewColumn suppIDGV, DataGridViewColumn companyNameGV, DataGridViewColumn personNameGV,
            DataGridViewColumn phone1GV, DataGridViewColumn phone2GV, DataGridViewColumn addressGV, DataGridViewColumn ntnGV, DataGridViewColumn StatusGV)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_getSupplierData", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                suppIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                companyNameGV.DataPropertyName = dt.Columns["Company"].ToString();
                personNameGV.DataPropertyName = dt.Columns["Person Name"].ToString();
                phone1GV.DataPropertyName = dt.Columns["Phone 1"].ToString();
                phone2GV.DataPropertyName = dt.Columns["Phone 2"].ToString();
                addressGV.DataPropertyName = dt.Columns["Address"].ToString();
                ntnGV.DataPropertyName = dt.Columns["NTN #"].ToString();
                StatusGV.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.ShowMSG("Unable to load Suppliers data", "Error", "Error");
            }
        }
    }
}