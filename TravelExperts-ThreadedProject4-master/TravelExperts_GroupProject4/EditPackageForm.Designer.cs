namespace TravelExperts_Group3
{
    partial class EditPackageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPackageForm));
            this.labelComm = new System.Windows.Forms.Label();
            this.labelBase = new System.Windows.Forms.Label();
            this.labelDescript = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.txtPackageDesc = new System.Windows.Forms.TextBox();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.txtCommission = new System.Windows.Forms.TextBox();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.txtPackageID = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelComm
            // 
            this.labelComm.AutoSize = true;
            this.labelComm.Location = new System.Drawing.Point(410, 244);
            this.labelComm.Name = "labelComm";
            this.labelComm.Size = new System.Drawing.Size(62, 13);
            this.labelComm.TabIndex = 12;
            this.labelComm.Text = "Commission";
            // 
            // labelBase
            // 
            this.labelBase.AutoSize = true;
            this.labelBase.Location = new System.Drawing.Point(12, 244);
            this.labelBase.Name = "labelBase";
            this.labelBase.Size = new System.Drawing.Size(58, 13);
            this.labelBase.TabIndex = 11;
            this.labelBase.Text = "Base Price";
            // 
            // labelDescript
            // 
            this.labelDescript.AutoSize = true;
            this.labelDescript.Location = new System.Drawing.Point(420, 140);
            this.labelDescript.Name = "labelDescript";
            this.labelDescript.Size = new System.Drawing.Size(60, 13);
            this.labelDescript.TabIndex = 10;
            this.labelDescript.Text = "Description";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(420, 196);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(52, 13);
            this.labelEnd.TabIndex = 9;
            this.labelEnd.Text = "End Date";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(18, 189);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(55, 13);
            this.labelDate.TabIndex = 8;
            this.labelDate.Text = "Start Date";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(11, 140);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(81, 13);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Package Name";
            // 
            // txtPackageName
            // 
            this.txtPackageName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPackageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageName.Location = new System.Drawing.Point(109, 137);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(208, 20);
            this.txtPackageName.TabIndex = 13;
            // 
            // txtPackageDesc
            // 
            this.txtPackageDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPackageDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageDesc.Location = new System.Drawing.Point(509, 115);
            this.txtPackageDesc.Multiline = true;
            this.txtPackageDesc.Name = "txtPackageDesc";
            this.txtPackageDesc.Size = new System.Drawing.Size(208, 58);
            this.txtPackageDesc.TabIndex = 14;
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasePrice.Location = new System.Drawing.Point(109, 237);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(208, 20);
            this.txtBasePrice.TabIndex = 17;
            // 
            // txtCommission
            // 
            this.txtCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommission.Location = new System.Drawing.Point(509, 237);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.Size = new System.Drawing.Size(208, 20);
            this.txtCommission.TabIndex = 18;
            // 
            // dateStart
            // 
            this.dateStart.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart.Location = new System.Drawing.Point(109, 189);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(208, 20);
            this.dateStart.TabIndex = 19;
            // 
            // dateEnd
            // 
            this.dateEnd.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnd.Location = new System.Drawing.Point(509, 189);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(208, 20);
            this.dateEnd.TabIndex = 20;
            // 
            // txtPackageID
            // 
            this.txtPackageID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPackageID.Location = new System.Drawing.Point(109, 101);
            this.txtPackageID.Name = "txtPackageID";
            this.txtPackageID.ReadOnly = true;
            this.txtPackageID.Size = new System.Drawing.Size(56, 20);
            this.txtPackageID.TabIndex = 22;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(11, 104);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 21;
            this.lblId.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Edit Travel Package";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(201, 279);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 32);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(509, 279);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 32);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(353, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 105);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // EditPackageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(757, 354);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPackageID);
            this.Controls.Add(this.lblId);
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
            this.Name = "EditPackageForm";
            this.Text = "EditPackage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelComm;
        private System.Windows.Forms.Label labelBase;
        private System.Windows.Forms.Label labelDescript;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtPackageName;
        private System.Windows.Forms.TextBox txtPackageDesc;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.TextBox txtCommission;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.TextBox txtPackageID;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}