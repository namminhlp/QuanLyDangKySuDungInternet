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
    public partial class frmChiTietTruyCap : Form
    {
        BUS.ChiTiet_TruyCapBUS business = new BUS.ChiTiet_TruyCapBUS();
        public frmChiTietTruyCap()
        {
            InitializeComponent();

        }
        public frmChiTietTruyCap(string MaPhieuBao)
        {
            dataGridView1.DataSource = business.xemChiTietTruyCap(MaPhieuBao);
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
