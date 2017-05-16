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
        public frmDangNhap()
        {
            InitializeComponent();
            // Màu mặc định 
            pnHeader.BackColor = ColorTranslator.FromHtml("#2196F3");
            btExit.BackColor = ColorTranslator.FromHtml("#2196F3");
            pnFooter.BackColor = Color.Gray;
            txtTenTruyCap.BackColor = ColorTranslator.FromHtml("#E7E7E7");
            txtMatKhau.BackColor = ColorTranslator.FromHtml("#E7E7E7");
            btDangNhap.BackColor = ColorTranslator.FromHtml("#2196F3");
            btThoat.BackColor = ColorTranslator.FromHtml("#2196F3");
            btDangKy.BackColor = ColorTranslator.FromHtml("#ff9800");
            //Biến chỉ mặc định
            radKhachHang.Checked = true;
            //Set text Admin
            txtTenTruyCap.Text = "namminhlp";
            txtMatKhau.Text = "3071997";
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
            btExit.BackColor = Color.Red;
        }

        private void btExit_MouseLeave(object sender, EventArgs e)
        {
            btExit.BackColor = ColorTranslator.FromHtml("#2196F3");
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
                bool check;
                if (radAdmin.Checked)
                {
                    if (busAdmin.checkDangNhap(txtTenTruyCap.Text, txtMatKhau.Text))
                    {

                        frmMain mainScreen = new frmMain();
                        this.Hide();
                        mainScreen.Show();
                        mainScreen.TroVeLogin += MainScreen_TroVeLogin;
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hay mật khẩu sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (check = busKhachHang.checkDangNhap(txtTenTruyCap.Text, txtMatKhau.Text))
                    {
                        frmGiaoDienKhachHang khScreen = new frmGiaoDienKhachHang();
                        this.Hide();
                        khScreen.Show();
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
            Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btThoat_Click(object sender, EventArgs e)
        {

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
    }
}
