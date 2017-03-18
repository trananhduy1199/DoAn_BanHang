using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanHang.LinqToSQL;


namespace BanHang
{
    public partial class FormKhachHang : Form
    {
        dbQLBanHangDataContext data = new dbQLBanHangDataContext();
        public FormKhachHang()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            txtmakhachhang.Enabled = false;
            var dulieu=data.TABLE_KHACHHANG();
            gridControlkhachhang.DataSource = dulieu;
            LoadMaKhachHang();            
        }

        public void ResetForm()
        {
            LoadMaKhachHang();
            txthoten.Text = "";
            radioButtonnam.Checked = false;
            radioButtonnu.Checked = false;
            dateEditngaysinh.Text = "";
            txtdiachi.Text = "";
            txtsodienthoai.Text = "";
        }

        //Load Mã Khách Hàng
        public void LoadMaKhachHang()
        {
            int dem = 10;
            int so = (int)data.RETURN_KYSO("KH");
            int len_so = so.ToString().Length;
            dem = dem - 2 - len_so;

            string ma = "KH";
            for (int i = 1; i <= dem; i++)
            {
                ma += "0";
            }
            txtmakhachhang.Text = ma + so.ToString(); // Hiện Mã Khách Hàng Tiếp Theo
        }
    
        

        private void butthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }                

        //Sửa
        private void butsua_Click(object sender, EventArgs e)
        {
            var laymakh = txtmakhachhang.Text;            
            KHACHHANG kh = data.KHACHHANGs.SingleOrDefault(k => k.MAKH == laymakh);
            if (kh != null)
            {
                kh.TENKH = txthoten.Text;
                if (radioButtonnam.Checked == true)
                {
                    kh.GIOITINH = radioButtonnam.Text;
                }
                if(radioButtonnu.Checked==true)
                {
                    kh.GIOITINH = radioButtonnu.Text;
                }
                kh.NGAYSINH = Convert.ToDateTime(dateEditngaysinh.Text);
                kh.DCKH = txtdiachi.Text;
                kh.DTKH = txtsodienthoai.Text;
                data.SubmitChanges();
                ResetForm();
                LoadData();
            }
        }

        //Thêm
        private void butthem_Click(object sender, EventArgs e)
        {
            //Lấy giá trị giới tính từ radiobutton
            string gt = "";
            if (radioButtonnam.Checked == true)
            {
                gt = radioButtonnam.Text;
            }
            if (radioButtonnu.Checked == true)
            { 
                gt=radioButtonnu.Text;
            }

            //Khởi tạo mới đối tượng Khách Hàng & Tiến hành thêm mới
            KHACHHANG kh = new KHACHHANG();
            kh.MAKH = txtmakhachhang.Text;
            kh.TENKH = txthoten.Text;
            kh.GIOITINH = gt;
            kh.NGAYSINH = Convert.ToDateTime(dateEditngaysinh.Text);
            kh.DCKH = txtdiachi.Text;
            kh.DTKH = txtsodienthoai.Text;

            //Lưu vào bảng KHÁCH HÀNG
            data.KHACHHANGs.InsertOnSubmit(kh);
            data.SubmitChanges();

            //Tăng ký số trong bảng CẤP MÃ TỰ ĐỘNG
            data.TANG_MATUDONG("KH");
            LoadData();

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtmakhachhang.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAKH").ToString();
            txthoten.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TENKH").ToString();
            dateEditngaysinh.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NGAYSINH").ToString();
            txtdiachi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DCKH").ToString();
            txtsodienthoai.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DTKH").ToString();

            string gt=gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GIOITINH").ToString();
            //Giới Tính
            if (gt == "Nam")
            {
                radioButtonnam.Checked = true;
            }
            if (gt == "Nữ")
            {
                radioButtonnu.Checked = true;
            }
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            var laymakh = txtmakhachhang.Text;
            KHACHHANG kh = data.KHACHHANGs.SingleOrDefault(k=>k.MAKH==laymakh);
            if (kh != null)
            {
                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có chắc muốn xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (thongbao == DialogResult.Yes)
                {
                    data.KHACHHANGs.DeleteOnSubmit(kh);
                    data.SubmitChanges();
                    ResetForm();
                    LoadData();
                }                
            }
        }        
        
    }
}
