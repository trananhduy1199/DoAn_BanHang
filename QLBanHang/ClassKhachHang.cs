using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanHang.LinQToSQL;

namespace QLBanHang
{
    class ClassKhachHang
    {
       ConnectToDatabase data;
        public ClassKhachHang()
        {
            data = new ConnectToDatabase();
        }

        public void LoadData(FormKhachHang fkh)
        {
            var kh = data.Database().KHACHHANGs.ToList();
            fkh.gridControlKhachHang.DataSource = kh;

            int dem = 10;
            int kyso = (int)data.Database().RETURN_KYSO("KH");
            int len = kyso.ToString().Length;
            dem = dem - 2 - len;
            string kq = "KH";
            for (int i = 1; i <= dem; i++)
            {
                kq += "0";
            }
            fkh.txtmakhachhang.Text = kq + kyso.ToString();

        }

        //Kiểm tra thêm  khách hàng
        public static bool KiemTraThemKH(string makh, string tenkh, string gioitinh, string ngaysinh, string diachi, string sodienthoai)
        {
            int kt = 0;
            string kq = "Phát Hiện Những Lỗi Sau:\n";
            if (makh == "")
            {
                kt = 1;
            }
            if (tenkh == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập tên khách hàng\n";
            }
            if (gioitinh == "")
            {
                kt = 1;
                kq += "-Vui lòng chọn giới tính\n";
            }
            if (ngaysinh == "")
            {
                kt = 1;
                kq += "-Vui lòng chọn ngày sinh\n";
            }
            if (diachi == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập địa chỉ\n";
            }
            if (sodienthoai == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập số điện thoại";
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

        //Thêm Khách Hàng
        public void ThemKH(string makh, string tenkh, string ngaysinh, string gioitinh, string diachi, string sodienthoai)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có chắc muốn thêm", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (thongbao == DialogResult.Yes)
            {
                KHACHHANG kh = new KHACHHANG();
                kh.MAKH = makh;
                kh.TENKH = tenkh;                
                kh.DCKH = diachi;
                kh.DTKH = sodienthoai;

                data.Database().KHACHHANGs.InsertOnSubmit(kh);
                data.Database().SubmitChanges();
                data.Database().TANG_MATUDONG("KH");
                MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Kiểm tra sửa khách hàng
        public static bool KiemTraSuaKH(string makh, string tenkh, string gioitinh, string ngaysinh, string diachi, string sodienthoai)
        {
            int kt = 0;
            string kq = "Phát Hiện Những Lỗi Sau:\n";
            if (makh == "")
            {
                kt = 1;
                kq += "-Vui lòng chọn mã khách hàng để sửa\n";
            }
            if (tenkh == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập tên khách hàng\n";
            }
            if (gioitinh == "")
            {
                kt = 1;
                kq += "-Vui lòng chọn giới tính\n";
            }
            if (ngaysinh == "")
            {
                kt = 1;
                kq += "-Vui lòng chọn ngày sinh\n";
            }
            if (diachi == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập địa chỉ\n";
            }
            if (sodienthoai == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập số điện thoại";
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



        //Sửa Khách Hàng
        public void SuaKH(string makh, string tenkh, string ngaysinh, string gioitinh, string diachi, string sodienthoai)
        {
            KHACHHANG kh = data.Database().KHACHHANGs.SingleOrDefault(k => k.MAKH == makh);
            DialogResult thongbao;
            if (kh != null)
            {
                thongbao = (MessageBox.Show("Bạn có chắc muốn sửa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (thongbao == DialogResult.Yes)
                {
                    kh.TENKH = tenkh;                    
                    kh.DCKH = diachi;
                    kh.DTKH = sodienthoai;

                    data.Database().SubmitChanges();
                    MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Mã chức vụ không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        //Kiểm tra xóa khách hàng
        public static bool KiemTraXoaKH(string makh)
        {
            int kt = 0;
            string kq = "Phát Hiện Những Lỗi Sau:\n";
            if (makh == "")
            {
                kt = 1;
                kq += "-Vui lòng chọn mã khách hàng để xóa\n";
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
        //Xóa Khách Hàng
        public void XoaKH(string makh)
        {
            KHACHHANG kh = data.Database().KHACHHANGs.SingleOrDefault(k => k.MAKH == makh);
            DialogResult thongbao;
            if (kh != null)
            {
                thongbao = (MessageBox.Show("Bạn có chắc muốn xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (thongbao == DialogResult.Yes)
                {
                    data.Database().KHACHHANGs.DeleteOnSubmit(kh);
                    data.Database().SubmitChanges();
                    MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Mã Không Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}




