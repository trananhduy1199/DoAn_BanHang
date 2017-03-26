using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanHang.LinQToSQL;
using System.Windows.Forms;

namespace QLBanHang
{
    class ClassSanPham
    {
        ConnectToDatabase data;
        public ClassSanPham()
        {
            data = new ConnectToDatabase();
        }

        public void LoadData(FormSanPham fsp)
        {
            var sp = data.Database().SANPHAMs.ToList();
            fsp.gridControlSanPham.DataSource = sp;
            //Load Mã Sản Phẩm
            int dem = 10;
            int kyso = (int)data.Database().RETURN_KYSO("SP");
            int lenght = kyso.ToString().Length;
            dem = dem - 2 - lenght;
            string kq = "SP";
            for (int i = 1; i <= dem; i++)
            {
                kq += "0";
            }
            fsp.txtmasanpham.Text = kq + kyso.ToString();

        }
        public static bool KTThemSP(string tensp, string giamua, string giaban, string soluongton)
        {
            int kt = 0;
            string kq = "Phát Hiện 1 Trong Những Lỗi Sau:\n";
            if (tensp == "")
            {
                kt += 1;
                kq += "-Vui lòng nhập tên sản phẩm\n";
            }
            if (giamua == "")
            {
                kt += 1;
                kq += "-Vui lòng nhập giá mua\n";
            }
            if (giaban == "")
            {
                kt += 1;
                kq += "-Vui lòng nhập giá bán\n ";
            }
            if (soluongton == "")
            {
                kt += 1;
                kq += "-Vui lòng nhập số lượng tồn\n ";
            }
            if (kt == 1)
            {
                MessageBox.Show(kq, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;

            }


        }
        public void ThemSP(string masp, string tensp, string giamua, string giaban, string soluongton)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có chắc muốn thêm", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            //var sp = data.Database().SANPHAMs.SingleOrDefault(n => n.MASP == masp);
            //if (sp == null)
            //{
                if (thongbao == DialogResult.Yes)
                {
                    SANPHAM sp1 = new SANPHAM();
                    sp1.MASP = masp;
                    sp1.TENSP = tensp;
                    sp1.GIAMUA = int.Parse(giamua);
                    sp1.GIABAN = int.Parse(giaban);
                    sp1.SLTON = int.Parse(soluongton);

                    data.Database().SANPHAMs.InsertOnSubmit(sp1);
                    data.Database().SubmitChanges();
                    data.Database().TANG_MATUDONG("SP");
                    MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            //}
        }
        public static bool KTSuaSP(string masp,string tensp, string giamua, string giaban, string soluongton)
        {
            int kt = 0;
            string kq = "Phát Hiện 1 Trong Những Lỗi Sau:\n";
            if (masp == "")
            {
                kt += 1;
                kq += "-Vui lòng chọn mã sản phẩm\n";
            }
            if (tensp == "")
            {
                kt += 1;
                kq += "-Vui lòng nhập tên sản phẩm\n";
            }
            if (giamua == "")
            {
                kt += 1;
                kq += "-Vui lòng nhập giá mua\n";
            }
            if (giaban == "")
            {
                kt += 1;
                kq += "-Vui lòng nhập giá bán\n ";
            }
            if (soluongton == "")
            {
                kt += 1;
                kq += "-Vui lòng nhập số lượng tồn\n ";
            }
            if (kt == 1)
            {
                MessageBox.Show(kq, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return false;

            }



        }
        public void SuaSP(string masp, string tensp, string giamua, string giaban, string soluongton)
        {
            DialogResult thongbao;
            SANPHAM sp = data.Database().SANPHAMs.SingleOrDefault(n => n.MASP == masp);
            {
                if(sp != null)
                {
                     thongbao = (MessageBox.Show("Bạn có chắc muốn sửa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                        if (thongbao == DialogResult.Yes)
                        {
                                sp.MASP = masp;
                                sp.TENSP = tensp;
                                sp.GIAMUA = int.Parse(giamua);
                                sp.GIABAN = int.Parse(giaban);
                                sp.SLTON = int.Parse(soluongton);
                                data.Database().SubmitChanges();
                                MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    
                    else
                    {
                        MessageBox.Show("Mã Sản Phẩm không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        public static bool KTXoaSP(string masp)
        {
            int kt = 0;
            string kq = "Phát Hiện 1 Trong Những Lỗi Sau:\n";
            if (masp == "")
            {
                kt += 1;
                kq += "-Vui lòng chọn mã sản phẩm\n";
            }           
            if (kt == 1)
            {
                MessageBox.Show(kq, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return false;

            }

        }
        public void XoaSP(string masp)
        {
            SANPHAM sp = data.Database().SANPHAMs.SingleOrDefault(n => n.MASP == masp);
            DialogResult thongbao;
            if (sp != null)
            {
                thongbao = (MessageBox.Show("Bạn có chắc muốn xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (thongbao == DialogResult.Yes)
                {
                    data.Database().SANPHAMs.DeleteOnSubmit(sp);
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
