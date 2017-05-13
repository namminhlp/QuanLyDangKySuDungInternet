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
    public partial class frmQuanLyTaiKhoan : Form
    {
        BUS.TaiKhoanBUS business = new BUS.TaiKhoanBUS();

        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
            dataGridView1.DataSource = business.load();
            btXemChiTietTruyCap.Enabled = false;

        }

        public event EventHandler TroVeMain;
        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            TroVeMain(this, new EventArgs());
        }

        private void btnTiepNhan_Click(object sender, EventArgs e)
        {
            frmTiepNhanTaiKhoan TNTK = new frmTiepNhanTaiKhoan();
            TNTK.Show();
            TNTK.FormClosed += FrmTNTK_FormClosed;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = business.load();
        }

        private void FrmTNTK_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnXem_Click(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (business.xoaTaiKhoan(txtTenTruyCap.Text))
            {
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            begin();
            btnXem_Click(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtTenTruyCap.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtMatKhauTTC.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtMaHD.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtDCCD.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtDCTT.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtTrangThai.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                btnXoa.Enabled = true;
                btnCapNhat.Enabled = true;
                btXemChiTietTruyCap.Enabled = true;
            }
            catch (Exception)
            {

            }
        }

        private void begin()
        {
            txtTenTruyCap.Text = null;
            txtTrangThai.Text = null;
            txtMatKhauTTC.Text = null;
            txtEmail.Text = null;
            txtDCTT.Text = null;
            txtDCCD.Text = null;
            txtMaHD.Text = null;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (business.suaTaiKhoan(txtTenTruyCap.Text, txtMatKhauTTC.Text, txtMaHD.Text, txtEmail.Text, txtDCCD.Text, txtDCTT.Text, txtTrangThai.Text))
            {
                MessageBox.Show("Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (dataGridView1.CurrentRow == null)
            {
                btnCapNhat.Enabled = false;
            }
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            begin();
            Refresh();
        }

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {   
        }

        private void comboBox1_DropDownStyleChanged(object sender, EventArgs e)
        {

        }

        private void btChuaKichHoat_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = business.xemChuaKichHoat();

        }
        private void frmCTTC_FormClosed (object sender, EventArgs e)
        {

        }
        private void btXemChiTietTruyCap_Click(object sender, EventArgs e)
        {
            frmChiTietTruyCap frmCTTC = new frmChiTietTruyCap(txtTenTruyCap.Text);
            frmCTTC.Show();
            frmCTTC.FormClosed += frmCTTC_FormClosed;
        }
    }
}
