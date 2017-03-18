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
        dbQLBanHangDataContext data = new dbQLBanHangDataContext();


        public FormNhanVien()
        {
            InitializeComponent();
            txtmanhanvien.Enabled = false;
            LoadData();
        }        

        public void LoadData()
        {
            var dl=data.TABLE_NHANVIEN();
            gridControlnhanvien.DataSource = dl;
            LoadMaNhanVien();
            LoadChucVu();

        }

        public void LoadMaNhanVien()
        {
            int dem = 10;
            int kyso = int.Parse(data.RETURN_KYSO("NV").ToString());
            int len_so = kyso.ToString().Length;
            dem = dem - 2 - kyso;
            string kq = "NV";
            for(int i=1;i<=dem;i++)
            {
                kq+="0";
            }
            txtmanhanvien.Text = kq + kyso.ToString();
        }

        public void LoadChucVu()
        {
            var cv = data.CHUCVUs.ToList();
            comboBoxchucvu.DataSource = cv;
            comboBoxchucvu.DisplayMember = "TENCV";
            comboBoxchucvu.ValueMember = "MACV";
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            NHANVIEN  nv = new NHANVIEN();
            nv.MANV = txtmanhanvien.Text;
            nv.TENNV = txttennhanvien.Text;
            nv.NGAYSINH = Convert.ToDateTime(dateEditngaysinh.ToString());
            
            if (radioButtonnam.Checked == true)
            {
                nv.GIOITINH = radioButtonnam.Text;
            }
            if (radioButtonnu.Checked == true)
            {
                nv.GIOITINH = radioButtonnu.Text;
            }

            nv.DCNVHIENTAI = txtchoohientai.Text;
            nv.DTNV = txtsodienthoai.Text;
            nv.CMND = txtsocmnd.Text;
            nv.NOICAPCMND = txtnoicap.Text;
            nv.NGAYCAPCMND = Convert.ToDateTime(dateEditngaycap.Text.ToString());
            nv.HOKHAU = txthokhau.Text;
            nv.MACV = comboBoxchucvu.SelectedValue.ToString();
            nv.HINHANH = duyetanh;
            data.NHANVIENs.InsertOnSubmit(nv);
            data.SubmitChanges();

            data.TANG_MATUDONG("NV");
            LoadData();
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
                duyetanh = openFileDialog1.FileName;
                pictureEdithinhanh.Image = Image.FromFile(ofd.FileName);
                butduyetanh.Enabled = false;
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
            dateEditngaysinh.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GIOITINH").ToString();
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
            var chucvutam=gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MACV").ToString();
            var cv = data.CHUCVUs.SingleOrDefault(c=>c.MACV==chucvutam);
            comboBoxchucvu.Text = cv.TENCV;

            //hinhanh
            duyetanh = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HINHANH").ToString();
            pictureEdithinhanh.Image = Image.FromFile(duyetanh);
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = data.NHANVIENs.SingleOrDefault(n=>n.MANV==txtmanhanvien.Text);
            if (nv != null)
            {
                nv.TENNV = txttennhanvien.Text;
                nv.NGAYSINH = Convert.ToDateTime(dateEditngaysinh.ToString());

                if (radioButtonnam.Checked)
                {
                    nv.GIOITINH = radioButtonnam.Text;
                }
                if (radioButtonnu.Checked == true)
                {
                    nv.GIOITINH = radioButtonnu.Text;
                }

                nv.DCNVHIENTAI = txtchoohientai.Text;
                nv.DTNV = txtsodienthoai.Text;
                nv.CMND = txtsocmnd.Text;
                nv.NOICAPCMND = txtnoicap.Text;
                nv.NGAYCAPCMND = Convert.ToDateTime(dateEditngaycap.Text.ToString());
                nv.HOKHAU = txthokhau.Text;
                nv.MACV = comboBoxchucvu.SelectedValue.ToString();
                nv.HINHANH = duyetanh;                
                data.SubmitChanges();
                data.TANG_MATUDONG("NV");
                LoadData();
            }
                                    
            
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = data.NHANVIENs.SingleOrDefault(n=>n.MANV==txtmanhanvien.Text);
            DialogResult thongbao;            
            if (nv != null)
            {
                thongbao = (MessageBox.Show("Bạn có chắc muốn xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (thongbao == DialogResult.Yes)
                {
                    data.NHANVIENs.DeleteOnSubmit(nv);
                    data.SubmitChanges();
                    LoadData();
                }
            }            
        }
        
    }
}
