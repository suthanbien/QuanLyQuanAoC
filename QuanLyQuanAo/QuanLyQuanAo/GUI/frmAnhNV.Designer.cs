namespace QuanLyQuanAo.GUI
{
    partial class frmAnhNV
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.picAnhNV = new System.Windows.Forms.PictureBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMLSP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGiaTien = new System.Windows.Forms.Label();
            this.lblSL = new System.Windows.Forms.Label();
            this.lblTenSp = new System.Windows.Forms.Label();
            this.lblMaSp = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhNV)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1176, 85);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.btnOk);
            this.pnlBottom.Controls.Add(this.btnSelect);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 431);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1176, 88);
            this.pnlBottom.TabIndex = 1;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.txtSDT);
            this.pnlCenter.Controls.Add(this.txtDiaChi);
            this.pnlCenter.Controls.Add(this.label2);
            this.pnlCenter.Controls.Add(this.label3);
            this.pnlCenter.Controls.Add(this.txtChucVu);
            this.pnlCenter.Controls.Add(this.txtGioiTinh);
            this.pnlCenter.Controls.Add(this.txtCMND);
            this.pnlCenter.Controls.Add(this.txtNgaySinh);
            this.pnlCenter.Controls.Add(this.txtEmail);
            this.pnlCenter.Controls.Add(this.txtTenNV);
            this.pnlCenter.Controls.Add(this.txtMaNV);
            this.pnlCenter.Controls.Add(this.lblMLSP);
            this.pnlCenter.Controls.Add(this.label1);
            this.pnlCenter.Controls.Add(this.label5);
            this.pnlCenter.Controls.Add(this.lblGiaTien);
            this.pnlCenter.Controls.Add(this.lblSL);
            this.pnlCenter.Controls.Add(this.lblTenSp);
            this.pnlCenter.Controls.Add(this.lblMaSp);
            this.pnlCenter.Controls.Add(this.picAnhNV);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 85);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1176, 346);
            this.pnlCenter.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Cyan;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1176, 85);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Ảnh Nhân Viên";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(751, 22);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 45);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Bỏ qua";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(575, 22);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(117, 46);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Đồng ý";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(97, 21);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(144, 46);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Chọn Ảnh";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // picAnhNV
            // 
            this.picAnhNV.Dock = System.Windows.Forms.DockStyle.Right;
            this.picAnhNV.Location = new System.Drawing.Point(776, 0);
            this.picAnhNV.Name = "picAnhNV";
            this.picAnhNV.Size = new System.Drawing.Size(400, 346);
            this.picAnhNV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnhNV.TabIndex = 27;
            this.picAnhNV.TabStop = false;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(542, 168);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(138, 22);
            this.txtSDT.TabIndex = 66;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(542, 125);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(138, 22);
            this.txtDiaChi.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 65;
            this.label2.Text = "SDT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 64;
            this.label3.Text = "Dịa Chỉ";
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(175, 142);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.ReadOnly = true;
            this.txtChucVu.Size = new System.Drawing.Size(138, 22);
            this.txtChucVu.TabIndex = 55;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(542, 79);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.ReadOnly = true;
            this.txtGioiTinh.Size = new System.Drawing.Size(138, 22);
            this.txtGioiTinh.TabIndex = 56;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(175, 248);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.ReadOnly = true;
            this.txtCMND.Size = new System.Drawing.Size(138, 22);
            this.txtCMND.TabIndex = 57;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(176, 193);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.ReadOnly = true;
            this.txtNgaySinh.Size = new System.Drawing.Size(138, 22);
            this.txtNgaySinh.TabIndex = 58;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(542, 21);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(138, 22);
            this.txtEmail.TabIndex = 59;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(175, 84);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.ReadOnly = true;
            this.txtTenNV.Size = new System.Drawing.Size(138, 22);
            this.txtTenNV.TabIndex = 60;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(175, 21);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(138, 22);
            this.txtMaNV.TabIndex = 61;
            // 
            // lblMLSP
            // 
            this.lblMLSP.AutoSize = true;
            this.lblMLSP.Location = new System.Drawing.Point(24, 142);
            this.lblMLSP.Name = "lblMLSP";
            this.lblMLSP.Size = new System.Drawing.Size(61, 17);
            this.lblMLSP.TabIndex = 54;
            this.lblMLSP.Text = "Chức Vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "CMND";
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.Location = new System.Drawing.Point(24, 193);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(73, 17);
            this.lblGiaTien.TabIndex = 52;
            this.lblGiaTien.Text = "Ngày Sinh";
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Location = new System.Drawing.Point(391, 24);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(42, 17);
            this.lblSL.TabIndex = 49;
            this.lblSL.Text = "Email";
            // 
            // lblTenSp
            // 
            this.lblTenSp.AutoSize = true;
            this.lblTenSp.Location = new System.Drawing.Point(24, 89);
            this.lblTenSp.Name = "lblTenSp";
            this.lblTenSp.Size = new System.Drawing.Size(103, 17);
            this.lblTenSp.TabIndex = 48;
            this.lblTenSp.Text = "Tên Nhân Viên";
            // 
            // lblMaSp
            // 
            this.lblMaSp.AutoSize = true;
            this.lblMaSp.Location = new System.Drawing.Point(24, 24);
            this.lblMaSp.Name = "lblMaSp";
            this.lblMaSp.Size = new System.Drawing.Size(97, 17);
            this.lblMaSp.TabIndex = 47;
            this.lblMaSp.Text = "Mã Nhân Viên";
            // 
            // frmAnhNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 519);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmAnhNV";
            this.Text = "Ảnh Nhân Viên";
            this.pnlTop.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.PictureBox picAnhNV;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblMLSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblGiaTien;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.Label lblTenSp;
        private System.Windows.Forms.Label lblMaSp;
    }
}