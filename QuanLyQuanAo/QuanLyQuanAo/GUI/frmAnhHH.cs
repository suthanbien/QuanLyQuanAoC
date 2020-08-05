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
    public partial class frmAnhHH : Form 
    {
		private String filename = "";
		private string _MaHangHoa;


		public string MaHangHoa {
			set { txtMaHH.Text = _MaHangHoa= value.ToString(); }
			get { return txtMaHH.Text; }
		}
		public string TenHangHoa {
			set { txtTenHH.Text = value; }
			get { return txtTenHH.Text; }
		}
		public string LoaiHangHoa
		{
			set { txtLoaiHH.Text = value; }
			get { return txtLoaiHH.Text; }
		}

		public string HangSanXuat
		{
			set { txtHangSX.Text = value; }
			get { return txtHangSX.Text; }
		}

		public string GiaNhap {
			set { txtGiaNhap.Text = value.ToString(); }
			get { return txtGiaNhap.Text; }
		}
		public string GiaBan {
			set { txtGiaBan.Text = value.ToString(); }
			get { return txtGiaBan.Text; }
		}
		public string SoLuongCon {
			set { txtSoLuong.Text = value.ToString(); }
			get { return txtSoLuong.Text; }
		}
		public Image Image {
			set { picAnhHH.Image = value; }
			get { return picAnhHH.Image; }
		}
		public string ChuThich
		{
			set { picAnhHH.Text = value; }
			get { return picAnhHH.Text; }
		}


		public frmAnhHH()
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
				picAnhHH.Image = Bitmap.FromFile(filename);
				btnOk.Enabled = true;
			}
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			int maHH = Convert.ToInt32(txtMaHH.Text.ToString());
			Image anhHH = picAnhHH.Image;
			BUSHangHoa.Instance.DoiAnh(maHH, anhHH);

		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmAnhHH_Load(object sender, EventArgs e)
		{

		}
	}
}
