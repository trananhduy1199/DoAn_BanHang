using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanHang.LinQToSQL;
namespace QLBanHang
{

   
    class ClassMuaHang
    {
        private string maSP;
        

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

        public string GiaMua
        {
            get
            {
                return giaMua;
            }

            set
            {
                giaMua = value;
            }
        }

       

        public string GiaBan
        {
            get
            {
                return giaBan;
            }

            set
            {
                giaBan = value;
            }
        }

        public string SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
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

        private string tenSP;

        private string giaMua;

        
        private string giaBan;

        private string soLuong;

        private string thanhTien;

        ConnectToDatabase data;

        public ClassMuaHang()
        {
            data = new ConnectToDatabase();

        }
        public void LoadMaPN(FormMuaHang fbh)
        {

            //Load Mã Phiếu Nhập
            int dem = 10;
            int kyso = (int)data.Database().RETURN_KYSO("PN");
            int len = kyso.ToString().Length;
            dem = dem - 2 - len;
            string kq = "PN";
            for (int i = 1; i <= dem; i++)
            {
                kq += "0";
            }
            fbh.txtsophieunhap.Text = kq + kyso.ToString();
        }

        

        public void LoadMaSP(FormMuaHang fbh)
        {
            var dl = data.Database().SANPHAMs.ToList();
            fbh.comboBoxmasanpham.DataSource = dl;
            fbh.comboBoxmasanpham.DisplayMember = "MASP";
            fbh.comboBoxmasanpham.ValueMember = "MASP";
        }
        public void LoadMaNCC(FormMuaHang fbh)
        {
            var dl = data.Database().NCCs.ToList();
            fbh.comboboxmancc.DataSource = dl;
            fbh.comboboxmancc.DisplayMember = "MANCC";
            fbh.comboboxmancc.ValueMember = "MANCC";
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
        public ClassMuaHang ThemSP(FormMuaHang fbh)
        {
            ClassMuaHang bh = new ClassMuaHang();
            bh.MaSP = fbh.comboBoxmasanpham.Text;
            bh.TenSP = fbh.txtsanpham.Text;         
            bh.SoLuong = fbh.txtsoluong.Text;
            bh.GiaMua = fbh.txtdongia.Text;

            bh.ThanhTien = (int.Parse(fbh.txtsoluong.Text) * int.Parse(fbh.txtdongia.Text)).ToString();

            return bh;
        }

        public void RS(FormMuaHang fbh)
        {
            fbh.comboBoxmasanpham.Text = "";           
            fbh.txtsoluong.Text = "";
            fbh.txtdongia.Text = "";

        }

        

        public void LuuPhieuNhap(string sopn, string ngaylap, string mancc, string manv, string thanhtien, FormMuaHang bh)
        {

            var kt = data.Database().PHIEUNHAPs.SingleOrDefault(n => n.PHIEUNHAP1 == sopn);
            if (kt == null)
            {
                PHIEUNHAP pn = new PHIEUNHAP();
                pn.PHIEUNHAP1 = sopn;
                pn.NGAYLAPPN = Convert.ToDateTime(ngaylap.ToString());
                pn.MANCC = mancc;
                pn.MANV = manv;
                pn.TONGTG = int.Parse(thanhtien);

                data.Database().PHIEUNHAPs.InsertOnSubmit(pn);
                data.Database().SubmitChanges();
                data.Database().TANG_MATUDONG("PN");


            }
              
            
        }

        public void LuuCTPN(string sopn, string masp, string soluong, string giamua)
        {
            CTPN ctpn = new CTPN();
            ctpn.PHIEUNHAP = sopn;
            ctpn.MASP = masp;
            ctpn.SL = int.Parse(soluong);
            ctpn.GIAMUA = int.Parse(giamua);
            

            data.Database().CTPNs.InsertOnSubmit(ctpn);
            data.Database().SubmitChanges();
           
        }
        public static bool KTTHemNCC(string mancc, string tenncc, string diachi, string dienthoai)
        {
            int kt = 0;
            string kq = "Phát hiện các lỗi sau:\n";
            if (mancc == "")
            {
                kt = 1;
            }
            if (tenncc == "")
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
    }


}
