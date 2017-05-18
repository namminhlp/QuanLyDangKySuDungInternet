using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmTiepNhanTaiKhoan : Form
    {
        BUS.TaiKhoanBUS business = new BUS.TaiKhoanBUS();
        public frmTiepNhanTaiKhoan()
        {
            InitializeComponent();
            label1.BackColor = ColorTranslator.FromHtml("#2B569A");
            StartPosition = FormStartPosition.Manual;
        }
        public frmTiepNhanTaiKhoan(string MaHopDong)
        {
            InitializeComponent();
            label1.BackColor = ColorTranslator.FromHtml("#2B569A");
            StartPosition = FormStartPosition.Manual;

            txtMaHopDong.Text = MaHopDong;
            txtMaHopDong.Enabled = false;
        }
        private void frmTiepNhanTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btDongY_Click(object sender, EventArgs e)
        {
            if (business.themTaiKhoan(txtTenTruyCap.Text, txtMatKhau.Text,txtMaHopDong.Text, txtEmail.Text, txtDiaChiCD.Text,txtDiaChiTT.Text,txtTrangThai.Text))
            {
                MessageBox.Show("Thêm hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Thêm hợp đồng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
