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
    public partial class frmQuanLyKhachHang : Form
    {
        BUS.KhachHangBUS business = new BUS.KhachHangBUS();
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.DataSource = business.load();

            btXoa.Enabled = false;
            btSua.Enabled = false;
            btLapHopDong.Enabled = false;

            btKhachHang.BackColor = ColorTranslator.FromHtml("#2196F3");
            
            pnMenu.BackColor = ColorTranslator.FromHtml("#2B569A");
            btHome.BackColor = ColorTranslator.FromHtml("#2B569A");
            btPhieuBao.BackColor = ColorTranslator.FromHtml("#2B569A");
            btThoat.BackColor = ColorTranslator.FromHtml("#2B569A");
            btTaiKhoan.BackColor = ColorTranslator.FromHtml("#2B569A");
            btTroGiup.BackColor = ColorTranslator.FromHtml("#2B569A");
            btHopDong.BackColor = ColorTranslator.FromHtml("#2B569A");
        }

        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {

        }
        Point click;
        private void lbHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - click.X;
                Top += e.Y - click.Y;
            }
        }

        private void lbHeader_Click(object sender, EventArgs e)
        {

        }

        private void lbHeader_MouseDown(object sender, MouseEventArgs e)
        {
            click = e.Location;
        }

        private void btMinimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            frmDangNhap x = new frmDangNhap();
            x.Show();
            Close();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            Close();

           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbHoTen_Click(object sender, EventArgs e)
        {

        }

        private void lbDiaChi_Click(object sender, EventArgs e)
        {

        }

        private void lbSDT_Click(object sender, EventArgs e)
        {

        }

        private void lbLoaiKH_Click(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaKhachHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLoaiKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void btPhieuBao_Click(object sender, EventArgs e)
        {

        }

        private void btKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void btXem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = business.load();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            frmTiepNhanKhachHang frmTNKH = new frmTiepNhanKhachHang();
            frmTNKH.Show();
            frmTNKH.FormClosed += FrmTNKH_FormClosed;
        }

        private void FrmTNKH_FormClosed(object sender, FormClosedEventArgs e)
        {
            btXem_Click(sender, e);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (business.suaKhachHang(txtMaKhachHang.Text, txtHoTen.Text, txtDiaChi.Text, txtCMND.Text, txtLoaiKH.Text, int.Parse(txtSDT.Text)))
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
                btLapHopDong.Enabled = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKhachHang.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtCMND.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtLoaiKH.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtSDT.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            btXoa.Enabled = true;
            btSua.Enabled = true;
            btLapHopDong.Enabled = true;
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKhachHang.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtCMND.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtLoaiKH.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtSDT.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            btXoa.Enabled = true;
            btSua.Enabled = true;
            btLapHopDong.Enabled = true;
        }
        private void troVeTrangThaiDau()
        {
            txtMaKhachHang.Text = null;
            txtHoTen.Text = null;
            txtDiaChi.Text = null;
            txtCMND.Text = null;
            txtLoaiKH.Text = null;
            txtSDT.Text = null;
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (business.xoaKhachHang(txtMaKhachHang.Text))
            {
                MessageBox.Show("Xóa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                MessageBox.Show("Xóa dữ liệu thất bại, có thể khách hàng đang có một vài hợp đồng trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            btXoa.Enabled = false;
            btSua.Enabled = false;
            btLapHopDong.Enabled = false;
            btXem_Click(sender, e);
        }

        private void btLapHopDong_Click(object sender, EventArgs e)
        {

        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTimKiem_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = business.timKhachHang(txtTimKiem.Text);
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = null;
            txtTimKiem.ForeColor = Color.Black;
            // Xử lý khi nhấn một phím xuống
            txtTimKiem.KeyDown += new KeyEventHandler(txtTimkiem_KeyDown);  
        }

        private void txtTimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            // Khi click vào nút enter
            if (e.KeyCode == Keys.Enter)
            {
                dataGridView1.DataSource = business.timKhachHang(txtTimKiem.Text);
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            txtTimKiem.Text = "Tìm kiếm với Mã khách hàng...";
            txtTimKiem.ForeColor = Color.Gray;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.DarkOrange;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.WhiteSmoke;
        }

        private void toolStripKhachHang_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
