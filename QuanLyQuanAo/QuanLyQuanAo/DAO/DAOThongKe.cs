using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAo.DAO
{
    class DAOThongKe
    {
        #region các khai báo
        private static DAOThongKe instance;
        #endregion

        #region các phương thức
        public static DAOThongKe Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAOThongKe();
                }
                return instance;
            }
        }

        private DAOThongKe()
        {

        }
        #endregion

        #region các xử lý
        public List<ClassMHBanChay> GetAllThongTinGiamDan()
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
               

             return db.ExecuteQuery<ClassMHBanChay>(" select  hh.MaHangHoa,hh.TenHangHoa,cthd.GiaNhap,SUM(cthd.SoLuong) AS SLM,Sum(cthd.SoLuong*cthd.GiaNhap) as TongTien"
                                    + " FROM dbo.ChiTietHoaDon cthd "
                                    + " INNER join dbo.HangHoa hh ON hh.MaHangHoa = cthd.MaHangHoa "
                                    + " WHERE MaHoaDon IN(SELECT MaHoaDon FROM dbo.HoaDon) "
                                    + " GROUP BY hh.MaHangHoa, hh.TenHangHoa, cthd.GiaNhap "
                                   + "  having SUM(cthd.SoLuong) > 0 "
                                   + "  ORDER BY SLM DESC ").ToList();


            }
        } 
        public List<ClassMHBanChay> GetAllThongTinTangDan()
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
               

             return db.ExecuteQuery<ClassMHBanChay>(" select  hh.MaHangHoa,hh.TenHangHoa,cthd.GiaNhap,SUM(cthd.SoLuong) AS SLM,Sum(cthd.SoLuong*cthd.GiaNhap) as TongTien"
                                    + " FROM dbo.ChiTietHoaDon cthd "
                                    + " INNER join dbo.HangHoa hh ON hh.MaHangHoa = cthd.MaHangHoa "
                                    + " WHERE MaHoaDon IN(SELECT MaHoaDon FROM dbo.HoaDon) "
                                    + " GROUP BY hh.MaHangHoa, hh.TenHangHoa, cthd.GiaNhap "
                                   + "  having SUM(cthd.SoLuong) > 0 "
                                   + "  ORDER BY SLM asc ").ToList();


            }
        }

        public List<ClassMHBanChay> GetThongTinTheoNgayGiamDan(String tuNgay, String denNgay)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {


                return db.ExecuteQuery<ClassMHBanChay>(" select  hh.MaHangHoa,hh.TenHangHoa,cthd.GiaNhap,SUM(cthd.SoLuong) AS SLM,Sum(cthd.SoLuong*cthd.GiaNhap) as TongTien"
                                       + " FROM dbo.ChiTietHoaDon cthd "
                                       + " INNER join dbo.HangHoa hh ON hh.MaHangHoa = cthd.MaHangHoa "
                                       + " WHERE MaHoaDon IN(SELECT MaHoaDon FROM dbo.HoaDon "
                                       + " WHERE NgayLapHoaDon BETWEEN '"+tuNgay+ "' AND'" + denNgay + "'"
                                       + ") "
                                       + " GROUP BY hh.MaHangHoa, hh.TenHangHoa, cthd.GiaNhap "
                                      + "  having SUM(cthd.SoLuong) > 0 "
                                      + "  ORDER BY SLM DESC ").ToList();


            }
        }
        public List<ClassMHBanChay> GetThongTinTheoNgayTangDan(String tuNgay, String denNgay)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {


                return db.ExecuteQuery<ClassMHBanChay>(" select  hh.MaHangHoa,hh.TenHangHoa,cthd.GiaNhap,SUM(cthd.SoLuong) AS SLM,Sum(cthd.SoLuong*cthd.GiaNhap) as TongTien"
                                       + " FROM dbo.ChiTietHoaDon cthd "
                                       + " INNER join dbo.HangHoa hh ON hh.MaHangHoa = cthd.MaHangHoa "
                                       + " WHERE MaHoaDon IN(SELECT MaHoaDon FROM dbo.HoaDon "
                                       + " WHERE NgayLapHoaDon BETWEEN '" + tuNgay + "' AND'" + denNgay + "'"
                                       + ") "
                                       + " GROUP BY hh.MaHangHoa, hh.TenHangHoa, cthd.GiaNhap "
                                      + "  having SUM(cthd.SoLuong) > 0 "
                                      + "  ORDER BY SLM asc ").ToList();


            }
        }
        #endregion
    }
}
