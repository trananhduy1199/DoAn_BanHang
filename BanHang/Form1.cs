using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BanHang.LinqToSQL;

namespace BanHang
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        dbQLBanHangDataContext data = new dbQLBanHangDataContext();
        public static string Quyen="";        
        
        public Form1()
        {
            InitializeComponent();            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {            
            FormLogIn flogin = new FormLogIn();
            flogin.Show();            

        }        

        private void Form1_Load(object sender, EventArgs e)
        {            
            barButtonItemDangXuat.Enabled = false;
            ribbonPageChucNang.Visible = false;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (Quyen == "admin")
            {
                barButtonItemDangXuat.Enabled = true;
                barButtonItemDangNhap.Enabled = false;
                ribbonPageChucNang.Visible = true;
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormChucVu fcv = new FormChucVu();
            fcv.Show();
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormNhanVien fnv = new FormNhanVien();
            fnv.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormKhachHang fkh = new FormKhachHang();
            fkh.Show();
        }
        
    }
}
