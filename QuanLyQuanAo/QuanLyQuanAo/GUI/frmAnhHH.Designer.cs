namespace QuanLyQuanAo.GUI
{
    partial class frmAnhHH
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.ricChuThich = new System.Windows.Forms.RichTextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtHangSX = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtLoaiHH = new System.Windows.Forms.TextBox();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMLSP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGiaTien = new System.Windows.Forms.Label();
            this.lblSL = new System.Windows.Forms.Label();
            this.lblTenSp = new System.Windows.Forms.Label();
            this.lblMaSp = new System.Windows.Forms.Label();
            this.picAnhHH = new System.Windows.Forms.PictureBox();
            this.pnlBottom.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhHH)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(686, 21);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 45);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Bỏ qua";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(510, 21);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(117, 46);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Đồng ý";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(32, 20);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(144, 46);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Chọn Ảnh";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.btnOk);
            this.pnlBottom.Controls.Add(this.btnSelect);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 474);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1135, 85);
            this.pnlBottom.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Cyan;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1135, 85);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Ảnh Sản Phẩm";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1135, 85);
            this.pnlTop.TabIndex = 6;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.ricChuThich);
            this.pnlCenter.Controls.Add(this.txtSoLuong);
            this.pnlCenter.Controls.Add(this.txtHangSX);
            this.pnlCenter.Controls.Add(this.txtGiaBan);
            this.pnlCenter.Controls.Add(this.txtGiaNhap);
            this.pnlCenter.Controls.Add(this.txtLoaiHH);
            this.pnlCenter.Controls.Add(this.txtTenHH);
            this.pnlCenter.Controls.Add(this.txtMaHH);
            this.pnlCenter.Controls.Add(this.label7);
            this.pnlCenter.Controls.Add(this.lblMLSP);
            this.pnlCenter.Controls.Add(this.label1);
            this.pnlCenter.Controls.Add(this.label5);
            this.pnlCenter.Controls.Add(this.lblGiaTien);
            this.pnlCenter.Controls.Add(this.lblSL);
            this.pnlCenter.Controls.Add(this.lblTenSp);
            this.pnlCenter.Controls.Add(this.lblMaSp);
            this.pnlCenter.Controls.Add(this.picAnhHH);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 85);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1135, 389);
            this.pnlCenter.TabIndex = 8;
            // 
            // ricChuThich
            // 
            this.ricChuThich.Location = new System.Drawing.Point(461, 183);
            this.ricChuThich.Name = "ricChuThich";
            this.ricChuThich.ReadOnly = true;
            this.ricChuThich.Size = new System.Drawing.Size(252, 122);
            this.ricChuThich.TabIndex = 43;
            this.ricChuThich.Text = "";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(161, 155);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.ReadOnly = true;
            this.txtSoLuong.Size = new System.Drawing.Size(138, 22);
            this.txtSoLuong.TabIndex = 35;
            // 
            // txtHangSX
            // 
            this.txtHangSX.Location = new System.Drawing.Point(528, 92);
            this.txtHangSX.Name = "txtHangSX";
            this.txtHangSX.ReadOnly = true;
            this.txtHangSX.Size = new System.Drawing.Size(138, 22);
            this.txtHangSX.TabIndex = 36;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(161, 261);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.ReadOnly = true;
            this.txtGiaBan.Size = new System.Drawing.Size(138, 22);
            this.txtGiaBan.TabIndex = 37;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(162, 206);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.ReadOnly = true;
            this.txtGiaNhap.Size = new System.Drawing.Size(138, 22);
            this.txtGiaNhap.TabIndex = 38;
            // 
            // txtLoaiHH
            // 
            this.txtLoaiHH.Location = new System.Drawing.Point(528, 34);
            this.txtLoaiHH.Name = "txtLoaiHH";
            this.txtLoaiHH.ReadOnly = true;
            this.txtLoaiHH.Size = new System.Drawing.Size(138, 22);
            this.txtLoaiHH.TabIndex = 39;
            // 
            // txtTenHH
            // 
            this.txtTenHH.Location = new System.Drawing.Point(161, 97);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.ReadOnly = true;
            this.txtTenHH.Size = new System.Drawing.Size(138, 22);
            this.txtTenHH.TabIndex = 40;
            // 
            // txtMaHH
            // 
            this.txtMaHH.Location = new System.Drawing.Point(161, 34);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.ReadOnly = true;
            this.txtMaHH.Size = new System.Drawing.Size(138, 22);
            this.txtMaHH.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Chú Thích";
            // 
            // lblMLSP
            // 
            this.lblMLSP.AutoSize = true;
            this.lblMLSP.Location = new System.Drawing.Point(10, 155);
            this.lblMLSP.Name = "lblMLSP";
            this.lblMLSP.Size = new System.Drawing.Size(69, 17);
            this.lblMLSP.TabIndex = 34;
            this.lblMLSP.Text = "Số Lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Hãng Sản Xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Giá Bán";
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.Location = new System.Drawing.Point(10, 206);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(68, 17);
            this.lblGiaTien.TabIndex = 32;
            this.lblGiaTien.Text = "Giá Nhập";
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Location = new System.Drawing.Point(377, 37);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(103, 17);
            this.lblSL.TabIndex = 29;
            this.lblSL.Text = "Loại Hàng Hóa";
            // 
            // lblTenSp
            // 
            this.lblTenSp.AutoSize = true;
            this.lblTenSp.Location = new System.Drawing.Point(10, 102);
            this.lblTenSp.Name = "lblTenSp";
            this.lblTenSp.Size = new System.Drawing.Size(101, 17);
            this.lblTenSp.TabIndex = 28;
            this.lblTenSp.Text = "Tên Hàng Hóa";
            // 
            // lblMaSp
            // 
            this.lblMaSp.AutoSize = true;
            this.lblMaSp.Location = new System.Drawing.Point(10, 37);
            this.lblMaSp.Name = "lblMaSp";
            this.lblMaSp.Size = new System.Drawing.Size(95, 17);
            this.lblMaSp.TabIndex = 27;
            this.lblMaSp.Text = "Mã Hàng Hóa";
            // 
            // picAnhHH
            // 
            this.picAnhHH.Dock = System.Windows.Forms.DockStyle.Right;
            this.picAnhHH.Location = new System.Drawing.Point(735, 0);
            this.picAnhHH.Name = "picAnhHH";
            this.picAnhHH.Size = new System.Drawing.Size(400, 389);
            this.picAnhHH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnhHH.TabIndex = 26;
            this.picAnhHH.TabStop = false;
            // 
            // frmAnhHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 559);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmAnhHH";
            this.Text = "frmAnhHH";
            this.Load += new System.EventHandler(this.frmAnhHH_Load);
            this.pnlBottom.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhHH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.RichTextBox ricChuThich;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtHangSX;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtLoaiHH;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMLSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblGiaTien;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.Label lblTenSp;
        private System.Windows.Forms.Label lblMaSp;
        private System.Windows.Forms.PictureBox picAnhHH;
    }
}