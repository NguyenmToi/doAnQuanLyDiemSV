using BUS;
using ĐA_LTW_QuanLyDiemDanhChoGV;
using DAO;
using DevExpress.Data.Utils;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ĐA_LTW_QuanLyDiemDanhChoGV.Quan_ly
{
    public partial class frmQLMonHoc : DevExpress.XtraEditors.XtraForm
    {
        MonHocBUS _monHocBUS = new MonHocBUS();
        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();
        public frmQLMonHoc()
        {
            InitializeComponent();
            LOADDSMonHoc();
            LOADCBOMonHoc();
            radMaMonHoc.Checked = false;
        }

        public void LOADDSMonHoc()
        {
            dgvMonHoc.DataSource = _monHocBUS.DSMonHoc();
        }

        private void grpChucNang_Enter(object sender, EventArgs e)
        {

        }

        public void LOADCN()
        {
            LOADCBOMonHoc();
            LOADDSMonHoc();
            Rs();
        }

        public void Rs()
        {
            cboMaMonHoc.SelectedIndex = 0;
            cboTenMonHoc.SelectedIndex = 0;
            txtSoTinChi.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
        }

        public void LOADCBOMonHoc()
        {
            cboMaMonHoc.DataSource = DB.MONHOCs.Where(u => u.TRANGTHAI == false).ToList();
            cboMaMonHoc.DisplayMember = "MAMH";
            cboMaMonHoc.ValueMember = "MAMH";

            cboTenMonHoc.DataSource = DB.MONHOCs.Where(u => u.TRANGTHAI == false).ToList();
            cboTenMonHoc.DisplayMember = "TENMH";
            cboTenMonHoc.ValueMember = "TENMH";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cboMaMonHoc.Text.Trim()) && !string.IsNullOrEmpty(cboTenMonHoc.Text.Trim()) && !string.IsNullOrEmpty(txtSoTinChi.Text.Trim()))
            {
                    MonHocDTO n = new MonHocDTO();
                    {
                        n.MAMH = cboMaMonHoc.Text.Trim();
                        n.TENMH = cboTenMonHoc.Text.Trim();
                        n.SOTINCHI = int.Parse(txtSoTinChi.Text.Trim());
                        n.GHICHU = txtGhiChu.Text.Trim();
                    }
                    if (_monHocBUS.KT(cboMaMonHoc.Text.Trim()) == false)
                    {
                        if (_monHocBUS.KTDaXoa(cboMaMonHoc.Text.Trim()) == false)
                        {
                            if (_monHocBUS.ThemMonHoc(n) == true)
                            {
                                MessageBox.Show(Constant.ThemTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Rs();
                                LOADDSMonHoc();
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
                            if (_monHocBUS.ThemMonHocDaXoa(n) == true)
                            {
                                MessageBox.Show(Constant.ThemTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Rs();
                                LOADDSMonHoc();
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
                        MessageBox.Show("Môn học đã tồn tại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                
            }
            else
            {
                MessageBox.Show(Constant.nhapChuaDuThongTin, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void txtSoTinChi_TextChanged(object sender, EventArgs e)
        {
            if (radSoTinChi.Checked && !string.IsNullOrEmpty(txtSoTinChi.Text))
            {
                dgvMonHoc.DataSource = _monHocBUS.DSMonHoc_SoTinChi(Int32.Parse(txtSoTinChi.Text.Trim()));
            }
            else
            {
                LOADDSMonHoc();
                return;
            }
        }

        private void txtSoTinChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar)&&!Char.IsControl(e.KeyChar)) 
            {
                e.Handled = true;
            }
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(Constant.HoiXoa, Constant.ThongBao, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(cboMaMonHoc.Text.Trim()))
                {
                    MonHocDTO n = new MonHocDTO();
                    {
                        n.MAMH = cboMaMonHoc.Text.Trim();
                    }
                    if (_monHocBUS.KT(cboMaMonHoc.Text.Trim()) == true)
                    {
                        if (_monHocBUS.XoaMonHoc(n) == true)
                        {

                            MessageBox.Show(Constant.XoaTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Rs();
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
                        MessageBox.Show("Môn học không tồn tại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã môn học", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else
            {
                MessageBox.Show(Constant.HuyXoa, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void dgvMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                cboMaMonHoc.Text = dgvMonHoc.Rows[e.RowIndex].Cells[Constant.MONHOC_MaMonHoc].Value.ToString();
                cboTenMonHoc.Text = dgvMonHoc.Rows[e.RowIndex].Cells[Constant.MONHOC_TenMonHoc].Value.ToString();
                txtSoTinChi.Text = dgvMonHoc.Rows[e.RowIndex].Cells[Constant.MONHOC_SoTinChi].Value.ToString();
                txtGhiChu.Text = dgvMonHoc.Rows[e.RowIndex].Cells[Constant.MONHOC_GhiChu].Value.ToString();
            }    

        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cboMaMonHoc.Text.Trim()) && !string.IsNullOrEmpty(cboTenMonHoc.Text.Trim()) && !string.IsNullOrEmpty(txtSoTinChi.Text.Trim()))
            {

                MonHocDTO n = new MonHocDTO()
                {
                    MAMH = cboMaMonHoc.Text.Trim(),
                    TENMH = cboTenMonHoc.Text.Trim(),
                    SOTINCHI = int.Parse(txtSoTinChi.Text.Trim()),
                    GHICHU = txtGhiChu.Text.Trim()
                };

                if (_monHocBUS.KT(cboMaMonHoc.Text.Trim()) == true)
                    {

                        if (_monHocBUS.SuaMonHoc(n) == true)
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
                        MessageBox.Show("Môn học không tồn tại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
             

            }
            else
            {
                MessageBox.Show(Constant.nhapChuaDuThongTin, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LOADCN();
            radMaMonHoc.Checked = false;
            radTenMonHoc.Checked = false;
            radSoTinChi.Checked = false;
            radGhiChu.Checked = false;
        }

        private void radGhiChu_CheckedChanged(object sender, EventArgs e)
        {
            if (radGhiChu.Checked)
            {
                dgvMonHoc.DataSource = _monHocBUS.DSMonHoc_GhiChu(txtGhiChu.Text.Trim());
            }
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {
            if (radGhiChu.Checked)
            {
                dgvMonHoc.DataSource = _monHocBUS.DSMonHoc_GhiChu(txtGhiChu.Text.Trim());
            }
        }

        private void radMaMonHoc_CheckedChanged(object sender, EventArgs e)
        {
            if(radMaMonHoc.Checked)
            {
                dgvMonHoc.DataSource = _monHocBUS.DSMonHoc_MaMonHoc(cboMaMonHoc.Text.Trim());
            }    
        }

        private void cboMaMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radMaMonHoc.Checked)
            {
                dgvMonHoc.DataSource = _monHocBUS.DSMonHoc_MaMonHoc(cboMaMonHoc.Text.Trim());
            }
        }

        private void radTenMonHoc_CheckedChanged(object sender, EventArgs e)
        {
            if (radTenMonHoc.Checked)
            {
                dgvMonHoc.DataSource = _monHocBUS.DSMonHoc_TenMonHoc(cboTenMonHoc.Text.Trim());
            }
        }

        private void cboTenMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radTenMonHoc.Checked)
            {
                dgvMonHoc.DataSource = _monHocBUS.DSMonHoc_TenMonHoc(cboTenMonHoc.Text.Trim());
            }
        }

        private void radSoTinChi_CheckedChanged(object sender, EventArgs e)
        {
            if (radSoTinChi.Checked && !string.IsNullOrEmpty(txtSoTinChi.Text))
            {
                dgvMonHoc.DataSource = _monHocBUS.DSMonHoc_SoTinChi(Int32.Parse(txtSoTinChi.Text.Trim()));
            }
            else
            {
                LOADDSMonHoc();
                return;
            }
        }

        private void dgvMonHoc_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void frmQLMonHoc_Load(object sender, EventArgs e)
        {

        }
    }
}