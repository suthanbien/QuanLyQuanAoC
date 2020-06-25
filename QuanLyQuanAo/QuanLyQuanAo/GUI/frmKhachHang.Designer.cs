namespace QuanLyQuanAo.GUI
{
    partial class frmKhachHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.maKhachHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhachHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiKhachHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.classKhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.pnlT_Top.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classKhachHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
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
            this.picAnh.TabIndex = 6;
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
            this.lblSanPham.TabIndex = 3;
            this.lblSanPham.Text = "Danh Mục Khách Hàng";
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
            this.btgNhomLenh.TabIndex = 1;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvNhanVien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 409);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 198);
            this.panel1.TabIndex = 2;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.AutoGenerateColumns = false;
            this.dgvNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKhachHangDataGridViewTextBoxColumn,
            this.tenKhachHangDataGridViewTextBoxColumn,
            this.ngaysinhDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.loaiKhachHangDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.dgvNhanVien.DataSource = this.classKhachHangBindingSource;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dgvNhanVien.MultiSelect = false;
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(1201, 198);
            this.dgvNhanVien.TabIndex = 4;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // maKhachHangDataGridViewTextBoxColumn
            // 
            this.maKhachHangDataGridViewTextBoxColumn.DataPropertyName = "MaKhachHang";
            this.maKhachHangDataGridViewTextBoxColumn.HeaderText = "MaKhachHang";
            this.maKhachHangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maKhachHangDataGridViewTextBoxColumn.Name = "maKhachHangDataGridViewTextBoxColumn";
            this.maKhachHangDataGridViewTextBoxColumn.ReadOnly = true;
            this.maKhachHangDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenKhachHangDataGridViewTextBoxColumn
            // 
            this.tenKhachHangDataGridViewTextBoxColumn.DataPropertyName = "TenKhachHang";
            this.tenKhachHangDataGridViewTextBoxColumn.HeaderText = "TenKhachHang";
            this.tenKhachHangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenKhachHangDataGridViewTextBoxColumn.Name = "tenKhachHangDataGridViewTextBoxColumn";
            this.tenKhachHangDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenKhachHangDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaysinhDataGridViewTextBoxColumn
            // 
            this.ngaysinhDataGridViewTextBoxColumn.DataPropertyName = "Ngaysinh";
            this.ngaysinhDataGridViewTextBoxColumn.HeaderText = "Ngaysinh";
            this.ngaysinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaysinhDataGridViewTextBoxColumn.Name = "ngaysinhDataGridViewTextBoxColumn";
            this.ngaysinhDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngaysinhDataGridViewTextBoxColumn.Width = 125;
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
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 125;
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
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            this.sDTDataGridViewTextBoxColumn.ReadOnly = true;
            this.sDTDataGridViewTextBoxColumn.Width = 125;
            // 
            // loaiKhachHangDataGridViewTextBoxColumn
            // 
            this.loaiKhachHangDataGridViewTextBoxColumn.DataPropertyName = "LoaiKhachHang";
            this.loaiKhachHangDataGridViewTextBoxColumn.HeaderText = "LoaiKhachHang";
            this.loaiKhachHangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loaiKhachHangDataGridViewTextBoxColumn.Name = "loaiKhachHangDataGridViewTextBoxColumn";
            this.loaiKhachHangDataGridViewTextBoxColumn.ReadOnly = true;
            this.loaiKhachHangDataGridViewTextBoxColumn.Width = 125;
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
            // classKhachHangBindingSource
            // 
            this.classKhachHangBindingSource.DataSource = typeof(QuanLyQuanAo.DAO.ClassKhachHang);
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 687);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmKhachHang";
            this.Text = "Danh Mục Khách Hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmKhachHang_FormClosed);
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.pnlT_Top.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classKhachHangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Panel pnlT_Top;
        private System.Windows.Forms.Label lblSanPham;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhachHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiKhachHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.BindingSource classKhachHangBindingSource;
        private ButtonGroup btgNhomLenh;
    }
}