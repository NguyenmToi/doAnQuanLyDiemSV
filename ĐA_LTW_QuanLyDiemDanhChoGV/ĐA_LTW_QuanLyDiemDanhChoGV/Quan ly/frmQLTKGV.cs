using BUS;
using DAO;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Drawing;
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
    public partial class frmQLTKGV : DevExpress.XtraEditors.XtraForm
    {
        QLTKGVBUS _taiKhoanGVBUS = new QLTKGVBUS();
        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();

        public frmQLTKGV()
        {
            InitializeComponent();
            DSTaiKhoan();
            LOADCN();

        }



        public void DSTaiKhoan()
        {
            dgvTaiKhoanSV.DataSource = _taiKhoanGVBUS.DSTaiKhoanGV();

        }

        public void LOADCN()
        {
            DSTaiKhoan();
            Rs();
        }

        public void Rs()
        {
            txtTaiKhoan.Text = string.Empty;
            txtMatKhau.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
            cboTimKiem.SelectedIndex = 0;
        }

        private void dgvTaiKhoanGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtTaiKhoan.Text = dgvTaiKhoanSV.Rows[e.RowIndex].Cells[Constant.TKGV_TaiKhoan].Value.ToString();
                txtMatKhau.Text = dgvTaiKhoanSV.Rows[e.RowIndex].Cells[Constant.TKGV_MatKhau].Value.ToString();
                txtGhiChu.Text = dgvTaiKhoanSV.Rows[e.RowIndex].Cells[Constant.GhiChu].Value.ToString();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtTaiKhoan.Text.Trim()))
            {
                if (!string.IsNullOrEmpty(txtMatKhau.Text.Trim()))
                {
                    if (txtMatKhau.Text.Trim().Length > 5)
                    {

                        TaiKhoanGVDTO tk = new TaiKhoanGVDTO();
                        {
                            tk.TAIKHOAN = txtTaiKhoan.Text.Trim();
                            tk.MATKHAU = txtMatKhau.Text.Trim();
                            tk.GHICHU = txtGhiChu.Text.Trim();
                            tk.TRANGTHAI = false;

                        }
                        if (_taiKhoanGVBUS.KT(txtTaiKhoan.Text.Trim()) == false)
                        {
                            if (_taiKhoanGVBUS.KTMaGV(txtTaiKhoan.Text.Trim()) == true)
                            {
                                if (_taiKhoanGVBUS.ThemTaiKhoan(tk) == true)
                                {
                                    MessageBox.Show(Constant.ThemTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LOADCN();
                                    return;
                                }
                                else
                                {
                                    MessageBox.Show(Constant.ThemTB, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtTaiKhoan.Focus();
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Tài khoản không tồn tại trong danh sách được tạo", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtTaiKhoan.Focus();
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản đã tồn tại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtTaiKhoan.Focus();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu phải có tối thiểu 6 ký tự", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMatKhau.Text = txtMatKhau.Text.Trim();
                        txtMatKhau.Focus();
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhau.Focus();
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

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnKhoiPhucTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }



        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LOADCN();
        }

    }
}