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
            this.lblEmailSdt = new System.Windows.Forms.Label();
            this.txtEmailSdt = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblThongBao
            // 
            this.lblThongBao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblThongBao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblThongBao.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblThongBao.ForeColor = System.Drawing.Color.Black;
            this.lblThongBao.Location = new System.Drawing.Point(41, 37);
            this.lblThongBao.MaximumSize = new System.Drawing.Size(50, 50);
            this.lblThongBao.MinimumSize = new System.Drawing.Size(500, 30);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(500, 46);
            this.lblThongBao.TabIndex = 0;
            this.lblThongBao.Text = "Hãy nhập email/sdt đã đăng ký, một mã 6 số sẽ được gửi đến email/sdt của bạn, xác" +
    " nhận để lấy lại mật khẩu.";
            // 
            // lblEmailSdt
            // 
            this.lblEmailSdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmailSdt.AutoSize = true;
            this.lblEmailSdt.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEmailSdt.ForeColor = System.Drawing.Color.Black;
            this.lblEmailSdt.Location = new System.Drawing.Point(41, 141);
            this.lblEmailSdt.Name = "lblEmailSdt";
            this.lblEmailSdt.Size = new System.Drawing.Size(95, 22);
            this.lblEmailSdt.TabIndex = 1;
            this.lblEmailSdt.Text = "Email/Sdt:";
            // 
            // txtEmailSdt
            // 
            this.txtEmailSdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmailSdt.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtEmailSdt.ForeColor = System.Drawing.Color.Black;
            this.txtEmailSdt.Location = new System.Drawing.Point(142, 133);
            this.txtEmailSdt.Name = "txtEmailSdt";
            this.txtEmailSdt.Size = new System.Drawing.Size(383, 30);
            this.txtEmailSdt.TabIndex = 2;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXacNhan.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnXacNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXacNhan.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(369, 193);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(156, 36);
            this.btnXacNhan.TabIndex = 3;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            // 
            // frmQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(591, 271);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtEmailSdt);
            this.Controls.Add(this.lblEmailSdt);
            this.Controls.Add(this.lblThongBao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lấy Lại Mật Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Label lblEmailSdt;
        private System.Windows.Forms.TextBox txtEmailSdt;
        private System.Windows.Forms.Button btnXacNhan;
    }
}