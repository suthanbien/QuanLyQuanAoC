namespace QuanLyQuanAo.GUI
{
    partial class frmTimHoaDon
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
            this.blbLoaiSanPham = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnIn = new System.Windows.Forms.Button();
            this.grbTimHoaDon = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.radTimTheoKH = new System.Windows.Forms.RadioButton();
            this.radTimTheoMa = new System.Windows.Forms.RadioButton();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.pnlC_C = new System.Windows.Forms.Panel();
            this.pnlC_R = new System.Windows.Forms.Panel();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.maHoaDonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHangHoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLConLaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classChiTietHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlCR_Top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlC_Left = new System.Windows.Forms.Panel();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.maHoaDonDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhachHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapHoaDonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlCL_Top = new System.Windows.Forms.Panel();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.grbTimHoaDon.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.pnlC_R.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classChiTietHoaDonBindingSource)).BeginInit();
            this.pnlCR_Top.SuspendLayout();
            this.pnlC_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classHoaDonBindingSource)).BeginInit();
            this.pnlCL_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.blbLoaiSanPham);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1239, 74);
            this.pnlTop.TabIndex = 0;
            // 
            // blbLoaiSanPham
            // 
            this.blbLoaiSanPham.BackColor = System.Drawing.Color.Bisque;
            this.blbLoaiSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blbLoaiSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blbLoaiSanPham.ForeColor = System.Drawing.Color.DodgerBlue;
            this.blbLoaiSanPham.Location = new System.Drawing.Point(0, 0);
            this.blbLoaiSanPham.Name = "blbLoaiSanPham";
            this.blbLoaiSanPham.Size = new System.Drawing.Size(1239, 74);
            this.blbLoaiSanPham.TabIndex = 3;
            this.blbLoaiSanPham.Text = "Tìm Hóa Đơn";
            this.blbLoaiSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnIn);
            this.pnlBottom.Controls.Add(this.grbTimHoaDon);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 463);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1239, 224);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(872, 16);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(124, 59);
            this.btnIn.TabIndex = 1;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // grbTimHoaDon
            // 
            this.grbTimHoaDon.Controls.Add(this.btnLamMoi);
            this.grbTimHoaDon.Controls.Add(this.btnTimKiem);
            this.grbTimHoaDon.Controls.Add(this.txtTimKiem);
            this.grbTimHoaDon.Controls.Add(this.radTimTheoKH);
            this.grbTimHoaDon.Controls.Add(this.radTimTheoMa);
            this.grbTimHoaDon.Location = new System.Drawing.Point(12, 16);
            this.grbTimHoaDon.Name = "grbTimHoaDon";
            this.grbTimHoaDon.Size = new System.Drawing.Size(562, 196);
            this.grbTimHoaDon.TabIndex = 0;
            this.grbTimHoaDon.TabStop = false;
            this.grbTimHoaDon.Text = "Tìm Hóa Đơn";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(310, 134);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(96, 41);
            this.btnLamMoi.TabIndex = 11;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(140, 134);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(96, 41);
            this.btnTimKiem.TabIndex = 11;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTimKiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTimKiem.Location = new System.Drawing.Point(140, 32);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(266, 22);
            this.txtTimKiem.TabIndex = 10;
            this.txtTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimKiem_KeyPress);
            // 
            // radTimTheoKH
            // 
            this.radTimTheoKH.AutoSize = true;
            this.radTimTheoKH.Location = new System.Drawing.Point(292, 89);
            this.radTimTheoKH.Name = "radTimTheoKH";
            this.radTimTheoKH.Size = new System.Drawing.Size(171, 21);
            this.radTimTheoKH.TabIndex = 1;
            this.radTimTheoKH.Text = "Tìm Theo Khách Hàng";
            this.radTimTheoKH.UseVisualStyleBackColor = true;
            this.radTimTheoKH.CheckedChanged += new System.EventHandler(this.radTim_CheckedChanged);
            // 
            // radTimTheoMa
            // 
            this.radTimTheoMa.AutoSize = true;
            this.radTimTheoMa.Checked = true;
            this.radTimTheoMa.Location = new System.Drawing.Point(140, 89);
            this.radTimTheoMa.Name = "radTimTheoMa";
            this.radTimTheoMa.Size = new System.Drawing.Size(112, 21);
            this.radTimTheoMa.TabIndex = 0;
            this.radTimTheoMa.TabStop = true;
            this.radTimTheoMa.Text = "Tìm Theo Mã";
            this.radTimTheoMa.UseVisualStyleBackColor = true;
            this.radTimTheoMa.CheckedChanged += new System.EventHandler(this.radTim_CheckedChanged);
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.pnlC_C);
            this.pnlCenter.Controls.Add(this.pnlC_R);
            this.pnlCenter.Controls.Add(this.pnlC_Left);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 74);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1239, 389);
            this.pnlCenter.TabIndex = 2;
            // 
            // pnlC_C
            // 
            this.pnlC_C.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlC_C.Location = new System.Drawing.Point(574, 0);
            this.pnlC_C.MaximumSize = new System.Drawing.Size(50, 0);
            this.pnlC_C.MinimumSize = new System.Drawing.Size(50, 0);
            this.pnlC_C.Name = "pnlC_C";
            this.pnlC_C.Size = new System.Drawing.Size(50, 389);
            this.pnlC_C.TabIndex = 1;
            // 
            // pnlC_R
            // 
            this.pnlC_R.Controls.Add(this.dgvChiTiet);
            this.pnlC_R.Controls.Add(this.pnlCR_Top);
            this.pnlC_R.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlC_R.Location = new System.Drawing.Point(623, 0);
            this.pnlC_R.Name = "pnlC_R";
            this.pnlC_R.Size = new System.Drawing.Size(616, 389);
            this.pnlC_R.TabIndex = 0;
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AllowUserToAddRows = false;
            this.dgvChiTiet.AllowUserToDeleteRows = false;
            this.dgvChiTiet.AutoGenerateColumns = false;
            this.dgvChiTiet.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHoaDonDataGridViewTextBoxColumn,
            this.maHangHoaDataGridViewTextBoxColumn,
            this.tenHHDataGridViewTextBoxColumn,
            this.sLConLaiDataGridViewTextBoxColumn,
            this.giaTienDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.tongTienDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn});
            this.dgvChiTiet.DataSource = this.classChiTietHoaDonBindingSource;
            this.dgvChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTiet.Location = new System.Drawing.Point(0, 35);
            this.dgvChiTiet.MultiSelect = false;
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.ReadOnly = true;
            this.dgvChiTiet.RowHeadersVisible = false;
            this.dgvChiTiet.RowHeadersWidth = 51;
            this.dgvChiTiet.RowTemplate.Height = 24;
            this.dgvChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvChiTiet.Size = new System.Drawing.Size(616, 354);
            this.dgvChiTiet.TabIndex = 2;
            // 
            // maHoaDonDataGridViewTextBoxColumn
            // 
            this.maHoaDonDataGridViewTextBoxColumn.DataPropertyName = "MaHoaDon";
            this.maHoaDonDataGridViewTextBoxColumn.HeaderText = "Mã HD";
            this.maHoaDonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maHoaDonDataGridViewTextBoxColumn.Name = "maHoaDonDataGridViewTextBoxColumn";
            this.maHoaDonDataGridViewTextBoxColumn.ReadOnly = true;
            this.maHoaDonDataGridViewTextBoxColumn.Width = 85;
            // 
            // maHangHoaDataGridViewTextBoxColumn
            // 
            this.maHangHoaDataGridViewTextBoxColumn.DataPropertyName = "MaHangHoa";
            this.maHangHoaDataGridViewTextBoxColumn.HeaderText = "Mã HH";
            this.maHangHoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maHangHoaDataGridViewTextBoxColumn.Name = "maHangHoaDataGridViewTextBoxColumn";
            this.maHangHoaDataGridViewTextBoxColumn.ReadOnly = true;
            this.maHangHoaDataGridViewTextBoxColumn.Width = 85;
            // 
            // tenHHDataGridViewTextBoxColumn
            // 
            this.tenHHDataGridViewTextBoxColumn.DataPropertyName = "TenHH";
            this.tenHHDataGridViewTextBoxColumn.HeaderText = "Tên HH";
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
            this.sLConLaiDataGridViewTextBoxColumn.Visible = false;
            this.sLConLaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // giaTienDataGridViewTextBoxColumn
            // 
            this.giaTienDataGridViewTextBoxColumn.DataPropertyName = "GiaTien";
            this.giaTienDataGridViewTextBoxColumn.HeaderText = "Giá";
            this.giaTienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaTienDataGridViewTextBoxColumn.Name = "giaTienDataGridViewTextBoxColumn";
            this.giaTienDataGridViewTextBoxColumn.ReadOnly = true;
            this.giaTienDataGridViewTextBoxColumn.Width = 80;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số Lượng";
            this.soLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.ReadOnly = true;
            this.soLuongDataGridViewTextBoxColumn.Width = 125;
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
            this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.HeaderText = "Tổng Tiền";
            this.tongTienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            this.tongTienDataGridViewTextBoxColumn.ReadOnly = true;
            this.tongTienDataGridViewTextBoxColumn.Width = 125;
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "Ghi Chú";
            this.ghiChuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            this.ghiChuDataGridViewTextBoxColumn.ReadOnly = true;
            this.ghiChuDataGridViewTextBoxColumn.Width = 125;
            // 
            // classChiTietHoaDonBindingSource
            // 
            this.classChiTietHoaDonBindingSource.DataSource = typeof(QuanLyQuanAo.DAO.ClassChiTietHoaDon);
            // 
            // pnlCR_Top
            // 
            this.pnlCR_Top.Controls.Add(this.label1);
            this.pnlCR_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCR_Top.Location = new System.Drawing.Point(0, 0);
            this.pnlCR_Top.Name = "pnlCR_Top";
            this.pnlCR_Top.Size = new System.Drawing.Size(616, 35);
            this.pnlCR_Top.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chi Tiết Hóa Đơn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlC_Left
            // 
            this.pnlC_Left.Controls.Add(this.dgvHoaDon);
            this.pnlC_Left.Controls.Add(this.pnlCL_Top);
            this.pnlC_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlC_Left.Location = new System.Drawing.Point(0, 0);
            this.pnlC_Left.Name = "pnlC_Left";
            this.pnlC_Left.Size = new System.Drawing.Size(574, 389);
            this.pnlC_Left.TabIndex = 0;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.AutoGenerateColumns = false;
            this.dgvHoaDon.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHoaDonDataGridViewTextBoxColumn1,
            this.tenKhachHangDataGridViewTextBoxColumn,
            this.tenNhanVienDataGridViewTextBoxColumn,
            this.ngayLapHoaDonDataGridViewTextBoxColumn,
            this.tongTienDataGridViewTextBoxColumn1,
            this.ghiChuDataGridViewTextBoxColumn1});
            this.dgvHoaDon.DataSource = this.classHoaDonBindingSource;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 35);
            this.dgvHoaDon.MultiSelect = false;
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(574, 354);
            this.dgvHoaDon.TabIndex = 2;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // maHoaDonDataGridViewTextBoxColumn1
            // 
            this.maHoaDonDataGridViewTextBoxColumn1.DataPropertyName = "MaHoaDon";
            this.maHoaDonDataGridViewTextBoxColumn1.HeaderText = "Mã HD";
            this.maHoaDonDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.maHoaDonDataGridViewTextBoxColumn1.Name = "maHoaDonDataGridViewTextBoxColumn1";
            this.maHoaDonDataGridViewTextBoxColumn1.ReadOnly = true;
            this.maHoaDonDataGridViewTextBoxColumn1.Width = 80;
            // 
            // tenKhachHangDataGridViewTextBoxColumn
            // 
            this.tenKhachHangDataGridViewTextBoxColumn.DataPropertyName = "TenKhachHang";
            this.tenKhachHangDataGridViewTextBoxColumn.HeaderText = "Tên KH";
            this.tenKhachHangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenKhachHangDataGridViewTextBoxColumn.Name = "tenKhachHangDataGridViewTextBoxColumn";
            this.tenKhachHangDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenKhachHangDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenNhanVienDataGridViewTextBoxColumn
            // 
            this.tenNhanVienDataGridViewTextBoxColumn.DataPropertyName = "TenNhanVien";
            this.tenNhanVienDataGridViewTextBoxColumn.HeaderText = "Tên NV";
            this.tenNhanVienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNhanVienDataGridViewTextBoxColumn.Name = "tenNhanVienDataGridViewTextBoxColumn";
            this.tenNhanVienDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenNhanVienDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayLapHoaDonDataGridViewTextBoxColumn
            // 
            this.ngayLapHoaDonDataGridViewTextBoxColumn.DataPropertyName = "NgayLapHoaDon";
            this.ngayLapHoaDonDataGridViewTextBoxColumn.HeaderText = "Ngày Lập";
            this.ngayLapHoaDonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayLapHoaDonDataGridViewTextBoxColumn.Name = "ngayLapHoaDonDataGridViewTextBoxColumn";
            this.ngayLapHoaDonDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayLapHoaDonDataGridViewTextBoxColumn.Width = 125;
            // 
            // tongTienDataGridViewTextBoxColumn1
            // 
            this.tongTienDataGridViewTextBoxColumn1.DataPropertyName = "TongTien";
            this.tongTienDataGridViewTextBoxColumn1.HeaderText = "Tổng Tiền";
            this.tongTienDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.tongTienDataGridViewTextBoxColumn1.Name = "tongTienDataGridViewTextBoxColumn1";
            this.tongTienDataGridViewTextBoxColumn1.ReadOnly = true;
            this.tongTienDataGridViewTextBoxColumn1.Width = 125;
            // 
            // ghiChuDataGridViewTextBoxColumn1
            // 
            this.ghiChuDataGridViewTextBoxColumn1.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn1.HeaderText = "Ghi Chú";
            this.ghiChuDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.ghiChuDataGridViewTextBoxColumn1.Name = "ghiChuDataGridViewTextBoxColumn1";
            this.ghiChuDataGridViewTextBoxColumn1.ReadOnly = true;
            this.ghiChuDataGridViewTextBoxColumn1.Width = 125;
            // 
            // classHoaDonBindingSource
            // 
            this.classHoaDonBindingSource.DataSource = typeof(QuanLyQuanAo.DAO.ClassHoaDon);
            // 
            // pnlCL_Top
            // 
            this.pnlCL_Top.Controls.Add(this.lblHoaDon);
            this.pnlCL_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCL_Top.Location = new System.Drawing.Point(0, 0);
            this.pnlCL_Top.Name = "pnlCL_Top";
            this.pnlCL_Top.Size = new System.Drawing.Size(574, 35);
            this.pnlCL_Top.TabIndex = 0;
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDon.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblHoaDon.Location = new System.Drawing.Point(0, 0);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(574, 35);
            this.lblHoaDon.TabIndex = 2;
            this.lblHoaDon.Text = "Hóa Đơn";
            this.lblHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTimHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 687);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.MinimumSize = new System.Drawing.Size(1193, 47);
            this.Name = "frmTimHoaDon";
            this.Text = "Tìm Hóa Đơn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTimHoaDon_FormClosed);
            this.Load += new System.EventHandler(this.frmTimHoaDon_Load);
            this.SizeChanged += new System.EventHandler(this.frmTimHoaDon_SizeChanged);
            this.Resize += new System.EventHandler(this.frmTimHoaDon_Resize);
            this.pnlTop.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.grbTimHoaDon.ResumeLayout(false);
            this.grbTimHoaDon.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.pnlC_R.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classChiTietHoaDonBindingSource)).EndInit();
            this.pnlCR_Top.ResumeLayout(false);
            this.pnlC_Left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classHoaDonBindingSource)).EndInit();
            this.pnlCL_Top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Label blbLoaiSanPham;
        private System.Windows.Forms.Panel pnlC_Left;
        private System.Windows.Forms.Panel pnlC_C;
        private System.Windows.Forms.Panel pnlC_R;
        private System.Windows.Forms.Panel pnlCL_Top;
        private System.Windows.Forms.Panel pnlCR_Top;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.GroupBox grbTimHoaDon;
        private System.Windows.Forms.RadioButton radTimTheoKH;
        private System.Windows.Forms.RadioButton radTimTheoMa;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.BindingSource classChiTietHoaDonBindingSource;
        private System.Windows.Forms.BindingSource classHoaDonBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHoaDonDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapHoaDonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHoaDonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHangHoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLConLaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
    }
}