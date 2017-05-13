using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class frmQuanLyHopDong : Form
    {
        HopDongBUS business = new HopDongBUS();
        private FormClosedEventHandler frmTNTK_FormClosed;

        public frmQuanLyHopDong()
        {
            InitializeComponent();
            dataGridView1.DataSource = business.load();
            button1.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
            txtMaHD.Enabled = false;
            txtMaKH.Enabled = false;
            btTaoTaiKhoan.Enabled = false;
            if (txtNgayDKHD.Text.Length == 0)
            {
                txtNgayDKHD.ForeColor = Color.Gray;
                txtNgayDKHD.Text = "mm/dd/yyyy";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTiepNhanHopDong TiepNhanHopDongScreen = new frmTiepNhanHopDong();
            TiepNhanHopDongScreen.Show();
            TiepNhanHopDongScreen.FormClosed += FrmTNHD_FormClosed;
        }

        private void FrmTNHD_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnXem_Click(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        public event EventHandler TroVeMain;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            TroVeMain(this, new EventArgs());
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = business.load();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (business.suaHopDong(txtMaHD.Text, txtMaKH.Text, txtTongTK.Text, txtChiPhi.Text, txtNgayDK.Text,txtNgayDKHD.Text))
            {
                MessageBox.Show("Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnCapNhat.Enabled = false;
            Refresh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (business.xoaHopDong(txtMaHD.Text))
            {
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            /* 
            if ( dataGridView1.CurrentRow == null)
            {
                btnXoa.Enabled = false;
            }
            */
            begin();
            btnXem_Click(sender, e);
        }

        private void begin()
        {
            txtMaKH.Text = null;
            txtMaHD.Text = null;
            txtNgayDK.Text = null;
            txtTongTK.Text = null;
            txtChiPhi.Text = null;
            txtNgayDKHD.Text = null;
        }

        private void frmQuanLyHopDong_Load(object sender, EventArgs e)
        {

        }

        private void btDanhSachCho_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = business.xemDanhSachCho();
        }

        private void btKyNhanThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void hopDongBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
                txtMaHD.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtMaKH.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtNgayDK.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtTongTK.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtChiPhi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                 // Do Ngày ký HD không có, null nên convert ta string ko dc nên phải sử dụng gián tiếp
                 DateTime tempNgayKyHD = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value);
                txtNgayDKHD.Text = (tempNgayKyHD == DateTime.MinValue ? "" : tempNgayKyHD.ToString());
                btnXoa.Enabled = true;
                btnCapNhat.Enabled = true;
                if (txtNgayDKHD.Text.Length == 0)
                {
                txtNgayDKHD.Text = "mm/dd/yyyy";
                txtNgayDKHD.ForeColor = Color.Gray;
                }
                else
                {
                btTaoTaiKhoan.Enabled = true;
                txtNgayDKHD.ForeColor = Color.Black;
                }
        }

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {

        }

        private void txtNgayDKHD_TextChanged(object sender, EventArgs e)
        {

              txtNgayDKHD.ForeColor = Color.Black;
        }

        private void btInHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void btTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            frmTiepNhanTaiKhoan frmTNTK = new frmTiepNhanTaiKhoan(txtMaHD.Text);
            frmTNTK.Show();
            frmTNTK.FormClosed += frmTNTK_FormClosed;
        }

        private void txtNgayDKHD_Click(object sender, EventArgs e)
        {
            if (txtNgayDKHD.Text == "mm/dd/yyyy" || txtNgayDKHD.Text.Length == 0)
            {
                txtNgayDKHD.Clear();
                txtNgayDKHD.ForeColor = Color.Black;
            }
        }

        private void txtNgayDKHD_Leave(object sender, EventArgs e)
        {
            if (txtNgayDKHD.Text.Length == 0)
            {
                txtNgayDKHD.Text = "mm/dd/yyyy";
                txtNgayDKHD.ForeColor = Color.Gray;
            }
        }
    }
}
