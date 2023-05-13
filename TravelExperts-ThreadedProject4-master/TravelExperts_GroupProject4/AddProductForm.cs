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
    public partial class AddProductForm : Form
    {
        // lists all products in package and available products not yet added
        public AddProductForm(int packageId, string packageName)
        {
            InitializeComponent();

            lblPackageName.Text = packageName;
            lblPackageId.Text = Convert.ToString(packageId);

            if (lstProducts.Items != null)
            {
                List<Package> packageProducts = TravelPackageDB.GetPackageProducts(lstProducts, packageId);
                List<Package> showProducts = TravelPackageDB.ShowAllProducts(lstAllProducts, packageId);
            }
        }

        // remove product from package
        private void BtnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedItem == null)
            {
                MessageBox.Show("A product must be selected to remove");
            }
            else
            {
                int packageId = Convert.ToInt32(lblPackageId.Text);
                int productId = Convert.ToInt32(lblProductId.Text);

                TravelPackageDB removeProduct = new TravelPackageDB();
                removeProduct.RemovePackageProduct(productId, packageId);
                List<Package> refreshProducts = TravelPackageDB.GetPackageProducts(lstProducts, packageId);
                List<Package> showProducts = TravelPackageDB.ShowAllProducts(lstAllProducts, packageId);
            }  
        }

        // add product to package
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if(lstAllProducts.SelectedItem == null)
            {
                MessageBox.Show("A product must be selected to add");
            }
            else
            {
                int packageId = Convert.ToInt32(lblPackageId.Text);
                int productId = Convert.ToInt32(lblListNewProd.Text);

                TravelPackageDB getProdSupplierId = new TravelPackageDB();
                int supplierId = getProdSupplierId.GetSupplierId(productId);
                getProdSupplierId.AddPackageToProd(Convert.ToInt32(lblPackageId.Text), supplierId);
                List<Package> refreshProducts = TravelPackageDB.GetPackageProducts(lstProducts, packageId);
                List<Package> showProducts = TravelPackageDB.ShowAllProducts(lstAllProducts, packageId);
            }
        }

        // selects the index of the selected product added to package
        private void LstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            TravelPackageDB getProdId = new TravelPackageDB();
            getProdId.GetProductId(lstProducts.Text, lblProductId);
        }

        // selects index of product not added to package
        private void LstAllProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            TravelPackageDB getProdId = new TravelPackageDB();
            getProdId.GetProductId(lstAllProducts.Text, lblListNewProd);
        }

        // cancel and close form
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
