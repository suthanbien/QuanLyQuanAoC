namespace QuanLyQuanAo.GUI
{
    partial class frmHangSanXuat
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
            this.btgNhomLenh = new QuanLyQuanAo.GUI.ButtonGroup();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.dgvHangSanXuat = new System.Windows.Forms.DataGridView();
            this.maHangSanXuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHangSanXuatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangSanXuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangSanXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangSanXuatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.blbLoaiSanPham);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1174, 100);
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
            this.blbLoaiSanPham.Size = new System.Drawing.Size(1174, 100);
            this.blbLoaiSanPham.TabIndex = 2;
            this.blbLoaiSanPham.Text = "Hãng Sản Xuất";
            this.blbLoaiSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btgNhomLenh);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 466);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1174, 85);
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
            this.btgNhomLenh.Extra2Text = "Phụ Trội 2";
            this.btgNhomLenh.Extra2Visible = false;
            this.btgNhomLenh.ExtraEnabled = true;
            this.btgNhomLenh.ExtraText = "Phụ Trội";
            this.btgNhomLenh.ExtraVisible = false;
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
            this.btgNhomLenh.Size = new System.Drawing.Size(1174, 85);
            this.btgNhomLenh.TabIndex = 0;
            this.btgNhomLenh.TenTimKiem = "";
            this.btgNhomLenh.Display += new QuanLyQuanAo.GUI.ButtonGroupEventHandler(this.btgNhomLenh_Display);
            this.btgNhomLenh.AddClick += new QuanLyQuanAo.GUI.ButtonGroupEventHandler(this.btgNhomLenh_AddClick);
            this.btgNhomLenh.EditClick += new QuanLyQuanAo.GUI.ButtonGroupEventHandler(this.btgNhomLenh_EditClick);
            this.btgNhomLenh.SaveClick += new QuanLyQuanAo.GUI.ButtonGroupEventHandler(this.btgNhomLenh_SaveClick);
            this.btgNhomLenh.CancelClick += new QuanLyQuanAo.GUI.ButtonGroupEventHandler(this.btgNhomLenh_CancelClick);
            this.btgNhomLenh.DeleteClick += new QuanLyQuanAo.GUI.ButtonGroupEventHandler(this.btgNhomLenh_DeleteClick);
            this.btgNhomLenh.TimKiemClick += new QuanLyQuanAo.GUI.ButtonGroupEventHandler(this.btgNhomLenh_TimKiemClick);
            this.btgNhomLenh.RadTimClick += new QuanLyQuanAo.GUI.ButtonGroupEventHandler(this.btgNhomLenh_RadTimClick);
            this.btgNhomLenh.Load += new System.EventHandler(this.btgNhomLenh_Load);
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.dgvHangSanXuat);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 100);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1174, 366);
            this.pnlCenter.TabIndex = 2;
            // 
            // dgvHangSanXuat
            // 
            this.dgvHangSanXuat.AllowUserToAddRows = false;
            this.dgvHangSanXuat.AllowUserToDeleteRows = false;
            this.dgvHangSanXuat.AutoGenerateColumns = false;
            this.dgvHangSanXuat.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvHangSanXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangSanXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHangSanXuatDataGridViewTextBoxColumn,
            this.tenHangSanXuatDataGridViewTextBoxColumn});
            this.dgvHangSanXuat.DataSource = this.hangSanXuatBindingSource;
            this.dgvHangSanXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHangSanXuat.Location = new System.Drawing.Point(0, 0);
            this.dgvHangSanXuat.MultiSelect = false;
            this.dgvHangSanXuat.Name = "dgvHangSanXuat";
            this.dgvHangSanXuat.ReadOnly = true;
            this.dgvHangSanXuat.RowHeadersWidth = 51;
            this.dgvHangSanXuat.RowTemplate.Height = 24;
            this.dgvHangSanXuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvHangSanXuat.Size = new System.Drawing.Size(1174, 366);
            this.dgvHangSanXuat.TabIndex = 2;
            this.dgvHangSanXuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangSanXuat_CellClick);
            // 
            // maHangSanXuatDataGridViewTextBoxColumn
            // 
            this.maHangSanXuatDataGridViewTextBoxColumn.DataPropertyName = "MaHangSanXuat";
            this.maHangSanXuatDataGridViewTextBoxColumn.HeaderText = "Mã Hãng Sản Xuất";
            this.maHangSanXuatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maHangSanXuatDataGridViewTextBoxColumn.Name = "maHangSanXuatDataGridViewTextBoxColumn";
            this.maHangSanXuatDataGridViewTextBoxColumn.ReadOnly = true;
            this.maHangSanXuatDataGridViewTextBoxColumn.Width = 200;
            // 
            // tenHangSanXuatDataGridViewTextBoxColumn
            // 
            this.tenHangSanXuatDataGridViewTextBoxColumn.DataPropertyName = "TenHangSanXuat";
            this.tenHangSanXuatDataGridViewTextBoxColumn.HeaderText = "Tên Hãng Sản Xuất";
            this.tenHangSanXuatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenHangSanXuatDataGridViewTextBoxColumn.Name = "tenHangSanXuatDataGridViewTextBoxColumn";
            this.tenHangSanXuatDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenHangSanXuatDataGridViewTextBoxColumn.Width = 500;
            // 
            // hangSanXuatBindingSource
            // 
            this.hangSanXuatBindingSource.DataSource = typeof(QuanLyQuanAo.DAO.HangSanXuat);
            // 
            // frmHangSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 551);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmHangSanXuat";
            this.Text = "frmHangSanXuat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHangSanXuat_FormClosed);
            this.Load += new System.EventHandler(this.frmHangSanXuat_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangSanXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangSanXuatBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Label blbLoaiSanPham;
        private ButtonGroup btgNhomLenh;
        private System.Windows.Forms.DataGridView dgvHangSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHangSanXuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHangSanXuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hangSanXuatBindingSource;
    }
}