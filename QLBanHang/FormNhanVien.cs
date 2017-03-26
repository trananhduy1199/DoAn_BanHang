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
using System.IO;

namespace QLBanHang
{
    public partial class FormNhanVien : DevExpress.XtraEditors.XtraForm
    {
        ClassNhanVien nv;
        public FormNhanVien()
        {           
            nv = new ClassNhanVien();
            InitializeComponent();
            txtmanhanvien.Enabled = false;
            FormNV_LoadData();
        }
        public void FormNV_LoadData()
        {
            nv.LoadData(this);
            FormNV_LoadChucVu();
        }

        public void FormNV_LoadChucVu()
        {
            nv.LoadChucVu(this);
        }
        public void ResetForm()
        {
            txthoten.Text = "";
            dateEditngaysinh.Text = "";
            if (radioButtonnam.Checked == true)
            {
                radioButtonnam.Checked = false;
            }
            if (radioButtonnu.Checked == true)
            {
                radioButtonnu.Checked = false;
            }
            txtchoohientai.Text = "";
            txtsodienthoai.Text = "";
            txtcmnd.Text = "";
            txtnoicap.Text = "";
            txthokhau.Text = "";
            dateEditngaycap.Text = "";
            comboBoxchucvu.Text = "";
        }




        private void FormNhanVien_Load(object sender, EventArgs e)
        {

        }

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
            comboBoxchucvu.ValueMember = "MACV";
            string machucvu_tam = comboBoxchucvu.SelectedValue.ToString();
            if (ClassNhanVien.KiemTraThemNV(txtmanhanvien.Text, txthoten.Text, dateEditngaysinh.Text, gt, txtchoohientai.Text, txtsodienthoai.Text, txtcmnd.Text, txtnoicap.Text, txthokhau.Text, dateEditngaycap.Text, machucvu_tam, duyetanh) == true)
            {
                nv.ThemNV(txtmanhanvien.Text, txthoten.Text, dateEditngaysinh.Text, gt, txtchoohientai.Text, txtsodienthoai.Text, txtcmnd.Text, txtnoicap.Text, txthokhau.Text, dateEditngaycap.Text, machucvu_tam, duyetanh);
                FormNV_LoadData();
                ResetForm();
            }
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            comboBoxchucvu.ValueMember = "MACV";
            string machucvu_tam = comboBoxchucvu.SelectedValue.ToString();
            string gt = "";
            if (radioButtonnam.Checked == true)
            {
                gt = radioButtonnam.Text;
            }
            if (radioButtonnu.Checked == true)
            {
                gt = radioButtonnu.Text;
            }
            if (ClassNhanVien.KiemTraSuaNV(txtmanhanvien.Text, txthoten.Text, dateEditngaysinh.Text, gt, txtchoohientai.Text, txtsodienthoai.Text, txtcmnd.Text, txtnoicap.Text, txthokhau.Text, dateEditngaycap.Text, machucvu_tam, ofd.FileName) == true)
            {
                nv.SuaNV(txtmanhanvien.Text, txthoten.Text, dateEditngaysinh.Text, gt, txtchoohientai.Text, txtsodienthoai.Text, txtcmnd.Text, txtnoicap.Text, txthokhau.Text, dateEditngaycap.Text, machucvu_tam, ofd.FileName);
                FormNV_LoadData();
                ResetForm();
            }
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            if (ClassNhanVien.KiemTraXoaNV(txtmanhanvien.Text) == true)
            {
                nv.XoaNV(txtmanhanvien.Text);
                FormNV_LoadData();
                ResetForm();
            }
        }

        private void butthoat_Click(object sender, EventArgs e)
        {

        }
        string duyetanh = "";
        OpenFileDialog ofd = new OpenFileDialog();
          private void simpleButton6_Click(object sender, EventArgs e)
        {
            ofd.Title = "Open Image";
            ofd.InitialDirectory = @"C:\";
            ofd.Filter = "Image|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string duyetanh_tam = "";
                duyetanh_tam = ofd.FileName;
                int len_duyetanh = duyetanh_tam.Length;
                if (len_duyetanh > 100)
                {
                    MessageBox.Show("Đường dẫn quá dài (Hơn 100 ký tự)\n Bạn vui lòng chỉnh sửa lại đường dẫn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    duyetanh = ofd.FileName;
                    pictureEdithinhanh.Image = Image.FromFile(ofd.FileName);
                    butduyetanh.Enabled = false;
                }
            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
           duyetanh = "";
           butduyetanh.Enabled = true;
           pictureEdithinhanh.Image = null;
        }
        

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtmanhanvien.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MANV").ToString();
            txthoten.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TENNV").ToString();
            dateEditngaysinh.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NGAYSINH").ToString();
            txtchoohientai.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DCNVHIENTAI").ToString();
            txtsodienthoai.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DTNV").ToString();
            txtcmnd.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CMND").ToString();
            txtnoicap.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NOICAPCMND").ToString();
            dateEditngaycap.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NGAYCAPCMND").ToString();
            txthokhau.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HOKHAU").ToString();
        }

        
    }
}