using QuanLyQuanAo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAo.BUS
{
    class BUSHangSanXuat
    {
        #region các khai báo
        private static BUSHangSanXuat instance;
        List<HangSanXuat> lstHangSanXuat = new List<HangSanXuat>();
        #endregion

        #region các phương thức
        public static BUSHangSanXuat Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUSHangSanXuat();
                }
                return instance;
            }
        }

        private BUSHangSanXuat()
        {

        }
        #endregion

        #region các xử lý
        public void GetHangSanXuat(DataGridView dgvHangSanXuat)
        {
            lstHangSanXuat = DAOHangSanXuat.Instance.GetHangSanXuat();
            dgvHangSanXuat.DataSource = lstHangSanXuat;
        }

        public void AddRows(DataGridView dgvHangSanXuat)
        {
            dgvHangSanXuat.DataSource = null;
            HangSanXuat lspMoi = new HangSanXuat();
            lstHangSanXuat.Add(lspMoi);
            dgvHangSanXuat.DataSource = lstHangSanXuat;
        }
        public void XoaRow(DataGridView dgvHangSanXuat)
        {
            lstHangSanXuat.RemoveAt(lstHangSanXuat.Count - 1);
            dgvHangSanXuat.DataSource = null;
            dgvHangSanXuat.DataSource = lstHangSanXuat;
        }
        public void Them(int maHSX, string tenHSX)
        {
            DAOHangSanXuat.Instance.Them(maHSX, tenHSX);
        }

        public void Sua(int maHSX, string tenHSX)
        {

            DAOHangSanXuat.Instance.Sua(maHSX, tenHSX);
        }

        public bool Xoa(int maHSX)
        {

            return DAOHangSanXuat.Instance.Xoa(maHSX);
        }

        public int TimTheoTen(string tenHSX, DataGridView dgvHangSanXuat)
        {
            if (tenHSX.Equals(""))
            {
                lstHangSanXuat = DAOHangSanXuat.Instance.GetHangSanXuat();
                dgvHangSanXuat.DataSource = lstHangSanXuat;
                return 0;
            }
            else
            {
                dgvHangSanXuat.DataSource = DAOHangSanXuat.Instance.TimTheoTen(tenHSX);
                return 1;
            }

        }
        public int TimTheoMa(string tenHSX, DataGridView dgvHangSanXuat)
        {
            try
            {

                dgvHangSanXuat.DataSource = DAOHangSanXuat.Instance.TimTheoMa(Convert.ToInt32(tenHSX));
                return 1;
            }
            catch
            {
                lstHangSanXuat = DAOHangSanXuat.Instance.GetHangSanXuat();
                dgvHangSanXuat.DataSource = lstHangSanXuat;
                return 0;
            }
        }

        public List<string> ListTimTheoTen()
        {
              return DAOHangSanXuat.Instance.ListTimTheoTen();
        }
        public List<string> ListTimTheoMa()
        {
            return DAOHangSanXuat.Instance.ListTimTheoMa();
        }
        #endregion

    }
}
