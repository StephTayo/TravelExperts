namespace TravelExperts_Group3
{
    partial class AddPackageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPackageForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.txtCommission = new System.Windows.Forms.TextBox();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.txtPackageDesc = new System.Windows.Forms.TextBox();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.labelComm = new System.Windows.Forms.Label();
            this.labelBase = new System.Windows.Forms.Label();
            this.labelDescript = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(374, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 97);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(434, 305);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 32);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(203, 305);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 32);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Save Package";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 25);
            this.label2.TabIndex = 41;
            this.label2.Text = "Add A Travel Package";
            // 
            // dateEnd
            // 
            this.dateEnd.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnd.Location = new System.Drawing.Point(434, 208);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(208, 20);
            this.dateEnd.TabIndex = 38;
            // 
            // dateStart
            // 
            this.dateStart.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart.Location = new System.Drawing.Point(111, 208);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(208, 20);
            this.dateStart.TabIndex = 37;
            // 
            // txtCommission
            // 
            this.txtCommission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommission.Location = new System.Drawing.Point(434, 265);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.Size = new System.Drawing.Size(208, 20);
            this.txtCommission.TabIndex = 36;
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasePrice.Location = new System.Drawing.Point(111, 263);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(208, 20);
            this.txtBasePrice.TabIndex = 35;
            // 
            // txtPackageDesc
            // 
            this.txtPackageDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPackageDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageDesc.Location = new System.Drawing.Point(434, 130);
            this.txtPackageDesc.Multiline = true;
            this.txtPackageDesc.Name = "txtPackageDesc";
            this.txtPackageDesc.Size = new System.Drawing.Size(208, 58);
            this.txtPackageDesc.TabIndex = 34;
            // 
            // txtPackageName
            // 
            this.txtPackageName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPackageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageName.Location = new System.Drawing.Point(111, 136);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(208, 20);
            this.txtPackageName.TabIndex = 33;
            // 
            // labelComm
            // 
            this.labelComm.AutoSize = true;
            this.labelComm.Location = new System.Drawing.Point(357, 267);
            this.labelComm.Name = "labelComm";
            this.labelComm.Size = new System.Drawing.Size(62, 13);
            this.labelComm.TabIndex = 32;
            this.labelComm.Text = "Commission";
            // 
            // labelBase
            // 
            this.labelBase.AutoSize = true;
            this.labelBase.Location = new System.Drawing.Point(36, 265);
            this.labelBase.Name = "labelBase";
            this.labelBase.Size = new System.Drawing.Size(58, 13);
            this.labelBase.TabIndex = 31;
            this.labelBase.Text = "Base Price";
            // 
            // labelDescript
            // 
            this.labelDescript.AutoSize = true;
            this.labelDescript.Location = new System.Drawing.Point(359, 139);
            this.labelDescript.Name = "labelDescript";
            this.labelDescript.Size = new System.Drawing.Size(60, 13);
            this.labelDescript.TabIndex = 30;
            this.labelDescript.Text = "Description";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(367, 214);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(52, 13);
            this.labelEnd.TabIndex = 29;
            this.labelEnd.Text = "End Date";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(39, 214);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(55, 13);
            this.labelDate.TabIndex = 28;
            this.labelDate.Text = "Start Date";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 139);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(81, 13);
            this.labelName.TabIndex = 27;
            this.labelName.Text = "Package Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 310);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 42);
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // AddPackageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(654, 364);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.txtCommission);
            this.Controls.Add(this.txtBasePrice);
            this.Controls.Add(this.txtPackageDesc);
            this.Controls.Add(this.txtPackageName);
            this.Controls.Add(this.labelComm);
            this.Controls.Add(this.labelBase);
            this.Controls.Add(this.labelDescript);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPackageForm";
            this.Text = "AddPackageForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.TextBox txtCommission;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.TextBox txtPackageDesc;
        private System.Windows.Forms.TextBox txtPackageName;
        private System.Windows.Forms.Label labelComm;
        private System.Windows.Forms.Label labelBase;
        private System.Windows.Forms.Label labelDescript;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}