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

namespace QLBanHang
{
    public partial class FormTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        ClassTaiKhoan tk;
        public FormTaiKhoan()
        {
            tk = new ClassTaiKhoan();
            FormTaiKhoan_LoadData();
            InitializeComponent();

        }

        public void FormTaiKhoan_LoadData()
        {
            tk.LoadData(this);
            tk.LoadMaNV(this);
        }

        private void simpleButtonthem_Click(object sender, EventArgs e)
        {
            if (ClassTaiKhoan.KTThemTK(txttaikhoan.Text, txtmatkhau.Text, comboboxmanv.Text) == true)
            {
                tk.ThemTK(txttaikhoan.Text, txtmatkhau.Text, comboboxmanv.Text);
                FormTaiKhoan_LoadData();
            }
        }

        private void simpleButtonxoa_Click(object sender, EventArgs e)
        {
            if(ClassTaiKhoan.KTXoaTK(comboboxmanv.Text) == true)
            {
                tk.XoaTK(comboboxmanv.Text);
                FormTaiKhoan_LoadData();
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txttaikhoan.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TAIKHOAN1").ToString();
            txtmatkhau.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MATKHAU").ToString();
            comboboxmanv.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MANV").ToString();
        }

        private void simpleButtonthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}