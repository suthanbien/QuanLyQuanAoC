using QuanLyQuanAo.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAo.BUS
{
    class BUSLoaiSanPham
    {
        #region các khai báo
        private static BUSLoaiSanPham instance;
        List<LoaiSanPham> lstLoaiSanPham = new List<LoaiSanPham>();
        #endregion

        #region các phương thức
        public static BUSLoaiSanPham Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUSLoaiSanPham();
                }
                return instance;
            }
        }

        private BUSLoaiSanPham()
        {

        }
        #endregion

        #region các xử lý
        public void GetLoaiSanPham(DataGridView dgvLoaiSanPham)
        {
            lstLoaiSanPham = DAOLoaiSanPham.Instance.GetLoaiSanPham();
            dgvLoaiSanPham.DataSource= lstLoaiSanPham;
        }

        public void AddRows(DataGridView dgvLoaiSanPham)
        {
            dgvLoaiSanPham.DataSource = null;
            LoaiSanPham lspMoi = new LoaiSanPham();
            lstLoaiSanPham.Add(lspMoi);
            dgvLoaiSanPham.DataSource = lstLoaiSanPham;
        }
        public void XoaRow(DataGridView dgvLoaiSanPham)
        {
            lstLoaiSanPham.RemoveAt(lstLoaiSanPham.Count-1);
            dgvLoaiSanPham.DataSource = null;
            dgvLoaiSanPham.DataSource = lstLoaiSanPham;
        }
        public void Them(int maLSP,string tenLSP)
        {
            DAOLoaiSanPham.Instance.Them( maLSP,tenLSP);
        }

        public void Sua(int maLSP, string tenLSP)
        {

            DAOLoaiSanPham.Instance.Sua(maLSP, tenLSP);
        }

        public bool Xoa( int maLSP)
        {
           
            return DAOLoaiSanPham.Instance.Xoa(maLSP);
        }

        public int TimTheoTen(string tenLSP,DataGridView dgvLoaiSanPham)
        {
            if (tenLSP.Equals(""))
            {
                lstLoaiSanPham = DAOLoaiSanPham.Instance.GetLoaiSanPham();
                dgvLoaiSanPham.DataSource = lstLoaiSanPham;
                return 0;
            }
            else
            {
                dgvLoaiSanPham.DataSource = DAOLoaiSanPham.Instance.TimTheoTen(tenLSP);
                return 1;
            }
           
        }
        public int TimTheoMa(string tenLSP, DataGridView dgvLoaiSanPham)
        {
            try
            {
                
                dgvLoaiSanPham.DataSource = DAOLoaiSanPham.Instance.TimTheoMa(Convert.ToInt32(tenLSP));
                return 1;
            }
            catch
            {
                lstLoaiSanPham = DAOLoaiSanPham.Instance.GetLoaiSanPham();
                dgvLoaiSanPham.DataSource = lstLoaiSanPham;
                return 0;
            }
        }

        public List<string> ListTimTheoTen()
        {
            return DAOLoaiSanPham.Instance.ListTimTheoTen();
        }
        public List<string> ListTimTheoMa()
        {
            return DAOLoaiSanPham.Instance.ListTimTheoMa();
        }
        #endregion
    }
    }
