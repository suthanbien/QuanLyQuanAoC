namespace QuanLyQuanAo.GUI
{
    partial class frmHangHoa
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
            this.pnlTop_Center = new System.Windows.Forms.Panel();
            this.ricChuThich = new System.Windows.Forms.RichTextBox();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtHangSX = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtLoaiHH = new System.Windows.Forms.TextBox();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMLSP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGiaTien = new System.Windows.Forms.Label();
            this.lblSL = new System.Windows.Forms.Label();
            this.lblTenSp = new System.Windows.Forms.Label();
            this.lblMaSp = new System.Windows.Forms.Label();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.lblSanPham = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.cboLoaiHH = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maHangHoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHangHoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiHangHoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangSanXuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongConDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chuThichDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.classHangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btgNhomLenh = new QuanLyQuanAo.GUI.ButtonGroup();
            this.pnlTop.SuspendLayout();
            this.pnlTop_Center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classHangHoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.pnlTop_Center);
            this.pnlTop.Controls.Add(this.lblSanPham);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1190, 403);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlTop_Center
            // 
            this.pnlTop_Center.Controls.Add(this.label2);
            this.pnlTop_Center.Controls.Add(this.cboLoaiHH);
            this.pnlTop_Center.Controls.Add(this.ricChuThich);
            this.pnlTop_Center.Controls.Add(this.txtAnh);
            this.pnlTop_Center.Controls.Add(this.txtSoLuong);
            this.pnlTop_Center.Controls.Add(this.txtHangSX);
            this.pnlTop_Center.Controls.Add(this.txtGiaBan);
            this.pnlTop_Center.Controls.Add(this.txtGiaNhap);
            this.pnlTop_Center.Controls.Add(this.txtLoaiHH);
            this.pnlTop_Center.Controls.Add(this.txtTenHH);
            this.pnlTop_Center.Controls.Add(this.txtMaHH);
            this.pnlTop_Center.Controls.Add(this.label7);
            this.pnlTop_Center.Controls.Add(this.lblMLSP);
            this.pnlTop_Center.Controls.Add(this.label1);
            this.pnlTop_Center.Controls.Add(this.label5);
            this.pnlTop_Center.Controls.Add(this.lblGiaTien);
            this.pnlTop_Center.Controls.Add(this.lblSL);
            this.pnlTop_Center.Controls.Add(this.lblTenSp);
            this.pnlTop_Center.Controls.Add(this.lblMaSp);
            this.pnlTop_Center.Controls.Add(this.picAnh);
            this.pnlTop_Center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTop_Center.Location = new System.Drawing.Point(0, 78);
            this.pnlTop_Center.Name = "pnlTop_Center";
            this.pnlTop_Center.Size = new System.Drawing.Size(1190, 325);
            this.pnlTop_Center.TabIndex = 2;
            // 
            // ricChuThich
            // 
            this.ricChuThich.Location = new System.Drawing.Point(504, 183);
            this.ricChuThich.Name = "ricChuThich";
            this.ricChuThich.ReadOnly = true;
            this.ricChuThich.Size = new System.Drawing.Size(252, 122);
            this.ricChuThich.TabIndex = 25;
            this.ricChuThich.Text = "";
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(762, 283);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.ReadOnly = true;
            this.txtAnh.Size = new System.Drawing.Size(22, 22);
            this.txtAnh.TabIndex = 24;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(172, 155);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.ReadOnly = true;
            this.txtSoLuong.Size = new System.Drawing.Size(138, 22);
            this.txtSoLuong.TabIndex = 18;
            // 
            // txtHangSX
            // 
            this.txtHangSX.Location = new System.Drawing.Point(539, 92);
            this.txtHangSX.Name = "txtHangSX";
            this.txtHangSX.ReadOnly = true;
            this.txtHangSX.Size = new System.Drawing.Size(138, 22);
            this.txtHangSX.TabIndex = 19;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(172, 261);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.ReadOnly = true;
            this.txtGiaBan.Size = new System.Drawing.Size(138, 22);
            this.txtGiaBan.TabIndex = 20;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(173, 206);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.ReadOnly = true;
            this.txtGiaNhap.Size = new System.Drawing.Size(138, 22);
            this.txtGiaNhap.TabIndex = 20;
            // 
            // txtLoaiHH
            // 
            this.txtLoaiHH.Location = new System.Drawing.Point(539, 34);
            this.txtLoaiHH.Name = "txtLoaiHH";
            this.txtLoaiHH.ReadOnly = true;
            this.txtLoaiHH.Size = new System.Drawing.Size(138, 22);
            this.txtLoaiHH.TabIndex = 21;
            // 
            // txtTenHH
            // 
            this.txtTenHH.Location = new System.Drawing.Point(172, 97);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.ReadOnly = true;
            this.txtTenHH.Size = new System.Drawing.Size(138, 22);
            this.txtTenHH.TabIndex = 22;
            // 
            // txtMaHH
            // 
            this.txtMaHH.Location = new System.Drawing.Point(172, 34);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.ReadOnly = true;
            this.txtMaHH.Size = new System.Drawing.Size(138, 22);
            this.txtMaHH.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Chú Thích";
            // 
            // lblMLSP
            // 
            this.lblMLSP.AutoSize = true;
            this.lblMLSP.Location = new System.Drawing.Point(21, 155);
            this.lblMLSP.Name = "lblMLSP";
            this.lblMLSP.Size = new System.Drawing.Size(69, 17);
            this.lblMLSP.TabIndex = 17;
            this.lblMLSP.Text = "Số Lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Hãng Sản Xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Giá Bán";
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.Location = new System.Drawing.Point(21, 206);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(68, 17);
            this.lblGiaTien.TabIndex = 16;
            this.lblGiaTien.Text = "Giá Nhập";
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Location = new System.Drawing.Point(388, 37);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(103, 17);
            this.lblSL.TabIndex = 14;
            this.lblSL.Text = "Loại Hàng Hóa";
            // 
            // lblTenSp
            // 
            this.lblTenSp.AutoSize = true;
            this.lblTenSp.Location = new System.Drawing.Point(21, 102);
            this.lblTenSp.Name = "lblTenSp";
            this.lblTenSp.Size = new System.Drawing.Size(101, 17);
            this.lblTenSp.TabIndex = 13;
            this.lblTenSp.Text = "Tên Hàng Hóa";
            // 
            // lblMaSp
            // 
            this.lblMaSp.AutoSize = true;
            this.lblMaSp.Location = new System.Drawing.Point(21, 37);
            this.lblMaSp.Name = "lblMaSp";
            this.lblMaSp.Size = new System.Drawing.Size(95, 17);
            this.lblMaSp.TabIndex = 12;
            this.lblMaSp.Text = "Mã Hàng Hóa";
            // 
            // picAnh
            // 
            this.picAnh.Dock = System.Windows.Forms.DockStyle.Right;
            this.picAnh.Location = new System.Drawing.Point(790, 0);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(400, 325);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnh.TabIndex = 4;
            this.picAnh.TabStop = false;
            // 
            // lblSanPham
            // 
            this.lblSanPham.BackColor = System.Drawing.Color.Chartreuse;
            this.lblSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanPham.ForeColor = System.Drawing.Color.Crimson;
            this.lblSanPham.Location = new System.Drawing.Point(0, 0);
            this.lblSanPham.Name = "lblSanPham";
            this.lblSanPham.Size = new System.Drawing.Size(1190, 78);
            this.lblSanPham.TabIndex = 1;
            this.lblSanPham.Text = "Danh Mục Hàng Hóa";
            this.lblSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btgNhomLenh);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 591);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1190, 74);
            this.pnlBottom.TabIndex = 1;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.dgvSanPham);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 403);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1190, 188);
            this.pnlCenter.TabIndex = 2;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.AutoGenerateColumns = false;
            this.dgvSanPham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHangHoaDataGridViewTextBoxColumn,
            this.tenHangHoaDataGridViewTextBoxColumn,
            this.loaiHangHoaDataGridViewTextBoxColumn,
            this.hangSanXuatDataGridViewTextBoxColumn,
            this.giaNhapDataGridViewTextBoxColumn,
            this.giaBanDataGridViewTextBoxColumn,
            this.soLuongConDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewCheckBoxColumn,
            this.chuThichDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.dgvSanPham.DataSource = this.classHangHoaBindingSource;
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.Location = new System.Drawing.Point(0, 0);
            this.dgvSanPham.MultiSelect = false;
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(1190, 188);
            this.dgvSanPham.TabIndex = 1;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            this.dgvSanPham.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvSanPham_EditingControlShowing);
            // 
            // cboLoaiHH
            // 
            this.cboLoaiHH.FormattingEnabled = true;
            this.cboLoaiHH.Location = new System.Drawing.Point(323, 261);
            this.cboLoaiHH.Name = "cboLoaiHH";
            this.cboLoaiHH.Size = new System.Drawing.Size(175, 24);
            this.cboLoaiHH.TabIndex = 26;
            this.cboLoaiHH.SelectedIndexChanged += new System.EventHandler(this.cboLoaiHH_SelectedIndexChanged);
            this.cboLoaiHH.Click += new System.EventHandler(this.cboLoaiHH_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "loại hàng hóa";
            // 
            // maHangHoaDataGridViewTextBoxColumn
            // 
            this.maHangHoaDataGridViewTextBoxColumn.DataPropertyName = "MaHangHoa";
            this.maHangHoaDataGridViewTextBoxColumn.HeaderText = "MaHangHoa";
            this.maHangHoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maHangHoaDataGridViewTextBoxColumn.Name = "maHangHoaDataGridViewTextBoxColumn";
            this.maHangHoaDataGridViewTextBoxColumn.ReadOnly = true;
            this.maHangHoaDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenHangHoaDataGridViewTextBoxColumn
            // 
            this.tenHangHoaDataGridViewTextBoxColumn.DataPropertyName = "TenHangHoa";
            this.tenHangHoaDataGridViewTextBoxColumn.HeaderText = "TenHangHoa";
            this.tenHangHoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenHangHoaDataGridViewTextBoxColumn.Name = "tenHangHoaDataGridViewTextBoxColumn";
            this.tenHangHoaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenHangHoaDataGridViewTextBoxColumn.Width = 125;
            // 
            // loaiHangHoaDataGridViewTextBoxColumn
            // 
            this.loaiHangHoaDataGridViewTextBoxColumn.DataPropertyName = "LoaiHangHoa";
            this.loaiHangHoaDataGridViewTextBoxColumn.HeaderText = "LoaiHangHoa";
            this.loaiHangHoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loaiHangHoaDataGridViewTextBoxColumn.Name = "loaiHangHoaDataGridViewTextBoxColumn";
            this.loaiHangHoaDataGridViewTextBoxColumn.ReadOnly = true;
            this.loaiHangHoaDataGridViewTextBoxColumn.Width = 125;
            // 
            // hangSanXuatDataGridViewTextBoxColumn
            // 
            this.hangSanXuatDataGridViewTextBoxColumn.DataPropertyName = "HangSanXuat";
            this.hangSanXuatDataGridViewTextBoxColumn.HeaderText = "HangSanXuat";
            this.hangSanXuatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hangSanXuatDataGridViewTextBoxColumn.Name = "hangSanXuatDataGridViewTextBoxColumn";
            this.hangSanXuatDataGridViewTextBoxColumn.ReadOnly = true;
            this.hangSanXuatDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hangSanXuatDataGridViewTextBoxColumn.Width = 125;
            // 
            // giaNhapDataGridViewTextBoxColumn
            // 
            this.giaNhapDataGridViewTextBoxColumn.DataPropertyName = "GiaNhap";
            this.giaNhapDataGridViewTextBoxColumn.HeaderText = "GiaNhap";
            this.giaNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaNhapDataGridViewTextBoxColumn.Name = "giaNhapDataGridViewTextBoxColumn";
            this.giaNhapDataGridViewTextBoxColumn.ReadOnly = true;
            this.giaNhapDataGridViewTextBoxColumn.Width = 125;
            // 
            // giaBanDataGridViewTextBoxColumn
            // 
            this.giaBanDataGridViewTextBoxColumn.DataPropertyName = "GiaBan";
            this.giaBanDataGridViewTextBoxColumn.HeaderText = "GiaBan";
            this.giaBanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaBanDataGridViewTextBoxColumn.Name = "giaBanDataGridViewTextBoxColumn";
            this.giaBanDataGridViewTextBoxColumn.ReadOnly = true;
            this.giaBanDataGridViewTextBoxColumn.Width = 125;
            // 
            // soLuongConDataGridViewTextBoxColumn
            // 
            this.soLuongConDataGridViewTextBoxColumn.DataPropertyName = "SoLuongCon";
            this.soLuongConDataGridViewTextBoxColumn.HeaderText = "SoLuongCon";
            this.soLuongConDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongConDataGridViewTextBoxColumn.Name = "soLuongConDataGridViewTextBoxColumn";
            this.soLuongConDataGridViewTextBoxColumn.ReadOnly = true;
            this.soLuongConDataGridViewTextBoxColumn.Width = 125;
            // 
            // trangThaiDataGridViewCheckBoxColumn
            // 
            this.trangThaiDataGridViewCheckBoxColumn.DataPropertyName = "TrangThai";
            this.trangThaiDataGridViewCheckBoxColumn.HeaderText = "TrangThai";
            this.trangThaiDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.trangThaiDataGridViewCheckBoxColumn.Name = "trangThaiDataGridViewCheckBoxColumn";
            this.trangThaiDataGridViewCheckBoxColumn.ReadOnly = true;
            this.trangThaiDataGridViewCheckBoxColumn.Width = 125;
            // 
            // chuThichDataGridViewTextBoxColumn
            // 
            this.chuThichDataGridViewTextBoxColumn.DataPropertyName = "ChuThich";
            this.chuThichDataGridViewTextBoxColumn.HeaderText = "ChuThich";
            this.chuThichDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chuThichDataGridViewTextBoxColumn.Name = "chuThichDataGridViewTextBoxColumn";
            this.chuThichDataGridViewTextBoxColumn.ReadOnly = true;
            this.chuThichDataGridViewTextBoxColumn.Width = 125;
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.MinimumWidth = 6;
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.ReadOnly = true;
            this.imageDataGridViewImageColumn.Width = 125;
            // 
            // classHangHoaBindingSource
            // 
            this.classHangHoaBindingSource.DataSource = typeof(QuanLyQuanAo.DAO.ClassHangHoa);
            // 
            // btgNhomLenh
            // 
            this.btgNhomLenh.AddEnabled = true;
            this.btgNhomLenh.AutoNumber = false;
            this.btgNhomLenh.CanDelete = true;
            this.btgNhomLenh.CanSave = true;
            this.btgNhomLenh.dgv = null;
            this.btgNhomLenh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btgNhomLenh.EditEnabled = true;
            this.btgNhomLenh.Extra2Enabled = true;
            this.btgNhomLenh.Extra2Text = "Thêm Ảnh";
            this.btgNhomLenh.Extra2Visible = true;
            this.btgNhomLenh.ExtraEnabled = true;
            this.btgNhomLenh.ExtraText = "Làm Mới";
            this.btgNhomLenh.ExtraVisible = true;
            this.btgNhomLenh.ListTimKiem = null;
            this.btgNhomLenh.Location = new System.Drawing.Point(0, 0);
            this.btgNhomLenh.MaTimKiem = "";
            this.btgNhomLenh.Mode = 0;
            this.btgNhomLenh.ModeADD = 0;
            this.btgNhomLenh.ModeTimKiem = 1;
            this.btgNhomLenh.MsMau = null;
            this.btgNhomLenh.Name = "btgNhomLenh";
            this.btgNhomLenh.Position = 0;
            this.btgNhomLenh.Reccount = 0;
            this.btgNhomLenh.Size = new System.Drawing.Size(1190, 74);
            this.btgNhomLenh.TabIndex = 0;
            this.btgNhomLenh.TenTimKiem = "";
            this.btgNhomLenh.Display += new QuanLyQuanAo.GUI.ButtonGroupEventHandler(this.btgNhomLenh_Display);
            this.btgNhomLenh.AddClick += new QuanLyQuanAo.GUI.ButtonGroupEventHandler(this.btgNhomLenh_AddClick);
            this.btgNhomLenh.EditClick += new QuanLyQuanAo.GUI.ButtonGroupEventHandler(this.btgNhomLenh_EditClick);
            this.btgNhomLenh.SaveClick += new QuanLyQuanAo.GUI.ButtonGroupEventHandler(this.btgNhomLenh_SaveClick);
            this.btgNhomLenh.CancelClick += new QuanLyQuanAo.GUI.ButtonGroupEventHandler(this.btgNhomLenh_CancelClick);
            this.btgNhomLenh.DeleteClick += new QuanLyQuanAo.GUI.ButtonGroupEventHandler(this.btgNhomLenh_DeleteClick);
            this.btgNhomLenh.TimKiemClick += new QuanLyQuanAo.GUI.ButtonGroupEventHandler(this.btgNhomLenh_TimKiemClick);
            this.btgNhomLenh.ExtraClick += new QuanLyQuanAo.GUI.ButtonGroupEventHandler(this.btgNhomLenh_ExtraClick);
            this.btgNhomLenh.Extra2Click += new QuanLyQuanAo.GUI.ButtonGroupEventHandler(this.btgNhomLenh_Extra2Click);
            this.btgNhomLenh.RadTimClick += new QuanLyQuanAo.GUI.ButtonGroupEventHandler(this.btgNhomLenh_RadTimClick);
            this.btgNhomLenh.Load += new System.EventHandler(this.btgNhomLenh_Load);
            // 
            // frmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 665);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmHangHoa";
            this.Text = "Danh Mục Hàng Hóa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHangHoa_FormClosed);
            this.Load += new System.EventHandler(this.frmHangHoa_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop_Center.ResumeLayout(false);
            this.pnlTop_Center.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classHangHoaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblSanPham;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlTop_Center;
        private ButtonGroup btgNhomLenh;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtHangSX;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtLoaiHH;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.Label lblMLSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGiaTien;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.Label lblTenSp;
        private System.Windows.Forms.Label lblMaSp;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.BindingSource classHangHoaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHangHoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHangHoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiHangHoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hangSanXuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongConDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn trangThaiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chuThichDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.RichTextBox ricChuThich;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLoaiHH;
    }
}