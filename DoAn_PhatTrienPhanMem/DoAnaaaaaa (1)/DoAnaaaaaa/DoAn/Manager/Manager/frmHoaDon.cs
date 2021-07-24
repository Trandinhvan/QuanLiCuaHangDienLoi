using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;

namespace Manager
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        private void loadDGV()
        {
            using (QL_CHTLDataContext db = new QL_CHTLDataContext())
            {
                var hoadon = from hd in db.HOADONs
                             select new { hd.MAHD, hd.MAKH, hd.MANV, hd.NGAYBAN, hd.TAMTINH, hd.THANHTOAN, hd.GIAMGIA };
                dgv_ChiTietHang.DataSource = hoadon;
            }
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            loadDGV();
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rptHoaDon rpt = new rptHoaDon();
            rpt.FilterString = "[MAHD] = '" + txtMaHD.Text + "'";
            rpt.CreateDocument();
            rpt.ShowPreviewDialog();
        }

        private void dgv_ChiTietHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          using (QL_CHTLDataContext db = new QL_CHTLDataContext())
            {
                txtMaHD.Text = dgv_ChiTietHang.SelectedRows[0].Cells[0].Value.ToString();
                dateTimePicker_NgayLapHD.Value = (DateTime)dgv_ChiTietHang.SelectedRows[0].Cells[3].Value;
                txtMaNV.Text = dgv_ChiTietHang.SelectedRows[0].Cells[2].Value.ToString();
                txtTenNV.Text = db.NHANVIENs.Where(nv => nv.DIENTHOAI == txtMaNV.Text).Select(t => t.TENNV).FirstOrDefault();
                txtMaKH.Text = dgv_ChiTietHang.SelectedRows[0].Cells[1].Value.ToString();
                txtTenKH.Text = db.KHACHes.Where(nv => nv.DIENTHOAI == txtMaKH.Text).Select(t => t.TENKH).FirstOrDefault();
          }
            
        }

        private void dgv_ChiTietHang_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void frmHoaDon_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.trangchinh.Show();
        }
    }
}
