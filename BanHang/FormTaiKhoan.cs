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
    public partial class FormTaiKhoan : Form
    {
        TaiKhoan tk;
        public FormTaiKhoan()
        {
            tk = new TaiKhoan();
            InitializeComponent();
            FormTaiKhoan_LoadData();
        }

        public void FormTaiKhoan_LoadData()
        {
            tk.LoadData(this);
            tk.LoadMaNV(this);
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            if (TaiKhoan.KTThemTK(txttaikhoan.Text, txtmatkhau.Text, comboboxmanv.Text) == true)
            {
                tk.ThemTK(txttaikhoan.Text, txtmatkhau.Text, comboboxmanv.Text);
                FormTaiKhoan_LoadData();
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txttaikhoan.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TAIKHOAN1").ToString();
            txtmatkhau.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MATKHAU").ToString();
            comboboxmanv.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MANV").ToString();
        }

        private void simpleButtonsua_Click(object sender, EventArgs e)
        {
            if (TaiKhoan.KTSuaTK(txttaikhoan.Text, txtmatkhau.Text, comboboxmanv.Text) == true)
            {
                tk.SuaTK(txttaikhoan.Text, txtmatkhau.Text, comboboxmanv.Text);
                FormTaiKhoan_LoadData();
            }
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
