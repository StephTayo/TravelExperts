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
    public partial class AddPackageForm : Form
    {
        public AddPackageForm()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // strip dollar signs
            string packageBase = Regex.Replace(txtBasePrice.Text, "\\$", "");
            string packageComm = Regex.Replace(txtCommission.Text, "\\$", "");

            string packageName = txtPackageName.Text;
            DateTime packageStartDate = dateStart.Value;
            DateTime packageEndDate = dateEnd.Value;
            string packageDescription = txtPackageDesc.Text;
            double packageBasePrice = Convert.ToDouble(packageBase);
            double packageCommission = Convert.ToDouble(packageComm);
            try
            {
                TravelPackageDB addNewPackage = new TravelPackageDB();
                addNewPackage.AddTravelPackage(packageName, packageStartDate, packageEndDate, packageDescription, packageBasePrice, packageCommission);

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
