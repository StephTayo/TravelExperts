using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    public static class SupplierDB
    {
        public static List<Supplier> GetSuppliersbyPackageId(int packageId)
        {
            List<Supplier> suppliers = new List<Supplier>();   // empty list
            Supplier supp;                   // object instance for reading
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string selectQuery =
                    "SELECT sup.SupplierId, sup.SupName " +
                    "FROM Suppliers AS sup " +
                    "INNER JOIN Products_Suppliers AS prs ON sup.SupplierId=prs.SupplierId " +
                    "INNER JOIN Packages_Products_Suppliers AS pps " +
                    "ON prs.ProductSupplierId=pps.ProductSupplierId " +
                    "WHERE pps.PackageId = @PackageId " +
                    "ORDER BY sup.SupplierId";
                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@PackageId", packageId);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())  // if products for given ID exists
                    {
                        supp = new Supplier();
                        supp.SupplierId = (int)reader["SupplierId"];
                        supp.SupName = reader["SupName"].ToString();
                        suppliers.Add(supp);
                    }
                }
            }
            return suppliers;
        }

        public static List<Supplier> GetSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();   // empty list
            Supplier supp;                   // object instance for reading
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string selectQuery =
                    "SELECT SupplierId, SupName " +
                    "FROM Suppliers";
                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())  // if products for given ID exists
                    {
                        supp = new Supplier();
                        supp.SupplierId = (int)reader["SupplierId"];
                        supp.SupName = reader["SupName"].ToString();
                        suppliers.Add(supp);
                    }
                }
            }
            return suppliers;
        }

        public static List<Supplier> GetEngagedSuppliers()
        {
            List<Supplier> engagedSuppliers = new List<Supplier>();   // empty list
            Supplier supp;                   // object instance for reading
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string selectQuery =
                    "SELECT DISTINCT sup.SupplierId, sup.SupName " +
                    "FROM Suppliers AS sup " +
                    "INNER JOIN Products_Suppliers AS prs ON sup.SupplierId=prs.SupplierId " +
                    "INNER JOIN Packages_Products_Suppliers AS pps " +
                    "ON prs.ProductSupplierId=pps.ProductSupplierId " +
                    "WHERE pps.PackageId IS NOT NULL " +
                    "ORDER BY sup.SupName";
                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())  // if products for given ID exists
                    {
                        supp = new Supplier();
                        supp.SupplierId = (int)reader["SupplierId"];
                        supp.SupName = reader["SupName"].ToString();
                        engagedSuppliers.Add(supp);
                    }
                }
            }
            return engagedSuppliers;
        }
    }
}
