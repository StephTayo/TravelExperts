using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExperts_GroupProject4
{
    public partial class EditPackageForm : Form
    {
        public EditPackageForm(string packageId, string packageName, DateTime packageStartDate, DateTime packageEndDate, string packageDescription, string packageBasePrice, string packageCommission)
        {
            InitializeComponent();

            txtPackageID.Text = packageId;
            txtPackageName.Text = packageName;
            dateStart.Value = packageStartDate;
            dateEnd.Value = packageEndDate;
            txtPackageDesc.Text = packageDescription;
            txtBasePrice.Text = packageBasePrice;
            txtCommission.Text = packageCommission;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // strip dollar signs
            string packageBase = Regex.Replace(txtBasePrice.Text, "\\$", "");
            string packageComm = Regex.Replace(txtCommission.Text, "\\$", "");

            int packageId = Convert.ToInt32(txtPackageID.Text);
            string packageName = txtPackageName.Text;
            DateTime packageStartDate = dateStart.Value;
            DateTime packageEndDate = dateEnd.Value;
            string packageDescription = txtPackageDesc.Text;
            double packageBasePrice = Convert.ToDouble(packageBase);
            double packageCommission = Convert.ToDouble(packageComm);
            try
            {
                TravelPackageDB updateTravelPackage = new TravelPackageDB();
                updateTravelPackage.EditTravelPackage(packageId, packageName, packageStartDate, packageEndDate, packageDescription, packageBasePrice, packageCommission);

                this.Close();
                TravelPackageForm refreshFrom = new TravelPackageForm();
                refreshFrom.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }
    }
}
