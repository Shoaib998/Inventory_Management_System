using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;



namespace IMS
{
    internal class insertion
    {
        public void insertUser(string name, string username, string password, string phone, string email, Int16 status)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_insertUsers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name",name );
                cmd.Parameters.AddWithValue("@username", username );
                cmd.Parameters.AddWithValue("@pwd", password );
                cmd.Parameters.AddWithValue("@phone", phone );
                cmd.Parameters.AddWithValue("@email", email );
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(name+ " added to the System Succesfully", "Success...", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
        }
        public void insertCat(string name, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@isActive", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(name + " added to the System Succesfully", "Success...", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
        }
        public void insertProduct(string product, string barcode, int catID, DateTime? expiry= null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_productInsert", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", product);
                cmd.Parameters.AddWithValue("@barcode", barcode);
                
                if (expiry == null )
                {
                    cmd.Parameters.AddWithValue("@expiry", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@expiry", expiry);
                }
                cmd.Parameters.AddWithValue("@catID", catID);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(product + " added to the System Succesfully", "Success...", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
        }
        public void insertSupplier(string company, string person, string phone1, string address, Int16 status, string phone2 = null, string ntn = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertSupplier", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@company", company);
                cmd.Parameters.AddWithValue("@personName", person);
                cmd.Parameters.AddWithValue("@phone1", phone1);
                if (phone2 == null )
                {
                    cmd.Parameters.AddWithValue("@phone2", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@phone2", phone2);
                }
                cmd.Parameters.AddWithValue("@address", address);
                if (ntn == null)
                {
                    cmd.Parameters.AddWithValue("@ntn", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ntn", ntn);
                }  
                cmd.Parameters.AddWithValue("@status", status);

                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(company + " added to the System Succesfully", "Success...", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
        }
        private Int64 PurchaseInvoiceID;
        public Int64 insertPurchaseInvoice(DateTime date,int doneBy, int suppID)
        {
            try
            {
               
                    SqlCommand cmd = new SqlCommand("st_insertPurchaseInvoice", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@doneBy", doneBy);
                    cmd.Parameters.AddWithValue("@suppID", suppID);
                    MainClass.con.Open();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "st_getLastPurchaseID";
                    cmd.Parameters.Clear();
                    PurchaseInvoiceID = Convert.ToInt64(cmd.ExecuteScalar());

                    MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
            return PurchaseInvoiceID;
        }
        int pidCount;
        public int insertPurchaseInvoiceDetails(Int64 purID, Int64 proID, int proquan, float totprice)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertPurchaseInvoiceDetails", MainClass.con);
                cmd.CommandType= CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@purchaseID",purID);
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@proquan", proquan);
                cmd.Parameters.AddWithValue("@totprice", totprice);
                MainClass.con.Open();
                pidCount = cmd.ExecuteNonQuery();
                MainClass.con.Close();

            }
            catch (Exception)
            {

                MainClass.con.Close();
            }
            return pidCount;
        }
        public void insertStock(Int64 proID, int proquan)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertStock", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@quan", proquan);
            
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();

            }
            catch (Exception)
            {

                MainClass.con.Close();
            }
        }
        public void insertDeletedItems(Int64 pid, Int64 proid, int quan, int userid, DateTime date)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_insertDeletedItemsPI", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pi", pid);
                cmd.Parameters.AddWithValue("@userID", userid);
                cmd.Parameters.AddWithValue("@proID", proid);
                cmd.Parameters.AddWithValue("@quan", quan);
                cmd.Parameters.AddWithValue("@date", date);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
        }
        public void insertProductPrice(Int64 proID, float buyingAmount)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertProductPrice", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@bp", buyingAmount);
               
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
        }
        int saleCount = 0;
        Int64 salesID;
        retrieval r = new retrieval();
        updation u = new updation();
        public void insertSales(DataGridView gv,string proIDGV,string proQuanGV,int doneBy, DateTime dt, float totAmt, float totDis, float amtGiven, float amtReturned,string payType)
        {
            try
            {
                using (TransactionScope sc = new TransactionScope())
                {
                    SqlCommand cmd = new SqlCommand("st_insertSales", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@done", doneBy);
                    cmd.Parameters.AddWithValue("@date", dt);
                    cmd.Parameters.AddWithValue("@totAmt", totAmt);
                    cmd.Parameters.AddWithValue("@totDis", totDis);
                    cmd.Parameters.AddWithValue("@amtGiven", amtGiven);
                    cmd.Parameters.AddWithValue("@amtReturn", amtReturned);
                    if (payType == "Cash")
                    {
                        cmd.Parameters.AddWithValue("@payType", 0);
                    }
                    else if (payType == "Debit Card")
                    {
                        cmd.Parameters.AddWithValue("@payType", 1);
                    }
                    else if (payType == "Credit Card")
                    {
                        cmd.Parameters.AddWithValue("@payType", 2);
                    }
                    MainClass.con.Open();
                    saleCount = cmd.ExecuteNonQuery();
                    if (saleCount > 0)
                    {
                        SqlCommand cmd1 = new SqlCommand("st_getSalesID", MainClass.con);
                        cmd1.CommandType = CommandType.StoredProcedure;
                        salesID = Convert.ToInt64(cmd1.ExecuteScalar());
                        foreach (DataGridViewRow row in gv.Rows)
                        {
                            SqlCommand cmd2 = new SqlCommand("st_insertSalesDetails", MainClass.con);
                            cmd2.CommandType = CommandType.StoredProcedure;
                            cmd2.Parameters.AddWithValue("@salID", salesID);
                            cmd2.Parameters.AddWithValue("@proID", Convert.ToInt64(row.Cells[proIDGV].Value.ToString()));
                            cmd2.Parameters.AddWithValue("@quan", Convert.ToInt32(row.Cells[proQuanGV].Value.ToString()));
                            cmd2.ExecuteNonQuery();
                            int stockofProduct = Convert.ToInt32( r.getProductQuantityWithoutConnection(Convert.ToInt64(row.Cells[proIDGV].Value.ToString())));
                            int currentQuanofProduct = Convert.ToInt32(row.Cells[proQuanGV].Value.ToString());
                            int finalProductQuantity = stockofProduct - currentQuanofProduct;
                            u.updateStockWithoutConnection(Convert.ToInt64(row.Cells[proIDGV].Value.ToString()), finalProductQuantity);
                        }
                    }
                    MainClass.con.Close();
                    MainClass.ShowMSG("Sales add Successfull", "Succes", "Succes");
                    sc.Complete();
                } 
            }
            catch (Exception)
            {

                MainClass.con.Close();
            }
        }
    }
}
