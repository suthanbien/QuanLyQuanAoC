namespace quanlyquanao
{
    partial class frmNhapma6so
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapma6so));
            this.lblNhapMa6So = new System.Windows.Forms.Label();
            this.txtNhapMa6So = new System.Windows.Forms.TextBox();
            this.btnXacNhan2 = new System.Windows.Forms.Button();
            this.lblChuaNhanDuocMa = new System.Windows.Forms.Label();
            this.btnGuiLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNhapMa6So
            // 
            this.lblNhapMa6So.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNhapMa6So.AutoSize = true;
            this.lblNhapMa6So.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNhapMa6So.ForeColor = System.Drawing.Color.Black;
            this.lblNhapMa6So.Location = new System.Drawing.Point(41, 37);
            this.lblNhapMa6So.Name = "lblNhapMa6So";
            this.lblNhapMa6So.Size = new System.Drawing.Size(418, 22);
            this.lblNhapMa6So.TabIndex = 0;
            this.lblNhapMa6So.Text = "Nhập mã 6 số vừa được gửi đến Email/Sdt của bạn:";
            // 
            // txtNhapMa6So
            // 
            this.txtNhapMa6So.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNhapMa6So.BackColor = System.Drawing.Color.White;
            this.txtNhapMa6So.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNhapMa6So.ForeColor = System.Drawing.Color.Black;
            this.txtNhapMa6So.Location = new System.Drawing.Point(45, 89);
            this.txtNhapMa6So.Name = "txtNhapMa6So";
            this.txtNhapMa6So.Size = new System.Drawing.Size(243, 30);
            this.txtNhapMa6So.TabIndex = 1;
            // 
            // btnXacNhan2
            // 
            this.btnXacNhan2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXacNhan2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnXacNhan2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacNhan2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXacNhan2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXacNhan2.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan2.Location = new System.Drawing.Point(303, 79);
            this.btnXacNhan2.Name = "btnXacNhan2";
            this.btnXacNhan2.Size = new System.Drawing.Size(156, 39);
            this.btnXacNhan2.TabIndex = 2;
            this.btnXacNhan2.Text = "Xác Nhận";
            this.btnXacNhan2.UseVisualStyleBackColor = false;
            // 
            // lblChuaNhanDuocMa
            // 
            this.lblChuaNhanDuocMa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblChuaNhanDuocMa.AutoSize = true;
            this.lblChuaNhanDuocMa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChuaNhanDuocMa.ForeColor = System.Drawing.Color.Black;
            this.lblChuaNhanDuocMa.Location = new System.Drawing.Point(45, 151);
            this.lblChuaNhanDuocMa.Name = "lblChuaNhanDuocMa";
            this.lblChuaNhanDuocMa.Size = new System.Drawing.Size(188, 22);
            this.lblChuaNhanDuocMa.TabIndex = 3;
            this.lblChuaNhanDuocMa.Text = "Chưa Nhận Được Mã?";
            // 
            // btnGuiLai
            // 
            this.btnGuiLai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuiLai.BackColor = System.Drawing.Color.LightGray;
            this.btnGuiLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuiLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuiLai.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuiLai.ForeColor = System.Drawing.Color.Black;
            this.btnGuiLai.Location = new System.Drawing.Point(239, 138);
            this.btnGuiLai.Name = "btnGuiLai";
            this.btnGuiLai.Size = new System.Drawing.Size(113, 35);
            this.btnGuiLai.TabIndex = 4;
            this.btnGuiLai.Text = "Gửi lại";
            this.btnGuiLai.UseVisualStyleBackColor = false;
            // 
            // frmNhapma6so
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(591, 271);
            this.Controls.Add(this.btnGuiLai);
            this.Controls.Add(this.lblChuaNhanDuocMa);
            this.Controls.Add(this.btnXacNhan2);
            this.Controls.Add(this.txtNhapMa6So);
            this.Controls.Add(this.lblNhapMa6So);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNhapma6so";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lấy Lại Mật Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhapMa6So;
        private System.Windows.Forms.TextBox txtNhapMa6So;
        private System.Windows.Forms.Button btnXacNhan2;
        private System.Windows.Forms.Label lblChuaNhanDuocMa;
        private System.Windows.Forms.Button btnGuiLai;
    }
}