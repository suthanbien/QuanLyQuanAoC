using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAo.DAO
{
    class DAOKhachHang
    {
        #region các khai báo
        private static DAOKhachHang instance;

        private List<ClassKhachHang> classKH = new List<ClassKhachHang>();
        #endregion

        #region các phương thức
        public static DAOKhachHang Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAOKhachHang();
                }
                return instance;
            }
        }

        private DAOKhachHang()
        {

        }
        private int GetLoaiKH(string tenLoai)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                LoaiKhachHang lkh = db.LoaiKhachHangs.Where(p => p.TenLoaiKhachHang.Equals(tenLoai)).SingleOrDefault();

                // MessageBox.Show(lsp.MaLoaiSanPham + "");
                return lkh.MaLoaiKhachHang;

            }
        }

        private byte[] ImageToByteArray(Image anhHH)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                anhHH.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
        }
        public Image ByteArrayToImage(byte[] arr)
        {
            using (MemoryStream ms = new MemoryStream(arr))
            {
                Image resurtImage = Image.FromStream(ms);
                return resurtImage;
            }
        }
        #endregion

        #region các xử lý
        public List<ClassKhachHang> GetKhachHang()
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<ClassKhachHang> lstKH = new List<ClassKhachHang>();

                db.DeferredLoadingEnabled = false;
                var ttKH = from k in db.KhachHangs
                           join l in db.LoaiKhachHangs on k.LoaiKhachHang equals l.MaLoaiKhachHang

                           select new
                           {
                               KhachHang = k,
                               LoaiKhachHang=l
                                
                           };

                foreach (var i in ttKH)
                {
                  //  MessageBox.Show(""+i);
                    ClassKhachHang KHNew = new ClassKhachHang();
                    KHNew.MaKhachHang = i.KhachHang.MaKhachHang;
                    KHNew.TenKhachHang = i.KhachHang.TenKhachHang;
                    KHNew.Ngaysinh = i.KhachHang.Ngaysinh;
                    KHNew.GioiTinh = i.KhachHang.GioiTinh;
                    KHNew.Email = i.KhachHang.Email;
                    KHNew.DiaChi = i.KhachHang.DiaChi;
                    KHNew.SDT = i.KhachHang.SDT;
                    KHNew.LoaiKhachHang = i.LoaiKhachHang.TenLoaiKhachHang;
                    KHNew.GhiChu = i.KhachHang.GhiChu;
                    if (i.KhachHang.Image != null)
                    {
                        KHNew.Image = ByteArrayToImage(i.KhachHang.Image.ToArray());
                    }
                    lstKH.Add(KHNew);
                }
                classKH = lstKH;
                return lstKH;
            }
        }
        public List<ClassNhanVien> GetNhanVien()
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<ClassNhanVien> lstNV = new List<ClassNhanVien>();

                db.DeferredLoadingEnabled = false;
                var ttNV = from n in db.NhanViens
                           join u in db.ChucVus on n.ChucVu equals u.MaChucVu
                           where n.TinhTrang == true && n.ChucVu != 1
                           select new
                           {
                               n.MaNhanVien,
                               n.TenNhanVien,
                               n.NgaySinh,
                               n.GioiTinh,
                               n.Email,
                               n.NgayVaoLam,
                               n.NgayNghiLam,
                               n.ChucVu,
                               n.DiaChi,
                               n.SoDT,
                               n.TinhTrang,
                               n.GhiChu,
                               n.Anh,
                               n.CMND,
                               u.TenChucVu,
                           };

                foreach (var i in ttNV)
                {
                    ClassNhanVien HHNew = new ClassNhanVien();
                    HHNew.MaNhanVien = i.MaNhanVien;
                    HHNew.TenNhanVien = i.TenNhanVien;
                    HHNew.NgaySinh = i.NgaySinh;
                    HHNew.GioiTinh = i.GioiTinh;
                    HHNew.Email = i.Email;
                    HHNew.CMND = i.CMND;
                    HHNew.NgayVaoLam = i.NgayVaoLam;
                    HHNew.NgayNghiLam = i.NgayNghiLam;
                    HHNew.ChucVu = i.TenChucVu;
                    HHNew.DiaChi = i.DiaChi;
                    HHNew.SoDT = i.SoDT;
                    HHNew.TinhTrang = i.TinhTrang;
                    HHNew.GhiChu = i.GhiChu;

                    if (i.Anh != null)
                    {
                        HHNew.Image = ByteArrayToImage(i.Anh.ToArray());
                    }
                    lstNV.Add(HHNew);
                }
               // classNV = lstNV;
                return lstNV;
            }
        }




        public List<string> GetListLoaiKH()
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<string> lstLKH= new List<string>();
                lstLKH = db.LoaiKhachHangs.Select(p => p.TenLoaiKhachHang).ToList();

                return lstLKH;
            }
        }



        public bool Them(int maKH, string tenKH, DateTime ngaySinhKH, string gioiTinh,
                     string email, string diaChi, string soDT, string loaiKH, string chuThich)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                int maloaiKH = GetLoaiKH(loaiKH);

                var kiemTraKH = db.KhachHangs.Where(p => p.Email.Equals(email) || p.SDT.Equals(soDT));

                if (kiemTraKH.Count() <= 0)
                {
                    KhachHang KhachHangNew = new KhachHang();
                    KhachHangNew.MaKhachHang = maKH;
                    KhachHangNew.TenKhachHang = tenKH;
                    KhachHangNew.Ngaysinh = ngaySinhKH;
                    KhachHangNew.GioiTinh = gioiTinh;
                    KhachHangNew.Email = email;     
                    KhachHangNew.DiaChi = diaChi;
                    KhachHangNew.SDT = soDT;
                    KhachHangNew.LoaiKhachHang = maloaiKH;
                    KhachHangNew.GhiChu = chuThich;

                    db.KhachHangs.InsertOnSubmit(KhachHangNew);
                    db.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        public bool Sua(int maKH, string tenKH, DateTime ngaySinhKH, string gioiTinh,
                     string email, string diaChi, string soDT, string loaiKH, string chuThich)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                // MessageBox.Show(maNV + "");
                KhachHang khachHang = db.KhachHangs.Where(p => p.MaKhachHang == maKH).SingleOrDefault();
                var kiemTraNV = db.NhanViens.Where(p => p.Email.Equals(email) || p.SoDT.Equals(soDT));

                if (kiemTraNV.Count() <= 1)
                {

                    int maloaiKH = GetLoaiKH(loaiKH);
                    //int maHangSX = GetMaHangSanXuat(hangSanXuat);
                    if (khachHang != null)
                    {

                        khachHang.MaKhachHang = maKH;
                        khachHang.TenKhachHang = tenKH;                     
                        khachHang.Ngaysinh = ngaySinhKH;
                        khachHang.GioiTinh = gioiTinh;
                        khachHang.Email = email;
                        khachHang.DiaChi = diaChi;
                        khachHang.SDT = soDT;
                        khachHang.LoaiKhachHang = maloaiKH;                       
                        khachHang.GhiChu = chuThich;
                        db.SubmitChanges();
                        return true;

                    }
                    else
                    {
                        MessageBox.Show("null");
                        return false;
                    }

                }
                else
                {
                    return false;
                }
            }
        }

        public bool Xoa(int maKH)
        {
            try
            {
                using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
                {
                    //MessageBox.Show( "thuc hien xoa");
                    KhachHang delKH = db.KhachHangs.Where(p => p.MaKhachHang == maKH).SingleOrDefault();
                    db.KhachHangs.DeleteOnSubmit(delKH);
                    db.SubmitChanges();
                    return true;
                }
            }
            catch
            {
                //MessageBox.Show("thuc hien xoa"+ex);
                return false;
            }

        }

        public List<ClassKhachHang> TimTheoTen(string tenKH)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<ClassKhachHang> lstKH = new List<ClassKhachHang>();

                db.DeferredLoadingEnabled = false;
                var ttNV = from n in db.KhachHangs
                           join u in db.LoaiKhachHangs on n.LoaiKhachHang equals u.MaLoaiKhachHang

                           where n.TenKhachHang.Equals(tenKH)
                           select new
                           {
                               n.MaKhachHang,
                               n.TenKhachHang,
                               n.Ngaysinh,
                               n.GioiTinh,
                               n.Email,
                               n.DiaChi,
                               n.SDT,

                               n.GhiChu,
                               n.Image,                        
                               u.TenLoaiKhachHang
                           };

                foreach (var i in ttNV)
                {
                    ClassKhachHang KHNew = new ClassKhachHang();
                    KHNew.MaKhachHang = i.MaKhachHang;
                    KHNew.TenKhachHang = i.TenKhachHang;
                    KHNew.Ngaysinh = i.Ngaysinh;
                    KHNew.GioiTinh = i.GioiTinh;
                    KHNew.Email = i.Email;
                    KHNew.LoaiKhachHang = i.TenLoaiKhachHang;
                    KHNew.DiaChi = i.DiaChi;
                    KHNew.SDT = i.SDT;
                    KHNew.GhiChu = i.GhiChu;

                    if (i.Image != null)
                    {
                        KHNew.Image = ByteArrayToImage(i.Image.ToArray());
                    }
                    lstKH.Add(KHNew);
                }
                //classNV = lstHH;
                return lstKH ;
            }
        }

        public List<ClassKhachHang> TimTheoMa(int maKH)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<ClassKhachHang> lstKH = new List<ClassKhachHang>();

                db.DeferredLoadingEnabled = false;
                var ttNV = from n in db.KhachHangs
                           join u in db.LoaiKhachHangs on n.LoaiKhachHang equals u.MaLoaiKhachHang

                           where n.MaKhachHang==maKH
                           select new
                           {
                               n.MaKhachHang,
                               n.TenKhachHang,
                               n.Ngaysinh,
                               n.GioiTinh,
                               n.Email,
                               n.DiaChi,
                               n.SDT,

                               n.GhiChu,
                               n.Image,
                               u.TenLoaiKhachHang
                           };

                foreach (var i in ttNV)
                {
                    ClassKhachHang KHNew = new ClassKhachHang();
                    KHNew.MaKhachHang = i.MaKhachHang;
                    KHNew.TenKhachHang = i.TenKhachHang;
                    KHNew.Ngaysinh = i.Ngaysinh;
                    KHNew.GioiTinh = i.GioiTinh;
                    KHNew.Email = i.Email;
                    KHNew.LoaiKhachHang = i.TenLoaiKhachHang;
                    KHNew.DiaChi = i.DiaChi;
                    KHNew.SDT = i.SDT;
                    KHNew.GhiChu = i.GhiChu;

                    if (i.Image != null)
                    {
                        KHNew.Image = ByteArrayToImage(i.Image.ToArray());
                    }
                    lstKH.Add(KHNew);
                }
                //classNV = lstHH;
                return lstKH;
            }
        }

        public List<ClassHangHoa> TimTheoLoaiHH(string tenLHH)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<ClassHangHoa> lstHH = new List<ClassHangHoa>();

                db.DeferredLoadingEnabled = false;
                var ttHH = from n in db.HangHoas
                           join u in db.HangSanXuats on n.MaHangSanXuat equals u.MaHangSanXuat
                           join l in db.LoaiSanPhams on n.MaLoaiHangHoa equals l.MaLoaiSanPham
                           where l.TenLoaiSanPham == tenLHH
                           select new
                           {
                               n.MaHangHoa,
                               n.TenHangHoa,
                               n.GiaNhap,
                               n.GiaBan,
                               n.SoLuongCon,
                               n.TrangThai,
                               n.ChuThich,
                               n.Image,
                               u.TenHangSanXuat,
                               l.TenLoaiSanPham
                           };

                foreach (var i in ttHH)
                {
                    ClassHangHoa HHNew = new ClassHangHoa();
                    HHNew.MaHangHoa = i.MaHangHoa;
                    HHNew.TenHangHoa = i.TenHangHoa;
                    HHNew.LoaiHangHoa = i.TenLoaiSanPham;
                    HHNew.HangSanXuat = i.TenHangSanXuat;
                    HHNew.GiaNhap = i.GiaNhap;
                    HHNew.GiaBan = i.GiaBan;
                    HHNew.SoLuongCon = i.SoLuongCon;
                    HHNew.TrangThai = i.TrangThai;
                    HHNew.ChuThich = i.ChuThich;
                    if (i.Image != null)
                    {
                        HHNew.Image = ByteArrayToImage(i.Image.ToArray());
                    }
                    lstHH.Add(HHNew);
                }
                //classHH = lstHH;
                return lstHH;
            }
        }

        public List<string> ListTimTheoTen()
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<string> lstTenNV = new List<string>();
                var tenNV = from n in db.KhachHangs
                            select n.TenKhachHang;
                try
                {
                    foreach (string i in tenNV)
                    {
                        lstTenNV.Add(i);
                    }
                    return lstTenNV;
                }
                catch
                {
                    return null;
                }
            }
        }

        public List<string> ListTimTheoMa()
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<string> lstManNV = new List<string>();
                var tenHH = from n in db.KhachHangs
                            select n.MaKhachHang;
                try
                {
                    foreach (int i in tenHH)
                    {
                        lstManNV.Add(i.ToString());
                    }
                    return lstManNV;
                }
                catch
                {
                    return null;
                }
            }
        }

        public void DoiAnh(int MaNV, Image image)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                NhanVien nhanVien = db.NhanViens.Where(p => p.MaNhanVien == MaNV).SingleOrDefault();
                byte[] fileAnh = ImageToByteArray(image);

                if (nhanVien != null)
                {

                    nhanVien.Anh = fileAnh;

                    db.SubmitChanges();

                }
            }

        }
        #endregion
    }
}
