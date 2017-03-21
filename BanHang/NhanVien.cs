using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanHang.LinqToSQL;

namespace BanHang
{
    class NhanVien
    {
        ConnectToDatabase data;

        public NhanVien()
        {
            data = new ConnectToDatabase();
        }

        public void LoadData(FormNhanVien fnv)
        {
            var nv = data.Database().NHANVIENs.ToList();
            fnv.gridControlnhanvien.DataSource = nv;

            //Load Mã Nhân Viên
            int dem = 10;
            int kyso = (int)data.Database().RETURN_KYSO("NV");
            int len = kyso.ToString().Length;
            dem = dem - 2 - len;
            string kq = "NV";
            for (int i = 1; i <= dem; i++)
            {
                kq += "0";
            }
            fnv.txtmanhanvien.Text = kq + kyso.ToString();
        }

        //Load Combobox chức vụ.
        public void LoadChucVu(FormNhanVien fnv)
        {
            var cv = data.Database().CHUCVUs.ToList();
            fnv.comboBoxchucvu.DataSource = cv;
            fnv.comboBoxchucvu.DisplayMember = "TENCV";
            fnv.comboBoxchucvu.ValueMember = "MACV";
        }

        public void Loadcombo(FormNhanVien fnv)
        {
            var tam = data.Database().CHUCVUs.ToList();
            foreach (var item in tam)
            {
                fnv.comboBoxTest.Items.Add(item.TENCV);
            }
        }

        public void ChonMaCV(FormNhanVien fnv)
        {
            var machucvutam = fnv.gridView1.GetRowCellValue(fnv.gridView1.FocusedRowHandle, "MACV").ToString();

            var laydl=data.Database().CHUCVUs.SingleOrDefault(l=>l.MACV==machucvutam);
            fnv.comboBoxchucvu.Text = laydl.TENCV;
        }
        

        //Kiểm tra thêm nhân viên
        public static bool KiemTraThemNV(string manv, string tennv, string ngaysinh, string gioitinh, string choohientai, string sodienthoai, string socmnd, string noicap, string hokhau, string ngaycap, string chucvu, string hinhanh)
        {
            int kt = 0;
            string kq = "Phát Hiện Những Lỗi Sau:\n";
            if (manv == "")
            {
                kt = 1;
            }
            if (tennv == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập tên nhân viên\n";
            }
            if (ngaysinh == "")
            {
                kt = 1;
                kq += "-Vui lòng chọn ngày sinh\n";
            }
            if (gioitinh == "")
            {
                kt = 1;
                kq += "-Vui lòng chọn giới tính\n";
            }
            if (choohientai == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập chỗ ổ hiện tại\n";
            }
            if (sodienthoai == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập số điện thoại\n";
            }
            if (socmnd == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập số CMND\n";
            }
            if (noicap == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập nơi cấp CMND\n";
            }
            if (hokhau == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập hộ khẩu\n";
            }
            if (ngaycap == "")
            {
                kt = 1;
                kq += "-Vui lòng chọn ngày cấp CMND\n";
            }
            if (chucvu == "")
            {
                kt = 1;
                kq += "-Vui lòng chọn chức vụ\n";
            }
            if (hinhanh == "")
            {
                kt = 1;
                kq += "-Vui lòng chọn đường dẫn ảnh\n";
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

        //Thêm Nhân Viên
        public void ThemNV(string manv, string tennv, string ngaysinh, string gioitinh, string choohientai, string sodienthoai, string socmnd, string noicap, string hokhau, string ngaycap, string tenchucvu, string hinhanh)
        {
            NHANVIEN kt = data.Database().NHANVIENs.SingleOrDefault(k => k.MANV == manv);
            if (kt == null)
            {
                NHANVIEN nv = new NHANVIEN();
                nv.MANV = manv;
                nv.TENNV = tennv;
                nv.NGAYSINH = Convert.ToDateTime(ngaysinh.ToString());
                nv.GIOITINH = gioitinh;
                nv.DCNVHIENTAI = choohientai;
                nv.DTNV = sodienthoai;
                nv.CMND = socmnd;
                nv.NOICAPCMND = noicap;
                nv.HOKHAU = hokhau;
                nv.NGAYCAPCMND = Convert.ToDateTime(ngaycap.ToString());
                CHUCVU CV = data.Database().CHUCVUs.SingleOrDefault(c=>c.TENCV==tenchucvu);
                if (CV != null)
                {
                    nv.MACV = CV.MACV;   
                }                
                nv.HINHANH = hinhanh;

                data.Database().NHANVIENs.InsertOnSubmit(nv);
                data.Database().SubmitChanges();
                data.Database().TANG_MATUDONG("NV");
            }
            else
            {
                MessageBox.Show("Không thể thêm vì mã nhân viên đã có rồi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Kiểm tra sửa nhân viên
        public static bool KiemTraSuaNV(string manv, string tennv, string ngaysinh, string gioitinh, string choohientai, string sodienthoai, string socmnd, string noicap, string hokhau, string ngaycap, string chucvu, string hinhanh)
        {
            int kt = 0;
            string kq = "Phát Hiện Những Lỗi Sau:\n";
            if (manv == "")
            {
                kt = 1;
                kq += "-Vui lòng chọn mã nhân viên để sửa\n";
            }
            if (tennv == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập tên nhân viên\n";
            }
            if (ngaysinh == "")
            {
                kt = 1;
                kq += "-Vui lòng chọn ngày sinh\n";
            }
            if (gioitinh == "")
            {
                kt = 1;
                kq += "-Vui lòng chọn giới tính\n";
            }
            if (choohientai == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập chỗ ổ hiện tại\n";
            }
            if (sodienthoai == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập số điện thoại\n";
            }
            if (socmnd == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập số CMND\n";
            }
            if (noicap == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập nơi cấp CMND\n";
            }
            if (hokhau == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập hộ khẩu\n";
            }
            if (ngaycap == "")
            {
                kt = 1;
                kq += "-Vui lòng chọn ngày cấp CMND\n";
            }
            if (chucvu == "")
            {
                kt = 1;
                kq += "-Vui lòng chọn chức vụ\n";
            }
            if (hinhanh == "")
            {
                kt = 1;
                kq += "-Vui lòng chọn đường dẫn ảnh\n";
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

        //Sửa nhân viên
        public void SuaNV(string manv, string tennv, string ngaysinh, string gioitinh, string choohientai, string sodienthoai, string socmnd, string noicap, string hokhau, string ngaycap, string tenchucvu, string hinhanh)
        {
            try
            {
                NHANVIEN nv = data.Database().NHANVIENs.SingleOrDefault(n => n.MANV == manv);
                DialogResult thongbao;
                if (nv != null)
                {
                    thongbao = (MessageBox.Show("Bạn có chắc muốn sửa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                    if (thongbao == DialogResult.Yes)
                    {
                        nv.TENNV = tennv;
                        nv.NGAYSINH = Convert.ToDateTime(ngaysinh.ToString());
                        nv.GIOITINH = gioitinh;
                        nv.DCNVHIENTAI = choohientai;
                        nv.DTNV = sodienthoai;
                        nv.CMND = socmnd;
                        nv.NOICAPCMND = noicap;
                        nv.HOKHAU = hokhau;
                        nv.NGAYCAPCMND = Convert.ToDateTime(ngaycap.ToString());
                        //CHUCVU CV = data.Database().CHUCVUs.SingleOrDefault(c => c.TENCV == tenchucvu);
                        //if (CV != null)
                        //{
                        //    nv.MACV = CV.MACV;
                        //}                
                        nv.HINHANH = hinhanh;

                        data.Database().SubmitChanges();
                        MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Mã nhân viên không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Kiểm tra xóa nhân viên
        public static bool KiemTraXoaNV(string manv)
        {
            int kt = 0;
            string kq = "Phát Hiện Những Lỗi Sau:\n";
            if (manv == "")
            {
                kt = 1;
                kq += "-Vui lòng chọn mã nhân viên để xóa\n";
            }
            if (kt == 1)
            {
                MessageBox.Show(kq, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }

        }

        //Xóa Nhân Viên
        public void XoaNV(string manv)
        {
            NHANVIEN nv = data.Database().NHANVIENs.SingleOrDefault(n=>n.MANV==manv);
            DialogResult thongbao;
            if (nv != null)
            {
                thongbao = (MessageBox.Show("Bạn có chắc muốn xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (thongbao == DialogResult.Yes)
                {
                    data.Database().NHANVIENs.DeleteOnSubmit(nv);
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
