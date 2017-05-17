using System;
using System.Drawing;
using System.Windows.Forms;
using BUS;
namespace GUI
{
    public partial class frmDangNhap : Form
    {
        NhanVienBUS busAdmin = new NhanVienBUS();
        TaiKhoanBUS busKhachHang = new TaiKhoanBUS();
        Point click;
        public frmDangNhap()
        {
            InitializeComponent();
            // Màu mặc định 
            txtTenTruyCap.BackColor = ColorTranslator.FromHtml("#E7E7E7");
            txtMatKhau.BackColor = ColorTranslator.FromHtml("#E7E7E7");
            StartPosition = FormStartPosition.CenterScreen;
            // Set text Admin
            txtTenTruyCap.Text = "admin1";
            txtMatKhau.Text = "3071997";
            btThoat.Hide();

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btExit_MouseHover(object sender, EventArgs e)
        {
        }

        private void btExit_MouseLeave(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radKhachHang_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenTruyCap.Text.Length == 0 && txtMatKhau.Text.Length == 0)
            {
                MessageBox.Show("Tài khoản mật khẩu không được trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtTenTruyCap.Text.Length < 7)
                {
                    if (busAdmin.checkDangNhap(txtTenTruyCap.Text, txtMatKhau.Text))
                    {

                        frmMain mainScreen = new frmMain();
                        Hide();
                        mainScreen.Show();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hay mật khẩu sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (busAdmin.checkDangNhap(txtTenTruyCap.Text, txtMatKhau.Text))
                    {
                        // Bung giao diện khách hàng
                        MessageBox.Show("Giao diện khách hàng đang được xây dựng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hay mật khẩu sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }       
        }
        private void MainScreen_TroVeLogin(object sender, EventArgs e)
        {
            (sender as frmMain).Close();
            txtMatKhau.Text = null;
            Show();
        }

        // Bắt sự kiện đóng các form để quay trở lại màn hình đăng nhập

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbDangKy_Click(object sender, EventArgs e)
        {

        }

        private void btDangKy_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void btDangKy_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pnHeader_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void pnHeader_MouseDown(object sender, MouseEventArgs e)
        {
      
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            click = e.Location;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            // Xử lý sự kiện kéo windows
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - click.X;
                Top += e.Y - click.Y;
            }
        }

        private void txtTenTruyCap_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            // Nút minimized
            WindowState = FormWindowState.Minimized;
        }
    }
}
