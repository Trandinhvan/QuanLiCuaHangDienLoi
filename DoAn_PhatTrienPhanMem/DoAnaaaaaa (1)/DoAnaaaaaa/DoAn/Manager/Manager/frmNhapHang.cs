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
    public partial class frmNhapHang : Form
    {
        List<HANG> lst = new List<HANG>();
        public frmNhapHang()
        {
            InitializeComponent();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            using (QL_CHTLDataContext db = new QL_CHTLDataContext())
            {
                cboTT.Enabled = false;
                cboNCC.Items.Add("");
                foreach (string tenncc in db.NHACCs.Select(t => t.TENNCC).ToList())
                {
                    cboNCC.Items.Add(tenncc);
                }
                cboTT.Items.Add("");
                cboTT.Items.Add("CÒN HÀNG");
                cboTT.Items.Add("HẾT HÀNG");
            }
            dgv_PhieuNhap.Columns[0].ReadOnly = true;
            dgv_PhieuNhap.Columns[1].ReadOnly = true;
            dgv_PhieuNhap.Columns[2].ReadOnly = true;
            dgv_PhieuNhap.Columns[6].ReadOnly = true;
            dgv_PhieuNhap.Columns[4].ReadOnly = true;
            dgv_PhieuNhap.Columns[5].ReadOnly = true;
        }

        private void cboNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNCC.Text == "")
            {
                cboTT.Enabled = false;
            }
            else
            {
                cboTT.Enabled = true;
            }
            using (QL_CHTLDataContext db = new QL_CHTLDataContext())
            {
                if (cboTT.Text == "")
                {                    
                    var data1 = from dt in db.HANGs.Where(hang => hang.MANCC == db.NHACCs.Where(t => t.TENNCC == cboNCC.Text).Select(y => y.MANCC).FirstOrDefault())
                                select new { dt.MAHG, dt.TENHG, dt.DVT, dt.SOLUONG, dt.MANCC, dt.DONGIA, dt.TINHTRANG };
                    dgvHang.DataSource = data1;
                }
                else
                {
                    var data1 = from dt in db.HANGs.Where(hang => hang.MANCC == db.NHACCs.Where(t => t.TENNCC == cboNCC.Text).Select(y => y.MANCC).FirstOrDefault() && hang.TINHTRANG == cboTT.Text)
                                select new { dt.MAHG, dt.TENHG, dt.DVT, dt.SOLUONG, dt.MANCC, dt.DONGIA, dt.TINHTRANG };
                    dgvHang.DataSource = data1;
                }
            }
        }

        private void cboTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (QL_CHTLDataContext db = new QL_CHTLDataContext())
            {
                if (cboTT.Text == "")
                {
                    var data1 = from dt in db.HANGs.Where(hang => hang.MANCC == db.NHACCs.Where(t => t.TENNCC == cboNCC.Text).Select(y => y.MANCC).FirstOrDefault())
                                select new { dt.MAHG, dt.TENHG, dt.DVT, dt.SOLUONG, dt.MANCC, dt.DONGIA, dt.TINHTRANG };
                    dgvHang.DataSource = data1;
                }
                else
                {
                    var data1 = from dt in db.HANGs.Where(hang => hang.MANCC == db.NHACCs.Where(t => t.TENNCC == cboNCC.Text).Select(y => y.MANCC).FirstOrDefault() && hang.TINHTRANG == cboTT.Text)
                                select new { dt.MAHG, dt.TENHG, dt.DVT, dt.SOLUONG, dt.MANCC, dt.DONGIA, dt.TINHTRANG };
                    dgvHang.DataSource = data1;
                }
            }
        }

        private void dgvHang_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //HANG hg = new HANG();
            //hg.MAHG = (int)dgvHang.SelectedRows[0].Cells[0].Value;
            //hg.TENHG = dgvHang.SelectedRows[0].Cells[1].Value.ToString();
            //hg.DVT = dgvHang.SelectedRows[0].Cells[2].Value.ToString();
            //hg.SOLUONG = 0;
            //hg.MANCC = (int)dgvHang.SelectedRows[0].Cells[4].Value;
            //hg.DONGIA = (double)dgvHang.SelectedRows[0].Cells[5].Value;
            //lst.Add(hg);
            //var data = from t in lst
            //           select new { t.MAHG, t.TENHG, t.DVT, t.SOLUONG, t.MANCC, t.DONGIA };
            //dgv_PhieuNhap.DataSource = data;
            DataGridViewRow row = (DataGridViewRow)dgvHang.SelectedRows[0].Clone();
            row.Cells[0].Value = dgvHang.SelectedRows[0].Cells[0].Value;
            row.Cells[1].Value = dgvHang.SelectedRows[0].Cells[1].Value;
            row.Cells[2].Value =dgvHang.SelectedRows[0].Cells[2].Value;
            row.Cells[3].Value = 1;
            row.Cells[4].Value =dgvHang.SelectedRows[0].Cells[4].Value;
            row.Cells[5].Value = dgvHang.SelectedRows[0].Cells[5].Value;
            row.Cells[6].Value = dgvHang.SelectedRows[0].Cells[6].Value;
            dgv_PhieuNhap.Rows.Add(row);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> lst = new List<int>();
            List<int> lstPN = new List<int>();
            foreach (DataGridViewRow row in dgv_PhieuNhap.Rows)
            {
                lst.Add((int)row.Cells[4].Value);
            }
            lst=lst.Distinct().ToList();

            foreach (int i in lst)
            {
                PHIEUNHAP pn = new PHIEUNHAP();
                using (QL_CHTLDataContext db = new QL_CHTLDataContext())
                {                    
                    pn.NGAYNHAP = DateTime.Now;
                    pn.MANCC = i;
                    pn.TIENNHAP = 0;
                    db.PHIEUNHAPs.InsertOnSubmit(pn);
                    db.SubmitChanges();
                }
                lstPN.Add(pn.MAPN);
            }

            foreach (DataGridViewRow row in dgv_PhieuNhap.Rows)
            {              
                CHITIETPN pn = new CHITIETPN();
                using (QL_CHTLDataContext db = new QL_CHTLDataContext())
                {
                    pn.MAHG = (int)row.Cells[0].Value;
                    pn.SOLUONG = int.Parse(row.Cells[3].Value.ToString());
                    pn.DONGIA = (double)row.Cells[5].Value;
                    pn.TONGCONG = pn.SOLUONG * pn.DONGIA;
                    pn.MAPN = lstPN[lst.IndexOf((int)row.Cells[4].Value)];
                    db.CHITIETPNs.InsertOnSubmit(pn);
                    db.SubmitChanges();
                }
            }
            MessageBox.Show("Nhập hàng thành công");
            dgv_PhieuNhap.Rows.Clear();
            using (QL_CHTLDataContext db = new QL_CHTLDataContext())
            {
                if (cboTT.Text == "")
                {
                    var data1 = from dt in db.HANGs.Where(hang => hang.MANCC == db.NHACCs.Where(t => t.TENNCC == cboNCC.Text).Select(y => y.MANCC).FirstOrDefault())
                                select new { dt.MAHG, dt.TENHG, dt.DVT, dt.SOLUONG, dt.MANCC, dt.DONGIA, dt.TINHTRANG };
                    dgvHang.DataSource = data1;
                }
                else
                {
                    var data1 = from dt in db.HANGs.Where(hang => hang.MANCC == db.NHACCs.Where(t => t.TENNCC == cboNCC.Text).Select(y => y.MANCC).FirstOrDefault() && hang.TINHTRANG == cboTT.Text)
                                select new { dt.MAHG, dt.TENHG, dt.DVT, dt.SOLUONG, dt.MANCC, dt.DONGIA, dt.TINHTRANG };
                    dgvHang.DataSource = data1;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }             
    }
}
