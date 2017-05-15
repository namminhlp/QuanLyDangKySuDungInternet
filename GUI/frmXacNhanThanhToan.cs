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
    public partial class frmXacNhanThanhToan : Form
    {
        public frmXacNhanThanhToan()
        {
            InitializeComponent();
            this.AcceptButton = btXacNhan;
        }
        public delegate void xacnhan(string HinhThucTT);
        public event xacnhan xacnhanEvent;
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            string HinhThucTT = txtHinhThucTT.Text;
            if (string.IsNullOrEmpty(HinhThucTT))
            {
                MessageBox.Show("Vui lòng chọn hình thức thanh toán", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (xacnhanEvent != null)
            {
                xacnhanEvent(HinhThucTT);  
                Close();
            }
            else
            {
                Close();
            }
        }

            

        private void btHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmXacNhanThanhToan_Load(object sender, EventArgs e)
        {

        }
    }
}
