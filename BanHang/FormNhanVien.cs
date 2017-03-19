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
using System.IO;

namespace BanHang
{
    public partial class FormNhanVien : Form
    {
        NhanVien nv;
        public FormNhanVien()
        {
            nv = new NhanVien();
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

        private void butthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            string gt="";
            if(radioButtonnam.Checked==true)
            {
                gt=radioButtonnam.Text;
            }
            if(radioButtonnu.Checked==true)
            {
                gt=radioButtonnu.Text;
            }
            comboBoxchucvu.ValueMember = "MACV";
            string machucvu_tam = comboBoxchucvu.SelectedValue.ToString();
            if (NhanVien.KiemTraThemNV(txtmanhanvien.Text,txttennhanvien.Text,dateEditngaysinh.Text,gt,txtchoohientai.Text,txtsodienthoai.Text,txtsocmnd.Text,txtnoicap.Text,txthokhau.Text,dateEditngaycap.Text,machucvu_tam,duyetanh) == true)
            {
                nv.ThemNV(txtmanhanvien.Text, txttennhanvien.Text, dateEditngaysinh.Text, gt, txtchoohientai.Text, txtsodienthoai.Text, txtsocmnd.Text, txtnoicap.Text, txthokhau.Text, dateEditngaycap.Text, machucvu_tam,duyetanh);
                FormNV_LoadData();
                ResetForm();
            }
        }

        string duyetanh = "";
        OpenFileDialog ofd = new OpenFileDialog();
        private void butduyetanh_Click(object sender, EventArgs e)
        {
            ofd.Title = "Open Image";
            ofd.InitialDirectory = @"C:\";
            ofd.Filter = "Image|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string duyetanh_tam = "";
                duyetanh_tam = openFileDialog1.FileName;
                int len_duyetanh=duyetanh_tam.Length;
                if (len_duyetanh > 100)
                {
                    MessageBox.Show("Đường dẫn quá dài (Hơn 100 ký tự)\n Bạn vui lòng chỉnh sửa lại đường dẫn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {                    
                    duyetanh = openFileDialog1.FileName;
                    pictureEdithinhanh.Image = Image.FromFile(ofd.FileName);
                    butduyetanh.Enabled = false;
                }                
            }
        }

        private void butxoaanh_Click(object sender, EventArgs e)
        {
            duyetanh = "";
            butduyetanh.Enabled = true;
            pictureEdithinhanh.Image = null;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtmanhanvien.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MANV").ToString();
            txttennhanvien.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TENNV").ToString();
            dateEditngaysinh.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NGAYSINH").ToString();            
            txtchoohientai.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DCNVHIENTAI").ToString();
            txtsodienthoai.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DTNV").ToString();
            txtsocmnd.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CMND").ToString();
            txtnoicap.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NOICAPCMND").ToString();
            dateEditngaycap.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NGAYCAPCMND").ToString();
            txthokhau.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HOKHAU").ToString();
            
            //gioitinh
            string gt=gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GIOITINH").ToString();
            if (gt == "Nam")
            {
                radioButtonnam.Checked = true;
            }
            if (gt == "Nữ")
            {
                radioButtonnu.Checked = true;
            }

            //chucvu
            nv.ChonChucVu(this);

            //hinhanh
            //var duyetanh_tam = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HINHANH").ToString();
            //pictureEdithinhanh.Image = Image.FromFile(duyetanh_tam);
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
            if (NhanVien.KiemTraSuaNV(txtmanhanvien.Text, txttennhanvien.Text, dateEditngaysinh.Text, gt, txtchoohientai.Text, txtsodienthoai.Text, txtsocmnd.Text, txtnoicap.Text, txthokhau.Text, dateEditngaycap.Text, machucvu_tam, duyetanh) == true)
            {
                nv.SuaNV(txtmanhanvien.Text, txttennhanvien.Text, dateEditngaysinh.Text, gt, txtchoohientai.Text, txtsodienthoai.Text, txtsocmnd.Text, txtnoicap.Text, txthokhau.Text, dateEditngaycap.Text, machucvu_tam, duyetanh);
                FormNV_LoadData();
                ResetForm();
            }
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            if (NhanVien.KiemTraXoaNV(txtmanhanvien.Text) == true)
            {
                nv.XoaNV(txtmanhanvien.Text);
                FormNV_LoadData();
                ResetForm();
            }
        }

        public void ResetForm()
        {             
            txttennhanvien.Text="";
            dateEditngaysinh.Text="";
            if (radioButtonnam.Checked == true)
            {
                radioButtonnam.Checked = false;
            }
            if (radioButtonnu.Checked == true)
            {
                radioButtonnu.Checked = false;
            }
            txtchoohientai.Text="";
            txtsodienthoai.Text="";
            txtsocmnd.Text="";
            txtnoicap.Text="";
            txthokhau.Text="";
            dateEditngaycap.Text="";
            comboBoxchucvu.Text="";
        }       

    }
}
