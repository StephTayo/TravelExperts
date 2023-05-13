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
    public partial class AddSupplierForm : Form
    {
        public AddSupplierForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SupplierForm suppForm = new SupplierForm();
            suppForm.Show();
            Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validator.IsNotEmpty(txtSupplierName, "Supplier Name") &&
            Validator.IsNotEmpty(txtSupplierID, "Supplier Id")) 
            {
                // inputing value into a variable

                int supId = Convert.ToInt32(txtSupplierID.Text);
                string supName = txtSupplierName.Text;

                try
                {
                    TravelSupplierDB addNewSupp = new TravelSupplierDB();
                    
                    addNewSupp.AddSupplier(supId, supName);

                    
                    SupplierForm refreshForm = new SupplierForm();
                    refreshForm.Show();
                    refreshForm.Refresh();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }
    }
}
