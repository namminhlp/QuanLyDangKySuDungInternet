using System;
using System.Windows.Forms;
using BUS;
using System.Drawing;

namespace GUI
{
    public partial class frmQuanLyKhachHang : Form
    {
        KhachHangBUS business = new KhachHangBUS();

        public frmQuanLyKhachHang()
        {
            InitializeComponent();
            dataGridView1.DataSource = business.xemTatCa();
            btXoaKH.Enabled = false;
            btCapNhat.Enabled = false;
            btLapHopDong.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = business.xemTatCa();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaKH.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtHoTen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtDiaChi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtCMND.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtLoaiKH.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtSDT.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                btXoaKH.Enabled = true;
                btCapNhat.Enabled = true;
                btLapHopDong.Enabled = true;
            }
            catch (Exception)
            {

            }
        }

        private void btThemKH_Click(object sender, EventArgs e)
        {
            frmTiepNhanKhachHang frmTNKH = new frmTiepNhanKhachHang();
            frmTNKH.Show();
            frmTNKH.FormClosed += FrmTNKH_FormClosed;
        }

        private void FrmTNKH_FormClosed(object sender, FormClosedEventArgs e)
        {
            button1_Click_1(sender, e);
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            if (business.suaKhachHang(txtMaKH.Text, txtHoTen.Text, txtDiaChi.Text, txtCMND.Text, txtLoaiKH.Text, int.Parse(txtSDT.Text)))
            {
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                MessageBox.Show("Cập nhật dữ liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (dataGridView1.CurrentRow == null)
            {
                btCapNhat.Enabled = false;
                btXoaKH.Enabled = false;
            }
            btCapNhat.Enabled = false;
            btXoaKH.Enabled = false;
            begin();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            txtMaKH.Enabled = false;
            txtMaKH.BackColor = Color.White;
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btXoaKH_Click_1(object sender, EventArgs e)
        {
            if (business.xoaKhachHang(txtMaKH.Text))
            {
                MessageBox.Show("Xóa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                MessageBox.Show("Xóa dữ liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            btXoaKH.Enabled = false;
            btCapNhat.Enabled = false;
            begin();
            button1_Click_1(sender, e);
        }

        public event EventHandler TroVeMain;
        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            TroVeMain(this, new EventArgs());
        }

        private void begin()
        {
            txtMaKH.Text = null;
            txtHoTen.Text = null;
            txtDiaChi.Text = null;
            txtCMND.Text = null;
            txtLoaiKH.Text = null;
            txtSDT.Text = null;
        }

        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btLapHopDong_Click(object sender, EventArgs e)
        {
            frmTiepNhanHopDong TiepNhanHopDongScreen = new frmTiepNhanHopDong(txtMaKH.Text);
            TiepNhanHopDongScreen.Show();
            TiepNhanHopDongScreen.FormClosed += TiepNhanHopDongScreen_FormClosed;

        }

        private void TiepNhanHopDongScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            button1_Click_1(sender, e);
        }
    }
}
