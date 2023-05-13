using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelExpertsData;

namespace Product2
{
    public static class Product_DB
    {
        public static List<Product_P> GetAllProducts()
        {
            List<Product_P> products = new List<Product_P>();
            Product_P P = null;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string Statement = "SELECT * FROM Products where prodname NOT LIKE 'inactive%' ORDER BY ProdName";
            SqlCommand cmd = new SqlCommand(Statement, con);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) // while there are customers
                {
                    P = new Product_P();
                    P.ProductID = (int)reader["ProductID"];
                    P.ProdName = reader["ProdName"].ToString();
                    products.Add(P);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return products;
        }

        public static void AddProduct(string prodName)
        {
           SqlConnection con = TravelExpertsDB.GetConnection();
           string insertStatement = "INSERT INTO Products (prodname) VALUES (@ProdName) ";
           SqlCommand cmd = new SqlCommand(insertStatement, con);
           cmd.Parameters.AddWithValue("@ProdName", prodName);
           con.Open();
           cmd.ExecuteNonQuery();                        
           con.Close();
        }
        public static void UpdateProduct(string newprodname, string oldprodname)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            string insertStatement = "UPDATE Products SET ProdName = @prodname WHERE @oldprodname = ProdName ; ";
            SqlCommand cmd = new SqlCommand(insertStatement, con);
            cmd.Parameters.AddWithValue("@prodname", newprodname);
            cmd.Parameters.AddWithValue("@oldprodname", oldprodname);
            con.Open();
            con.Close();
        }
       
    }
}
    