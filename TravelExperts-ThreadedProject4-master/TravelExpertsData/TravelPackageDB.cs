using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpertsData
{
    public class TravelPackageDB
    {
        // list all packages
        public static List<Package> GetPackages(ListView tableView)
        {
            List<Package> packages = new List<Package>();

            using (SqlConnection con = TravelExpertsDB.GetConnection())
            {
                string selectPackagesQuery = @"SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission FROM Packages";
                using (SqlCommand cmd = new SqlCommand(selectPackagesQuery, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    tableView.View = View.Details;
                    tableView.FullRowSelect = true;

                    tableView.Columns.Add("ID").Width=35;
                    tableView.Columns.Add("Name").Width = 125;
                    tableView.Columns.Add("Start Date").Width = 85;
                    tableView.Columns.Add("End Date").Width = 85;
                    tableView.Columns.Add("Description").Width = 270;
                    tableView.Columns.Add("Base Price").Width = 85;
                    tableView.Columns.Add("Commission").Width = 85;

                    while (reader.Read())
                    {
                        var item = new ListViewItem();
                        // variables
                        DateTime startDate = Convert.ToDateTime(reader["PkgStartDate"]);
                        DateTime endDate = Convert.ToDateTime(reader["PkgEndDate"]);
                        double basePrice = Convert.ToDouble(reader["PkgBasePrice"]);
                        double agencyCommission = Convert.ToDouble(reader["PkgAgencyCommission"]);

                        item.SubItems[0].Text = reader[0].ToString();
                        item.SubItems.Add(reader["PkgName"].ToString());
                        item.SubItems.Add(startDate.ToString("MM/dd/yyyy"));
                        item.SubItems.Add(endDate.ToString("MM/dd/yyyy"));
                        item.SubItems.Add(reader["PkgDesc"].ToString());
                        item.SubItems.Add(basePrice.ToString("C"));
                        item.SubItems.Add(agencyCommission.ToString("C"));
                        tableView.Items.Add(item);
                    }
                }
            }
            return packages;
        }

        // show details from selected package
        public void ShowSelectedOrder(ListView listview, Label packageId, Label packageName, Label packageStartDate, Label packageEndDate, Label packageDescription, Label packageBasePrice, Label packageCommission)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            try
            {
                string selectPackageQuery = @"SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission FROM Packages WHERE PackageId = @PackageId";

                SqlCommand sqlCommand = new SqlCommand(selectPackageQuery, con);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    if (listview != null && listview.SelectedItems.Count > 0)
                    {
                        sqlCommand.Parameters.AddWithValue("@PackageId", listview.FocusedItem.Text);

                        DataTable OrderDataTable = new DataTable();
                        sqlDataAdapter.Fill(OrderDataTable);

                        // variables
                        string pkgId = Convert.ToString(OrderDataTable.Rows[0]["PackageId"]);
                        string pkgName = Convert.ToString(OrderDataTable.Rows[0]["PkgName"]);
                        string pkgDesc = Convert.ToString(OrderDataTable.Rows[0]["PkgDesc"]);
                        DateTime startDate = Convert.ToDateTime(OrderDataTable.Rows[0]["PkgStartDate"]);
                        DateTime endDate = Convert.ToDateTime(OrderDataTable.Rows[0]["PkgEndDate"]);
                        double pkgPrice = Convert.ToDouble(OrderDataTable.Rows[0]["PkgBasePrice"]);
                        double pkgComm = Convert.ToDouble(OrderDataTable.Rows[0]["PkgAgencyCommission"]);

                        packageId.Text = pkgId;
                        packageName.Text = pkgName;
                        packageStartDate.Text = startDate.ToString("MM/dd/yyyy");
                        packageEndDate.Text = endDate.ToString("MM/dd/yyyy");
                        packageDescription.Text = pkgDesc;
                        packageBasePrice.Text = pkgPrice.ToString("C");
                        packageCommission.Text = pkgComm.ToString("C");
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

        // show products associated with selected package
        public static List<Package> GetPackageProducts(ListBox listBox, int packageId)
        {
            List<Package> packageProducts = new List<Package>();
            using (SqlConnection con = TravelExpertsDB.GetConnection())
            {
                string selectPackProdQuery = @"SELECT ProdName FROM Packages P " +
                                              "INNER JOIN Packages_Products_Suppliers S ON P.PackageId = S.PackageId " +
                                              "INNER JOIN Products_Suppliers O ON S.ProductSupplierId = O.ProductSupplierId " +
                                              "INNER JOIN Products R ON O.ProductId = R.ProductId " +
                                              "WHERE S.PackageId = @PackageId";

                using (SqlCommand cmd = new SqlCommand(selectPackProdQuery, con))
                {
                    cmd.Parameters.AddWithValue("@PackageId", packageId);
                    con.Open();

                    if (listBox.ValueMember != null)
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable prod = new DataTable();
                        adapter.Fill(prod);

                        listBox.DisplayMember = "ProdName";
                        listBox.ValueMember = "ProductId";
                        listBox.DataSource = prod;
                    }
                }
            }
            return packageProducts;
        }

        // list products in package
        public static List<Package> PackageList(int packageId)
        {
            List<Package> listProducts = new List<Package>();
            using (SqlConnection con = TravelExpertsDB.GetConnection())
            {
                string selectPackProdQuery = @"SELECT ProdName FROM Packages P " +
                                              "INNER JOIN Packages_Products_Suppliers S ON P.PackageId = S.PackageId " +
                                              "INNER JOIN Products_Suppliers O ON S.ProductSupplierId = O.ProductSupplierId " +
                                              "INNER JOIN Products R ON O.ProductId = R.ProductId " +
                                              "WHERE S.PackageId = @PackageId";

                using (SqlCommand cmd = new SqlCommand(selectPackProdQuery, con))
                {
                    cmd.Parameters.AddWithValue("@PackageId", packageId);
                    con.Open();
                }
            }
            return listProducts;
        }

        // gets ID of selected package
        public static List<Package> GetCurrentProdIds(int packageId)
        {
            List<Package> currentProductIds = new List<Package>();
            using (SqlConnection con = TravelExpertsDB.GetConnection())
            {
                string selectPackProdQuery = @"SELECT ProductId FROM Packages P " +
                                              "INNER JOIN Packages_Products_Suppliers S ON P.PackageId = S.PackageId " +
                                              "INNER JOIN Products_Suppliers O ON S.ProductSupplierId = O.ProductSupplierId " +
                                              "INNER JOIN Products R ON O.ProductId = R.ProductId " +
                                              "WHERE R.ProductId = O.ProductId " +
                                              "AND O.ProductSupplierId = S.ProductSupplierId " +
                                              "AND S.PackageId = @PackageId";

                using (SqlCommand cmd = new SqlCommand(selectPackProdQuery, con))
                {
                    cmd.Parameters.AddWithValue("@PackageId", packageId);
                    con.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable prod = new DataTable();
                    adapter.Fill(prod);
                }
            }
            return currentProductIds;
        }

        // get available products not added to the package
        public static List<Package> ShowAllProducts(ListBox listBox, int packageId)
        {
            List<Package> showProducts = new List<Package>();
            using (SqlConnection con = TravelExpertsDB.GetConnection())
            {
                string showProdQuery = @"SELECT DISTINCT ProdName FROM Products P " +
                                        "INNER JOIN Products_Suppliers S ON P.ProductId = S.ProductId " +
                                        "INNER JOIN Packages_Products_Suppliers D ON S.ProductSupplierId = D.ProductSupplierId " +
                                        "WHERE P.ProductId = S.ProductId AND S.ProductSupplierId = D.ProductSupplierId AND P.ProductId " +
                                        "NOT IN (SELECT ProductId FROM Products_Suppliers S " +
                                        "INNER JOIN Packages_Products_Suppliers D ON S.ProductSupplierId = D.ProductSupplierId " +
                                        "AND D.PackageId = @PackageId)";

                using (SqlCommand cmd = new SqlCommand(showProdQuery, con))
                {
                    cmd.Parameters.AddWithValue("@PackageId", packageId);
                    con.Open();

                    if (listBox.ValueMember != null)
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable prod = new DataTable();
                        adapter.Fill(prod);

                        listBox.DisplayMember = "ProdName";
                        listBox.ValueMember = "ProductId";
                        listBox.DataSource = prod;
                    }
                }
            }
            return showProducts;
        }

        // gets ID of selected product
        public void GetProductId(string productName, Label label)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            try
            {
                string getProductIdQuery = @"SELECT ProductId FROM Products WHERE ProdName = @ProdName";

                SqlCommand sqlCommand = new SqlCommand(getProductIdQuery, con);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@ProdName", productName);
                    DataTable ProdIdTable = new DataTable();
                    sqlDataAdapter.Fill(ProdIdTable);
                    string prodId = Convert.ToString(ProdIdTable.Rows[0]["ProductId"]);
                    label.Text = prodId;
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

        // gets product supplier id from product selection
        public int GetSupplierId(int productId)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            try
            {
                string getSupplierIdQuery = @"SELECT P.ProductSupplierId FROM Products_Suppliers P " +
                                             "INNER JOIN Packages_Products_Suppliers S " +
                                             "ON P.ProductSupplierId = S.ProductSupplierId " +
                                             "WHERE P.ProductId = @ProductId";

                SqlCommand sqlCommand = new SqlCommand(getSupplierIdQuery, con);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@ProductId", productId);
                    DataTable ProdIdTable = new DataTable();
                    sqlDataAdapter.Fill(ProdIdTable);
                    int prodSupplierId = Convert.ToInt32(ProdIdTable.Rows[0]["ProductSupplierId"]);
                    return prodSupplierId;
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

        // saves changes to travel packages after editing
        public void EditTravelPackage(int packageId, string packageName, DateTime packageStartDate, DateTime packageEndDate, string packageDescription, double packageBasePrice, double packageCommission)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            try
            {
                string updatePkgQuery = @"UPDATE Packages " +
                                         "SET PkgName = @PackageName, PkgStartDate = @PackageStartDate, PkgEndDate = @PackageEndDate, PkgDesc = @PackageDescription, PkgBasePrice = @PackageBasePrice, PkgAgencyCommission = @PackageCommission " +
                                         "WHERE PackageId = @PackageId";

                SqlCommand sqlCommand = new SqlCommand(updatePkgQuery, con);
                con.Open();
                sqlCommand.Parameters.AddWithValue("@PackageId", packageId);
                sqlCommand.Parameters.AddWithValue("@PackageName", packageName);
                sqlCommand.Parameters.AddWithValue("@PackageStartDate", packageStartDate);
                sqlCommand.Parameters.AddWithValue("@PackageEndDate", packageEndDate);
                sqlCommand.Parameters.AddWithValue("@PackageDescription", packageDescription);
                sqlCommand.Parameters.AddWithValue("@PackageBasePrice", packageBasePrice);
                sqlCommand.Parameters.AddWithValue("@PackageCommission", packageCommission);
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

        // adds new travel package to database
        public void AddTravelPackage(string packageName, DateTime packageStartDate, DateTime packageEndDate, string packageDescription, double packageBasePrice, double packageCommission)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            try
            {
                string updatePkgQuery = @"INSERT INTO Packages " +
                                         "(PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission) " +
                                         "VALUES (@PackageName, @PackageStartDate, @PackageEndDate, @PackageDescription, @PackageBasePrice, @PackageCommission)";

                SqlCommand sqlCommand = new SqlCommand(updatePkgQuery, con);
                con.Open();
                sqlCommand.Parameters.AddWithValue("@PackageName", packageName);
                sqlCommand.Parameters.AddWithValue("@PackageStartDate", packageStartDate);
                sqlCommand.Parameters.AddWithValue("@PackageEndDate", packageEndDate);
                sqlCommand.Parameters.AddWithValue("@PackageDescription", packageDescription);
                sqlCommand.Parameters.AddWithValue("@PackageBasePrice", packageBasePrice);
                sqlCommand.Parameters.AddWithValue("@PackageCommission", packageCommission);
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

        // adds products to package
        public void AddPackageToProd(int packageId, int prodSupplierId)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();
            try
            {
                string insertPackToProdQuery = @"INSERT INTO Packages_Products_Suppliers (PackageId, ProductSupplierId) " +
                                                "VALUES (@PackageId, @ProductSupplierId)";

                SqlCommand sqlCommand = new SqlCommand(insertPackToProdQuery, con);
                con.Open();
                sqlCommand.Parameters.AddWithValue("@PackageId", packageId);
                sqlCommand.Parameters.AddWithValue("@ProductSupplierId", prodSupplierId);
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

        // delete travel package
        public void DeleteTravelPackage(ListView packageList, int packageID)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();

            try
            {
                // remove associated products
                string removeProdQuery = @"DELETE FROM Packages_Products_Suppliers WHERE PackageId = @PackageId";
                SqlCommand sqlRemoveProdCommand = new SqlCommand(removeProdQuery, con);
                sqlRemoveProdCommand.Parameters.AddWithValue("@PackageId", packageID);

                // delete package
                string deletePkgQuery = @"DELETE FROM Packages WHERE PackageID = @PackageId";
                SqlCommand sqlCommand = new SqlCommand(deletePkgQuery, con);
                sqlCommand.Parameters.AddWithValue("@PackageId", packageID);

                con.Open();
                
                sqlRemoveProdCommand.ExecuteScalar();
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

        // remove product from travel package
        public void RemovePackageProduct(int productId, int packageId)
        {
            SqlConnection con = TravelExpertsDB.GetConnection();

            try
            {
                string removeProdQuery = @"DELETE FROM Packages_Products_Suppliers " +
                                          "FROM Packages_Products_Suppliers " + 
                                          "LEFT OUTER JOIN Products_Suppliers " +
                                          "ON Packages_Products_Suppliers.ProductSupplierId = Products_Suppliers.ProductSupplierId " +
                                          "WHERE ProductId = @ProductId AND PackageId = @PackageId";

                SqlCommand sqlCommand = new SqlCommand(removeProdQuery, con);
                con.Open();

                sqlCommand.Parameters.AddWithValue("@ProductId", productId);
                sqlCommand.Parameters.AddWithValue("@PackageId", packageId);

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
