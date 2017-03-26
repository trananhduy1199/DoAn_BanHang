namespace QLBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChucVu));
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.butthoat = new DevExpress.XtraEditors.SimpleButton();
            this.butxoa = new DevExpress.XtraEditors.SimpleButton();
            this.butsua = new DevExpress.XtraEditors.SimpleButton();
            this.butthem = new DevExpress.XtraEditors.SimpleButton();
            this.txttenchucvu = new System.Windows.Forms.TextBox();
            this.txtmachucvu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlChucVu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(189, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHỨC VỤ NHÂN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.butthoat);
            this.groupControl1.Controls.Add(this.butxoa);
            this.groupControl1.Controls.Add(this.butsua);
            this.groupControl1.Controls.Add(this.butthem);
            this.groupControl1.Controls.Add(this.txttenchucvu);
            this.groupControl1.Controls.Add(this.txtmachucvu);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Location = new System.Drawing.Point(12, 48);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(445, 100);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Chức Năng";
            // 
            // butthoat
            // 
            this.butthoat.Image = ((System.Drawing.Image)(resources.GetObject("butthoat.Image")));
            this.butthoat.Location = new System.Drawing.Point(365, 63);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(75, 23);
            this.butthoat.TabIndex = 7;
            this.butthoat.Text = "Thoát";
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // butxoa
            // 
            this.butxoa.Image = ((System.Drawing.Image)(resources.GetObject("butxoa.Image")));
            this.butxoa.Location = new System.Drawing.Point(284, 63);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(75, 23);
            this.butxoa.TabIndex = 6;
            this.butxoa.Text = "Xóa";
            this.butxoa.Click += new System.EventHandler(this.butxoa_Click);
            // 
            // butsua
            // 
            this.butsua.Image = ((System.Drawing.Image)(resources.GetObject("butsua.Image")));
            this.butsua.Location = new System.Drawing.Point(365, 30);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(75, 23);
            this.butsua.TabIndex = 5;
            this.butsua.Text = "Sửa";
            this.butsua.Click += new System.EventHandler(this.butsua_Click);
            // 
            // butthem
            // 
            this.butthem.Image = ((System.Drawing.Image)(resources.GetObject("butthem.Image")));
            this.butthem.Location = new System.Drawing.Point(284, 30);
            this.butthem.Name = "butthem";
            this.butthem.Size = new System.Drawing.Size(75, 23);
            this.butthem.TabIndex = 4;
            this.butthem.Text = "Thêm";
            this.butthem.Click += new System.EventHandler(this.butthem_Click);
            // 
            // txttenchucvu
            // 
            this.txttenchucvu.Location = new System.Drawing.Point(109, 65);
            this.txttenchucvu.Name = "txttenchucvu";
            this.txttenchucvu.Size = new System.Drawing.Size(169, 21);
            this.txttenchucvu.TabIndex = 3;
            // 
            // txtmachucvu
            // 
            this.txtmachucvu.Location = new System.Drawing.Point(109, 32);
            this.txtmachucvu.Name = "txtmachucvu";
            this.txtmachucvu.Size = new System.Drawing.Size(169, 21);
            this.txtmachucvu.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(5, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Chức Vụ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(5, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Chức Vụ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControlChucVu);
            this.groupControl2.Location = new System.Drawing.Point(12, 154);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(445, 174);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Danh Sách";
            // 
            // gridControlChucVu
            // 
            this.gridControlChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlChucVu.Location = new System.Drawing.Point(2, 20);
            this.gridControlChucVu.MainView = this.gridView1;
            this.gridControlChucVu.Name = "gridControlChucVu";
            this.gridControlChucVu.Size = new System.Drawing.Size(441, 152);
            this.gridControlChucVu.TabIndex = 0;
            this.gridControlChucVu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlChucVu;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // FormChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 340);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.label1);
            this.Name = "FormChucVu";
            this.Text = "FormChucVu";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton butthoat;
        private DevExpress.XtraEditors.SimpleButton butxoa;
        private DevExpress.XtraEditors.SimpleButton butsua;
        private DevExpress.XtraEditors.SimpleButton butthem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraGrid.GridControl gridControlChucVu;
        public System.Windows.Forms.TextBox txttenchucvu;
        public System.Windows.Forms.TextBox txtmachucvu;
    }
}