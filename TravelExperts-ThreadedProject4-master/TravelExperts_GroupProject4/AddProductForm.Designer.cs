namespace TravelExperts_Group3
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblProduct = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstAllProducts = new System.Windows.Forms.ListBox();
            this.lblAddProd = new System.Windows.Forms.Label();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.lblPackageName = new System.Windows.Forms.Label();
            this.lblPackageId = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblListNewProd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(158, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 114);
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(204, 499);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 32);
            this.btnCancel.TabIndex = 59;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(12, 441);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 32);
            this.btnAdd.TabIndex = 58;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(12, 18);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(140, 25);
            this.lblProduct.TabIndex = 57;
            this.lblProduct.Text = "Edit Products";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(14, 43);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(140, 13);
            this.labelName.TabIndex = 45;
            this.labelName.Text = "Add Remove Products From";
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.Location = new System.Drawing.Point(12, 132);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(308, 82);
            this.lstProducts.TabIndex = 61;
            this.lstProducts.SelectedIndexChanged += new System.EventHandler(this.LstProducts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Current Products";
            // 
            // lstAllProducts
            // 
            this.lstAllProducts.FormattingEnabled = true;
            this.lstAllProducts.Location = new System.Drawing.Point(12, 288);
            this.lstAllProducts.Name = "lstAllProducts";
            this.lstAllProducts.Size = new System.Drawing.Size(308, 147);
            this.lstAllProducts.TabIndex = 63;
            this.lstAllProducts.SelectedIndexChanged += new System.EventHandler(this.LstAllProducts_SelectedIndexChanged);
            // 
            // lblAddProd
            // 
            this.lblAddProd.AutoSize = true;
            this.lblAddProd.Location = new System.Drawing.Point(14, 272);
            this.lblAddProd.Name = "lblAddProd";
            this.lblAddProd.Size = new System.Drawing.Size(101, 13);
            this.lblAddProd.TabIndex = 64;
            this.lblAddProd.Text = "Add A New Product";
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(12, 220);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(116, 32);
            this.btnRemoveProduct.TabIndex = 65;
            this.btnRemoveProduct.Text = "Remove";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.BtnRemoveProduct_Click);
            // 
            // lblPackageName
            // 
            this.lblPackageName.AutoSize = true;
            this.lblPackageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackageName.Location = new System.Drawing.Point(13, 62);
            this.lblPackageName.Name = "lblPackageName";
            this.lblPackageName.Size = new System.Drawing.Size(145, 24);
            this.lblPackageName.TabIndex = 67;
            this.lblPackageName.Text = "PackageName";
            // 
            // lblPackageId
            // 
            this.lblPackageId.AutoSize = true;
            this.lblPackageId.BackColor = System.Drawing.SystemColors.Control;
            this.lblPackageId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackageId.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPackageId.Location = new System.Drawing.Point(14, 86);
            this.lblPackageId.Name = "lblPackageId";
            this.lblPackageId.Size = new System.Drawing.Size(58, 13);
            this.lblPackageId.TabIndex = 68;
            this.lblPackageId.Text = "packageId";
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.BackColor = System.Drawing.SystemColors.Control;
            this.lblProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProductId.Location = new System.Drawing.Point(91, 86);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProductId.Size = new System.Drawing.Size(52, 13);
            this.lblProductId.TabIndex = 69;
            this.lblProductId.Text = "productId";
            // 
            // lblListNewProd
            // 
            this.lblListNewProd.AutoSize = true;
            this.lblListNewProd.BackColor = System.Drawing.SystemColors.Control;
            this.lblListNewProd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblListNewProd.Location = new System.Drawing.Point(239, 441);
            this.lblListNewProd.Name = "lblListNewProd";
            this.lblListNewProd.Size = new System.Drawing.Size(77, 13);
            this.lblListNewProd.TabIndex = 70;
            this.lblListNewProd.Text = "lblListNewProd";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(332, 543);
            this.Controls.Add(this.lblListNewProd);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.lblPackageId);
            this.Controls.Add(this.lblPackageName);
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.lblAddProd);
            this.Controls.Add(this.lstAllProducts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.labelName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstAllProducts;
        private System.Windows.Forms.Label lblAddProd;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Label lblPackageName;
        private System.Windows.Forms.Label lblPackageId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblListNewProd;
    }
}