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
            this.mnuTrangChu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLapHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhoHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoaiSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHangSanXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHangHoaDaAn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhapHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTKNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoanKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuTrangChu
            // 
            this.mnuTrangChu.Name = "mnuTrangChu";
            this.mnuTrangChu.Size = new System.Drawing.Size(89, 24);
            this.mnuTrangChu.Text = "Trang Chủ";
            // 
            // mnuHoaDon
            // 
            this.mnuHoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLapHoaDon,
            this.mnuTimHoaDon});
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.Size = new System.Drawing.Size(83, 24);
            this.mnuHoaDon.Text = "Hóa Đơn";
            // 
            // mnuLapHoaDon
            // 
            this.mnuLapHoaDon.Name = "mnuLapHoaDon";
            this.mnuLapHoaDon.Size = new System.Drawing.Size(181, 26);
            this.mnuLapHoaDon.Text = "Lập Hóa Đơn";
            this.mnuLapHoaDon.Click += new System.EventHandler(this.mnuLapHoaDon_Click);
            // 
            // mnuTimHoaDon
            // 
            this.mnuTimHoaDon.Name = "mnuTimHoaDon";
            this.mnuTimHoaDon.Size = new System.Drawing.Size(181, 26);
            this.mnuTimHoaDon.Text = "Tìm Hóa Đơn";
            this.mnuTimHoaDon.Click += new System.EventHandler(this.mnuTimHoaDon_Click);
            // 
            // mnuKhoHang
            // 
            this.mnuKhoHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSanPham,
            this.mnuLoaiSanPham,
            this.mnuHangSanXuat,
            this.mnuHangHoaDaAn,
            this.mnuNhapHang});
            this.mnuKhoHang.Name = "mnuKhoHang";
            this.mnuKhoHang.Size = new System.Drawing.Size(89, 24);
            this.mnuKhoHang.Text = "Kho Hàng";
            // 
            // mnuSanPham
            // 
            this.mnuSanPham.Name = "mnuSanPham";
            this.mnuSanPham.Size = new System.Drawing.Size(237, 26);
            this.mnuSanPham.Text = "Hàng Hóa";
            this.mnuSanPham.Click += new System.EventHandler(this.mnuSanPham_Click);
            // 
            // mnuLoaiSanPham
            // 
            this.mnuLoaiSanPham.Name = "mnuLoaiSanPham";
            this.mnuLoaiSanPham.Size = new System.Drawing.Size(237, 26);
            this.mnuLoaiSanPham.Text = "Loại Hàng Hóa";
            this.mnuLoaiSanPham.Click += new System.EventHandler(this.mnuLoaiSanPham_Click);
            // 
            // mnuHangSanXuat
            // 
            this.mnuHangSanXuat.Name = "mnuHangSanXuat";
            this.mnuHangSanXuat.Size = new System.Drawing.Size(237, 26);
            this.mnuHangSanXuat.Text = "Hãng Sản Xuất";
            this.mnuHangSanXuat.Click += new System.EventHandler(this.mnuHangSanXuat_Click);
            // 
            // mnuHangHoaDaAn
            // 
            this.mnuHangHoaDaAn.Name = "mnuHangHoaDaAn";
            this.mnuHangHoaDaAn.Size = new System.Drawing.Size(237, 26);
            this.mnuHangHoaDaAn.Text = "Hàng Hóa Đã Ẩn";
            this.mnuHangHoaDaAn.Click += new System.EventHandler(this.mnuHangHoaDaAn_Click);
            // 
            // mnuNhapHang
            // 
            this.mnuNhapHang.Name = "mnuNhapHang";
            this.mnuNhapHang.Size = new System.Drawing.Size(237, 26);
            this.mnuNhapHang.Text = "Tạo Phiếu Nhập Hàng";
            this.mnuNhapHang.Click += new System.EventHandler(this.mnuNhapHang_Click);
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQLNhanVien,
            this.mnuTKNhanVien});
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(91, 24);
            this.mnuNhanVien.Text = "Nhân Viên";
            // 
            // mnuQLNhanVien
            // 
            this.mnuQLNhanVien.Name = "mnuQLNhanVien";
            this.mnuQLNhanVien.Size = new System.Drawing.Size(284, 26);
            this.mnuQLNhanVien.Text = "Quản Lý Nhân Viên";
            this.mnuQLNhanVien.Click += new System.EventHandler(this.mnuQLNhanVien_Click);
            // 
            // mnuTKNhanVien
            // 
            this.mnuTKNhanVien.Name = "mnuTKNhanVien";
            this.mnuTKNhanVien.Size = new System.Drawing.Size(284, 26);
            this.mnuTKNhanVien.Text = "Quản Lý Tài Khoản Nhân Viên";
            this.mnuTKNhanVien.Click += new System.EventHandler(this.mnuTKNhanVien_Click);
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQLKhachHang,
            this.mnuTaiKhoanKH});
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.Size = new System.Drawing.Size(103, 24);
            this.mnuKhachHang.Text = "Khách Hàng";
            // 
            // mnuQLKhachHang
            // 
            this.mnuQLKhachHang.Name = "mnuQLKhachHang";
            this.mnuQLKhachHang.Size = new System.Drawing.Size(240, 26);
            this.mnuQLKhachHang.Text = "Quản Lý Khách Hàng";
            this.mnuQLKhachHang.Click += new System.EventHandler(this.mnuQLKhachHang_Click);
            // 
            // mnuTaiKhoanKH
            // 
            this.mnuTaiKhoanKH.Name = "mnuTaiKhoanKH";
            this.mnuTaiKhoanKH.Size = new System.Drawing.Size(240, 26);
            this.mnuTaiKhoanKH.Text = "Tài Khoản Khách Hàng";
            // 
            // mnuThongKe
            // 
            this.mnuThongKe.Name = "mnuThongKe";
            this.mnuThongKe.Size = new System.Drawing.Size(86, 24);
            this.mnuThongKe.Text = "Thống Kê";
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTrangChu,
            this.mnuHoaDon,
            this.mnuKhoHang,
            this.mnuNhanVien,
            this.mnuKhachHang,
            this.mnuThongKe});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1245, 28);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            this.mainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mainMenu_ItemClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 852);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ứng dụng quản lý quần áo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ToolStripMenuItem mnuNhapHang;
        private System.Windows.Forms.ToolStripMenuItem mnuQLNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuTKNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuQLKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoanKH;
        private System.Windows.Forms.ToolStripMenuItem mnuLapHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuTimHoaDon;
    }
}