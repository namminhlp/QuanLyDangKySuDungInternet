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
    public partial class frmMain : Form
    {
        Point click;
        public frmMain()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
            pnMenu.BackColor = ColorTranslator.FromHtml("#2B569A");
            btKhachHang.BackColor = ColorTranslator.FromHtml("#2B569A");
            btPhieuBao.BackColor = ColorTranslator.FromHtml("#2B569A");
            btThoat.BackColor = ColorTranslator.FromHtml("#2B569A");
            btTaiKhoan.BackColor = ColorTranslator.FromHtml("#2B569A");
            btTroGiup.BackColor = ColorTranslator.FromHtml("#2B569A");
            btHopDong.BackColor = ColorTranslator.FromHtml("#2B569A");
            btHome.BackColor = ColorTranslator.FromHtml("#2196F3");

        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btHide_Click(object sender, EventArgs e)
        {

        }

        private void lbHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - click.X;
                Top += e.Y - click.Y;
            }
        }

        private void lbHeader_MouseDown(object sender, MouseEventArgs e)
        {
            click = e.Location;
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void pnHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btTaiKhoan_Click(object sender, EventArgs e)
        {
            frmQuanLyTaiKhoan frmQLTK = new frmQuanLyTaiKhoan();
            Close();
            frmQLTK.Show();
        }

        private void btTroGiup_Click(object sender, EventArgs e)
        {

        }

        private void btKhachHang_Click(object sender, EventArgs e)
        {
            frmQuanLyKhachHang frmQLKH = new frmQuanLyKhachHang();
            Close();
            frmQLKH.Show();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            frmDangNhap x = new frmDangNhap();
            x.Show();
            Close();
        }

        private void btHopDong_Click(object sender, EventArgs e)
        {
            frmQuanLyHopDong frmQLHD = new frmQuanLyHopDong();
            Close();
            frmQLHD.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmQuanLyPhieuBao frmQLPB = new frmQuanLyPhieuBao();
            Close();
            frmQLPB.Show();
        }
    }
}