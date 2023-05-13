namespace TravelExperts_Group3
{
    partial class SupplierForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.lstViewSupplier = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSupName = new System.Windows.Forms.Label();
            this.lblSupID = new System.Windows.Forms.Label();
            this.lstBoxProducts = new System.Windows.Forms.ListBox();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier Detail";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(15, 274);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(134, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(178, 274);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(335, 274);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(134, 23);
            this.btnAddSupplier.TabIndex = 4;
            this.btnAddSupplier.Text = "Add Supplier";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // lstViewSupplier
            // 
            this.lstViewSupplier.HideSelection = false;
            this.lstViewSupplier.Location = new System.Drawing.Point(12, 25);
            this.lstViewSupplier.Name = "lstViewSupplier";
            this.lstViewSupplier.Size = new System.Drawing.Size(593, 238);
            this.lstViewSupplier.TabIndex = 5;
            this.lstViewSupplier.UseCompatibleStateImageBehavior = false;
            this.lstViewSupplier.SelectedIndexChanged += new System.EventHandler(this.lstViewSupplier_SelectedIndexChanged);
            this.lstViewSupplier.DoubleClick += new System.EventHandler(this.btnEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selected Supplier Info";
            // 
            // lblSupName
            // 
            this.lblSupName.AutoSize = true;
            this.lblSupName.Location = new System.Drawing.Point(101, 357);
            this.lblSupName.Name = "lblSupName";
            this.lblSupName.Size = new System.Drawing.Size(0, 13);
            this.lblSupName.TabIndex = 7;
            // 
            // lblSupID
            // 
            this.lblSupID.AutoSize = true;
            this.lblSupID.Location = new System.Drawing.Point(12, 357);
            this.lblSupID.Name = "lblSupID";
            this.lblSupID.Size = new System.Drawing.Size(0, 13);
            this.lblSupID.TabIndex = 8;
            // 
            // lstBoxProducts
            // 
            this.lstBoxProducts.FormattingEnabled = true;
            this.lstBoxProducts.Location = new System.Drawing.Point(611, 25);
            this.lstBoxProducts.Name = "lstBoxProducts";
            this.lstBoxProducts.Size = new System.Drawing.Size(173, 238);
            this.lstBoxProducts.TabIndex = 20;
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(650, 274);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(134, 23);
            this.btnGoBack.TabIndex = 21;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(608, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Products";
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(796, 393);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.lstBoxProducts);
            this.Controls.Add(this.lblSupID);
            this.Controls.Add(this.lblSupName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstViewSupplier);
            this.Controls.Add(this.btnAddSupplier);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SupplierForm";
            this.Text = "SupplierForm";
            this.DoubleClick += new System.EventHandler(this.lstViewSupplier_SelectedIndexChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.ListView lstViewSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSupName;
        private System.Windows.Forms.Label lblSupID;
        private System.Windows.Forms.ListBox lstBoxProducts;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label label3;
    }
}