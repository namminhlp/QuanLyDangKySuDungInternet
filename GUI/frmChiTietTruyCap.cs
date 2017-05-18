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
            InitializeComponent();
            dataGridView1.DataSource = business.xemChiTietTruyCap(MaPhieuBao);

          
            lbHeader.Text = "Thông tin chi tiết truy cập mạng của phiếu báo " + MaPhieuBao;
            
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbHeader_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btMinimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void frmChiTietTruyCap_Load(object sender, EventArgs e)
        {

        }
    }
}
