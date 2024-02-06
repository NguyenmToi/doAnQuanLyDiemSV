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
    public partial class frmQLNganh : DevExpress.XtraEditors.XtraForm
    {
        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();
        NganhBUS _nganhBUS = new NganhBUS();
        public frmQLNganh()
        {
            InitializeComponent();
            LoadDSNganh();
            LoadCBONganh();
            Res();
            radTatCa.Checked = true;
        }

        public void LoadDSNganh()
        {
            dgvNganh.DataSource = _nganhBUS.DSNganh();
        }
        public void LoadCN()
        {
            LoadCBONganh();
            LoadDSNganh();
            Res();
        }
        public void LoadCBONganh()
        {
            cboMaNganh.DataSource = DB.NGANHs.Where(u => u.TRANGTHAI == false).ToList();
            cboMaNganh.DisplayMember = "MANGANH";
            cboMaNganh.ValueMember = "MANGANH";

            cboTenNganh.DataSource = DB.NGANHs.Where(u => u.TRANGTHAI == false).ToList();
            cboTenNganh.DisplayMember = "TENNGANH";
            cboTenNganh.ValueMember = "TENNGANH";

            cboTenKhoa.DataSource = DB.KHOAs.Where(u=>u.TRANGTHAI ==false).ToList();
            cboTenKhoa.DisplayMember = "TENKHOA";
            cboTenKhoa.ValueMember = "MAKHOA";
        }

        public void Res()
        {
            cboMaNganh.SelectedIndex = 0;
            cboTenNganh.SelectedIndex = 0;
            cboTenKhoa.SelectedIndex = 0;
            txtGhiChu.Text = string.Empty;

            radMaNganh.Checked = false;
            radTenNganh.Checked = false;
            radGhiChu.Checked = false;
            radTatCa.Checked = false;
            radTenKhoa.Checked = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cboMaNganh.Text.Trim()) && !string.IsNullOrEmpty(cboTenKhoa.Text.Trim()) && !string.IsNullOrEmpty(cboTenNganh.Text.Trim()))
            {
                if (cboTenKhoa.SelectedValue != null)
                {
                    NganhDTO n = new NganhDTO();
                    {
                        n.MANGANH = cboMaNganh.Text.Trim();
                        n.TENNGANH = cboTenNganh.Text.Trim();
                        n.MAKHOA = cboTenKhoa.SelectedValue.ToString();
                        n.GHICHU = txtGhiChu.Text.Trim();
                    }
                    if (_nganhBUS.KTNganh(n) == false)
                    {
                        if (_nganhBUS.KTNganhDaXoa(cboMaNganh.Text.Trim()) == false)
                        {
                            if (_nganhBUS.ThemNganh(n) == true)
                            {
                                MessageBox.Show(Constant.ThemTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Res();
                                LoadDSNganh();
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
                            if (_nganhBUS.ThemNganhDaXoa(n) == true)
                            {
                                MessageBox.Show(Constant.ThemTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Res();
                                LoadDSNganh();
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
                        MessageBox.Show("Ngành đã tồn tại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show(Constant.nhapChuaDuThongTin, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show(Constant.nhapChuaDuThongTin, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cboMaNganh.Text.Trim()) && !string.IsNullOrEmpty(cboTenKhoa.Text.Trim()) && !string.IsNullOrEmpty(cboTenNganh.Text.Trim()))
            {
                if (cboTenKhoa.SelectedValue != null)
                {
                    NganhDTO n = new NganhDTO()
                    {
                        MANGANH = cboMaNganh.Text.Trim(),
                        TENNGANH = cboTenNganh.Text.Trim(),
                        MAKHOA = cboTenKhoa.SelectedValue.ToString(),
                        GHICHU = txtGhiChu.Text.Trim(),
                    };

                    if (_nganhBUS.KTNganh(n) == true)
                    {

                        if (_nganhBUS.SuaNganh(n) == true)
                        {
                            MessageBox.Show(Constant.SuaTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Res();
                            LoadDSNganh();
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
                        MessageBox.Show("Ngành không tồn tại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show(Constant.nhapChuaDuThongTin, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (!string.IsNullOrEmpty(cboMaNganh.Text.Trim()))
                {
                    NganhDTO n = new NganhDTO();
                    {
                        n.MANGANH = cboMaNganh.Text.Trim();
                    }
                    if (_nganhBUS.KTNganh(n) == true)
                    {
                        if (_nganhBUS.XoaNgah(n) == true)
                        {

                            MessageBox.Show(Constant.XoaTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Res();
                            LoadDSNganh();
                            LoadCBONganh();
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
                        MessageBox.Show("Ngành không tồn tại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã ngành", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            LoadCBONganh();

        }




        private void radGhiChu_CheckedChanged(object sender, EventArgs e)
        {
            if (radGhiChu.Checked)
            {
                dgvNganh.DataSource = _nganhBUS.DSNganh_GhiChu(txtGhiChu.Text);
            }
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {
            if (radGhiChu.Checked)
            {
                dgvNganh.DataSource = _nganhBUS.DSNganh_GhiChu(txtGhiChu.Text);
            }
        }

        private void radTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (radTatCa.Checked)
            {
                LoadDSNganh();
            }    

        }

        private void dgvNganh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            else if (dgvNganh.SelectedRows.Count == 0)
            {
                dgvNganh.ClearSelection();
                LoadCBONganh();
                LoadDSNganh();
            }
            else
            {
                cboMaNganh.Text = dgvNganh.Rows[e.RowIndex].Cells[Constant.NGANH_MaNganh].Value.ToString();
                cboTenKhoa.Text = dgvNganh.Rows[e.RowIndex].Cells[Constant.NGANH_TenKhoa].Value.ToString();
                cboTenNganh.Text = dgvNganh.Rows[e.RowIndex].Cells[Constant.NGANH_TenNganh].Value.ToString();
                txtGhiChu.Text = dgvNganh.Rows[e.RowIndex].Cells[Constant.NGANH_GhiChu].Value.ToString();
            }
        }

        private void radMaNganh_CheckedChanged(object sender, EventArgs e)
        {
            if (radMaNganh.Checked)
            {
                dgvNganh.DataSource = _nganhBUS.DSNganh_MaNganh(cboMaNganh.Text.Trim());
            }
        }

        private void cboMaNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radMaNganh.Checked)
            {
                dgvNganh.DataSource = _nganhBUS.DSNganh_MaNganh(cboMaNganh.Text.Trim());
            }
        }

        private void cboTenNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radTenNganh.Checked)
            {
                dgvNganh.DataSource = _nganhBUS.DSNganh_TenNganh(cboTenNganh.Text.Trim());
            }
        }

        private void radTenNganh_CheckedChanged(object sender, EventArgs e)
        {
            if (radTenNganh.Checked)
            {
                dgvNganh.DataSource = _nganhBUS.DSNganh_TenNganh(cboTenNganh.Text.Trim());
            }
        }

        private void radTenKhoa_CheckedChanged(object sender, EventArgs e)
        {
            if (radTenKhoa.Checked)
            {
                dgvNganh.DataSource = _nganhBUS.DSNganh_TenKhoa(cboTenKhoa.Text.Trim());
            }
        }

        private void cboTenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radTenKhoa.Checked)
            {
                dgvNganh.DataSource = _nganhBUS.DSNganh_TenKhoa(cboTenKhoa.Text.Trim());
            }
        }

        private void frmQLNganh_Load(object sender, EventArgs e)
        {
            

        }
    }
}