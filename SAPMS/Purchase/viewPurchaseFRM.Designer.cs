namespace SAPMS.Sales
{
    partial class viewPurchaseFRM
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
            this.purchaseGrdCtrl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.refreshbtn = new DevExpress.XtraEditors.SimpleButton();
            this.clientCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseGrdCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // purchaseGrdCtrl
            // 
            this.purchaseGrdCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.purchaseGrdCtrl.Location = new System.Drawing.Point(0, 36);
            this.purchaseGrdCtrl.MainView = this.gridView1;
            this.purchaseGrdCtrl.Name = "purchaseGrdCtrl";
            this.purchaseGrdCtrl.Size = new System.Drawing.Size(506, 232);
            this.purchaseGrdCtrl.TabIndex = 0;
            this.purchaseGrdCtrl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.purchaseGrdCtrl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // refreshbtn
            // 
            this.refreshbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshbtn.Location = new System.Drawing.Point(430, 12);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(64, 18);
            this.refreshbtn.TabIndex = 1;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // clientCode
            // 
            this.clientCode.Enabled = false;
            this.clientCode.Location = new System.Drawing.Point(73, 11);
            this.clientCode.Name = "clientCode";
            this.clientCode.Properties.ReadOnly = true;
            this.clientCode.Size = new System.Drawing.Size(98, 20);
            this.clientCode.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Client Code";
            // 
            // viewPurchaseFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 268);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.clientCode);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.purchaseGrdCtrl);
            this.Name = "viewPurchaseFRM";
            this.Text = "Purchases";
            this.Load += new System.EventHandler(this.viewPurchaseFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseGrdCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl purchaseGrdCtrl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton refreshbtn;
        private DevExpress.XtraEditors.TextEdit clientCode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}