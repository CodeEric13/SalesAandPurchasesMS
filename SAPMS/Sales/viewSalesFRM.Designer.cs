namespace SAPMS
{
    partial class viewSalesFRM
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
            this.components = new System.ComponentModel.Container();
            this.viewSalesGrdCtrl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.clientCode = new DevExpress.XtraEditors.TextEdit();
            this.refreshbtn = new DevExpress.XtraEditors.SimpleButton();
            this.salesRercordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colBusinessCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrossSales = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVatSales = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOutputSales = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateOfTransact = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.viewSalesGrdCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRercordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // viewSalesGrdCtrl
            // 
            this.viewSalesGrdCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewSalesGrdCtrl.DataSource = this.salesRercordBindingSource;
            this.viewSalesGrdCtrl.Location = new System.Drawing.Point(0, 32);
            this.viewSalesGrdCtrl.MainView = this.gridView1;
            this.viewSalesGrdCtrl.Name = "viewSalesGrdCtrl";
            this.viewSalesGrdCtrl.Size = new System.Drawing.Size(546, 236);
            this.viewSalesGrdCtrl.TabIndex = 0;
            this.viewSalesGrdCtrl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBusinessCode,
            this.colCustomerName,
            this.colGrossSales,
            this.colVatSales,
            this.colOutputSales,
            this.colDateOfTransact});
            this.gridView1.GridControl = this.viewSalesGrdCtrl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Client Code";
            // 
            // clientCode
            // 
            this.clientCode.Enabled = false;
            this.clientCode.Location = new System.Drawing.Point(71, 6);
            this.clientCode.Name = "clientCode";
            this.clientCode.Properties.ReadOnly = true;
            this.clientCode.Size = new System.Drawing.Size(98, 20);
            this.clientCode.TabIndex = 5;
            // 
            // refreshbtn
            // 
            this.refreshbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshbtn.Location = new System.Drawing.Point(470, 9);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(64, 18);
            this.refreshbtn.TabIndex = 4;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // salesRercordBindingSource
            // 
            this.salesRercordBindingSource.DataSource = typeof(SAPMS.Classes.SalesRercord);
            // 
            // colBusinessCode
            // 
            this.colBusinessCode.FieldName = "BusinessCode";
            this.colBusinessCode.Name = "colBusinessCode";
            this.colBusinessCode.Visible = true;
            this.colBusinessCode.VisibleIndex = 0;
            // 
            // colCustomerName
            // 
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 1;
            // 
            // colGrossSales
            // 
            this.colGrossSales.FieldName = "GrossSales";
            this.colGrossSales.Name = "colGrossSales";
            this.colGrossSales.Visible = true;
            this.colGrossSales.VisibleIndex = 2;
            // 
            // colVatSales
            // 
            this.colVatSales.FieldName = "VatSales";
            this.colVatSales.Name = "colVatSales";
            this.colVatSales.Visible = true;
            this.colVatSales.VisibleIndex = 3;
            // 
            // colOutputSales
            // 
            this.colOutputSales.FieldName = "OutputSales";
            this.colOutputSales.Name = "colOutputSales";
            this.colOutputSales.Visible = true;
            this.colOutputSales.VisibleIndex = 4;
            // 
            // colDateOfTransact
            // 
            this.colDateOfTransact.FieldName = "DateOfTransact";
            this.colDateOfTransact.Name = "colDateOfTransact";
            this.colDateOfTransact.Visible = true;
            this.colDateOfTransact.VisibleIndex = 5;
            // 
            // viewSalesFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 268);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.clientCode);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.viewSalesGrdCtrl);
            this.Name = "viewSalesFRM";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.viewSalesFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewSalesGrdCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRercordBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl viewSalesGrdCtrl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit clientCode;
        private DevExpress.XtraEditors.SimpleButton refreshbtn;
        private System.Windows.Forms.BindingSource salesRercordBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colBusinessCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colGrossSales;
        private DevExpress.XtraGrid.Columns.GridColumn colVatSales;
        private DevExpress.XtraGrid.Columns.GridColumn colOutputSales;
        private DevExpress.XtraGrid.Columns.GridColumn colDateOfTransact;
    }
}