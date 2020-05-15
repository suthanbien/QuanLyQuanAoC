namespace QuanLyQuanAo.GUI
{
    partial class frmQLNhanVien
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
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.pnlT_Top = new System.Windows.Forms.Panel();
            this.lblSanPham = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btgNhomLenh = new QuanLyQuanAo.GUI.ButtonGroup();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.maNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMNDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayVaoLamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayNghiLamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.classNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ricChuThich = new System.Windows.Forms.RichTextBox();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMLSP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGiaTien = new System.Windows.Forms.Label();
            this.lblSL = new System.Windows.Forms.Label();
            this.lblTenSp = new System.Windows.Forms.Label();
            this.lblMaSp = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.pnlT_Top.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classNhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.txtSDT);
            this.pnlTop.Controls.Add(this.txtDiaChi);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Controls.Add(this.ricChuThich);
            this.pnlTop.Controls.Add(this.txtAnh);
            this.pnlTop.Controls.Add(this.txtChucVu);
            this.pnlTop.Controls.Add(this.txtGioiTinh);
            this.pnlTop.Controls.Add(this.txtCMND);
            this.pnlTop.Controls.Add(this.txtNgaySinh);
            this.pnlTop.Controls.Add(this.txtEmail);
            this.pnlTop.Controls.Add(this.txtTenNV);
            this.pnlTop.Controls.Add(this.txtMaNV);
            this.pnlTop.Controls.Add(this.label7);
            this.pnlTop.Controls.Add(this.lblMLSP);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.label5);
            this.pnlTop.Controls.Add(this.lblGiaTien);
            this.pnlTop.Controls.Add(this.lblSL);
            this.pnlTop.Controls.Add(this.lblTenSp);
            this.pnlTop.Controls.Add(this.lblMaSp);
            this.pnlTop.Controls.Add(this.picAnh);
            this.pnlTop.Controls.Add(this.pnlT_Top);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1201, 409);
            this.pnlTop.TabIndex = 0;
            // 
            // picAnh
            // 
            this.picAnh.Dock = System.Windows.Forms.DockStyle.Right;
            this.picAnh.Location = new System.Drawing.Point(826, 76);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(375, 333);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnh.TabIndex = 5;
            this.picAnh.TabStop = false;
            // 
            // pnlT_Top
            // 
            this.pnlT_Top.Controls.Add(this.lblSanPham);
            this.pnlT_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlT_Top.Location = new System.Drawing.Point(0, 0);
            this.pnlT_Top.Name = "pnlT_Top";
            this.pnlT_Top.Size = new System.Drawing.Size(1201, 76);
            this.pnlT_Top.TabIndex = 0;
            // 
            // lblSanPham
            // 
            this.lblSanPham.BackColor = System.Drawing.Color.Chartreuse;
            this.lblSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanPham.ForeColor = System.Drawing.Color.Crimson;
            this.lblSanPham.Location = new System.Drawing.Point(0, 0);
            this.lblSanPham.Name = "lblSanPham";
            this.lblSanPham.Size = new System.Drawing.Size(1201, 76);
            this.lblSanPham.TabIndex = 2;
            this.lblSanPham.Text = "Danh Mục Nhân Viên";
            this.lblSanPham.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btgNhomLenh);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 607);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1201, 80);
            this.pnlBottom.TabIndex = 1;
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
            this.btgNhomLenh.Size = new System.Drawing.Size(1201, 80);
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
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.dgvNhanVien);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 409);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1201, 198);
            this.pnlCenter.TabIndex = 2;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.AutoGenerateColumns = false;
            this.dgvNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhanVienDataGridViewTextBoxColumn,
            this.tenNhanVienDataGridViewTextBoxColumn,
            this.chucVuDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.cMNDDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.ngayVaoLamDataGridViewTextBoxColumn,
            this.ngayNghiLamDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.soDTDataGridViewTextBoxColumn,
            this.tinhTrangDataGridViewCheckBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.dgvNhanVien.DataSource = this.classNhanVienBindingSource;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dgvNhanVien.MultiSelect = false;
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(1201, 198);
            this.dgvNhanVien.TabIndex = 3;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            this.dgvNhanVien.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvSanPham_EditingControlShowing);
            // 
            // maNhanVienDataGridViewTextBoxColumn
            // 
            this.maNhanVienDataGridViewTextBoxColumn.DataPropertyName = "MaNhanVien";
            this.maNhanVienDataGridViewTextBoxColumn.HeaderText = "MaNhanVien";
            this.maNhanVienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNhanVienDataGridViewTextBoxColumn.Name = "maNhanVienDataGridViewTextBoxColumn";
            this.maNhanVienDataGridViewTextBoxColumn.ReadOnly = true;
            this.maNhanVienDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenNhanVienDataGridViewTextBoxColumn
            // 
            this.tenNhanVienDataGridViewTextBoxColumn.DataPropertyName = "TenNhanVien";
            this.tenNhanVienDataGridViewTextBoxColumn.HeaderText = "TenNhanVien";
            this.tenNhanVienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNhanVienDataGridViewTextBoxColumn.Name = "tenNhanVienDataGridViewTextBoxColumn";
            this.tenNhanVienDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenNhanVienDataGridViewTextBoxColumn.Width = 125;
            // 
            // chucVuDataGridViewTextBoxColumn
            // 
            this.chucVuDataGridViewTextBoxColumn.DataPropertyName = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn.HeaderText = "ChucVu";
            this.chucVuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.chucVuDataGridViewTextBoxColumn.Name = "chucVuDataGridViewTextBoxColumn";
            this.chucVuDataGridViewTextBoxColumn.ReadOnly = true;
            this.chucVuDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngaySinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            this.gioiTinhDataGridViewTextBoxColumn.ReadOnly = true;
            this.gioiTinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // cMNDDataGridViewTextBoxColumn
            // 
            this.cMNDDataGridViewTextBoxColumn.DataPropertyName = "CMND";
            this.cMNDDataGridViewTextBoxColumn.HeaderText = "CMND";
            this.cMNDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cMNDDataGridViewTextBoxColumn.Name = "cMNDDataGridViewTextBoxColumn";
            this.cMNDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cMNDDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayVaoLamDataGridViewTextBoxColumn
            // 
            this.ngayVaoLamDataGridViewTextBoxColumn.DataPropertyName = "NgayVaoLam";
            this.ngayVaoLamDataGridViewTextBoxColumn.HeaderText = "NgayVaoLam";
            this.ngayVaoLamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayVaoLamDataGridViewTextBoxColumn.Name = "ngayVaoLamDataGridViewTextBoxColumn";
            this.ngayVaoLamDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayVaoLamDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayNghiLamDataGridViewTextBoxColumn
            // 
            this.ngayNghiLamDataGridViewTextBoxColumn.DataPropertyName = "NgayNghiLam";
            this.ngayNghiLamDataGridViewTextBoxColumn.HeaderText = "NgayNghiLam";
            this.ngayNghiLamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayNghiLamDataGridViewTextBoxColumn.Name = "ngayNghiLamDataGridViewTextBoxColumn";
            this.ngayNghiLamDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngayNghiLamDataGridViewTextBoxColumn.Width = 125;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.ReadOnly = true;
            this.diaChiDataGridViewTextBoxColumn.Width = 125;
            // 
            // soDTDataGridViewTextBoxColumn
            // 
            this.soDTDataGridViewTextBoxColumn.DataPropertyName = "SoDT";
            this.soDTDataGridViewTextBoxColumn.HeaderText = "SoDT";
            this.soDTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soDTDataGridViewTextBoxColumn.Name = "soDTDataGridViewTextBoxColumn";
            this.soDTDataGridViewTextBoxColumn.ReadOnly = true;
            this.soDTDataGridViewTextBoxColumn.Width = 125;
            // 
            // tinhTrangDataGridViewCheckBoxColumn
            // 
            this.tinhTrangDataGridViewCheckBoxColumn.DataPropertyName = "TinhTrang";
            this.tinhTrangDataGridViewCheckBoxColumn.HeaderText = "TinhTrang";
            this.tinhTrangDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.tinhTrangDataGridViewCheckBoxColumn.Name = "tinhTrangDataGridViewCheckBoxColumn";
            this.tinhTrangDataGridViewCheckBoxColumn.ReadOnly = true;
            this.tinhTrangDataGridViewCheckBoxColumn.Width = 125;
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
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.MinimumWidth = 6;
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.ReadOnly = true;
            this.imageDataGridViewImageColumn.Width = 125;
            // 
            // classNhanVienBindingSource
            // 
            this.classNhanVienBindingSource.DataSource = typeof(QuanLyQuanAo.DAO.ClassNhanVien);
            // 
            // ricChuThich
            // 
            this.ricChuThich.Location = new System.Drawing.Point(500, 310);
            this.ricChuThich.Name = "ricChuThich";
            this.ricChuThich.ReadOnly = true;
            this.ricChuThich.Size = new System.Drawing.Size(228, 81);
            this.ricChuThich.TabIndex = 42;
            this.ricChuThich.Text = "";
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(746, 369);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.ReadOnly = true;
            this.txtAnh.Size = new System.Drawing.Size(74, 22);
            this.txtAnh.TabIndex = 41;
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(206, 223);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.ReadOnly = true;
            this.txtChucVu.Size = new System.Drawing.Size(138, 22);
            this.txtChucVu.TabIndex = 34;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(573, 160);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.ReadOnly = true;
            this.txtGioiTinh.Size = new System.Drawing.Size(138, 22);
            this.txtGioiTinh.TabIndex = 35;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(206, 329);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.ReadOnly = true;
            this.txtCMND.Size = new System.Drawing.Size(138, 22);
            this.txtCMND.TabIndex = 36;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(207, 274);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.ReadOnly = true;
            this.txtNgaySinh.Size = new System.Drawing.Size(138, 22);
            this.txtNgaySinh.TabIndex = 37;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(573, 102);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(138, 22);
            this.txtEmail.TabIndex = 38;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(206, 165);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.ReadOnly = true;
            this.txtTenNV.Size = new System.Drawing.Size(138, 22);
            this.txtTenNV.TabIndex = 39;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(206, 102);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(138, 22);
            this.txtMaNV.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(422, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Chú Thích";
            // 
            // lblMLSP
            // 
            this.lblMLSP.AutoSize = true;
            this.lblMLSP.Location = new System.Drawing.Point(55, 223);
            this.lblMLSP.Name = "lblMLSP";
            this.lblMLSP.Size = new System.Drawing.Size(61, 17);
            this.lblMLSP.TabIndex = 33;
            this.lblMLSP.Text = "Chức Vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "CMND";
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.Location = new System.Drawing.Point(55, 274);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(73, 17);
            this.lblGiaTien.TabIndex = 31;
            this.lblGiaTien.Text = "Ngày Sinh";
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Location = new System.Drawing.Point(422, 105);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(42, 17);
            this.lblSL.TabIndex = 28;
            this.lblSL.Text = "Email";
            // 
            // lblTenSp
            // 
            this.lblTenSp.AutoSize = true;
            this.lblTenSp.Location = new System.Drawing.Point(55, 170);
            this.lblTenSp.Name = "lblTenSp";
            this.lblTenSp.Size = new System.Drawing.Size(103, 17);
            this.lblTenSp.TabIndex = 27;
            this.lblTenSp.Text = "Tên Nhân Viên";
            // 
            // lblMaSp
            // 
            this.lblMaSp.AutoSize = true;
            this.lblMaSp.Location = new System.Drawing.Point(55, 105);
            this.lblMaSp.Name = "lblMaSp";
            this.lblMaSp.Size = new System.Drawing.Size(97, 17);
            this.lblMaSp.TabIndex = 26;
            this.lblMaSp.Text = "Mã Nhân Viên";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(573, 249);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(138, 22);
            this.txtSDT.TabIndex = 45;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(573, 206);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(138, 22);
            this.txtDiaChi.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "SDT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Dịa Chỉ";
            // 
            // frmQLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 687);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmQLNhanVien";
            this.Text = "frmQLNhanVien";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmQLNhanVien_FormClosed);
            this.Load += new System.EventHandler(this.frmQLNhanVien_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.pnlT_Top.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classNhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private ButtonGroup btgNhomLenh;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Panel pnlT_Top;
        private System.Windows.Forms.Label lblSanPham;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMNDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayVaoLamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNghiLamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tinhTrangDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.BindingSource classNhanVienBindingSource;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox ricChuThich;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMLSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblGiaTien;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.Label lblTenSp;
        private System.Windows.Forms.Label lblMaSp;
    }
}