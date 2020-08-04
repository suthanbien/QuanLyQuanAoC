using QuanLyQuanAo.DAO;
using QuanLyQuanAo.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAo.BUS
{
    class BUSThongKe
    {
        #region các khai báo
        private static BUSThongKe instance;
        private List<ClassMHBanChay> lstMHBC = new List<ClassMHBanChay>();
        #endregion

        #region các phương thức
        public static BUSThongKe Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUSThongKe();
                }
                return instance;
            }
        }

        private BUSThongKe()
        {

        }
        #endregion

        #region các xử lý
        public void GetAllThongTinGiamDan(DataGridView dgv)
        {
            dgv.DataSource = null;
            lstMHBC.Clear();
            lstMHBC= DAOThongKe.Instance.GetAllThongTinGiamDan();
            dgv.DataSource = lstMHBC;

        }
        public void GetAllThongTinTangDan(DataGridView dgv)
        {
            dgv.DataSource = null;
            lstMHBC.Clear();
            lstMHBC = DAOThongKe.Instance.GetAllThongTinTangDan();
            dgv.DataSource = lstMHBC;
        }

        public void GetThongTinTheoNgayGiamDan(DataGridView dgv,String tuNgay,String denNgay)
        {
            dgv.DataSource = null;
            lstMHBC.Clear();
            lstMHBC = DAOThongKe.Instance.GetThongTinTheoNgayGiamDan( tuNgay,  denNgay);
            dgv.DataSource = lstMHBC;
        }
        public void GetThongTinTheoNgayTangDan(DataGridView dgv, String tuNgay, String denNgay)
        {
            dgv.DataSource = null;
            lstMHBC.Clear();
            lstMHBC = DAOThongKe.Instance.GetThongTinTheoNgayTangDan(tuNgay, denNgay);
            dgv.DataSource = lstMHBC;
        }
        public void InBaoCao(frmPrintThongKe frm, String tuNgay, String denNgay)
        {
            frmPrintThongKe.LstMHBanChay = lstMHBC;
            frmPrintThongKe.mauIn = 0;
            if (tuNgay.Equals(""))
            {
                frmPrintThongKe._ThongTin = "Tất cả mặt hàng";
            }
            else
            {
                frmPrintThongKe._ThongTin = "Những mặt hàng bán chạy từ ngày "+tuNgay+" đến ngày "+denNgay;
            }
            frm.ShowDialog();
        }
        #endregion
    }
}
