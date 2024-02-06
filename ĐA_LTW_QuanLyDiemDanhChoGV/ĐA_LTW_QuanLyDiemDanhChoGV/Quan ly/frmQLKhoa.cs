using BUS;
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
    public partial class frmQLKhoa : DevExpress.XtraEditors.XtraForm
    {
       KhoaBUS _KhoaBUS = new KhoaBUS();
        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();
        public frmQLKhoa()
        {
            InitializeComponent();
            LoadDSKhoa();
            Res();
            radTatCa.Checked = true;
        }

        public void LoadDSKhoa()
        {
            dgvKhoa.DataSource = _KhoaBUS.DSKhoa();
        }
        private void LoadCBO_Khoa()
        {
            cboMaKhoa.DataSource = DB.KHOAs.Where(u => u.TRANGTHAI == false).ToList();
            cboMaKhoa.ValueMember = "MAKHOA";
            cboMaKhoa.DisplayMember = "MAKHOA";

            cboTenKhoa.DataSource = DB.KHOAs.Where(u => u.TRANGTHAI == false).ToList();
            cboTenKhoa.ValueMember = "TENKHOA";
            cboTenKhoa.DisplayMember = "TENKHOA";
        }
        
        public void Res()
        {
            txtGhiChu.Text = string.Empty;
            LoadCBO_Khoa();
            cboMaKhoa.SelectedIndex = 0;
            cboTenKhoa.SelectedIndex = 0;

        }

        private void cboMaKhoa_TextChanged(object sender, EventArgs e)
        {
            if (radMaKhoa.Checked)
            {
                dgvKhoa.DataSource = _KhoaBUS.DSKHOA_MaKhoa(cboMaKhoa.Text.Trim());
            }
        }

        private void radTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (radTatCa.Checked)
            {
                dgvKhoa.DataSource = _KhoaBUS.DSKhoa();
            }
        }

        private void radTenKhoa_CheckedChanged(object sender, EventArgs e)
        {
            if (radTenKhoa.Checked)
            {
                dgvKhoa.DataSource = _KhoaBUS.DSKHOA_TenKhoa(cboTenKhoa.Text.Trim());
            }
        }


        private void radGhiChu_CheckedChanged(object sender, EventArgs e)
        {
            if (radGhiChu.Checked)
            {
                dgvKhoa.DataSource = _KhoaBUS.DSKHOA_GhiChu(txtGhiChu.Text.Trim());
            }
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {
            if (radGhiChu.Checked)
            {
                dgvKhoa.DataSource = _KhoaBUS.DSKHOA_GhiChu(txtGhiChu.Text.Trim());
            }
        }

        
        private void btnThem_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(cboMaKhoa.Text.Trim()) && !string.IsNullOrEmpty(cboTenKhoa.Text.Trim()))
            {
                if (!string.IsNullOrEmpty(cboMaKhoa.Text.Trim()))
                {
                    KhoaDTO khoa = new KhoaDTO();
                    {
                        khoa.MAKHOA = cboMaKhoa.Text;
                        khoa.TENKHOA = cboTenKhoa.Text;
                        khoa.GHICHU = txtGhiChu.Text;
                    }
                    if (_KhoaBUS.KTKhoa(khoa) == false)
                    {
                        if (_KhoaBUS.KTKhoaDaXoa(cboMaKhoa.Text.Trim()) == false)
                        {
                            if (_KhoaBUS.ThemKhoa(khoa) == true)
                            {
                                MessageBox.Show(Constant.ThemTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Res();
                                LoadDSKhoa();
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
                            if (_KhoaBUS.ThemKhoaDaXoa(khoa) == true)
                            {
                                MessageBox.Show(Constant.ThemTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Res();
                                LoadDSKhoa();
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
                        MessageBox.Show("Khoa đã tồn tại khoa", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            KhoaDTO khoa = new KhoaDTO()
            {
                MAKHOA = cboMaKhoa.Text,
                TENKHOA = cboTenKhoa.Text,
                GHICHU = txtGhiChu.Text,

            };
            if (!string.IsNullOrEmpty(cboMaKhoa.Text.Trim()) && !string.IsNullOrEmpty(cboTenKhoa.Text.Trim()))
            {
                if (_KhoaBUS.KTKhoa(khoa) == true)
                {

                    if (_KhoaBUS.SuaKhoa(khoa) == true)
                    {
                        MessageBox.Show(Constant.SuaTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Res();
                        LoadDSKhoa();
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
                    MessageBox.Show("Khoa không tồn tại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if(!string.IsNullOrEmpty(cboMaKhoa.Text.Trim()))
                {
                    KhoaDTO khoa = new KhoaDTO();
                    {
                        khoa.MAKHOA = cboMaKhoa.Text;
                    }
                    if (_KhoaBUS.KTKhoa(khoa) == true)
                    {
                        if (_KhoaBUS.XoaKhoa(khoa) == true)
                        {

                            MessageBox.Show(Constant.XoaTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Res();
                            LoadDSKhoa();

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
                        MessageBox.Show("Khoa không tồn tại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã khoa", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Res();
            LoadDSKhoa() ;
            radMaKhoa.Checked = false;
            radTenKhoa.Checked = false;
            radGhiChu.Checked = false;
            radTatCa.Checked = false;
        }

        private void dgvKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            else if (dgvKhoa.SelectedRows.Count == 0)
            {
                dgvKhoa.ClearSelection();
                Res();
            }
            else
            {
                cboMaKhoa.Text = dgvKhoa.Rows[e.RowIndex].Cells[Constant.KHOA_MaKhoa].Value.ToString();
                cboTenKhoa.Text = dgvKhoa.Rows[e.RowIndex].Cells[Constant.KHOA_TenKhoa].Value.ToString();
                txtGhiChu.Text = dgvKhoa.Rows[e.RowIndex].Cells[Constant.KHOA_GhiChu].Value.ToString();
            }
        }

        private void cboTenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radTenKhoa.Checked)
            {
                dgvKhoa.DataSource = _KhoaBUS.DSKHOA_TenKhoa(cboTenKhoa.Text.Trim());
            }
        }

        private void cboMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radMaKhoa.Checked)
            {
                dgvKhoa.DataSource = _KhoaBUS.DSKHOA_MaKhoa(cboMaKhoa.Text.Trim());
            }
        }

    }
}