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
            this.salesRercordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.branchCode = new DevExpress.XtraEditors.TextEdit();
            this.refreshbtn = new DevExpress.XtraEditors.SimpleButton();
            this.viewSalesGrdCtrl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.salesRercordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSalesGrdCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // salesRercordBindingSource
            // 
            this.salesRercordBindingSource.DataSource = typeof(SAPMS.Classes.SalesRercord);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Branch Code";
            // 
            // branchCode
            // 
            this.branchCode.Enabled = false;
            this.branchCode.Location = new System.Drawing.Point(77, 7);
            this.branchCode.Name = "branchCode";
            this.branchCode.Properties.ReadOnly = true;
            this.branchCode.Size = new System.Drawing.Size(98, 20);
            this.branchCode.TabIndex = 5;
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
            // viewSalesGrdCtrl
            // 
            this.viewSalesGrdCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewSalesGrdCtrl.Location = new System.Drawing.Point(-1, 33);
            this.viewSalesGrdCtrl.MainView = this.gridView1;
            this.viewSalesGrdCtrl.Name = "viewSalesGrdCtrl";
            this.viewSalesGrdCtrl.Size = new System.Drawing.Size(548, 236);
            this.viewSalesGrdCtrl.TabIndex = 7;
            this.viewSalesGrdCtrl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.viewSalesGrdCtrl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick_1);
            // 
            // viewSalesFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 268);
            this.Controls.Add(this.viewSalesGrdCtrl);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.branchCode);
            this.Controls.Add(this.refreshbtn);
            this.Name = "viewSalesFRM";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.viewSalesFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesRercordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSalesGrdCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit branchCode;
        private DevExpress.XtraEditors.SimpleButton refreshbtn;
        private System.Windows.Forms.BindingSource salesRercordBindingSource;
        private DevExpress.XtraGrid.GridControl viewSalesGrdCtrl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}