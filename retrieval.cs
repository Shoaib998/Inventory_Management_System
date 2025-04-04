﻿using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
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
        public void getList(string proc, ComboBox cb, string displayMember, string valueMember)
        {
            try
            {
                
                cb.DataSource = null;

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
         
                cb.DataSource = dt;
                
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void getListWithTwoParameters(string proc, ComboBox cb, string displayMember, string valueMember, string param1, object val1, string param2, object val2)
        {
            try
            {
              
                cb.DataSource = null;

                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param1, val1);
                cmd.Parameters.AddWithValue(param2, val2);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select..." };
                dt.Rows.InsertAt(dr, 0);
                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;

                cb.DataSource = dt;

            }
            catch (Exception)
            {
            
            }
        }
        public void showProducts(DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn proNameGV, DataGridViewColumn expiryGV, DataGridViewColumn catGV, DataGridViewColumn barcodeGV, DataGridViewColumn catIDGV)
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
        private string[] productsData = new string[6];
        public string[] getProductsWRTBarcode(string barcode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductByBarcode", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", barcode);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    while (dr.Read())
                    {
                        productsData[0] = dr[0].ToString(); //product ID
                        productsData[1] = dr[1].ToString(); //product
                        productsData[2] = dr[2].ToString(); //barcode
                        productsData[3] = dr[3].ToString(); // selling price
                        productsData[4] = dr[4].ToString(); // discount
                        productsData[5] = dr[5].ToString(); //final selling price
                    }
                }
                else
                {
                    Array.Clear(productsData,0, productsData.Length);
                }
                MainClass.con.Close();
            }
            catch (Exception)
            {
                MainClass.con.Close();
                throw;
            }
            return productsData;
        }
        private object productStockCount = 0;
        public object getProductQuantity(Int64 proID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductQuantity", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
               
                MainClass.con.Open();
                productStockCount = cmd.ExecuteScalar();
                MainClass.con.Close();
            }
            catch (Exception)
            {
               
            }
            return productStockCount;
        }
        public void showPurchaseInvoiceDetails(Int64 pid, DataGridView gv,DataGridViewColumn mPIDGV, DataGridViewColumn proIDGV, DataGridViewColumn proNameGV, DataGridViewColumn quantityGV, DataGridViewColumn perunitpriceGV, DataGridViewColumn totalGV)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_getPurchaseInvoiceDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pid", pid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                mPIDGV.DataPropertyName = dt.Columns["mPID"].ToString();
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                proNameGV.DataPropertyName = dt.Columns["Product Name"].ToString();
                quantityGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                perunitpriceGV.DataPropertyName = dt.Columns["Per Unit Price"].ToString();
                totalGV.DataPropertyName = dt.Columns["Total Price"].ToString();
        
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.ShowMSG("Unable to load Invoice Details data", "Error", "Error");
            }
        }
        public void showStockDetails(DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn proNameGV, DataGridViewColumn barcodeGV,
          DataGridViewColumn expiryGV, DataGridViewColumn bpGV, DataGridViewColumn spGV, DataGridViewColumn catGV, DataGridViewColumn availStGV,DataGridViewColumn totalAmountGV, DataGridViewColumn StatusGV)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_getAllStock", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                proIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                proNameGV.DataPropertyName = dt.Columns["Product Name"].ToString();
                barcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                expiryGV.DataPropertyName = dt.Columns["Expiry Date"].ToString();
                bpGV.DataPropertyName = dt.Columns["Buying Price"].ToString();
                spGV.DataPropertyName = dt.Columns["Selling Price"].ToString();
                catGV.DataPropertyName = dt.Columns["Category"].ToString();
                availStGV.DataPropertyName = dt.Columns["Available Stock"].ToString();
                totalAmountGV.DataPropertyName = dt.Columns["Total Amount"].ToString();
                StatusGV.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.ShowMSG("Unable to load Stock data", "Error", "Error");
            }
        }
        public void showProductWRTCategory(int catID,DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn proNameGV, DataGridViewColumn bpGV, DataGridViewColumn spGV, DataGridViewColumn discountGV, DataGridViewColumn profitPercentageGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductsWRTCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@catID", catID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                proNameGV.DataPropertyName = dt.Columns["Product Name"].ToString();
                bpGV.DataPropertyName = dt.Columns["Buying Price"].ToString();
                spGV.DataPropertyName = dt.Columns["Selling Price"].ToString();
                discountGV.DataPropertyName = dt.Columns["Discount"].ToString();
                profitPercentageGV.DataPropertyName = dt.Columns["Profit Percentage"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.ShowMSG("Unable to load Products data", "Error", "Error");
            }
        }
        private bool checkPPExistance;
        private object[] productPriceDetails = new object[5];
        public object[] checkProductPriceExistance(Int64 proID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_checkProductPriceExist", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        productPriceDetails[0] = dr[0].ToString(); //proID
                        productPriceDetails[1] = dr[1].ToString(); //bp
                        productPriceDetails[2] = dr[2].ToString(); //sp
                        productPriceDetails[3] = dr[3].ToString(); //dispercentage
                        productPriceDetails[4] = dr[4].ToString(); //profitPercentage
                    }
                }
                else
                {
                    Array.Clear(productPriceDetails, 0, productPriceDetails.Length);
                }
                MainClass.con.Close();
            }
            catch (Exception)
            {

            }
            return productPriceDetails;
        }
        public object getProductQuantityWithoutConnection(Int64 proID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductQuantity", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);

                productStockCount = cmd.ExecuteScalar();
            }
            catch (Exception)
            {

            }
            return productStockCount;
        }
        public void showReport(string reportName,ReportDocument rd,CrystalReportViewer crv,string proc, string param1= null, object val1=null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType= CommandType.StoredProcedure;
                if (param1 != null && val1 != null)
                {
                    cmd.Parameters.AddWithValue(param1, val1);
                }
                else
                {

                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rd.Load(Application.StartupPath+ "\\Reports\\" + reportName); 
                rd.SetDataSource(dt);
                crv.ReportSource = rd;
                crv.RefreshReport();
            }
            catch (Exception ex)
            {

                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }
        public void showDailySales(DateTime date,DataGridView gv, DataGridViewColumn saleIDGV, DataGridViewColumn UserGV, DataGridViewColumn totAmountGV, DataGridViewColumn totDiscountGV, DataGridViewColumn amountGivenGV, DataGridViewColumn amountReturnedGV, DataGridViewColumn userIDGV)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_getDailySales", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date", date);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                saleIDGV.DataPropertyName = dt.Columns["Sales ID"].ToString();
                UserGV.DataPropertyName = dt.Columns["User"].ToString();
                totAmountGV.DataPropertyName = dt.Columns["Total Amount"].ToString();
                totDiscountGV.DataPropertyName = dt.Columns["Total Discount"].ToString();
                amountGivenGV.DataPropertyName = dt.Columns["Given Amount"].ToString();
                amountReturnedGV.DataPropertyName = dt.Columns["Returned Amount"].ToString();
                userIDGV.DataPropertyName = dt.Columns["User ID"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.ShowMSG("Unable to load sales data", "Error", "Error");
            }
        }
        public void showSalesDataViaID(Int64 salesID,DataGridView gv, DataGridViewColumn salesIDGV, DataGridViewColumn barcodeGV, 
            DataGridViewColumn productGV, DataGridViewColumn quantityGV, DataGridViewColumn perProDisGV, DataGridViewColumn perProTotalGV,
            DataGridViewColumn totalDisGV, DataGridViewColumn totAmountGV, DataGridViewColumn givenAmountGV, DataGridViewColumn returnedAmountGV,
            DataGridViewColumn dateGV, DataGridViewColumn proPriceGV, DataGridViewColumn userGV, DataGridViewColumn paymentMethodGV, DataGridViewColumn proIDGV, DataGridViewColumn productDiscount)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_getSalesReceiptWRTSalesID", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@salesID", salesID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                salesIDGV.DataPropertyName = dt.Columns["Sales ID"].ToString();
                barcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                productGV.DataPropertyName = dt.Columns["Product Name"].ToString();
                quantityGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                proPriceGV.DataPropertyName = dt.Columns["Product Price"].ToString();
                perProDisGV.DataPropertyName = dt.Columns["Per Product Discount"].ToString();
                perProTotalGV.DataPropertyName = dt.Columns["Per Product Total"].ToString();
                totalDisGV.DataPropertyName = dt.Columns["Total Discount"].ToString();
                totAmountGV.DataPropertyName = dt.Columns["Total Amount"].ToString();
                givenAmountGV.DataPropertyName = dt.Columns["Given Amount"].ToString();
                returnedAmountGV.DataPropertyName = dt.Columns["Returned Amount"].ToString();
                dateGV.DataPropertyName = dt.Columns["Date"].ToString();
                userGV.DataPropertyName = dt.Columns["User"].ToString();
                paymentMethodGV.DataPropertyName = dt.Columns["Pay Type"].ToString();
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                productDiscount.DataPropertyName = dt.Columns["Product Discount"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception)
            {
                MainClass.ShowMSG("Unable to load sales data", "Error", "Error");
            }
        }
    }
}