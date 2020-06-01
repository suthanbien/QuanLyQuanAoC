namespace QuanLyQuanAo.GUI
{
    partial class frmPhieuNhapHang
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
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.pnlC_left = new System.Windows.Forms.Panel();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.datePic = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThemHangLoat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSLCon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLoaiHH = new System.Windows.Forms.ComboBox();
            this.grbTimHoaDon = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.radTimTheoSL = new System.Windows.Forms.RadioButton();
            this.radTimTheoMa = new System.Windows.Forms.RadioButton();
            this.btnThemVaoPhieu = new System.Windows.Forms.Button();
            this.pnlCenterLeft = new System.Windows.Forms.Panel();
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.ThemPhieuIn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.maHangHoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHangHoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiHangHoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangSanXuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongConDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.chuThichDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classHangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.txtSLNhap = new System.Windows.Forms.TextBox();
            this.btnXoaHH = new System.Windows.Forms.Button();
            this.btnLuuPhieu = new System.Windows.Forms.Button();
            this.btnXoaPhieu = new System.Windows.Forms.Button();
            this.pnlB_left = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlB_Top = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThemSLList = new System.Windows.Forms.Button();
            this.btnThemSL1Mon = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.pnlC_left.SuspendLayout();
            this.grbTimHoaDon.SuspendLayout();
            this.pnlCenterLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classHangHoaBindingSource)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlB_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlB_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblHoaDon);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1157, 78);
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
            this.lblHoaDon.Size = new System.Drawing.Size(1157, 78);
            this.lblHoaDon.TabIndex = 2;
            this.lblHoaDon.Text = "Nhập Hàng";
            this.lblHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.pnlC_left);
            this.pnlCenter.Controls.Add(this.pnlCenterLeft);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 78);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1157, 777);
            this.pnlCenter.TabIndex = 1;
            // 
            // pnlC_left
            // 
            this.pnlC_left.Controls.Add(this.txtMaNV);
            this.pnlC_left.Controls.Add(this.txtTenNV);
            this.pnlC_left.Controls.Add(this.datePic);
            this.pnlC_left.Controls.Add(this.label3);
            this.pnlC_left.Controls.Add(this.label6);
            this.pnlC_left.Controls.Add(this.label7);
            this.pnlC_left.Controls.Add(this.btnThemHangLoat);
            this.pnlC_left.Controls.Add(this.label4);
            this.pnlC_left.Controls.Add(this.txtSLCon);
            this.pnlC_left.Controls.Add(this.label2);
            this.pnlC_left.Controls.Add(this.cboLoaiHH);
            this.pnlC_left.Controls.Add(this.grbTimHoaDon);
            this.pnlC_left.Controls.Add(this.btnThemVaoPhieu);
            this.pnlC_left.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlC_left.Location = new System.Drawing.Point(664, 0);
            this.pnlC_left.Name = "pnlC_left";
            this.pnlC_left.Size = new System.Drawing.Size(493, 777);
            this.pnlC_left.TabIndex = 2;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(143, 257);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(117, 22);
            this.txtMaNV.TabIndex = 36;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(143, 303);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.ReadOnly = true;
            this.txtTenNV.Size = new System.Drawing.Size(117, 22);
            this.txtTenNV.TabIndex = 37;
            // 
            // datePic
            // 
            this.datePic.Enabled = false;
            this.datePic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePic.Location = new System.Drawing.Point(146, 349);
            this.datePic.Name = "datePic";
            this.datePic.Size = new System.Drawing.Size(140, 22);
            this.datePic.TabIndex = 39;
            this.datePic.Value = new System.DateTime(2019, 5, 14, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Tên Nhân Viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "Mã Nhân Viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Ngày Tạo Phiếu";
            // 
            // btnThemHangLoat
            // 
            this.btnThemHangLoat.Location = new System.Drawing.Point(33, 431);
            this.btnThemHangLoat.Name = "btnThemHangLoat";
            this.btnThemHangLoat.Size = new System.Drawing.Size(124, 54);
            this.btnThemHangLoat.TabIndex = 35;
            this.btnThemHangLoat.Text = "Thêm Hàng Loạt";
            this.btnThemHangLoat.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "SL còn lại";
            // 
            // txtSLCon
            // 
            this.txtSLCon.Location = new System.Drawing.Point(369, 307);
            this.txtSLCon.Name = "txtSLCon";
            this.txtSLCon.ReadOnly = true;
            this.txtSLCon.Size = new System.Drawing.Size(94, 22);
            this.txtSLCon.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "loại hàng hóa";
            // 
            // cboLoaiHH
            // 
            this.cboLoaiHH.FormattingEnabled = true;
            this.cboLoaiHH.Location = new System.Drawing.Point(159, 32);
            this.cboLoaiHH.Name = "cboLoaiHH";
            this.cboLoaiHH.Size = new System.Drawing.Size(175, 24);
            this.cboLoaiHH.TabIndex = 28;
            this.cboLoaiHH.SelectedIndexChanged += new System.EventHandler(this.cboLoaiHH_SelectedIndexChanged);
            // 
            // grbTimHoaDon
            // 
            this.grbTimHoaDon.Controls.Add(this.btnLamMoi);
            this.grbTimHoaDon.Controls.Add(this.btnTimKiem);
            this.grbTimHoaDon.Controls.Add(this.txtTimKiem);
            this.grbTimHoaDon.Controls.Add(this.radTimTheoSL);
            this.grbTimHoaDon.Controls.Add(this.radTimTheoMa);
            this.grbTimHoaDon.Location = new System.Drawing.Point(19, 62);
            this.grbTimHoaDon.Name = "grbTimHoaDon";
            this.grbTimHoaDon.Size = new System.Drawing.Size(462, 186);
            this.grbTimHoaDon.TabIndex = 2;
            this.grbTimHoaDon.TabStop = false;
            this.grbTimHoaDon.Text = "Tìm HH";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(284, 133);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(96, 41);
            this.btnLamMoi.TabIndex = 11;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(73, 133);
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
            this.txtTimKiem.Location = new System.Drawing.Point(140, 34);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(175, 22);
            this.txtTimKiem.TabIndex = 10;
            // 
            // radTimTheoSL
            // 
            this.radTimTheoSL.AutoSize = true;
            this.radTimTheoSL.Location = new System.Drawing.Point(284, 88);
            this.radTimTheoSL.Name = "radTimTheoSL";
            this.radTimTheoSL.Size = new System.Drawing.Size(154, 21);
            this.radTimTheoSL.TabIndex = 1;
            this.radTimTheoSL.Text = "Tìm Theo Số Lượng";
            this.radTimTheoSL.UseVisualStyleBackColor = true;
            this.radTimTheoSL.CheckedChanged += new System.EventHandler(this.radTim_CheckedChanged);
            // 
            // radTimTheoMa
            // 
            this.radTimTheoMa.AutoSize = true;
            this.radTimTheoMa.Checked = true;
            this.radTimTheoMa.Location = new System.Drawing.Point(57, 88);
            this.radTimTheoMa.Name = "radTimTheoMa";
            this.radTimTheoMa.Size = new System.Drawing.Size(112, 21);
            this.radTimTheoMa.TabIndex = 0;
            this.radTimTheoMa.TabStop = true;
            this.radTimTheoMa.Text = "Tìm Theo Mã";
            this.radTimTheoMa.UseVisualStyleBackColor = true;
            this.radTimTheoMa.CheckedChanged += new System.EventHandler(this.radTim_CheckedChanged);
            // 
            // btnThemVaoPhieu
            // 
            this.btnThemVaoPhieu.Location = new System.Drawing.Point(337, 365);
            this.btnThemVaoPhieu.Name = "btnThemVaoPhieu";
            this.btnThemVaoPhieu.Size = new System.Drawing.Size(126, 58);
            this.btnThemVaoPhieu.TabIndex = 1;
            this.btnThemVaoPhieu.Text = "Thêm Vào Phiếu";
            this.btnThemVaoPhieu.UseVisualStyleBackColor = true;
            // 
            // pnlCenterLeft
            // 
            this.pnlCenterLeft.Controls.Add(this.dgvHangHoa);
            this.pnlCenterLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCenterLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlCenterLeft.Name = "pnlCenterLeft";
            this.pnlCenterLeft.Size = new System.Drawing.Size(658, 777);
            this.pnlCenterLeft.TabIndex = 0;
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.AllowUserToAddRows = false;
            this.dgvHangHoa.AllowUserToDeleteRows = false;
            this.dgvHangHoa.AutoGenerateColumns = false;
            this.dgvHangHoa.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ThemPhieuIn,
            this.maHangHoaDataGridViewTextBoxColumn,
            this.tenHangHoaDataGridViewTextBoxColumn,
            this.loaiHangHoaDataGridViewTextBoxColumn,
            this.hangSanXuatDataGridViewTextBoxColumn,
            this.giaNhapDataGridViewTextBoxColumn,
            this.giaBanDataGridViewTextBoxColumn,
            this.soLuongConDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewCheckBoxColumn,
            this.imageDataGridViewImageColumn,
            this.chuThichDataGridViewTextBoxColumn});
            this.dgvHangHoa.DataSource = this.classHangHoaBindingSource;
            this.dgvHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHangHoa.Location = new System.Drawing.Point(0, 0);
            this.dgvHangHoa.MultiSelect = false;
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.ReadOnly = true;
            this.dgvHangHoa.RowHeadersVisible = false;
            this.dgvHangHoa.RowHeadersWidth = 51;
            this.dgvHangHoa.RowTemplate.Height = 24;
            this.dgvHangHoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvHangHoa.Size = new System.Drawing.Size(658, 777);
            this.dgvHangHoa.TabIndex = 3;
            this.dgvHangHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_CellClick);
            // 
            // ThemPhieuIn
            // 
            this.ThemPhieuIn.HeaderText = "Thêm Vào Phiếu";
            this.ThemPhieuIn.MinimumWidth = 6;
            this.ThemPhieuIn.Name = "ThemPhieuIn";
            this.ThemPhieuIn.ReadOnly = true;
            this.ThemPhieuIn.Width = 125;
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
            this.hangSanXuatDataGridViewTextBoxColumn.Width = 125;
            // 
            // giaNhapDataGridViewTextBoxColumn
            // 
            this.giaNhapDataGridViewTextBoxColumn.DataPropertyName = "GiaNhap";
            this.giaNhapDataGridViewTextBoxColumn.HeaderText = "GiaNhap";
            this.giaNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaNhapDataGridViewTextBoxColumn.Name = "giaNhapDataGridViewTextBoxColumn";
            this.giaNhapDataGridViewTextBoxColumn.ReadOnly = true;
            this.giaNhapDataGridViewTextBoxColumn.Visible = false;
            this.giaNhapDataGridViewTextBoxColumn.Width = 125;
            // 
            // giaBanDataGridViewTextBoxColumn
            // 
            this.giaBanDataGridViewTextBoxColumn.DataPropertyName = "GiaBan";
            this.giaBanDataGridViewTextBoxColumn.HeaderText = "GiaBan";
            this.giaBanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaBanDataGridViewTextBoxColumn.Name = "giaBanDataGridViewTextBoxColumn";
            this.giaBanDataGridViewTextBoxColumn.ReadOnly = true;
            this.giaBanDataGridViewTextBoxColumn.Visible = false;
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
            this.trangThaiDataGridViewCheckBoxColumn.Visible = false;
            this.trangThaiDataGridViewCheckBoxColumn.Width = 125;
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
            // chuThichDataGridViewTextBoxColumn
            // 
            this.chuThichDataGridViewTextBoxColumn.DataPropertyName = "ChuThich";
            this.chuThichDataGridViewTextBoxColumn.HeaderText = "ChuThich";
            this.chuThichDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chuThichDataGridViewTextBoxColumn.Name = "chuThichDataGridViewTextBoxColumn";
            this.chuThichDataGridViewTextBoxColumn.ReadOnly = true;
            this.chuThichDataGridViewTextBoxColumn.Width = 125;
            // 
            // classHangHoaBindingSource
            // 
            this.classHangHoaBindingSource.DataSource = typeof(QuanLyQuanAo.DAO.ClassHangHoa);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(689, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Mã HH";
            // 
            // txtMaHH
            // 
            this.txtMaHH.Location = new System.Drawing.Point(758, 56);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.ReadOnly = true;
            this.txtMaHH.Size = new System.Drawing.Size(63, 22);
            this.txtMaHH.TabIndex = 32;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(1038, 199);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(116, 54);
            this.btnDong.TabIndex = 31;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.txtSLNhap);
            this.pnlBottom.Controls.Add(this.btnXoaHH);
            this.pnlBottom.Controls.Add(this.btnLuuPhieu);
            this.pnlBottom.Controls.Add(this.btnXoaPhieu);
            this.pnlBottom.Controls.Add(this.pnlB_left);
            this.pnlBottom.Controls.Add(this.pnlB_Top);
            this.pnlBottom.Controls.Add(this.btnDong);
            this.pnlBottom.Controls.Add(this.label8);
            this.pnlBottom.Controls.Add(this.btnThemSLList);
            this.pnlBottom.Controls.Add(this.txtMaHH);
            this.pnlBottom.Controls.Add(this.label1);
            this.pnlBottom.Controls.Add(this.btnThemSL1Mon);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 579);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1157, 276);
            this.pnlBottom.TabIndex = 2;
            // 
            // txtSLNhap
            // 
            this.txtSLNhap.Location = new System.Drawing.Point(937, 59);
            this.txtSLNhap.Name = "txtSLNhap";
            this.txtSLNhap.Size = new System.Drawing.Size(100, 22);
            this.txtSLNhap.TabIndex = 36;
            // 
            // btnXoaHH
            // 
            this.btnXoaHH.Location = new System.Drawing.Point(683, 121);
            this.btnXoaHH.Name = "btnXoaHH";
            this.btnXoaHH.Size = new System.Drawing.Size(111, 53);
            this.btnXoaHH.TabIndex = 34;
            this.btnXoaHH.Text = "Xóa HH trong Phiếu";
            this.btnXoaHH.UseVisualStyleBackColor = true;
            // 
            // btnLuuPhieu
            // 
            this.btnLuuPhieu.Location = new System.Drawing.Point(864, 196);
            this.btnLuuPhieu.Name = "btnLuuPhieu";
            this.btnLuuPhieu.Size = new System.Drawing.Size(111, 57);
            this.btnLuuPhieu.TabIndex = 33;
            this.btnLuuPhieu.Text = "Lưu Phiếu";
            this.btnLuuPhieu.UseVisualStyleBackColor = true;
            // 
            // btnXoaPhieu
            // 
            this.btnXoaPhieu.Location = new System.Drawing.Point(683, 196);
            this.btnXoaPhieu.Name = "btnXoaPhieu";
            this.btnXoaPhieu.Size = new System.Drawing.Size(111, 57);
            this.btnXoaPhieu.TabIndex = 33;
            this.btnXoaPhieu.Text = "Xóa Phiếu";
            this.btnXoaPhieu.UseVisualStyleBackColor = true;
            // 
            // pnlB_left
            // 
            this.pnlB_left.Controls.Add(this.dataGridView1);
            this.pnlB_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlB_left.Location = new System.Drawing.Point(0, 37);
            this.pnlB_left.Name = "pnlB_left";
            this.pnlB_left.Size = new System.Drawing.Size(658, 239);
            this.pnlB_left.TabIndex = 32;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(658, 239);
            this.dataGridView1.TabIndex = 4;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Thêm Phiếu In";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Visible = false;
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // pnlB_Top
            // 
            this.pnlB_Top.Controls.Add(this.label5);
            this.pnlB_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlB_Top.Location = new System.Drawing.Point(0, 0);
            this.pnlB_Top.Name = "pnlB_Top";
            this.pnlB_Top.Size = new System.Drawing.Size(1157, 37);
            this.pnlB_Top.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1157, 37);
            this.label5.TabIndex = 3;
            this.label5.Text = "Phiếu Nhập";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(861, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "SL Nhập";
            // 
            // btnThemSLList
            // 
            this.btnThemSLList.Location = new System.Drawing.Point(864, 120);
            this.btnThemSLList.Name = "btnThemSLList";
            this.btnThemSLList.Size = new System.Drawing.Size(111, 54);
            this.btnThemSLList.TabIndex = 35;
            this.btnThemSLList.Text = "Thêm SL Hàng Loạt";
            this.btnThemSLList.UseVisualStyleBackColor = true;
            // 
            // btnThemSL1Mon
            // 
            this.btnThemSL1Mon.Location = new System.Drawing.Point(1038, 116);
            this.btnThemSL1Mon.Name = "btnThemSL1Mon";
            this.btnThemSL1Mon.Size = new System.Drawing.Size(116, 58);
            this.btnThemSL1Mon.TabIndex = 1;
            this.btnThemSL1Mon.Text = "Thêm SL vào 1 Món";
            this.btnThemSL1Mon.UseVisualStyleBackColor = true;
            // 
            // frmPhieuNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 855);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmPhieuNhapHang";
            this.Text = "Phiếu Nhập Hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNhapHang_FormClosed);
            this.Load += new System.EventHandler(this.frmNhapHang_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            this.pnlC_left.ResumeLayout(false);
            this.pnlC_left.PerformLayout();
            this.grbTimHoaDon.ResumeLayout(false);
            this.grbTimHoaDon.PerformLayout();
            this.pnlCenterLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classHangHoaBindingSource)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlB_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlB_Top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Button btnThemVaoPhieu;
        private System.Windows.Forms.Panel pnlCenterLeft;
        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.Panel pnlC_left;
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.BindingSource classHangHoaBindingSource;
        private System.Windows.Forms.GroupBox grbTimHoaDon;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RadioButton radTimTheoSL;
        private System.Windows.Forms.RadioButton radTimTheoMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLoaiHH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSLCon;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnThemHangLoat;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnXoaHH;
        private System.Windows.Forms.Button btnXoaPhieu;
        private System.Windows.Forms.Panel pnlB_left;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Panel pnlB_Top;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLuuPhieu;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.DateTimePicker datePic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ThemPhieuIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHangHoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHangHoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiHangHoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hangSanXuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongConDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn trangThaiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chuThichDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnThemSLList;
        private System.Windows.Forms.Button btnThemSL1Mon;
        private System.Windows.Forms.TextBox txtSLNhap;
        private System.Windows.Forms.Label label8;
    }
}