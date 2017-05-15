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
            dataGridView1.DataSource = business.load();
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
            
        }
    }
}
