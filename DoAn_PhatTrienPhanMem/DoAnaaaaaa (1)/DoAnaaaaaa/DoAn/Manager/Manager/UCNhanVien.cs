using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public partial class UCNhanVien : UserControl
    {
        public UCNhanVien()
        {
            InitializeComponent();
        }
        private static UCNhanVien _instance;
        public static UCNhanVien Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCNhanVien();
                return _instance;
            }
        }

        private void UCNhanVien_Load(object sender, EventArgs e)
        {
            loadDuLieu();
        }
        private void loadDuLieu()
        {
            using (QL_CHTLDataContext db = new QL_CHTLDataContext())
            {
                var data = from nv in db.NHANVIENs
                           where (nv.LOAINV.Equals("NHÂN VIÊN"))
                           select new { nv.TENNV, nv.DIENTHOAI, nv.NGAYLAMVIEC, nv.DCHI, nv.NGAYSINH,nv.LUONGCOBAN };
                dgv_NhanVien.DataSource = data;
            }
        }

        

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtten.Text!="" && txtma.Text != "" && txtdiachi.Text != "" && txtLuongCoBan.Text != "" && txtmk.Text != "")
                {
                    NHANVIEN nv = new NHANVIEN();
                    nv.TENNV = txtten.Text;
                    nv.DIENTHOAI = txtma.Text;
                    nv.DCHI = txtdiachi.Text;
                    nv.LOAINV = "NHÂN VIÊN";
                    nv.LUONGCOBAN = int.Parse(txtLuongCoBan.Text);
                    nv.MK = txtmk.Text;
                    nv.NGAYLAMVIEC = dateTimePicker2.Value;
                    nv.NGAYSINH = dateTimePicker1.Value;
                    using (QL_CHTLDataContext db = new QL_CHTLDataContext())
                    {
                        db.NHANVIENs.InsertOnSubmit(nv);
                        db.SubmitChanges();
                        MessageBox.Show("Thêm nhân viên thành công");
                        loadDuLieu();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
                }
            }
            catch
            {
                MessageBox.Show("Nhân viên đã tồn tại hoặc dữ liệu lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (QL_CHTLDataContext db = new QL_CHTLDataContext())
            {
                NHANVIEN nv = db.NHANVIENs.Where(t => t.DIENTHOAI.Equals(txtma.Text.Trim())).FirstOrDefault();
                if (nv == null)
                {
                    MessageBox.Show("Nhân viên không tồn tại");
                    return;
                }
                DialogResult kt = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (kt == DialogResult.Yes)
                {
                    try
                    {
                        db.NHANVIENs.DeleteOnSubmit(nv);
                        db.SubmitChanges();
                        MessageBox.Show("Xóa thành công");
                        loadDuLieu();
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa nhân viên này");
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (QL_CHTLDataContext db = new QL_CHTLDataContext())
            {
                NHANVIEN nv = db.NHANVIENs.Where(t => t.DIENTHOAI.Equals(txtma.Text.Trim())).FirstOrDefault();
                if (nv == null)
                {
                    MessageBox.Show("Nhân viên không tồn tại");
                    return;
                }
                DialogResult kt = MessageBox.Show("Bạn có chắc muốn sửa thông tin nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (kt == DialogResult.Yes)
                {
                    try
                    {
                        nv.DCHI = txtdiachi.Text;
                        nv.LUONGCOBAN = int.Parse(txtLuongCoBan.Text);
                        nv.NGAYSINH = dateTimePicker1.Value;
                        nv.NGAYLAMVIEC = dateTimePicker2.Value;
                        db.SubmitChanges();
                        MessageBox.Show("Sửa thành công");
                        loadDuLieu();
                    }
                    catch
                    {
                        MessageBox.Show("Không thể sửa thông tin nhân viên này");
                    }
                }
            }

        }

        private void txtma_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtLuongCoBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtma_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length != 10)
            {
                this.errorProvider1.SetError(ctr, "SDT có 10 chữ số");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void dgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtten.Text = dgv_NhanVien.SelectedRows[0].Cells[0].Value.ToString();
            txtma.Text = dgv_NhanVien.SelectedRows[0].Cells[1].Value.ToString();
            txtdiachi.Text = dgv_NhanVien.SelectedRows[0].Cells[3].Value.ToString();
            dateTimePicker2.Value = (DateTime)dgv_NhanVien.SelectedRows[0].Cells[2].Value;
            dateTimePicker1.Value = (DateTime)dgv_NhanVien.SelectedRows[0].Cells[4].Value;
            txtLuongCoBan.Text = dgv_NhanVien.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           txtten.Text="";
           txtma.Text = "";
           txtdiachi.Text = "";
           dateTimePicker1.Value = DateTime.Now;
           dateTimePicker2.Value = DateTime.Now;
           txtLuongCoBan.Text = "";

        }
    }
}
