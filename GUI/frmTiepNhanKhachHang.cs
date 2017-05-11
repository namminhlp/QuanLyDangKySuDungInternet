using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
namespace GUI
{
    public partial class frmTiepNhanKhachHang : Form
    {
        BUS.KhachHangBUS business = new BUS.KhachHangBUS();
        public frmTiepNhanKhachHang()
        {
            InitializeComponent();
            this.AcceptButton = btnAccept;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void frmTiepNhanKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (business.themKhachHang(txtMaKH.Text, txtHoTen.Text, txtDiaChi.Text, txtCMND.Text, txtLoaiKH.Text, txtSDT.Text))
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
