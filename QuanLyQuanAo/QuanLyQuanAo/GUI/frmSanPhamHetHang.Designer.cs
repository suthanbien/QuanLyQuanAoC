namespace QuanLyQuanAo.GUI
{
    partial class frmSanPhamHetHang
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
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.pnlCenterLeft = new System.Windows.Forms.Panel();
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlCenter.SuspendLayout();
            this.pnlCenterLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1157, 78);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.button1);
            this.pnlCenter.Controls.Add(this.pnlCenterLeft);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 78);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1157, 460);
            this.pnlCenter.TabIndex = 1;
            // 
            // pnlCenterLeft
            // 
            this.pnlCenterLeft.Controls.Add(this.dgvHangHoa);
            this.pnlCenterLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCenterLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlCenterLeft.Name = "pnlCenterLeft";
            this.pnlCenterLeft.Size = new System.Drawing.Size(658, 460);
            this.pnlCenterLeft.TabIndex = 0;
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHangHoa.Location = new System.Drawing.Point(0, 0);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.RowHeadersWidth = 51;
            this.dgvHangHoa.RowTemplate.Height = 24;
            this.dgvHangHoa.Size = new System.Drawing.Size(658, 460);
            this.dgvHangHoa.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(849, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thêm số lượng";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmSanPhamHetHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 538);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmSanPhamHetHang";
            this.Text = "frmSanPhamHetHang";
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenterLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlCenterLeft;
        private System.Windows.Forms.DataGridView dgvHangHoa;
    }
}