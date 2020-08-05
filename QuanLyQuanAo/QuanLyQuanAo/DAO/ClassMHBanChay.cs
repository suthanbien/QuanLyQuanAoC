using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAo.DAO
{
    class ClassMHBanChay
    {
        private int maHH=0;
        private String tenHH="";
        private int gia=0;
        private int soLuongMua=0;
        private int tongTien=0;

        public ClassMHBanChay(int maHH, string tenHH, int gia, int soLuongMua, int tongTien)
        {
            this.MaHangHoa = maHH;
            this.TenHangHoa = tenHH;
            this.GiaNhap = gia;
            this.SLM = soLuongMua;
            this.TongTien = tongTien;
        }

        public ClassMHBanChay()
        {
        }

        public int MaHangHoa { get => maHH; set => maHH = value; }
        public string TenHangHoa { get => tenHH; set => tenHH = value; }
        public int GiaNhap { get => gia; set => gia = value; }
        public int SLM { get => soLuongMua; set => soLuongMua = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
    }
}
