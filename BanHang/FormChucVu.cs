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
        dbQLBanHangDataContext data = new dbQLBanHangDataContext();
        public FormChucVu()
        {
            InitializeComponent();
            txtmachucvu.Enabled = false;
            LoadData();
        }

        public void LoadData()
        {
            var dl = data.TABLE_CHUCVU();
            gridControlchucvu.DataSource = dl;
            LoadMaChucVu();
        }

        public void LoadMaChucVu()
        {
            int dem = 10;
            int kyso = int.Parse(data.RETURN_KYSO("CV").ToString());
            int len_so = kyso.ToString().Length;
            dem = dem - 2 - len_so;
            string kq = "CV";
            for (int i = 1; i <= dem; i++)
            {
                kq += "0";
            }
            txtmachucvu.Text = kq + kyso.ToString();
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            CHUCVU cv = new CHUCVU();
            cv.MACV = txtmachucvu.Text;
            cv.TENCV = txttenchucvu.Text;
            data.CHUCVUs.InsertOnSubmit(cv);
            data.SubmitChanges();
            data.TANG_MATUDONG("CV");
            LoadData();
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            CHUCVU CV = data.CHUCVUs.SingleOrDefault(C=>C.MACV==txtmachucvu.Text);

            CV.TENCV = txttenchucvu.Text;
            data.SubmitChanges();
            LoadData();
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            CHUCVU cv = data.CHUCVUs.SingleOrDefault(C => C.MACV == txtmachucvu.Text);
            DialogResult thongbao;
            if(cv!=null)
            {
                thongbao = (MessageBox.Show("Bạn có chắc muốn xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (thongbao == DialogResult.Yes)
                {
                    data.CHUCVUs.DeleteOnSubmit(cv);
                    data.SubmitChanges();
                    LoadData();
                }                                
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            txtmachucvu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MACV").ToString();            
            txttenchucvu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TENCV").ToString();
        }
    }
}
