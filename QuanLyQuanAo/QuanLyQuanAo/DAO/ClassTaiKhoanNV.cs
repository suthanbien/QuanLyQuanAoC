using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAo.DAO
{
    class ClassTaiKhoanNV
    {
		private int _ID = 0;
		private int _MaNhanVien = 0;

		private string _TenNhanVien = "";

		private string _GioiTinh = "nam";

		private string _Email = "";

		private string _ChucVu = "";


		private string _SoDT = "0000000000";

		private bool? _TinhTrang = true;

		private int _CMND = 0;

		private string _TenDangNhap="";

		private string _Password="";

		private string _Quyen="";

		private string _ChuThich;
		public int ID { get => _ID; set => _ID = value; }
		public int MaNhanVien { get => _MaNhanVien; set => _MaNhanVien = value; }
		public string TenNhanVien { get => _TenNhanVien; set => _TenNhanVien = value; }
		public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
		public string Email { get => _Email; set => _Email = value; }
		public string ChucVu { get => _ChucVu; set => _ChucVu = value; }
		public string SoDT { get => _SoDT; set => _SoDT = value; }
		public bool? TinhTrang { get => _TinhTrang; set => _TinhTrang = value; }
		public int CMND { get => _CMND; set => _CMND = value; }
		public string TenDangNhap { get => _TenDangNhap; set => _TenDangNhap = value; }
		public string Password { get => _Password; set => _Password = value; }
		public string Quyen { get => _Quyen; set => _Quyen = value; }
		public string ChuThich { get => _ChuThich; set => _ChuThich = value; }
		

		public ClassTaiKhoanNV()
		{
		}
	}
}
