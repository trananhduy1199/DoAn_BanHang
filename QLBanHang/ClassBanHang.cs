using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanHang.LinQToSQL;

namespace QLBanHang
{

  
    class ClassBanHang
    {
        private string maSP;
        private string tenSP;

        private string soluong;
        private string donGia;

        public string MaSP
        {
            get
            {
                return maSP;
            }

            set
            {
                maSP = value;
            }
        }

        public string TenSP
        {
            get
            {
                return tenSP;
            }

            set
            {
                tenSP = value;
            }
        }

        public string SoLuong
        {
            get
            {
                return soluong;
            }

            set
            {
                soluong = value;
            }
        }

        public string DonGia
        {
            get
            {
                return donGia;
            }

            set
            {
                donGia = value;
            }
        }

        public string ThanhTien
        {
            get
            {
                return thanhTien;
            }

            set
            {
                thanhTien = value;
            }
        }

        private string thanhTien;

        ConnectToDatabase data;
        public ClassBanHang()
        {
            data = new ConnectToDatabase();
        
        }
        public void LoadMaKH(FormBanHang fbh)
        {

            //Load Mã Hóa Đơn
            int dem = 10;
            int kyso = (int)data.Database().RETURN_KYSO("KH");
            int len = kyso.ToString().Length;
            dem = dem - 2 - len;
            string kq = "KH";
            for (int i = 1; i <= dem; i++)
            {
                kq += "0";
            }
            fbh.txtmakhachhang.Text = kq + kyso.ToString();
        }
        public void LoadSoHD(FormBanHang fbh)
        {
                     
            //Load Mã Hóa Đơn
            int dem = 10;
            int kyso = (int)data.Database().RETURN_KYSO("HD");
            int len = kyso.ToString().Length;
            dem = dem - 2 - len;
            string kq = "HD";
            for (int i = 1; i <= dem; i++)
            {
                kq += "0";
            }
            fbh.txtsohoadon.Text = kq + kyso.ToString();
        }
       

        public void LoadMaNV(FormBanHang ftk)
        {
            var dl = data.Database().NHANVIENs.ToList();
            ftk.comboBoxmanhanvien.DataSource = dl;
            ftk.comboBoxmanhanvien.DisplayMember = "MANV";
            ftk.comboBoxmanhanvien.ValueMember = "MANV";
        }

        public void LoadMaSP(FormBanHang fbh)
        {
            var dl = data.Database().SANPHAMs.ToList();
            fbh.comboBoxmasanpham.DataSource = dl;
            fbh.comboBoxmasanpham.DisplayMember = "MASP";
            fbh.comboBoxmasanpham.ValueMember = "MASP";            
        }

        public static bool KTThemSP(string soluong)
        {
            int kt = 0;
            string kq = "Phát Hiện Những Lỗi Sau:\n";
               
            if (soluong == "")
            {
                kt = 1;
                kq += "-Vui lòng chọn ngày lập hóa đơn\n";
            }
            if(kt == 1)
            {
                MessageBox.Show(kq, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        public ClassBanHang ThemSP(FormBanHang fbh)
        {
            ClassBanHang bh = new ClassBanHang();
            bh.MaSP = fbh.comboBoxmasanpham.Text;
            bh.TenSP = fbh.txttensanpham.Text;
            bh.SoLuong = fbh.txtsoluong.Text;
            bh.DonGia = fbh.txtdongia.Text;

            bh.ThanhTien = (int.Parse(fbh.txtsoluong.Text) * int.Parse(fbh.txtdongia.Text)).ToString(); 
        
            return bh;
        }

        public void showcombobox(FormBanHang fbh)
        {
            string tam = fbh.comboBoxmasanpham.SelectedValue.ToString();
            var dl = data.Database().SANPHAMs.SingleOrDefault(a=>a.MASP==tam);
            fbh.txttensanpham.Text = dl.TENSP;
        }

        public void RS(FormBanHang fbh)
        {
            fbh.comboBoxmasanpham.Text = "";
            fbh.txttensanpham.Text = "";
            fbh.txtsoluong.Text = "";
            fbh.txtdongia.Text = "";

        }

      

        public void LuuKhachHang(string makh,string tenkh,string diachi,string sdt)
        {
            var dl = data.Database().KHACHHANGs.SingleOrDefault(n => n.MAKH == makh);
            if (dl == null)
            {
                KHACHHANG kh1 = new KHACHHANG();
                kh1.MAKH = makh;
                kh1.TENKH = tenkh;
                kh1.DCKH = diachi;
                kh1.DTKH = sdt;
                data.Database().KHACHHANGs.InsertOnSubmit(kh1);
                data.Database().SubmitChanges();
                data.Database().TANG_MATUDONG("KH");
            }
            else
            {
               //Không tạo mới
            }
               
                      
        }


        public static bool KTChonRadio(FormBanHang fbh)
        {
            int kt = 0;
            string kq = "Phát hiện các lỗi sau:\n";
            if (fbh.radiobuttonkhachvanlai.Checked == false && fbh.radiokhachthanhvien.Checked == false)
            {
                kt = 1;
                kq += "-Vui lòng chọn loại khách hàng\n";
            }
            if (kt == 1)
            {
                MessageBox.Show(kq, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool KTTHemKhachHang(string makh, string tenkh, string diachi, string dienthoai)
        {
            int kt = 0;
            string kq = "Phát hiện các lỗi sau:\n";
            if (makh == "")
            {
                kt = 1;
            }
            if (tenkh == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập tên khách hàng\n";
            }
            if (diachi == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập địa chỉ khách hàng\n";
            }
            if (dienthoai == "")
            {
                kt = 1;
                kq += "-Vui lòng nhập điện thoại khách hàng\n";
            }
            if (kt == 1)
            {
                MessageBox.Show(kq, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        public void LuuHoaDon(string sohd, string ngaylap, string makh, string manv,string thanhtien, FormBanHang bh)
        {

            var kt = data.Database().HOADONs.SingleOrDefault(n => n.SOHD == sohd);
            if (kt == null)
            {
                HOADON hd = new HOADON();
                if (bh.radiobuttonkhachvanlai.Checked == true)
                {
                    hd.SOHD = sohd;
                    hd.NGAYLAPHD = Convert.ToDateTime(ngaylap.ToString());
                    //hd.MAKH = "NULL";
                    hd.MANV = manv;
                    hd.TONGTG = int.Parse(thanhtien);
                }

                if (bh.radiokhachthanhvien.Checked == true)
                {
                    hd.SOHD = sohd;
                    hd.NGAYLAPHD = Convert.ToDateTime(ngaylap.ToString());
                    hd.MAKH = makh;
                    hd.MANV = manv;
                    hd.TONGTG = int.Parse(thanhtien);
                }
                data.Database().HOADONs.InsertOnSubmit(hd);
                data.Database().SubmitChanges();
                data.Database().TANG_MATUDONG("HD");
            }
        }

        public void LuuCTHD(string sohd,string masp,string soluong,string giaban)
        {
            CTHD cthd = new CTHD();
            
            cthd.SOHD = sohd;
            cthd.MASP = masp;
            cthd.SL = Convert.ToInt32(soluong);
            cthd.GIABAN = int.Parse(giaban);


            data.Database().CTHDs.InsertOnSubmit(cthd);
            data.Database().SubmitChanges();
        }               
       

   }
            
}    
    


