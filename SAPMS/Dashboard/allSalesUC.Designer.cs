namespace SAPMS.Dashboard
{
    partial class allSalesUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.allSalesGrdCtrl = new DevExpress.XtraGrid.GridControl();
            this.salesRercordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSalesID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBusinessCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrossSales = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVatSales = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOutputSales = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateOfTransact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.prvSalesbtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.fltrCusName = new DevExpress.XtraEditors.TextEdit();
            this.fltrDate = new DevExpress.XtraEditors.DateEdit();
            this.fltrCode = new DevExpress.XtraEditors.TextEdit();
            this.clearbtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.allSalesGrdCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRercordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fltrCusName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fltrDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fltrDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fltrCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // allSalesGrdCtrl
            // 
            this.allSalesGrdCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allSalesGrdCtrl.DataSource = this.salesRercordBindingSource;
            this.allSalesGrdCtrl.Location = new System.Drawing.Point(0, 54);
            this.allSalesGrdCtrl.MainView = this.gridView1;
            this.allSalesGrdCtrl.Name = "allSalesGrdCtrl";
            this.allSalesGrdCtrl.Size = new System.Drawing.Size(679, 354);
            this.allSalesGrdCtrl.TabIndex = 0;
            this.allSalesGrdCtrl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSalesID,
            this.colBusinessCode,
            this.colCustomerName,
            this.colGrossSales,
            this.colVatSales,
            this.colOutputSales,
            this.colDateOfTransact});
            this.gridView1.GridControl = this.allSalesGrdCtrl;
            this.gridView1.Name = "gridView1";
            // 
            // colSalesID
            // 
            this.colSalesID.FieldName = "SalesID";
            this.colSalesID.Name = "colSalesID";
            this.colSalesID.Visible = true;
            this.colSalesID.VisibleIndex = 0;
            // 
            // colBusinessCode
            // 
            this.colBusinessCode.FieldName = "BusinessCode";
            this.colBusinessCode.Name = "colBusinessCode";
            this.colBusinessCode.Visible = true;
            this.colBusinessCode.VisibleIndex = 1;
            // 
            // colCustomerName
            // 
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 2;
            // 
            // colGrossSales
            // 
            this.colGrossSales.FieldName = "GrossSales";
            this.colGrossSales.Name = "colGrossSales";
            this.colGrossSales.Visible = true;
            this.colGrossSales.VisibleIndex = 3;
            // 
            // colVatSales
            // 
            this.colVatSales.FieldName = "VatSales";
            this.colVatSales.Name = "colVatSales";
            this.colVatSales.Visible = true;
            this.colVatSales.VisibleIndex = 4;
            // 
            // colOutputSales
            // 
            this.colOutputSales.FieldName = "OutputSales";
            this.colOutputSales.Name = "colOutputSales";
            this.colOutputSales.Visible = true;
            this.colOutputSales.VisibleIndex = 5;
            // 
            // colDateOfTransact
            // 
            this.colDateOfTransact.FieldName = "DateOfTransact";
            this.colDateOfTransact.Name = "colDateOfTransact";
            this.colDateOfTransact.Visible = true;
            this.colDateOfTransact.VisibleIndex = 6;
            // 
            // prvSalesbtn
            // 
            this.prvSalesbtn.Location = new System.Drawing.Point(3, 3);
            this.prvSalesbtn.Name = "prvSalesbtn";
            this.prvSalesbtn.Size = new System.Drawing.Size(89, 33);
            this.prvSalesbtn.TabIndex = 1;
            this.prvSalesbtn.Text = "Preview";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(576, 9);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(95, 13);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Date of Transaction";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(466, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 13);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Customer Name";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(360, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Business Code";
            // 
            // fltrCusName
            // 
            this.fltrCusName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fltrCusName.Location = new System.Drawing.Point(466, 28);
            this.fltrCusName.Name = "fltrCusName";
            this.fltrCusName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.fltrCusName.Size = new System.Drawing.Size(104, 20);
            this.fltrCusName.TabIndex = 11;
            this.fltrCusName.TextChanged += new System.EventHandler(this.fltrCusName_TextChanged);
            // 
            // fltrDate
            // 
            this.fltrDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fltrDate.EditValue = null;
            this.fltrDate.Location = new System.Drawing.Point(576, 28);
            this.fltrDate.Name = "fltrDate";
            this.fltrDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fltrDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fltrDate.Size = new System.Drawing.Size(100, 20);
            this.fltrDate.TabIndex = 10;
            this.fltrDate.TextChanged += new System.EventHandler(this.fltrDate_TextChanged);
            // 
            // fltrCode
            // 
            this.fltrCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fltrCode.Location = new System.Drawing.Point(360, 28);
            this.fltrCode.Name = "fltrCode";
            this.fltrCode.Size = new System.Drawing.Size(100, 20);
            this.fltrCode.TabIndex = 9;
            this.fltrCode.TextChanged += new System.EventHandler(this.fltrCode_TextChanged);
            // 
            // clearbtn
            // 
            this.clearbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearbtn.Location = new System.Drawing.Point(296, 31);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(58, 17);
            this.clearbtn.TabIndex = 15;
            this.clearbtn.Text = "Clear";
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // allSalesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.fltrCusName);
            this.Controls.Add(this.fltrDate);
            this.Controls.Add(this.fltrCode);
            this.Controls.Add(this.prvSalesbtn);
            this.Controls.Add(this.allSalesGrdCtrl);
            this.Name = "allSalesUC";
            this.Size = new System.Drawing.Size(679, 411);
            this.Load += new System.EventHandler(this.allSalesUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allSalesGrdCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRercordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fltrCusName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fltrDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fltrDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fltrCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl allSalesGrdCtrl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton prvSalesbtn;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit fltrCusName;
        private DevExpress.XtraEditors.DateEdit fltrDate;
        private DevExpress.XtraEditors.TextEdit fltrCode;
        private System.Windows.Forms.BindingSource salesRercordBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesID;
        private DevExpress.XtraGrid.Columns.GridColumn colBusinessCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colGrossSales;
        private DevExpress.XtraGrid.Columns.GridColumn colVatSales;
        private DevExpress.XtraGrid.Columns.GridColumn colOutputSales;
        private DevExpress.XtraGrid.Columns.GridColumn colDateOfTransact;
        private DevExpress.XtraEditors.SimpleButton clearbtn;
    }
}
