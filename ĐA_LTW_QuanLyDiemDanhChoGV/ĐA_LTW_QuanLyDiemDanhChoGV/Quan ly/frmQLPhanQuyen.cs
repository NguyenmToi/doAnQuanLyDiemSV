using BUS;
using DAO;
using DevExpress.XtraEditors;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐA_LTW_QuanLyDiemDanhChoGV.Quan_ly
{
    public partial class frmQLPhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        QLCapQuyenBUS _phanQuyenTaiKhoanBUS = new QLCapQuyenBUS();
        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();
        QLTKGVBUS _taiKhoanGVBUS = new QLTKGVBUS();
        public frmQLPhanQuyen()
        {
            InitializeComponent();
            LoadDSTK();
            Rs();
        }

        public void LoadDSTK()
        {

            dgvPhanQuyen.DataSource = _phanQuyenTaiKhoanBUS.DSQLTaiKhoan();
        }
        private void UserPhanQuyen_Load(object sender, EventArgs e)
        {
            LoadDSTK();
        }

        public void Rs()
        {
            txtTaiKhoan.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
            radAdmin.Checked = true;
            cboTimKiem.SelectedIndex = 0;
        }

        private void dgvPhanQuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                txtTaiKhoan.Text = dgvPhanQuyen.Rows[e.RowIndex].Cells[Constant.TKPQ_TaiKhoan].Value.ToString();
                txtGhiChu.Text = dgvPhanQuyen.Rows[e.RowIndex].Cells[Constant.TKPQ_GhiChu].Value.ToString();
                int ltk = int.Parse(dgvPhanQuyen.Rows[e.RowIndex].Cells[Constant.TKPQ_LoaiTaiKhoan].Value.ToString());
                if (ltk == 1 ? radGiangVien.Checked = true : radAdmin.Checked = true) ;
                lblLTK.Text = dgvPhanQuyen.Rows[e.RowIndex].Cells[Constant.TKPQ_LoaiTaiKhoan].Value.ToString();
            }

        }
        private void btnCapQuyen_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTaiKhoan.Text.Trim()))
            {


                TaiKhoanGVDTO tk = new TaiKhoanGVDTO();
                {
                    tk.TAIKHOAN = txtTaiKhoan.Text.Trim();
                    tk.GHICHU = txtGhiChu.Text.Trim();
                    tk.LOAITAIKHOAN = radGiangVien.Checked ? 1 : 0;
                    tk.TRANGTHAI = false;

                }
                if (_phanQuyenTaiKhoanBUS.KT(txtTaiKhoan.Text.Trim()) == true)
                {

                    if (_phanQuyenTaiKhoanBUS.CapQuyenTK(tk) == true)
                    {
                        MessageBox.Show("Cấp quyền thành công", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDSTK();
                        Rs();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Cấp quyền thất bại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTaiKhoan.Focus();
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTaiKhoan.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tài khoản", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaiKhoan.Focus();
                return;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Rs();
            LoadDSTK();
        }

        private void btnTimKiemTK_Click(object sender, EventArgs e)
        {
            if (cboTimKiem.SelectedIndex == 0)
            {
                dgvPhanQuyen.DataSource = _taiKhoanGVBUS.DSTaiKhoanGV_TaiKhoan(txtTaiKhoan.Text.Trim());
            }
            else if(cboTimKiem.SelectedIndex==1)
            {
                dgvPhanQuyen.DataSource = _taiKhoanGVBUS.DSDSTaiKhoanGV_GhiChu(txtGhiChu.Text.Trim());
            }
            else
            {
                int a;
                if (radAdmin.Checked) a = 0; else a = 1;
                dgvPhanQuyen.DataSource = _taiKhoanGVBUS.DSDSTaiKhoanGV_LTK(a);
            }
        }


        private void btnTimKiemTKGV_Click(object sender, EventArgs e)
        {
            if (cboTimKiem.SelectedIndex == 0)
            {
                dgvPhanQuyen.DataSource = _phanQuyenTaiKhoanBUS.DSTaiKhoanSV_TaiKhoan(txtTaiKhoan.Text.Trim());
                return;
            }
            else if (cboTimKiem.SelectedIndex == 1)
            {
                dgvPhanQuyen.DataSource = _phanQuyenTaiKhoanBUS.DSTaiKhoanSV_GhiChu(txtGhiChu.Text.Trim());
                return;
            }
            else
            {
                dgvPhanQuyen.DataSource = _phanQuyenTaiKhoanBUS.DSTaiKhoanSV_LoaiTaiKhoan(int.Parse(lblLTK.Text.Trim()));
                return;
            }
        }

        private void cboTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            string a = txtTaiKhoan.Text;

            if (!string.IsNullOrEmpty(a))
            {
                string loc = new string(a.Where(c => char.IsLetterOrDigit(c)).ToArray());

                if (loc != a)
                {
                    txtTaiKhoan.Text = loc;
                    txtTaiKhoan.Select(loc.Length, 0);
                }
            }
        }
    }
}