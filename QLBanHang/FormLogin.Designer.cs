namespace QLBanHang
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.txtmatkhau = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.txttaikhoan = new DevExpress.XtraEditors.TextEdit();
            this.butthoat = new DevExpress.XtraEditors.SimpleButton();
            this.butdangnhap = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.checkEdithethong = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditnhanvien = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmatkhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttaikhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdithethong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditnhanvien.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(322, 118);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(190, 20);
            this.txtmatkhau.TabIndex = 1;
            this.txtmatkhau.Tag = "2";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Top;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(255, 66);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Tài Khoản";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Location = new System.Drawing.Point(255, 121);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Mật Khẩu";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "McSkin";
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.Location = new System.Drawing.Point(322, 64);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Size = new System.Drawing.Size(190, 20);
            this.txttaikhoan.TabIndex = 7;
            this.txttaikhoan.Tag = "1";
            // 
            // butthoat
            // 
            this.butthoat.Appearance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butthoat.Appearance.Options.UseFont = true;
            this.butthoat.Image = ((System.Drawing.Image)(resources.GetObject("butthoat.Image")));
            this.butthoat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.butthoat.Location = new System.Drawing.Point(420, 159);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(92, 23);
            this.butthoat.TabIndex = 5;
            this.butthoat.Tag = "4";
            this.butthoat.Text = "Thoát";
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // butdangnhap
            // 
            this.butdangnhap.Appearance.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butdangnhap.Appearance.Options.UseFont = true;
            this.butdangnhap.Image = ((System.Drawing.Image)(resources.GetObject("butdangnhap.Image")));
            this.butdangnhap.Location = new System.Drawing.Point(322, 159);
            this.butdangnhap.Name = "butdangnhap";
            this.butdangnhap.Size = new System.Drawing.Size(92, 23);
            this.butdangnhap.TabIndex = 4;
            this.butdangnhap.Tag = "3";
            this.butdangnhap.Text = "Đăng Nhập";
            this.butdangnhap.Click += new System.EventHandler(this.butdangnhap_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "ĐĂNG NHẬP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkEdithethong
            // 
            this.checkEdithethong.Location = new System.Drawing.Point(322, 35);
            this.checkEdithethong.Name = "checkEdithethong";
            this.checkEdithethong.Properties.Caption = "Hệ thống";
            this.checkEdithethong.Size = new System.Drawing.Size(75, 20);
            this.checkEdithethong.TabIndex = 9;
            this.checkEdithethong.CheckedChanged += new System.EventHandler(this.checkEdithethong_CheckedChanged);
            // 
            // checkEditnhanvien
            // 
            this.checkEditnhanvien.Location = new System.Drawing.Point(432, 35);
            this.checkEditnhanvien.Name = "checkEditnhanvien";
            this.checkEditnhanvien.Properties.Caption = "Nhân Viên";
            this.checkEditnhanvien.Size = new System.Drawing.Size(75, 20);
            this.checkEditnhanvien.TabIndex = 10;
            this.checkEditnhanvien.CheckedChanged += new System.EventHandler(this.checkEditnhanven_CheckedChanged);
            // 
            // FormLogin
            // 
            this.Appearance.BackColor = System.Drawing.Color.AliceBlue;
            this.Appearance.ForeColor = System.Drawing.Color.AliceBlue;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.None;
            this.BackgroundImageStore = global::QLBanHang.Properties.Resources.Login_icon;
            this.ClientSize = new System.Drawing.Size(519, 237);
            this.Controls.Add(this.checkEditnhanvien);
            this.Controls.Add(this.checkEdithethong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttaikhoan);
            this.Controls.Add(this.butthoat);
            this.Controls.Add(this.butdangnhap);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtmatkhau);
            this.DoubleBuffered = true;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)(this.txtmatkhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttaikhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdithethong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditnhanvien.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtmatkhau;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton butdangnhap;
        private DevExpress.XtraEditors.SimpleButton butthoat;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.TextEdit txttaikhoan;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.CheckEdit checkEdithethong;
        private DevExpress.XtraEditors.CheckEdit checkEditnhanvien;
    }
}