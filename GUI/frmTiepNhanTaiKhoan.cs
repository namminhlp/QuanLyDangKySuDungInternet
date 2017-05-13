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
    public partial class frmTiepNhanTaiKhoan : Form
    {
        BUS.TaiKhoanBUS business = new BUS.TaiKhoanBUS();
        public frmTiepNhanTaiKhoan()
        {
            InitializeComponent();
            this.AcceptButton = btnAccept;
        }
        public frmTiepNhanTaiKhoan(string MaHD)
        {
            InitializeComponent();
            this.AcceptButton = btnAccept;
            txtMaHD.Text = MaHD;
            txtMaHD.Enabled = false;
            txtTrangThai.Enabled = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (business.checkSoLuong(txtMaHD.Text) == false)
            {
                MessageBox.Show("Hợp đồng đã đủ số lượng tài khoản", "Thông báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);

            }
            else
            {
                if (business.themTaiKhoan(txtTenTruyCap.Text, txtMatKhauTTC.Text, txtMaHD.Text, txtEmail.Text, txtDCCD.Text, txtDCTT.Text))
                {
                    MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        private void frmTiepNhanTaiKhoan_Load(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
