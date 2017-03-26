using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLBanHang.LinQToSQL;

namespace QLBanHang
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DBQLBanHangDataContext data = new DBQLBanHangDataContext();
        TAIKHOAN tk = new TAIKHOAN();
        FormLogin fl = new FormLogin();
        public static string Quyen = "";

        public void NhanDuLieu(string s)
        {

            string[] k = s.Split('-');
            butlogin.Enabled = false;
            butexit.Enabled = false;
            var username = k[0].Trim();
            var password = k[1].Trim();
            TAIKHOAN t = data.TAIKHOANs.SingleOrDefault(n => n.TAIKHOAN1 == username && n.MATKHAU == password);
            if (t != null)
            {
                //Phân Quyền ổ đây
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butlogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormLogin lg = new FormLogin();
            lg.MdiParent = this;
            lg.TruyenVeMain = new FormLogin.TruyenDuLieu(NhanDuLieu);
            lg.Show();
        }

        private void butexit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có chắc chắn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

       

        private void barButsanpham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormSanPham sp = new FormSanPham();
            sp.MdiParent = this;
            sp.Show();
        }

        private void barbuttaikhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormTaiKhoan tk = new FormTaiKhoan();
            tk.MdiParent = this;
            tk.Show();

        }

        private void barButkhachhang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormKhachHang kh = new FormKhachHang();
            kh.MdiParent = this;
            kh.Show();
        }

        private void barButnhanvien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormNhanVien nv = new FormNhanVien();
            nv.MdiParent = this;
            nv.Show();
        }

        private void barButbanhang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormBanHang bh = new FormBanHang();
            bh.MdiParent = this;
            bh.Show();
        }

        private void barButmuahang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormMuaHang mh = new FormMuaHang();
            mh.MdiParent = this;
            mh.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormNCC ncc = new FormNCC();
            ncc.MdiParent = this;
            ncc.Show();
        }
    }
}
