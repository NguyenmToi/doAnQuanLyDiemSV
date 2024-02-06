using BUS;
using ĐA_LTW_QuanLyDiemDanhChoGV;
using DAO;
using DevExpress.Utils.Win.Hook;
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
    public partial class frmQLLoaiTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();
        LoaiTaiKhoanBUS _loaiTaiKhoanBUS = new LoaiTaiKhoanBUS();
        public frmQLLoaiTaiKhoan()
        {
            InitializeComponent();
            DSLoaiTaiKhoan();
            radTatCa.Checked = true;
            LOADCBOMaLoaiTaiKhoan();
        }

        public void DSLoaiTaiKhoan()
        {
            dgvLoaiTaiKhoan.DataSource = _loaiTaiKhoanBUS.DSLoaiTaiKhoan();
;       }

        public void LOADCN()
        {
            DSLoaiTaiKhoan();
            LOADCBOMaLoaiTaiKhoan();
            Rs();
        }

        public void LOADCBOMaLoaiTaiKhoan()
        {
            cboMaLoaiTaiKhoan.DataSource = DB.LOAITAIKHOANs.Where(u => u.TRANGTHAI == false).ToList();
            cboMaLoaiTaiKhoan.DisplayMember = "MALOAITAIKHOAN";
            cboMaLoaiTaiKhoan.ValueMember = "MALOAITAIKHOAN";

            cboTenLoaiTaiKhoan.DataSource = DB.LOAITAIKHOANs.Where(u => u.TRANGTHAI == false).ToList();
            cboTenLoaiTaiKhoan.DisplayMember = "TENLOAITAIKHOAN";
            cboTenLoaiTaiKhoan.ValueMember = "TENLOAITAIKHOAN";

        }
        public void Rs()
        {
            cboMaLoaiTaiKhoan.SelectedIndex = 0;
            cboTenLoaiTaiKhoan.SelectedIndex=0;
            txtGhiChu.Text = string.Empty;
        }

private void btnThem_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(cboMaLoaiTaiKhoan.Text.Trim()) && !string.IsNullOrEmpty(cboTenLoaiTaiKhoan.Text.Trim()))
            {
                LoaiTaiKhoanDTO ltk = new LoaiTaiKhoanDTO();
                {
                    ltk.MALOAITAIKHOAN = int.Parse(cboMaLoaiTaiKhoan.Text.Trim());
                    ltk.TENLOAITAIKHOAN = cboTenLoaiTaiKhoan.Text.Trim();
                    ltk.GHICHU = txtGhiChu.Text.Trim();
                }
                if (_loaiTaiKhoanBUS.KT(int.Parse(cboMaLoaiTaiKhoan.Text.Trim())) == false)
                {
                    if (_loaiTaiKhoanBUS.KTLTKDaXoa(int.Parse(cboMaLoaiTaiKhoan.Text.Trim())) == false)
                    {
                        if (_loaiTaiKhoanBUS.ThemLoaiTaiKhoan(ltk) == true)
                        {
                            MessageBox.Show(Constant.ThemTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LOADCN();
                            return;
                        }
                        else
                        {
                            MessageBox.Show(Constant.ThemTB, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        if (_loaiTaiKhoanBUS.ThemLTKDaXoa(ltk) == true)
                        {
                            MessageBox.Show(Constant.ThemTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LOADCN();
                            return;
                        }
                        else
                        {
                            MessageBox.Show(Constant.ThemTB, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Đã tồn tại loại tài khoản", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnSua_Click(object sender, EventArgs e)

        {

            if (!string.IsNullOrEmpty(cboMaLoaiTaiKhoan.Text.Trim()) && !string.IsNullOrEmpty(cboTenLoaiTaiKhoan.Text.Trim()))
            {
                LoaiTaiKhoanDTO ltk = new LoaiTaiKhoanDTO()
                {
                    MALOAITAIKHOAN = int.Parse(cboMaLoaiTaiKhoan.Text.Trim()),
                    TENLOAITAIKHOAN = cboTenLoaiTaiKhoan.Text.Trim(),
                    GHICHU = txtGhiChu.Text.Trim(),

                };
                if (_loaiTaiKhoanBUS.KT(int.Parse(cboMaLoaiTaiKhoan.Text.Trim())) == true)
                {

                    if (_loaiTaiKhoanBUS.SuaLoaiTaiKhoan(ltk) == true)
                    {
                        MessageBox.Show(Constant.SuaTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LOADCN();
                        return;
                    }
                    else
                    {
                        MessageBox.Show(Constant.SuaTB, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Loại tài khoản không tồn tại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(Constant.HoiXoa, Constant.ThongBao, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if(!string.IsNullOrEmpty(cboMaLoaiTaiKhoan.Text.Trim()))
                {
                    LoaiTaiKhoanDTO ltk = new LoaiTaiKhoanDTO();
                    {
                        ltk.MALOAITAIKHOAN = int.Parse(cboMaLoaiTaiKhoan.Text.Trim());
                    }
                    int a = int.Parse(cboMaLoaiTaiKhoan.Text.Trim());
                    if (_loaiTaiKhoanBUS.KT(a) == true)
                    {
                        if (_loaiTaiKhoanBUS.XoaLoaiTaiKhoan(ltk) == true)
                        {

                            MessageBox.Show(Constant.XoaTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LOADCN();

                            return;
                        }
                        else
                        {
                            MessageBox.Show(Constant.XoaTB, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Loại tài khoản không tồn tại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã loại tài khoản", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show(Constant.HuyXoa, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void cboMaLoaiTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            if (radMaLoaiTaiKhoan.Checked && !string.IsNullOrEmpty(cboMaLoaiTaiKhoan.Text))
            {
                dgvLoaiTaiKhoan.DataSource = _loaiTaiKhoanBUS.DSLoaiTaiKhoan_MaLoaiTaiKhoan(Int32.Parse(cboMaLoaiTaiKhoan.Text.Trim()));
            }
            else
            {
                DSLoaiTaiKhoan();
                return;
            }
        }

        private void cboMaLoaiTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvLoaiTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cboMaLoaiTaiKhoan.Text = dgvLoaiTaiKhoan.Rows[e.RowIndex].Cells[Constant.LTK_MaLoaiTaiKhoan].Value.ToString();
                cboTenLoaiTaiKhoan.Text = dgvLoaiTaiKhoan.Rows[e.RowIndex].Cells[Constant.LTK_TenLoaiTaiKhoan].Value.ToString();
                txtGhiChu.Text = dgvLoaiTaiKhoan.Rows[e.RowIndex].Cells[Constant.LTK_GhiChu].Value.ToString();
            }
        }

        private void radMaLoaiTaiKhoan_CheckedChanged(object sender, EventArgs e)
        {
            if(radMaLoaiTaiKhoan.Checked)
            {
                dgvLoaiTaiKhoan.DataSource = _loaiTaiKhoanBUS.DSLoaiTaiKhoan_MaLoaiTaiKhoan(int.Parse(cboMaLoaiTaiKhoan.Text.Trim()));
            }    
        }

        private void cboMaLoaiTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radMaLoaiTaiKhoan.Checked)
            {
                dgvLoaiTaiKhoan.DataSource = _loaiTaiKhoanBUS.DSLoaiTaiKhoan_MaLoaiTaiKhoan(int.Parse(cboMaLoaiTaiKhoan.Text.Trim()));
            }
        }

        private void radTenLoaiTaiKhoan_CheckedChanged(object sender, EventArgs e)
        {
            if (radTenLoaiTaiKhoan.Checked)
            {
                dgvLoaiTaiKhoan.DataSource = _loaiTaiKhoanBUS.DSLoaiTaiKhoan_TenLoaiTaiKhoan(cboTenLoaiTaiKhoan.Text.Trim());
            }
        }

        private void cboTenLoaiTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radTenLoaiTaiKhoan.Checked)
            {
                dgvLoaiTaiKhoan.DataSource = _loaiTaiKhoanBUS.DSLoaiTaiKhoan_TenLoaiTaiKhoan(cboTenLoaiTaiKhoan.Text.Trim());
            }
        }

        private void radGhiChu_CheckedChanged(object sender, EventArgs e)
        {
            if (radGhiChu.Checked)
            {
                dgvLoaiTaiKhoan.DataSource = _loaiTaiKhoanBUS.DSLoaiTaiKhoan_GhiChu(txtGhiChu.Text.Trim());
            }
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {
            if (radGhiChu.Checked)
            {
                dgvLoaiTaiKhoan.DataSource = _loaiTaiKhoanBUS.DSLoaiTaiKhoan_GhiChu(txtGhiChu.Text.Trim());
            }
        }

        private void radTatCa_CheckedChanged(object sender, EventArgs e)
        {
            LOADCBOMaLoaiTaiKhoan();
            DSLoaiTaiKhoan();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LOADCN();
        }
    }
}