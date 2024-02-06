using BUS;
using DAO;
using DevExpress.DashboardWeb.Native;
using DevExpress.Utils;
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
    public partial class frmQLHocKy : DevExpress.XtraEditors.XtraForm
    {
        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();
        HocKyBUS _HocKyBUS = new HocKyBUS();
        public frmQLHocKy()
        {
            InitializeComponent();
            loadDSHK();
            Res();
            radTatCa.Checked = true;
        }

        public void loadDSHK()
        {
            dgvHocKy.DataSource = _HocKyBUS.DSHocKy();
        }

        private void LoadCBO_HocKy()
        {
            cboMaHocKy.DataSource = DB.HOCKies.Where(u => u.TRANGTHAI == false).ToList();
            cboMaHocKy.ValueMember = "MAHOCKY";
            cboMaHocKy.DisplayMember = "MAHOCKY";

            cboTenHocKy.DataSource = DB.HOCKies.Where(u => u.TRANGTHAI == false).ToList();
            cboTenHocKy.ValueMember = "TENHOCKY";
            cboTenHocKy.DisplayMember = "TENHOCKY";
        }
        public void Res()
        {
            LoadCBO_HocKy();
            cboMaHocKy.SelectedIndex=0;
            cboTenHocKy.SelectedIndex=0;
            txtGhiChu.Text = string.Empty;
            radGhiChu.Checked =false;
            radMaHocKy.Checked =false;
            radTatCa.Checked =false;
            radTenHocKy.Checked=false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(cboMaHocKy.Text.Trim())&& !string.IsNullOrEmpty(cboTenHocKy.Text.Trim()))
            {
                HocKYDTO hocky = new HocKYDTO();
                {
                    hocky.MAHOCKY = cboMaHocKy.Text;
                    hocky.TENHOCKY = cboTenHocKy.Text;
                    hocky.GHICHU = txtGhiChu.Text;
                }
                if (_HocKyBUS.KTHocKy(hocky) == false)
                {
                    if(_HocKyBUS.KTHKDaXoa(cboMaHocKy.Text.Trim())==false)
                    {
                        if (_HocKyBUS.ThemHocKy(hocky) == true)
                        {
                            MessageBox.Show(Constant.ThemTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Res();
                            loadDSHK();
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
                        if (_HocKyBUS.ThemHKDaXoa(hocky) == true)
                        {
                            MessageBox.Show(Constant.ThemTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Res();
                            loadDSHK();
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
                    MessageBox.Show("Đã tồn tại học kỳ", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show(Constant.nhapChuaDuThongTin, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
        }

        private void dgvHocKy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            else
            {
                cboMaHocKy.Text = dgvHocKy.Rows[e.RowIndex].Cells[Constant.HOCKY_MaHocKy].Value.ToString();
                cboTenHocKy.Text = dgvHocKy.Rows[e.RowIndex].Cells[Constant.HOCKY_TenHocKy].Value.ToString();
                txtGhiChu.Text = dgvHocKy.Rows[e.RowIndex].Cells[Constant.HOCKY_GhiChu].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(Constant.HoiXoa, Constant.ThongBao, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if(!string.IsNullOrEmpty(cboMaHocKy.Text.Trim()))
                {
                    HocKYDTO hocky = new HocKYDTO();
                    {
                        hocky.MAHOCKY = cboMaHocKy.Text;
                    }
                    if (_HocKyBUS.KTHocKy(hocky) == true)
                    {
                        if (_HocKyBUS.XoaHK(hocky) == true)
                        {

                            MessageBox.Show(Constant.XoaTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Res();
                            loadDSHK();

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
                        MessageBox.Show("Học kỳ không tồn tại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã học kỳ", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else
            {
                MessageBox.Show(Constant.HuyXoa, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(cboMaHocKy.Text.Trim()) && !string.IsNullOrEmpty(cboTenHocKy.Text.Trim()))
            {
                HocKYDTO hocky = new HocKYDTO()
                {
                    MAHOCKY = cboMaHocKy.Text,
                    TENHOCKY = cboTenHocKy.Text,
                    GHICHU = txtGhiChu.Text,

                };
                if (_HocKyBUS.KTHocKy(hocky) == true)
                {

                    if (_HocKyBUS.SuaHK(hocky) == true)
                    {
                        MessageBox.Show(Constant.SuaTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Res();
                        loadDSHK();
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
                    MessageBox.Show("Học kỳ không tồn tại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Res();
            loadDSHK() ;
            radMaHocKy.Checked = false;
            radTenHocKy.Checked = false;
            radGhiChu.Checked = false;
            radTatCa.Checked = false;
        }

        private void radMaHocKy_CheckedChanged(object sender, EventArgs e)
        {
            if(radMaHocKy.Checked)
            {
                dgvHocKy.DataSource = _HocKyBUS.DSHOCKY_MaHocKy(cboMaHocKy.Text.Trim());
            }    
        }

        private void cboMaHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radMaHocKy.Checked)
            {
                dgvHocKy.DataSource = _HocKyBUS.DSHOCKY_MaHocKy(cboMaHocKy.Text.Trim());
            }
        }

        private void radTenHocKy_CheckedChanged(object sender, EventArgs e)
        {
            if (radTenHocKy.Checked)
            {
                dgvHocKy.DataSource = _HocKyBUS.DSHOCKY_TenHocKy(cboTenHocKy.Text.Trim());
            }
        }

        private void cboTenHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radTenHocKy.Checked)
            {
                dgvHocKy.DataSource = _HocKyBUS.DSHOCKY_TenHocKy(cboTenHocKy.Text.Trim());
            }
        }

        private void radGhiChu_CheckedChanged(object sender, EventArgs e)
        {
            if (radGhiChu.Checked)
            {
                dgvHocKy.DataSource = _HocKyBUS.DSHOCKY_GhiChu(txtGhiChu.Text.Trim());
            }
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {
            if (radGhiChu.Checked)
            {
                dgvHocKy.DataSource = _HocKyBUS.DSHOCKY_GhiChu(txtGhiChu.Text.Trim());
            }
        }

        private void radTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if(radTatCa.Checked)
            {
                dgvHocKy.DataSource = _HocKyBUS.DSHocKy();
            }    
        }

        private void frmQLHocKy_Load(object sender, EventArgs e)
        {

        }
    }
}