namespace QLBanHang
{
    partial class FormKhachHang
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButThem = new DevExpress.XtraBars.BarButtonItem();
            this.barButSua = new DevExpress.XtraBars.BarButtonItem();
            this.barButXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barButThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlKhachHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.radioButnu = new System.Windows.Forms.RadioButton();
            this.radioButnam = new System.Windows.Forms.RadioButton();
            this.dateEditngaysinh = new DevExpress.XtraEditors.DateEdit();
            this.txtdiachi = new DevExpress.XtraEditors.TextEdit();
            this.txtsodienthoai = new DevExpress.XtraEditors.TextEdit();
            this.txthoten = new DevExpress.XtraEditors.TextEdit();
            this.txtmakhachhang = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditngaysinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditngaysinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiachi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsodienthoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthoten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmakhachhang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButXoa,
            this.barButThem,
            this.barButSua,
            this.barButThoat});
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Offset = 156;
            this.bar1.Text = "Tools";
            // 
            // barButThem
            // 
            this.barButThem.Caption = "Thêm ";
            this.barButThem.Glyph = global::QLBanHang.Properties.Resources.Actions_list_add_icon1;
            this.barButThem.Id = 1;
            this.barButThem.Name = "barButThem";
            this.barButThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButThem_ItemClick);
            // 
            // barButSua
            // 
            this.barButSua.Caption = "Sửa Thông Tin";
            this.barButSua.Glyph = global::QLBanHang.Properties.Resources.Actions_edit_redo_icon;
            this.barButSua.Id = 2;
            this.barButSua.Name = "barButSua";
            this.barButSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButSua_ItemClick);
            // 
            // barButXoa
            // 
            this.barButXoa.Caption = "Xóa";
            this.barButXoa.Glyph = global::QLBanHang.Properties.Resources.Exit2;
            this.barButXoa.Id = 0;
            this.barButXoa.Name = "barButXoa";
            this.barButXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButXoa_ItemClick);
            // 
            // barButThoat
            // 
            this.barButThoat.Caption = "Thoát";
            this.barButThoat.Glyph = global::QLBanHang.Properties.Resources.Actions_edit_delete_icon4;
            this.barButThoat.Id = 3;
            this.barButThoat.Name = "barButThoat";
            this.barButThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(833, 59);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 454);
            this.barDockControlBottom.Size = new System.Drawing.Size(833, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 59);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 395);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(833, 59);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 395);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.gridControlKhachHang);
            this.groupControl1.Controls.Add(this.radioButnu);
            this.groupControl1.Controls.Add(this.radioButnam);
            this.groupControl1.Controls.Add(this.dateEditngaysinh);
            this.groupControl1.Controls.Add(this.txtdiachi);
            this.groupControl1.Controls.Add(this.txtsodienthoai);
            this.groupControl1.Controls.Add(this.txthoten);
            this.groupControl1.Controls.Add(this.txtmakhachhang);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(0, 63);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(833, 390);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Thông Tin Khách Hàng";
            // 
            // gridControlKhachHang
            // 
            this.gridControlKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlKhachHang.Location = new System.Drawing.Point(12, 96);
            this.gridControlKhachHang.MainView = this.gridView1;
            this.gridControlKhachHang.MenuManager = this.barManager1;
            this.gridControlKhachHang.Name = "gridControlKhachHang";
            this.gridControlKhachHang.Size = new System.Drawing.Size(816, 288);
            this.gridControlKhachHang.TabIndex = 8;
            this.gridControlKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlKhachHang;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // radioButnu
            // 
            this.radioButnu.AutoSize = true;
            this.radioButnu.Location = new System.Drawing.Point(746, 52);
            this.radioButnu.Name = "radioButnu";
            this.radioButnu.Size = new System.Drawing.Size(39, 17);
            this.radioButnu.TabIndex = 7;
            this.radioButnu.TabStop = true;
            this.radioButnu.Text = "Nữ";
            this.radioButnu.UseVisualStyleBackColor = true;
            // 
            // radioButnam
            // 
            this.radioButnam.AutoSize = true;
            this.radioButnam.Location = new System.Drawing.Point(645, 52);
            this.radioButnam.Name = "radioButnam";
            this.radioButnam.Size = new System.Drawing.Size(46, 17);
            this.radioButnam.TabIndex = 6;
            this.radioButnam.TabStop = true;
            this.radioButnam.Text = "Nam";
            this.radioButnam.UseVisualStyleBackColor = true;
            // 
            // dateEditngaysinh
            // 
            this.dateEditngaysinh.EditValue = null;
            this.dateEditngaysinh.Location = new System.Drawing.Point(645, 12);
            this.dateEditngaysinh.MenuManager = this.barManager1;
            this.dateEditngaysinh.Name = "dateEditngaysinh";
            this.dateEditngaysinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditngaysinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditngaysinh.Size = new System.Drawing.Size(183, 20);
            this.dateEditngaysinh.TabIndex = 5;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(381, 51);
            this.txtdiachi.MenuManager = this.barManager1;
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(183, 20);
            this.txtdiachi.TabIndex = 4;
            // 
            // txtsodienthoai
            // 
            this.txtsodienthoai.Location = new System.Drawing.Point(381, 12);
            this.txtsodienthoai.MenuManager = this.barManager1;
            this.txtsodienthoai.Name = "txtsodienthoai";
            this.txtsodienthoai.Size = new System.Drawing.Size(183, 20);
            this.txtsodienthoai.TabIndex = 3;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(108, 51);
            this.txthoten.MenuManager = this.barManager1;
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(183, 20);
            this.txthoten.TabIndex = 2;
            // 
            // txtmakhachhang
            // 
            this.txtmakhachhang.Location = new System.Drawing.Point(108, 12);
            this.txtmakhachhang.MenuManager = this.barManager1;
            this.txtmakhachhang.Name = "txtmakhachhang";
            this.txtmakhachhang.Size = new System.Drawing.Size(183, 20);
            this.txtmakhachhang.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(297, 54);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(34, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Địa Chỉ";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(297, 15);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(66, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Số Điện Thoại";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(570, 54);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Giới Tính";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(570, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Ngày Sinh";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Họ Tên";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã Khách Hàng";
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 476);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormKhachHang";
            this.Text = "FormThemKhachHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditngaysinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditngaysinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiachi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsodienthoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthoten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmakhachhang.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButXoa;
        private DevExpress.XtraBars.BarButtonItem barButThem;
        private DevExpress.XtraBars.BarButtonItem barButSua;
        private DevExpress.XtraBars.BarButtonItem barButThoat;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public System.Windows.Forms.RadioButton radioButnu;
        public System.Windows.Forms.RadioButton radioButnam;
        public DevExpress.XtraEditors.DateEdit dateEditngaysinh;
        public DevExpress.XtraEditors.TextEdit txtdiachi;
        public DevExpress.XtraEditors.TextEdit txtsodienthoai;
        public DevExpress.XtraEditors.TextEdit txthoten;
        public DevExpress.XtraEditors.TextEdit txtmakhachhang;
        public DevExpress.XtraGrid.GridControl gridControlKhachHang;
    }
}