using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Manager
{
    public partial class UCKhachHang : UserControl
    {
        public UCKhachHang()
        {
            InitializeComponent();
        }
        private static UCKhachHang _instance;
        public static UCKhachHang Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCKhachHang();
                return _instance;
            }
        }

        private void UCKhachHang_Load(object sender, EventArgs e)
        {
            loadDuLieu();
        }
        private void loadDuLieu()
        {
            using (QL_CHTLDataContext db = new QL_CHTLDataContext())
            {
                var data = from kh in db.KHACHes
                           select new { kh.TENKH, kh.DIENTHOAI, kh.DCHI, kh.DIEMTHANHVIEN };
                dgvKhach.DataSource = data;
                dgvKhach.Rows.RemoveAt(0);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (QL_CHTLDataContext db = new QL_CHTLDataContext())
            {
                try
                {
                    if (txtsdt.Text.Trim().Length == 10 && txtten.Text != "" && txtdiachi.Text != "" && txtmk.Text != "")
                    {
                        KHACH kh = new KHACH();
                        kh.DIENTHOAI = txtsdt.Text.Trim();
                        kh.TENKH = txtten.Text;
                        kh.DCHI = txtdiachi.Text;
                        kh.DIEMTHANHVIEN = 0;
                        kh.MK = txtmk.Text;
                        db.KHACHes.InsertOnSubmit(kh);
                        db.SubmitChanges();
                        MessageBox.Show("Thêm thành công");
                        loadDuLieu();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Khách hàng đã tồn tại hoặc dữ liệu quá dài, không đúng!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (QL_CHTLDataContext db = new QL_CHTLDataContext())
            {
                KHACH kh = db.KHACHes.Where(t => t.DIENTHOAI == txtsdt.Text.Trim()).FirstOrDefault();
                if (kh == null)
                {
                    MessageBox.Show("Không tồn tại khách hàng này");
                    return;
                }
                DialogResult kt = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kt == DialogResult.Yes)
                {
                    try
                    {
                        db.KHACHes.DeleteOnSubmit(kh);
                        db.SubmitChanges();
                        MessageBox.Show("Xóa thành công");
                        loadDuLieu();
                    }
                    catch
                    {
                        MessageBox.Show("Không xóa được khách hàng này");
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (QL_CHTLDataContext db = new QL_CHTLDataContext())
            {
                KHACH kh = db.KHACHes.Where(t => t.DIENTHOAI == txtsdt.Text.Trim()).FirstOrDefault();
                if (kh == null)
                {
                    MessageBox.Show("Không tồn tại khách hàng này");
                    return;
                }
                DialogResult kt = MessageBox.Show("Bạn có chắc muốn sửa địa chỉ khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kt == DialogResult.Yes)
                {
                    try
                    {
                        kh.DCHI = txtdiachi.Text;
                        db.SubmitChanges();
                        MessageBox.Show("Sửa thành công");
                        loadDuLieu();
                    }
                    catch
                    {
                        MessageBox.Show("Không sửa được thông tin khách hàng này");
                    }
                }
            }
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtten_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122 || e.KeyChar == 8));
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Họ tên phải là kí tự chữ ", "Thông Báo ");
            } 
        }

        private void txtsdt_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length !=10)
            {
                this.errorProvider1.SetError(ctr, "SDT có 10 chữ số");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void dgvKhach_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvKhach.ClearSelection();
            txtdiachi.Clear();
            txtdiem.Clear();
            txtmk.Clear();
            txtsdt.Clear();
            txtten.Clear();
        }


        private void dgvKhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtten.Text = dgvKhach.SelectedRows[0].Cells[0].Value.ToString();
            txtsdt.Text = dgvKhach.SelectedRows[0].Cells[1].Value.ToString();
            txtdiachi.Text = dgvKhach.SelectedRows[0].Cells[2].Value.ToString();
            txtdiem.Text = dgvKhach.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAdmin ad = new frmAdmin();
            this.Hide();
            ad.Show();
        }
    }
}
