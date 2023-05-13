using Product2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsData;

namespace TravelExperts_Group3
{
    public partial class HomePage : Form
    {
        // List of Packages
        List<PackageHC> packageList;  
        List<Supplier> supplierList, engagedSuppliers;
        List<Product> productList, engagedProducts;
        bool subTotalChecked;

        public HomePage()
        {
            InitializeComponent();
        }
        // on click displays the package form
        private void BtnPackages_Click(object sender, EventArgs e)
        {
            new TravelPackageForm().Show();
            Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            subTotalChecked = checkBox1.Checked;

            if (subTotalChecked)
            {
                lblCostMin.Text = "Lowest Cost subtotal: ";
                lblCostMax.Text = "Highest Cost subtotal: ";
                GetHomePageInfo();
            }
            else
            {                
                lblCostMin.Text = "Lowest Base Price: ";
                lblCostMax.Text = "Highest Base Price: ";
                GetHomePageInfo();
            }
        }
        // shows product form
        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.Show();
            Hide();
        }
        // displays suppliers list
        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            SupplierForm supplierListForm = new SupplierForm();
            supplierListForm.Show();
            Hide();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            GetHomePageInfo();
            lblCostMin.Text = "Lowest Base Price: ";
            lblCostMax.Text = "Highest Base Price: ";
        }
        //
        private void GetHomePageInfo()
        {
            List<int> duration = new List<int>();
            List<decimal> subCost = new List<decimal>();
            int rows, rowDuration, minDuration, maxDuration;
            decimal minBasePrice, maxBasePrice, rowSubCost;
            subTotalChecked = checkBox1.Checked;

            packageList = PackageDB.GetPackages();
            rows = packageList.Count;
            txtPackageCount.Text = rows.ToString();

            if (subTotalChecked)
            {
                for (int i = 0; i < rows; i++)
                {
                    rowSubCost = (decimal)packageList[i].PkgBasePrice + (decimal)packageList[i].PkgAgencyCommission;
                    subCost.Add(rowSubCost);
                }

                minBasePrice = subCost.Min();
                txtMinBasePrice.Text = minBasePrice.ToString("c");
                maxBasePrice = subCost.Max();
                txtMaxBasePrice.Text = maxBasePrice.ToString("c");
            }
            else
            {
                minBasePrice = packageList.Min(r => r.PkgBasePrice);
                txtMinBasePrice.Text = minBasePrice.ToString("c");
                maxBasePrice = packageList.Max(r => r.PkgBasePrice);
                txtMaxBasePrice.Text = maxBasePrice.ToString("c");
            }

            for (int i = 0; i < rows; i++)
            {
                rowDuration = (int)((DateTime)packageList[i].PkgEndDate - (DateTime)packageList[i].PkgStartDate).TotalDays;
                duration.Add(rowDuration);
            }

            minDuration = duration.Min();
            txtMinDuration.Text = minDuration.ToString();
            maxDuration = duration.Max();
            txtMaxDuration.Text = maxDuration.ToString();

            supplierList = SupplierDB.GetSuppliers();
            txtTotalNumSuppliers.Text = supplierList.Count.ToString();

            engagedSuppliers = SupplierDB.GetEngagedSuppliers();
            txtEngagedSuppliers.Text = engagedSuppliers.Count.ToString();

            productList = ProductDB.GetProducts();
            txtTotalNumProducts.Text = productList.Count.ToString();

            engagedProducts = ProductDB.GetEngagedProducts();
            txtEngagedProducts.Text = engagedProducts.Count.ToString();
        }
    }
}
