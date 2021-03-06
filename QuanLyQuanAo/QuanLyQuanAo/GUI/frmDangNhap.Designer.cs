﻿namespace quanlyquanao
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.lblTenTaiKhoan = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.rbQuanLy = new System.Windows.Forms.RadioButton();
            this.rbNhanVien = new System.Windows.Forms.RadioButton();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.llblQuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.llblDoiMatKhau = new System.Windows.Forms.LinkLabel();
            this.grbTuCach = new System.Windows.Forms.GroupBox();
            this.pnlDangNhap = new System.Windows.Forms.Panel();
            this.lblDangNhap = new System.Windows.Forms.Label();
            this.llblKiemTraKetNoi = new System.Windows.Forms.LinkLabel();
            this.ttDangNhap = new System.Windows.Forms.ToolTip(this.components);
            this.grbTuCach.SuspendLayout();
            this.pnlDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTenTaiKhoan
            // 
            this.lblTenTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTenTaiKhoan.AutoSize = true;
            this.lblTenTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.lblTenTaiKhoan.Location = new System.Drawing.Point(79, 87);
            this.lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            this.lblTenTaiKhoan.Size = new System.Drawing.Size(104, 19);
            this.lblTenTaiKhoan.TabIndex = 1;
            this.lblTenTaiKhoan.Text = "Tên tài khoản:";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMatKhau.ForeColor = System.Drawing.Color.Black;
            this.lblMatKhau.Location = new System.Drawing.Point(79, 134);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(76, 19);
            this.lblMatKhau.TabIndex = 2;
            this.lblMatKhau.Text = "Mật khẩu:";
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenTaiKhoan.BackColor = System.Drawing.Color.White;
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(201, 81);
            this.txtTenTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(185, 27);
            this.txtTenTaiKhoan.TabIndex = 3;
            this.ttDangNhap.SetToolTip(this.txtTenTaiKhoan, "Nhập Tên Tài Khoản");
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMatKhau.BackColor = System.Drawing.Color.White;
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.Black;
            this.txtMatKhau.Location = new System.Drawing.Point(201, 127);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(185, 27);
            this.txtMatKhau.TabIndex = 4;
            this.ttDangNhap.SetToolTip(this.txtMatKhau, "Nhập Mật Khẩu Của Bạn");
            // 
            // rbQuanLy
            // 
            this.rbQuanLy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbQuanLy.AutoSize = true;
            this.rbQuanLy.Checked = true;
            this.rbQuanLy.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbQuanLy.Location = new System.Drawing.Point(38, 29);
            this.rbQuanLy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbQuanLy.Name = "rbQuanLy";
            this.rbQuanLy.Size = new System.Drawing.Size(93, 21);
            this.rbQuanLy.TabIndex = 6;
            this.rbQuanLy.TabStop = true;
            this.rbQuanLy.Text = "Quản Lý";
            this.rbQuanLy.UseVisualStyleBackColor = true;
            // 
            // rbNhanVien
            // 
            this.rbNhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbNhanVien.AutoSize = true;
            this.rbNhanVien.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbNhanVien.Location = new System.Drawing.Point(164, 29);
            this.rbNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbNhanVien.Name = "rbNhanVien";
            this.rbNhanVien.Size = new System.Drawing.Size(108, 21);
            this.rbNhanVien.TabIndex = 7;
            this.rbNhanVien.Text = "Nhân Viên";
            this.rbNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDangNhap.BackColor = System.Drawing.Color.Tomato;
            this.btnDangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(83, 286);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(303, 40);
            this.btnDangNhap.TabIndex = 10;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.ttDangNhap.SetToolTip(this.btnDangNhap, "Đăng Nhập Vào Hệ Thống!");
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // llblQuenMatKhau
            // 
            this.llblQuenMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.llblQuenMatKhau.AutoSize = true;
            this.llblQuenMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llblQuenMatKhau.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.llblQuenMatKhau.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llblQuenMatKhau.Location = new System.Drawing.Point(173, 386);
            this.llblQuenMatKhau.Name = "llblQuenMatKhau";
            this.llblQuenMatKhau.Size = new System.Drawing.Size(127, 20);
            this.llblQuenMatKhau.TabIndex = 11;
            this.llblQuenMatKhau.TabStop = true;
            this.llblQuenMatKhau.Text = "Quên mật khẩu?";
            this.llblQuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblQuenMatKhau_LinkClicked);
            // 
            // llblDoiMatKhau
            // 
            this.llblDoiMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.llblDoiMatKhau.AutoSize = true;
            this.llblDoiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llblDoiMatKhau.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.llblDoiMatKhau.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llblDoiMatKhau.Location = new System.Drawing.Point(184, 431);
            this.llblDoiMatKhau.Name = "llblDoiMatKhau";
            this.llblDoiMatKhau.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.llblDoiMatKhau.Size = new System.Drawing.Size(105, 20);
            this.llblDoiMatKhau.TabIndex = 12;
            this.llblDoiMatKhau.TabStop = true;
            this.llblDoiMatKhau.Text = "Đổi mật khẩu";
            this.llblDoiMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblDoiMatKhau_LinkClicked);
            // 
            // grbTuCach
            // 
            this.grbTuCach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grbTuCach.Controls.Add(this.rbQuanLy);
            this.grbTuCach.Controls.Add(this.rbNhanVien);
            this.grbTuCach.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbTuCach.ForeColor = System.Drawing.Color.Black;
            this.grbTuCach.Location = new System.Drawing.Point(83, 178);
            this.grbTuCach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTuCach.Name = "grbTuCach";
            this.grbTuCach.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTuCach.Size = new System.Drawing.Size(303, 70);
            this.grbTuCach.TabIndex = 14;
            this.grbTuCach.TabStop = false;
            this.grbTuCach.Text = "Tư cách";
            // 
            // pnlDangNhap
            // 
            this.pnlDangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDangNhap.BackColor = System.Drawing.Color.White;
            this.pnlDangNhap.Controls.Add(this.lblDangNhap);
            this.pnlDangNhap.Controls.Add(this.llblKiemTraKetNoi);
            this.pnlDangNhap.Controls.Add(this.llblDoiMatKhau);
            this.pnlDangNhap.Controls.Add(this.grbTuCach);
            this.pnlDangNhap.Controls.Add(this.llblQuenMatKhau);
            this.pnlDangNhap.Controls.Add(this.lblTenTaiKhoan);
            this.pnlDangNhap.Controls.Add(this.btnDangNhap);
            this.pnlDangNhap.Controls.Add(this.lblMatKhau);
            this.pnlDangNhap.Controls.Add(this.txtMatKhau);
            this.pnlDangNhap.Controls.Add(this.txtTenTaiKhoan);
            this.pnlDangNhap.ForeColor = System.Drawing.Color.Black;
            this.pnlDangNhap.Location = new System.Drawing.Point(165, 54);
            this.pnlDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDangNhap.Name = "pnlDangNhap";
            this.pnlDangNhap.Size = new System.Drawing.Size(469, 459);
            this.pnlDangNhap.TabIndex = 16;
            // 
            // lblDangNhap
            // 
            this.lblDangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDangNhap.AutoSize = true;
            this.lblDangNhap.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDangNhap.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDangNhap.ForeColor = System.Drawing.Color.White;
            this.lblDangNhap.Location = new System.Drawing.Point(0, 0);
            this.lblDangNhap.MinimumSize = new System.Drawing.Size(469, 40);
            this.lblDangNhap.Name = "lblDangNhap";
            this.lblDangNhap.Size = new System.Drawing.Size(469, 40);
            this.lblDangNhap.TabIndex = 15;
            this.lblDangNhap.Text = "ĐĂNG NHẬP";
            this.lblDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDangNhap.Click += new System.EventHandler(this.lblDangNhap_Click);
            // 
            // llblKiemTraKetNoi
            // 
            this.llblKiemTraKetNoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.llblKiemTraKetNoi.AutoSize = true;
            this.llblKiemTraKetNoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llblKiemTraKetNoi.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.llblKiemTraKetNoi.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llblKiemTraKetNoi.Location = new System.Drawing.Point(322, 49);
            this.llblKiemTraKetNoi.Name = "llblKiemTraKetNoi";
            this.llblKiemTraKetNoi.Size = new System.Drawing.Size(132, 20);
            this.llblKiemTraKetNoi.TabIndex = 11;
            this.llblKiemTraKetNoi.TabStop = true;
            this.llblKiemTraKetNoi.Text = "Kiểm Tra Kết Nối";
            this.llblKiemTraKetNoi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblKiemTraKetNoi_LinkClicked);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::QuanLyQuanAo.Properties.Resources.sounds_aura_hp2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(810, 565);
            this.Controls.Add(this.pnlDangNhap);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quần Áo Sỉ Lẻ Baby Milo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDangNhap_FormClosed);
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.grbTuCach.ResumeLayout(false);
            this.grbTuCach.PerformLayout();
            this.pnlDangNhap.ResumeLayout(false);
            this.pnlDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTenTaiKhoan;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.RadioButton rbQuanLy;
        private System.Windows.Forms.RadioButton rbNhanVien;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.LinkLabel llblQuenMatKhau;
        private System.Windows.Forms.LinkLabel llblDoiMatKhau;
        private System.Windows.Forms.GroupBox grbTuCach;
        private System.Windows.Forms.Panel pnlDangNhap;
        private System.Windows.Forms.Label lblDangNhap;
        private System.Windows.Forms.LinkLabel llblKiemTraKetNoi;
        private System.Windows.Forms.ToolTip ttDangNhap;
    }
}

