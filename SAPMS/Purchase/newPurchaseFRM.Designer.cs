namespace SAPMS.Sales
{
    partial class newPurchaseFRM
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
            this.clearbtn = new DevExpress.XtraEditors.SimpleButton();
            this.savebtn = new DevExpress.XtraEditors.SimpleButton();
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
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.clientCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.grossPurchase = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.transacDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transacDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputVat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.netOfVat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grossPurchase.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(124, 237);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(123, 23);
            this.clearbtn.TabIndex = 32;
            this.clearbtn.Text = "Clear";
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(13, 237);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(105, 23);
            this.savebtn.TabIndex = 31;
            this.savebtn.Text = "Save";
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // transacDate
            // 
            this.transacDate.EditValue = new System.DateTime(2025, 7, 23, 9, 25, 39, 0);
            this.transacDate.Location = new System.Drawing.Point(114, 205);
            this.transacDate.Name = "transacDate";
            this.transacDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transacDate.Properties.Appearance.Options.UseFont = true;
            this.transacDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.transacDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.transacDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.transacDate.Size = new System.Drawing.Size(133, 26);
            this.transacDate.TabIndex = 26;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 86);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(38, 13);
            this.labelControl5.TabIndex = 25;
            this.labelControl5.Text = "Supplier";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 150);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 13);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "Input VAT";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 118);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "Net of AT";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(17, 13);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "TIN";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 213);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 13);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "Date of Transaction";
            // 
            // supplier
            // 
            this.supplier.Location = new System.Drawing.Point(114, 78);
            this.supplier.Name = "supplier";
            this.supplier.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier.Properties.Appearance.Options.UseFont = true;
            this.supplier.Size = new System.Drawing.Size(133, 26);
            this.supplier.TabIndex = 20;
            // 
            // inputVat
            // 
            this.inputVat.Location = new System.Drawing.Point(114, 142);
            this.inputVat.Name = "inputVat";
            this.inputVat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputVat.Properties.Appearance.Options.UseFont = true;
            this.inputVat.Size = new System.Drawing.Size(133, 26);
            this.inputVat.TabIndex = 19;
            // 
            // netOfVat
            // 
            this.netOfVat.Location = new System.Drawing.Point(114, 110);
            this.netOfVat.Name = "netOfVat";
            this.netOfVat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netOfVat.Properties.Appearance.Options.UseFont = true;
            this.netOfVat.Size = new System.Drawing.Size(133, 26);
            this.netOfVat.TabIndex = 18;
            // 
            // TIN
            // 
            this.TIN.Location = new System.Drawing.Point(114, 46);
            this.TIN.Name = "TIN";
            this.TIN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIN.Properties.Appearance.Options.UseFont = true;
            this.TIN.Size = new System.Drawing.Size(133, 26);
            this.TIN.TabIndex = 17;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(13, 20);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(55, 13);
            this.labelControl6.TabIndex = 34;
            this.labelControl6.Text = "Client Code";
            // 
            // clientCode
            // 
            this.clientCode.Enabled = false;
            this.clientCode.Location = new System.Drawing.Point(114, 12);
            this.clientCode.Name = "clientCode";
            this.clientCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientCode.Properties.Appearance.Options.UseFont = true;
            this.clientCode.Properties.ReadOnly = true;
            this.clientCode.Size = new System.Drawing.Size(133, 26);
            this.clientCode.TabIndex = 33;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(13, 181);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(74, 13);
            this.labelControl7.TabIndex = 36;
            this.labelControl7.Text = "Gross Purchase";
            // 
            // grossPurchase
            // 
            this.grossPurchase.Location = new System.Drawing.Point(114, 173);
            this.grossPurchase.Name = "grossPurchase";
            this.grossPurchase.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossPurchase.Properties.Appearance.Options.UseFont = true;
            this.grossPurchase.Size = new System.Drawing.Size(133, 26);
            this.grossPurchase.TabIndex = 35;
            // 
            // newPurchaseFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 268);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.grossPurchase);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.clientCode);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.savebtn);
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
            this.MaximizeBox = false;
            this.Name = "newPurchaseFRM";
            this.Text = "New Purchase";
            this.Load += new System.EventHandler(this.newPurchaseFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transacDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transacDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputVat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.netOfVat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grossPurchase.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton clearbtn;
        private DevExpress.XtraEditors.SimpleButton savebtn;
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
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit clientCode;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit grossPurchase;
    }
}