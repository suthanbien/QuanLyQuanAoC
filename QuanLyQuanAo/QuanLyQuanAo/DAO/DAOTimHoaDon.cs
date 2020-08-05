using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAo.DAO
{
    class DAOTimHoaDon
    {
        #region các khai báo
        private static DAOTimHoaDon instance;
        #endregion

        #region các phương thức
        public static DAOTimHoaDon Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAOTimHoaDon();
                }
                return instance;
            }
        }

        private DAOTimHoaDon()
        {

        }
        #endregion

        #region các xử lý
        public List<ClassHoaDon> GetAllHoaDon()
        {
            using (CSDLQuanLyQuanAoDataContext db= new CSDLQuanLyQuanAoDataContext())
            {
                List<ClassHoaDon> lstHD = new List<ClassHoaDon>();

                db.DeferredLoadingEnabled = false;
                var ttHD = from h in db.HoaDons
                           join n in db.NhanViens on h.MaNhanVien equals n.MaNhanVien
                           join k in db.KhachHangs on h.MaKhachHang equals k.MaKhachHang
                          
                           select new
                           {
                               HoaDon=h,
                               NhanVien=n,
                               KhachHang=k
                              
                           };


                foreach (var i in ttHD)
                {

                        ClassHoaDon hoaDonNew = new ClassHoaDon();

                    hoaDonNew.MaHoaDon = i.HoaDon.MaHoaDon;
                    hoaDonNew.TenKhachHang = i.KhachHang.TenKhachHang;
                    hoaDonNew.TenNhanVien = i.NhanVien.TenNhanVien;
                    hoaDonNew.TongTien = i.HoaDon.TongTien;
                    hoaDonNew.NgayLapHoaDon = i.HoaDon.NgayLapHoaDon;
                    hoaDonNew.GhiChu = i.HoaDon.GhiChu;

                        lstHD.Add(hoaDonNew);
                }

                return lstHD;
            }
        }

        public List<ClassHoaDon> TimTheoMa(int maHD)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<ClassHoaDon> lstHD = new List<ClassHoaDon>();

                db.DeferredLoadingEnabled = false;
                var ttHD = from h in db.HoaDons
                           join n in db.NhanViens on h.MaNhanVien equals n.MaNhanVien
                           join k in db.KhachHangs on h.MaKhachHang equals k.MaKhachHang
                           where h.MaHoaDon==maHD
                           select new
                           {
                               HoaDon = h,
                               NhanVien = n,
                               KhachHang = k

                           };


                foreach (var i in ttHD)
                {

                    ClassHoaDon hoaDonNew = new ClassHoaDon();

                    hoaDonNew.MaHoaDon = i.HoaDon.MaHoaDon;
                    hoaDonNew.TenKhachHang = i.KhachHang.TenKhachHang;
                    hoaDonNew.TenNhanVien = i.NhanVien.TenNhanVien;
                    hoaDonNew.TongTien = i.HoaDon.TongTien;
                    hoaDonNew.NgayLapHoaDon = i.HoaDon.NgayLapHoaDon;
                    hoaDonNew.GhiChu = i.HoaDon.GhiChu;

                    lstHD.Add(hoaDonNew);
                }

                return lstHD;
            }
        }
        public List<ClassHoaDon> TimTheoKH(string keyTimKiem)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<ClassHoaDon> lstHD = new List<ClassHoaDon>();

                db.DeferredLoadingEnabled = false;
                var ttHD = from h in db.HoaDons
                           join n in db.NhanViens on h.MaNhanVien equals n.MaNhanVien
                           join k in db.KhachHangs on h.MaKhachHang equals k.MaKhachHang
                           where k.MaKhachHang.ToString().Equals(keyTimKiem)
                           || k.TenKhachHang.Equals(keyTimKiem)
                           || k.SDT.Equals(keyTimKiem)
                           || k.Email.Equals(keyTimKiem)

                           select new
                           {
                               HoaDon = h,
                               NhanVien = n,
                               KhachHang = k

                           };


                foreach (var i in ttHD)
                {

                    ClassHoaDon hoaDonNew = new ClassHoaDon();

                    hoaDonNew.MaHoaDon = i.HoaDon.MaHoaDon;
                    hoaDonNew.TenKhachHang = i.KhachHang.TenKhachHang;
                    hoaDonNew.TenNhanVien = i.NhanVien.TenNhanVien;
                    hoaDonNew.TongTien = i.HoaDon.TongTien;
                    hoaDonNew.NgayLapHoaDon = i.HoaDon.NgayLapHoaDon;
                    hoaDonNew.GhiChu = i.HoaDon.GhiChu;

                    lstHD.Add(hoaDonNew);
                }

                return lstHD;
            }
        }

        public List<ClassChiTietHoaDon> GetChiTietHD(int maHDon)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                //  MessageBox.Show(maHDon+"");
                List<ClassChiTietHoaDon> lstCTHD = new List<ClassChiTietHoaDon>();
                db.DeferredLoadingEnabled = false;
                var ttCTHD = from c in db.ChiTietHoaDons
                             join h in db.HangHoas on c.MaHangHoa equals h.MaHangHoa
                             where c.MaHoaDon == maHDon


                             select new
                             {
                                 ChiTietHoaDon = c,
                                 HangHoa = h

                             };


                foreach (var i in ttCTHD)
                {

                    ClassChiTietHoaDon chiTietNew = new ClassChiTietHoaDon();

                    chiTietNew.MaHangHoa = i.ChiTietHoaDon.MaHangHoa;
                    chiTietNew.TenHH = i.HangHoa.TenHangHoa;
                    chiTietNew.GiaTien = i.HangHoa.GiaBan;
                    chiTietNew.SoLuong = i.ChiTietHoaDon.SoLuong;
                    chiTietNew.TongTien = i.ChiTietHoaDon.TongTien;
                    chiTietNew.GhiChu = i.ChiTietHoaDon.GhiChu;
                    lstCTHD.Add(chiTietNew);
                }

                return lstCTHD;
            }
        }

        public List<string> ListTimTheoMa()
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<string> lstManHD = new List<string>();
                var tenHH = from n in db.HoaDons
                            select n.MaHoaDon;
                try
                {
                    foreach (int i in tenHH)
                    {
                        lstManHD.Add(i.ToString());
                    }
                    return lstManHD;
                }
                catch
                {
                    return null;
                }
            }
        }
        #endregion
    }
}
