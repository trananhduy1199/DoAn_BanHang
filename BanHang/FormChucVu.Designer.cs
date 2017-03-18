namespace BanHang
{
    partial class FormChucVu
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
            this.txtmachucvu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txttenchucvu = new DevExpress.XtraEditors.TextEdit();
            this.butthem = new DevExpress.XtraEditors.SimpleButton();
            this.butsua = new DevExpress.XtraEditors.SimpleButton();
            this.butthoat = new DevExpress.XtraEditors.SimpleButton();
            this.butxoa = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlchucvu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MACV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENCV = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtmachucvu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenchucvu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlchucvu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(37, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(137, 23);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Mã Chức Vụ";
            // 
            // txtmachucvu
            // 
            this.txtmachucvu.Location = new System.Drawing.Point(222, 34);
            this.txtmachucvu.Name = "txtmachucvu";
            this.txtmachucvu.Size = new System.Drawing.Size(132, 20);
            this.txtmachucvu.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(37, 98);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(137, 23);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tên Chức Vụ";
            // 
            // txttenchucvu
            // 
            this.txttenchucvu.Location = new System.Drawing.Point(222, 95);
            this.txttenchucvu.Name = "txttenchucvu";
            this.txttenchucvu.Size = new System.Drawing.Size(132, 20);
            this.txttenchucvu.TabIndex = 4;
            // 
            // butthem
            // 
            this.butthem.Location = new System.Drawing.Point(12, 163);
            this.butthem.Name = "butthem";
            this.butthem.Size = new System.Drawing.Size(75, 23);
            this.butthem.TabIndex = 14;
            this.butthem.Text = "Thêm";
            this.butthem.Click += new System.EventHandler(this.butthem_Click);
            // 
            // butsua
            // 
            this.butsua.Location = new System.Drawing.Point(114, 163);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(75, 23);
            this.butsua.TabIndex = 15;
            this.butsua.Text = "Sửa";
            this.butsua.Click += new System.EventHandler(this.butsua_Click);
            // 
            // butthoat
            // 
            this.butthoat.Location = new System.Drawing.Point(331, 163);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(75, 23);
            this.butthoat.TabIndex = 18;
            this.butthoat.Text = "Thoát";
            // 
            // butxoa
            // 
            this.butxoa.Location = new System.Drawing.Point(222, 163);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(75, 23);
            this.butxoa.TabIndex = 17;
            this.butxoa.Text = "Xóa";
            this.butxoa.Click += new System.EventHandler(this.butxoa_Click);
            // 
            // gridControlchucvu
            // 
            this.gridControlchucvu.Location = new System.Drawing.Point(13, 206);
            this.gridControlchucvu.MainView = this.gridView1;
            this.gridControlchucvu.Name = "gridControlchucvu";
            this.gridControlchucvu.Size = new System.Drawing.Size(400, 215);
            this.gridControlchucvu.TabIndex = 19;
            this.gridControlchucvu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MACV,
            this.TENCV});
            this.gridView1.GridControl = this.gridControlchucvu;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // MACV
            // 
            this.MACV.Caption = "Mã Chức Vụ";
            this.MACV.FieldName = "MACV";
            this.MACV.Name = "MACV";
            this.MACV.OptionsColumn.AllowEdit = false;
            this.MACV.OptionsColumn.ReadOnly = true;
            this.MACV.Visible = true;
            this.MACV.VisibleIndex = 0;
            // 
            // TENCV
            // 
            this.TENCV.Caption = "Tên Chức Vụ";
            this.TENCV.FieldName = "TENCV";
            this.TENCV.Name = "TENCV";
            this.TENCV.OptionsColumn.AllowEdit = false;
            this.TENCV.OptionsColumn.ReadOnly = true;
            this.TENCV.Visible = true;
            this.TENCV.VisibleIndex = 1;
            // 
            // FormChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 426);
            this.Controls.Add(this.gridControlchucvu);
            this.Controls.Add(this.butthoat);
            this.Controls.Add(this.butxoa);
            this.Controls.Add(this.butsua);
            this.Controls.Add(this.butthem);
            this.Controls.Add(this.txttenchucvu);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtmachucvu);
            this.Controls.Add(this.labelControl1);
            this.Name = "FormChucVu";
            this.Text = "FormChucVu";
            ((System.ComponentModel.ISupportInitialize)(this.txtmachucvu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenchucvu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlchucvu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtmachucvu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txttenchucvu;
        private DevExpress.XtraEditors.SimpleButton butthem;
        private DevExpress.XtraEditors.SimpleButton butsua;
        private DevExpress.XtraEditors.SimpleButton butthoat;
        private DevExpress.XtraEditors.SimpleButton butxoa;
        private DevExpress.XtraGrid.GridControl gridControlchucvu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MACV;
        private DevExpress.XtraGrid.Columns.GridColumn TENCV;
    }
}