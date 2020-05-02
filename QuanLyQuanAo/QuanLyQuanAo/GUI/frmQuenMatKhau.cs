using QuanLyQuanAo.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyquanao
{
    public partial class frmQuenMatKhau : Form
    {


        #region các khai báo
        #endregion


        #region các phương thức
        public frmQuenMatKhau()
        {
            InitializeComponent();
        }

        private void GuiMail(string from_,string to_,string subject_,string messager_)
        {
            MailMessage mess_ = new MailMessage(from_,to_,messager_,subject_);
            SmtpClient client = new SmtpClient("smtp.gmail.com",587);
            client.EnableSsl = true;

            client.Credentials = new NetworkCredential("suthanbien2@gmail.com","01678174651");

            client.Send(mess_);

        }
        #endregion


        #region các xử lý

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string nEmail;
            nEmail = txtEmail.Text;
            string nguoiNhan="";
            nguoiNhan = txtEmail.Text;
            string traVePass="Mật khẩu cho tài khoản baby milo của bạn là: ";
            traVePass+= BUSQuenMatKhau.Instance.LayLaiMatKhau(nEmail);
            GuiMail("suthanbien2@gmail.com",nguoiNhan, traVePass,"Xác Nhận Lấy Lại Mật Khẩu");
            MessageBox.Show("Mật khẩu đã được gửi đến Email, vui lòng kiểm tra lại. \n"
                               +"nếu không nhận được gamil vui lòng ấn thử lại.");
            btnXacNhanQuenMatKhau.Text = "Thử Lại";
        }

        private void frmQuenMatKhau_Load(object sender, EventArgs e)
        {
            btnXacNhanQuenMatKhau.Enabled = false;
            btnXacNhanQuenMatKhau.Text = "Xác Nhận";
            lblAdMin.Text = "";
            lblLoiMail.Visible = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            btnXacNhanQuenMatKhau.Enabled = false;
            btnXacNhanQuenMatKhau.Text = "Xác Nhận";
            lblAdMin.Text = "";
            lblLoiMail.Visible = false;
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            string nEmail;
            nEmail = txtEmail.Text;
            // MessageBox.Show(nEmail);
            if (BUSQuenMatKhau.Instance.KiemTraEmail(nEmail).Length==0)
            {
                lblLoiMail.Visible = true;
            }
            else
            {
                lblAdMin.Text = BUSQuenMatKhau.Instance.KiemTraEmail(nEmail);
                btnXacNhanQuenMatKhau.Enabled = true;
            }
            
        }



        #endregion

        private void lblThongBao_Click(object sender, EventArgs e)
        {

        }
    }
}
