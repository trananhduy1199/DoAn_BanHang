﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanHang.LinQToSQL;

namespace QLBanHang
{
    class ClassTaiKhoan
    {
        ConnectToDatabase data;
        public ClassTaiKhoan()
        {
            data = new ConnectToDatabase();
        }
        public void LoadData(FormTaiKhoan ftk)
        {
            var dl = data.Database().TAIKHOANs.ToList();
            ftk.gridControltaikhoan.DataSource = dl;
        }

        public void LoadMaNV(FormTaiKhoan ftk)
        {
            var dl = data.Database().NHANVIENs.ToList();
            ftk.comboboxmanv.DataSource = dl;
            ftk.comboboxmanv.DisplayMember = "MANV";
            ftk.comboboxmanv.ValueMember = "MANV";
        }

        public static bool KTThemTK(string taikhoan, string matkhau, string manv)
        {
            int kt = 0;
            string kq = "Phát Hiện Những Lỗi Sau:\n";
            if (taikhoan == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập Tài Khoản\n";
            }
            if (matkhau == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập Mật Khẩu\n";
            }
            if (manv == "")
            {
                kt = 1;
                kq += "-Vui lòng chọn Mã Nhân Viên\n";
            }
            if (kt == 1)
            {
                MessageBox.Show(kq, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        public void ThemTK(string taikhoan, string matkhau, string manv)
        {
            TAIKHOAN tk_tam = data.Database().TAIKHOANs.SingleOrDefault(t => t.TAIKHOAN1 == taikhoan);
            DialogResult thongbao;
            if (tk_tam == null)
            {
                thongbao = (MessageBox.Show("Bạn có chắc muốn thêm", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (thongbao == DialogResult.Yes)
                {
                    TAIKHOAN tk = new TAIKHOAN();
                    tk.TAIKHOAN1 = taikhoan;
                    tk.MATKHAU = matkhau;
                    tk.MANV = manv;
                    data.Database().TAIKHOANs.InsertOnSubmit(tk);
                    data.Database().SubmitChanges();
                    MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool KTSuaTK(string taikhoan, string matkhau, string manv)
        {
            int kt = 0;
            string kq = "Phát Hiện Những Lỗi Sau:\n";
            if (taikhoan == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập hoặc chọn Tài Khoản\n";
            }
            if (matkhau == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập Mật Khẩu\n";
            }
            if (manv == "")
            {
                kt = 1;
                kq += "-Vui lòng chọn Mã Nhân Viên\n";
            }
            if (kt == 1)
            {
                MessageBox.Show(kq, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        public void SuaTK(string taikhoan, string matkhau, string manv)
        {
            TAIKHOAN tk = data.Database().TAIKHOANs.SingleOrDefault(t => t.TAIKHOAN1 == taikhoan);
            DialogResult thongbao;
            if (tk != null)
            {
                thongbao = (MessageBox.Show("Bạn có chắc muốn sửa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (thongbao == DialogResult.Yes)
                {
                    tk.MATKHAU = matkhau;
                    tk.MANV = manv;
                    data.Database().SubmitChanges();
                    MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool KTXoaTK(string taikhoan)
        {
            int kt = 0;
            string kq = "Phát Hiện Những Lỗi Sau:\n";
            if (taikhoan == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập hoặc chọn Tài Khoản để xóa\n";
            }
            if (kt == 1)
            {
                MessageBox.Show(kq, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        public void XoaTK(string taikhoan)
        {
            TAIKHOAN tk = data.Database().TAIKHOANs.SingleOrDefault(t => t.TAIKHOAN1 == taikhoan);
            DialogResult thongbao;
            if (tk != null)
            {
                thongbao = (MessageBox.Show("Bạn có chắc muốn xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (thongbao == DialogResult.Yes)
                {
                    data.Database().TAIKHOANs.DeleteOnSubmit(tk);
                    data.Database().SubmitChanges();
                    MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
   
    }

}


 