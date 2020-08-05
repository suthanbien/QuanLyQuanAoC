using QuanLyQuanAo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAo.BUS
{
    class BUSAnHangHoa
    {

        #region các khai báo
        private static BUSAnHangHoa instance;
        private List<ClassHangHoa> lstTimKiem = new List<ClassHangHoa>();
        private List<ClassHangHoa> lstHH;
        private List<ClassHangHoa> lstHHAn;
        #endregion

        #region các phương thức
        public static BUSAnHangHoa Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUSAnHangHoa();
                }
                return instance;
            }
        }

        private BUSAnHangHoa()
        {

        }
        #endregion

        #region các xử lý
        public void GetHangHoa(DataGridView dtg)
        {
            dtg.DataSource = DAOAnHangHoa.Instance.GetHangHoa();
        }
        public void GetHangHoaAn(DataGridView dtg)
        {
            dtg.DataSource = DAOAnHangHoa.Instance.GetHangHoaAn();
        }

        public List<string> ListTimTheoTen()
        {
            return DAOAnHangHoa.Instance.ListTimTheoTen();
        }
        public List<string> ListTimTheoMa()
        {
            return DAOAnHangHoa.Instance.ListTimTheoMa();
        }

        public void TimTheoMa(int maHH,DataGridView dgv, DataGridView dgvAn)
        {
            lstHH = new List<ClassHangHoa>();
            lstHHAn= new List<ClassHangHoa>();
            dgv.DataSource = null;
            dgvAn.DataSource = null;
            lstTimKiem = DAOAnHangHoa.Instance.TimTheoMa(maHH);
            if (lstTimKiem != null)
            {
                for(int i = 0; i < lstTimKiem.Count; i++)
                {
                    if (lstTimKiem[i].TrangThai == true)
                    {
                        lstHH.Add(lstTimKiem[i]);
                    }
                    else
                    {
                        lstHHAn.Add(lstTimKiem[i]);
                    }
                }

                dgv.DataSource = lstHH;
                dgvAn.DataSource = lstHHAn;
            }

        }

        public void TimTheoTen(string ten, DataGridView dgv, DataGridView dgvAn)
        {
            lstHH = new List<ClassHangHoa>();
            lstHHAn = new List<ClassHangHoa>();
            dgv.DataSource = null;
            dgvAn.DataSource = null;
            lstTimKiem = DAOAnHangHoa.Instance.TimTheoTen(ten);
            if (lstTimKiem != null)
            {
                for (int i = 0; i < lstTimKiem.Count; i++)
                {
                    if (lstTimKiem[i].TrangThai == true)
                    {
                        lstHH.Add(lstTimKiem[i]);
                    }
                    else
                    {
                        lstHHAn.Add(lstTimKiem[i]);
                    }
                }
                dgv.DataSource = lstHH;
                dgvAn.DataSource = lstHHAn;
            }


        }

        public void TimTheoSoLuong(int sl, DataGridView dgv, DataGridView dgvAn)
        {
            lstHH = new List<ClassHangHoa>();
            lstHHAn = new List<ClassHangHoa>();
            dgv.DataSource = null;
            dgvAn.DataSource = null;
            lstTimKiem = DAOAnHangHoa.Instance.TimTheoSoLuong(sl);
            if (lstTimKiem != null)
            {
                for (int i = 0; i < lstTimKiem.Count; i++)
                {
                    if (lstTimKiem[i].TrangThai == true)
                    {
                        lstHH.Add(lstTimKiem[i]);
                    }
                    else
                    {
                        lstHHAn.Add(lstTimKiem[i]);
                    }
                }
                dgv.DataSource = lstHH;
                dgvAn.DataSource = lstHHAn;
            }
        }

        public void An(int maHH)
        {
            DAOAnHangHoa.Instance.An(maHH);
        }
        public void Hien(int maHH)
        {
            DAOAnHangHoa.Instance.Hien(maHH);
        }

        #endregion


    }
}
