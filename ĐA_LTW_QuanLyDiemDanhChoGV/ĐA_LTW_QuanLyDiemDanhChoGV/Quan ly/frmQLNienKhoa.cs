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
    public partial class frmQLNienKhoa : DevExpress.XtraEditors.XtraForm
    {
        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();
        NienKhoaBUS _nienKhoaBUS = new NienKhoaBUS();
        public frmQLNienKhoa()
        {
            InitializeComponent();
            LoadDSNienKhoa();
            LoadCBONienKhoa();
            radTatCa.Checked = true;
        }
        public void LoadDSNienKhoa()
        {
            dgvNienKhoa.DataSource = _nienKhoaBUS.DSNienKhoa();
        }
        public void LoadCN()
        {
            LoadCBONienKhoa();
            LoadDSNienKhoa();
            Res();
        }
        public void LoadCBONienKhoa()
        {
            cboMaNienKhoa.DataSource=DB.NIENKHOAs.Where(u => u.TRANGTHAI == false).ToList();
            cboMaNienKhoa.DisplayMember = "MANIENKHOA";
            cboMaNienKhoa.ValueMember = "MANIENKHOA";

            cboTenNienKhoa.DataSource = DB.NIENKHOAs.Where(u => u.TRANGTHAI == false).ToList();
            cboTenNienKhoa.DisplayMember = "TENNIENKHOA";
            cboTenNienKhoa.ValueMember = "TENNIENKHOA";
        }

        public void Res()
        {
            cboMaNienKhoa.SelectedIndex = 0;
            cboTenNienKhoa.SelectedIndex=0;
            txtGhiChu.Text = string.Empty;

            radMaNienKhoa.Checked = false;
            radTenNienKhoa.Checked=false;
            radGhiChu.Checked = false;
            radTatCa.Checked = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cboMaNienKhoa.Text.Trim()) && !string.IsNullOrEmpty(cboTenNienKhoa.Text.Trim()))
            {
                NienKhoaDTO nk = new NienKhoaDTO();
                {
                    nk.MANIENKHOA = cboMaNienKhoa.Text;
                    nk.TENNIENKHOA = cboTenNienKhoa.Text;
                    nk.GHICHU = txtGhiChu.Text;
                }
                if (_nienKhoaBUS.KTNienKhoa(cboMaNienKhoa.Text.Trim()) == false)
                {
                    if (_nienKhoaBUS.KTNienKhoaDaXoa(cboMaNienKhoa.Text.Trim()) == false)
                    {
                        if (_nienKhoaBUS.ThemNienKhoa(nk) == true)
                        {
                            MessageBox.Show(Constant.ThemTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadCN();
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
                        if (_nienKhoaBUS.ThemNienKhoaDaXoa(nk) == true)
                        {
                            MessageBox.Show(Constant.ThemTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadCN();
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
                    MessageBox.Show("Đã tồn tại niên khóa", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show(Constant.nhapChuaDuThongTin, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dgvNienKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            else if (dgvNienKhoa.SelectedRows.Count == 0)
            {
                dgvNienKhoa.ClearSelection();
                LoadCBONienKhoa();
                LoadDSNienKhoa();
            }
            else
            {
                cboMaNienKhoa.Text = dgvNienKhoa.Rows[e.RowIndex].Cells[Constant.NIENKHOA_MaNienKhoa].Value.ToString();
                cboTenNienKhoa.Text = dgvNienKhoa.Rows[e.RowIndex].Cells[Constant.NIENKHOA_TenNienKhoa].Value.ToString();
                txtGhiChu.Text = dgvNienKhoa.Rows[e.RowIndex].Cells[Constant.NIENKHOA_GhiChu].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrEmpty(cboMaNienKhoa.Text.Trim()) && !string.IsNullOrEmpty(cboTenNienKhoa.Text.Trim()))
            {
                if (_nienKhoaBUS.KTNienKhoa(cboMaNienKhoa.Text.Trim()) == true)
                {
                    NienKhoaDTO nk = new NienKhoaDTO()
                    {
                        MANIENKHOA = cboMaNienKhoa.Text.Trim(),
                        TENNIENKHOA = cboTenNienKhoa.Text.Trim(),
                        GHICHU = txtGhiChu.Text.Trim()
                    };

                    if (_nienKhoaBUS.SuaNienKhoa(nk) == true)
                    {
                        MessageBox.Show(Constant.SuaTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCN();
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
                    MessageBox.Show("Niên Khóa không tồn tại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show(Constant.nhapChuaDuThongTin, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(Constant.HoiXoa, Constant.ThongBao, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(cboMaNienKhoa.Text.Trim()))
                {
                    NienKhoaDTO nk = new NienKhoaDTO();
                    {
                        nk.MANIENKHOA = cboMaNienKhoa.Text;
                    }
                    if (_nienKhoaBUS.KTNienKhoa(cboMaNienKhoa.Text.Trim()) == true)
                    {
                        if (_nienKhoaBUS.XoaNienKhoa(nk) == true)
                        {

                            MessageBox.Show(Constant.XoaTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadCN();
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
                        MessageBox.Show("Niên khóa không tồn tại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã niên khóa", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show(Constant.HuyXoa, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }


        

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadCN(); 
        }

        private void radMaNienKhoa_CheckedChanged(object sender, EventArgs e)
        {
            if(radMaNienKhoa.Checked)
            {
                dgvNienKhoa.DataSource = _nienKhoaBUS.DSNienKhoa_MaNienKhoa(cboMaNienKhoa.Text);
            }
        }

        private void cboMaNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radMaNienKhoa.Checked)
            {
                dgvNienKhoa.DataSource = _nienKhoaBUS.DSNienKhoa_MaNienKhoa(cboMaNienKhoa.Text);
            }
        }

        private void radTenNienKhoa_CheckedChanged(object sender, EventArgs e)
        {
            if (radTenNienKhoa.Checked)
            {
                dgvNienKhoa.DataSource = _nienKhoaBUS.DSNienKhoa_TenNienKhoa(cboTenNienKhoa.Text);
            }
        }

        private void cboTenNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radTenNienKhoa.Checked)
            {
                dgvNienKhoa.DataSource = _nienKhoaBUS.DSNienKhoa_TenNienKhoa(cboTenNienKhoa.Text);
            }
        }

        private void radGhiChu_CheckedChanged(object sender, EventArgs e)
        {
            if (radGhiChu.Checked)
            {
                dgvNienKhoa.DataSource = _nienKhoaBUS.DSNienKhoa_GhiChu(txtGhiChu.Text);
            }
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {
            if (radGhiChu.Checked)
            {
                dgvNienKhoa.DataSource = _nienKhoaBUS.DSNienKhoa_GhiChu(txtGhiChu.Text);
            }
        }

        private void radTatCa_CheckedChanged(object sender, EventArgs e)
        {
            LoadDSNienKhoa();
        }

        private void grpChucNang_Enter(object sender, EventArgs e)
        {

        }
    }
}