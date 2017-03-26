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
    public partial class FormKhachHang : DevExpress.XtraEditors.XtraForm
    {
        ClassKhachHang kh;
        public FormKhachHang()
        {
            InitializeComponent();
            kh = new ClassKhachHang();
            LoadData();
            txtmakhachhang.Enabled = false;
            

        }

        public void LoadData()
        {
            kh.LoadData(this);
        }

        public void Reset()
        {
            txtdiachi.Text = "";
            txthoten.Text = "";
            txtmakhachhang.Text = "";
            txtsodienthoai.Text = "";
            radioButnam.Checked = false;
            radioButnu.Checked = false;
        }

        private void barButThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string gt = "";
            if (radioButnam.Checked == true)
            {
                gt = radioButnam.Text;
            }
            if (radioButnu.Checked == true)
            {
                gt = radioButnu.Text;
            }
            if (ClassKhachHang.KiemTraThemKH(txtmakhachhang.Text, txthoten.Text, dateEditngaysinh.Text, gt, txtdiachi.Text, txtsodienthoai.Text) == true)
            {
                kh.ThemKH(txtmakhachhang.Text, txthoten.Text, dateEditngaysinh.Text, gt, txtdiachi.Text, txtsodienthoai.Text);
                kh.LoadData(this);
                Reset();
            }
        }

        private void barButSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string gt = "";
            if (radioButnam.Checked == true)
            {
                gt = radioButnam.Text;
            }
            if (radioButnu.Checked == true)
            {
                gt = radioButnu.Text;
            }
            if (ClassKhachHang.KiemTraSuaKH(txtmakhachhang.Text, txthoten.Text, dateEditngaysinh.Text, gt, txtdiachi.Text, txtsodienthoai.Text) == true)
            {
                kh.SuaKH(txtmakhachhang.Text, txthoten.Text, dateEditngaysinh.Text, gt, txtdiachi.Text, txtsodienthoai.Text);
                kh.LoadData(this);
                Reset();
            }
        }

        private void barButXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ClassKhachHang.KiemTraXoaKH(txtmakhachhang.Text) == true)
            {
                kh.XoaKH(txtmakhachhang.Text);
                kh.LoadData(this);
                Reset();
            }
        }

        private void barButThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtmakhachhang.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAKH").ToString();
            txthoten.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TENKH").ToString();
            dateEditngaysinh.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NGAYSINH").ToString();
            txtdiachi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DCKH").ToString();
            txtsodienthoai.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DTKH").ToString();
        }

        
    }
}