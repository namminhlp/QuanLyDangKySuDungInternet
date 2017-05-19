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
    public partial class frmDangKyOnline : Form
    {
        public frmDangKyOnline()
        {
            InitializeComponent();
            lbHeader.BackColor = ColorTranslator.FromHtml("#2B569A");
            btExit.BackColor = ColorTranslator.FromHtml("#2B569A");
            btMinimized.BackColor = ColorTranslator.FromHtml("#2B569A");
            btDongY.BackColor = ColorTranslator.FromHtml("#2B569A");
            btHuy.BackColor = ColorTranslator.FromHtml("#2B569A");
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmDangKyOnline_Load(object sender, EventArgs e)
        {
            
        }

        private void btDongY_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text.ToString() == String.Empty)
                    {
                        c.Focus();
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
                        return;
                    }
                }
            }
            // Nếu textbox không rỗng, bắt đầu thêm khách hàng và hợp đồng

            BUS.KhachHangBUS busKH = new BUS.KhachHangBUS();
            BUS.HopDongBUS busHD = new BUS.HopDongBUS();
            string tempMaKH = busKH.sinhMaTuDong();
            if (busKH.themKhachHang(tempMaKH, txtHoTen.Text, txtDiaChi.Text, txtCMND.Text, txtLoaiKH.Text, txtSDT.Text))
            {
                bool checkHD = busHD.themHopDong(busHD.sinhMaTuDong(), tempMaKH, txtTongTK.Text, "100000", Convert.ToString(DateTime.Now));
                if (checkHD == false)
                {
                    MessageBox.Show("Thêm được khách hàng nhưng hợp đồng thất bại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("Thêm hợp đồng thất bại !!!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }

        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btMinimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
