using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAo.DAO
{
    class DAOLoaiSanPham
    {
        #region các khai báo
        private static DAOLoaiSanPham instance;

        #endregion

        #region các phương thức
        public static DAOLoaiSanPham Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAOLoaiSanPham();
                }
                return instance;
            }
        }

        private DAOLoaiSanPham()
        {

        }
        #endregion

        #region các xử lý
        public List<LoaiSanPham> LayLoaiSanPham()
        {
            //tạo csdl
            using (CSDLQuanLyQuanAoDataContext db=new CSDLQuanLyQuanAoDataContext())
            {
                List<LoaiSanPham> lsLSP = new List<LoaiSanPham>();
                lsLSP = db.LoaiSanPhams.Select(n => n).ToList();
                return lsLSP;
            }
        }


        public void Them(int maLSP, string tenLSP)
        {
            using (CSDLQuanLyQuanAoDataContext db=new CSDLQuanLyQuanAoDataContext())
            {
                LoaiSanPham loaiSP = new LoaiSanPham();
                //loaiSP.MaLoaiSanPham = maLSP;
                loaiSP.TenLoaiSanPham = tenLSP;
                db.LoaiSanPhams.InsertOnSubmit(loaiSP);
                db.SubmitChanges();
                //MessageBox.Show( loaiSP.MaLoaiSanPham.ToString());

            }
        }

        public void Sua(int maLSP, string tenLSP)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                LoaiSanPham loaiSP = db.LoaiSanPhams.Where(p => p.MaLoaiSanPham == maLSP).SingleOrDefault();

                if (loaiSP != null)
                {
                    loaiSP.TenLoaiSanPham = tenLSP;
                    db.SubmitChanges();
                   
                }
 
            }
        }

        public bool Xoa(int maLSP)
        {
            try
            {
                using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
                {
                    LoaiSanPham loaiSP = db.LoaiSanPhams.Where(p => p.MaLoaiSanPham == maLSP).SingleOrDefault();
                    db.LoaiSanPhams.DeleteOnSubmit(loaiSP);
                    db.SubmitChanges();
                    return true;
                }
            }
            catch 
            {
                return false;
            }
           
        }

        public List<LoaiSanPham> TimTheoTen(string tenLSP)
        {
            using (CSDLQuanLyQuanAoDataContext db=new CSDLQuanLyQuanAoDataContext())
            {
                List<LoaiSanPham> lsLSP = new List<LoaiSanPham>();
                lsLSP = db.LoaiSanPhams.Where(p => p.TenLoaiSanPham==tenLSP).ToList();
                return lsLSP;
            }
        }

        public List<LoaiSanPham> TimTheoMa(int maLSP)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<LoaiSanPham> lsLSP = new List<LoaiSanPham>();
                lsLSP = db.LoaiSanPhams.Where(p => p.MaLoaiSanPham == maLSP).ToList();
                return lsLSP;
            }
        }

        public List<string> ListTimTheoTen()
        {
            using (CSDLQuanLyQuanAoDataContext db=new CSDLQuanLyQuanAoDataContext())
            {
                List<string> lstTenLSP = new List<string>();
                var tenLSP = from n in db.LoaiSanPhams
                            select n.TenLoaiSanPham;
                try
                {
                    foreach (string i in tenLSP)
                    {
                        lstTenLSP.Add(i);
                    }
                    return lstTenLSP;
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
                List<string> lstTenLSP = new List<string>();
                var tenLSP = from n in db.LoaiSanPhams
                             select n.MaLoaiSanPham;
                try
                {
                    foreach (int i in tenLSP)
                    {
                        lstTenLSP.Add(i.ToString());
                    }
                    return lstTenLSP;
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
