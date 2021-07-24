using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;
using System.Configuration;
using DAL;
using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
using System.Text.RegularExpressions;
namespace Manager
{
    public partial class Form1 : Form
    {
        XuLy xuly = new XuLy();
        APINhanDien nhandienTV = new APINhanDien();
        string sdtnv;
        List<string> lstGioHang;
        int MaHoaDon;
        public static Form1 trangchinh;
        public Form1()
        {
            InitializeComponent();
            trangchinh = this;
        }
        public Form1(string sdt)
        {
            InitializeComponent();
            this.sdtnv = sdt;
            trangchinh = this;
        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {
            if (txtTenSP.Text == "")
            {
                txtMaSP.Enabled = true;
            }
            else
                txtMaSP.Enabled = false;
            using (QL_CHTLDataContext db = new QL_CHTLDataContext())
            {
                var link = from hg in db.HANGs
                           join ncc in db.NHACCs on hg.MANCC equals ncc.MANCC
                           where hg.TENHG.Contains(txtTenSP.Text)
                           select new { hg.MAHG, hg.TENHG, hg.DVT, hg.SOLUONG, ncc.TENNCC, hg.DONGIA, hg.TINHTRANG, hg.ANH };


                dgvHang.DataSource = link;
                
            }
            dgvHang.Columns[7].Visible = false;
            
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "")
                txtTenSP.Enabled = true;
            else
                txtTenSP.Enabled = false;
            using (QL_CHTLDataContext db = new QL_CHTLDataContext())
            {
                //var link = from hg in db.HANGs
                           
                //           where hg.MAHG.ToString().Contains(txtMaSP.Text) 
                //           select new { hg.MAHG, hg.TENHG, hg.DVT, hg.SOLUONG, hg.MANCC, hg.DONGIA, hg.TINHTRANG,hg.ANH };
                var link1 = from hg in db.HANGs
                           join ncc in db.NHACCs on hg.MANCC equals ncc.MANCC
                           where hg.MAHG.ToString().Contains( txtMaSP.Text)
                           select new { hg.MAHG, hg.TENHG, hg.DVT, hg.SOLUONG, ncc.TENNCC, hg.DONGIA, hg.TINHTRANG, hg.ANH };
                dgvHang.DataSource = link1;
            }
            dgvHang.Columns[7].Visible = false;
            ThemSPvaoHD();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (QL_CHTLDataContext db = new QL_CHTLDataContext())
            {
                foreach (FlowLayoutPanel pn in flowLayoutPanel1.Controls)
                {
                    if (pn.Tag.ToString() == dgvHang.SelectedRows[0].Cells[0].Value.ToString())
                    {
                        MessageBox.Show("Đã có sản phẩm này rồi");
                        return;
                    }
                    if (dgvHang.SelectedRows[0].Cells[3].Value.ToString() == "0")
                    {
                        MessageBox.Show("Đã hết hàng");
                        return;
                    }
                }
                FlowLayoutPanel flowLayoutPanelnew = new FlowLayoutPanel();
                flowLayoutPanelnew.Tag = dgvHang.SelectedRows[0].Cells[0].Value.ToString();
                flowLayoutPanelnew.Size = new System.Drawing.Size(793, 100);
                flowLayoutPanel1.Controls.Add(flowLayoutPanelnew);

                //hinh
                PictureBox hinh = new PictureBox();
                hinh.Tag = dgvHang.SelectedRows[0].Cells[0].Value.ToString();
                hinh.Size = new System.Drawing.Size(107, 89);
                hinh.Location = new System.Drawing.Point(3, 3);
                flowLayoutPanelnew.Controls.Add(hinh);
                hinh.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\Images\\" + dgvHang.SelectedRows[0].Cells[7].Value.ToString());
                hinh.SizeMode = PictureBoxSizeMode.StretchImage;

                //soluong
                TextBox sl = new TextBox();
                sl.Tag = dgvHang.SelectedRows[0].Cells[0].Value.ToString();
                Panel pnSL = new Panel();
                pnSL.Tag = dgvHang.SelectedRows[0].Cells[0].Value.ToString() + "PNSL";
                pnSL.Size = new System.Drawing.Size(59, 89);
                pnSL.Controls.Add(sl);
                sl.Location = new System.Drawing.Point(14, 33);
                sl.Size = new System.Drawing.Size(25, 17);
                flowLayoutPanelnew.Controls.Add(pnSL);
                sl.Text = "1";
                sl.TextChanged += new System.EventHandler(sl_TextChanged);
                sl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(sl_KeyPress);
                sl.Leave += new System.EventHandler(this.sl_Leave);

                //dongia
                Label lbDonGia = new Label();
                lbDonGia.Tag = dgvHang.SelectedRows[0].Cells[0].Value.ToString() + "DG";
                Panel pnDG = new Panel();
                pnDG.Tag = dgvHang.SelectedRows[0].Cells[0].Value.ToString() + "PNDG";
                pnDG.Location = new System.Drawing.Point(181, 3);
                pnDG.Size = new System.Drawing.Size(147, 89);
                pnDG.Controls.Add(lbDonGia);
                lbDonGia.Location = new System.Drawing.Point(42, 33);
                lbDonGia.Size = new System.Drawing.Size(57, 17);
                flowLayoutPanelnew.Controls.Add(pnDG);
                lbDonGia.Text = dgvHang.SelectedRows[0].Cells[5].Value.ToString();

                //thanhtien
                Label lbThanhTien = new Label();
                lbThanhTien.Tag = dgvHang.SelectedRows[0].Cells[0].Value.ToString() + "TT";
                Panel pnTT = new Panel();
                pnTT.Tag = dgvHang.SelectedRows[0].Cells[0].Value.ToString() + "PNTT";
                pnTT.Location = new System.Drawing.Point(334, 3);
                pnTT.Size = new System.Drawing.Size(136, 86);
                pnTT.Controls.Add(lbThanhTien);
                flowLayoutPanelnew.Controls.Add(pnTT);
                lbThanhTien.Location = new System.Drawing.Point(31, 33);
                lbThanhTien.Size = new System.Drawing.Size(81, 17);
                lbThanhTien.Text = dgvHang.SelectedRows[0].Cells[5].Value.ToString();
                lbThanhTien.TextChanged += new System.EventHandler(lbThanhTien_TextChanged);
                //Xoa
                Button btnXoa = new Button();
                btnXoa.Image = global::Manager.Properties.Resources.icons8_delete_50;
                btnXoa.Size = new System.Drawing.Size(88, 67);
                btnXoa.Text = "Xóa";
                btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                btnXoa.UseVisualStyleBackColor = true;
                flowLayoutPanelnew.Controls.Add(btnXoa);
                btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
                btnXoa.Tag = dgvHang.SelectedRows[0].Cells[0].Value.ToString();
                //update tamtinh
                tinhTamTinh();
            }
        }
        private void sl_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text != "")
            {
                if (int.Parse(tb.Text) <= 0)
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0");
                    tb.Text = "1";
                }
                using (QL_CHTLDataContext db = new QL_CHTLDataContext())
                {
                    int? slton = db.HANGs.Where(t => t.MAHG == int.Parse(tb.Tag.ToString())).Select(sl => sl.SOLUONG).FirstOrDefault();
                    if (slton == null)
                    {
                        MessageBox.Show("Mặt hàng chưa được nhập");
                        tb.Text = "";
                        return;
                    }
                    else
                    {
                        if (slton < int.Parse(tb.Text))
                        {
                            MessageBox.Show("Mặt hàn chỉ còn " + slton);
                            tb.Text = slton.ToString();
                        }
                    }
                }
            }
            int soluong = 1;
            try
            {
                soluong = int.Parse(tb.Text);
            }
            catch
            {

            }
            double dongia = 1;
            double thanhtien = 1;
            foreach (Control pn in tb.Parent.Parent.Controls)
            {


                if (pn.Tag.ToString() == tb.Tag.ToString() + "PNDG")
                {
                    foreach (Control lb in pn.Controls)
                    {
                        if (lb.Tag.ToString() == tb.Tag.ToString() + "DG")
                            dongia = double.Parse(lb.Text);
                    }
                }
                thanhtien = soluong * dongia;
                if (pn.Tag.ToString() == tb.Tag.ToString() + "PNTT")
                {
                    foreach (Control lb in pn.Controls)
                    {
                        if (lb.Tag.ToString() == tb.Tag.ToString() + "TT")
                            lb.Text = thanhtien.ToString();
                    }
                }
            }
        }

        private void sl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void sl_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "")
            {
                tb.Text = "1";
            }
            int soluong = int.Parse(tb.Text);
            double dongia = 0;
            double thanhtien = 0;
            foreach (Control pn in tb.Parent.Parent.Controls)
            {


                if (pn.Tag.ToString() == tb.Tag.ToString() + "PNDG")
                {
                    foreach (Control lb in pn.Controls)
                    {
                        if (lb.Tag.ToString() == tb.Tag.ToString() + "DG")
                            dongia = double.Parse(lb.Text);
                    }
                }
                thanhtien = soluong * dongia;
                if (pn.Tag.ToString() == tb.Tag.ToString() + "PNTT")
                {
                    foreach (Control lb in pn.Controls)
                    {
                        if (lb.Tag.ToString() == tb.Tag.ToString() + "TT")
                            lb.Text = thanhtien.ToString();
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (QL_CHTLDataContext db = new QL_CHTLDataContext())
            {
                try
                {
                    if (db.NHANVIENs.Where(t => t.DIENTHOAI.Trim() == sdtnv.Trim()).Select(n=>n.LOAINV).FirstOrDefault()=="NHÂN VIÊN")
                    {
                        ribbonTab3.Visible = false;
                    }
                }
                catch { }
            }
            lstGioHang = new List<string>();
            FlowLayoutPanel flowLayoutPanelnew = new FlowLayoutPanel();
            flowLayoutPanelnew.Tag = "1";
            flowLayoutPanelnew.Size = new System.Drawing.Size(479, 92);
            flowLayoutPanel1.Controls.Add(flowLayoutPanelnew);
            //hinh
            PictureBox hinh = new PictureBox();
            hinh.Size = new System.Drawing.Size(107, 89);
            hinh.Location = new System.Drawing.Point(3, 3);
            flowLayoutPanelnew.Controls.Add(hinh);
            hinh.SizeMode = PictureBoxSizeMode.StretchImage;
            hinh.Tag = "2";
            //soluong
            Label sl = new Label();
            Panel pnSL = new Panel();
            pnSL.Size = new System.Drawing.Size(59, 89);
            pnSL.Controls.Add(sl);
            sl.Location = new System.Drawing.Point(14, 33);
            sl.Size = new System.Drawing.Size(25, 17);
            flowLayoutPanelnew.Controls.Add(pnSL);
            sl.Text = "SL";
            sl.Tag = "3";
            //dongia
            Label lbDonGia = new Label();
            Panel pnDG = new Panel();
            pnDG.Location = new System.Drawing.Point(181, 3);
            pnDG.Size = new System.Drawing.Size(147, 89);
            pnDG.Controls.Add(lbDonGia);
            lbDonGia.Location = new System.Drawing.Point(42, 33);
            lbDonGia.Size = new System.Drawing.Size(57, 17);
            flowLayoutPanelnew.Controls.Add(pnDG);
            lbDonGia.Text = "Đơn giá";
            lbDonGia.Tag = "3";
            pnDG.Tag = "5";
            //thanhtien
            Label lbThanhTien = new Label();
            lbThanhTien.Tag = "LBTT";
            Panel pnTT = new Panel();
            pnTT.Tag = "2";
            pnTT.Location = new System.Drawing.Point(334, 3);
            pnTT.Size = new System.Drawing.Size(136, 86);
            pnTT.Controls.Add(lbThanhTien);
            flowLayoutPanelnew.Controls.Add(pnTT);
            lbThanhTien.Location = new System.Drawing.Point(31, 33);
            lbThanhTien.Size = new System.Drawing.Size(81, 17);
            lbThanhTien.Text = "Thành tiền";
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            Button btnXoa = (Button)sender;
            foreach (Control pn in btnXoa.Parent.Parent.Controls)
            {
                if (pn.Tag.ToString() == btnXoa.Tag.ToString())
                {
                    btnXoa.Parent.Parent.Controls.Remove(pn);
                }
            }
            tinhTamTinh();
        }
        private void tinhTamTinh()
        {
            double tt = 0;
            foreach (Control pn in flowLayoutPanel1.Controls)
            {
                foreach (Control pn1 in pn.Controls)
                {
                    if (pn1.Tag == null) { pn1.Tag = ""; }
                    if (pn1.Tag.ToString().Contains("PNTT"))
                    {
                        foreach (Control lb in pn1.Controls)
                        {
                            if (lb.Text != "Thành tiền")
                            {
                                tt += double.Parse(lb.Text);
                            }
                        }
                    }
                }
            }
            txtTamTinh.Text = tt.ToString();
        }

        private void lbThanhTien_TextChanged(object sender, EventArgs e)
        {
            tinhTamTinh();
        }

        private void txtTamTinh_TextChanged(object sender, EventArgs e)
        {
            if (cbGiamGia.Checked == true)
            {
                txtThanhTien.Text = (double.Parse(txtTamTinh.Text) - double.Parse(txtGiamGia.Text)).ToString();
            }
            else
            {
                txtThanhTien.Text = (double.Parse(txtTamTinh.Text)).ToString();
            }
        }

        private void txtThanhVien_Leave(object sender, EventArgs e)
        {
            using (QL_CHTLDataContext db = new QL_CHTLDataContext())
            {
                foreach (KHACH kh in db.KHACHes.ToList())
                {
                    if (kh.DIENTHOAI.Trim() == txtThanhVien.Text.Trim())
                    {
                        txtGiamGia.Text = kh.DIEMTHANHVIEN.ToString();
                        return;
                    }
                }
                MessageBox.Show("Khách hàng không tồn tại");
                txtThanhVien.Text = "";
            }
        }

        private void cbGiamGia_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGiamGia.Checked == true)
            {
                txtThanhTien.Text = (double.Parse(txtTamTinh.Text) - double.Parse(txtGiamGia.Text)).ToString();
            }
            else
            {
                txtThanhTien.Text = (double.Parse(txtTamTinh.Text)).ToString();
            }
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {
            if (double.Parse(txtThanhTien.Text) < 0)
            {
                txtThanhTien.Text = "0";
            }
        }

       

        private void rbnn_Click(object sender, EventArgs e)
        {
            frmAdmin admin = new frmAdmin();
            admin.Show();
            this.Hide();
        }

        private void btnThanhToan_Click_1(object sender, EventArgs e)
        {
            DialogResult qd = MessageBox.Show("Xác nhận thanh toán!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (qd == DialogResult.Yes)
            {
                using (QL_CHTLDataContext db = new QL_CHTLDataContext())
                {
                    //Them hoa don
                    HOADON hd = new HOADON();
                    if (txtThanhVien.Text == "")
                    {
                        hd.MAKH = "0000000000";
                        hd.MANV = sdtnv;
                        hd.TAMTINH = 0;
                        hd.GIAMGIA = 0;
                        hd.NGAYBAN = DateTime.Today;
                    }
                    else
                    {
                        hd.MAKH = txtThanhVien.Text.Trim();
                        hd.MANV = sdtnv;
                        //hd.TAMTINH = 0;
                        if (cbGiamGia.Checked == true)
                        {
                            if (double.Parse(txtTamTinh.Text) < double.Parse(txtGiamGia.Text))
                            {
                                hd.GIAMGIA = double.Parse(txtTamTinh.Text);
                            }
                            else
                            {
                                hd.GIAMGIA = double.Parse(txtGiamGia.Text);
                            }
                            KHACH khachgiamgia = db.KHACHes.Where(t => t.DIENTHOAI.Trim() == txtThanhVien.Text.Trim()).FirstOrDefault();
                            khachgiamgia.DIEMTHANHVIEN = khachgiamgia.DIEMTHANHVIEN - (double.Parse(txtTamTinh.Text) - double.Parse(txtThanhTien.Text));
                            db.SubmitChanges();
                        }
                        hd.NGAYBAN = DateTime.Today;
                        if (cbGiamGia.Checked == false)
                            db.KHACHes.Where(t => t.DIENTHOAI.Trim() == txtThanhVien.Text.Trim()).FirstOrDefault().DIEMTHANHVIEN += double.Parse(txtThanhTien.Text) * 0.1;
                    }
                    db.HOADONs.InsertOnSubmit(hd);
                    db.SubmitChanges();

                    foreach (Control lo in flowLayoutPanel1.Controls)
                    {
                        if (lo.Tag.ToString() == "1")
                            continue;
                        else
                        {
                            CHITIETHD cthd = new CHITIETHD();
                            cthd.MAHD = hd.MAHD;
                            cthd.MAHG = int.Parse(lo.Tag.ToString());
                            foreach (Control pn in lo.Controls)
                            {
                                if (pn.Tag.ToString() == (cthd.MAHG.ToString() + "PNSL"))
                                {
                                    foreach (Control tb in pn.Controls)
                                    {
                                        cthd.SOLUONG = int.Parse(tb.Text);
                                    }
                                }
                                if (pn.Tag.ToString() == (cthd.MAHG.ToString() + "PNDG"))
                                {
                                    foreach (Control tb in pn.Controls)
                                    {
                                        cthd.DONGIA = int.Parse(tb.Text);
                                    }
                                }
                            }
                            db.CHITIETHDs.InsertOnSubmit(cthd);
                            db.SubmitChanges();
                        }
                    }
                    var hoadon = (from mahd in db.CHITIETHDs orderby mahd.MAHD descending select mahd.MAHD).FirstOrDefault();
                    MaHoaDon = hoadon;
                    MessageBox.Show("Thanh toán thành công!");
                    rptHoaDon rpt = new rptHoaDon();
                    rpt.FilterString = "[MAHD] = '" + MaHoaDon.ToString()+ "'";
                    rpt.CreateDocument();
                    rpt.ShowPreviewDialog();
                    flowLayoutPanel1.Controls.Clear();
                    txtGiamGia.Text = "0";
                    txtTamTinh.Text = "0";
                    txtTenSP.Text = "Re";
                    txtTenSP.Clear();
                    txtMaSP.Clear();
                    cbGiamGia.Checked = false;
                }
            }
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            frmHoaDon hd = new frmHoaDon();
            this.Hide();
            hd.Show();
        }

        private void rbtn_KH_Click(object sender, EventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            this.Hide();
            kh.Show();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
            if (r == DialogResult.Yes)
            {
                frmDangNhap.dangnhap.Show();
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String output = nhandienTV.getOutput();
            string[] words = output.Split(':');
            string[] words1 = words[1].Split(',');
            string strResult = Regex.Replace(words1[0], @"[^a-zA-Z0-9]", string.Empty);
            using (QL_CHTLDataContext db = new QL_CHTLDataContext())
            {
                foreach (KHACH kh in db.KHACHes.ToList())
                {
                    if (kh.DIENTHOAI.Trim() == strResult.Trim())
                    {
                        txtThanhVien.Text = strResult;
                        cbGiamGia.Checked = true;
                    }
                }
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtMaSP.Focus();
            barcode.Checked = true;

        }
        private void ThemSPvaoHD()
        {
            if (dgvHang.RowCount==1 && barcode.Checked==true)
            {
                using (QL_CHTLDataContext db = new QL_CHTLDataContext())
                {
                    foreach (FlowLayoutPanel pn in flowLayoutPanel1.Controls)
                    {
                        if (pn.Tag.ToString() == dgvHang.SelectedRows[0].Cells[0].Value.ToString())
                        {
                            MessageBox.Show("Đã có sản phẩm này rồi");
                            return;
                        }
                        if (dgvHang.SelectedRows[0].Cells[3].Value.ToString() == "0")
                        {
                            MessageBox.Show("Đã hết hàng");
                            return;
                        }
                    }
                    FlowLayoutPanel flowLayoutPanelnew = new FlowLayoutPanel();
                    flowLayoutPanelnew.Tag = dgvHang.SelectedRows[0].Cells[0].Value.ToString();
                    flowLayoutPanelnew.Size = new System.Drawing.Size(793, 100);
                    flowLayoutPanel1.Controls.Add(flowLayoutPanelnew);

                    //hinh
                    PictureBox hinh = new PictureBox();
                    hinh.Tag = dgvHang.SelectedRows[0].Cells[0].Value.ToString();
                    hinh.Size = new System.Drawing.Size(107, 89);
                    hinh.Location = new System.Drawing.Point(3, 3);
                    flowLayoutPanelnew.Controls.Add(hinh);
                    hinh.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\Images\\" + dgvHang.SelectedRows[0].Cells[7].Value.ToString());
                    hinh.SizeMode = PictureBoxSizeMode.StretchImage;

                    //soluong
                    TextBox sl = new TextBox();
                    sl.Tag = dgvHang.SelectedRows[0].Cells[0].Value.ToString();
                    Panel pnSL = new Panel();
                    pnSL.Tag = dgvHang.SelectedRows[0].Cells[0].Value.ToString() + "PNSL";
                    pnSL.Size = new System.Drawing.Size(59, 89);
                    pnSL.Controls.Add(sl);
                    sl.Location = new System.Drawing.Point(14, 33);
                    sl.Size = new System.Drawing.Size(25, 17);
                    flowLayoutPanelnew.Controls.Add(pnSL);
                    sl.Text = "1";
                    sl.TextChanged += new System.EventHandler(sl_TextChanged);
                    sl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(sl_KeyPress);
                    sl.Leave += new System.EventHandler(this.sl_Leave);

                    //dongia
                    Label lbDonGia = new Label();
                    lbDonGia.Tag = dgvHang.SelectedRows[0].Cells[0].Value.ToString() + "DG";
                    Panel pnDG = new Panel();
                    pnDG.Tag = dgvHang.SelectedRows[0].Cells[0].Value.ToString() + "PNDG";
                    pnDG.Location = new System.Drawing.Point(181, 3);
                    pnDG.Size = new System.Drawing.Size(147, 89);
                    pnDG.Controls.Add(lbDonGia);
                    lbDonGia.Location = new System.Drawing.Point(42, 33);
                    lbDonGia.Size = new System.Drawing.Size(57, 17);
                    flowLayoutPanelnew.Controls.Add(pnDG);
                    lbDonGia.Text = dgvHang.SelectedRows[0].Cells[5].Value.ToString();

                    //thanhtien
                    Label lbThanhTien = new Label();
                    lbThanhTien.Tag = dgvHang.SelectedRows[0].Cells[0].Value.ToString() + "TT";
                    Panel pnTT = new Panel();
                    pnTT.Tag = dgvHang.SelectedRows[0].Cells[0].Value.ToString() + "PNTT";
                    pnTT.Location = new System.Drawing.Point(334, 3);
                    pnTT.Size = new System.Drawing.Size(136, 86);
                    pnTT.Controls.Add(lbThanhTien);
                    flowLayoutPanelnew.Controls.Add(pnTT);
                    lbThanhTien.Location = new System.Drawing.Point(31, 33);
                    lbThanhTien.Size = new System.Drawing.Size(81, 17);
                    lbThanhTien.Text = dgvHang.SelectedRows[0].Cells[5].Value.ToString();
                    lbThanhTien.TextChanged += new System.EventHandler(lbThanhTien_TextChanged);
                    //Xoa
                    Button btnXoa = new Button();
                    btnXoa.Image = global::Manager.Properties.Resources.icons8_delete_50;
                    btnXoa.Size = new System.Drawing.Size(88, 67);
                    btnXoa.Text = "Xóa";
                    btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                    btnXoa.UseVisualStyleBackColor = true;
                    flowLayoutPanelnew.Controls.Add(btnXoa);
                    btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
                    btnXoa.Tag = dgvHang.SelectedRows[0].Cells[0].Value.ToString();
                    //update tamtinh
                    tinhTamTinh();
                    
                }
                txtMaSP.Clear();
                txtMaSP.Focus();
            }
        }
    }
}
