using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    public static class PackageDB
    {

        public static List<PackageHC> GetPackages()
        {
            List<PackageHC> packages = new List<PackageHC>();   // empty list
            SqlConnection connection = TravelExpertsDB.GetConnection();// create the connection
            // create a  command string
            string selectQuery = "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission " +
 "FROM Packages ";
            // connect to the database and execute the command
            SqlCommand cmd = new SqlCommand(selectQuery, connection);
            try
            {
                connection.Open();// open connection

                //read one row from database with the specific value

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) // we have a package

                {

                    //create the Package array

                    PackageHC pkg = new PackageHC();

                    pkg.PackageId = (int)reader["PackageId"];

                    pkg.PkgName = reader["PkgName"].ToString();

                    if (reader["PkgStartDate"] is DBNull)

                        pkg.PkgStartDate = null;

                    else

                        pkg.PkgStartDate = Convert.ToDateTime(reader["PkgStartDate"]);



                    if (reader["PkgEndDate"] is DBNull)
                        pkg.PkgEndDate = null;
                    else
                        pkg.PkgEndDate = Convert.ToDateTime(reader["PkgEndDate"]);

                    if (reader["PkgDesc"] is DBNull)
                        pkg.PkgDesc = null;
                    else
                        pkg.PkgDesc = reader["PkgDesc"].ToString();
                    pkg.PkgBasePrice = (decimal)reader["PkgBasePrice"];
                    if (reader["PkgAgencyCommission"] is DBNull)
                        pkg.PkgAgencyCommission = null;
                    else
                        pkg.PkgAgencyCommission = (decimal)reader["PkgAgencyCommission"];
                    packages.Add(pkg);

                }// end of while

            }// end of try
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();//close connection
            }
            return packages;
        }
            

            public static PackageHC GetPackageById(int packageId)
        {
            PackageHC selectedPkg = null;
            using (SqlConnection connection = TravelExpertsDB.GetConnection())
            {
                string selectQuery =
                    "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, " +
                    "PkgDesc, PkgBasePrice, PkgAgencyCommission " +
                    "FROM Packages " +
                    "WHERE PackageId = @PackageId";
                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@PackageId", packageId);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    if (reader.Read())  // if package with given ID exists
                    {
                        selectedPkg = new PackageHC();
                        selectedPkg.PackageId = (int)reader["PackageId"];
                        selectedPkg.PkgName = reader["PkgName"].ToString();

                        // for any column that can be null need to determine if it is DBNull
                        // and set accordingly
                        int colSD = reader.GetOrdinal("PkgStartDate"); // column number of PkgStartDate
                        if (reader.IsDBNull(colSD)) // if reader contains DBNull in this column
                            selectedPkg.PkgStartDate = null; // make it null in the object
                        else // it is not null
                            selectedPkg.PkgStartDate = Convert.ToDateTime(reader["PkgStartDate"]);

                        int colED = reader.GetOrdinal("PkgEndDate"); // column number of PkgEndDate
                        if (reader.IsDBNull(colED)) // if reader contains DBNull in this column
                            selectedPkg.PkgEndDate = null; // make it null in the object
                        else // it is not null
                            selectedPkg.PkgEndDate = Convert.ToDateTime(reader["PkgEndDate"]);

                        selectedPkg.PkgDesc = reader["PkgDesc"].ToString();
                        selectedPkg.PkgBasePrice = (decimal)reader["PkgBasePrice"];

                        int colAC = reader.GetOrdinal("PkgAgencyCommission"); // column number of PkgAgencyCommission
                        if (reader.IsDBNull(colAC)) // if reader contains DBNull in this column
                            selectedPkg.PkgAgencyCommission = null; // make it null in the object
                        else // it is not null
                            selectedPkg.PkgAgencyCommission = (decimal)reader["PkgAgencyCommission"];
                    }
                }
            }
            return selectedPkg;
        }

    }
}
