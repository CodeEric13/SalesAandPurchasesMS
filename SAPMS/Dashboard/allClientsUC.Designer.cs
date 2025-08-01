namespace SAPMS.Dashboard
{
    partial class allClientsUC
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
            this.allClientsGrdCtrl = new DevExpress.XtraGrid.GridControl();
            this.clientRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBusinessAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBusinessCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBusinessName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateAdded = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.allClientsGrdCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientRecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // allClientsGrdCtrl
            // 
            this.allClientsGrdCtrl.DataSource = this.clientRecordsBindingSource;
            this.allClientsGrdCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allClientsGrdCtrl.Location = new System.Drawing.Point(0, 0);
            this.allClientsGrdCtrl.MainView = this.gridView1;
            this.allClientsGrdCtrl.Name = "allClientsGrdCtrl";
            this.allClientsGrdCtrl.Size = new System.Drawing.Size(539, 349);
            this.allClientsGrdCtrl.TabIndex = 0;
            this.allClientsGrdCtrl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clientRecordsBindingSource
            // 
            this.clientRecordsBindingSource.DataSource = typeof(SAPMS.Classes.ClientRecords);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colBusinessAddress,
            this.colBusinessCode,
            this.colBusinessName,
            this.colTaxType,
            this.colDateAdded});
            this.gridView1.GridControl = this.allClientsGrdCtrl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colBusinessAddress
            // 
            this.colBusinessAddress.FieldName = "BusinessAddress";
            this.colBusinessAddress.Name = "colBusinessAddress";
            this.colBusinessAddress.Visible = true;
            this.colBusinessAddress.VisibleIndex = 1;
            // 
            // colBusinessCode
            // 
            this.colBusinessCode.FieldName = "BusinessCode";
            this.colBusinessCode.Name = "colBusinessCode";
            this.colBusinessCode.Visible = true;
            this.colBusinessCode.VisibleIndex = 2;
            // 
            // colBusinessName
            // 
            this.colBusinessName.FieldName = "BusinessName";
            this.colBusinessName.Name = "colBusinessName";
            this.colBusinessName.Visible = true;
            this.colBusinessName.VisibleIndex = 3;
            // 
            // colTaxType
            // 
            this.colTaxType.FieldName = "TaxType";
            this.colTaxType.Name = "colTaxType";
            this.colTaxType.Visible = true;
            this.colTaxType.VisibleIndex = 4;
            // 
            // colDateAdded
            // 
            this.colDateAdded.FieldName = "DateAdded";
            this.colDateAdded.Name = "colDateAdded";
            this.colDateAdded.Visible = true;
            this.colDateAdded.VisibleIndex = 5;
            // 
            // allClientsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.allClientsGrdCtrl);
            this.Name = "allClientsUC";
            this.Size = new System.Drawing.Size(539, 349);
            this.Load += new System.EventHandler(this.allClientsUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allClientsGrdCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientRecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl allClientsGrdCtrl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource clientRecordsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colBusinessAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colBusinessCode;
        private DevExpress.XtraGrid.Columns.GridColumn colBusinessName;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxType;
        private DevExpress.XtraGrid.Columns.GridColumn colDateAdded;
    }
}
