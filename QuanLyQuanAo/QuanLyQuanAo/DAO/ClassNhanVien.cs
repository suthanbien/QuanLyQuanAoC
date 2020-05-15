using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAo.DAO
{
    class ClassNhanVien
    {
		private int _MaNhanVien=0;

		private string _TenNhanVien="";

		private DateTime _NgaySinh;

		private string _GioiTinh="nam";

		private string _Email="";

		private DateTime _NgayVaoLam;

		private System.Nullable<System.DateTime> _NgayNghiLam=new DateTime();

		private string _ChucVu="";

		private string _DiaChi="";

		private string _SoDT="0000000000";

		private bool _TinhTrang=true;
		private int _CMND = 0;


		private Image _Image = null;
		private string _GhiChu="";

		public int MaNhanVien { get => _MaNhanVien; set => _MaNhanVien = value; }
		public string TenNhanVien { get => _TenNhanVien; set => _TenNhanVien = value; }
		public DateTime NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
		public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
		public string Email { get => _Email; set => _Email = value; }
		public DateTime NgayVaoLam { get => _NgayVaoLam; set => _NgayVaoLam = value; }
		public DateTime? NgayNghiLam { get => _NgayNghiLam; set => _NgayNghiLam = value; }
		public string ChucVu { get => _ChucVu; set => _ChucVu = value; }
		public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
		public string SoDT { get => _SoDT; set => _SoDT = value; }
		public bool TinhTrang { get => _TinhTrang; set => _TinhTrang = value; }
		public string GhiChu { get => _GhiChu; set => _GhiChu = value; }
		public Image Image { get => _Image; set => _Image = value; }
		public int CMND { get => _CMND; set => _CMND = value; }

		public ClassNhanVien()
		{
		}
	}
}
