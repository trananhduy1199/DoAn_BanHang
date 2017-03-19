using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanHang.LinqToSQL;
using System.Windows.Forms;

namespace BanHang
{
    class SanPham
    {
        ConnectToDatabase data; //Gọi class ConnectToDatabase

        public SanPham()
        {
            data = new ConnectToDatabase(); //Tạo mới 
        }

        //Load data lên form (load lên gridcontrol, load mã sản phẩm)
        public void LoadData(FormSanPham fsp)
        {

            //Load data lên gridControl
            var sp = data.Database().SANPHAMs.ToList();
            fsp.gridControlsanpham.DataSource = sp;

            //Load Mã Sản Phẩm
            int dem = 10;
            int kyso = (int)data.Database().RETURN_KYSO("SP");
            int lenght = kyso.ToString().Length;
            dem=dem-2-lenght;
            string kq="SP";
            for(int i=1;i<=dem;i++)
            {
                kq+="0";
            }
            fsp.txtmasanpham.Text=kq+kyso.ToString();
        }        

        //Kiểm tra  thêm sản phẩm
        public static bool KiemTraThemSP(string masp,string tensp, string quycach, string giaban, string soluongton)
        {
            int kt = 0;
            string kq = "Phát Hiện Những Lỗi Sau:\n";
            
            if (tensp == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập tên sản phẩm\n";
            }
            if (quycach == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập quy cách\n";
            }
            if (giaban == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập giá bán\n";
            }
            if (soluongton == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập số lượng tồn";
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
        

        //Thêm sản phẩm
        public void ThemSP(string masp, string tensp, string quycach, int giaban, int soluongton )
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có chắc muốn thêm", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (thongbao == DialogResult.Yes)
            {
                SANPHAM sp = new SANPHAM();   //Table trong LinQ
                sp.MASP = masp;
                sp.TENSP = tensp;
                sp.QUYCACH = quycach;
                sp.GIABAN = giaban;
                sp.SLTON = soluongton;

                data.Database().TANG_MATUDONG("SP"); // Tăng ký số trong table cấp mã tự động
                data.Database().SANPHAMs.InsertOnSubmit(sp); // Tiến hành thêm
                data.Database().SubmitChanges(); //Lưu lại
                MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        //Kiểm tra sửa sản phẩm
        public static bool KiemTraSuaSP(string masp, string tensp, string quycach, string giaban, string soluongton)
        {
            int kt = 0;
            string kq = "Phát Hiện Những Lỗi Sau:\n";

            if (masp == "")
            {
                kt = 1;
                kq += "-Vui lòng chọn mã sản phẩm\n";
            }            
            if (tensp == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập tên sản phẩm\n";
            }
            if (quycach == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập quy cách\n";
            }
            if (giaban == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập giá bán\n";
            }
            if (soluongton == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập số lượng tồn";
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
        

        //Sửa sản phẩm
        public void SuaSP(string masp, string tensp, string quycach, int giaban, int soluongton)
        {
            SANPHAM sp = data.Database().SANPHAMs.SingleOrDefault(s=>s.MASP==masp);
            DialogResult thongbao;
            if (sp != null)
            {
                thongbao=(MessageBox.Show("Bạn có chắc muốn sửa","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question));
                if(thongbao==DialogResult.Yes)
                {
                    sp.TENSP = tensp;
                    sp.QUYCACH = quycach;
                    sp.GIABAN = giaban;
                    sp.SLTON = soluongton;
                    data.Database().SubmitChanges();
                    MessageBox.Show("Sửa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                  
            }
            else
            {
                MessageBox.Show("Mã sản phẩm không tồn tại","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        //KIểm tra xóa sản phẩm
        public static bool KTXoaSP(string masp)
        {
            int kt = 0;
            string kq = "Phát Hiện Những Lỗi Sau:\n";

            if (masp == "")
            {
                kt = 1;
                kq += "-Vui lòng chọn mã sản phẩm để xóa\n";
            }

            if (kt == 1)
            {
                MessageBox.Show(kq,"Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        //Xóa sản phẩm
        public void XoaSP(string masp)
        {
            SANPHAM sp = data.Database().SANPHAMs.SingleOrDefault(s => s.MASP == masp);
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
