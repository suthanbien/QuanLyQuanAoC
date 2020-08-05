using QuanLyQuanAo.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAo.GUI
{
    public partial class frmAnhNV : Form
    {
		private String filename = "";
		private string _MaNhanVien;


		public string MaNhanVien
		{
			set { txtMaNV.Text = _MaNhanVien = value.ToString(); }
			get { return txtMaNV.Text; }
		}
		public string TenNhanVien
		{
			set { txtTenNV.Text = value; }
			get { return txtTenNV.Text; }
		}
		public string CMND
		{
			set { txtCMND.Text = value; }
			get { return txtCMND.Text; }
		}

		public string NgaySinh
		{
			set { txtNgaySinh.Text = value; }
			get { return txtNgaySinh.Text; }
		}

		public string GioiTinh
		{
			set { txtGioiTinh.Text = value.ToString(); }
			get { return txtGioiTinh.Text; }
		}
		public string Email
		{
			set { txtEmail.Text = value.ToString(); }
			get { return txtEmail.Text; }
		}
		public string ChucVu
		{
			set { txtChucVu.Text = value.ToString(); }
			get { return txtChucVu.Text; }
		}
		public string SoDT
		{
			set { txtSDT.Text = value.ToString(); }
			get { return txtSDT.Text; }
		}
		public string DiaChi
		{
			set { txtDiaChi.Text = value.ToString(); }
			get { return txtDiaChi.Text; }
		}


		public Image Image
		{
			set { picAnhNV.Image = value; }
			get { return picAnhNV.Image; }
		}
		public frmAnhNV()
        {
            InitializeComponent();
        }

		private void btnSelect_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();

			String DataPath = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(

			Directory.GetCurrentDirectory()).ToString()).ToString()).ToString()).ToString();
			ofd.InitialDirectory = DataPath + "\\Anh";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				filename = ofd.FileName;
				picAnhNV.Image = Bitmap.FromFile(filename);
				btnOk.Enabled = true;
			}
		}

		private void btnOk_Click(object sender, EventArgs e)
		{

			int maNV = Convert.ToInt32(txtMaNV.Text.ToString());
			Image anhNV = picAnhNV.Image;
			BUSQLNhanVien.Instance.DoiAnh(maNV, anhNV);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
