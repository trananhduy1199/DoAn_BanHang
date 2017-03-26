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
    public partial class FormChucVu : DevExpress.XtraEditors.XtraForm
    {
        ClassChucVu cv;
        public FormChucVu()
        {
            InitializeComponent();
            cv = new ClassChucVu();
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

        private void butthem_Click(object sender, EventArgs e)
        {
            if (ClassChucVu.KiemTraThemVaSuaCV(txttenchucvu.Text) == true)
            {
                cv.ThemCV(txtmachucvu.Text, txttenchucvu.Text);
                FormChucVu_Load();
                ResetForm();
            }
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            if (ClassChucVu.KiemTraThemVaSuaCV(txttenchucvu.Text) == true)
            {
                cv.SuaCV(txtmachucvu.Text, txttenchucvu.Text);
                FormChucVu_Load();
                ResetForm();
            }
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            if (ClassChucVu.KiemTraXoaCV(txtmachucvu.Text) == true)
            {
                cv.XoaCV(txtmachucvu.Text);
                FormChucVu_Load();
                ResetForm();
            }
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtmachucvu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MACV").ToString();
            txttenchucvu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TENCV").ToString();
        }
    }
}