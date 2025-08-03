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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.fltrCode = new DevExpress.XtraEditors.TextEdit();
            this.fltrDate = new DevExpress.XtraEditors.DateEdit();
            this.fltrSupplier = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.allPurchaseGrdCtrl = new DevExpress.XtraGrid.GridControl();
            this.purchaseRecordBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBusinesCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaseID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrossPurchase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetOfVat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInputVat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateOfTransact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clearbtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.fltrCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fltrDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fltrDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fltrSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allPurchaseGrdCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRecordBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(3, 8);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(108, 37);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Preview";
            // 
            // fltrCode
            // 
            this.fltrCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fltrCode.Location = new System.Drawing.Point(263, 32);
            this.fltrCode.Name = "fltrCode";
            this.fltrCode.Size = new System.Drawing.Size(100, 20);
            this.fltrCode.TabIndex = 3;
            this.fltrCode.TextChanged += new System.EventHandler(this.fltrCode_TextChanged_1);
            // 
            // fltrDate
            // 
            this.fltrDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fltrDate.EditValue = null;
            this.fltrDate.Location = new System.Drawing.Point(479, 32);
            this.fltrDate.Name = "fltrDate";
            this.fltrDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fltrDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fltrDate.Size = new System.Drawing.Size(100, 20);
            this.fltrDate.TabIndex = 4;
            this.fltrDate.TextChanged += new System.EventHandler(this.fltrDate_TextChanged_1);
            // 
            // fltrSupplier
            // 
            this.fltrSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fltrSupplier.Location = new System.Drawing.Point(369, 32);
            this.fltrSupplier.Name = "fltrSupplier";
            this.fltrSupplier.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.fltrSupplier.Size = new System.Drawing.Size(104, 20);
            this.fltrSupplier.TabIndex = 5;
            this.fltrSupplier.TextChanged += new System.EventHandler(this.fltrSupplier_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(263, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Business Code";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(369, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Supplier";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(479, 13);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(95, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Date of Transaction";
            // 
            // allPurchaseGrdCtrl
            // 
            this.allPurchaseGrdCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allPurchaseGrdCtrl.DataSource = this.purchaseRecordBindingSource1;
            this.allPurchaseGrdCtrl.Location = new System.Drawing.Point(0, 58);
            this.allPurchaseGrdCtrl.MainView = this.gridView1;
            this.allPurchaseGrdCtrl.Name = "allPurchaseGrdCtrl";
            this.allPurchaseGrdCtrl.Size = new System.Drawing.Size(584, 236);
            this.allPurchaseGrdCtrl.TabIndex = 9;
            this.allPurchaseGrdCtrl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // purchaseRecordBindingSource1
            // 
            this.purchaseRecordBindingSource1.DataSource = typeof(SAPMS.Classes.PurchaseRecord);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBusinesCode,
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
            // colBusinesCode
            // 
            this.colBusinesCode.FieldName = "BusinesCode";
            this.colBusinesCode.Name = "colBusinesCode";
            this.colBusinesCode.Visible = true;
            this.colBusinesCode.VisibleIndex = 1;
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
            // clearbtn
            // 
            this.clearbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearbtn.Location = new System.Drawing.Point(199, 35);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(58, 17);
            this.clearbtn.TabIndex = 16;
            this.clearbtn.Text = "Clear";
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // allPurchaseUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.allPurchaseGrdCtrl);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.fltrSupplier);
            this.Controls.Add(this.fltrDate);
            this.Controls.Add(this.fltrCode);
            this.Controls.Add(this.simpleButton1);
            this.Name = "allPurchaseUC";
            this.Size = new System.Drawing.Size(584, 294);
            this.Load += new System.EventHandler(this.allPurchaseUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fltrCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fltrDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fltrDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fltrSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allPurchaseGrdCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRecordBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit fltrCode;
        private DevExpress.XtraEditors.DateEdit fltrDate;
        private DevExpress.XtraEditors.TextEdit fltrSupplier;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl allPurchaseGrdCtrl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource purchaseRecordBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colBusinesCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseID;
        private DevExpress.XtraGrid.Columns.GridColumn colTin;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierName;
        private DevExpress.XtraGrid.Columns.GridColumn colGrossPurchase;
        private DevExpress.XtraGrid.Columns.GridColumn colNetOfVat;
        private DevExpress.XtraGrid.Columns.GridColumn colInputVat;
        private DevExpress.XtraGrid.Columns.GridColumn colDateOfTransact;
        private DevExpress.XtraEditors.SimpleButton clearbtn;
    }
}
