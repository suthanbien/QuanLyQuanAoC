namespace QuanLyQuanAo.GUI
{
    partial class frmLapHoaDon
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
            this.components = new System.ComponentModel.Container();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.grbThongTinMatHang = new System.Windows.Forms.GroupBox();
            this.lblHeSoGiam = new System.Windows.Forms.Label();
            this.lblThongBaoGG = new System.Windows.Forms.Label();
            this.txtMaGiamGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSuaHH = new System.Windows.Forms.Button();
            this.btnLuuHH = new System.Windows.Forms.Button();
            this.btnSuDungMGG = new System.Windows.Forms.Button();
            this.btnXoaHH = new System.Windows.Forms.Button();
            this.btnThemHH = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtConLai = new System.Windows.Forms.TextBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.MaHH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tenHHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLConLaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHoaDonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classChiTietHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.btnLoadKH = new System.Windows.Forms.Button();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtLoaiGiamGia = new System.Windows.Forms.TextBox();
            this.txtLoaiKH = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.cboMKH = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.datePic = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.grbThongTinMatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classChiTietHoaDonBindingSource)).BeginInit();
            this.grbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblHoaDon);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(852, 73);
            this.pnlTop.TabIndex = 0;
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDon.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblHoaDon.Location = new System.Drawing.Point(0, 0);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(852, 73);
            this.lblHoaDon.TabIndex = 1;
            this.lblHoaDon.Text = "Hóa Đơn Bán Hàng";
            this.lblHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnDong);
            this.pnlBottom.Controls.Add(this.btnLuu);
            this.pnlBottom.Controls.Add(this.btnHuy);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 686);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(852, 67);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(729, 10);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(111, 45);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(216, 10);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(111, 45);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu Hóa Đơn";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(424, 10);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(111, 45);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy Hóa Đơn";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.grbThongTinMatHang);
            this.pnlCenter.Controls.Add(this.grbThongTin);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 73);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(852, 613);
            this.pnlCenter.TabIndex = 2;
            // 
            // grbThongTinMatHang
            // 
            this.grbThongTinMatHang.Controls.Add(this.lblHeSoGiam);
            this.grbThongTinMatHang.Controls.Add(this.lblThongBaoGG);
            this.grbThongTinMatHang.Controls.Add(this.txtMaGiamGia);
            this.grbThongTinMatHang.Controls.Add(this.label1);
            this.grbThongTinMatHang.Controls.Add(this.btnSuaHH);
            this.grbThongTinMatHang.Controls.Add(this.btnLuuHH);
            this.grbThongTinMatHang.Controls.Add(this.btnSuDungMGG);
            this.grbThongTinMatHang.Controls.Add(this.btnXoaHH);
            this.grbThongTinMatHang.Controls.Add(this.btnThemHH);
            this.grbThongTinMatHang.Controls.Add(this.label11);
            this.grbThongTinMatHang.Controls.Add(this.label10);
            this.grbThongTinMatHang.Controls.Add(this.label14);
            this.grbThongTinMatHang.Controls.Add(this.txtConLai);
            this.grbThongTinMatHang.Controls.Add(this.txtGiamGia);
            this.grbThongTinMatHang.Controls.Add(this.txtTongTien);
            this.grbThongTinMatHang.Controls.Add(this.dgvHoaDon);
            this.grbThongTinMatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbThongTinMatHang.Enabled = false;
            this.grbThongTinMatHang.Location = new System.Drawing.Point(0, 194);
            this.grbThongTinMatHang.Name = "grbThongTinMatHang";
            this.grbThongTinMatHang.Size = new System.Drawing.Size(852, 419);
            this.grbThongTinMatHang.TabIndex = 2;
            this.grbThongTinMatHang.TabStop = false;
            this.grbThongTinMatHang.Text = "Thông Tin mặt Hàng";
            // 
            // lblHeSoGiam
            // 
            this.lblHeSoGiam.AutoSize = true;
            this.lblHeSoGiam.Location = new System.Drawing.Point(654, 285);
            this.lblHeSoGiam.Name = "lblHeSoGiam";
            this.lblHeSoGiam.Size = new System.Drawing.Size(0, 17);
            this.lblHeSoGiam.TabIndex = 28;
            // 
            // lblThongBaoGG
            // 
            this.lblThongBaoGG.AutoSize = true;
            this.lblThongBaoGG.Location = new System.Drawing.Point(676, 283);
            this.lblThongBaoGG.Name = "lblThongBaoGG";
            this.lblThongBaoGG.Size = new System.Drawing.Size(0, 17);
            this.lblThongBaoGG.TabIndex = 28;
            // 
            // txtMaGiamGia
            // 
            this.txtMaGiamGia.Location = new System.Drawing.Point(492, 280);
            this.txtMaGiamGia.Name = "txtMaGiamGia";
            this.txtMaGiamGia.Size = new System.Drawing.Size(143, 22);
            this.txtMaGiamGia.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Giảm Giá";
            // 
            // btnSuaHH
            // 
            this.btnSuaHH.Enabled = false;
            this.btnSuaHH.Location = new System.Drawing.Point(118, 273);
            this.btnSuaHH.Name = "btnSuaHH";
            this.btnSuaHH.Size = new System.Drawing.Size(91, 37);
            this.btnSuaHH.TabIndex = 1;
            this.btnSuaHH.Text = "Sửa HH";
            this.btnSuaHH.UseVisualStyleBackColor = true;
            this.btnSuaHH.Click += new System.EventHandler(this.btnSuaHH_Click);
            // 
            // btnLuuHH
            // 
            this.btnLuuHH.Location = new System.Drawing.Point(22, 271);
            this.btnLuuHH.Name = "btnLuuHH";
            this.btnLuuHH.Size = new System.Drawing.Size(90, 39);
            this.btnLuuHH.TabIndex = 0;
            this.btnLuuHH.Text = "Lưu";
            this.btnLuuHH.UseVisualStyleBackColor = true;
            this.btnLuuHH.Click += new System.EventHandler(this.btnLuuSP_Click);
            // 
            // btnSuDungMGG
            // 
            this.btnSuDungMGG.Location = new System.Drawing.Point(372, 325);
            this.btnSuDungMGG.Name = "btnSuDungMGG";
            this.btnSuDungMGG.Size = new System.Drawing.Size(111, 46);
            this.btnSuDungMGG.TabIndex = 5;
            this.btnSuDungMGG.Text = "Sử dụng MGG";
            this.btnSuDungMGG.UseVisualStyleBackColor = true;
            this.btnSuDungMGG.Click += new System.EventHandler(this.btnSuDungMGG_Click);
            // 
            // btnXoaHH
            // 
            this.btnXoaHH.Enabled = false;
            this.btnXoaHH.Location = new System.Drawing.Point(215, 272);
            this.btnXoaHH.Name = "btnXoaHH";
            this.btnXoaHH.Size = new System.Drawing.Size(91, 38);
            this.btnXoaHH.TabIndex = 2;
            this.btnXoaHH.Text = "Xóa HH";
            this.btnXoaHH.UseVisualStyleBackColor = true;
            this.btnXoaHH.Click += new System.EventHandler(this.btnXoaHH_Click);
            // 
            // btnThemHH
            // 
            this.btnThemHH.Location = new System.Drawing.Point(22, 272);
            this.btnThemHH.Name = "btnThemHH";
            this.btnThemHH.Size = new System.Drawing.Size(90, 39);
            this.btnThemHH.TabIndex = 6;
            this.btnThemHH.Text = "Thêm HH";
            this.btnThemHH.UseVisualStyleBackColor = true;
            this.btnThemHH.Click += new System.EventHandler(this.btnThemHH_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(550, 381);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "Còn Lại";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(550, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Giảm Giá";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(550, 325);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 17);
            this.label14.TabIndex = 19;
            this.label14.Text = "Tổng Tiền";
            // 
            // txtConLai
            // 
            this.txtConLai.Location = new System.Drawing.Point(644, 378);
            this.txtConLai.Name = "txtConLai";
            this.txtConLai.ReadOnly = true;
            this.txtConLai.Size = new System.Drawing.Size(154, 22);
            this.txtConLai.TabIndex = 18;
            this.txtConLai.Text = "0";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(644, 350);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.ReadOnly = true;
            this.txtGiamGia.Size = new System.Drawing.Size(154, 22);
            this.txtGiamGia.TabIndex = 18;
            this.txtGiamGia.Text = "0";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(644, 322);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(154, 22);
            this.txtTongTien.TabIndex = 18;
            this.txtTongTien.Text = "0";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.AutoGenerateColumns = false;
            this.dgvHoaDon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHH,
            this.tenHHDataGridViewTextBoxColumn,
            this.sLConLaiDataGridViewTextBoxColumn,
            this.giaTienDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.tongTienDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn,
            this.maHoaDonDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dgvHoaDon.DataSource = this.classChiTietHoaDonBindingSource;
            this.dgvHoaDon.Location = new System.Drawing.Point(33, 38);
            this.dgvHoaDon.MultiSelect = false;
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(792, 223);
            this.dgvHoaDon.TabIndex = 0;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            this.dgvHoaDon.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvHoaDon_EditingControlShowing);
            // 
            // MaHH
            // 
            this.MaHH.DataPropertyName = "MaHoaDon";
            this.MaHH.HeaderText = "MaHH";
            this.MaHH.MinimumWidth = 6;
            this.MaHH.Name = "MaHH";
            this.MaHH.ReadOnly = true;
            this.MaHH.Width = 125;
            // 
            // tenHHDataGridViewTextBoxColumn
            // 
            this.tenHHDataGridViewTextBoxColumn.DataPropertyName = "TenHH";
            this.tenHHDataGridViewTextBoxColumn.HeaderText = "TenHH";
            this.tenHHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenHHDataGridViewTextBoxColumn.Name = "tenHHDataGridViewTextBoxColumn";
            this.tenHHDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenHHDataGridViewTextBoxColumn.Width = 125;
            // 
            // sLConLaiDataGridViewTextBoxColumn
            // 
            this.sLConLaiDataGridViewTextBoxColumn.DataPropertyName = "SLConLai";
            this.sLConLaiDataGridViewTextBoxColumn.HeaderText = "SLConLai";
            this.sLConLaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sLConLaiDataGridViewTextBoxColumn.Name = "sLConLaiDataGridViewTextBoxColumn";
            this.sLConLaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.sLConLaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // giaTienDataGridViewTextBoxColumn
            // 
            this.giaTienDataGridViewTextBoxColumn.DataPropertyName = "GiaTien";
            this.giaTienDataGridViewTextBoxColumn.HeaderText = "GiaTien";
            this.giaTienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaTienDataGridViewTextBoxColumn.Name = "giaTienDataGridViewTextBoxColumn";
            this.giaTienDataGridViewTextBoxColumn.ReadOnly = true;
            this.giaTienDataGridViewTextBoxColumn.Width = 125;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.ReadOnly = true;
            this.soLuongDataGridViewTextBoxColumn.Width = 125;
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
            this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.HeaderText = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            this.tongTienDataGridViewTextBoxColumn.ReadOnly = true;
            this.tongTienDataGridViewTextBoxColumn.Width = 125;
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            this.ghiChuDataGridViewTextBoxColumn.ReadOnly = true;
            this.ghiChuDataGridViewTextBoxColumn.Width = 125;
            // 
            // maHoaDonDataGridViewTextBoxColumn
            // 
            this.maHoaDonDataGridViewTextBoxColumn.DataPropertyName = "MaHoaDon";
            this.maHoaDonDataGridViewTextBoxColumn.HeaderText = "MaHoaDon";
            this.maHoaDonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maHoaDonDataGridViewTextBoxColumn.Name = "maHoaDonDataGridViewTextBoxColumn";
            this.maHoaDonDataGridViewTextBoxColumn.ReadOnly = true;
            this.maHoaDonDataGridViewTextBoxColumn.Visible = false;
            this.maHoaDonDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaHangHoa";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaHangHoa";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // classChiTietHoaDonBindingSource
            // 
            this.classChiTietHoaDonBindingSource.DataSource = typeof(QuanLyQuanAo.DAO.ClassChiTietHoaDon);
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.btnLoadKH);
            this.grbThongTin.Controls.Add(this.btnThemKH);
            this.grbThongTin.Controls.Add(this.txtMaNV);
            this.grbThongTin.Controls.Add(this.txtTenNV);
            this.grbThongTin.Controls.Add(this.txtLoaiGiamGia);
            this.grbThongTin.Controls.Add(this.txtLoaiKH);
            this.grbThongTin.Controls.Add(this.txtSDT);
            this.grbThongTin.Controls.Add(this.txtDiaChi);
            this.grbThongTin.Controls.Add(this.txtTenKH);
            this.grbThongTin.Controls.Add(this.cboMKH);
            this.grbThongTin.Controls.Add(this.label13);
            this.grbThongTin.Controls.Add(this.label12);
            this.grbThongTin.Controls.Add(this.label9);
            this.grbThongTin.Controls.Add(this.datePic);
            this.grbThongTin.Controls.Add(this.label8);
            this.grbThongTin.Controls.Add(this.label7);
            this.grbThongTin.Controls.Add(this.label6);
            this.grbThongTin.Controls.Add(this.label5);
            this.grbThongTin.Controls.Add(this.label4);
            this.grbThongTin.Controls.Add(this.label3);
            this.grbThongTin.Controls.Add(this.label2);
            this.grbThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbThongTin.Location = new System.Drawing.Point(0, 0);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(852, 194);
            this.grbThongTin.TabIndex = 1;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông Tin Chung";
            // 
            // btnLoadKH
            // 
            this.btnLoadKH.Location = new System.Drawing.Point(424, 98);
            this.btnLoadKH.Name = "btnLoadKH";
            this.btnLoadKH.Size = new System.Drawing.Size(120, 54);
            this.btnLoadKH.TabIndex = 3;
            this.btnLoadKH.Text = "Load Lại KH";
            this.btnLoadKH.UseVisualStyleBackColor = true;
            this.btnLoadKH.Click += new System.EventHandler(this.btnLoadKH_Click);
            // 
            // btnThemKH
            // 
            this.btnThemKH.Location = new System.Drawing.Point(424, 28);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(120, 54);
            this.btnThemKH.TabIndex = 3;
            this.btnThemKH.Text = "Thêm KH";
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(184, 25);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(117, 22);
            this.txtMaNV.TabIndex = 0;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(184, 71);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.ReadOnly = true;
            this.txtTenNV.Size = new System.Drawing.Size(117, 22);
            this.txtTenNV.TabIndex = 1;
            // 
            // txtLoaiGiamGia
            // 
            this.txtLoaiGiamGia.Location = new System.Drawing.Point(747, 157);
            this.txtLoaiGiamGia.Name = "txtLoaiGiamGia";
            this.txtLoaiGiamGia.ReadOnly = true;
            this.txtLoaiGiamGia.Size = new System.Drawing.Size(43, 22);
            this.txtLoaiGiamGia.TabIndex = 11;
            this.txtLoaiGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLoaiGiamGia.TextChanged += new System.EventHandler(this.txtLoaiGiamGia_TextChanged);
            // 
            // txtLoaiKH
            // 
            this.txtLoaiKH.Location = new System.Drawing.Point(606, 156);
            this.txtLoaiKH.Name = "txtLoaiKH";
            this.txtLoaiKH.ReadOnly = true;
            this.txtLoaiKH.Size = new System.Drawing.Size(88, 22);
            this.txtLoaiKH.TabIndex = 11;
            this.txtLoaiKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(704, 117);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(121, 22);
            this.txtSDT.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(704, 83);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(121, 22);
            this.txtDiaChi.TabIndex = 10;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(704, 54);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.ReadOnly = true;
            this.txtTenKH.Size = new System.Drawing.Size(121, 22);
            this.txtTenKH.TabIndex = 9;
            // 
            // cboMKH
            // 
            this.cboMKH.FormattingEnabled = true;
            this.cboMKH.Location = new System.Drawing.Point(704, 21);
            this.cboMKH.Name = "cboMKH";
            this.cboMKH.Size = new System.Drawing.Size(121, 24);
            this.cboMKH.TabIndex = 8;
            this.cboMKH.SelectedIndexChanged += new System.EventHandler(this.cboMKH_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(801, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(700, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 17);
            this.label12.TabIndex = 7;
            this.label12.Text = "Giảm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(533, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Loại KH";
            // 
            // datePic
            // 
            this.datePic.Enabled = false;
            this.datePic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePic.Location = new System.Drawing.Point(187, 117);
            this.datePic.Name = "datePic";
            this.datePic.Size = new System.Drawing.Size(140, 22);
            this.datePic.TabIndex = 2;
            this.datePic.Value = new System.DateTime(2019, 5, 14, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(582, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Diện Thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(582, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Địa Chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(579, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên Khách Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(579, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã Khách Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Bán";
            // 
            // frmLapHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 753);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.MaximumSize = new System.Drawing.Size(870, 800);
            this.MinimumSize = new System.Drawing.Size(870, 800);
            this.Name = "frmLapHoaDon";
            this.Text = "Lập Hóa Đơn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLapHoaDon_FormClosed);
            this.Load += new System.EventHandler(this.frmLapHoaDon_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            this.grbThongTinMatHang.ResumeLayout(false);
            this.grbThongTinMatHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classChiTietHoaDonBindingSource)).EndInit();
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.GroupBox grbThongTinMatHang;
        private System.Windows.Forms.Button btnSuaHH;
        private System.Windows.Forms.Button btnLuuHH;
        private System.Windows.Forms.Button btnXoaHH;
        private System.Windows.Forms.Button btnThemHH;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.ComboBox cboMKH;
        private System.Windows.Forms.DateTimePicker datePic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaGiamGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblThongBaoGG;
        private System.Windows.Forms.Button btnSuDungMGG;
        private System.Windows.Forms.TextBox txtLoaiKH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtConLai;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.Button btnLoadKH;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridViewComboBoxColumn cboCellMaHangHoa;
        private System.Windows.Forms.DataGridViewComboBoxColumn cboCellMaHangHoa1;
        private System.Windows.Forms.DataGridViewComboBoxColumn maHangHoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLConLaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHoaDonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource classChiTietHoaDonBindingSource;
        private System.Windows.Forms.TextBox txtLoaiGiamGia;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblHeSoGiam;
    }
}