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
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();

            List<Supplier> item = TravelSupplierDB.GetSupplier(lstViewSupplier);
        }
        //display list of supplier
        private void lstViewSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

            TravelSupplierDB supplierDetails = new TravelSupplierDB();
            supplierDetails.SelectedSupplier(lstViewSupplier, lblSupID, lblSupName);

            int suppId = Convert.ToInt32(lblSupID.Text);
            List<Supplier> prod = TravelSupplierDB.GetProducts(lstBoxProducts, suppId);
        }
        // allows for modification
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lblSupID.Text == "")
            {
                MessageBox.Show("A product must be selected");
            }
            else
            {
                string supplierId = lblSupID.Text;
                string supplierName = lblSupName.Text;
                
                EditSupplierForm updatesupplierListForm = new EditSupplierForm(supplierId, supplierName);
                updatesupplierListForm.FormClosed += new FormClosedEventHandler(UpdateForm_FormClosed);
                updatesupplierListForm.Show();
                this.Close();
            }   
        }
        //create new supplier
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            AddSupplierForm addedSupplier = new AddSupplierForm();
            addedSupplier.FormClosed += new FormClosedEventHandler(UpdateForm_FormClosed);
            addedSupplier.Show();
            this.Close();
        }

        //remove highlighted detail
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int supplierID = Convert.ToInt32(lblSupID.Text);
            TravelSupplierDB deleteSupplier = new TravelSupplierDB();
            deleteSupplier.DeleteSupplier(lstViewSupplier, supplierID);

            this.Close();
            SupplierForm refreshFrom = new SupplierForm();
            refreshFrom.Refresh();
            refreshFrom.Show();


        }
        private void UpdateForm_FormClosed(object sender, EventArgs e)
        {
        
        }

        private void listViewProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

            SupplierForm refreshFrom = new SupplierForm();
            refreshFrom.Refresh();
        }

        //close and cancel form
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            new HomePage().Show();
            Close();
        }
    }
}
