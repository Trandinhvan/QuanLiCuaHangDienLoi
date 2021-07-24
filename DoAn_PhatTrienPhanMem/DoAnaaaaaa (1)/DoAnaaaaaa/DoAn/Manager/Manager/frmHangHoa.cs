using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Manager
{
    public partial class frmHangHoa : Form
    {
        public frmHangHoa()
        {
            InitializeComponent();
        }

       

        private void loadDGV()
        {
            using (QL_CHTLDataContext db = new QL_CHTLDataContext())
            {
                var link = from hg in db.HANGs
                           select new { hg.MAHG, hg.TENHG, hg.DVT, hg.SOLUONG, hg.MANCC, hg.DONGIA};
                dgvHang.DataSource = link;
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFIle = new OpenFileDialog();
            openFIle.Filter = openFIle.Filter = "JPG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openFIle.FilterIndex = 1;
            openFIle.RestoreDirectory = true;
            if (openFIle.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFIle.FileName;
                txtLinkAnh.Text = openFIle.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dgvHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (QL_CHTLDataContext db = new QL_CHTLDataContext())
            {
                txtMaHangHoa.Text = dgvHang.SelectedRows[0].Cells[0].Value.ToString();
                txtTenHangHoa.Text = dgvHang.SelectedRows[0].Cells[1].Value.ToString();
                txtLinkAnh.Text = System.IO.Directory.GetCurrentDirectory() + "\\Images\\" + db.HANGs.Where(t => t.MAHG == (int)dgvHang.SelectedRows[0].Cells[0].Value).Select(t => t.ANH).FirstOrDefault();
                pictureBox1.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\Images\\" + db.HANGs.Where(t => t.MAHG == (int)dgvHang.SelectedRows[0].Cells[0].Value).Select(t => t.ANH).FirstOrDefault());
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                txtDVT.Text = dgvHang.SelectedRows[0].Cells[2].Value.ToString();
                txtSoLuong.Text = dgvHang.SelectedRows[0].Cells[3].Value.ToString();
                txtDonGia.Text = dgvHang.SelectedRows[0].Cells[5].Value.ToString();
                cbMaNCC.Text = db.NHACCs.Where(y => y.MANCC == (int)dgvHang.SelectedRows[0].Cells[4].Value).Select(t => t.TENNCC).FirstOrDefault();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDonGia.Text == "" || txtDVT.Text == "" || txtLinkAnh.Text == "" || txtSoLuong.Text == "" || txtTenHangHoa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }
            using (QL_CHTLDataContext db = new QL_CHTLDataContext())
            {
                HANG hg = new HANG();
                hg.TENHG = txtTenHangHoa.Text.Trim();
                hg.MANCC = db.NHACCs.Where(t => t.TENNCC == cbMaNCC.Text).Select(h => h.MANCC).FirstOrDefault();
                hg.SOLUONG = int.Parse(txtSoLuong.Text);
                hg.DONGIA = Double.Parse(txtDonGia.Text);
                hg.DVT = txtDVT.Text;
                string[] temp = txtLinkAnh.Text.Split('\\');
                foreach (string hihi in temp)
                {
                    hg.ANH = hihi;
                }
                try
                {
                    db.HANGs.InsertOnSubmit(hg);
                    db.SubmitChanges();
                    loadDGV();
                    try
                    {
                        System.IO.File.Copy(txtLinkAnh.Text, System.IO.Directory.GetCurrentDirectory() + "\\Images\\" + hg.ANH, true);
                    }
                    catch
                    {
                        MessageBox.Show("Hình ảnh đã tồn tại sẵn");
                    }
                    MessageBox.Show("Thêm thành công");
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra");
                }
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (QL_CHTLDataContext db = new QL_CHTLDataContext())
            {
                HANG hang = db.HANGs.Where(t => t.MAHG.Equals(txtMaHangHoa.Text.Trim())).FirstOrDefault();
              
                DialogResult kt = MessageBox.Show("Bạn có chắc muốn xóa mặt hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kt == DialogResult.Yes)
                {
                    try
                    {
                        db.HANGs.DeleteOnSubmit(hang);
                        db.SubmitChanges();
                        MessageBox.Show("Xóa thành công");
                        loadDGV();
                    }
                    catch
                    {
                        MessageBox.Show("Không xóa được mặt hàng này vì tồn tại hóa đơn");
                    }
                }
            }
        }

        private void dgvHang_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtDonGia.Text == "" || txtDVT.Text == "" || txtLinkAnh.Text == "" || txtMaHangHoa.Text == "" || txtSoLuong.Text == "" || txtTenHangHoa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }
            using (QL_CHTLDataContext db = new QL_CHTLDataContext())
            {
                HANG hg = db.HANGs.Where(t => t.MAHG == int.Parse(txtMaHangHoa.Text)).FirstOrDefault();
                hg.TENHG = txtTenHangHoa.Text.Trim();
                hg.MANCC = db.NHACCs.Where(t => t.TENNCC == cbMaNCC.Text).Select(h => h.MANCC).FirstOrDefault();
                hg.SOLUONG = int.Parse(txtSoLuong.Text);
                hg.DONGIA = Double.Parse(txtDonGia.Text);
                hg.DVT = txtDVT.Text;
                string[] temp = txtLinkAnh.Text.Split('\\');
                foreach (string hihi in temp)
                {
                    hg.ANH = hihi;
                }
                try
                {
                    db.SubmitChanges();
                    loadDGV();
                    try
                    {
                        System.IO.File.Copy(txtLinkAnh.Text, System.IO.Directory.GetCurrentDirectory() + "\\Images\\" + hg.ANH, true);
                    }
                    catch
                    {
                        MessageBox.Show("Hình ảnh đã tồn tại sẵn");
                    }
                    MessageBox.Show("Sửa thành công");
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra");
                }
            }
        }

        private void cbMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (QL_CHTLDataContext db = new QL_CHTLDataContext())
            {
                if (cbMaNCC.Text == "")
                {
                    loadDGV();
                    return;
                }
                int mancc = db.NHACCs.Where(t => t.TENNCC == cbMaNCC.Text).Select(y => y.MANCC).FirstOrDefault();
                var data = from hg in db.HANGs.Where(t => t.MAHG == mancc)
                           select new { hg.MAHG, hg.TENHG, hg.DVT, hg.SOLUONG, hg.MANCC, hg.TINHTRANG };
                dgvHang.DataSource = data;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (QL_CHTLDataContext db = new QL_CHTLDataContext())
            {
                var link = from hg in db.HANGs
                           where hg.TENHG.Contains(txtTenHangHoa.Text)
                           select new { hg.MAHG, hg.TENHG, hg.DVT, hg.SOLUONG, hg.MANCC, hg.DONGIA, hg.ANH, hg.TINHTRANG };
                dgvHang.DataSource = link;
            }
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            loadDGV();
            using (QL_CHTLDataContext db = new QL_CHTLDataContext())
            {
                cbMaNCC.Items.Add("");
                foreach (string tenncc in db.NHACCs.Select(t => t.TENNCC).ToList())
                {
                    cbMaNCC.Items.Add(tenncc);
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            frmAdmin ad = new frmAdmin();
            this.Hide();
            ad.Show();
        }
    }
}