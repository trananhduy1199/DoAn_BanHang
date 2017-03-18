namespace BanHang
{
    partial class FormSanPham
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
            this.gridControlsanpham = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.butthem = new DevExpress.XtraEditors.SimpleButton();
            this.butsua = new DevExpress.XtraEditors.SimpleButton();
            this.butxoa = new DevExpress.XtraEditors.SimpleButton();
            this.butthoat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtmasanpham = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txttensanpham = new DevExpress.XtraEditors.TextEdit();
            this.txtquycach = new DevExpress.XtraEditors.TextEdit();
            this.txtgiaban = new DevExpress.XtraEditors.TextEdit();
            this.txtsoluongton = new DevExpress.XtraEditors.TextEdit();
            this.MASP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QUYCACH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIABAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SLTON = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlsanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmasanpham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttensanpham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtquycach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgiaban.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluongton.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlsanpham
            // 
            this.gridControlsanpham.Location = new System.Drawing.Point(12, 234);
            this.gridControlsanpham.MainView = this.gridView1;
            this.gridControlsanpham.Name = "gridControlsanpham";
            this.gridControlsanpham.Size = new System.Drawing.Size(628, 200);
            this.gridControlsanpham.TabIndex = 10;
            this.gridControlsanpham.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MASP,
            this.TENSP,
            this.QUYCACH,
            this.GIABAN,
            this.SLTON});
            this.gridView1.GridControl = this.gridControlsanpham;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // butthem
            // 
            this.butthem.Location = new System.Drawing.Point(42, 172);
            this.butthem.Name = "butthem";
            this.butthem.Size = new System.Drawing.Size(75, 23);
            this.butthem.TabIndex = 6;
            this.butthem.Text = "Thêm";
            this.butthem.Click += new System.EventHandler(this.butthem_Click);
            // 
            // butsua
            // 
            this.butsua.Location = new System.Drawing.Point(183, 172);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(75, 23);
            this.butsua.TabIndex = 7;
            this.butsua.Text = "Sửa";
            this.butsua.Click += new System.EventHandler(this.butsua_Click);
            // 
            // butxoa
            // 
            this.butxoa.Location = new System.Drawing.Point(323, 172);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(75, 23);
            this.butxoa.TabIndex = 8;
            this.butxoa.Text = "Xóa";
            this.butxoa.Click += new System.EventHandler(this.butxoa_Click);
            // 
            // butthoat
            // 
            this.butthoat.Location = new System.Drawing.Point(457, 172);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(75, 23);
            this.butthoat.TabIndex = 9;
            this.butthoat.Text = "Thoát";
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(25, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(120, 29);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Mã Sản Phẩm";
            // 
            // txtmasanpham
            // 
            this.txtmasanpham.Location = new System.Drawing.Point(183, 21);
            this.txtmasanpham.Name = "txtmasanpham";
            this.txtmasanpham.Size = new System.Drawing.Size(141, 20);
            this.txtmasanpham.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(352, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(120, 29);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Tên Sản Phẩm";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(25, 64);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(120, 29);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Quy Cách";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(25, 114);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(120, 29);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Giá Bán";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(352, 64);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(120, 29);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Số Lượng Tồn";
            // 
            // txttensanpham
            // 
            this.txttensanpham.Location = new System.Drawing.Point(499, 19);
            this.txttensanpham.Name = "txttensanpham";
            this.txttensanpham.Size = new System.Drawing.Size(141, 20);
            this.txttensanpham.TabIndex = 2;
            // 
            // txtquycach
            // 
            this.txtquycach.Location = new System.Drawing.Point(183, 73);
            this.txtquycach.Name = "txtquycach";
            this.txtquycach.Size = new System.Drawing.Size(141, 20);
            this.txtquycach.TabIndex = 3;
            // 
            // txtgiaban
            // 
            this.txtgiaban.Location = new System.Drawing.Point(183, 121);
            this.txtgiaban.Name = "txtgiaban";
            this.txtgiaban.Size = new System.Drawing.Size(141, 20);
            this.txtgiaban.TabIndex = 5;
            // 
            // txtsoluongton
            // 
            this.txtsoluongton.Location = new System.Drawing.Point(499, 71);
            this.txtsoluongton.Name = "txtsoluongton";
            this.txtsoluongton.Size = new System.Drawing.Size(141, 20);
            this.txtsoluongton.TabIndex = 4;
            // 
            // MASP
            // 
            this.MASP.Caption = "Mã Sản Phẩm";
            this.MASP.FieldName = "MASP";
            this.MASP.Name = "MASP";
            this.MASP.OptionsColumn.AllowEdit = false;
            this.MASP.OptionsColumn.ReadOnly = true;
            this.MASP.Visible = true;
            this.MASP.VisibleIndex = 0;
            // 
            // TENSP
            // 
            this.TENSP.Caption = "Tên Sản Phẩm";
            this.TENSP.FieldName = "TENSP";
            this.TENSP.Name = "TENSP";
            this.TENSP.OptionsColumn.AllowEdit = false;
            this.TENSP.OptionsColumn.ReadOnly = true;
            this.TENSP.Visible = true;
            this.TENSP.VisibleIndex = 1;
            // 
            // QUYCACH
            // 
            this.QUYCACH.Caption = "Quy Cách";
            this.QUYCACH.FieldName = "QUYCACH";
            this.QUYCACH.Name = "QUYCACH";
            this.QUYCACH.OptionsColumn.AllowEdit = false;
            this.QUYCACH.OptionsColumn.ReadOnly = true;
            this.QUYCACH.Visible = true;
            this.QUYCACH.VisibleIndex = 2;
            // 
            // GIABAN
            // 
            this.GIABAN.Caption = "Giá Bán";
            this.GIABAN.FieldName = "GIABAN";
            this.GIABAN.Name = "GIABAN";
            this.GIABAN.OptionsColumn.AllowEdit = false;
            this.GIABAN.OptionsColumn.ReadOnly = true;
            this.GIABAN.Visible = true;
            this.GIABAN.VisibleIndex = 3;
            // 
            // SLTON
            // 
            this.SLTON.Caption = "Số Lượng Tồn";
            this.SLTON.FieldName = "SLTON";
            this.SLTON.Name = "SLTON";
            this.SLTON.OptionsColumn.AllowEdit = false;
            this.SLTON.OptionsColumn.ReadOnly = true;
            this.SLTON.Visible = true;
            this.SLTON.VisibleIndex = 4;
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 446);
            this.Controls.Add(this.txtsoluongton);
            this.Controls.Add(this.txtgiaban);
            this.Controls.Add(this.txtquycach);
            this.Controls.Add(this.txttensanpham);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtmasanpham);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.butthoat);
            this.Controls.Add(this.butxoa);
            this.Controls.Add(this.butsua);
            this.Controls.Add(this.butthem);
            this.Controls.Add(this.gridControlsanpham);
            this.Name = "FormSanPham";
            this.Text = "FormSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlsanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmasanpham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttensanpham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtquycach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgiaban.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluongton.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton butthem;
        private DevExpress.XtraEditors.SimpleButton butsua;
        private DevExpress.XtraEditors.SimpleButton butxoa;
        private DevExpress.XtraEditors.SimpleButton butthoat;
        public DevExpress.XtraGrid.GridControl gridControlsanpham;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txttensanpham;
        private DevExpress.XtraEditors.TextEdit txtquycach;
        private DevExpress.XtraEditors.TextEdit txtgiaban;
        private DevExpress.XtraEditors.TextEdit txtsoluongton;
        private DevExpress.XtraGrid.Columns.GridColumn MASP;
        private DevExpress.XtraGrid.Columns.GridColumn TENSP;
        private DevExpress.XtraGrid.Columns.GridColumn QUYCACH;
        private DevExpress.XtraGrid.Columns.GridColumn GIABAN;
        private DevExpress.XtraGrid.Columns.GridColumn SLTON;
        public DevExpress.XtraEditors.TextEdit txtmasanpham;
    }
}