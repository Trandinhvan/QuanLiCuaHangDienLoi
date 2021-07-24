namespace Manager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.barcode = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.dgvHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtThanhVien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTamTinh = new System.Windows.Forms.TextBox();
            this.cbGiamGia = new System.Windows.Forms.CheckBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.btnInHD = new System.Windows.Forms.Button();
            this.chitiethdTableAdapter1 = new Manager.QLSTDataSetTableAdapters.CHITIETHDTableAdapter();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.ribbonTab2 = new System.Windows.Forms.RibbonTab();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonTab3 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.rbnn = new System.Windows.Forms.RibbonButton();
            this.ribbonTab5 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.rbtn_KhachHang = new System.Windows.Forms.RibbonButton();
            this.rbtn_KH = new System.Windows.Forms.RibbonButton();
            this.ribbonTab6 = new System.Windows.Forms.RibbonTab();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1002, 204);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(814, 523);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.barcode);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txtMaSP);
            this.panel1.Controls.Add(this.txtTenSP);
            this.panel1.Controls.Add(this.dgvHang);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(20, 206);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 523);
            this.panel1.TabIndex = 2;
            // 
            // barcode
            // 
            this.barcode.AutoSize = true;
            this.barcode.Location = new System.Drawing.Point(792, 43);
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(83, 21);
            this.barcode.TabIndex = 38;
            this.barcode.Text = "Barcode";
            this.barcode.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(661, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 69);
            this.button2.TabIndex = 37;
            this.button2.Text = "Quét Mã";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtMaSP
            // 
            this.txtMaSP.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMaSP.Location = new System.Drawing.Point(141, 63);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaSP.Multiline = true;
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(279, 27);
            this.txtMaSP.TabIndex = 9;
            this.txtMaSP.TextChanged += new System.EventHandler(this.txtMaSP_TextChanged);
            // 
            // txtTenSP
            // 
            this.txtTenSP.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTenSP.Location = new System.Drawing.Point(144, 16);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenSP.Multiline = true;
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(277, 29);
            this.txtTenSP.TabIndex = 8;
            this.txtTenSP.TextChanged += new System.EventHandler(this.txtTenSP_TextChanged);
            // 
            // dgvHang
            // 
            this.dgvHang.AllowUserToAddRows = false;
            this.dgvHang.AllowUserToOrderColumns = true;
            this.dgvHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvHang.Location = new System.Drawing.Point(11, 106);
            this.dgvHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHang.Name = "dgvHang";
            this.dgvHang.RowTemplate.Height = 24;
            this.dgvHang.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHang.Size = new System.Drawing.Size(925, 415);
            this.dgvHang.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAHG";
            this.Column1.HeaderText = "Mã hàng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENHG";
            this.Column2.HeaderText = "Tên hàng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DVT";
            this.Column3.HeaderText = "Đơn vị tính";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SOLUONG";
            this.Column4.HeaderText = "Số lượng";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TENNCC";
            this.Column5.HeaderText = "Tên Nhà Cung Cấp";
            this.Column5.Name = "Column5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã sản  phẩm :";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.Image = global::Manager.Properties.Resources.icons8_favorite_cart_100;
            this.btnThem.Location = new System.Drawing.Point(472, 16);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(141, 73);
            this.btnThem.TabIndex = 2;
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(4, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên sản phẩm :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtThanhVien);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtThanhTien);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtTamTinh);
            this.panel2.Controls.Add(this.cbGiamGia);
            this.panel2.Controls.Add(this.txtGiamGia);
            this.panel2.Location = new System.Drawing.Point(20, 752);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(743, 106);
            this.panel2.TabIndex = 26;
            // 
            // txtThanhVien
            // 
            this.txtThanhVien.Location = new System.Drawing.Point(519, 63);
            this.txtThanhVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThanhVien.Multiline = true;
            this.txtThanhVien.Name = "txtThanhVien";
            this.txtThanhVien.Size = new System.Drawing.Size(188, 32);
            this.txtThanhVien.TabIndex = 33;
            this.txtThanhVien.Leave += new System.EventHandler(this.txtThanhVien_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(376, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 22);
            this.label5.TabIndex = 32;
            this.label5.Text = "Thành viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 22);
            this.label4.TabIndex = 30;
            this.label4.Text = "Thành tiền:";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(144, 66);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThanhTien.Multiline = true;
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(168, 29);
            this.txtThanhTien.TabIndex = 28;
            this.txtThanhTien.Text = "0";
            this.txtThanhTien.TextChanged += new System.EventHandler(this.txtThanhTien_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Tạm tính:";
            // 
            // txtTamTinh
            // 
            this.txtTamTinh.Location = new System.Drawing.Point(144, 8);
            this.txtTamTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTamTinh.Multiline = true;
            this.txtTamTinh.Name = "txtTamTinh";
            this.txtTamTinh.ReadOnly = true;
            this.txtTamTinh.Size = new System.Drawing.Size(175, 29);
            this.txtTamTinh.TabIndex = 29;
            this.txtTamTinh.Text = "0";
            this.txtTamTinh.TextChanged += new System.EventHandler(this.txtTamTinh_TextChanged);
            // 
            // cbGiamGia
            // 
            this.cbGiamGia.AutoSize = true;
            this.cbGiamGia.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbGiamGia.Location = new System.Drawing.Point(380, 14);
            this.cbGiamGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGiamGia.Name = "cbGiamGia";
            this.cbGiamGia.Size = new System.Drawing.Size(117, 26);
            this.cbGiamGia.TabIndex = 27;
            this.cbGiamGia.Text = "Giảm giá :";
            this.cbGiamGia.UseVisualStyleBackColor = true;
            this.cbGiamGia.CheckedChanged += new System.EventHandler(this.cbGiamGia_CheckedChanged);
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(519, 8);
            this.txtGiamGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiamGia.Multiline = true;
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.ReadOnly = true;
            this.txtGiamGia.Size = new System.Drawing.Size(188, 31);
            this.txtGiamGia.TabIndex = 26;
            this.txtGiamGia.Text = "0";
            // 
            // btnInHD
            // 
            this.btnInHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnInHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHD.Image = ((System.Drawing.Image)(resources.GetObject("btnInHD.Image")));
            this.btnInHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInHD.Location = new System.Drawing.Point(1597, 752);
            this.btnInHD.Margin = new System.Windows.Forms.Padding(4);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(181, 71);
            this.btnInHD.TabIndex = 34;
            this.btnInHD.Text = "In Hóa Đơn";
            this.btnInHD.UseVisualStyleBackColor = false;
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);
            // 
            // chitiethdTableAdapter1
            // 
            this.chitiethdTableAdapter1.ClearBeforeFill = true;
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Tag = null;
            this.ribbonTab1.Text = "Admin";
            this.ribbonTab1.ToolTip = null;
            this.ribbonTab1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.ribbonTab1.ToolTipImage = null;
            this.ribbonTab1.ToolTipTitle = null;
            this.ribbonTab1.Value = null;
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Tag = null;
            this.ribbonPanel1.Text = "Khach Hang";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Tag = null;
            this.ribbonPanel2.Text = "ribbonPanel2";
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Tag = null;
            this.ribbonTab2.Text = "ribbonTab2";
            this.ribbonTab2.ToolTip = null;
            this.ribbonTab2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.ribbonTab2.ToolTipImage = null;
            this.ribbonTab2.ToolTipTitle = null;
            this.ribbonTab2.Value = null;
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.RecentItemsCaption = null;
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            this.ribbon1.OrbText = null;
            // 
            // 
            // 
            this.ribbon1.QuickAcessToolbar.AltKey = null;
            this.ribbon1.QuickAcessToolbar.CheckedGroup = null;
            this.ribbon1.QuickAcessToolbar.Image = null;
            this.ribbon1.QuickAcessToolbar.Tag = null;
            this.ribbon1.QuickAcessToolbar.Text = null;
            this.ribbon1.QuickAcessToolbar.ToolTip = null;
            this.ribbon1.QuickAcessToolbar.ToolTipTitle = null;
            this.ribbon1.QuickAcessToolbar.Value = null;
            this.ribbon1.Size = new System.Drawing.Size(1828, 200);
            this.ribbon1.TabIndex = 35;
            this.ribbon1.Tabs.Add(this.ribbonTab3);
            this.ribbon1.Tabs.Add(this.ribbonTab5);
            this.ribbon1.Tabs.Add(this.ribbonTab6);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.TabSpacing = 6;
            this.ribbon1.Text = "ribbon1";
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.Panels.Add(this.ribbonPanel3);
            this.ribbonTab3.Tag = null;
            this.ribbonTab3.Text = "Admin";
            this.ribbonTab3.ToolTip = null;
            this.ribbonTab3.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.ribbonTab3.ToolTipImage = null;
            this.ribbonTab3.ToolTipTitle = null;
            this.ribbonTab3.Value = null;
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.rbnn);
            this.ribbonPanel3.Tag = null;
            this.ribbonPanel3.Text = "Quản lý";
            // 
            // rbnn
            // 
            this.rbnn.AltKey = null;
            this.rbnn.CheckedGroup = null;
            this.rbnn.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbnn.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbnn.Image = ((System.Drawing.Image)(resources.GetObject("rbnn.Image")));
            this.rbnn.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbnn.SmallImage")));
            this.rbnn.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbnn.Tag = null;
            this.rbnn.Text = null;
            this.rbnn.ToolTip = null;
            this.rbnn.ToolTipTitle = null;
            this.rbnn.Value = null;
            this.rbnn.Click += new System.EventHandler(this.rbnn_Click);
            // 
            // ribbonTab5
            // 
            this.ribbonTab5.Panels.Add(this.ribbonPanel4);
            this.ribbonTab5.Tag = null;
            this.ribbonTab5.Text = "Khách Hàng";
            this.ribbonTab5.ToolTip = null;
            this.ribbonTab5.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.ribbonTab5.ToolTipImage = null;
            this.ribbonTab5.ToolTipTitle = null;
            this.ribbonTab5.Value = null;
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Items.Add(this.rbtn_KhachHang);
            this.ribbonPanel4.Items.Add(this.rbtn_KH);
            this.ribbonPanel4.Tag = null;
            this.ribbonPanel4.Text = "Khách Hàng";
            // 
            // rbtn_KhachHang
            // 
            this.rbtn_KhachHang.AltKey = null;
            this.rbtn_KhachHang.CheckedGroup = null;
            this.rbtn_KhachHang.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtn_KhachHang.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtn_KhachHang.Image = null;
            this.rbtn_KhachHang.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtn_KhachHang.SmallImage")));
            this.rbtn_KhachHang.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtn_KhachHang.Tag = null;
            this.rbtn_KhachHang.Text = null;
            this.rbtn_KhachHang.ToolTip = null;
            this.rbtn_KhachHang.ToolTipTitle = null;
            this.rbtn_KhachHang.Value = null;
            // 
            // rbtn_KH
            // 
            this.rbtn_KH.AltKey = null;
            this.rbtn_KH.CheckedGroup = null;
            this.rbtn_KH.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbtn_KH.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbtn_KH.Image = ((System.Drawing.Image)(resources.GetObject("rbtn_KH.Image")));
            this.rbtn_KH.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtn_KH.SmallImage")));
            this.rbtn_KH.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbtn_KH.Tag = null;
            this.rbtn_KH.Text = null;
            this.rbtn_KH.ToolTip = null;
            this.rbtn_KH.ToolTipTitle = null;
            this.rbtn_KH.Value = null;
            this.rbtn_KH.Click += new System.EventHandler(this.rbtn_KH_Click);
            // 
            // ribbonTab6
            // 
            this.ribbonTab6.Tag = null;
            this.ribbonTab6.Text = null;
            this.ribbonTab6.ToolTip = null;
            this.ribbonTab6.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.ribbonTab6.ToolTipImage = null;
            this.ribbonTab6.ToolTipTitle = null;
            this.ribbonTab6.Value = null;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Image = global::Manager.Properties.Resources.icons8_money_bag_50;
            this.btnThanhToan.Location = new System.Drawing.Point(1325, 754);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(193, 71);
            this.btnThanhToan.TabIndex = 25;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click_1);
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.AltKey = null;
            this.ribbonButton1.CheckedGroup = null;
            this.ribbonButton1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.ribbonButton1.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.ribbonButton1.Image = null;
            this.ribbonButton1.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.ribbonButton1.Tag = null;
            this.ribbonButton1.Text = "ribbonButton1";
            this.ribbonButton1.ToolTip = null;
            this.ribbonButton1.ToolTipTitle = null;
            this.ribbonButton1.Value = null;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1002, 752);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 71);
            this.button1.TabIndex = 36;
            this.button1.Text = "Kiểm Tra Thành Viên";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1828, 863);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ribbon1);
            this.Controls.Add(this.btnInHD);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnThanhToan);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Trang Chính";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.DataGridView dgvHang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtThanhVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTamTinh;
        private System.Windows.Forms.CheckBox cbGiamGia;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.Button btnThanhToan;
        private QLSTDataSetTableAdapters.CHITIETHDTableAdapter chitiethdTableAdapter1;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonTab ribbonTab2;
        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab3;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonButton rbnn;
       
        private System.Windows.Forms.RibbonTab ribbonTab5;
        private System.Windows.Forms.RibbonTab ribbonTab6;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonButton rbtn_KhachHang;
        private System.Windows.Forms.RibbonButton rbtn_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox barcode;
    }
}

