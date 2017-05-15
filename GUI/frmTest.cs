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
    public partial class frmTest : Form
    {
        ChiTiet_TruyCapBUS business = new ChiTiet_TruyCapBUS();
        public frmTest()
        {
            InitializeComponent();
        }
        public frmTest(string MaPhieuBao)
        {
            InitializeComponent();

            dataGridView1.DataSource = business.load();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmTest_Load(object sender, EventArgs e)
        {

        }
    }
}
