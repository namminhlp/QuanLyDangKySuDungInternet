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
    public partial class frmTiepNhanHopDong : Form
    {
        BUS.HopDongBUS business = new BUS.HopDongBUS();
        public frmTiepNhanHopDong()
        {
            InitializeComponent();
            this.AcceptButton = btnOK;

        }
        public frmTiepNhanHopDong(string MaKH)
        {
            InitializeComponent();
            this.AcceptButton = btnOK;
            txtMaKH.Text = MaKH;
            txtMaKH.Enabled = false;
            txtNgayKyHD.Enabled = false;
            txtNgayDK.Text = "mm/dd/yyyy";
            txtNgayDK.ForeColor = Color.Gray;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (business.themHopDong(txtMaHD.Text, txtMaKH.Text, txtTongTK.Text, txtChiPhi.Text,txtNgayDK.Text))
            {
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNgayDKHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNgayDKHD_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtNgayDKHD_Click_1(object sender, EventArgs e)
        {
           /*  txtNgayKyHD.Clear();
            txtNgayKyHD.ForeColor = Color.Black; */
        }

        private void txtNgayDKHD_Leave(object sender, EventArgs e)
        {
            /* txtNgayKyHD.Text = "mm/dd/yyyy";
            txtNgayKyHD.ForeColor = Color.Gray; */
        } 

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmTiepNhanHopDong_Load(object sender, EventArgs e)
        {

        }

        private void txtNgayDK_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNgayDK_Click(object sender, EventArgs e)
        {
            txtNgayDK.Clear();
            txtNgayDK.ForeColor = Color.Black;
        }

        private void txtNgayDK_Leave(object sender, EventArgs e)
        {
            if (txtNgayDK.Text.Length == 0)
            {
                txtNgayDK.Text = "mm/dd/yyyy";
                txtNgayDK.ForeColor = Color.Gray;
            }
            else
            {
                txtNgayDK.ForeColor = Color.Black;
            }
        }
    }
}
