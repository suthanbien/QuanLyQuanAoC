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
    public partial class frmQuenMatKhau : Form
    {


        #region các khai báo
        #endregion


        #region các phương thức
        public frmQuenMatKhau()
        {
            InitializeComponent();
        }
        #endregion


        #region các xử lý

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

        }

        private void frmQuenMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            btnXacNhan.Enabled = false;
        }

        #endregion



    }
}
