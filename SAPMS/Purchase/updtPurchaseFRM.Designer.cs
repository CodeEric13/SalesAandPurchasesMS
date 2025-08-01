namespace SAPMS.Purchase
{
    partial class updtPurchaseFRM
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
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.grossPurchase = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.purchaseID = new DevExpress.XtraEditors.TextEdit();
            this.updatebtn = new DevExpress.XtraEditors.SimpleButton();
            this.transacDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.supplier = new DevExpress.XtraEditors.TextEdit();
            this.inputVat = new DevExpress.XtraEditors.TextEdit();
            this.netOfVat = new DevExpress.XtraEditors.TextEdit();
            this.TIN = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grossPurchase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transacDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transacDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputVat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.netOfVat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIN.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 183);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(74, 13);
            this.labelControl7.TabIndex = 52;
            this.labelControl7.Text = "Gross Purchase";
            // 
            // grossPurchase
            // 
            this.grossPurchase.Location = new System.Drawing.Point(113, 175);
            this.grossPurchase.Name = "grossPurchase";
            this.grossPurchase.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossPurchase.Properties.Appearance.Options.UseFont = true;
            this.grossPurchase.Size = new System.Drawing.Size(133, 26);
            this.grossPurchase.TabIndex = 51;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 22);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(58, 13);
            this.labelControl6.TabIndex = 50;
            this.labelControl6.Text = "Purchase ID";
            // 
            // purchaseID
            // 
            this.purchaseID.Enabled = false;
            this.purchaseID.Location = new System.Drawing.Point(113, 14);
            this.purchaseID.Name = "purchaseID";
            this.purchaseID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseID.Properties.Appearance.Options.UseFont = true;
            this.purchaseID.Properties.ReadOnly = true;
            this.purchaseID.Size = new System.Drawing.Size(133, 26);
            this.purchaseID.TabIndex = 49;
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(12, 239);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(234, 29);
            this.updatebtn.TabIndex = 47;
            this.updatebtn.Text = "Update";
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // transacDate
            // 
            this.transacDate.EditValue = new System.DateTime(2025, 7, 23, 9, 25, 39, 0);
            this.transacDate.Location = new System.Drawing.Point(113, 207);
            this.transacDate.Name = "transacDate";
            this.transacDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transacDate.Properties.Appearance.Options.UseFont = true;
            this.transacDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.transacDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.transacDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.transacDate.Size = new System.Drawing.Size(133, 26);
            this.transacDate.TabIndex = 46;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(11, 88);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(38, 13);
            this.labelControl5.TabIndex = 45;
            this.labelControl5.Text = "Supplier";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 152);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 13);
            this.labelControl4.TabIndex = 44;
            this.labelControl4.Text = "Input VAT";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 120);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 43;
            this.labelControl3.Text = "Net of AT";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(17, 13);
            this.labelControl2.TabIndex = 42;
            this.labelControl2.Text = "TIN";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 215);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 13);
            this.labelControl1.TabIndex = 41;
            this.labelControl1.Text = "Date of Transaction";
            // 
            // supplier
            // 
            this.supplier.Location = new System.Drawing.Point(113, 80);
            this.supplier.Name = "supplier";
            this.supplier.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier.Properties.Appearance.Options.UseFont = true;
            this.supplier.Size = new System.Drawing.Size(133, 26);
            this.supplier.TabIndex = 40;
            // 
            // inputVat
            // 
            this.inputVat.Location = new System.Drawing.Point(113, 144);
            this.inputVat.Name = "inputVat";
            this.inputVat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputVat.Properties.Appearance.Options.UseFont = true;
            this.inputVat.Size = new System.Drawing.Size(133, 26);
            this.inputVat.TabIndex = 39;
            // 
            // netOfVat
            // 
            this.netOfVat.Location = new System.Drawing.Point(113, 112);
            this.netOfVat.Name = "netOfVat";
            this.netOfVat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netOfVat.Properties.Appearance.Options.UseFont = true;
            this.netOfVat.Size = new System.Drawing.Size(133, 26);
            this.netOfVat.TabIndex = 38;
            // 
            // TIN
            // 
            this.TIN.Location = new System.Drawing.Point(113, 48);
            this.TIN.Name = "TIN";
            this.TIN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIN.Properties.Appearance.Options.UseFont = true;
            this.TIN.Size = new System.Drawing.Size(133, 26);
            this.TIN.TabIndex = 37;
            // 
            // updtPurchaseFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 278);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.grossPurchase);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.purchaseID);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.transacDate);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.supplier);
            this.Controls.Add(this.inputVat);
            this.Controls.Add(this.netOfVat);
            this.Controls.Add(this.TIN);
            this.Name = "updtPurchaseFRM";
            this.Text = "updtPurchaseFRM";
            this.Load += new System.EventHandler(this.updtPurchaseFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grossPurchase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transacDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transacDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputVat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.netOfVat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIN.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit grossPurchase;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit purchaseID;
        private DevExpress.XtraEditors.SimpleButton updatebtn;
        private DevExpress.XtraEditors.DateEdit transacDate;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit supplier;
        private DevExpress.XtraEditors.TextEdit inputVat;
        private DevExpress.XtraEditors.TextEdit netOfVat;
        private DevExpress.XtraEditors.TextEdit TIN;
    }
}