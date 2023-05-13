using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpertsData
{
    public class TravelSupplierDB
    {
       
        public static List<Supplier> GetSupplier(ListView tableView)
        {
            List<Supplier> suppliers = new List<Supplier>();

            //sql connection 
            using (SqlConnection con = TravelExpertsDB.GetConnection())
            {
                // Supplier Query
                string selectSuppliersQuery = @"SELECT SupplierId, SupName FROM Suppliers ORDER BY SupplierId";
                // SQL command
                using (SqlCommand cmd = new SqlCommand(selectSuppliersQuery, con))
                {                 
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                  
                    tableView.View = View.Details;
                    tableView.FullRowSelect = true;
                    //Data Table Columns
                    tableView.Columns.Add("SupplierID").Width = 100;
                    tableView.Columns.Add("SupplierName").Width = 300;

                    while (reader.Read())
                    {
                        // variables
                        var item = new ListViewItem();

                        item.SubItems[0].Text = reader[0].ToString();
                        item.SubItems.Add(reader["SupName"].ToString());
                        tableView.Items.Add(item);
                    }
                } 
            }
            return suppliers;
        }

        public static List<Supplier> GetProducts(ListBox listBoxPackage, int suppId)
        {
          
            List<Supplier> products = new List<Supplier>();
            using (SqlConnection con = TravelExpertsDB.GetConnection())
            {
                string productQuery = @"SELECT Products.ProductId, Products.ProdName " +
                                        "FROM Products " +
                                        "INNER JOIN Products_suppliers ON Products_suppliers.ProductId  = Products.ProductId " +
                                        "INNER JOIN Suppliers ON Suppliers.SupplierId = Products_suppliers.SupplierId " +
                                        "WHERE Suppliers.SupplierId = @SupplierId";

                using (SqlCommand sqlCommand = new SqlCommand(productQuery, con))
                {
                    sqlCommand.Parameters.AddWithValue("@SupplierId", suppId);
                    con.Open();

                    if (listBoxPackage.ValueMember != null)
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                        DataTable prod = new DataTable();
                        adapter.Fill(prod);

                        listBoxPackage.DisplayMember = "ProdName";
                        listBoxPackage.ValueMember = "ProductId";
                        listBoxPackage.DataSource = prod;
                    }
                }
            }
            return products;
        }


        public static List<Supplier> GetSupplierwithProduct(ListView tableView)
        {
            List<Supplier> suppliersandproducts = new List<Supplier>();

            //sql connection 
            using (SqlConnection con = TravelExpertsDB.GetConnection())
            {
                string selectSuppliersQuery = @"SELECT [dbo].[Suppliers].SupplierId, SupName, [dbo].[Products].ProductId, [dbo].[Products].ProdName
                                                FROM Suppliers
                                                INNER JOIN Products_Suppliers ON[dbo].[Suppliers].SupplierId  = [dbo].[Products_Suppliers].SupplierId
                                                INNER JOIN Products ON[dbo].[Products_Suppliers].ProductId = [dbo].[Products].ProductId
                                                ORDER BY SupplierId";

                //string selectSuppliersQuery = @"SELECT SupplierId, SupName FROM Suppliers";
                using (SqlCommand cmd = new SqlCommand(selectSuppliersQuery, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    tableView.View = View.Details;
                    tableView.FullRowSelect = true;

                    tableView.Columns.Add("SupplierID").Width = 100;
                    tableView.Columns.Add("SupplierName").Width = 300;
                    tableView.Columns.Add("ProductID").Width = 100;
                    tableView.Columns.Add("ProductName").Width = 200;

                    while (reader.Read())
                    {
                        var item = new ListViewItem();
                        // variables      
                        item.SubItems[0].Text = reader[0].ToString();
                        item.SubItems.Add(reader["SupName"].ToString());
                        item.SubItems.Add(reader["ProductId"].ToString());
                        item.SubItems.Add(reader["ProdName"].ToString());
                        tableView.Items.Add(item);
                    }
                }
            }
            return suppliersandproducts;
        }

        // Add supplier db method
        public void AddSupplier(int supplierId, string supplierName)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            try
            {
                // Insert into Supplier Query
                string addSupplierQuery = @"INSERT INTO Suppliers (SupplierId, SupName) VALUES(@SupplierID, @SupplierName)";
                // SQL command
                SqlCommand sqlSupplierCommand = new SqlCommand(addSupplierQuery, con);
                con.Open();

                sqlSupplierCommand.Parameters.AddWithValue("@SupplierID", supplierId);
                sqlSupplierCommand.Parameters.AddWithValue("@SupplierName", supplierName);
                sqlSupplierCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        // Edit supplier db method
        public void EditSupplier(int supplierId, string supplierName)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            try
            {
                // Update Supplier Query
                string updateQuery = @"UPDATE Suppliers SET SupplierId = @SupplierID, SupName = @SupplierName WHERE SupplierId = @SupplierID";

                // SQL command
                SqlCommand sqlCommand = new SqlCommand(updateQuery, con);
                con.Open();

                sqlCommand.Parameters.AddWithValue("@SupplierID", supplierId);
                sqlCommand.Parameters.AddWithValue("@SupplierName", supplierName);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        // Selected supplier db method
        //public void SelectedSupplier(ListView listview, Label supplierId, Label supplierName, Label productId, Label productName)
        public void SelectedSupplier(ListView listview, Label supplierId, Label supplierName)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            try
            {
              
                string selectPackageQuery = @" SELECT SupplierId, SupName FROM Suppliers WHERE SupplierId = @SupplierId";

                SqlCommand sqlCommand = new SqlCommand(selectPackageQuery, con);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    if (listview != null && listview.SelectedItems.IsReadOnly == true)
                    {
                        sqlCommand.Parameters.AddWithValue("@SupplierId", listview.FocusedItem.Text);

                        DataTable SupplierTable = new DataTable();
                        sqlDataAdapter.Fill(SupplierTable);

                        // variables
                        int supId = Convert.ToInt32(SupplierTable.Rows[0]["SupplierId"]);
                        string supName = SupplierTable.Rows[0]["SupName"].ToString();
                        //int prodId = Convert.ToInt32(SupplierTable.Rows[0]["ProductId"]);
                        //string prodName = SupplierTable.Rows[0]["ProdName"].ToString();

                        supplierId.Text = supId.ToString();
                        supplierName.Text = supName;
                        //productId.Text = prodId.ToString();
                        //productName.Text = prodName;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public void SelectedSupplieriwthProduct(ListView listview, Label supplierId, Label supplierName, Label productId, Label productName)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            try
            {
                string selectPackageQuery = @" SELECT [dbo].[Suppliers].SupplierId, SupName, [dbo].[Products].ProductId, [dbo].[Products].ProdName
                                            FROM Suppliers
                                            INNER JOIN Products_Suppliers 
                                            ON [dbo].[Suppliers].SupplierId  = [dbo].[Products_Suppliers].SupplierId
                                            INNER JOIN Products 
                                            ON[dbo].[Products_Suppliers].ProductId = [dbo].[Products].ProductId
                                            WHERE [dbo].[Suppliers].SupplierId = @SupplierId";


                SqlCommand sqlCommand = new SqlCommand(selectPackageQuery, con);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    if (listview != null && listview.SelectedItems.IsReadOnly == true)
                    {
                        sqlCommand.Parameters.AddWithValue("@SupplierId", listview.FocusedItem.Text);

                        DataTable SupplierTable = new DataTable();
                        sqlDataAdapter.Fill(SupplierTable);

                        // variables

                        int supId = Convert.ToInt32(SupplierTable.Rows[0]["SupplierId"]);
                        string supName = SupplierTable.Rows[0]["SupName"].ToString();
                        int prodId = Convert.ToInt32(SupplierTable.Rows[0]["ProductId"]); // value from the table
                        string prodName = SupplierTable.Rows[0]["ProdName"].ToString(); // value from the table

                        supplierId.Text = supId.ToString();
                        supplierName.Text = supName;
                        productId.Text = prodId.ToString();
                        productName.Text = prodName;

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public void DeleteSupplier(ListView supplierList, int supplierId)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            try
            {
                string deleteSupQuery = @"DELETE FROM Suppliers WHERE SupplierId = @SupplierID";
                SqlCommand sqlCommand = new SqlCommand(deleteSupQuery, con);
                con.Open();
                sqlCommand.Parameters.AddWithValue("@SupplierID", supplierId);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

    }
}
