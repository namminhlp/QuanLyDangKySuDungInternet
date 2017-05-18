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
    public partial class frmTiepNhanKhachHang : Form
    {
        BUS.KhachHangBUS business = new BUS.KhachHangBUS();
        public frmTiepNhanKhachHang()
        {
            InitializeComponent();
            label1.BackColor = ColorTranslator.FromHtml("#2B569A");
            StartPosition = FormStartPosition.Manual;
        }

        private void lbLoaiKH_Click(object sender, EventArgs e)
        {

        }

        private void frmTiepNhanKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btDongY_Click(object sender, EventArgs e)
        {
            if (business.themKhachHang(txtMaKhachHang.Text, txtHoTen.Text, txtDiaChi.Text, txtCMND.Text, txtLoaiKH.Text, txtSDT.Text))
            {
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại!", "Thông báo",  MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }

        }
    }
}
