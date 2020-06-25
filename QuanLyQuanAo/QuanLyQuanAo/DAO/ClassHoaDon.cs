using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAo.DAO
{
    class ClassHoaDon
    {
		private int _MaHoaDon;

		private string _TenKhachHang;

		private string _TenNhanVien;

		private System.DateTime _NgayLapHoaDon;

		private int _TongTien;

		private string _GhiChu;

		public int MaHoaDon { get => _MaHoaDon; set => _MaHoaDon = value; }
		public string TenKhachHang { get => _TenKhachHang; set => _TenKhachHang = value; }
		public string TenNhanVien { get => _TenNhanVien; set => _TenNhanVien = value; }
		public DateTime NgayLapHoaDon { get => _NgayLapHoaDon; set => _NgayLapHoaDon = value; }
		public int TongTien { get => _TongTien; set => _TongTien = value; }
		public string GhiChu { get => _GhiChu; set => _GhiChu = value; }

		public ClassHoaDon()
		{
		}
	}
}
