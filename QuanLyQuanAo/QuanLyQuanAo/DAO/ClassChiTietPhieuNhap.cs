using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAo.DAO
{
    class ClassChiTietPhieuNhap
    {
		private int _ID;

		private int _MaPhieuNhap;
		private int _MaHH;
		private string TenHH;

		private int _SoLuongCon;

		private int _SoLuongNhap;

		private int _GiaCapNhat;

		private int _TongTien;

		private string _GhiChu;

		private System.Nullable<bool> _TinhTrang;

		public int ID { get => _ID; set => _ID = value; }
		public int MaPhieuNhap { get => _MaPhieuNhap; set => _MaPhieuNhap = value; }
		public string TenHH1 { get => TenHH; set => TenHH = value; }
		public int SoLuongCon { get => _SoLuongCon; set => _SoLuongCon = value; }
		public int SoLuongNhap { get => _SoLuongNhap; set => _SoLuongNhap = value; }
		public int GiaCapNhat { get => _GiaCapNhat; set => _GiaCapNhat = value; }
		public int TongTien { get => _TongTien; set => _TongTien = value; }
		public string GhiChu { get => _GhiChu; set => _GhiChu = value; }
		public bool? TinhTrang { get => _TinhTrang; set => _TinhTrang = value; }
		public int MaHH { get => _MaHH; set => _MaHH = value; }

		public ClassChiTietPhieuNhap()
		{
		}
	}
}
