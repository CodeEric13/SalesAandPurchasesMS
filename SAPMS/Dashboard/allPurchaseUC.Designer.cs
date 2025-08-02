namespace SAPMS.Dashboard
{
    partial class allPurchaseUC
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
            this.allPurchaseGrdCtrl = new DevExpress.XtraGrid.GridControl();
            this.purchaseRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaseID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrossPurchase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetOfVat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInputVat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateOfTransact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.allPurchaseGrdCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // allPurchaseGrdCtrl
            // 
            this.allPurchaseGrdCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allPurchaseGrdCtrl.DataSource = this.purchaseRecordBindingSource;
            this.allPurchaseGrdCtrl.Location = new System.Drawing.Point(0, 46);
            this.allPurchaseGrdCtrl.MainView = this.gridView1;
            this.allPurchaseGrdCtrl.Name = "allPurchaseGrdCtrl";
            this.allPurchaseGrdCtrl.Size = new System.Drawing.Size(584, 248);
            this.allPurchaseGrdCtrl.TabIndex = 0;
            this.allPurchaseGrdCtrl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // purchaseRecordBindingSource
            // 
            this.purchaseRecordBindingSource.DataSource = typeof(SAPMS.Classes.PurchaseRecord);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colPurchaseID,
            this.colTin,
            this.colSupplierName,
            this.colGrossPurchase,
            this.colNetOfVat,
            this.colInputVat,
            this.colDateOfTransact});
            this.gridView1.GridControl = this.allPurchaseGrdCtrl;
            this.gridView1.Name = "gridView1";
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 1;
            // 
            // colPurchaseID
            // 
            this.colPurchaseID.FieldName = "PurchaseID";
            this.colPurchaseID.Name = "colPurchaseID";
            this.colPurchaseID.Visible = true;
            this.colPurchaseID.VisibleIndex = 0;
            // 
            // colTin
            // 
            this.colTin.FieldName = "Tin";
            this.colTin.Name = "colTin";
            this.colTin.Visible = true;
            this.colTin.VisibleIndex = 2;
            // 
            // colSupplierName
            // 
            this.colSupplierName.FieldName = "SupplierName";
            this.colSupplierName.Name = "colSupplierName";
            this.colSupplierName.Visible = true;
            this.colSupplierName.VisibleIndex = 3;
            // 
            // colGrossPurchase
            // 
            this.colGrossPurchase.FieldName = "GrossPurchase";
            this.colGrossPurchase.Name = "colGrossPurchase";
            this.colGrossPurchase.Visible = true;
            this.colGrossPurchase.VisibleIndex = 4;
            // 
            // colNetOfVat
            // 
            this.colNetOfVat.FieldName = "NetOfVat";
            this.colNetOfVat.Name = "colNetOfVat";
            this.colNetOfVat.Visible = true;
            this.colNetOfVat.VisibleIndex = 5;
            // 
            // colInputVat
            // 
            this.colInputVat.FieldName = "InputVat";
            this.colInputVat.Name = "colInputVat";
            this.colInputVat.Visible = true;
            this.colInputVat.VisibleIndex = 6;
            // 
            // colDateOfTransact
            // 
            this.colDateOfTransact.FieldName = "DateOfTransact";
            this.colDateOfTransact.Name = "colDateOfTransact";
            this.colDateOfTransact.Visible = true;
            this.colDateOfTransact.VisibleIndex = 7;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(3, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(108, 37);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Preview";
            // 
            // allPurchaseUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.allPurchaseGrdCtrl);
            this.Name = "allPurchaseUC";
            this.Size = new System.Drawing.Size(584, 294);
            this.Load += new System.EventHandler(this.allPurchaseUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allPurchaseGrdCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl allPurchaseGrdCtrl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.BindingSource purchaseRecordBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseID;
        private DevExpress.XtraGrid.Columns.GridColumn colTin;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierName;
        private DevExpress.XtraGrid.Columns.GridColumn colGrossPurchase;
        private DevExpress.XtraGrid.Columns.GridColumn colNetOfVat;
        private DevExpress.XtraGrid.Columns.GridColumn colInputVat;
        private DevExpress.XtraGrid.Columns.GridColumn colDateOfTransact;
    }
}
