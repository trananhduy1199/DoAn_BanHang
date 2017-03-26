using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using BanHang.LinqToSQL;
=======
>>>>>>> origin/master

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

<<<<<<< HEAD
        private void butthem_Click(object sender, EventArgs e)
        {
            if (TaiKhoan.KTThemTK(txttaikhoan.Text, txtmatkhau.Text, comboboxmanv.Text) == true)
            {
                tk.ThemTK(txttaikhoan.Text, txtmatkhau.Text, comboboxmanv.Text);
=======
        private void butthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            if (TaiKhoan.KTThemTK(txttaikhoan.Text,txtmatkhau.Text,comboBoxEditmanv.Text) == true)
            {
                tk.ThemTK(txttaikhoan.Text, txtmatkhau.Text, comboBoxEditmanv.Text);
>>>>>>> origin/master
                FormTaiKhoan_LoadData();
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txttaikhoan.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TAIKHOAN1").ToString();
            txtmatkhau.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MATKHAU").ToString();
<<<<<<< HEAD
            comboboxmanv.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MANV").ToString();
=======
            comboBoxEditmanv.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MANV").ToString();
>>>>>>> origin/master
        }

        private void simpleButtonsua_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
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
        
=======
            if (TaiKhoan.KTSuaTK(txttaikhoan.Text, txtmatkhau.Text, comboBoxEditmanv.Text) == true)
            {
                tk.SuaTK(txttaikhoan.Text, txtmatkhau.Text, comboBoxEditmanv.Text);
                FormTaiKhoan_LoadData();
            }
        }
>>>>>>> origin/master
    }
}
