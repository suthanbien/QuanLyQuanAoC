using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAo.DAO
{
    class ClassPhieuNhap
    {
		private int _ID;

		private string _NVTao;

		private DateTime _NgayTao;

		private bool? _TinhTrang;

		private System.Nullable<System.DateTime> _NgayXacNhan;

		private string _NVXacNhan="";

		private int _TongTien;

		private string _GhiChu;

		public int ID { get => _ID; set => _ID = value; }
		public string NVTao { get => _NVTao; set => _NVTao = value; }
		public DateTime NgayTao { get => _NgayTao; set => _NgayTao = value; }
		public bool? TinhTrang { get => _TinhTrang; set => _TinhTrang = value; }
		public DateTime? NgayXacNhan { get => _NgayXacNhan; set => _NgayXacNhan = value; }
		public int TongTien { get => _TongTien; set => _TongTien = value; }
		public string GhiChu { get => _GhiChu; set => _GhiChu = value; }
		public string NVXacNhan { get => _NVXacNhan; set => _NVXacNhan = value; }

		public ClassPhieuNhap()
		{
		}
	}
}
