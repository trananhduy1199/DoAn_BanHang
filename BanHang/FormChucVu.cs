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
    public partial class FormChucVu : Form
    {
        ChucVu cv;
        public FormChucVu()
        {
            cv = new ChucVu();
            InitializeComponent();
            FormChucVu_Load();
            txtmachucvu.Enabled = false;            
        }

        //Load Form
        public void FormChucVu_Load()
        {
            cv.LoadData(this);
        }

        //Reset Form
        public void ResetForm()
        {            
            txttenchucvu.Text = "";
        }
        //Thêm Chức Vụ
        private void butthem_Click(object sender, EventArgs e)
        {
            if (ChucVu.KiemTraThemVaSuaCV(txttenchucvu.Text)==true)
            {
                cv.ThemCV(txtmachucvu.Text,txttenchucvu.Text);
                FormChucVu_Load();
                ResetForm();
            }
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            if (ChucVu.KiemTraThemVaSuaCV(txttenchucvu.Text) == true)
            {
                cv.SuaCV(txtmachucvu.Text,txttenchucvu.Text);
                FormChucVu_Load();
                ResetForm();
            }            
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            if (ChucVu.KiemTraXoaCV(txtmachucvu.Text) == true)
            {
                cv.XoaCV(txtmachucvu.Text);
                FormChucVu_Load();
                ResetForm();
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtmachucvu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MACV").ToString();            
            txttenchucvu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TENCV").ToString();
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
