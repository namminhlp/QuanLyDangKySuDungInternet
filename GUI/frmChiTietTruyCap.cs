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
            txtThongBao.Enabled = false;
            txtThongBao.Text = "Chi tiết truy cập của tài khoản " + TenTruyCap + "";
            txtThongBao.ForeColor = Color.Brown;
            dataGridView1.DataSource = business.xemChiTietTruyCap(TenTruyCap);
        }
        private void lbTenTruyCap_Click(object sender, EventArgs e)
        {

        }

        private void frmChiTietTruyCap_Load(object sender, EventArgs e)
        {

        }

        private void txtThongBao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
