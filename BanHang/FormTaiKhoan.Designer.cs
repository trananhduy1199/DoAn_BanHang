namespace BanHang
{
    partial class FormTaiKhoan
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txttaikhoan = new DevExpress.XtraEditors.TextEdit();
            this.txtmatkhau = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gridControltaikhoan = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.butthem = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonsua = new DevExpress.XtraEditors.SimpleButton();
            this.butthoat = new DevExpress.XtraEditors.SimpleButton();
            this.TAIKHOAN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MATKHAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.comboBoxEditmanv = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txttaikhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmatkhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControltaikhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(12, 66);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(113, 25);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tài Khoản:";
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.Location = new System.Drawing.Point(131, 71);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Size = new System.Drawing.Size(178, 20);
            this.txttaikhoan.TabIndex = 2;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(131, 127);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Properties.Mask.EditMask = "*";
            this.txtmatkhau.Size = new System.Drawing.Size(178, 20);
            this.txtmatkhau.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(12, 122);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(113, 25);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Mật Khẩu:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(12, 176);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(113, 25);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Mã Nhân Viên:";
            // 
            // gridControltaikhoan
            // 
            this.gridControltaikhoan.Location = new System.Drawing.Point(12, 295);
            this.gridControltaikhoan.MainView = this.gridView1;
            this.gridControltaikhoan.Name = "gridControltaikhoan";
            this.gridControltaikhoan.Size = new System.Drawing.Size(297, 200);
            this.gridControltaikhoan.TabIndex = 7;
            this.gridControltaikhoan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TAIKHOAN1,
            this.MATKHAU,
            this.MANV});
            this.gridView1.GridControl = this.gridControltaikhoan;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // butthem
            // 
            this.butthem.Location = new System.Drawing.Point(13, 225);
            this.butthem.Name = "butthem";
            this.butthem.Size = new System.Drawing.Size(75, 23);
            this.butthem.TabIndex = 8;
            this.butthem.Text = "Thêm";
            this.butthem.Click += new System.EventHandler(this.butthem_Click);
            // 
            // simpleButtonsua
            // 
            this.simpleButtonsua.Location = new System.Drawing.Point(131, 224);
            this.simpleButtonsua.Name = "simpleButtonsua";
            this.simpleButtonsua.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonsua.TabIndex = 9;
            this.simpleButtonsua.Text = "Sửa";
            this.simpleButtonsua.Click += new System.EventHandler(this.simpleButtonsua_Click);
            // 
            // butthoat
            // 
            this.butthoat.Location = new System.Drawing.Point(235, 223);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(75, 23);
            this.butthoat.TabIndex = 10;
            this.butthoat.Text = "Thoát";
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // TAIKHOAN1
            // 
            this.TAIKHOAN1.Caption = "Tài Khoản";
            this.TAIKHOAN1.FieldName = "TAIKHOAN1";
            this.TAIKHOAN1.Name = "TAIKHOAN1";
            this.TAIKHOAN1.OptionsColumn.AllowEdit = false;
            this.TAIKHOAN1.OptionsColumn.ReadOnly = true;
            this.TAIKHOAN1.Visible = true;
            this.TAIKHOAN1.VisibleIndex = 0;
            // 
            // MATKHAU
            // 
            this.MATKHAU.Caption = "Mật Khẩu";
            this.MATKHAU.FieldName = "MATKHAU";
            this.MATKHAU.Name = "MATKHAU";
            this.MATKHAU.OptionsColumn.AllowEdit = false;
            this.MATKHAU.OptionsColumn.ReadOnly = true;
            this.MATKHAU.Visible = true;
            this.MATKHAU.VisibleIndex = 1;
            // 
            // MANV
            // 
            this.MANV.Caption = "Mã Nhân Viên";
            this.MANV.FieldName = "MANV";
            this.MANV.Name = "MANV";
            this.MANV.OptionsColumn.AllowEdit = false;
            this.MANV.OptionsColumn.ReadOnly = true;
            this.MANV.Visible = true;
            this.MANV.VisibleIndex = 2;
            // 
            // comboBoxEditmanv
            // 
            this.comboBoxEditmanv.FormattingEnabled = true;
            this.comboBoxEditmanv.Location = new System.Drawing.Point(131, 179);
            this.comboBoxEditmanv.Name = "comboBoxEditmanv";
            this.comboBoxEditmanv.Size = new System.Drawing.Size(178, 21);
            this.comboBoxEditmanv.TabIndex = 11;
            // 
            // FormTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 507);
            this.Controls.Add(this.comboBoxEditmanv);
            this.Controls.Add(this.butthoat);
            this.Controls.Add(this.simpleButtonsua);
            this.Controls.Add(this.butthem);
            this.Controls.Add(this.gridControltaikhoan);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txttaikhoan);
            this.Controls.Add(this.labelControl1);
            this.Name = "FormTaiKhoan";
            this.Text = "FormTaiKhoan";
            ((System.ComponentModel.ISupportInitialize)(this.txttaikhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmatkhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControltaikhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txttaikhoan;
        private DevExpress.XtraEditors.TextEdit txtmatkhau;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton butthem;
        private DevExpress.XtraEditors.SimpleButton simpleButtonsua;
        private DevExpress.XtraEditors.SimpleButton butthoat;
        private DevExpress.XtraGrid.Columns.GridColumn TAIKHOAN1;
        private DevExpress.XtraGrid.Columns.GridColumn MATKHAU;
        private DevExpress.XtraGrid.Columns.GridColumn MANV;
        public DevExpress.XtraGrid.GridControl gridControltaikhoan;
        public System.Windows.Forms.ComboBox comboBoxEditmanv;
    }
}