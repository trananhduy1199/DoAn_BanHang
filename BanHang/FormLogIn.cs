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
    public partial class FormLogIn : Form
    {
        dbQLBanHangDataContext data = new dbQLBanHangDataContext();

        public FormLogIn()
        {
            InitializeComponent();
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butdangnhap_Click(object sender, EventArgs e)
        {
            var taikhoan = txttaikhoan.Text;
            var matkhau = txtmatkhau.Text;

            PHANQUYEN pq = data.PHANQUYENs.SingleOrDefault(p=> p.TAIKHOAN_ADMIN==taikhoan && p.MATKHAU_ADMIN==matkhau);
            if (pq != null)
            {
                Form1.Quyen = pq.QUYEN;
                this.Hide();
                this.DialogResult = DialogResult.OK;
                this.Close();               
            }
        }
    }
}
