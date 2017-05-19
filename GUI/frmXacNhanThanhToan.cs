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
    public partial class frmXacNhanThanhToan : Form
    {
        BUS.PhieuBaoBUS business = new BUS.PhieuBaoBUS();
        string tempMaPhieu;
        public frmXacNhanThanhToan()
        {
            InitializeComponent();
        }
        public frmXacNhanThanhToan (string MaPhieuBao)
        {
            InitializeComponent();
            tempMaPhieu = MaPhieuBao;

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmXacNhanThanhToan_Load(object sender, EventArgs e)
        {

        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btDongY_Click(object sender, EventArgs e)
        {
            if (business.xacNhanThanhToan(tempMaPhieu, dateTimePicker1.Value, comboBox1.Text))
            {
                MessageBox.Show("Thanh toán thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
