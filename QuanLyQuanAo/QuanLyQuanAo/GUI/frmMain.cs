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

    public partial class frmMain : Form
    {
        #region Khai báo biến

        public static string quyen ="";
        public static string taiKhoan = "";

        public static string mSThamChieu = "";

        #endregion

        #region các phương thức
        public frmMain()
        {
            InitializeComponent();
        }
        #endregion

        #region các xử lý
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion


    }
}
