using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAo.DAO
{
    class DAOHangSanXuat
    {
        #region các khai báo
        private static DAOHangSanXuat instance;
        #endregion

        #region các phương thức
        public static DAOHangSanXuat Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAOHangSanXuat();
                }
                return instance;
            }
        }

        private DAOHangSanXuat()
        {

        }
        #endregion

        #region các xử lý

        public List<HangSanXuat> GetHangSanXuat()
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<HangSanXuat> lstHSX = new List<HangSanXuat>();
                lstHSX = db.HangSanXuats.Select(p => p).ToList();
                return lstHSX;
            }
        }


        public void Them(int maHSX, string tenHSX)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                HangSanXuat hangSX = new HangSanXuat();
                hangSX.MaHangSanXuat = maHSX;
                hangSX.TenHangSanXuat = tenHSX;
                db.HangSanXuats.InsertOnSubmit(hangSX);
                db.SubmitChanges();
            }
        }

        public void Sua(int ma, string ten)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                HangSanXuat hangSX = db.HangSanXuats.Where(p => p.MaHangSanXuat == ma).SingleOrDefault();

                if (hangSX != null)
                {
                    hangSX.TenHangSanXuat = ten;
                    db.SubmitChanges();

                }

            }
        }

        public bool Xoa(int ma)
        {
            try
            {
                using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
                {
                    HangSanXuat hangSX = db.HangSanXuats.Where(p => p.MaHangSanXuat == ma).SingleOrDefault();
                    db.HangSanXuats.DeleteOnSubmit(hangSX);
                    db.SubmitChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }

        public List<HangSanXuat> TimTheoTen(string tenHSX)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
               // MessageBox.Show(tenHSX);
                List<HangSanXuat> lstHSX = new List<HangSanXuat>();
                lstHSX = db.HangSanXuats.Where(p => p.TenHangSanXuat == tenHSX).ToList();
                return lstHSX;
            }
        }

        public List<HangSanXuat> TimTheoMa(int ma)
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<HangSanXuat> latHSX = new List<HangSanXuat>();
                latHSX = db.HangSanXuats.Where(p => p.MaHangSanXuat == ma).ToList();
                return latHSX;
            }
        }

        public List<string> ListTimTheoTen()
        {
            using (CSDLQuanLyQuanAoDataContext db = new CSDLQuanLyQuanAoDataContext())
            {
                List<string> lstHSX = new List<string>();
                var tenHSX = from n in db.HangSanXuats
                             select n.TenHangSanXuat;
                try
                {
                    foreach (string i in tenHSX)
                    {
                        lstHSX.Add(i);
                    }
                    return lstHSX;
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
                List<string> lstMaHSX = new List<string>();
                var tenHSX = from n in db.HangSanXuats
                             select n.MaHangSanXuat;
                try
                {
                    foreach (int i in tenHSX)
                    {
                       // MessageBox.Show("2");
                        lstMaHSX.Add(i.ToString());
                    }
                    return lstMaHSX;
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
