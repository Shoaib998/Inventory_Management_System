using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IMS
{
    internal class updation
    {
        public void updateUser(int id, string name, string username, string password, string phone, string email, Int16 status)

        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateUsers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pwd", password);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@status", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(name + " updated to the System Succesfully", "Success...", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
        }
        public void updateCat(int id,string name, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@isActive", status);
                cmd.Parameters.AddWithValue("@id", id);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(name + " updated Succesfully", "Success...", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
        }
        public void updateProduct(int proID, string product, string barcode, float price, int catID, DateTime? expiry=null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_productUpdate", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", product);
                cmd.Parameters.AddWithValue("@barcode", barcode);
                cmd.Parameters.AddWithValue("@price", price);
                if (expiry == null)
                {
                    cmd.Parameters.AddWithValue("@expiry", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@expiry", expiry);
                }
                cmd.Parameters.AddWithValue("@catID", catID);
                cmd.Parameters.AddWithValue("@proID", proID);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(product + " updated  Succesfully", "Success...", "Success");
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
        }
    }
}
