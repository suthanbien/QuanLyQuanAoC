using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAo.DAO
{
    class ClassHoaDon
    {
		private int _MaHoaDon=0;
		private string _MaNhanVien="";
		private string _TenNhanVien="";

		private string _MaKhachHang="";
		private string _TenKhachHang="";
		private string _DiaChi="";
		private string _DienThoai="";
		private string _LoaiKH="";

		private System.DateTime _NgayLapHoaDon;

		private int _TongTien=0;
		private string _GhiChu="";


		public ClassHoaDon()
		{
		}

		public int MaHoaDon { get => _MaHoaDon; set => _MaHoaDon = value; }
		public string MaNhanVien { get => _MaNhanVien; set => _MaNhanVien = value; }
		public string TenNhanVien { get => _TenNhanVien; set => _TenNhanVien = value; }
		public string MaKhachHang { get => _MaKhachHang; set => _MaKhachHang = value; }
		public string TenKhachHang { get => _TenKhachHang; set => _TenKhachHang = value; }
		public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
		public string DienThoai { get => _DienThoai; set => _DienThoai = value; }
		public string LoaiKH { get => _LoaiKH; set => _LoaiKH = value; }
		public DateTime NgayLapHoaDon { get => _NgayLapHoaDon; set => _NgayLapHoaDon = value; }
		public int TongTien { get => _TongTien; set => _TongTien = value; }
		public string GhiChu { get => _GhiChu; set => _GhiChu = value; }
	}
}
