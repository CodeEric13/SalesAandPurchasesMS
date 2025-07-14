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
            ((System.ComponentModel.ISupportInitialize)(this.transacDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transacDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputVat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.netOfVat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TIN.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(191, 172);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(58, 23);
            this.clearbtn.TabIndex = 32;
            this.clearbtn.Text = "Clear";
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(116, 172);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(69, 23);
            this.savebtn.TabIndex = 31;
            this.savebtn.Text = "Save";
            // 
            // transacDate
            // 
            this.transacDate.EditValue = null;
            this.transacDate.Location = new System.Drawing.Point(116, 140);
            this.transacDate.Name = "transacDate";
            this.transacDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transacDate.Properties.Appearance.Options.UseFont = true;
            this.transacDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.transacDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.transacDate.Size = new System.Drawing.Size(133, 26);
            this.transacDate.TabIndex = 26;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(14, 52);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(38, 13);
            this.labelControl5.TabIndex = 25;
            this.labelControl5.Text = "Supplier";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(15, 116);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 13);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "Input VAT";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 84);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "Net of AT";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 20);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(17, 13);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "TIN";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 148);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 13);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "Date of Transaction";
            // 
            // supplier
            // 
            this.supplier.Location = new System.Drawing.Point(116, 44);
            this.supplier.Name = "supplier";
            this.supplier.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier.Properties.Appearance.Options.UseFont = true;
            this.supplier.Size = new System.Drawing.Size(133, 26);
            this.supplier.TabIndex = 20;
            // 
            // inputVat
            // 
            this.inputVat.Location = new System.Drawing.Point(116, 108);
            this.inputVat.Name = "inputVat";
            this.inputVat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputVat.Properties.Appearance.Options.UseFont = true;
            this.inputVat.Size = new System.Drawing.Size(133, 26);
            this.inputVat.TabIndex = 19;
            // 
            // netOfVat
            // 
            this.netOfVat.Location = new System.Drawing.Point(116, 76);
            this.netOfVat.Name = "netOfVat";
            this.netOfVat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netOfVat.Properties.Appearance.Options.UseFont = true;
            this.netOfVat.Size = new System.Drawing.Size(133, 26);
            this.netOfVat.TabIndex = 18;
            // 
            // TIN
            // 
            this.TIN.Location = new System.Drawing.Point(116, 12);
            this.TIN.Name = "TIN";
            this.TIN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIN.Properties.Appearance.Options.UseFont = true;
            this.TIN.Size = new System.Drawing.Size(133, 26);
            this.TIN.TabIndex = 17;
            // 
            // newPurchaseFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 203);
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
            this.Text = "newPurchaseFRM";
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
    }
}