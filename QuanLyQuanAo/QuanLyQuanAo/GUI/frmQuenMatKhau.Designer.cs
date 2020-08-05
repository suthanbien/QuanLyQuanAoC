namespace quanlyquanao
{
    partial class frmQuenMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuenMatKhau));
            this.lblThongBao = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnXacNhanQuenMatKhau = new System.Windows.Forms.Button();
            this.lblLoiMail = new System.Windows.Forms.Label();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.lblTaiKhoanCuaBanLa = new System.Windows.Forms.Label();
            this.lblAdMin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblThongBao
            // 
            this.lblThongBao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblThongBao.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThongBao.ForeColor = System.Drawing.Color.Black;
            this.lblThongBao.Location = new System.Drawing.Point(89, 70);
            this.lblThongBao.MaximumSize = new System.Drawing.Size(50, 50);
            this.lblThongBao.MinimumSize = new System.Drawing.Size(500, 30);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(500, 44);
            this.lblThongBao.TabIndex = 7;
            this.lblThongBao.Text = "Hãy nhập email đã đăng ký, một mật khẩu mới sẽ được gửi đến email của bạn, xác nh" +
    "ận để lấy lại mật khẩu.";
            this.lblThongBao.Click += new System.EventHandler(this.lblThongBao_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(89, 174);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 22);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(158, 166);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(334, 30);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // btnXacNhanQuenMatKhau
            // 
            this.btnXacNhanQuenMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXacNhanQuenMatKhau.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnXacNhanQuenMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacNhanQuenMatKhau.Enabled = false;
            this.btnXacNhanQuenMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXacNhanQuenMatKhau.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXacNhanQuenMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnXacNhanQuenMatKhau.Location = new System.Drawing.Point(514, 291);
            this.btnXacNhanQuenMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXacNhanQuenMatKhau.Name = "btnXacNhanQuenMatKhau";
            this.btnXacNhanQuenMatKhau.Size = new System.Drawing.Size(137, 73);
            this.btnXacNhanQuenMatKhau.TabIndex = 2;
            this.btnXacNhanQuenMatKhau.Text = "Xác Nhận";
            this.btnXacNhanQuenMatKhau.UseVisualStyleBackColor = false;
            this.btnXacNhanQuenMatKhau.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // lblLoiMail
            // 
            this.lblLoiMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoiMail.AutoSize = true;
            this.lblLoiMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLoiMail.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLoiMail.ForeColor = System.Drawing.Color.Red;
            this.lblLoiMail.Location = new System.Drawing.Point(89, 226);
            this.lblLoiMail.MaximumSize = new System.Drawing.Size(50, 50);
            this.lblLoiMail.MinimumSize = new System.Drawing.Size(500, 30);
            this.lblLoiMail.Name = "lblLoiMail";
            this.lblLoiMail.Size = new System.Drawing.Size(500, 44);
            this.lblLoiMail.TabIndex = 6;
            this.lblLoiMail.Text = "Lỗi: Email này không có trong hệ thống vui lòng kiểm tra lại thông tin";
            this.lblLoiMail.Visible = false;
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKiemTra.BackColor = System.Drawing.Color.DarkGray;
            this.btnKiemTra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKiemTra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKiemTra.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKiemTra.ForeColor = System.Drawing.Color.Black;
            this.btnKiemTra.Location = new System.Drawing.Point(514, 158);
            this.btnKiemTra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(137, 48);
            this.btnKiemTra.TabIndex = 1;
            this.btnKiemTra.Text = "Kiểm Tra";
            this.btnKiemTra.UseVisualStyleBackColor = false;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // lblTaiKhoanCuaBanLa
            // 
            this.lblTaiKhoanCuaBanLa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTaiKhoanCuaBanLa.AutoSize = true;
            this.lblTaiKhoanCuaBanLa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTaiKhoanCuaBanLa.ForeColor = System.Drawing.Color.Black;
            this.lblTaiKhoanCuaBanLa.Location = new System.Drawing.Point(89, 328);
            this.lblTaiKhoanCuaBanLa.Name = "lblTaiKhoanCuaBanLa";
            this.lblTaiKhoanCuaBanLa.Size = new System.Drawing.Size(189, 22);
            this.lblTaiKhoanCuaBanLa.TabIndex = 5;
            this.lblTaiKhoanCuaBanLa.Text = "Tài khoản của bạn là : ";
            // 
            // lblAdMin
            // 
            this.lblAdMin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdMin.AutoSize = true;
            this.lblAdMin.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblAdMin.ForeColor = System.Drawing.Color.Black;
            this.lblAdMin.Location = new System.Drawing.Point(272, 312);
            this.lblAdMin.Name = "lblAdMin";
            this.lblAdMin.Size = new System.Drawing.Size(113, 41);
            this.lblAdMin.TabIndex = 4;
            this.lblAdMin.Text = "admin";
            // 
            // frmQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(719, 466);
            this.Controls.Add(this.lblAdMin);
            this.Controls.Add(this.lblTaiKhoanCuaBanLa);
            this.Controls.Add(this.lblLoiMail);
            this.Controls.Add(this.btnKiemTra);
            this.Controls.Add(this.btnXacNhanQuenMatKhau);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblThongBao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lấy Lại Mật Khẩu";
            this.Load += new System.EventHandler(this.frmQuenMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnXacNhanQuenMatKhau;
        private System.Windows.Forms.Label lblLoiMail;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.Label lblTaiKhoanCuaBanLa;
        private System.Windows.Forms.Label lblAdMin;
    }
}