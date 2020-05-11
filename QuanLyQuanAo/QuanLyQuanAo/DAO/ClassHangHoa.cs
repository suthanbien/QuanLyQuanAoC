using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAo.DAO
{
    class ClassHangHoa
    {
		private int _MaHangHoa;

		private string _TenHangHoa;

		private string _LoaiHangHoa="";

		private string _HangSanXuat="";

		private int _GiaNhap;

		private int _GiaBan;

		private int _SoLuongCon;

		private bool _TrangThai=true;

		private Image _Image=null;

		private string _ChuThich="";

		public int MaHangHoa { get => _MaHangHoa; set => _MaHangHoa = value; }
		public string TenHangHoa { get => _TenHangHoa; set => _TenHangHoa = value; }
		public string LoaiHangHoa { get => _LoaiHangHoa; set => _LoaiHangHoa = value; }
		public string HangSanXuat { get => _HangSanXuat; set => _HangSanXuat = value; }
		public int GiaNhap { get => _GiaNhap; set => _GiaNhap = value; }
		public int GiaBan { get => _GiaBan; set => _GiaBan = value; }
		public int SoLuongCon { get => _SoLuongCon; set => _SoLuongCon = value; }
		public bool TrangThai { get => _TrangThai; set => _TrangThai = value; }
		public Image Image { get => _Image; set => _Image = value; }
		public string ChuThich { get => _ChuThich; set => _ChuThich = value; }
		
		
		public ClassHangHoa()
		{
		}

		public ClassHangHoa(int maHangHoa, string tenHangHoa, string loaiHangHoa, string hangSanXuat, int giaNhap, int giaBan, int soLuongCon, bool trangThai, Image image, string chuThich)
		{
			_MaHangHoa = maHangHoa;
			_TenHangHoa = tenHangHoa;
			_LoaiHangHoa = loaiHangHoa;
			_HangSanXuat = hangSanXuat;
			_GiaNhap = giaNhap;
			_GiaBan = giaBan;
			_SoLuongCon = soLuongCon;
			_TrangThai = trangThai;
			_Image = image;
			_ChuThich = chuThich;
		}
	}
}
