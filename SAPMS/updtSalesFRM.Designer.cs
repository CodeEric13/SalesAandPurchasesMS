namespace SAPMS
{
    partial class updtSalesFRM
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
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.clientCode = new DevExpress.XtraEditors.TextEdit();
            this.updatebtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.x12OutVat = new DevExpress.XtraEditors.TextEdit();
            this.x12VatSales = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.transacDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grossSales = new DevExpress.XtraEditors.TextEdit();
            this.outSales = new DevExpress.XtraEditors.TextEdit();
            this.vatSales = new DevExpress.XtraEditors.TextEdit();
            this.cusName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.clientCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x12OutVat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x12VatSales.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transacDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transacDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grossSales.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outSales.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vatSales.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(312, 12);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(55, 13);
            this.labelControl8.TabIndex = 35;
            this.labelControl8.Text = "Client Code";
            // 
            // clientCode
            // 
            this.clientCode.Location = new System.Drawing.Point(373, 4);
            this.clientCode.Name = "clientCode";
            this.clientCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientCode.Properties.Appearance.Options.UseFont = true;
            this.clientCode.Properties.ReadOnly = true;
            this.clientCode.Size = new System.Drawing.Size(72, 26);
            this.clientCode.TabIndex = 34;
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(312, 135);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(69, 23);
            this.updatebtn.TabIndex = 33;
            this.updatebtn.Text = "Update";
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(281, 108);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(25, 13);
            this.labelControl7.TabIndex = 32;
            this.labelControl7.Text = "X .12";
            // 
            // x12OutVat
            // 
            this.x12OutVat.Location = new System.Drawing.Point(312, 100);
            this.x12OutVat.Name = "x12OutVat";
            this.x12OutVat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x12OutVat.Properties.Appearance.Options.UseFont = true;
            this.x12OutVat.Properties.ReadOnly = true;
            this.x12OutVat.Size = new System.Drawing.Size(133, 26);
            this.x12OutVat.TabIndex = 31;
            // 
            // x12VatSales
            // 
            this.x12VatSales.Location = new System.Drawing.Point(312, 68);
            this.x12VatSales.Name = "x12VatSales";
            this.x12VatSales.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x12VatSales.Properties.Appearance.Options.UseFont = true;
            this.x12VatSales.Properties.ReadOnly = true;
            this.x12VatSales.Size = new System.Drawing.Size(133, 26);
            this.x12VatSales.TabIndex = 30;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(281, 76);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(25, 13);
            this.labelControl6.TabIndex = 29;
            this.labelControl6.Text = "X .12";
            // 
            // transacDate
            // 
            this.transacDate.EditValue = new System.DateTime(2025, 7, 23, 9, 26, 22, 0);
            this.transacDate.Location = new System.Drawing.Point(142, 132);
            this.transacDate.Name = "transacDate";
            this.transacDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transacDate.Properties.Appearance.Options.UseFont = true;
            this.transacDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.transacDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.transacDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.transacDate.Size = new System.Drawing.Size(133, 26);
            this.transacDate.TabIndex = 28;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(11, 44);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 13);
            this.labelControl5.TabIndex = 27;
            this.labelControl5.Text = "Gross Sales";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 108);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 13);
            this.labelControl4.TabIndex = 26;
            this.labelControl4.Text = "Output VAT";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 76);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 13);
            this.labelControl3.TabIndex = 25;
            this.labelControl3.Text = "Vatable Sales";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 13);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "Customer\'s Name";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 140);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 13);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "Date of Transaction";
            // 
            // grossSales
            // 
            this.grossSales.Location = new System.Drawing.Point(142, 36);
            this.grossSales.Name = "grossSales";
            this.grossSales.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossSales.Properties.Appearance.Options.UseFont = true;
            this.grossSales.Size = new System.Drawing.Size(133, 26);
            this.grossSales.TabIndex = 22;
            // 
            // outSales
            // 
            this.outSales.Location = new System.Drawing.Point(142, 100);
            this.outSales.Name = "outSales";
            this.outSales.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outSales.Properties.Appearance.Options.UseFont = true;
            this.outSales.Size = new System.Drawing.Size(133, 26);
            this.outSales.TabIndex = 21;
            // 
            // vatSales
            // 
            this.vatSales.Location = new System.Drawing.Point(142, 68);
            this.vatSales.Name = "vatSales";
            this.vatSales.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vatSales.Properties.Appearance.Options.UseFont = true;
            this.vatSales.Size = new System.Drawing.Size(133, 26);
            this.vatSales.TabIndex = 20;
            // 
            // cusName
            // 
            this.cusName.Location = new System.Drawing.Point(142, 4);
            this.cusName.Name = "cusName";
            this.cusName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusName.Properties.Appearance.Options.UseFont = true;
            this.cusName.Size = new System.Drawing.Size(133, 26);
            this.cusName.TabIndex = 19;
            // 
            // updtSalesFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 168);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.clientCode);
            this.Controls.Add(this.updatebtn);
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
            this.Name = "updtSalesFRM";
            this.Text = "updtSalesFRM";
            this.Load += new System.EventHandler(this.updtSalesFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x12OutVat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x12VatSales.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transacDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transacDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grossSales.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outSales.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vatSales.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit clientCode;
        private DevExpress.XtraEditors.SimpleButton updatebtn;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit x12OutVat;
        private DevExpress.XtraEditors.TextEdit x12VatSales;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit transacDate;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit grossSales;
        private DevExpress.XtraEditors.TextEdit outSales;
        private DevExpress.XtraEditors.TextEdit vatSales;
        private DevExpress.XtraEditors.TextEdit cusName;
    }
}