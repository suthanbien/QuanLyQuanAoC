using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAo.DAO
{
    class DAOTaiKhoanNV
    {
        #region các khai báo
        private static DAOTaiKhoanNV instance;
        #endregion

        #region các phương thức
        public static DAOTaiKhoanNV Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAOTaiKhoanNV();
                }
                return instance;
            }
        }

        private DAOTaiKhoanNV()
        {

        }
        private int GetQuyen(string tenQuyen)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                Quyen quyen = db.Quyens.Where(p => p.TenQuyen.Equals(tenQuyen)).SingleOrDefault();

                // MessageBox.Show(lsp.MaLoaiSanPham + "");
                return quyen.MaQuyen;

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
                           join c in db.ChucVus on n.ChucVu equals c.MaChucVu
                           join u in db.Users on n.MaNhanVien equals u.MaNhanVien into temp
                           from subtemp in temp.DefaultIfEmpty()


                               //where n.TinhTrang == true && c.ChucVu != 1
                           select new
                           {
                               NhanVien = n,
                               User = subtemp == null ? -1 : subtemp.ID,
                               c.TenChucVu
                           };


                foreach (var i in ttNV)
                {
                    
                    if (i.User==-1)
                    {
                        ClassNhanVien HHNew = new ClassNhanVien();
                        HHNew.MaNhanVien = i.NhanVien.MaNhanVien;
                        HHNew.TenNhanVien = i.NhanVien.TenNhanVien;
                        HHNew.NgaySinh = i.NhanVien.NgaySinh;
                        HHNew.GioiTinh = i.NhanVien.GioiTinh;
                        HHNew.Email = i.NhanVien.Email;
                        HHNew.CMND = i.NhanVien.CMND;
                        HHNew.NgayVaoLam = i.NhanVien.NgayVaoLam;
                        HHNew.NgayNghiLam = i.NhanVien.NgayNghiLam;
                        HHNew.ChucVu = i.TenChucVu;
                        HHNew.DiaChi = i.NhanVien.DiaChi;
                        HHNew.SoDT = i.NhanVien.SoDT;
                        HHNew.TinhTrang = i.NhanVien.TinhTrang;
                        HHNew.GhiChu = i.NhanVien.GhiChu;

                        lstNV.Add(HHNew);
                    }
                     
                }

                return lstNV;
            }
        }

        public List<ClassTaiKhoanNV> GetTaiKhoan()
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<ClassTaiKhoanNV> lstNV = new List<ClassTaiKhoanNV>();

                db.DeferredLoadingEnabled = false;
                var ttNV = from n in db.NhanViens
                           join c in db.ChucVus on n.ChucVu equals c.MaChucVu
                           join u in db.Users on n.MaNhanVien equals u.MaNhanVien
                           join q in db.Quyens on u.Quyen equals q.MaQuyen


                           //where n.TinhTrang == true && c.ChucVu != 1
                           select new
                           {
                               NhanVien = n,
                               User = u,
                               Quyen=q,
                               c.TenChucVu
                           };


                foreach (var i in ttNV)
                {

                    if (i.User.Quyen!=1)
                    {
                        ClassTaiKhoanNV HHNew = new ClassTaiKhoanNV();
                        HHNew.ID = i.User.ID;
                        HHNew.MaNhanVien = i.NhanVien.MaNhanVien;
                        HHNew.TenNhanVien = i.NhanVien.TenNhanVien;
                        HHNew.GioiTinh = i.NhanVien.GioiTinh;
                        HHNew.Email = i.NhanVien.Email;
                        HHNew.CMND = i.NhanVien.CMND;
                        HHNew.ChucVu = i.TenChucVu;
                        HHNew.SoDT = i.NhanVien.SoDT;
                        HHNew.TinhTrang = i.User.TinhTrang;
                        HHNew.ChuThich = i.User.ChuThich;
                        HHNew.TenDangNhap = i.User.TenDangNhap;
                        HHNew.Password = i.User.Password;
                        HHNew.Quyen = i.Quyen.TenQuyen;

                        lstNV.Add(HHNew);
                    }
                        
                    
                }

                return lstNV;
            }

        }

        public List<string> GetListChucVu()
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<string> lstCV = new List<string>();
                lstCV = db.ChucVus.Where(p => p.TenChucVu!="Admin").Select(p=>p.TenChucVu).ToList();

                return lstCV;
            }
        }

        public List<string> GetListQuyen()
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<string> lstCV = new List<string>();
                lstCV = db.Quyens.Where(p => p.MaQuyen!=1).Select(p=>p.TenQuyen).ToList();

                return lstCV;
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

        public List<ClassNhanVien> TimNhanVienTheoTen(string tenNV)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<ClassNhanVien> lstNV = new List<ClassNhanVien>();

                db.DeferredLoadingEnabled = false;
                var ttNV = from n in db.NhanViens
                           join c in db.ChucVus on n.ChucVu equals c.MaChucVu
                           join u in db.Users on n.MaNhanVien equals u.MaNhanVien into temp
                           from subtemp in temp.DefaultIfEmpty()


                               //where n.TinhTrang == true && c.ChucVu != 1
                           select new
                           {
                               NhanVien = n,
                               User = subtemp == null ? -1 : subtemp.ID,
                               c.TenChucVu
                           };


                foreach (var i in ttNV)
                {

                    if (i.User == -1 && i.NhanVien.TenNhanVien.Equals(tenNV))
                    {
                        ClassNhanVien HHNew = new ClassNhanVien();
                        HHNew.MaNhanVien = i.NhanVien.MaNhanVien;
                        HHNew.TenNhanVien = i.NhanVien.TenNhanVien;
                        HHNew.NgaySinh = i.NhanVien.NgaySinh;
                        HHNew.GioiTinh = i.NhanVien.GioiTinh;
                        HHNew.Email = i.NhanVien.Email;
                        HHNew.CMND = i.NhanVien.CMND;
                        HHNew.NgayVaoLam = i.NhanVien.NgayVaoLam;
                        HHNew.NgayNghiLam = i.NhanVien.NgayNghiLam;
                        HHNew.ChucVu = i.TenChucVu;
                        HHNew.DiaChi = i.NhanVien.DiaChi;
                        HHNew.SoDT = i.NhanVien.SoDT;
                        HHNew.TinhTrang = i.NhanVien.TinhTrang;
                        HHNew.GhiChu = i.NhanVien.GhiChu;

                        lstNV.Add(HHNew);
                    }


                }

                return lstNV;
            }
        }
        public List<ClassTaiKhoanNV> TimTaiKhoanTheoTen(string tenNV)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<ClassTaiKhoanNV> lstNV = new List<ClassTaiKhoanNV>();

                db.DeferredLoadingEnabled = false;
                var ttNV = from n in db.NhanViens
                           join c in db.ChucVus on n.ChucVu equals c.MaChucVu
                           join u in db.Users on n.MaNhanVien equals u.MaNhanVien
                           join q in db.Quyens on u.Quyen equals q.MaQuyen


                           //where n.TinhTrang == true && c.ChucVu != 1
                           select new
                           {
                               NhanVien = n,
                               User = u,
                               Quyen = q,
                               c.TenChucVu
                           };


                foreach (var i in ttNV)
                {

                    if (i.User.Quyen != 1&& i.NhanVien.TenNhanVien.Equals(tenNV))
                    {

                        ClassTaiKhoanNV HHNew = new ClassTaiKhoanNV();
                        HHNew.ID = i.User.ID;
                        HHNew.MaNhanVien = i.NhanVien.MaNhanVien;
                        HHNew.TenNhanVien = i.NhanVien.TenNhanVien;
                        HHNew.GioiTinh = i.NhanVien.GioiTinh;
                        HHNew.Email = i.NhanVien.Email;
                        HHNew.CMND = i.NhanVien.CMND;
                        HHNew.ChucVu = i.TenChucVu;
                        HHNew.SoDT = i.NhanVien.SoDT;
                        HHNew.TinhTrang = i.User.TinhTrang;
                        HHNew.ChuThich = i.User.ChuThich;
                        HHNew.TenDangNhap = i.User.TenDangNhap;
                        HHNew.Password = i.User.Password;
                        HHNew.Quyen = i.Quyen.TenQuyen;

                        lstNV.Add(HHNew);
                    }


                }

                return lstNV;
            }

        }

        public List<ClassNhanVien> TimNhanVienTheoMa(int maNV)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<ClassNhanVien> lstNV = new List<ClassNhanVien>();

                db.DeferredLoadingEnabled = false;
                var ttNV = from n in db.NhanViens
                           join c in db.ChucVus on n.ChucVu equals c.MaChucVu
                           join u in db.Users on n.MaNhanVien equals u.MaNhanVien into temp
                           from subtemp in temp.DefaultIfEmpty()


                               //where n.TinhTrang == true && c.ChucVu != 1
                           select new
                           {
                               NhanVien = n,
                               User = subtemp == null ? -1 : subtemp.ID,
                               c.TenChucVu
                           };


                foreach (var i in ttNV)
                {

                    if (i.User == -1 && i.NhanVien.MaNhanVien==maNV)
                    {
                        ClassNhanVien HHNew = new ClassNhanVien();
                        HHNew.MaNhanVien = i.NhanVien.MaNhanVien;
                        HHNew.TenNhanVien = i.NhanVien.TenNhanVien;
                        HHNew.NgaySinh = i.NhanVien.NgaySinh;
                        HHNew.GioiTinh = i.NhanVien.GioiTinh;
                        HHNew.Email = i.NhanVien.Email;
                        HHNew.CMND = i.NhanVien.CMND;
                        HHNew.NgayVaoLam = i.NhanVien.NgayVaoLam;
                        HHNew.NgayNghiLam = i.NhanVien.NgayNghiLam;
                        HHNew.ChucVu = i.TenChucVu;
                        HHNew.DiaChi = i.NhanVien.DiaChi;
                        HHNew.SoDT = i.NhanVien.SoDT;
                        HHNew.TinhTrang = i.NhanVien.TinhTrang;
                        HHNew.GhiChu = i.NhanVien.GhiChu;

                        lstNV.Add(HHNew);
                    }


                }

                return lstNV;
            }
        }
        public List<ClassTaiKhoanNV> TimTaiKhoanTheoMa(int maNV)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<ClassTaiKhoanNV> lstNV = new List<ClassTaiKhoanNV>();

                db.DeferredLoadingEnabled = false;
                var ttNV = from n in db.NhanViens
                           join c in db.ChucVus on n.ChucVu equals c.MaChucVu
                           join u in db.Users on n.MaNhanVien equals u.MaNhanVien
                           join q in db.Quyens on u.Quyen equals q.MaQuyen


                           //where n.TinhTrang == true && c.ChucVu != 1
                           select new
                           {
                               NhanVien = n,
                               User = u,
                               Quyen = q,
                               c.TenChucVu
                           };


                foreach (var i in ttNV)
                {

                    if (i.User.Quyen != 1 && i.NhanVien.MaNhanVien==maNV)
                    {
                        ClassTaiKhoanNV HHNew = new ClassTaiKhoanNV();
                        HHNew.ID = i.User.ID;
                        HHNew.MaNhanVien = i.NhanVien.MaNhanVien;
                        HHNew.TenNhanVien = i.NhanVien.TenNhanVien;
                        HHNew.GioiTinh = i.NhanVien.GioiTinh;
                        HHNew.Email = i.NhanVien.Email;
                        HHNew.CMND = i.NhanVien.CMND;
                        HHNew.ChucVu = i.TenChucVu;
                        HHNew.SoDT = i.NhanVien.SoDT;
                        HHNew.TinhTrang = i.User.TinhTrang;
                        HHNew.ChuThich = i.User.ChuThich;
                        HHNew.TenDangNhap = i.User.TenDangNhap;
                        HHNew.Password = i.User.Password;
                        HHNew.Quyen = i.Quyen.TenQuyen;

                        lstNV.Add(HHNew);
                    }


                }

                return lstNV;
            }

        }

        public List<ClassNhanVien> TimNhanVienTheoChucVu(string chucVu)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<ClassNhanVien> lstNV = new List<ClassNhanVien>();

                db.DeferredLoadingEnabled = false;
                var ttNV = from n in db.NhanViens
                           join c in db.ChucVus on n.ChucVu equals c.MaChucVu
                           join u in db.Users on n.MaNhanVien equals u.MaNhanVien into temp
                           from subtemp in temp.DefaultIfEmpty()


                               //where n.TinhTrang == true && c.ChucVu != 1
                           select new
                           {
                               NhanVien = n,
                               User = subtemp == null ? -1 : subtemp.ID,
                               c.TenChucVu
                           };


                foreach (var i in ttNV)
                {

                    if (i.User == -1 && i.TenChucVu.Equals(chucVu))
                    {
                        ClassNhanVien HHNew = new ClassNhanVien();
                        HHNew.MaNhanVien = i.NhanVien.MaNhanVien;
                        HHNew.TenNhanVien = i.NhanVien.TenNhanVien;
                        HHNew.NgaySinh = i.NhanVien.NgaySinh;
                        HHNew.GioiTinh = i.NhanVien.GioiTinh;
                        HHNew.Email = i.NhanVien.Email;
                        HHNew.CMND = i.NhanVien.CMND;
                        HHNew.NgayVaoLam = i.NhanVien.NgayVaoLam;
                        HHNew.NgayNghiLam = i.NhanVien.NgayNghiLam;
                        HHNew.ChucVu = i.TenChucVu;
                        HHNew.DiaChi = i.NhanVien.DiaChi;
                        HHNew.SoDT = i.NhanVien.SoDT;
                        HHNew.TinhTrang = i.NhanVien.TinhTrang;
                        HHNew.GhiChu = i.NhanVien.GhiChu;

                        lstNV.Add(HHNew);
                    }


                }

                return lstNV;
            }
        }
        public List<ClassTaiKhoanNV> TimTaiKhoanTheoChucVu(string chucVu)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<ClassTaiKhoanNV> lstNV = new List<ClassTaiKhoanNV>();

                db.DeferredLoadingEnabled = false;
                var ttNV = from n in db.NhanViens
                           join c in db.ChucVus on n.ChucVu equals c.MaChucVu
                           join u in db.Users on n.MaNhanVien equals u.MaNhanVien
                           join q in db.Quyens on u.Quyen equals q.MaQuyen


                           //where n.TinhTrang == true && c.ChucVu != 1
                           select new
                           {
                               NhanVien = n,
                               User = u,
                               Quyen = q,
                               c.TenChucVu
                           };


                foreach (var i in ttNV)
                {

                    if (i.User.Quyen != 1 && i.TenChucVu.Equals(chucVu))
                    {
                        ClassTaiKhoanNV HHNew = new ClassTaiKhoanNV();
                        HHNew.ID = i.User.ID;
                        HHNew.MaNhanVien = i.NhanVien.MaNhanVien;
                        HHNew.TenNhanVien = i.NhanVien.TenNhanVien;
                        HHNew.GioiTinh = i.NhanVien.GioiTinh;
                        HHNew.Email = i.NhanVien.Email;
                        HHNew.CMND = i.NhanVien.CMND;
                        HHNew.ChucVu = i.TenChucVu;
                        HHNew.SoDT = i.NhanVien.SoDT;
                        HHNew.TinhTrang = i.User.TinhTrang;
                        HHNew.ChuThich = i.User.ChuThich;
                        HHNew.TenDangNhap = i.User.TenDangNhap;
                        HHNew.Password = i.User.Password;
                        HHNew.Quyen = i.Quyen.TenQuyen;

                        lstNV.Add(HHNew);
                    }


                }

                return lstNV;
            }

        }

        public void TaoTaiKhoan(int maNV, string taiKhoan, string matKhau, string quyen)
        {
            using (CSDLQuanLyQuanAoDataContext db=new CSDLQuanLyQuanAoDataContext())
            {
                int maQuyen = GetQuyen(quyen);
                User newUser = new User();
                newUser.MaNhanVien = maNV;
                newUser.TenDangNhap = taiKhoan;
                newUser.Password = matKhau;
                newUser.Quyen = maQuyen;
                db.Users.InsertOnSubmit(newUser);
                db.SubmitChanges();
            }

        }

        public bool XoaTaiKhoan(int m_ID)
        {
            try
            {
                using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
                {
                    User taiKhoan = db.Users.Where(p => p.ID == m_ID).SingleOrDefault();
                    db.Users.DeleteOnSubmit(taiKhoan);
                    db.SubmitChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool KiemTraTenDangNhap(string tenDN)
        {
            using (CSDLQuanLyQuanAoDataContext db=new CSDLQuanLyQuanAoDataContext())
            {
                var kq = db.Users.Where(p => p.TenDangNhap.Equals(tenDN)).ToList();
                if (kq.Count==0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void SuaTK(int m_ID, int maNV, string tenDN, string m_MK, string quyen, string chuThich, bool tinhTrang)
        {
            
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                int quyenUS = GetQuyen(quyen);
                User editUser = db.Users.Where(p => p.ID.Equals(m_ID)).SingleOrDefault();
                if (editUser != null)
                {
                    editUser.ID = m_ID;
                    editUser.MaNhanVien = maNV;
                    editUser.TenDangNhap = tenDN;
                    editUser.Password = m_MK;
                    editUser.Quyen = quyenUS;
                    editUser.ChuThich = chuThich;
                    editUser.TinhTrang = tinhTrang;
                    db.SubmitChanges();
                }


            }
        }
        #endregion
    }
}
