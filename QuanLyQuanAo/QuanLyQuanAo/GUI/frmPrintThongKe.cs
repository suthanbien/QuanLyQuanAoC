using QuanLyQuanAo.DAO;
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
    public partial class frmPrintThongKe : Form
    {
        public static int mauIn = 0;
        //Thong Ke
        public static string _ThongTin = "";
     
        private static List<ClassMHBanChay> lstMHBanChay;

        // Hoa Don

        public static string maHD = "";
        public static string maNV = "";
        public static string tenNV = "";
        public static string ngayBan = "";
        public static string maKH = "";
        public static string tenKH = "";
        public static string diaChiKH = "";
        public static string dienThoai = "";
        public static string loaiKH = "";
        public static string tongTien = "";
        public static string giamGia = "";
        public static string conLai = "";
        public static string ghiChu = "123";

        private static List<ClassChiTietHoaDon> lstChiTietHD;
        List<ClassChiTietHoaDon> lstCTHDPrint = new List<ClassChiTietHoaDon>();




        public frmPrintThongKe()
        {
            InitializeComponent();
        }

        internal static List<ClassMHBanChay> LstMHBanChay { get => lstMHBanChay; set => lstMHBanChay = value; }
        internal static List<ClassChiTietHoaDon> lstChiTietHoaDon { get => lstChiTietHD; set => lstChiTietHD = value; }
        private void frmPrint_Load(object sender, EventArgs e)
        {
            if (mauIn==0)
            {
                crystalReport_MatHangBanChay.SetDataSource(LstMHBanChay);
                crystalReport_MatHangBanChay.SetParameterValue("pThongTin", _ThongTin);
                crystalReportViewer.ReportSource = crystalReport_MatHangBanChay;
            }
            if (mauIn == 1)
            {
                crystalReport_HoaDon.SetDataSource(lstChiTietHoaDon);
                crystalReport_HoaDon.SetParameterValue("pmaHD", maHD);
                crystalReport_HoaDon.SetParameterValue("pmaNV", maNV);
                crystalReport_HoaDon.SetParameterValue("ptenNV", tenNV);
                crystalReport_HoaDon.SetParameterValue("pngayBan", ngayBan);
                crystalReport_HoaDon.SetParameterValue("pmaKH", maKH);
                crystalReport_HoaDon.SetParameterValue("ptenKH", tenKH);
                crystalReport_HoaDon.SetParameterValue("pdiaChi", diaChiKH);
                crystalReport_HoaDon.SetParameterValue("pdienThoaiKH", dienThoai);
                crystalReport_HoaDon.SetParameterValue("ploaiKH", loaiKH);
                crystalReport_HoaDon.SetParameterValue("ptongTien", tongTien);
                crystalReport_HoaDon.SetParameterValue("pgiamGia", giamGia);
                crystalReport_HoaDon.SetParameterValue("pconLai", conLai);
                crystalReport_HoaDon.SetParameterValue("pGhiChu", ghiChu);
                crystalReportViewer.ReportSource = crystalReport_HoaDon;
    }
        }
    }
}
