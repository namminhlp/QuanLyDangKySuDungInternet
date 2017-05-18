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
    public partial class frmQuanLyHopDong : Form
    {
        BUS.HopDongBUS business = new BUS.HopDongBUS();
        public frmQuanLyHopDong()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.DataSource = business.load();
            // Set giao diện mặc định
            btXoa.Enabled = false;
            btSua.Enabled = false;
            btTaoTaiKhoan.Enabled = false;
            txtNgayKyHD.Enabled = false;
            btHopDong.BackColor =  ColorTranslator.FromHtml("#2196F3");

            pnMenu.BackColor = ColorTranslator.FromHtml("#2B569A");
            btHome.BackColor = ColorTranslator.FromHtml("#2B569A");
            btPhieuBao.BackColor = ColorTranslator.FromHtml("#2B569A");
            btThoat.BackColor = ColorTranslator.FromHtml("#2B569A");
            btTaiKhoan.BackColor = ColorTranslator.FromHtml("#2B569A");
            btTroGiup.BackColor = ColorTranslator.FromHtml("#2B569A");
            btKhachHang.BackColor = ColorTranslator.FromHtml("#2B569A");
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbMaKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void frmQuanLyHopDong_Load(object sender, EventArgs e)
        {

        }

        private void lbTongTK_Click(object sender, EventArgs e)
        {

        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLoaiKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbChiPhi_Click(object sender, EventArgs e)
        {

        }

        private void lbNgayKyHD_Click(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaHopDong.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtMaKhachHang.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtNgayDK.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtTongTK.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtChiPhi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                // Do Ngày ký HD không có, null nên convert ta string ko dc nên phải sử dụng gián tiếp
                DateTime tempNgayKyHD = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value);
                txtNgayKyHD.Text = (tempNgayKyHD == DateTime.MinValue ? "" : tempNgayKyHD.ToString());
                btXoa.Enabled = true;
                btSua.Enabled = true;
                if (txtNgayKyHD.Text.Length == 0)
                {
                    txtNgayKyHD.Text = "mm/dd/yyyy";
                    txtNgayKyHD.ForeColor = Color.Gray;
                }
                else
                {
                    btTaoTaiKhoan.Enabled = true;
                    txtNgayKyHD.ForeColor = Color.Black;
                }
            }
            catch (Exception)
            {

            }

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaHopDong.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtMaKhachHang.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtNgayDK.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtTongTK.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtChiPhi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                // Do Ngày ký HD không có, null nên convert ta string ko dc nên phải sử dụng gián tiếp
                DateTime tempNgayKyHD = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value);
                txtNgayKyHD.Text = (tempNgayKyHD == DateTime.MinValue ? "" : tempNgayKyHD.ToString());
                btXoa.Enabled = true;
                btSua.Enabled = true;
                if (txtNgayKyHD.Text.Length == 0)
                {
                    txtNgayKyHD.Text = "mm/dd/yyyy";
                    txtNgayKyHD.ForeColor = Color.Gray;
                }
                else
                {
                    btTaoTaiKhoan.Enabled = true;
                    txtNgayKyHD.ForeColor = Color.Black;
                }
            }
            catch (Exception)
            {

            }
            
        }

        private void toolStripHopDong_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btHome_Click(object sender, EventArgs e)
        {
            frmMain fMain = new frmMain();
            fMain.Show();
            Close();
        }

        private void btKhachHang_Click(object sender, EventArgs e)
        {
            frmQuanLyKhachHang fQLKH = new frmQuanLyKhachHang();
            fQLKH.Show();
            Close();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            frmDangNhap fLogin = new frmDangNhap();
            fLogin.Show();
            Close();
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = business.load();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            frmTiepNhanHopDong fTNHD = new frmTiepNhanHopDong();
            fTNHD.Show();
            fTNHD.FormClosed += FTNHD_FormClosed;
        }

        private void FTNHD_FormClosed(object sender, FormClosedEventArgs e)
        {
            btXem_Click(sender, e);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (business.suaHopDong(txtMaHopDong.Text, txtMaKhachHang.Text,txtTongTK.Text, txtChiPhi.Text, txtNgayDK.Text,txtNgayKyHD.Text))
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    MessageBox.Show("Cập nhật dữ liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            if (dataGridView1.CurrentRow == null)
            {
                btSua.Enabled = false;
                btXoa.Enabled = false;
                btTaoTaiKhoan.Enabled = false;
            }
            btXem_Click(sender, e);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (business.xoaHopDong(txtMaHopDong.Text))
            {
                MessageBox.Show("Xóa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                MessageBox.Show("Xóa hợp đồng thất bại, có thể do tồn tại tài khoản trong hợp đồng đang sử dụng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (dataGridView1.CurrentRow == null)
            {
                btSua.Enabled = false;
                btXoa.Enabled = false;
                btTaoTaiKhoan.Enabled = false;
            }
            btXem_Click(sender, e);
        }

        private void btTaoTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = 
                business.xemDanhSachCho();
        }

        private void btMinimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - click.X;
                Top += e.Y - click.Y;
            }
        }
        Point click;
        private void lbHeader_MouseDown(object sender, MouseEventArgs e)
        {
            click = e.Location;
        }

        private void lbHeader_Click(object sender, EventArgs e)
        {

        }
    }
}
