using quanlyquanao.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyquanao
{
    class BUSDangNhap
    {
        private static BUSDangNhap instance;

        public static BUSDangNhap Instance {
            get
            {
                if (instance==null)
                {
                    instance = new BUSDangNhap();
                }
                return instance;
            }
        }

        private BUSDangNhap()
        {
            
        }

        public void KiemTraDangNhap(string taiKhoan,string matKhau,string tuCach, DataGridView dataGridView1)
        {
            dataGridView1.DataSource = DAODangNhap.Instance.KiemTra();
            
        }
    }
}
