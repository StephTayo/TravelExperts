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

namespace TravelExperts_GroupProject4
{
    public partial class TravelPackageForm : Form
    {
        public TravelPackageForm()
        {
            InitializeComponent();
        }

        private void AddPackageForm_Load(object sender, EventArgs e)
        {
            List<Package> packageView = TravelPackageDB.GetPackages(lstViewTravelPackages);
            ClearLabels();
            btnEditPackage.Enabled = false;
            btnDeletePackage.Enabled = false;
        }

        private void LstViewTravelPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            TravelPackageDB packageDetails = new TravelPackageDB();
            packageDetails.ShowSelectedOrder(lstViewTravelPackages, lblPackageID, lblPackageName, lblStartDate, lblEndDate, lblDescription, lblBasePrice, lblCommission);
            ShowLabels();
            btnEditPackage.Enabled = true;
            btnDeletePackage.Enabled = true;

            int packageId = Convert.ToInt32(lblPackageID.Text);
            List<Package> packageProducts = TravelPackageDB.GetPackageProducts(lstProducts, packageId);
        }

        private void ClearLabels()
        {
            labelName.Text = "";
            lblPackageName.Text = "";
            labelDate.Text = "";
            lblStartDate.Text = "";
            labelEnd.Text = "";
            lblEndDate.Text = "";
            labelDescript.Text = "";
            lblDescription.Text = "";
            labelBase.Text = "";
            lblBasePrice.Text = "";
            labelComm.Text = "";
            lblCommission.Text = "";
        }

        private void ShowLabels()
        {
            labelName.Text = "Package Name";
            labelDate.Text = "Start Date";
            labelEnd.Text = "End Date";
            labelDescript.Text = "Description";
            labelBase.Text = "Base Price";
            labelComm.Text = "Agency Commission";
        }

        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            new HomePage().Show();
            Close();
        }

        private void BtnEditPackage_Click(object sender, EventArgs e)
        {
            string packageId = lblPackageID.Text;
            string packageName = lblPackageName.Text;
            DateTime packageStartDate = Convert.ToDateTime(lblStartDate.Text);
            DateTime packageEndDate = Convert.ToDateTime(lblEndDate.Text);
            string packageDescription = lblDescription.Text;
            string packageBasePrice = lblBasePrice.Text;
            string packageCommission = lblCommission.Text;

            EditPackageForm updatePkgForm = new EditPackageForm(packageId, packageName, packageStartDate, packageEndDate, packageDescription, packageBasePrice, packageCommission);
            updatePkgForm.FormClosed += new FormClosedEventHandler(UpdatePkgForm_FormClosed);
            updatePkgForm.Show();
        }

        private void UpdatePkgForm_FormClosed(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void BtnDeletePackage_Click(object sender, EventArgs e)
        {
            string packageName = lblPackageName.Text;
            DialogResult deleteClient = MessageBox.Show("Are you sure you want to delete the " + packageName + " package?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteClient == DialogResult.Yes)
            {
                int packageID = Convert.ToInt32(lblPackageID.Text);
                TravelPackageDB deletePackage = new TravelPackageDB();
                   deletePackage.DeleteTravelPackage(lstViewTravelPackages, packageID);

                ClearForm();
            }
        }

        private void ClearForm()
        {
            lstViewTravelPackages.Clear();
            List<Package> refreshPackageView = TravelPackageDB.GetPackages(lstViewTravelPackages);
            ClearLabels();
            btnEditPackage.Enabled = false;
            btnDeletePackage.Enabled = false;
        }

        private void BtnAddPackage_Click(object sender, EventArgs e)
        {
            AddPackageForm addPkgForm = new AddPackageForm();
            addPkgForm.FormClosed += new FormClosedEventHandler(UpdatePkgForm_FormClosed);
            addPkgForm.Show();
        }
    }
}
