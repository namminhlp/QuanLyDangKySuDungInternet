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
    public partial class frmTiepNhanHopDong : Form
    {
        BUS.HopDongBUS business = new BUS.HopDongBUS();
        public frmTiepNhanHopDong()
        {
            InitializeComponent();
        }
        public frmTiepNhanHopDong(string MaKH)
        {
            InitializeComponent();
            txtMaKhachHang.Text = MaKH;
            txtMaKhachHang.Enabled = false;
            label1.BackColor = ColorTranslator.FromHtml("#2B569A");
            StartPosition = FormStartPosition.Manual;

            txtNgayDK.Text = "Nhập mm/dd/yyyy";
            txtNgayDK.ForeColor = Color.DimGray;

        }
        private void frmTiepNhanHopDong_Load(object sender, EventArgs e)
        {

        }

        private void btDongY_Click(object sender, EventArgs e)
        {
            if (business.themHopDong(txtMaHopDong.Text, txtMaKhachHang.Text, txtTongTK.Text, txtChiPhi.Text, txtNgayDK.Text))
            {
                MessageBox.Show("Thông báo", "Thêm hợp đồng thành công !", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Thông báo", "Thêm hợp đồng thất bại !", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        private void txtMaKhachHang_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNgayDK_Leave(object sender, EventArgs e)
        {
            if (txtNgayDK.Text.Length == 0 || txtNgayDK.Text == null)
            {
                txtNgayDK.Text = "Nhập mm/dd/yyyy";
                txtNgayDK.ForeColor = Color.DimGray;
            }
        }

        private void txtNgayDK_Click(object sender, EventArgs e)
        {
            txtNgayDK.Text = null;
            txtNgayDK.ForeColor = Color.Black;
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
