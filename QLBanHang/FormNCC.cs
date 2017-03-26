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

namespace QLBanHang
{
    public partial class FormNCC : DevExpress.XtraEditors.XtraForm
    {
        ClassNCC ncc;
        public FormNCC()
        {
            ncc = new ClassNCC();
            InitializeComponent();
            LoadData();
        }
        public void RsForm()
        {
            txtdiachi.Text = "";
            txtmancc.Text = "";
            txtsdt.Text = "";
            txttenncc.Text = "";
        }
        public void LoadData()
        {
            ncc.LoadData(this);
            ncc.LoadMaNCC(this);
        }
        private void FormNCC_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ncc.ThemNCC(txtmancc.Text, txttenncc.Text, txtdiachi.Text, txtsdt.Text);
            RsForm();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ncc.SuaNCC(txtmancc.Text, txttenncc.Text, txtdiachi.Text, txtsdt.Text);
            RsForm();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            ncc.XoaNCC(txtmancc.Text);
            RsForm();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}