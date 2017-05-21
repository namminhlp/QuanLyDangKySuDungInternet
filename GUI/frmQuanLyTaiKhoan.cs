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
    public partial class frmQuanLyTaiKhoan : Form
    {
        BUS.TaiKhoanBUS business = new BUS.TaiKhoanBUS();
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.DataSource = business.load();
            //Set giao diện mặc định
            btXoa.Enabled = false;
            btSua.Enabled = false;
            btTaiKhoan.BackColor = ColorTranslator.FromHtml("#2196F3");

            pnMenu.BackColor = ColorTranslator.FromHtml("#2B569A");
            btHome.BackColor = ColorTranslator.FromHtml("#2B569A");
            btPhieuBao.BackColor = ColorTranslator.FromHtml("#2B569A");
            btThoat.BackColor = ColorTranslator.FromHtml("#2B569A");
            btTroGiup.BackColor = ColorTranslator.FromHtml("#2B569A");
            btKhachHang.BackColor = ColorTranslator.FromHtml("#2B569A");
            btHopDong.BackColor = ColorTranslator.FromHtml("#2B569A");

            txtTimKiem.KeyDown += new KeyEventHandler(txtTimkiem_KeyDown);

        }

        private void pnMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btMinimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void txtTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbHeader_Click(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point click;
        private void lbHeader_MouseDown(object sender, MouseEventArgs e)
        {
            click = e.Location;
        }

        private void lbHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - click.X;
                Top += e.Y - click.Y;
            }
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            frmMain fMain = new frmMain();
            fMain.Show();
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
            frmTiepNhanTaiKhoan fTNTK = new frmTiepNhanTaiKhoan();
            fTNTK.Show();
            fTNTK.FormClosed += FTNTK_FormClosed;
        }

        private void FTNTK_FormClosed(object sender, FormClosedEventArgs e)
        {
            btXem_Click(sender, e);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (business.suaTaiKhoan(txtTenTruyCap.Text, txtMatKhau.Text, txtMaHopDong.Text, txtEmail.Text, txtDiaChiCD.Text, txtDiaChiTT.Text, txtTrangThai.Text))
            {
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Cập nhật dữ liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (dataGridView1.CurrentRow == null)
            {
                btSua.Enabled = false;
                btXoa.Enabled = false;
            }
            btXem_Click(sender, e);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (business.xoaTaiKhoan(txtTenTruyCap.Text))
            {
                MessageBox.Show("Xóa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (dataGridView1.CurrentRow == null)
            {
                btSua.Enabled = false;
                btXoa.Enabled = false;
            }
            btXem_Click(sender, e);
        }

        private void btDinhChi_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = business.xemChuaKichHoat();
        }

        private void btChiTietTruyCap_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtTenTruyCap.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtMaHopDong.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtMatKhau.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtDiaChiCD.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtDiaChiTT.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtTrangThai.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                btXoa.Enabled = true;
                btSua.Enabled = true;
                
            }
            catch (Exception)
            {

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtTenTruyCap.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtMaHopDong.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtMatKhau.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtDiaChiCD.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtDiaChiTT.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtTrangThai.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                btXoa.Enabled = true;
                btSua.Enabled = true;

            }
            catch (Exception)
            {

            }
        }

        private void btHopDong_Click(object sender, EventArgs e)
        {
            frmQuanLyHopDong fQLHD = new frmQuanLyHopDong();
            fQLHD.Show();
            Close();

        }

        private void btKhachHang_Click(object sender, EventArgs e)
        {
            frmQuanLyKhachHang fQLKH = new frmQuanLyKhachHang();
            fQLKH.Show();
            Close();
        }

        private void btPhieuBao_Click(object sender, EventArgs e)
        {
            frmQuanLyPhieuBao fQLPB = new frmQuanLyPhieuBao();
            fQLPB.Show();
            Close();
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            txtTimKiem.Text = "Tìm kiếm với Tên truy cập...";
            txtTimKiem.ForeColor = Color.Gray;
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = null;
            txtTimKiem.ForeColor = Color.Black;
            // Xử lý khi nhấn một phím xuống
        }

        private void txtTimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pictureBox2_Click(sender, e);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = business.timTaiKhoan(txtTimKiem.Text);
            txtTimKiem.Clear();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.DarkOrange;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.WhiteSmoke;
        }
    }
}
