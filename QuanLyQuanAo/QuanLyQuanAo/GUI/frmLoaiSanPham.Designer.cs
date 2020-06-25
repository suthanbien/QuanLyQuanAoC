namespace QuanLyQuanAo.GUI
{
    partial class frmLoaiSanPham
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
            this.dgvLoaiSanPham = new System.Windows.Forms.DataGridView();
            this.maLoaiSanPhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiSanPhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btgNhomLenh = new QuanLyQuanAo.GUI.ButtonGroup();
            this.pnCenter = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSanPhamBindingSource)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.blbLoaiSanPham);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1183, 67);
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
            this.blbLoaiSanPham.Size = new System.Drawing.Size(1183, 67);
            this.blbLoaiSanPham.TabIndex = 1;
            this.blbLoaiSanPham.Text = "Loại Sản Phẩm";
            this.blbLoaiSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvLoaiSanPham
            // 
            this.dgvLoaiSanPham.AllowUserToAddRows = false;
            this.dgvLoaiSanPham.AllowUserToDeleteRows = false;
            this.dgvLoaiSanPham.AutoGenerateColumns = false;
            this.dgvLoaiSanPham.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvLoaiSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLoaiSanPhamDataGridViewTextBoxColumn,
            this.tenLoaiSanPhamDataGridViewTextBoxColumn});
            this.dgvLoaiSanPham.DataSource = this.loaiSanPhamBindingSource;
            this.dgvLoaiSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoaiSanPham.Location = new System.Drawing.Point(0, 0);
            this.dgvLoaiSanPham.MultiSelect = false;
            this.dgvLoaiSanPham.Name = "dgvLoaiSanPham";
            this.dgvLoaiSanPham.ReadOnly = true;
            this.dgvLoaiSanPham.RowHeadersVisible = false;
            this.dgvLoaiSanPham.RowHeadersWidth = 51;
            this.dgvLoaiSanPham.RowTemplate.Height = 24;
            this.dgvLoaiSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvLoaiSanPham.Size = new System.Drawing.Size(1183, 308);
            this.dgvLoaiSanPham.TabIndex = 1;
            this.dgvLoaiSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiSanPham_CellClick);
            // 
            // maLoaiSanPhamDataGridViewTextBoxColumn
            // 
            this.maLoaiSanPhamDataGridViewTextBoxColumn.DataPropertyName = "MaLoaiSanPham";
            this.maLoaiSanPhamDataGridViewTextBoxColumn.HeaderText = "Mã Loại Sản Phẩm";
            this.maLoaiSanPhamDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.maLoaiSanPhamDataGridViewTextBoxColumn.Name = "maLoaiSanPhamDataGridViewTextBoxColumn";
            this.maLoaiSanPhamDataGridViewTextBoxColumn.ReadOnly = true;
            this.maLoaiSanPhamDataGridViewTextBoxColumn.Width = 200;
            // 
            // tenLoaiSanPhamDataGridViewTextBoxColumn
            // 
            this.tenLoaiSanPhamDataGridViewTextBoxColumn.DataPropertyName = "TenLoaiSanPham";
            this.tenLoaiSanPhamDataGridViewTextBoxColumn.HeaderText = "Tên Loại Sản Phẩm";
            this.tenLoaiSanPhamDataGridViewTextBoxColumn.MinimumWidth = 500;
            this.tenLoaiSanPhamDataGridViewTextBoxColumn.Name = "tenLoaiSanPhamDataGridViewTextBoxColumn";
            this.tenLoaiSanPhamDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenLoaiSanPhamDataGridViewTextBoxColumn.Width = 500;
            // 
            // loaiSanPhamBindingSource
            // 
            this.loaiSanPhamBindingSource.DataSource = typeof(QuanLyQuanAo.DAO.LoaiSanPham);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btgNhomLenh);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 375);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1183, 71);
            this.pnlBottom.TabIndex = 0;
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
            this.btgNhomLenh.Size = new System.Drawing.Size(1183, 71);
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
            this.btgNhomLenh.RadTimClick += new QuanLyQuanAo.GUI.ButtonGroupEventHandler(this.btgNhomLenh_RadTimClick);
            this.btgNhomLenh.Load += new System.EventHandler(this.btgNhomLenh_Load);
            // 
            // pnCenter
            // 
            this.pnCenter.Controls.Add(this.dgvLoaiSanPham);
            this.pnCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCenter.Location = new System.Drawing.Point(0, 67);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(1183, 308);
            this.pnCenter.TabIndex = 2;
            // 
            // frmLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 446);
            this.Controls.Add(this.pnCenter);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmLoaiSanPham";
            this.Text = "Loại Sản Phẩm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLoaiSanPham_FormClosed);
            this.Load += new System.EventHandler(this.frmLoaiSanPham_Load);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSanPhamBindingSource)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private ButtonGroup btgNhomLenh;
        private System.Windows.Forms.Label blbLoaiSanPham;
        private System.Windows.Forms.DataGridView dgvLoaiSanPham;
        private System.Windows.Forms.Panel pnCenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiSanPhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiSanPhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource loaiSanPhamBindingSource;
    }
}