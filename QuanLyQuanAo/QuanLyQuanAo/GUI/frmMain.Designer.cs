namespace QuanLyQuanAo.GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuTrangChu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLapHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhoHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoaiSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHangSanXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHangHoaDaAn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhieuNhapHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhapHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTKNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoanKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKetThuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.AutoSize = false;
            this.mainMenu.BackgroundImage = global::QuanLyQuanAo.Properties.Resources.blue_pattern_brick_wallpaper_2304x768_13301_103;
            this.mainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainMenu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 1, 0);
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTrangChu,
            this.mnuHoaDon,
            this.mnuKhoHang,
            this.mnuNhanVien,
            this.mnuKhachHang,
            this.mnuThongKe,
            this.mnuHeThong});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(5, 100, 0, 0);
            this.mainMenu.Size = new System.Drawing.Size(1401, 150);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            this.mainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mainMenu_ItemClicked);
            // 
            // mnuTrangChu
            // 
            this.mnuTrangChu.BackColor = System.Drawing.SystemColors.Window;
            this.mnuTrangChu.Image = global::QuanLyQuanAo.Properties.Resources.home_24px;
            this.mnuTrangChu.Margin = new System.Windows.Forms.Padding(2);
            this.mnuTrangChu.Name = "mnuTrangChu";
            this.mnuTrangChu.Size = new System.Drawing.Size(145, 46);
            this.mnuTrangChu.Text = "Trang Chủ";
            this.mnuTrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mnuHoaDon
            // 
            this.mnuHoaDon.BackColor = System.Drawing.SystemColors.Window;
            this.mnuHoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLapHoaDon,
            this.mnuTimHoaDon});
            this.mnuHoaDon.Image = global::QuanLyQuanAo.Properties.Resources.bill_24px;
            this.mnuHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.Size = new System.Drawing.Size(129, 46);
            this.mnuHoaDon.Text = "Hóa Đơn";
            this.mnuHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mnuLapHoaDon
            // 
            this.mnuLapHoaDon.Name = "mnuLapHoaDon";
            this.mnuLapHoaDon.Size = new System.Drawing.Size(235, 34);
            this.mnuLapHoaDon.Text = "Lập Hóa Đơn";
            this.mnuLapHoaDon.Click += new System.EventHandler(this.mnuLapHoaDon_Click);
            // 
            // mnuTimHoaDon
            // 
            this.mnuTimHoaDon.Name = "mnuTimHoaDon";
            this.mnuTimHoaDon.Size = new System.Drawing.Size(235, 34);
            this.mnuTimHoaDon.Text = "Tìm Hóa Đơn";
            this.mnuTimHoaDon.Click += new System.EventHandler(this.mnuTimHoaDon_Click);
            // 
            // mnuKhoHang
            // 
            this.mnuKhoHang.BackColor = System.Drawing.SystemColors.Window;
            this.mnuKhoHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSanPham,
            this.mnuLoaiSanPham,
            this.mnuHangSanXuat,
            this.mnuHangHoaDaAn,
            this.mnuPhieuNhapHang,
            this.mnuNhapHang});
            this.mnuKhoHang.Image = global::QuanLyQuanAo.Properties.Resources.warehouse_24px;
            this.mnuKhoHang.Margin = new System.Windows.Forms.Padding(2);
            this.mnuKhoHang.Name = "mnuKhoHang";
            this.mnuKhoHang.Size = new System.Drawing.Size(139, 46);
            this.mnuKhoHang.Text = "Kho Hàng";
            this.mnuKhoHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mnuSanPham
            // 
            this.mnuSanPham.Name = "mnuSanPham";
            this.mnuSanPham.Size = new System.Drawing.Size(315, 34);
            this.mnuSanPham.Text = "Hàng Hóa";
            this.mnuSanPham.Click += new System.EventHandler(this.mnuSanPham_Click);
            // 
            // mnuLoaiSanPham
            // 
            this.mnuLoaiSanPham.Name = "mnuLoaiSanPham";
            this.mnuLoaiSanPham.Size = new System.Drawing.Size(315, 34);
            this.mnuLoaiSanPham.Text = "Loại Hàng Hóa";
            this.mnuLoaiSanPham.Click += new System.EventHandler(this.mnuLoaiSanPham_Click);
            // 
            // mnuHangSanXuat
            // 
            this.mnuHangSanXuat.Name = "mnuHangSanXuat";
            this.mnuHangSanXuat.Size = new System.Drawing.Size(315, 34);
            this.mnuHangSanXuat.Text = "Hãng Sản Xuất";
            this.mnuHangSanXuat.Click += new System.EventHandler(this.mnuHangSanXuat_Click);
            // 
            // mnuHangHoaDaAn
            // 
            this.mnuHangHoaDaAn.Name = "mnuHangHoaDaAn";
            this.mnuHangHoaDaAn.Size = new System.Drawing.Size(315, 34);
            this.mnuHangHoaDaAn.Text = "Hàng Hóa Đã Ẩn";
            this.mnuHangHoaDaAn.Click += new System.EventHandler(this.mnuHangHoaDaAn_Click);
            // 
            // mnuPhieuNhapHang
            // 
            this.mnuPhieuNhapHang.Name = "mnuPhieuNhapHang";
            this.mnuPhieuNhapHang.Size = new System.Drawing.Size(315, 34);
            this.mnuPhieuNhapHang.Text = "Tạo Phiếu Nhập Hàng";
            this.mnuPhieuNhapHang.Click += new System.EventHandler(this.mnuNhapHang_Click);
            // 
            // mnuNhapHang
            // 
            this.mnuNhapHang.Name = "mnuNhapHang";
            this.mnuNhapHang.Size = new System.Drawing.Size(315, 34);
            this.mnuNhapHang.Text = "Nhập Hàng";
            this.mnuNhapHang.Click += new System.EventHandler(this.mnuNhapHang_Click_1);
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.BackColor = System.Drawing.SystemColors.Window;
            this.mnuNhanVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQLNhanVien,
            this.mnuTKNhanVien});
            this.mnuNhanVien.Image = global::QuanLyQuanAo.Properties.Resources.customer_support_24px;
            this.mnuNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(142, 46);
            this.mnuNhanVien.Text = "Nhân Viên";
            this.mnuNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mnuQLNhanVien
            // 
            this.mnuQLNhanVien.Name = "mnuQLNhanVien";
            this.mnuQLNhanVien.Size = new System.Drawing.Size(394, 34);
            this.mnuQLNhanVien.Text = "Quản Lý Nhân Viên";
            this.mnuQLNhanVien.Click += new System.EventHandler(this.mnuQLNhanVien_Click);
            // 
            // mnuTKNhanVien
            // 
            this.mnuTKNhanVien.Name = "mnuTKNhanVien";
            this.mnuTKNhanVien.Size = new System.Drawing.Size(394, 34);
            this.mnuTKNhanVien.Text = "Quản Lý Tài Khoản Nhân Viên";
            this.mnuTKNhanVien.Click += new System.EventHandler(this.mnuTKNhanVien_Click);
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.BackColor = System.Drawing.SystemColors.Window;
            this.mnuKhachHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQLKhachHang,
            this.mnuTaiKhoanKH});
            this.mnuKhachHang.Image = global::QuanLyQuanAo.Properties.Resources.user_account_30px;
            this.mnuKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.Size = new System.Drawing.Size(161, 46);
            this.mnuKhachHang.Text = "Khách Hàng";
            this.mnuKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mnuQLKhachHang
            // 
            this.mnuQLKhachHang.Name = "mnuQLKhachHang";
            this.mnuQLKhachHang.Size = new System.Drawing.Size(327, 34);
            this.mnuQLKhachHang.Text = "Quản Lý Khách Hàng";
            this.mnuQLKhachHang.Click += new System.EventHandler(this.mnuQLKhachHang_Click);
            // 
            // mnuTaiKhoanKH
            // 
            this.mnuTaiKhoanKH.Name = "mnuTaiKhoanKH";
            this.mnuTaiKhoanKH.Size = new System.Drawing.Size(327, 34);
            this.mnuTaiKhoanKH.Text = "Tài Khoản Khách Hàng";
            // 
            // mnuThongKe
            // 
            this.mnuThongKe.BackColor = System.Drawing.SystemColors.Window;
            this.mnuThongKe.Image = global::QuanLyQuanAo.Properties.Resources.edit_graph_report_50px;
            this.mnuThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.mnuThongKe.Name = "mnuThongKe";
            this.mnuThongKe.Size = new System.Drawing.Size(138, 46);
            this.mnuThongKe.Text = "Thống Kê";
            this.mnuThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.BackColor = System.Drawing.SystemColors.Window;
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangXuat,
            this.mnuKetThuc});
            this.mnuHeThong.Image = global::QuanLyQuanAo.Properties.Resources.system_diagnostic_24px;
            this.mnuHeThong.Margin = new System.Windows.Forms.Padding(2);
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(138, 46);
            this.mnuHeThong.Text = "Hệ Thống";
            this.mnuHeThong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(270, 34);
            this.mnuDangXuat.Text = "Đăng Xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // mnuKetThuc
            // 
            this.mnuKetThuc.Name = "mnuKetThuc";
            this.mnuKetThuc.Size = new System.Drawing.Size(270, 34);
            this.mnuKetThuc.Text = "Kết Thúc";
            this.mnuKetThuc.Click += new System.EventHandler(this.mnuKetThuc_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1401, 1050);
            this.Controls.Add(this.mainMenu);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ứng dụng quản lý quần áo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuTrangChu;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuKhoHang;
        private System.Windows.Forms.ToolStripMenuItem mnuLoaiSanPham;
        private System.Windows.Forms.ToolStripMenuItem mnuSanPham;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKe;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuHangHoaDaAn;
        private System.Windows.Forms.ToolStripMenuItem mnuHangSanXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuPhieuNhapHang;
        private System.Windows.Forms.ToolStripMenuItem mnuQLNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuTKNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuQLKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoanKH;
        private System.Windows.Forms.ToolStripMenuItem mnuLapHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuTimHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuNhapHang;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuKetThuc;
    }
}