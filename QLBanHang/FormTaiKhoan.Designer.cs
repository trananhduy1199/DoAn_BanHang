namespace QLBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaiKhoan));
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.comboboxmanv = new System.Windows.Forms.ComboBox();
            this.simpleButtonthoat = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtondoimatkhau = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonxoa = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonthem = new DevExpress.XtraEditors.SimpleButton();
            this.txttaikhoan = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControltaikhoan = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControltaikhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ TÀI KHOẢN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.comboboxmanv);
            this.groupControl1.Controls.Add(this.simpleButtonthoat);
            this.groupControl1.Controls.Add(this.simpleButtondoimatkhau);
            this.groupControl1.Controls.Add(this.simpleButtonxoa);
            this.groupControl1.Controls.Add(this.simpleButtonthem);
            this.groupControl1.Controls.Add(this.txttaikhoan);
            this.groupControl1.Controls.Add(this.txtmatkhau);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Location = new System.Drawing.Point(12, 74);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(755, 142);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Tạo Tài Khoản";
            // 
            // comboboxmanv
            // 
            this.comboboxmanv.FormattingEnabled = true;
            this.comboboxmanv.Location = new System.Drawing.Point(136, 31);
            this.comboboxmanv.Name = "comboboxmanv";
            this.comboboxmanv.Size = new System.Drawing.Size(211, 21);
            this.comboboxmanv.TabIndex = 1;
            this.comboboxmanv.Tag = "1";
            // 
            // simpleButtonthoat
            // 
            this.simpleButtonthoat.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonthoat.Image")));
            this.simpleButtonthoat.Location = new System.Drawing.Point(605, 95);
            this.simpleButtonthoat.Name = "simpleButtonthoat";
            this.simpleButtonthoat.Size = new System.Drawing.Size(111, 40);
            this.simpleButtonthoat.TabIndex = 7;
            this.simpleButtonthoat.Tag = "8";
            this.simpleButtonthoat.Text = "Thoát";
            this.simpleButtonthoat.Click += new System.EventHandler(this.simpleButtonthoat_Click);
            // 
            // simpleButtondoimatkhau
            // 
            this.simpleButtondoimatkhau.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtondoimatkhau.Image")));
            this.simpleButtondoimatkhau.Location = new System.Drawing.Point(605, 34);
            this.simpleButtondoimatkhau.Name = "simpleButtondoimatkhau";
            this.simpleButtondoimatkhau.Size = new System.Drawing.Size(111, 40);
            this.simpleButtondoimatkhau.TabIndex = 6;
            this.simpleButtondoimatkhau.Tag = "6";
            this.simpleButtondoimatkhau.Text = "Đổi Mật Khẩu";
            // 
            // simpleButtonxoa
            // 
            this.simpleButtonxoa.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonxoa.Image")));
            this.simpleButtonxoa.Location = new System.Drawing.Point(412, 95);
            this.simpleButtonxoa.Name = "simpleButtonxoa";
            this.simpleButtonxoa.Size = new System.Drawing.Size(111, 40);
            this.simpleButtonxoa.TabIndex = 5;
            this.simpleButtonxoa.Tag = "7";
            this.simpleButtonxoa.Text = "Xóa";
            this.simpleButtonxoa.Click += new System.EventHandler(this.simpleButtonxoa_Click);
            // 
            // simpleButtonthem
            // 
            this.simpleButtonthem.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonthem.Image")));
            this.simpleButtonthem.Location = new System.Drawing.Point(412, 34);
            this.simpleButtonthem.Name = "simpleButtonthem";
            this.simpleButtonthem.Size = new System.Drawing.Size(111, 40);
            this.simpleButtonthem.TabIndex = 4;
            this.simpleButtonthem.Tag = "5";
            this.simpleButtonthem.Text = "Thêm";
            this.simpleButtonthem.Click += new System.EventHandler(this.simpleButtonthem_Click);
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.Location = new System.Drawing.Point(136, 71);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Size = new System.Drawing.Size(211, 21);
            this.txttaikhoan.TabIndex = 2;
            this.txttaikhoan.Tag = "3";
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(136, 111);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(211, 21);
            this.txtmatkhau.TabIndex = 3;
            this.txtmatkhau.Tag = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mật Khẩu";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tài Khoản";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Nhân Viên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.gridControltaikhoan);
            this.groupControl2.Location = new System.Drawing.Point(12, 222);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(755, 262);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Danh Sách Tài Khoản";
            // 
            // gridControltaikhoan
            // 
            this.gridControltaikhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControltaikhoan.Location = new System.Drawing.Point(5, 23);
            this.gridControltaikhoan.MainView = this.gridView1;
            this.gridControltaikhoan.Name = "gridControltaikhoan";
            this.gridControltaikhoan.Size = new System.Drawing.Size(745, 240);
            this.gridControltaikhoan.TabIndex = 0;
            this.gridControltaikhoan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControltaikhoan;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // FormTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 496);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.label1);
            this.Name = "FormTaiKhoan";
            this.Text = "FormTaiKhoan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControltaikhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonthoat;
        private DevExpress.XtraEditors.SimpleButton simpleButtondoimatkhau;
        private DevExpress.XtraEditors.SimpleButton simpleButtonxoa;
        private DevExpress.XtraEditors.SimpleButton simpleButtonthem;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public System.Windows.Forms.TextBox txttaikhoan;
        public System.Windows.Forms.TextBox txtmatkhau;
        public System.Windows.Forms.ComboBox comboboxmanv;
        public DevExpress.XtraGrid.GridControl gridControltaikhoan;
    }
}