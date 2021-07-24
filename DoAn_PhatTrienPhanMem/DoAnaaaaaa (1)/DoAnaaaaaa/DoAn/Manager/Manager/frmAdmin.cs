using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnKhangHang_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UCKhachHang.Instance))
            {
                panel1.Controls.Add(UCKhachHang.Instance);
                UCKhachHang.Instance.Dock = DockStyle.Fill;
                UCKhachHang.Instance.BringToFront();
            }
            else
                UCKhachHang.Instance.BringToFront();
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UCNhanVien.Instance))
            {
                panel1.Controls.Add(UCNhanVien.Instance);
                UCNhanVien.Instance.Dock = DockStyle.Fill;
                UCNhanVien.Instance.BringToFront();
            }
            else
                UCNhanVien.Instance.BringToFront();
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            frmHangHoa hh = new frmHangHoa();
            hh.Show();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            FormRP rp = new FormRP();
            rp.Show();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UCNhapHang.Instance))
            {
                panel1.Controls.Add(UCNhapHang.Instance);
                UCNhapHang.Instance.Dock = DockStyle.Fill;
                UCNhapHang.Instance.BringToFront();
            }
            else
                UCNhapHang.Instance.BringToFront();
        }

        private void frmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.trangchinh.Show();
        }
    }
}
