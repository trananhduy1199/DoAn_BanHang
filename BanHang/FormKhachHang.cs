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
        KhachHang kh;
        public FormKhachHang()
        {
            kh = new KhachHang();
            InitializeComponent();
            FormKhachHang_LoadData();
            txtmakhachhang.Enabled = false;
        }

        public void FormKhachHang_LoadData()
        {
            kh.LoadData(this);
        }        

        private void butthoat_Click(object sender, EventArgs e)
        {
            this.Close();
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

        //Thêm khách hàng
        private void butthem_Click(object sender, EventArgs e)
        {
            string gt = "";
            if (radioButtonnam.Checked == true)
            {
                gt = radioButtonnam.Text;
            }
            if (radioButtonnu.Checked == true)
            {
                gt = radioButtonnu.Text;
            }
            if (KhachHang.KiemTraThemKH(txtmakhachhang.Text, txthoten.Text, gt, dateEditngaysinh.Text, txtdiachi.Text, txtsodienthoai.Text)==true)
            {
                kh.ThemKH(txtmakhachhang.Text, txthoten.Text, gt, dateEditngaysinh.Text, txtdiachi.Text, txtsodienthoai.Text);
                kh.LoadData(this);
                ResetForm();
            }
        }

        //ResetForm
        public void ResetForm()
        {
            txthoten.Text = "";
            radioButtonnam.Checked = false;
            radioButtonnu.Checked = false;
            dateEditngaysinh.Text = "";
            txtdiachi.Text = "";
            txtsodienthoai.Text = "";
        }

        //Sửa khách hàng
        private void butsua_Click(object sender, EventArgs e)
        {
            string gt = "";
            if (radioButtonnam.Checked == true)
            {
                gt = radioButtonnam.Text;
            }
            if (radioButtonnu.Checked == true)
            {
                gt = radioButtonnu.Text;
            }
            if (KhachHang.KiemTraSuaKH(txtmakhachhang.Text, txthoten.Text, gt, dateEditngaysinh.Text.ToString(), txtdiachi.Text, txtsodienthoai.Text) == true)
            {
                kh.SuaKH(txtmakhachhang.Text, txthoten.Text, gt,dateEditngaysinh.Text.ToString(), txtdiachi.Text, txtsodienthoai.Text);
                kh.LoadData(this);
                ResetForm();
            }
        }

        //Xóa khách hàng
        private void butxoa_Click(object sender, EventArgs e)
        {
            if (KhachHang.KiemTraXoaKH(txtmakhachhang.Text) == true)
            {
                kh.XoaKH(txtmakhachhang.Text);
                kh.LoadData(this);
                ResetForm();
            }
        }
        
    }
}
