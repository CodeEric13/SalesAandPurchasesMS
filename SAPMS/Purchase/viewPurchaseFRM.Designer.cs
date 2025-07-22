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
            ((System.ComponentModel.ISupportInitialize)(this.purchaseGrdCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            // viewPurchaseFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 268);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.purchaseGrdCtrl);
            this.Name = "viewPurchaseFRM";
            this.Text = "viewPurchaseFRM";
            this.Load += new System.EventHandler(this.viewPurchaseFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseGrdCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl purchaseGrdCtrl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton refreshbtn;
    }
}