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
            this.allSalesGrdCtrl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.prvSalesbtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.allSalesGrdCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // allSalesGrdCtrl
            // 
            this.allSalesGrdCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allSalesGrdCtrl.Location = new System.Drawing.Point(0, 42);
            this.allSalesGrdCtrl.MainView = this.gridView1;
            this.allSalesGrdCtrl.Name = "allSalesGrdCtrl";
            this.allSalesGrdCtrl.Size = new System.Drawing.Size(679, 366);
            this.allSalesGrdCtrl.TabIndex = 0;
            this.allSalesGrdCtrl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.allSalesGrdCtrl;
            this.gridView1.Name = "gridView1";
            // 
            // prvSalesbtn
            // 
            this.prvSalesbtn.Location = new System.Drawing.Point(3, 3);
            this.prvSalesbtn.Name = "prvSalesbtn";
            this.prvSalesbtn.Size = new System.Drawing.Size(89, 33);
            this.prvSalesbtn.TabIndex = 1;
            this.prvSalesbtn.Text = "Preview";
            // 
            // allSalesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.prvSalesbtn);
            this.Controls.Add(this.allSalesGrdCtrl);
            this.Name = "allSalesUC";
            this.Size = new System.Drawing.Size(679, 411);
            this.Load += new System.EventHandler(this.allSalesUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allSalesGrdCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl allSalesGrdCtrl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton prvSalesbtn;
    }
}
