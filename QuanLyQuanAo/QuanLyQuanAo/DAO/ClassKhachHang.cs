using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAo.DAO
{
    class ClassKhachHang
    {
		private int _MaKhachHang=0;

		private string _TenKhachHang="";

		private System.DateTime _Ngaysinh;

		private string _GioiTinh="nam";

		private string _Email="";

		private string _DiaChi="";

		private string _SDT="0000000000";

		private string _LoaiKhachHang= "thường";

		private string _GhiChu="";

		private Image _Image = null;

		public int MaKhachHang { get => _MaKhachHang; set => _MaKhachHang = value; }
		public string TenKhachHang { get => _TenKhachHang; set => _TenKhachHang = value; }
		public DateTime Ngaysinh { get => _Ngaysinh; set => _Ngaysinh = value; }
		public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
		public string Email { get => _Email; set => _Email = value; }
		public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
		public string SDT { get => _SDT; set => _SDT = value; }
		public string LoaiKhachHang { get => _LoaiKhachHang; set => _LoaiKhachHang = value; }
		public string GhiChu { get => _GhiChu; set => _GhiChu = value; }
		public Image Image { get => _Image; set => _Image = value; }

		public ClassKhachHang()
		{
		}
	}
}
