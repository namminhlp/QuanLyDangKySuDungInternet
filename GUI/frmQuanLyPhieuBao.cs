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

            // hàm tự động
            business.lapPhieuBaoTuDong();
            business.tinhCuocPhiTuDong();

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
            business.lapPhieuBaoTuDong();
            business.tinhCuocPhiTuDong();
            dataGridView1.DataSource = business.load();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (business.xoaPhieuBao(txtMaPhieuBao.Text))
            {
                MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                txtMaPhieuBao.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtTenTruyCap.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtNgayLap.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtThangLap.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtTongTien.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                // txtTinhTrangTT.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                bool tempTinhTrangTT = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[5].Value);
                if (tempTinhTrangTT == true)
                {
                    txtTinhTrangTT.Text = "Đã thanh toán";
                }
                else
                {
                    txtTinhTrangTT.Text = "Chưa thanh toán";
                }
                // Do Ngày TT không có, null nên convert ta string ko dc nên phải sử dụng gián tiếp
                DateTime tempNgayTT = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[6].Value);
                txtNgayTT.Text = (tempNgayTT == DateTime.MinValue ? "" : tempNgayTT.ToString());
                // Tương tự với hình thức thanh toán
                string tempHinhThucTT = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);
                txtHinhThucTT.Text = (tempHinhThucTT == null ? "" : tempHinhThucTT.ToString());
                 if (tempTinhTrangTT == false && Convert.ToInt32(txtTongTien.Text) > 0 && DateTime.Now.Month > Convert.ToDateTime(txtThangLap.Text).Month)
                 {
                        btXacNhan.Enabled = true;
                  }
                 else
                 {
                         btXacNhan.Enabled = false;
                  }
                  btXoa.Enabled = true;
                  btChiTietTruyCap.Enabled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

                txtMaPhieuBao.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtTenTruyCap.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtNgayLap.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtThangLap.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtTongTien.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                // txtTinhTrangTT.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                bool tempTinhTrangTT = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[5].Value);
                if (tempTinhTrangTT == true )
                {
                    txtTinhTrangTT.Text = "Đã thanh toán";
                } 
                else
                {
                    txtTinhTrangTT.Text = "Chưa thanh toán";
                }
                // Do Ngày TT không có, null nên convert ta string ko dc nên phải sử dụng gián tiếp
                DateTime tempNgayTT = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[6].Value);
                txtNgayTT.Text = (tempNgayTT == DateTime.MinValue ? "" : tempNgayTT.ToString());
                // Tương tự với hình thức thanh toán
                string tempHinhThucTT = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);
                txtHinhThucTT.Text = (tempHinhThucTT == null ? "" : tempHinhThucTT.ToString());
                if (tempTinhTrangTT == false && Convert.ToInt32(txtTongTien.Text) > 0 && DateTime.Now.Month > Convert.ToDateTime(txtThangLap.Text).Month)
                {
                     btXacNhan.Enabled = true;
                }
                else
                 {
                    btXacNhan.Enabled = false;
                  }
                btXoa.Enabled = true;
                btChiTietTruyCap.Enabled = true;

            
        }

        private void lbHeader_Click(object sender, EventArgs e)
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

        private void lbHeader_MouseDown(object sender, MouseEventArgs e)
        {
            click = e.Location;
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            frmXacNhanThanhToan fXN = new frmXacNhanThanhToan(txtMaPhieuBao.Text);
            fXN.Show();
            fXN.FormClosed += FXN_FormClosed;
        }

        private void FXN_FormClosed(object sender, FormClosedEventArgs e)
        {
            btXem_Click(sender, e);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridView1.DataSource = business.timPhieuBao(txtMaPhieuBao.Text);
            }
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = null;
            txtTimKiem.ForeColor = Color.Black;
            txtTimKiem.KeyDown += new KeyEventHandler(TxtTimKiem_KeyDown);
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            txtTimKiem.Text = "Tìm kiếm với Mã phiếu báo...";
            txtTimKiem.ForeColor = Color.Gray;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = business.timPhieuBao(txtMaPhieuBao.Text);
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.DarkOrange;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.WhiteSmoke;
        }

        private void btPhieuBao_Click(object sender, EventArgs e)
        {

        }
    }
}
