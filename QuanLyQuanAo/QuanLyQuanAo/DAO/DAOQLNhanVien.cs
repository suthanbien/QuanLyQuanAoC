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
    class DAOQLNhanVien
    {
        #region các khai báo
        private static DAOQLNhanVien instance;
        private List<ClassNhanVien> classNV = new List<ClassNhanVien>();
        #endregion

        #region các phương thức
        public static DAOQLNhanVien Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAOQLNhanVien();
                }
                return instance;
            }
        }

        private DAOQLNhanVien()
        {

        }
        private int GetChucVu(string tenchucVu)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                ChucVu cv = db.ChucVus.Where(p => p.TenChucVu.Equals(tenchucVu)).SingleOrDefault();

                // MessageBox.Show(lsp.MaLoaiSanPham + "");
                return cv.MaChucVu;

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
                               n.ChucVu,n.DiaChi,
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
                classNV = lstNV;
                return lstNV;
            }
        }

        


        public List<string> GetListChucVu()
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<string> lstCV = new List<string>();
                lstCV = db.ChucVus.Select(p => p.TenChucVu).ToList();

                return lstCV;
            }
        }



        public bool Them(int maNV,string tenNV,string chucVu,DateTime ngaySinh,string gioiTinh,int cmnd,
                           string email, DateTime ngayVaoLam, DateTime? ngayNghiLam,string diaChi,string soDT,Boolean tinhTrang,string chuThich)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                int maChucVu = GetChucVu(chucVu);
                var kiemTraNV = db.NhanViens.Where(p => p.CMND.Equals(cmnd) || p.Email.Equals(email) || p.SoDT.Equals(soDT));

                if (kiemTraNV.Count()<=0)
                {
                    NhanVien NhanVienNew = new NhanVien();
                    NhanVienNew.MaNhanVien = maNV;
                    NhanVienNew.TenNhanVien = tenNV;
                    NhanVienNew.CMND = cmnd;
                    NhanVienNew.NgaySinh = ngaySinh;
                    NhanVienNew.GioiTinh = gioiTinh;
                    NhanVienNew.Email = email;
                    NhanVienNew.NgayVaoLam = ngayVaoLam;
                    NhanVienNew.NgayNghiLam = ngayNghiLam;
                    NhanVienNew.ChucVu = maChucVu;
                    NhanVienNew.DiaChi = diaChi;
                    NhanVienNew.SoDT = soDT;
                    NhanVienNew.TinhTrang = tinhTrang;
                    NhanVienNew.GhiChu = chuThich;
                    NhanVienNew.Anh = null;

                    db.NhanViens.InsertOnSubmit(NhanVienNew);
                    db.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
        }

        public bool Sua(int maNV, string tenNV, string chucVu, DateTime ngaySinh, string gioiTinh, int cmnd,
                           string email, DateTime ngayVaoLam, DateTime? ngayNghiLam, string diaChi, string soDT, Boolean tinhTrang, string chuThich)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
               // MessageBox.Show(maNV + "");
                NhanVien nhanVien = db.NhanViens.Where(p => p.MaNhanVien == maNV).SingleOrDefault();
                var kiemTraNV = db.NhanViens.Where(p => p.CMND.Equals(cmnd) || p.Email.Equals(email) || p.SoDT.Equals(soDT));

                if (kiemTraNV.Count() <= 1)
                {

                    int maChucVu = GetChucVu(chucVu);
                    //int maHangSX = GetMaHangSanXuat(hangSanXuat);
                    if (nhanVien != null)
                    {

                        nhanVien.MaNhanVien = maNV;
                        nhanVien.TenNhanVien = tenNV;
                        nhanVien.CMND = cmnd;
                        nhanVien.NgaySinh = ngaySinh;
                        nhanVien.GioiTinh = gioiTinh;
                        nhanVien.Email = email;
                        nhanVien.NgayVaoLam = ngayVaoLam;
                        nhanVien.NgayNghiLam = ngayNghiLam;
                        nhanVien.ChucVu = maChucVu;
                        nhanVien.DiaChi = diaChi;
                        nhanVien.SoDT = soDT;
                        nhanVien.TinhTrang = tinhTrang;
                        nhanVien.GhiChu = chuThich;
                        nhanVien.Anh = null; ;
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
            
        public bool Xoa(int maNV)
        {
            try
            {
                using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
                {
                    //MessageBox.Show( "thuc hien xoa");
                    NhanVien delNV = db.NhanViens.Where(p => p.MaNhanVien == maNV).SingleOrDefault();
                    db.NhanViens.DeleteOnSubmit(delNV);
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

        public List<ClassNhanVien> TimTheoTen(string tenNV)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<ClassNhanVien> lstNV = new List<ClassNhanVien>();

                db.DeferredLoadingEnabled = false;
                var ttNV = from n in db.NhanViens
                           join u in db.ChucVus on n.ChucVu equals u.MaChucVu

                           where n.TenNhanVien.Equals(tenNV)
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
                               u.TenChucVu
                           };

                foreach (var i in ttNV)
                {
                    ClassNhanVien NVNew = new ClassNhanVien();
                    NVNew.MaNhanVien = i.MaNhanVien;
                    NVNew.TenNhanVien = i.TenNhanVien;
                    NVNew.NgaySinh = i.NgaySinh;
                    NVNew.GioiTinh = i.GioiTinh;
                    NVNew.Email = i.Email;
                    NVNew.CMND = i.CMND;
                    NVNew.NgayVaoLam = i.NgayVaoLam;
                    NVNew.NgayNghiLam = i.NgayNghiLam;
                    NVNew.ChucVu = i.TenChucVu;
                    NVNew.DiaChi = i.DiaChi;
                    NVNew.SoDT = i.SoDT;
                    NVNew.TinhTrang = i.TinhTrang;
                    NVNew.GhiChu = i.GhiChu;

                    if (i.Anh != null)
                    {
                        NVNew.Image = ByteArrayToImage(i.Anh.ToArray());
                    }
                    lstNV.Add(NVNew);
                }
                //classNV = lstHH;
                return lstNV;
            }
        }

        public List<ClassNhanVien> TimTheoMa(int maNV)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<ClassNhanVien> lstNV = new List<ClassNhanVien>();

                db.DeferredLoadingEnabled = false;
                var ttNV = from n in db.NhanViens
                           join u in db.ChucVus on n.ChucVu equals u.MaChucVu

                           where n.MaNhanVien == maNV
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
                               u.TenChucVu
                           };

                foreach (var i in ttNV)
                {
                    ClassNhanVien NVNew = new ClassNhanVien();
                    NVNew.MaNhanVien = i.MaNhanVien;
                    NVNew.TenNhanVien = i.TenNhanVien;
                    NVNew.NgaySinh = i.NgaySinh;
                    NVNew.GioiTinh = i.GioiTinh;
                    NVNew.Email = i.Email;
                    NVNew.CMND = i.CMND;
                    NVNew.NgayVaoLam = i.NgayVaoLam;
                    NVNew.NgayNghiLam = i.NgayNghiLam;
                    NVNew.ChucVu = i.TenChucVu;
                    NVNew.DiaChi = i.DiaChi;
                    NVNew.SoDT = i.SoDT;
                    NVNew.TinhTrang = i.TinhTrang;
                    NVNew.GhiChu = i.GhiChu;

                    if (i.Anh != null)
                    {
                        NVNew.Image = ByteArrayToImage(i.Anh.ToArray());
                    }
                    lstNV.Add(NVNew);
                }
                //classNV = lstHH;
                return lstNV;
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
                var tenNV = from n in db.NhanViens
                            select n.TenNhanVien;
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
                var tenHH = from n in db.NhanViens
                            select n.MaNhanVien;
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
    }
        #endregion

    }
