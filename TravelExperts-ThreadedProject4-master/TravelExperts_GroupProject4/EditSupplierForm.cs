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
    public partial class EditSupplierForm : Form
    {
        public EditSupplierForm(string supplierId, string supplierName)
        {
            InitializeComponent();

            txtSupplierID.Text = supplierId;
            txtSupplierName.Text = supplierName;

        }
        // close and cancel form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            SupplierForm suppForm = new SupplierForm();
            suppForm.Show();
            Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validator.IsNotEmpty(txtSupplierName, "Supplier Name"))
            { 
                int supId = Convert.ToInt32(txtSupplierID.Text);
                string supName = txtSupplierName.Text;

                try
                {
                    TravelSupplierDB updateSuppliers = new TravelSupplierDB();
                    updateSuppliers.EditSupplier(supId, supName);

                    this.Close();
                    SupplierForm refreshSupplier = new SupplierForm();
                    refreshSupplier.Show();
                    refreshSupplier.Refresh();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
