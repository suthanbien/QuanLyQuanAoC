namespace QuanLyQuanAo.GUI
{
    partial class frmThongKe
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
            this.lblMHBC = new System.Windows.Forms.Label();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.btnXem = new System.Windows.Forms.Button();
            this.datepicDenNgay = new System.Windows.Forms.DateTimePicker();
            this.datepicTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnTangDan = new System.Windows.Forms.Button();
            this.btnGiamDan = new System.Windows.Forms.Button();
            this.dgvThongTin = new System.Windows.Forms.DataGridView();
            this.btnXemTatCa = new System.Windows.Forms.Button();
            this.classMHBanChayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlTop.SuspendLayout();
            this.pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classMHBanChayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblMHBC);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(844, 79);
            this.pnlTop.TabIndex = 0;
            // 
            // lblMHBC
            // 
            this.lblMHBC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMHBC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMHBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMHBC.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMHBC.Location = new System.Drawing.Point(0, 0);
            this.lblMHBC.Name = "lblMHBC";
            this.lblMHBC.Size = new System.Drawing.Size(844, 79);
            this.lblMHBC.TabIndex = 1;
            this.lblMHBC.Text = "Những mặt hàng bán chạy";
            this.lblMHBC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.dgvThongTin);
            this.pnlFill.Controls.Add(this.btnXemTatCa);
            this.pnlFill.Controls.Add(this.btnXem);
            this.pnlFill.Controls.Add(this.datepicDenNgay);
            this.pnlFill.Controls.Add(this.datepicTuNgay);
            this.pnlFill.Controls.Add(this.label2);
            this.pnlFill.Controls.Add(this.label1);
            this.pnlFill.Controls.Add(this.btnClose);
            this.pnlFill.Controls.Add(this.btnIn);
            this.pnlFill.Controls.Add(this.btnTangDan);
            this.pnlFill.Controls.Add(this.btnGiamDan);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(0, 79);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(844, 508);
            this.pnlFill.TabIndex = 1;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(464, 365);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(78, 36);
            this.btnXem.TabIndex = 16;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // datepicDenNgay
            // 
            this.datepicDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicDenNgay.Location = new System.Drawing.Point(328, 372);
            this.datepicDenNgay.Name = "datepicDenNgay";
            this.datepicDenNgay.Size = new System.Drawing.Size(116, 22);
            this.datepicDenNgay.TabIndex = 14;
            this.datepicDenNgay.Value = new System.DateTime(2020, 5, 21, 0, 0, 0, 0);
            // 
            // datepicTuNgay
            // 
            this.datepicTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepicTuNgay.Location = new System.Drawing.Point(111, 372);
            this.datepicTuNgay.Name = "datepicTuNgay";
            this.datepicTuNgay.Size = new System.Drawing.Size(116, 22);
            this.datepicTuNgay.TabIndex = 15;
            this.datepicTuNgay.Value = new System.DateTime(2019, 4, 4, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Từ ngày";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(697, 451);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 43);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(567, 451);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(85, 43);
            this.btnIn.TabIndex = 10;
            this.btnIn.Text = "IN";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnTangDan
            // 
            this.btnTangDan.Enabled = false;
            this.btnTangDan.Location = new System.Drawing.Point(181, 438);
            this.btnTangDan.Name = "btnTangDan";
            this.btnTangDan.Size = new System.Drawing.Size(127, 43);
            this.btnTangDan.TabIndex = 9;
            this.btnTangDan.Text = "Tăng Dần";
            this.btnTangDan.UseVisualStyleBackColor = true;
            this.btnTangDan.Click += new System.EventHandler(this.btnTangDan_Click);
            // 
            // btnGiamDan
            // 
            this.btnGiamDan.Enabled = false;
            this.btnGiamDan.Location = new System.Drawing.Point(48, 438);
            this.btnGiamDan.Name = "btnGiamDan";
            this.btnGiamDan.Size = new System.Drawing.Size(127, 43);
            this.btnGiamDan.TabIndex = 8;
            this.btnGiamDan.Text = "Giảm Dần";
            this.btnGiamDan.UseVisualStyleBackColor = true;
            this.btnGiamDan.Click += new System.EventHandler(this.btnGiamDan_Click);
            // 
            // dgvThongTin
            // 
            this.dgvThongTin.AllowUserToAddRows = false;
            this.dgvThongTin.AllowUserToDeleteRows = false;
            this.dgvThongTin.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTin.Location = new System.Drawing.Point(12, 6);
            this.dgvThongTin.MultiSelect = false;
            this.dgvThongTin.Name = "dgvThongTin";
            this.dgvThongTin.ReadOnly = true;
            this.dgvThongTin.RowHeadersVisible = false;
            this.dgvThongTin.RowHeadersWidth = 51;
            this.dgvThongTin.RowTemplate.Height = 24;
            this.dgvThongTin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvThongTin.Size = new System.Drawing.Size(820, 323);
            this.dgvThongTin.TabIndex = 17;
            // 
            // btnXemTatCa
            // 
            this.btnXemTatCa.Location = new System.Drawing.Point(697, 356);
            this.btnXemTatCa.Name = "btnXemTatCa";
            this.btnXemTatCa.Size = new System.Drawing.Size(111, 48);
            this.btnXemTatCa.TabIndex = 16;
            this.btnXemTatCa.Text = "Xem Tất Cả";
            this.btnXemTatCa.UseVisualStyleBackColor = true;
            this.btnXemTatCa.Click += new System.EventHandler(this.btnXemTatCa_Click);
            // 
            // classMHBanChayBindingSource
            // 
            this.classMHBanChayBindingSource.DataSource = typeof(QuanLyQuanAo.DAO.ClassMHBanChay);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 587);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmThongKe";
            this.Text = "Những mặt hàng bán chạy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmThongKe_FormClosed);
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlFill.ResumeLayout(false);
            this.pnlFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classMHBanChayBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblMHBC;
        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DateTimePicker datepicDenNgay;
        private System.Windows.Forms.DateTimePicker datepicTuNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnTangDan;
        private System.Windows.Forms.Button btnGiamDan;
        private System.Windows.Forms.DataGridView dgvThongTin;
        private System.Windows.Forms.BindingSource classMHBanChayBindingSource;
        private System.Windows.Forms.Button btnXemTatCa;
    }
}