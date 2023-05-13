namespace TravelExperts_Group3
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.btnPackages = new System.Windows.Forms.Button();
            this.txtMaxBasePrice = new System.Windows.Forms.TextBox();
            this.lblCostMax = new System.Windows.Forms.Label();
            this.txtMinBasePrice = new System.Windows.Forms.TextBox();
            this.lblCostMin = new System.Windows.Forms.Label();
            this.txtMaxDuration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMinDuration = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPackageCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalNumSuppliers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEngagedSuppliers = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalNumProducts = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEngagedProducts = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPackages
            // 
            this.btnPackages.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPackages.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPackages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPackages.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPackages.Location = new System.Drawing.Point(12, 423);
            this.btnPackages.Name = "btnPackages";
            this.btnPackages.Size = new System.Drawing.Size(122, 47);
            this.btnPackages.TabIndex = 0;
            this.btnPackages.Text = "Packages";
            this.btnPackages.UseVisualStyleBackColor = false;
            this.btnPackages.Click += new System.EventHandler(this.BtnPackages_Click);
            // 
            // txtMaxBasePrice
            // 
            this.txtMaxBasePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaxBasePrice.Enabled = false;
            this.txtMaxBasePrice.Location = new System.Drawing.Point(400, 121);
            this.txtMaxBasePrice.Name = "txtMaxBasePrice";
            this.txtMaxBasePrice.Size = new System.Drawing.Size(69, 20);
            this.txtMaxBasePrice.TabIndex = 20;
            // 
            // lblCostMax
            // 
            this.lblCostMax.AutoSize = true;
            this.lblCostMax.Location = new System.Drawing.Point(258, 124);
            this.lblCostMax.Name = "lblCostMax";
            this.lblCostMax.Size = new System.Drawing.Size(97, 13);
            this.lblCostMax.TabIndex = 19;
            this.lblCostMax.Text = "Highest Base Price";
            // 
            // txtMinBasePrice
            // 
            this.txtMinBasePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMinBasePrice.Enabled = false;
            this.txtMinBasePrice.Location = new System.Drawing.Point(167, 121);
            this.txtMinBasePrice.Name = "txtMinBasePrice";
            this.txtMinBasePrice.Size = new System.Drawing.Size(69, 20);
            this.txtMinBasePrice.TabIndex = 18;
            // 
            // lblCostMin
            // 
            this.lblCostMin.AutoSize = true;
            this.lblCostMin.Location = new System.Drawing.Point(25, 124);
            this.lblCostMin.Name = "lblCostMin";
            this.lblCostMin.Size = new System.Drawing.Size(98, 13);
            this.lblCostMin.TabIndex = 17;
            this.lblCostMin.Text = "Lowest Base Price:";
            // 
            // txtMaxDuration
            // 
            this.txtMaxDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaxDuration.Enabled = false;
            this.txtMaxDuration.Location = new System.Drawing.Point(400, 95);
            this.txtMaxDuration.Name = "txtMaxDuration";
            this.txtMaxDuration.Size = new System.Drawing.Size(69, 20);
            this.txtMaxDuration.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Maximum Duration (Days):";
            // 
            // txtMinDuration
            // 
            this.txtMinDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMinDuration.Enabled = false;
            this.txtMinDuration.Location = new System.Drawing.Point(167, 95);
            this.txtMinDuration.Name = "txtMinDuration";
            this.txtMinDuration.Size = new System.Drawing.Size(69, 20);
            this.txtMinDuration.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Minimum Duration (Days):";
            // 
            // txtPackageCount
            // 
            this.txtPackageCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPackageCount.Enabled = false;
            this.txtPackageCount.Location = new System.Drawing.Point(167, 67);
            this.txtPackageCount.Name = "txtPackageCount";
            this.txtPackageCount.Size = new System.Drawing.Size(69, 20);
            this.txtPackageCount.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total Number of Packages:";
            // 
            // txtTotalNumSuppliers
            // 
            this.txtTotalNumSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalNumSuppliers.Enabled = false;
            this.txtTotalNumSuppliers.Location = new System.Drawing.Point(400, 176);
            this.txtTotalNumSuppliers.Name = "txtTotalNumSuppliers";
            this.txtTotalNumSuppliers.Size = new System.Drawing.Size(69, 20);
            this.txtTotalNumSuppliers.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Total Number of Suppliers:";
            // 
            // txtEngagedSuppliers
            // 
            this.txtEngagedSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEngagedSuppliers.Enabled = false;
            this.txtEngagedSuppliers.Location = new System.Drawing.Point(167, 176);
            this.txtEngagedSuppliers.Name = "txtEngagedSuppliers";
            this.txtEngagedSuppliers.Size = new System.Drawing.Size(69, 20);
            this.txtEngagedSuppliers.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Engaged Suppliers:";
            // 
            // txtTotalNumProducts
            // 
            this.txtTotalNumProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalNumProducts.Enabled = false;
            this.txtTotalNumProducts.Location = new System.Drawing.Point(400, 202);
            this.txtTotalNumProducts.Name = "txtTotalNumProducts";
            this.txtTotalNumProducts.Size = new System.Drawing.Size(69, 20);
            this.txtTotalNumProducts.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Total Number of Products:";
            // 
            // txtEngagedProducts
            // 
            this.txtEngagedProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEngagedProducts.Enabled = false;
            this.txtEngagedProducts.Location = new System.Drawing.Point(167, 202);
            this.txtEngagedProducts.Name = "txtEngagedProducts";
            this.txtEngagedProducts.Size = new System.Drawing.Size(69, 20);
            this.txtEngagedProducts.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Products in Current Use:";
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProducts.Location = new System.Drawing.Point(200, 423);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(121, 47);
            this.btnProducts.TabIndex = 29;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSuppliers.Location = new System.Drawing.Point(387, 423);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(123, 47);
            this.btnSuppliers.TabIndex = 30;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.UseVisualStyleBackColor = false;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(369, 25);
            this.label10.TabIndex = 31;
            this.label10.Text = "Packages Summary and Overview";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(311, 152);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(158, 17);
            this.checkBox1.TabIndex = 32;
            this.checkBox1.Text = "Include Agency Commission";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnlHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHome.Controls.Add(this.checkBox1);
            this.pnlHome.Controls.Add(this.label10);
            this.pnlHome.Controls.Add(this.label2);
            this.pnlHome.Controls.Add(this.txtPackageCount);
            this.pnlHome.Controls.Add(this.txtTotalNumProducts);
            this.pnlHome.Controls.Add(this.label3);
            this.pnlHome.Controls.Add(this.label8);
            this.pnlHome.Controls.Add(this.txtMinDuration);
            this.pnlHome.Controls.Add(this.txtEngagedProducts);
            this.pnlHome.Controls.Add(this.label4);
            this.pnlHome.Controls.Add(this.label9);
            this.pnlHome.Controls.Add(this.txtMaxDuration);
            this.pnlHome.Controls.Add(this.txtTotalNumSuppliers);
            this.pnlHome.Controls.Add(this.lblCostMin);
            this.pnlHome.Controls.Add(this.label1);
            this.pnlHome.Controls.Add(this.txtMinBasePrice);
            this.pnlHome.Controls.Add(this.txtEngagedSuppliers);
            this.pnlHome.Controls.Add(this.lblCostMax);
            this.pnlHome.Controls.Add(this.label7);
            this.pnlHome.Controls.Add(this.txtMaxBasePrice);
            this.pnlHome.Location = new System.Drawing.Point(12, 163);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(498, 245);
            this.pnlHome.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(459, 73);
            this.label5.TabIndex = 34;
            this.label5.Text = "Travel Experts";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlHome);
            this.Controls.Add(this.btnPackages);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnProducts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePage";
            this.Text = "Travel Experts";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPackages;
        private System.Windows.Forms.TextBox txtMaxBasePrice;
        private System.Windows.Forms.Label lblCostMax;
        private System.Windows.Forms.TextBox txtMinBasePrice;
        private System.Windows.Forms.Label lblCostMin;
        private System.Windows.Forms.TextBox txtMaxDuration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMinDuration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPackageCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalNumSuppliers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEngagedSuppliers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalNumProducts;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEngagedProducts;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Label label5;
    }
}

