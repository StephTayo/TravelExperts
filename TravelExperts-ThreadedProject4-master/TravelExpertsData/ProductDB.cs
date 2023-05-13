using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    public static class ProductDB
    {
        public static List<Product> GetProductsbyPackageId(int packageId)
        {            
            List<Product> products = new List<Product>();   // empty list
            Product prod;                   // object instance for reading
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string selectQuery =
                    "SELECT prod.ProductId, prod.ProdName " +
                    "FROM Products AS prod " +
                    "INNER JOIN Products_Suppliers AS prs ON prod.ProductId=prs.ProductId " +
                    "INNER JOIN Packages_Products_Suppliers AS pps " +
                    "ON prs.ProductSupplierId=pps.ProductSupplierId " +                  
                    "WHERE pps.PackageId = @PackageId " +
                    "ORDER BY prod.ProductId";
                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@PackageId", packageId);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())  // if products for given ID exists
                    {
                        prod = new Product();
                        prod.ProductId = (int)reader["ProductId"];
                        prod.ProdName = reader["ProdName"].ToString();
                        products.Add(prod);
                    }
                }
            }
            return products;
        }

        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();   // empty list
            Product prod;                   // object instance for reading
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string selectQuery =
                    "SELECT ProductId, ProdName " +
                    "FROM Products";
                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())  // if products for given ID exists
                    {
                        prod = new Product();
                        prod.ProductId = (int)reader["ProductId"];
                        prod.ProdName = reader["ProdName"].ToString();
                        products.Add(prod);
                    }
                }
            }
            return products;
        }

        public static List<Product> GetEngagedProducts()
        {
            List<Product> engagedProducts = new List<Product>();   // empty list
            Product engProd;                   // object instance for reading
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string selectQuery =
                    "SELECT DISTINCT prod.ProductId, prod.ProdName " +
                    "FROM Products AS prod " +
                    "INNER JOIN Products_Suppliers AS prs ON prod.ProductId=prs.ProductId " +
                    "INNER JOIN Packages_Products_Suppliers AS pps " +
                    "ON prs.ProductSupplierId=pps.ProductSupplierId " +
                    "WHERE pps.PackageId IS NOT NULL " +
                    "ORDER BY prod.ProdName";
                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())  // if products for given ID exists
                    {
                        engProd = new Product();
                        engProd.ProductId = (int)reader["ProductId"];
                        engProd.ProdName = reader["ProdName"].ToString();
                        engagedProducts.Add(engProd);
                    }
                }
            }
            return engagedProducts;
        }

    }
}
