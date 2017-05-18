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
    public partial class frmQuanLyPhieuBao : Form
    {
        BUS.PhieuBaoBUS business = new BUS.PhieuBaoBUS();
        BUS.ChiTiet_TruyCapBUS busCTTC = new BUS.ChiTiet_TruyCapBUS();
        public frmQuanLyPhieuBao()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.DataSource = business.load();
            //Set button
            btXoa.Enabled = false;
            btXacNhan.Enabled = false;
            btChiTietTruyCap.Enabled = false;

            // Màu mặc định form
            btPhieuBao.BackColor = ColorTranslator.FromHtml("#2196F3");
            pnMenu.BackColor = ColorTranslator.FromHtml("#2B569A");
            btHome.BackColor = ColorTranslator.FromHtml("#2B569A");
            btKhachHang.BackColor = ColorTranslator.FromHtml("#2B569A");
            btThoat.BackColor = ColorTranslator.FromHtml("#2B569A");
            btTaiKhoan.BackColor = ColorTranslator.FromHtml("#2B569A");
            btTroGiup.BackColor = ColorTranslator.FromHtml("#2B569A");
            btHopDong.BackColor = ColorTranslator.FromHtml("#2B569A");

            //Không được phép chỉnh sửa data do Phiếu báo được cập nhật tự động
            txtMaPhieuBao.Enabled = false;
            txtTenTruyCap.Enabled = false;
            txtNgayTT.Enabled = false;
            txtTinhTrangTT.Enabled = false;
            txtThangLap.Enabled = false;
            txtTongTien.Enabled = false;
            txtHinhThucTT.Enabled = false;
            txtNgayLap.Enabled = false;


        }

        private void frmQuanLyPhieuBao_Load(object sender, EventArgs e)
        {

        }

        private void btSua_Click(object sender, EventArgs e)
        {

        }

        private void btMinimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = business.load();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (business.xoaPhieuBao(txtMaPhieuBao.Text))
            {
                MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                MessageBox.Show("Xóa dữ liệu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            btXoa.Enabled = false;
            btXacNhan.Enabled = false;
            btChiTietTruyCap.Enabled = false;
            btXem_Click(sender, e);
        }

        private void btXemTrePhi_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = business.dongPhiTre();
        }

        private void btChiTietTruyCap_Click(object sender, EventArgs e)
        {
            frmChiTietTruyCap fCTTC = new frmChiTietTruyCap(txtMaPhieuBao.Text);
            fCTTC.Show();
            fCTTC.FormClosed += FCTTC_FormClosed;
           
        }

        private void FCTTC_FormClosed(object sender, FormClosedEventArgs e)
        {
            btXem_Click(sender, e);
        }

        private void btTaiKhoan_Click(object sender, EventArgs e)
        {
            frmQuanLyTaiKhoan fQLTK = new frmQuanLyTaiKhoan();
            fQLTK.Show();
            Close();
        }

        private void btHopDong_Click(object sender, EventArgs e)
        {
            frmQuanLyHopDong fHD = new frmQuanLyHopDong();
            fHD.Show();
            Close();

        }

        private void btKhachHang_Click(object sender, EventArgs e)
        {
            frmQuanLyKhachHang fKH = new frmQuanLyKhachHang();
            fKH.Show();
            Close();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            frmMain fMain = new frmMain();
            fMain.Show();
            Close();
        }
    }
}
