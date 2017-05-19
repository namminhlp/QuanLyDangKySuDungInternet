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

            foreach (Control c in groupBox2.Controls)
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
            BUS.KhachHangBUS busKH = new BUS.KhachHangBUS();
            BUS.HopDongBUS busHD = new BUS.HopDongBUS();
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
