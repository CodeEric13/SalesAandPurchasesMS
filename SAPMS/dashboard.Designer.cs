namespace SAPMS
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.clientsGrdCtrl = new DevExpress.XtraGrid.GridControl();
            this.clientRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBusinessAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBusinessCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBusinessName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxtType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateAdded = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.addClient = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.clientRecordsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGrdCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientRecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientRecordsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.clientsGrdCtrl);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(210, 31);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(580, 442);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // clientsGrdCtrl
            // 
            this.clientsGrdCtrl.DataSource = this.clientRecordsBindingSource1;
            this.clientsGrdCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientsGrdCtrl.Location = new System.Drawing.Point(0, 0);
            this.clientsGrdCtrl.MainView = this.gridView1;
            this.clientsGrdCtrl.MenuManager = this.fluentFormDefaultManager1;
            this.clientsGrdCtrl.Name = "clientsGrdCtrl";
            this.clientsGrdCtrl.Size = new System.Drawing.Size(580, 442);
            this.clientsGrdCtrl.TabIndex = 0;
            this.clientsGrdCtrl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colBusinessAddress,
            this.colBusinessCode,
            this.colBusinessName,
            this.colTaxtType,
            this.colDateAdded});
            this.gridView1.GridControl = this.clientsGrdCtrl;
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
            // colTaxtType
            // 
            this.colTaxtType.FieldName = "TaxtType";
            this.colTaxtType.Name = "colTaxtType";
            this.colTaxtType.Visible = true;
            this.colTaxtType.VisibleIndex = 4;
            // 
            // colDateAdded
            // 
            this.colDateAdded.FieldName = "DateAdded";
            this.colDateAdded.Name = "colDateAdded";
            this.colDateAdded.Visible = true;
            this.colDateAdded.VisibleIndex = 5;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.addClient});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(210, 442);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // addClient
            // 
            this.addClient.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.addClient.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("addClient.ImageOptions.SvgImage")));
            this.addClient.Name = "addClient";
            this.addClient.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.addClient.Text = "Add Client";
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(790, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            // 
            // clientRecordsBindingSource1
            // 
            this.clientRecordsBindingSource1.DataSource = typeof(SAPMS.Classes.ClientRecords);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 473);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "dashboard";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.fluentDesignFormContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientsGrdCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientRecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientRecordsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement addClient;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraGrid.GridControl clientsGrdCtrl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource clientRecordsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colBusinessAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colBusinessCode;
        private DevExpress.XtraGrid.Columns.GridColumn colBusinessName;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxtType;
        private DevExpress.XtraGrid.Columns.GridColumn colDateAdded;
        private System.Windows.Forms.BindingSource clientRecordsBindingSource1;
    }
}

