using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBanHang.LinQToSQL;

namespace QLBanHang
{
    public partial class FormBanHang : DevExpress.XtraEditors.XtraForm
    {
        List<ClassBanHang> bh = new List<ClassBanHang>();      
        ClassBanHang banhang;
        ConnectToDatabase data;
        public FormBanHang()
        {
            data = new ConnectToDatabase();
            banhang = new ClassBanHang();
            InitializeComponent();
            LoadData();
            txtmakhachhang.Enabled = false;
            txtthanhtien.Enabled = false;
            txtsohoadon.Enabled = false;
            dateEditngaylap.Enabled = false;
            dateEditngaylap.Text = DateTime.Now.ToString();
            txtdongia.Enabled = false;
            txttensanpham.Enabled = false;
            txtmakhachhang.Enabled = false;
            comboBoxmanhanvien.Enabled = false;



        }

        public void LoadData()
        {
            banhang.LoadMaSP(this);
            banhang.LoadSoHD(this);
            banhang.LoadMaKH(this);
            banhang.LoadMaNV(this);
        }
        
        private void simpleButtonthem_Click(object sender, EventArgs e)
        {
            if(ClassBanHang.KTThemSP(txtsoluong.Text)== true)
            {
                //Tìm sản phẩm trong list
                var tam = bh.SingleOrDefault(n => n.MaSP == comboBoxmasanpham.Text);
                //Nếu sản phẩm có rồi thì cộng dồn số lượng
                if(tam != null)
                {
                    tam.SoLuong = (int.Parse(tam.SoLuong) + int.Parse(txtsoluong.Text)).ToString();
                }
                //Nếu sản phẩm chưa có thì lưu vào danh sách
                else
                {
                    bh.Add(banhang.ThemSP(this));
                }
                
                //update lại list
                var sp = bh.ToList();
                //Show list lên grid
                gridControlsanpham.DataSource = sp;
                //ResetForm
                banhang.RS(this);
               
            }
            int tong = 0;
            foreach (var item in bh)
            {
                tong += int.Parse(item.SoLuong) * int.Parse(item.DonGia);
            }
            txtthanhtien.Text = tong.ToString() ;

        }

        private void simpleButtonsearch_Click(object sender, EventArgs e)
        {
            var dt = txtsearchsdt.Text;
            KHACHHANG kk = data.Database().KHACHHANGs.SingleOrDefault(n => n.DTKH == dt);
            if(kk != null)
            {                
                 txtmakhachhang.Text = kk.MAKH;
                 txttenkhachhang.Text = kk.TENKH;
                 txtdiachi.Text = kk.DCKH;
                 txtsodienthoai.Text = kk.DTKH;
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin khách hàng ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radiobuttonkhachvanlai_CheckedChanged(object sender, EventArgs e)
        {
            if(radiobuttonkhachvanlai.Checked == true)
                if(radiokhachthanhvien.Checked == false)
                    {
                        txtmakhachhang.Enabled = false;
                        txttenkhachhang.Enabled = false;
                        txtdiachi.Enabled = false;
                        txtsodienthoai.Enabled = false;
                        txtsearchsdt.Enabled = false;

                    }
        }

        private void radiokhachthanhvien_CheckedChanged(object sender, EventArgs e)
        {
              if(radiokhachthanhvien.Checked == true)
                if(radiobuttonkhachvanlai.Checked == false)          
                {
                    txtmakhachhang.Enabled = true;
                    txttenkhachhang.Enabled = true;
                    txtdiachi.Enabled = true;
                    txtsodienthoai.Enabled = true;
                    txtsearchsdt.Enabled = true;

                }
        }

        private void simpleButtondongy_Click(object sender, EventArgs e)
        {
            
            var chucvutam = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SoLuong").ToString();
            if (ClassBanHang.KTChonRadio(this) == true)
            {
                
                //Khách vãn lai
                if (radiobuttonkhachvanlai.Checked == true)
                {
                    banhang.LuuHoaDon(txtsohoadon.Text, dateEditngaylap.Text, txtmakhachhang.Text, comboBoxmanhanvien.Text,txtthanhtien.Text, this);
                    foreach (var item in bh)
                    {
                        banhang.LuuCTHD(txtsohoadon.Text, item.MaSP, item.SoLuong, item.DonGia);
                    }
                }

                // Khách thành viên                    
                if (radiokhachthanhvien.Checked == true)
                {
                    if (ClassBanHang.KTTHemKhachHang(txtmakhachhang.Text, txttenkhachhang.Text, txtdiachi.Text, txtsodienthoai.Text) == true)
                    {
                        banhang.LuuKhachHang(txtmakhachhang.Text, txttenkhachhang.Text, txtdiachi.Text, txtsodienthoai.Text);
                        banhang.LuuHoaDon(txtsohoadon.Text, dateEditngaylap.Text, txtmakhachhang.Text, comboBoxmanhanvien.Text,txtthanhtien.Text,this);
                        foreach(var item in bh)
                        {
                            banhang.LuuCTHD(txtsohoadon.Text, item.MaSP, item.SoLuong,item.DonGia);
                        }
                       
                    }
                }                
            }            
            
        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {

        }

       
        string masp;
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            masp = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaSP").ToString();
          
           

        }

        private void simpleButtonxoa_Click(object sender, EventArgs e)
        {


            foreach(var item in bh.ToList())
            {
                if (item.MaSP == masp) 
                {
                    bh.Remove(item);


                }
            }
            var sp = bh.ToList();
            //Show list lên grid
            gridControlsanpham.DataSource = sp;
        }
        

        private void comboBoxmasanpham_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // MessageBox.Show(comboBoxmasanpham.Text,"Thong bao",MessageBoxButtons.OK,MessageBoxIcon.Information);
            var sql = data.Database().SANPHAMs.SingleOrDefault(a => a.MASP == comboBoxmasanpham.Text);
            if (sql != null)
            {
                txttensanpham.Text = sql.TENSP;
                txtdongia.Text = sql.GIABAN.ToString();
            }
        }
    }
}