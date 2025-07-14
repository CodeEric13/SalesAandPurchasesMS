namespace SAPMS.Sales
{
    partial class newSalesFRM
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
            this.cusName = new DevExpress.XtraEditors.TextEdit();
            this.vatSales = new DevExpress.XtraEditors.TextEdit();
            this.outSales = new DevExpress.XtraEditors.TextEdit();
            this.grossSales = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.transacDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.x12VatSales = new DevExpress.XtraEditors.TextEdit();
            this.x12OutVat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.savebtn = new DevExpress.XtraEditors.SimpleButton();
            this.clearbtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cusName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vatSales.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outSales.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grossSales.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transacDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transacDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x12VatSales.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x12OutVat.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cusName
            // 
            this.cusName.Location = new System.Drawing.Point(143, 9);
            this.cusName.Name = "cusName";
            this.cusName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusName.Properties.Appearance.Options.UseFont = true;
            this.cusName.Size = new System.Drawing.Size(133, 26);
            this.cusName.TabIndex = 1;
            // 
            // vatSales
            // 
            this.vatSales.Location = new System.Drawing.Point(143, 73);
            this.vatSales.Name = "vatSales";
            this.vatSales.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vatSales.Properties.Appearance.Options.UseFont = true;
            this.vatSales.Size = new System.Drawing.Size(133, 26);
            this.vatSales.TabIndex = 2;
            // 
            // outSales
            // 
            this.outSales.Location = new System.Drawing.Point(143, 105);
            this.outSales.Name = "outSales";
            this.outSales.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outSales.Properties.Appearance.Options.UseFont = true;
            this.outSales.Size = new System.Drawing.Size(133, 26);
            this.outSales.TabIndex = 3;
            // 
            // grossSales
            // 
            this.grossSales.Location = new System.Drawing.Point(143, 41);
            this.grossSales.Name = "grossSales";
            this.grossSales.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossSales.Properties.Appearance.Options.UseFont = true;
            this.grossSales.Size = new System.Drawing.Size(133, 26);
            this.grossSales.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 145);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Date of Transaction";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Customer\'s Name";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 81);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Vatable Sales";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 113);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Output VAT";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 49);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Gross Sales";
            // 
            // transacDate
            // 
            this.transacDate.EditValue = null;
            this.transacDate.Location = new System.Drawing.Point(143, 137);
            this.transacDate.Name = "transacDate";
            this.transacDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transacDate.Properties.Appearance.Options.UseFont = true;
            this.transacDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.transacDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.transacDate.Size = new System.Drawing.Size(133, 26);
            this.transacDate.TabIndex = 10;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(282, 81);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(25, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "X .12";
            // 
            // x12VatSales
            // 
            this.x12VatSales.Location = new System.Drawing.Point(313, 73);
            this.x12VatSales.Name = "x12VatSales";
            this.x12VatSales.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x12VatSales.Properties.Appearance.Options.UseFont = true;
            this.x12VatSales.Size = new System.Drawing.Size(133, 26);
            this.x12VatSales.TabIndex = 12;
            // 
            // x12OutVat
            // 
            this.x12OutVat.Location = new System.Drawing.Point(313, 105);
            this.x12OutVat.Name = "x12OutVat";
            this.x12OutVat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x12OutVat.Properties.Appearance.Options.UseFont = true;
            this.x12OutVat.Size = new System.Drawing.Size(133, 26);
            this.x12OutVat.TabIndex = 13;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(282, 113);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(25, 13);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "X .12";
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(313, 140);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(69, 23);
            this.savebtn.TabIndex = 15;
            this.savebtn.Text = "Save";
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(388, 140);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(58, 23);
            this.clearbtn.TabIndex = 16;
            this.clearbtn.Text = "Clear";
            // 
            // newSalesFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 174);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.x12OutVat);
            this.Controls.Add(this.x12VatSales);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.transacDate);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.grossSales);
            this.Controls.Add(this.outSales);
            this.Controls.Add(this.vatSales);
            this.Controls.Add(this.cusName);
            this.MaximizeBox = false;
            this.Name = "newSalesFRM";
            this.Text = "newSalesFRM";
            ((System.ComponentModel.ISupportInitialize)(this.cusName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vatSales.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outSales.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grossSales.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transacDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transacDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x12VatSales.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x12OutVat.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit cusName;
        private DevExpress.XtraEditors.TextEdit vatSales;
        private DevExpress.XtraEditors.TextEdit outSales;
        private DevExpress.XtraEditors.TextEdit grossSales;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit transacDate;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit x12VatSales;
        private DevExpress.XtraEditors.TextEdit x12OutVat;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton savebtn;
        private DevExpress.XtraEditors.SimpleButton clearbtn;
    }
}