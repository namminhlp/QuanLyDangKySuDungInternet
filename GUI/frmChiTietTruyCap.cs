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
    public partial class frmChiTietTruyCap : Form
    {
        TaiKhoanBUS business = new TaiKhoanBUS();
        public frmChiTietTruyCap()
        {
            InitializeComponent();
        }
        public frmChiTietTruyCap(string TenTruyCap)
        {
            InitializeComponent();
            textBox1.Text = "Thông tin chi tiết truy cập của tài khoản " + TenTruyCap + "";
            textBox1.Enabled = false;
            // dataGridView1.DataSource = business.xemChiTietTruyCap(TenTruyCap);

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void brThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
