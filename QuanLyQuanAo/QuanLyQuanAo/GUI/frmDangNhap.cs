using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyquanao
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void llblQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // mở frmQuenMatKhau 
            frmQuenMatKhau  frm = new frmQuenMatKhau();

            //Mở dưới dạng dialog ( không cho điều khiển frm khác nếu chưa tắt)
            frm.ShowDialog();
           
        }

        private void lblDangNhap_Click(object sender, EventArgs e)
        {
            rbNhanVien.Checked = false; 
            rbQuanLy.Checked = false;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

        }
    }
}
