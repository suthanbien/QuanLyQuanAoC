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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnhHH));
            this.btnSelect = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBottom.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhHH)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Snow;
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(35, 25);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(160, 60);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Chọn Ảnh";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.btnOk);
            this.pnlBottom.Controls.Add(this.btnSelect);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 584);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1278, 110);
            this.pnlBottom.TabIndex = 7;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1278, 106);
            this.pnlTop.TabIndex = 6;
            // 
            // pnlCenter
            // 
            this.pnlCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.pnlCenter.Location = new System.Drawing.Point(0, 106);
            this.pnlCenter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1278, 478);
            this.pnlCenter.TabIndex = 8;
            // 
            // ricChuThich
            // 
            this.ricChuThich.Location = new System.Drawing.Point(430, 225);
            this.ricChuThich.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ricChuThich.Name = "ricChuThich";
            this.ricChuThich.ReadOnly = true;
            this.ricChuThich.Size = new System.Drawing.Size(290, 141);
            this.ricChuThich.TabIndex = 43;
            this.ricChuThich.Text = "";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(180, 195);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.ReadOnly = true;
            this.txtSoLuong.Size = new System.Drawing.Size(155, 26);
            this.txtSoLuong.TabIndex = 35;
            // 
            // txtHangSX
            // 
            this.txtHangSX.Location = new System.Drawing.Point(565, 120);
            this.txtHangSX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHangSX.Name = "txtHangSX";
            this.txtHangSX.ReadOnly = true;
            this.txtHangSX.Size = new System.Drawing.Size(155, 26);
            this.txtHangSX.TabIndex = 36;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(180, 340);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.ReadOnly = true;
            this.txtGiaBan.Size = new System.Drawing.Size(155, 26);
            this.txtGiaBan.TabIndex = 37;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(180, 265);
            this.txtGiaNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.ReadOnly = true;
            this.txtGiaNhap.Size = new System.Drawing.Size(155, 26);
            this.txtGiaNhap.TabIndex = 38;
            // 
            // txtLoaiHH
            // 
            this.txtLoaiHH.Location = new System.Drawing.Point(565, 50);
            this.txtLoaiHH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLoaiHH.Name = "txtLoaiHH";
            this.txtLoaiHH.ReadOnly = true;
            this.txtLoaiHH.Size = new System.Drawing.Size(155, 26);
            this.txtLoaiHH.TabIndex = 39;
            // 
            // txtTenHH
            // 
            this.txtTenHH.Location = new System.Drawing.Point(180, 120);
            this.txtTenHH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.ReadOnly = true;
            this.txtTenHH.Size = new System.Drawing.Size(155, 26);
            this.txtTenHH.TabIndex = 40;
            // 
            // txtMaHH
            // 
            this.txtMaHH.Location = new System.Drawing.Point(180, 50);
            this.txtMaHH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.ReadOnly = true;
            this.txtMaHH.Size = new System.Drawing.Size(155, 26);
            this.txtMaHH.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(425, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Chú Thích:";
            // 
            // lblMLSP
            // 
            this.lblMLSP.AutoSize = true;
            this.lblMLSP.Location = new System.Drawing.Point(35, 195);
            this.lblMLSP.Name = "lblMLSP";
            this.lblMLSP.Size = new System.Drawing.Size(82, 20);
            this.lblMLSP.TabIndex = 34;
            this.lblMLSP.Text = "Số Lượng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Hãng Sản Xuất:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Giá Bán:";
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.Location = new System.Drawing.Point(35, 265);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(80, 20);
            this.lblGiaTien.TabIndex = 32;
            this.lblGiaTien.Text = "Giá Nhập:";
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Location = new System.Drawing.Point(425, 50);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(120, 20);
            this.lblSL.TabIndex = 29;
            this.lblSL.Text = "Loại Hàng Hóa:";
            // 
            // lblTenSp
            // 
            this.lblTenSp.AutoSize = true;
            this.lblTenSp.Location = new System.Drawing.Point(35, 120);
            this.lblTenSp.Name = "lblTenSp";
            this.lblTenSp.Size = new System.Drawing.Size(117, 20);
            this.lblTenSp.TabIndex = 28;
            this.lblTenSp.Text = "Tên Hàng Hóa:";
            // 
            // lblMaSp
            // 
            this.lblMaSp.AutoSize = true;
            this.lblMaSp.Location = new System.Drawing.Point(35, 50);
            this.lblMaSp.Name = "lblMaSp";
            this.lblMaSp.Size = new System.Drawing.Size(112, 20);
            this.lblMaSp.TabIndex = 27;
            this.lblMaSp.Text = "Mã Hàng Hóa:";
            // 
            // picAnhHH
            // 
            this.picAnhHH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnhHH.Dock = System.Windows.Forms.DockStyle.Right;
            this.picAnhHH.Location = new System.Drawing.Point(826, 0);
            this.picAnhHH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picAnhHH.Name = "picAnhHH";
            this.picAnhHH.Size = new System.Drawing.Size(450, 476);
            this.picAnhHH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnhHH.TabIndex = 26;
            this.picAnhHH.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::QuanLyQuanAo.Properties.Resources.delete_30px;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(1100, 25);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 60);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Bỏ qua";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Green;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Enabled = false;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Image = global::QuanLyQuanAo.Properties.Resources.checkmark_26px;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(855, 25);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(135, 60);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Đồng ý";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.DarkCyan;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Image = global::QuanLyQuanAo.Properties.Resources.forester_shirt_128px1;
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1278, 106);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ẢNH SẢN PHẨM";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAnhHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1278, 694);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAnhHH";
            this.Text = "Ảnh hàng hóa";
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