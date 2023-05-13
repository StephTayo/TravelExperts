namespace TravelExperts_Group3
{
    partial class TravelPackageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TravelPackageForm));
            this.lstViewTravelPackages = new System.Windows.Forms.ListView();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelDescript = new System.Windows.Forms.Label();
            this.labelBase = new System.Windows.Forms.Label();
            this.labelComm = new System.Windows.Forms.Label();
            this.lblPackageName = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.lblCommission = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnEditPackage = new System.Windows.Forms.Button();
            this.btnDeletePackage = new System.Windows.Forms.Button();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.lblPackageID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.lblPackages = new System.Windows.Forms.Label();
            this.btnEditProducts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstViewTravelPackages
            // 
            this.lstViewTravelPackages.HideSelection = false;
            this.lstViewTravelPackages.Location = new System.Drawing.Point(12, 12);
            this.lstViewTravelPackages.Name = "lstViewTravelPackages";
            this.lstViewTravelPackages.Size = new System.Drawing.Size(776, 217);
            this.lstViewTravelPackages.TabIndex = 0;
            this.lstViewTravelPackages.UseCompatibleStateImageBehavior = false;
            this.lstViewTravelPackages.SelectedIndexChanged += new System.EventHandler(this.LstViewTravelPackages_SelectedIndexChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(22, 285);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(81, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Package Name";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDate.Location = new System.Drawing.Point(391, 285);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(55, 13);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Start Date";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.BackColor = System.Drawing.Color.Transparent;
            this.labelEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelEnd.Location = new System.Drawing.Point(508, 285);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(52, 13);
            this.labelEnd.TabIndex = 3;
            this.labelEnd.Text = "End Date";
            // 
            // labelDescript
            // 
            this.labelDescript.AutoSize = true;
            this.labelDescript.Location = new System.Drawing.Point(22, 347);
            this.labelDescript.Name = "labelDescript";
            this.labelDescript.Size = new System.Drawing.Size(60, 13);
            this.labelDescript.TabIndex = 4;
            this.labelDescript.Text = "Description";
            // 
            // labelBase
            // 
            this.labelBase.AutoSize = true;
            this.labelBase.BackColor = System.Drawing.Color.Transparent;
            this.labelBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelBase.Location = new System.Drawing.Point(391, 347);
            this.labelBase.Name = "labelBase";
            this.labelBase.Size = new System.Drawing.Size(58, 13);
            this.labelBase.TabIndex = 5;
            this.labelBase.Text = "Base Price";
            // 
            // labelComm
            // 
            this.labelComm.AutoSize = true;
            this.labelComm.BackColor = System.Drawing.Color.Transparent;
            this.labelComm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelComm.Location = new System.Drawing.Point(508, 347);
            this.labelComm.Name = "labelComm";
            this.labelComm.Size = new System.Drawing.Size(62, 13);
            this.labelComm.TabIndex = 6;
            this.labelComm.Text = "Commission";
            // 
            // lblPackageName
            // 
            this.lblPackageName.AutoSize = true;
            this.lblPackageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackageName.Location = new System.Drawing.Point(21, 305);
            this.lblPackageName.Name = "lblPackageName";
            this.lblPackageName.Size = new System.Drawing.Size(0, 20);
            this.lblPackageName.TabIndex = 7;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblStartDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(390, 305);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(0, 20);
            this.lblStartDate.TabIndex = 8;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lblEndDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(507, 305);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(0, 20);
            this.lblEndDate.TabIndex = 9;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(22, 365);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(0, 20);
            this.lblDescription.TabIndex = 10;
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.BackColor = System.Drawing.Color.Transparent;
            this.lblBasePrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasePrice.Location = new System.Drawing.Point(390, 365);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(0, 20);
            this.lblBasePrice.TabIndex = 11;
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.BackColor = System.Drawing.Color.Transparent;
            this.lblCommission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommission.Location = new System.Drawing.Point(507, 365);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(0, 20);
            this.lblCommission.TabIndex = 12;
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(12, 405);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(145, 26);
            this.btnGoBack.TabIndex = 13;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.BtnGoBack_Click);
            // 
            // btnEditPackage
            // 
            this.btnEditPackage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditPackage.Location = new System.Drawing.Point(12, 235);
            this.btnEditPackage.Name = "btnEditPackage";
            this.btnEditPackage.Size = new System.Drawing.Size(145, 26);
            this.btnEditPackage.TabIndex = 14;
            this.btnEditPackage.Text = "Edit";
            this.btnEditPackage.UseVisualStyleBackColor = true;
            this.btnEditPackage.Click += new System.EventHandler(this.BtnEditPackage_Click);
            // 
            // btnDeletePackage
            // 
            this.btnDeletePackage.Location = new System.Drawing.Point(168, 235);
            this.btnDeletePackage.Name = "btnDeletePackage";
            this.btnDeletePackage.Size = new System.Drawing.Size(145, 26);
            this.btnDeletePackage.TabIndex = 15;
            this.btnDeletePackage.Text = "Delete";
            this.btnDeletePackage.UseVisualStyleBackColor = true;
            this.btnDeletePackage.Click += new System.EventHandler(this.BtnDeletePackage_Click);
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Location = new System.Drawing.Point(643, 235);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(145, 26);
            this.btnAddPackage.TabIndex = 16;
            this.btnAddPackage.Text = "Add A Travel Package";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.BtnAddPackage_Click);
            // 
            // lblPackageID
            // 
            this.lblPackageID.AutoSize = true;
            this.lblPackageID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPackageID.Location = new System.Drawing.Point(109, 285);
            this.lblPackageID.Name = "lblPackageID";
            this.lblPackageID.Size = new System.Drawing.Size(0, 13);
            this.lblPackageID.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(319, 235);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 215);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lstProducts
            // 
            this.lstProducts.BackColor = System.Drawing.SystemColors.Window;
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.Location = new System.Drawing.Point(643, 305);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstProducts.Size = new System.Drawing.Size(145, 95);
            this.lstProducts.TabIndex = 19;
            // 
            // lblPackages
            // 
            this.lblPackages.AutoSize = true;
            this.lblPackages.Location = new System.Drawing.Point(640, 285);
            this.lblPackages.Name = "lblPackages";
            this.lblPackages.Size = new System.Drawing.Size(49, 13);
            this.lblPackages.TabIndex = 20;
            this.lblPackages.Text = "Products";
            // 
            // btnEditProducts
            // 
            this.btnEditProducts.Location = new System.Drawing.Point(643, 405);
            this.btnEditProducts.Name = "btnEditProducts";
            this.btnEditProducts.Size = new System.Drawing.Size(145, 26);
            this.btnEditProducts.TabIndex = 21;
            this.btnEditProducts.Text = "Edit Products";
            this.btnEditProducts.UseVisualStyleBackColor = true;
            this.btnEditProducts.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // TravelPackageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditProducts);
            this.Controls.Add(this.lblPackages);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.lblPackageID);
            this.Controls.Add(this.btnAddPackage);
            this.Controls.Add(this.btnDeletePackage);
            this.Controls.Add(this.btnEditPackage);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.lblCommission);
            this.Controls.Add(this.lblBasePrice);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblPackageName);
            this.Controls.Add(this.labelComm);
            this.Controls.Add(this.labelBase);
            this.Controls.Add(this.labelDescript);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.lstViewTravelPackages);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TravelPackageForm";
            this.Text = "Travel Packages";
            this.Load += new System.EventHandler(this.AddPackageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstViewTravelPackages;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelDescript;
        private System.Windows.Forms.Label labelBase;
        private System.Windows.Forms.Label labelComm;
        private System.Windows.Forms.Label lblPackageName;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Label lblCommission;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnEditPackage;
        private System.Windows.Forms.Button btnDeletePackage;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.Label lblPackageID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Label lblPackages;
        private System.Windows.Forms.Button btnEditProducts;
    }
}