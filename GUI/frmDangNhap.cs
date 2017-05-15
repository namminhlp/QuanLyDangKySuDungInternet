using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        BUS.NhanVienBUS busAdmin= new BUS.NhanVienBUS();
        BUS.TaiKhoanBUS busKhachHang = new BUS.TaiKhoanBUS();

        public frmDangNhap()
        {
            InitializeComponent();
            this.AcceptButton = btDangNhap;
            txtTaiKhoan.Text = "namminhlp";
            txtMatKhau.Text = "3071997";
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Length == 0 && txtMatKhau.Text.Length == 0)
            {
                MessageBox.Show("Tài khoản mật khẩu không được trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool check;
                if (radAdmin.Checked)
                {
                    if (busAdmin.checkDangNhap(txtTaiKhoan.Text, txtMatKhau.Text))
                    {

                        frmMain mainScreen = new frmMain();
                        this.Hide();
                        mainScreen.Show();
                        mainScreen.TroVeLogin += MainForm_DangXuat;
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hay mật khẩu sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (check = busKhachHang.checkDangNhap(txtTaiKhoan.Text, txtMatKhau.Text))
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void MainForm_DangXuat(object sender, EventArgs e)
        {
            (sender as frmMain).Close();
            txtMatKhau.Text = null;
            this.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void grpDangNhap_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
