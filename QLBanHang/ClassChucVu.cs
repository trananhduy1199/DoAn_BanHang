using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanHang.LinQToSQL;
using System.Windows.Forms;

namespace QLBanHang
{
    class ClassChucVu
    {
        ConnectToDatabase data;
        public ClassChucVu()
        {
            data = new ConnectToDatabase();
        }

        public void LoadData(FormChucVu fcv)
        {
            var cv = data.Database().CHUCVUs.ToList();
            fcv.gridControlChucVu.DataSource = cv; // Nếu nó không hiện cái gridcontrol thì qua formchucvu cái chỗ gridcontrol ->F4-> kiếm cái modifier -> public

            //Load Mã Chức Vụ
            int dem = 10;
            int kyso = (int)data.Database().RETURN_KYSO("CV");
            int lenght = kyso.ToString().Length;
            dem = dem - 2 - lenght;
            string kq = "CV";
            for (int i = 1; i <= dem; i++)
            {
                kq += "0";
            }
            fcv.txtmachucvu.Text = kq + kyso.ToString();
        }

        //Kiểm tra thêm Chức Vụ
        public static bool KiemTraThemVaSuaCV(string tencv)
        {
            int kt = 0;
            string kq = "Phát Hiện 1 Trong Những Lỗi Sau:\n";
            if (tencv == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập tên chức vụ\n";
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

        //Thêm Chức Vụ
        public void ThemCV(string macv, string tencv)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có chắc muốn thêm", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (thongbao == DialogResult.Yes)
            {
                CHUCVU cv = new CHUCVU();
                cv.MACV = macv;
                cv.TENCV = tencv;

                data.Database().CHUCVUs.InsertOnSubmit(cv);
                data.Database().SubmitChanges();
                data.Database().TANG_MATUDONG("CV");
                MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Kiểm tra sửa chức vụ
        public static bool KiemTraSuaCV(string macv, string tencv)
        {
            int kt = 0;
            string kq = "Phát Hiện Những Lỗi Sau:\n";
            if (macv == "")
            {
                kt = 1;
                kq += "-Vui lòng chọn mã chức vụ\n";
            }
            if (tencv == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập tên chức vụ\n";
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
        //Sửa Chức Vụ
        public void SuaCV(string macv, string tencv)
        {
            DialogResult thongbao;
            CHUCVU cv = data.Database().CHUCVUs.SingleOrDefault(c => c.MACV == macv);
            if (cv != null)
            {
                thongbao = (MessageBox.Show("Bạn có chắc muốn sửa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (thongbao == DialogResult.Yes)
                {
                    cv.TENCV = tencv;
                    data.Database().SubmitChanges();
                    MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Mã chức vụ không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Kiểm tra xóa chức vụ
        public static bool KiemTraXoaCV(string macv)
        {
            int kt = 0;
            string kq = "Phát Hiện Những Lỗi Sau:\n";
            if (macv == "")
            {
                kt = 1;
                kq += "-Vui lòng chọn mã chức vụ để xóa\n";
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

        //Xóa Chức Vụ
        public void XoaCV(string macv)
        {
            CHUCVU cv = data.Database().CHUCVUs.SingleOrDefault(c => c.MACV == macv);
            DialogResult thongbao;
            if (cv != null)
            {
                thongbao = (MessageBox.Show("Bạn có chắc muốn xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (thongbao == DialogResult.Yes)
                {
                    data.Database().CHUCVUs.DeleteOnSubmit(cv);
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
    

