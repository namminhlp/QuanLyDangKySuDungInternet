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
            if (txtTenTruyCap.Text.Length <= 6)
            {
                MessageBox.Show("Tên truy cập ít nhất 7 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
            if (business.themTaiKhoan(txtTenTruyCap.Text, txtMatKhau.Text,txtMaHopDong.Text, txtEmail.Text, txtDiaChiCD.Text,txtDiaChiTT.Text,txtTrangThai.Text))
            {
                MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại! Có thể do đã tồn tại tên truy cập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            Close();
        }
    }
}
