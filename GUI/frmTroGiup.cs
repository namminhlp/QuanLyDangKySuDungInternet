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
    public partial class frmTroGiup : Form
    {
        public frmTroGiup()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            btTroGiup.BackColor = ColorTranslator.FromHtml("#2196F3");

            pnMenu.BackColor = ColorTranslator.FromHtml("#2B569A");
            btKhachHang.BackColor = ColorTranslator.FromHtml("#2B569A");
            btPhieuBao.BackColor = ColorTranslator.FromHtml("#2B569A");
            btThoat.BackColor = ColorTranslator.FromHtml("#2B569A");
            btTaiKhoan.BackColor = ColorTranslator.FromHtml("#2B569A");
            btHopDong.BackColor = ColorTranslator.FromHtml("#2B569A");
            btHome.BackColor = ColorTranslator.FromHtml("#2B569A");
        }

        private void btMinimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbHeader_Click(object sender, EventArgs e)
        {

        }

        private void btHome_Click(object sender, EventArgs e)
        {
            frmMain x = new frmMain();
            x.Show();
            Close();
        }

        private void btKhachHang_Click(object sender, EventArgs e)
        {
            frmQuanLyKhachHang x = new frmQuanLyKhachHang();
            x.Show();
            Close();
        }

        private void btTaiKhoan_Click(object sender, EventArgs e)
        {
            frmQuanLyTaiKhoan x = new frmQuanLyTaiKhoan();
            x.Show();
            Close();
        }

        private void btPhieuBao_Click(object sender, EventArgs e)
        {
            frmQuanLyPhieuBao x = new frmQuanLyPhieuBao();
            x.Show();
            Close();
        }

        private void btTroGiup_Click(object sender, EventArgs e)
        {
            
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            frmDangNhap x = new frmDangNhap();
            x.Show();
            Close();
        }
    }
}
