using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAo.DAO
{
    class ClassChiTietHoaDon
    {

		private int _MaHoaDon=0;

		private int _MaHangHoa=0;

		private string _TenHH="";

		private int _SLConLai=0;
		private int _GiaTien=0;

		private int _SoLuong=0;

		private int _TongTien=0;

		private string _GhiChu="";

		public int MaHoaDon { get => _MaHoaDon; set => _MaHoaDon = value; }
		public int MaHangHoa { get => _MaHangHoa; set => _MaHangHoa = value; }
		public string TenHH { get => _TenHH; set => _TenHH = value; }
		public int SLConLai { get => _SLConLai; set => _SLConLai = value; }
		public int GiaTien { get => _GiaTien; set => _GiaTien = value; }
		public int SoLuong { get => _SoLuong; set => _SoLuong = value; }
		public int TongTien { get => _TongTien; set => _TongTien = value; }
		public string GhiChu { get => _GhiChu; set => _GhiChu = value; }

		public ClassChiTietHoaDon()
		{
		}
	}
}
