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
    public partial class frmQuanLyPhieuBao : Form
    {
        PhieuBaoBUS business = new PhieuBaoBUS();
        public frmQuanLyPhieuBao()
        {
            InitializeComponent();
            business.lapPhieuBaoTuDong();
            business.tinhCuocPhiTuDong();
            business.dinhChiTruyCap();
            dataGridView1.DataSource = business.load();
            button1.Enabled = false;
            btXacNhanThanhToan.Enabled = false;
        }
        private void frmQuanLyPhieuBao_Load(object sender, EventArgs e)
        {

        }
        public event EventHandler TroVeMain;
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDCTT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtDCCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTiepNhan_Click(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            TroVeMain(this, new EventArgs());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhieuBao.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenTruyCap.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtThangLap.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtNgayLap.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTinhTrang.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtTongTien.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            // Do Ngày TT không có, null nên convert ta string ko dc nên phải sử dụng gián tiếp
            DateTime tempNgayTT = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[6].Value);
            txtNgayTT.Text = (tempNgayTT == DateTime.MinValue ? "" : tempNgayTT.ToString());;
            //Truong hợp với hình thức thanh toán cũng tương tự
            string tempHinhThucTT = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);
            txtHinhThucTT.Text = ((tempHinhThucTT == null) ? "" : tempHinhThucTT.ToString());
            if (Convert.ToBoolean(txtTinhTrang.Text) == false )
            {
                btXacNhanThanhToan.Enabled = true;
            }

            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTest test = new frmTest(txtMaPhieuBao.Text);
            test.Show();
           
        }

        private void btDongPhiTre_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = business.dongPhiTre();
        }

        private void btXacNhanThanhToan_Click(object sender, EventArgs e)
        {
            frmXacNhanThanhToan frmTT = new frmXacNhanThanhToan();
            frmTT.Show();
            frmTT.xacnhanEvent += FrmTT_xacnhanEvent;

        }

        private void FrmTT_xacnhanEvent(string HinhThucTT)
        {
            bool TinhTrangTT = true;
            if (business.xacNhanThanhToan(txtMaPhieuBao.Text,TinhTrangTT,HinhThucTT))
            {
                MessageBox.Show("Xác nhận thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                dataGridView1.DataSource = business.load();
            }
            else
            {
                MessageBox.Show("Xác nhận thanh toán thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void dataGridView1_Leave(object sender, EventArgs e)
        {
            /*
            txtMaPhieuBao.Clear();
            txtHinhThucTT.Clear();
            txtTenTruyCap.Clear();
            txtThangLap.Clear();
            txtNgayTT.Clear();
            txtNgayLap.Clear();
            txtTinhTrang.Clear();
            txtThangLap.Clear();
            */
        }
    }
}
