using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanHang.LinQToSQL;
using DevExpress.XtraEditors;

namespace QLBanHang
{
    class ClassNCC
    {
        ConnectToDatabase data;
        public ClassNCC()
        {
            data = new ConnectToDatabase();
        }

        public void LoadData(FormNCC ncc)
        {
            var dl = data.Database().NCCs.ToList();
            ncc.gridControl1.DataSource = dl;
        }

        public void LoadMaNCC(FormNCC fbh)
        {

            //Load Mã NCC
            int dem = 10;
            int kyso = (int)data.Database().RETURN_KYSO("NCC");
            int len = kyso.ToString().Length;
            dem = dem - 2 - len;
            string kq = "NCC";
            for (int i = 1; i <= dem; i++)
            {
                kq += "0";
            }
            fbh.txtmancc.Text = kq + kyso.ToString();
        }

        public void ThemNCC(string mancc, string tenncc, string diachi, string sdt)
        {
            NCC kq = data.Database().NCCs.SingleOrDefault(n => n.MANCC == mancc);
            if (kq == null)
            {
                NCC ncc = new NCC();
                ncc.MANCC = mancc;
                ncc.TENNCC = tenncc;
                ncc.DCNCC = diachi;
                ncc.DTNCC = sdt;

                data.Database().NCCs.InsertOnSubmit(ncc);
                data.Database().SubmitChanges();
                data.Database().TANG_MATUDONG("NCC");

            }

        }

        public void SuaNCC(string mancc, string tenncc, string diachi, string sdt)
        {

            NCC ncc = data.Database().NCCs.SingleOrDefault(n => n.MANCC == mancc);
            if (ncc != null)
            {
                ncc.MANCC = mancc;
                ncc.TENNCC = tenncc;
                ncc.DCNCC = diachi;
                ncc.DTNCC = sdt;

                data.Database().SubmitChanges();
            }
        }

        public void XoaNCC(string mancc)
        {
            DialogResult thongbao;
            NCC ncc = data.Database().NCCs.SingleOrDefault(n => n.MANCC == mancc);
            if(ncc != null)
            {
                thongbao = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông Báo",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(thongbao == DialogResult.Yes)
                {
                    data.Database().NCCs.DeleteOnSubmit(ncc);
                    data.Database().SubmitChanges();
                }

            }
        }
    }
    
}
