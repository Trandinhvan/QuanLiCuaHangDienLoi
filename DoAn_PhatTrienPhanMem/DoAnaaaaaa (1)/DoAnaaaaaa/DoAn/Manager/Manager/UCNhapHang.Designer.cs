namespace Manager
{
    partial class UCNhapHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNhaphang = new System.Windows.Forms.Button();
            this.dgvHang = new System.Windows.Forms.DataGridView();
            this.MAHG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANCC1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_PhieuNhap = new System.Windows.Forms.DataGridView();
            this.TinhTrang1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboTT = new System.Windows.Forms.ComboBox();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuNhap)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNhaphang
            // 
            this.btnNhaphang.BackColor = System.Drawing.Color.Transparent;
            this.btnNhaphang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhaphang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNhaphang.Image = global::Manager.Properties.Resources.icons8_shopping_basket_add_100;
            this.btnNhaphang.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhaphang.Location = new System.Drawing.Point(488, 22);
            this.btnNhaphang.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhaphang.Name = "btnNhaphang";
            this.btnNhaphang.Size = new System.Drawing.Size(182, 62);
            this.btnNhaphang.TabIndex = 76;
            this.btnNhaphang.Text = "Nhập hàng";
            this.btnNhaphang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhaphang.UseVisualStyleBackColor = false;
            this.btnNhaphang.Click += new System.EventHandler(this.btnNhaphang_Click);
            // 
            // dgvHang
            // 
            this.dgvHang.AllowUserToAddRows = false;
            this.dgvHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHG,
            this.TENHG,
            this.DVT,
            this.SoLuong,
            this.MANCC1,
            this.DonGia,
            this.TinhTrang});
            this.dgvHang.Location = new System.Drawing.Point(10, 55);
            this.dgvHang.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvHang.MultiSelect = false;
            this.dgvHang.Name = "dgvHang";
            this.dgvHang.ReadOnly = true;
            this.dgvHang.RowTemplate.Height = 24;
            this.dgvHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHang.Size = new System.Drawing.Size(793, 141);
            this.dgvHang.TabIndex = 14;
            this.dgvHang.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHang_CellMouseDoubleClick);
            // 
            // MAHG
            // 
            this.MAHG.DataPropertyName = "MAHG";
            this.MAHG.HeaderText = "Mã Hàng";
            this.MAHG.Name = "MAHG";
            this.MAHG.ReadOnly = true;
            // 
            // TENHG
            // 
            this.TENHG.DataPropertyName = "TENHG";
            this.TENHG.HeaderText = "Tên Hàng";
            this.TENHG.Name = "TENHG";
            this.TENHG.ReadOnly = true;
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "Đơn vị tính";
            this.DVT.Name = "DVT";
            this.DVT.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SOLUONG";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // MANCC1
            // 
            this.MANCC1.DataPropertyName = "MANCC";
            this.MANCC1.HeaderText = "MÃ NCC";
            this.MANCC1.Name = "MANCC1";
            this.MANCC1.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DONGIA";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TINHTRANG";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            // 
            // DonGia1
            // 
            this.DonGia1.DataPropertyName = "DONGIA";
            this.DonGia1.HeaderText = "Đơn giá";
            this.DonGia1.Name = "DonGia1";
            // 
            // MANCC
            // 
            this.MANCC.DataPropertyName = "MANCC";
            this.MANCC.HeaderText = "MÃ NCC";
            this.MANCC.Name = "MANCC";
            // 
            // SL
            // 
            this.SL.DataPropertyName = "SOLUONG";
            this.SL.HeaderText = "Số lượng";
            this.SL.Name = "SL";
            // 
            // DVTinh
            // 
            this.DVTinh.DataPropertyName = "DVT";
            this.DVTinh.HeaderText = "Đơn vị tính";
            this.DVTinh.Name = "DVTinh";
            // 
            // TENHANG
            // 
            this.TENHANG.DataPropertyName = "TENHG";
            this.TENHANG.HeaderText = "Tên Hàng";
            this.TENHANG.Name = "TENHANG";
            // 
            // MAHANG
            // 
            this.MAHANG.DataPropertyName = "MAHG";
            this.MAHANG.HeaderText = "Mã Hàng";
            this.MAHANG.Name = "MAHANG";
            // 
            // dgv_PhieuNhap
            // 
            this.dgv_PhieuNhap.AllowUserToAddRows = false;
            this.dgv_PhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHANG,
            this.TENHANG,
            this.DVTinh,
            this.SL,
            this.MANCC,
            this.DonGia1,
            this.TinhTrang1});
            this.dgv_PhieuNhap.Location = new System.Drawing.Point(3, 19);
            this.dgv_PhieuNhap.MultiSelect = false;
            this.dgv_PhieuNhap.Name = "dgv_PhieuNhap";
            this.dgv_PhieuNhap.Size = new System.Drawing.Size(800, 156);
            this.dgv_PhieuNhap.TabIndex = 0;
            // 
            // TinhTrang1
            // 
            this.TinhTrang1.DataPropertyName = "TINHTRANG";
            this.TinhTrang1.HeaderText = "Tình Trạng";
            this.TinhTrang1.Name = "TinhTrang1";
            // 
            // cboTT
            // 
            this.cboTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTT.FormattingEnabled = true;
            this.cboTT.Location = new System.Drawing.Point(625, 20);
            this.cboTT.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboTT.Name = "cboTT";
            this.cboTT.Size = new System.Drawing.Size(167, 27);
            this.cboTT.TabIndex = 13;
            this.cboTT.SelectedIndexChanged += new System.EventHandler(this.cboTT_SelectedIndexChanged);
            // 
            // cboNCC
            // 
            this.cboNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(124, 20);
            this.cboNCC.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(390, 27);
            this.cboNCC.TabIndex = 13;
            this.cboNCC.SelectedIndexChanged += new System.EventHandler(this.cboNCC_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_PhieuNhap);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(27, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(809, 181);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng thông tin phiếu nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(63, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 38);
            this.label1.TabIndex = 74;
            this.label1.Text = "NHẬP HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tình trạng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhà cung cấp";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHang);
            this.groupBox1.Controls.Add(this.cboTT);
            this.groupBox1.Controls.Add(this.cboNCC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(27, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 206);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // UCNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNhaphang);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCNhapHang";
            this.Size = new System.Drawing.Size(872, 557);
            this.Load += new System.EventHandler(this.UCNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuNhap)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNhaphang;
        private System.Windows.Forms.DataGridView dgvHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANCC1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHANG;
        private System.Windows.Forms.DataGridView dgv_PhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang1;
        private System.Windows.Forms.ComboBox cboTT;
        private System.Windows.Forms.ComboBox cboNCC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
