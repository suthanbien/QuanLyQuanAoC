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
    public partial class frmHangSanXuat : Form
    {
        #region Khai báo biến
        private String m_HSX;
        private String[] OldHangSanXuat;
        #endregion

        #region Các phương thức
        private void LoadData()
        {
            BUSHangSanXuat.Instance.GetHangSanXuat(dgvHangSanXuat);
            btgNhomLenh.Reccount = dgvHangSanXuat.RowCount;
            // MessageBox.Show(""+ dgvLoaiSanPham.RowCount);

            // btgNhomLenh.ds = dsLoaiSanPham;
        }
        private void DinhViLai(String m_MLSP)
        {

            for (int i = 0; i < btgNhomLenh.Reccount; i++)
                if (dgvHangSanXuat.Rows[i].Cells[0].Value.ToString().Trim() == m_MLSP.Trim())
                {

                    btgNhomLenh.Position = i;
                    dgvHangSanXuat.CurrentCell = dgvHangSanXuat.Rows[i].Cells[0];
                }
        }

        #endregion

        public frmHangSanXuat()
        {
            InitializeComponent();
        }

        private void frmHangSanXuat_Load(object sender, EventArgs e)
        {
            LoadData();
            btgNhomLenh.EnableButton(true);
            btgNhomLenh.AddDataTimKiem(BUSHangSanXuat.Instance.ListTimTheoTen());
            btgNhomLenh.ExtraVisible = true;
            btgNhomLenh.ExtraText = "Làm Mới";
        }

        private void btgNhomLenh_Load(object sender, EventArgs e)
        {
            btgNhomLenh.dgv = dgvHangSanXuat;
        }
        private void frmHangSanXuat_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((frmMain)(this.MdiParent)).moMnuHangSanXuat();
        }
        private void dgvHangSanXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btgNhomLenh.Mode != 0)  //0: bình thường, 1 : thêm,2: sửa
            {
                if (dgvHangSanXuat.CurrentRow.Index != btgNhomLenh.Position)
                    dgvHangSanXuat.CurrentCell = dgvHangSanXuat.Rows[btgNhomLenh.Position].Cells[1];
            }


            if (dgvHangSanXuat.CurrentCell != null)
            {
                btgNhomLenh.Position = dgvHangSanXuat.CurrentCell.RowIndex;
            }
            m_HSX = dgvHangSanXuat.Rows[btgNhomLenh.Position].Cells[0].Value.ToString();
            if (btgNhomLenh.Mode == 0)
                btgNhomLenh.EnableButton(true);
        }
        #region Các Xử Lý



        private void btgNhomLenh_Display(object sender, ButtonGroupEventArgs e)
        {
            if (btgNhomLenh.Reccount > 0)
                dgvHangSanXuat.CurrentCell = dgvHangSanXuat.Rows[btgNhomLenh.Position].Cells[0];
        }

        private void btgNhomLenh_AddClick(object sender, ButtonGroupEventArgs e)
        {
            // MessageBox.Show("c " + btgNhomLenh.Reccount);
            BUSHangSanXuat.Instance.AddRows(dgvHangSanXuat);
            btgNhomLenh.Position = btgNhomLenh.Reccount++;
            //MessageBox.Show("m " + btgNhomLenh.Position);
            dgvHangSanXuat.CurrentCell = dgvHangSanXuat.Rows[btgNhomLenh.Position].Cells[1];

        }

        private void btgNhomLenh_EditClick(object sender, ButtonGroupEventArgs e)
        {
            OldHangSanXuat = new String[2];
            for (int i = 0; i < 2; i++)
                OldHangSanXuat[i] = dgvHangSanXuat.Rows[btgNhomLenh.Position].Cells[i].Value.ToString();
        }

        private void btgNhomLenh_SaveClick(object sender, ButtonGroupEventArgs e)
        {

            if (btgNhomLenh.Mode == 1) //lưu lúc thêm
            {
                string TenHSX;
                int maHSX;
                maHSX = Convert.ToInt32(dgvHangSanXuat.Rows[btgNhomLenh.Position].Cells[0].Value.ToString());
                TenHSX = dgvHangSanXuat.Rows[btgNhomLenh.Position].Cells[1].Value.ToString();
                //MessageBox.Show( tenLSP);
                BUSHangSanXuat.Instance.Them(maHSX, TenHSX);
                LoadData();
                DinhViLai(m_HSX);
            }
            else
            {
                string tenHSX;
                int maHSX;
                maHSX = Convert.ToInt32(dgvHangSanXuat.Rows[btgNhomLenh.Position].Cells[0].Value.ToString());
                tenHSX = dgvHangSanXuat.Rows[btgNhomLenh.Position].Cells[1].Value.ToString();
                BUSHangSanXuat.Instance.Sua(maHSX, tenHSX);
                LoadData();
                DinhViLai(m_HSX);
            }
        }

        private void btgNhomLenh_CancelClick(object sender, ButtonGroupEventArgs e)
        {
            if (btgNhomLenh.Mode == 1) //trang thai 1: huy luc thêm
            {
                BUSHangSanXuat.Instance.XoaRow(dgvHangSanXuat);
                dgvHangSanXuat.CurrentCell = dgvHangSanXuat.Rows[btgNhomLenh.Position].Cells[0];
            }
            else   //trạng thái khác 1: hủy lúc sửa
            {
                for (int i = 0; i < 2; i++)
                    dgvHangSanXuat.Rows[btgNhomLenh.Position].Cells[i].Value = OldHangSanXuat[i];
            }
        }

        private void btgNhomLenh_DeleteClick(object sender, ButtonGroupEventArgs e)
        {
            m_HSX = dgvHangSanXuat.Rows[btgNhomLenh.Position].Cells[0].Value.ToString().Trim();
            if (MessageBox.Show(
            "Có chắc chắn hủy bỏ hãng sản xuất với mã số  " + m_HSX + " không?",
            "Nhà xuất bản", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (BUSHangSanXuat.Instance.Xoa(Convert.ToInt32(m_HSX)) == true)
                {
                    LoadData();
                }
                else
                {
                    MessageBox.Show("không thể xóa ràng buộc dữ liệu");
                }

            }
        }

        private void btgNhomLenh_TimKiemClick(object sender, ButtonGroupEventArgs e)
        {
            if (btgNhomLenh.ModeTimKiem == 1)
            {
                //MessageBox.Show("tim kiem theo tên" + btgNhomLenh.TenTimKiem);
                string tenHSX = btgNhomLenh.TenTimKiem;
                btgNhomLenh.ModeADD = BUSHangSanXuat.Instance.TimTheoTen(tenHSX, dgvHangSanXuat);


                btgNhomLenh.Reccount = dgvHangSanXuat.RowCount;
                btgNhomLenh.Position = 0;

            }
            else
            {
                string maHSX = btgNhomLenh.MaTimKiem;
                btgNhomLenh.ModeADD = BUSHangSanXuat.Instance.TimTheoMa(maHSX, dgvHangSanXuat);


                btgNhomLenh.Reccount = dgvHangSanXuat.RowCount;
                btgNhomLenh.Position = 0;
            }

        }


        private void btgNhomLenh_ExtraClick(object sender, ButtonGroupEventArgs e)
        {
            LoadData();
        }
        private void btgNhomLenh_RadTimClick(object sender, ButtonGroupEventArgs e)
        {
            if (btgNhomLenh.ModeTimKiem == 1)
            {
                btgNhomLenh.ListTimKiem = BUSHangSanXuat.Instance.ListTimTheoTen();

            }
            else
            {
                btgNhomLenh.ListTimKiem = BUSHangSanXuat.Instance.ListTimTheoMa();

            }
        }


        #endregion


    }
}
