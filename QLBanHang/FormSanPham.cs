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
    public partial class FormSanPham : DevExpress.XtraEditors.XtraForm
    {
        ClassSanPham sp;
        public FormSanPham()
        {
            sp = new ClassSanPham();
            InitializeComponent();
            LoadData();
            txtmasanpham.Enabled = false;          
        }
        public void Reset()
        {
            txtgiamua.Text = "";
            txtgiaban.Text = "";
            txtmasanpham.Text = "";
            txtsoluongton.Text = "";
            txttensanpham.Text = "";
        }
        public void LoadData()
        {
            sp.LoadData(this);
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            if (ClassSanPham.KTThemSP(txttensanpham.Text, txtgiaban.Text,txtgiamua.Text,txtsoluongton.Text ) == true)
            {
                sp.ThemSP(txtmasanpham.Text,txttensanpham.Text,txtgiamua.Text, txtgiaban.Text, txtsoluongton.Text);
                LoadData();
                Reset();
            }
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            if (ClassSanPham.KTSuaSP(txtmasanpham.Text,txttensanpham.Text, txtgiaban.Text, txtgiamua.Text, txtsoluongton.Text) == true) 
            {
                sp.SuaSP(txtmasanpham.Text, txttensanpham.Text, txtgiamua.Text, txtgiaban.Text, txtsoluongton.Text);
                LoadData();
                Reset();
            }
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            if (ClassSanPham.KTXoaSP(txtmasanpham.Text) == true)
            {
                sp.XoaSP(txtmasanpham.Text);
                LoadData();
                Reset();
            }
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtmasanpham.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Mã Sản Phẩm").ToString();
            txttensanpham.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tên Sản Phẩm").ToString();
            txtgiamua.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Gía Mua").ToString();
            txtgiaban.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Giá Bán").ToString();
            txtsoluongton.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Số Lượng Tồn").ToString();
         
        }

        private void gridControlSanPham_Click(object sender, EventArgs e)
        {

        }
    }
}