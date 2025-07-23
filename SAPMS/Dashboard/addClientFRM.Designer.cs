namespace SAPMS
{
    partial class addClientFRM
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
            this.clientName = new DevExpress.XtraEditors.TextEdit();
            this.busName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.savebtn = new DevExpress.XtraEditors.SimpleButton();
            this.taxTypecmb = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.dateAdded = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.busAddress = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.bCode = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.clientName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxTypecmb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAdded.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // clientName
            // 
            this.clientName.Location = new System.Drawing.Point(104, 12);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(122, 20);
            this.clientName.TabIndex = 0;
            // 
            // busName
            // 
            this.busName.Location = new System.Drawing.Point(104, 64);
            this.busName.Name = "busName";
            this.busName.Size = new System.Drawing.Size(122, 20);
            this.busName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Business Name";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 119);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Tax Type";
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(15, 168);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(211, 34);
            this.savebtn.TabIndex = 6;
            this.savebtn.Text = "Save";
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // taxTypecmb
            // 
            this.taxTypecmb.Location = new System.Drawing.Point(104, 116);
            this.taxTypecmb.Name = "taxTypecmb";
            this.taxTypecmb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.taxTypecmb.Properties.Items.AddRange(new object[] {
            "VAT",
            "NON-VAT"});
            this.taxTypecmb.Size = new System.Drawing.Size(122, 20);
            this.taxTypecmb.TabIndex = 7;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(15, 208);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(211, 44);
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Text = "Save and Go to Sales and Purchases";
            // 
            // dateAdded
            // 
            this.dateAdded.Location = new System.Drawing.Point(104, 142);
            this.dateAdded.Name = "dateAdded";
            this.dateAdded.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateAdded.Properties.Items.AddRange(new object[] {
            "VAT",
            "NON-VAT"});
            this.dateAdded.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateAdded.Size = new System.Drawing.Size(122, 20);
            this.dateAdded.TabIndex = 10;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(15, 145);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(23, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Date";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(15, 93);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(83, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Business Address";
            // 
            // busAddress
            // 
            this.busAddress.Location = new System.Drawing.Point(104, 90);
            this.busAddress.Name = "busAddress";
            this.busAddress.Size = new System.Drawing.Size(122, 20);
            this.busAddress.TabIndex = 11;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(15, 41);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(61, 13);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "Branch Code";
            // 
            // bCode
            // 
            this.bCode.Location = new System.Drawing.Point(104, 38);
            this.bCode.Name = "bCode";
            this.bCode.Size = new System.Drawing.Size(122, 20);
            this.bCode.TabIndex = 15;
            // 
            // addClientFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 264);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.bCode);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.busAddress);
            this.Controls.Add(this.dateAdded);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.taxTypecmb);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.busName);
            this.Controls.Add(this.clientName);
            this.Name = "addClientFRM";
            this.Text = "New Client";
            this.Load += new System.EventHandler(this.addClientFRM_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.clientName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxTypecmb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateAdded.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit clientName;
        private DevExpress.XtraEditors.TextEdit busName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton savebtn;
        private DevExpress.XtraEditors.ComboBoxEdit taxTypecmb;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.ComboBoxEdit dateAdded;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit busAddress;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit bCode;
    }
}