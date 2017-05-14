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
        public frmMain()
        {
            InitializeComponent();
        }
        public event EventHandler TroVeLogin;
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TroVeLogin(this, new EventArgs());
        }

        void QLKHForm_DangXuat(object sender, EventArgs e)
        {
            (sender as frmQuanLyKhachHang).Close();
            this.Show();
        }
        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyKhachHang KhachHangScreen = new frmQuanLyKhachHang();
            KhachHangScreen.Show();
            KhachHangScreen.TroVeMain += QLKHForm_DangXuat;
        }
        void QLHDForm_DangXuat(object sender, EventArgs e)
        {
            (sender as frmQuanLyHopDong).Close();
            this.Show();
        }
        private void hợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyHopDong HopDongScreen = new frmQuanLyHopDong();
            HopDongScreen.Show();
            HopDongScreen.TroVeMain += QLHDForm_DangXuat;
        }
        void QLTKForm_DangXuat(object sender, EventArgs e)
        {
            (sender as frmQuanLyTaiKhoan).Close();
            this.Show();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyTaiKhoan QLTK = new frmQuanLyTaiKhoan();
            QLTK.Show();
            QLTK.TroVeMain += QLTKForm_DangXuat;
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        void QLPBForm_DangXuat(object sender, EventArgs e)
        {
            (sender as frmQuanLyPhieuBao).Close();
            this.Show();
        }
        private void phiếuBáoĐãLậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyPhieuBao frmQLPB = new frmQuanLyPhieuBao();
            frmQLPB.Show();
            frmQLPB.TroVeMain += QLPBForm_DangXuat;

        }
    }
}
