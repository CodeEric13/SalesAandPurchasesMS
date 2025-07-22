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
            this.viewSalesGrdCtrl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.viewSalesGrdCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // viewSalesGrdCtrl
            // 
            this.viewSalesGrdCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewSalesGrdCtrl.Location = new System.Drawing.Point(0, 0);
            this.viewSalesGrdCtrl.MainView = this.gridView1;
            this.viewSalesGrdCtrl.Name = "viewSalesGrdCtrl";
            this.viewSalesGrdCtrl.Size = new System.Drawing.Size(546, 268);
            this.viewSalesGrdCtrl.TabIndex = 0;
            this.viewSalesGrdCtrl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.viewSalesGrdCtrl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // viewSalesFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 268);
            this.Controls.Add(this.viewSalesGrdCtrl);
            this.Name = "viewSalesFRM";
            this.Text = "viewSalesFRM";
            this.Load += new System.EventHandler(this.viewSalesFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewSalesGrdCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl viewSalesGrdCtrl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}