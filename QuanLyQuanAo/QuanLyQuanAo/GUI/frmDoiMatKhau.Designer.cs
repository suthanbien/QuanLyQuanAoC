namespace quanlyquanao.GUI
{
    partial class frmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            this.lblMatKhauHienTai = new System.Windows.Forms.Label();
            this.lblMatKhauMoi = new System.Windows.Forms.Label();
            this.lblNhapLaiMatKhauMoi = new System.Windows.Forms.Label();
            this.txtMatKhauHienTai = new System.Windows.Forms.TextBox();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.txtNhapLaiMatKhauMoi = new System.Windows.Forms.TextBox();
            this.btnXacNhanDoiMatKhau = new System.Windows.Forms.Button();
            this.ttDoiMatKhau = new System.Windows.Forms.ToolTip(this.components);
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblTenTaiKhoan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMatKhauHienTai
            // 
            this.lblMatKhauHienTai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMatKhauHienTai.AutoSize = true;
            this.lblMatKhauHienTai.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMatKhauHienTai.Location = new System.Drawing.Point(101, 176);
            this.lblMatKhauHienTai.Name = "lblMatKhauHienTai";
            this.lblMatKhauHienTai.Size = new System.Drawing.Size(151, 22);
            this.lblMatKhauHienTai.TabIndex = 0;
            this.lblMatKhauHienTai.Text = "Mật khẩu hiện tại:";
            // 
            // lblMatKhauMoi
            // 
            this.lblMatKhauMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMatKhauMoi.AutoSize = true;
            this.lblMatKhauMoi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMatKhauMoi.Location = new System.Drawing.Point(101, 227);
            this.lblMatKhauMoi.Name = "lblMatKhauMoi";
            this.lblMatKhauMoi.Size = new System.Drawing.Size(124, 22);
            this.lblMatKhauMoi.TabIndex = 1;
            this.lblMatKhauMoi.Text = "Mật khẩu mới:";
            // 
            // lblNhapLaiMatKhauMoi
            // 
            this.lblNhapLaiMatKhauMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNhapLaiMatKhauMoi.AutoSize = true;
            this.lblNhapLaiMatKhauMoi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNhapLaiMatKhauMoi.Location = new System.Drawing.Point(101, 278);
            this.lblNhapLaiMatKhauMoi.Name = "lblNhapLaiMatKhauMoi";
            this.lblNhapLaiMatKhauMoi.Size = new System.Drawing.Size(194, 22);
            this.lblNhapLaiMatKhauMoi.TabIndex = 2;
            this.lblNhapLaiMatKhauMoi.Text = "Nhập lại mật khẩu mới:";
            // 
            // txtMatKhauHienTai
            // 
            this.txtMatKhauHienTai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMatKhauHienTai.BackColor = System.Drawing.Color.White;
            this.txtMatKhauHienTai.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhauHienTai.ForeColor = System.Drawing.Color.Black;
            this.txtMatKhauHienTai.Location = new System.Drawing.Point(310, 167);
            this.txtMatKhauHienTai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhauHienTai.Name = "txtMatKhauHienTai";
            this.txtMatKhauHienTai.PasswordChar = '*';
            this.txtMatKhauHienTai.Size = new System.Drawing.Size(266, 30);
            this.txtMatKhauHienTai.TabIndex = 1;
            this.ttDoiMatKhau.SetToolTip(this.txtMatKhauHienTai, "Nhập Mật Khẩu Hiện Tại");
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMatKhauMoi.BackColor = System.Drawing.Color.White;
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhauMoi.ForeColor = System.Drawing.Color.Black;
            this.txtMatKhauMoi.Location = new System.Drawing.Point(310, 220);
            this.txtMatKhauMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '*';
            this.txtMatKhauMoi.Size = new System.Drawing.Size(266, 30);
            this.txtMatKhauMoi.TabIndex = 2;
            this.ttDoiMatKhau.SetToolTip(this.txtMatKhauMoi, "Nhập Mật Khẩu Mới");
            // 
            // txtNhapLaiMatKhauMoi
            // 
            this.txtNhapLaiMatKhauMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNhapLaiMatKhauMoi.BackColor = System.Drawing.Color.White;
            this.txtNhapLaiMatKhauMoi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNhapLaiMatKhauMoi.ForeColor = System.Drawing.Color.Black;
            this.txtNhapLaiMatKhauMoi.Location = new System.Drawing.Point(310, 271);
            this.txtNhapLaiMatKhauMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNhapLaiMatKhauMoi.Name = "txtNhapLaiMatKhauMoi";
            this.txtNhapLaiMatKhauMoi.PasswordChar = '*';
            this.txtNhapLaiMatKhauMoi.Size = new System.Drawing.Size(266, 30);
            this.txtNhapLaiMatKhauMoi.TabIndex = 3;
            this.ttDoiMatKhau.SetToolTip(this.txtNhapLaiMatKhauMoi, "Xác Nhận Mật Khẩu Mới");
            // 
            // btnXacNhanDoiMatKhau
            // 
            this.btnXacNhanDoiMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXacNhanDoiMatKhau.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnXacNhanDoiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacNhanDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXacNhanDoiMatKhau.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXacNhanDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnXacNhanDoiMatKhau.Location = new System.Drawing.Point(439, 331);
            this.btnXacNhanDoiMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXacNhanDoiMatKhau.Name = "btnXacNhanDoiMatKhau";
            this.btnXacNhanDoiMatKhau.Size = new System.Drawing.Size(137, 73);
            this.btnXacNhanDoiMatKhau.TabIndex = 4;
            this.btnXacNhanDoiMatKhau.Text = "Xác Nhận";
            this.ttDoiMatKhau.SetToolTip(this.btnXacNhanDoiMatKhau, "Xác Nhận Đổi Mật Khẩu");
            this.btnXacNhanDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnXacNhanDoiMatKhau.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // ttDoiMatKhau
            // 
            this.ttDoiMatKhau.ForeColor = System.Drawing.Color.Black;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTaiKhoan.BackColor = System.Drawing.Color.White;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.txtTaiKhoan.Location = new System.Drawing.Point(310, 115);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(266, 30);
            this.txtTaiKhoan.TabIndex = 0;
            this.ttDoiMatKhau.SetToolTip(this.txtTaiKhoan, "Nhập Mật Khẩu Hiện Tại");
            // 
            // lblTenTaiKhoan
            // 
            this.lblTenTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTenTaiKhoan.AutoSize = true;
            this.lblTenTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenTaiKhoan.Location = new System.Drawing.Point(101, 124);
            this.lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            this.lblTenTaiKhoan.Size = new System.Drawing.Size(134, 22);
            this.lblTenTaiKhoan.TabIndex = 7;
            this.lblTenTaiKhoan.Text = "Tên Tài Khoản:";
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(719, 466);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.lblTenTaiKhoan);
            this.Controls.Add(this.btnXacNhanDoiMatKhau);
            this.Controls.Add(this.txtNhapLaiMatKhauMoi);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.txtMatKhauHienTai);
            this.Controls.Add(this.lblNhapLaiMatKhauMoi);
            this.Controls.Add(this.lblMatKhauMoi);
            this.Controls.Add(this.lblMatKhauHienTai);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatKhauHienTai;
        private System.Windows.Forms.Label lblMatKhauMoi;
        private System.Windows.Forms.Label lblNhapLaiMatKhauMoi;
        private System.Windows.Forms.TextBox txtMatKhauHienTai;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.TextBox txtNhapLaiMatKhauMoi;
        private System.Windows.Forms.Button btnXacNhanDoiMatKhau;
        private System.Windows.Forms.ToolTip ttDoiMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label lblTenTaiKhoan;
    }
}