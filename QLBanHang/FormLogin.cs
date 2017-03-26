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
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        DBQLBanHangDataContext data = new DBQLBanHangDataContext();
        public FormLogin()
        {
            InitializeComponent();
        }
        //Truyền dữ liệu từ form này sang form kia(truyền chuỗi )
        public delegate void TruyenDuLieu(string s);
        public TruyenDuLieu TruyenVeMain;


        private void butdangnhap_Click(object sender, EventArgs e)
        {
            var ID = txttaikhoan.Text;
            var Pass = txtmatkhau.Text;
            if(string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Nhập tài khoản!!!","Thống Báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(string.IsNullOrEmpty(Pass))
            {
                MessageBox.Show("Nhập mật khẩu!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TAIKHOAN tk = data.TAIKHOANs.SingleOrDefault(n => n.MATKHAU == ID && n.TAIKHOAN1 == Pass);
                if(tk != null)
                {
                    string s = ID + " " + Pass;
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TruyenVeMain(s);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }                               
            }
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có chắc muốn thoát!!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(thongbao == DialogResult.Yes)
            {
                Application.Exit();
            }
            

        }

        private void checkEdithethong_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdithethong.Checked == true)
            {
                checkEditnhanvien.Checked = false;                    
            }
        }

        private void checkEditnhanven_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditnhanvien.Checked == true)
            {
                checkEdithethong.Checked = false;
            }
        }
    }
}