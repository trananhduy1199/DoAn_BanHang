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
    public partial class FormMuaHang : DevExpress.XtraEditors.XtraForm
    {
        List<ClassMuaHang> listmuahang = new List<ClassMuaHang>();
        ClassMuaHang muahang;
        ConnectToDatabase data;

        public FormMuaHang()
        {
            muahang = new ClassMuaHang();
            data = new ConnectToDatabase();
            InitializeComponent();
            LoadData();
            dateEditngaylap.Text = DateTime.Now.ToString();
            txttenncc.Enabled = false;
            txtdiachi.Enabled = false;
            txtsodienthoai.Enabled = false;
            
        }

        

       
        public void LoadData()
        {
            muahang.LoadMaPN(this);
            muahang.LoadMaSP(this);
            muahang.LoadMaNCC(this);
        }

        private void simpleButtonthem_Click(object sender, EventArgs e)
        {
            if (ClassMuaHang.KTThemSP(txtsoluong.Text) == true)
            {
                //Tìm sản phẩm trong list
                var tam = listmuahang.SingleOrDefault(n => n.MaSP == comboBoxmasanpham.Text);
                //Nếu sản phẩm có rồi thì cộng dồn số lượng
                if (tam != null)
                {
                    tam.SoLuong = (int.Parse(tam.SoLuong) + int.Parse(txtsoluong.Text)).ToString();
                }
                //Nếu sản phẩm chưa có thì lưu vào danh sách
                else
                {
                    listmuahang.Add(muahang.ThemSP(this));
                }

                //update lại list
                var sp = listmuahang.ToList();
                //Show list lên grid
                gridControl1.DataSource = sp;
                //ResetForm
                muahang.RS(this);

            }
            int tong = 0;
            foreach (var item in listmuahang)
            {
                tong += int.Parse(item.SoLuong) * int.Parse(item.GiaMua);
            }
            txtthanhtien.Text = tong.ToString();

        }

        private void simpleButtondongy_Click(object sender, EventArgs e)
        {
           
                muahang.LuuPhieuNhap(txtsophieunhap.Text, dateEditngaylap.Text,comboboxmancc.Text ,textBoxmanhanvien.Text, txtthanhtien.Text,this);
                foreach(var item in listmuahang)
                {
                    muahang.LuuCTPN(txtsophieunhap.Text,item.MaSP, item.SoLuong, item.GiaMua);
                }
           

        }
        string masp;
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            masp = gridView1.GetRowCellValue(gridView1.FocusedRowHandle,"MaSP").ToString();
        }

        private void simpleButtonxoa_Click(object sender, EventArgs e)
        {

            foreach (var item in listmuahang.ToList())
            {
                if (item.MaSP == masp)
                {
                    listmuahang.Remove(item);


                }
            }
            var sp = listmuahang.ToList();
            //Show list lên grid
            gridControl1.DataSource = sp;
        }

        private void FormMuaHang_Load(object sender, EventArgs e)
        {

        }

        private void comboboxmancc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dl = data.Database().NCCs.SingleOrDefault(a=>a.MANCC==comboboxmancc.Text);
            if (dl != null)
            {
                txttenncc.Text = dl.TENNCC;
                txtdiachi.Text=dl.DCNCC;
                txtsodienthoai.Text=dl.DTNCC;               
            }
        }

        private void comboBoxmasanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dl = data.Database().SANPHAMs.SingleOrDefault(a => a.MASP == comboBoxmasanpham.Text);
            if (dl != null)
            {
                txtdongia.Text = dl.GIAMUA.ToString();
                txtsanpham.Text = dl.TENSP;           
            }
        }
    }
}