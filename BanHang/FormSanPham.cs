using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHang
{
    public partial class FormSanPham : Form
    {
        SanPham sp; //Khai báo
        public FormSanPham()
        {
            sp = new SanPham();  // Khởi tạo            
            InitializeComponent();
            FormSP_Load();
            txtmasanpham.Enabled = false;
        }

        public void FormSP_Load()
        {
            sp.LoadData(this);
        }

        //Thêm sản phẩm
        private void butthem_Click(object sender, EventArgs e)
        {

            if (SanPham.KiemTraThemSP(txtmasanpham.Text,txttensanpham.Text, txtquycach.Text, txtgiaban.Text, txtsoluongton.Text) == true)
            {
                sp.ThemSP(txtmasanpham.Text, txttensanpham.Text, txtquycach.Text, int.Parse(txtgiaban.Text.ToString()), int.Parse(txtsoluongton.Text.ToString()));
                sp.LoadData(this);
                ResetForm();
            }            
        }

        //Sửa sản phẩm
        private void butsua_Click(object sender, EventArgs e)
        {
            if (SanPham.KiemTraSuaSP(txtmasanpham.Text,txttensanpham.Text, txtquycach.Text, txtgiaban.Text, txtsoluongton.Text) == true)
            {
                sp.SuaSP(txtmasanpham.Text, txttensanpham.Text, txtquycach.Text, int.Parse(txtgiaban.Text.ToString()), int.Parse(txtsoluongton.Text.ToString()));
                sp.LoadData(this);
                ResetForm();
            }            
        }


        //Click vào 1 row load dữ liệu lên các trường trên form
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {            
            txtmasanpham.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MASP").ToString();
            txttensanpham.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TENSP").ToString();
            txtquycach.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "QUYCACH").ToString();
            txtgiaban.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GIABAN").ToString();
            txtsoluongton.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SLTON").ToString();
        }
        
        //Xóa sản phẩm
        private void butxoa_Click(object sender, EventArgs e)
        {
            if (SanPham.KTXoaSP(txtmasanpham.Text) == true)
            {
                sp.XoaSP(txtmasanpham.Text);
                sp.LoadData(this);
                ResetForm();
            }            
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ResetForm()
        {
            txttensanpham.Text = "";
            txtquycach.Text = "";
            txtsoluongton.Text = "";
            txtgiaban.Text = "";
        }
    }
}
