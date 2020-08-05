using QuanLyQuanAo.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAo.GUI
{
    public partial class frmThongKe : Form
    {
        #region Khai báo biến
        private String m_MLSP;
        private String[] OldLoaiSanPham;
        private bool checkXemTatCa=true;
        private string tuNgay="",denNgay="";
        #endregion
        #region Các phương thức



        #endregion


        #region Các Xử Lý
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmMain)(this.MdiParent)).moMnuMatHangBanChay();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            BUSThongKe.Instance.GetAllThongTinGiamDan(dgvThongTin);
            btnGiamDan.Enabled = false;
            btnTangDan.Enabled = true;
           /* tuNgay = datepicTuNgay.Value.Year.ToString()
                       + "/" + datepicTuNgay.Value.Month.ToString()
                       + "/" + datepicTuNgay.Value.Day.ToString();
            denNgay = datepicDenNgay.Value.Year.ToString()
                       + "/" + datepicDenNgay.Value.Month.ToString()
                       + "/" + datepicDenNgay.Value.Day.ToString();*/

          //  MessageBox.Show(tuNgay+" Den "+denNgay);
        }

        private void btnGiamDan_Click(object sender, EventArgs e)
        {
            if (checkXemTatCa)
            {
                btnTangDan.Enabled = true;
                BUSThongKe.Instance.GetAllThongTinGiamDan(dgvThongTin);
                btnGiamDan.Enabled = false;
            }
            else
            {
                btnTangDan.Enabled = true;
                BUSThongKe.Instance.GetThongTinTheoNgayGiamDan(dgvThongTin, tuNgay, denNgay);
                btnGiamDan.Enabled = false;
            }
        }

        private void btnTangDan_Click(object sender, EventArgs e)
        {
            if (checkXemTatCa)
            {
                btnGiamDan.Enabled = true;
                BUSThongKe.Instance.GetAllThongTinTangDan(dgvThongTin);
                btnTangDan.Enabled = false;
            }else
            {
                btnGiamDan.Enabled = true;
               
                BUSThongKe.Instance.GetThongTinTheoNgayTangDan(dgvThongTin, tuNgay, denNgay);
                btnTangDan.Enabled = false;
            }
           
        }

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            checkXemTatCa = true;
            BUSThongKe.Instance.GetAllThongTinGiamDan(dgvThongTin);
            btnGiamDan.Enabled = false;
            btnTangDan.Enabled = true;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmPrintThongKe frm  = new frmPrintThongKe();

            BUSThongKe.Instance.InBaoCao(frm, tuNgay, denNgay);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            checkXemTatCa = false;
            tuNgay = datepicTuNgay.Value.Year.ToString()
                      + "/" + datepicTuNgay.Value.Month.ToString()
                      + "/" + datepicTuNgay.Value.Day.ToString();
            denNgay = datepicDenNgay.Value.Year.ToString()
                       + "/" + datepicDenNgay.Value.Month.ToString()
                       + "/" + datepicDenNgay.Value.Day.ToString();

            BUSThongKe.Instance.GetThongTinTheoNgayGiamDan(dgvThongTin,tuNgay,denNgay);

            btnGiamDan.Enabled = false;
            btnTangDan.Enabled = true;
        }
    }
}
