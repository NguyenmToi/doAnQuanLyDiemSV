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
    public partial class frmQLLop : DevExpress.XtraEditors.XtraForm
    {
        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();
        LopBUS _LopBUS = new LopBUS();
        public frmQLLop()
        {
            InitializeComponent();
            LoadDSLop();
            LoadCBOLop();
            Res();
            radTatCa.Checked = true;
        }

        public void LoadDSLop()
        {
            dgvLop.DataSource = _LopBUS.DSLOP();
        }


        public void LoadCBOLop()
        {
            cboMaLop.DataSource = DB.LOPs.Where(u => u.TRANGTHAI == false).ToList();
            cboMaLop.ValueMember = "MALOP";
            cboMaLop.DisplayMember = "MALOP";

            cboTenLop.DataSource = DB.LOPs.Where(u => u.TRANGTHAI == false).ToList();
            cboTenLop.ValueMember = "TENLOP";
            cboTenLop.DisplayMember = "TENLOP";

            cboTenNganh.DataSource = DB.NGANHs.Where(u => u.TRANGTHAI == false).ToList();
            cboTenNganh.ValueMember = "MANGANH";
            cboTenNganh.DisplayMember = "TENNGANH";

            cboNienKhoa.DataSource = DB.NIENKHOAs.Where(u=>u.TRANGTHAI==false).ToList();
            cboNienKhoa.ValueMember = "MANIENKHOA";
            cboNienKhoa.DisplayMember = "TENNIENKHOA";

        }

        public void Res()
        {
            cboMaLop.SelectedIndex = 0;
            cboTenLop.SelectedIndex=0;
            cboTenNganh.SelectedIndex=0;
            cboNienKhoa.SelectedIndex=0;
            txtGhiChu.Text = string.Empty;

            radMaLop.Checked = false;
            radNienKhoa.Checked = false;
            radGhiChu.Checked = false;
            radTenLop.Checked = false;
            radTenNganh.Checked = false;
            radTatCa.Checked = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cboMaLop.Text.Trim()) && !string.IsNullOrEmpty(cboTenLop.Text.Trim())&&!string.IsNullOrEmpty(cboNienKhoa.Text.Trim())&&!string.IsNullOrEmpty(cboTenNganh.Text.Trim()))
            {
                if (cboTenNganh.SelectedValue!=null&&cboNienKhoa.SelectedValue!=null)
                {
                    LopDTO lop = new LopDTO();
                    {
                        lop.MALOP = cboMaLop.Text.Trim();
                        lop.TENLOP = cboTenLop.Text.Trim();
                        lop.MANGANH = cboTenNganh.SelectedValue.ToString();
                        lop.MANIENKHOA = cboNienKhoa.SelectedValue.ToString();
                        lop.GHICHU = txtGhiChu.Text.Trim();
                    }
                    if (_LopBUS.KTLop(lop) == false)
                    {
                        if (_LopBUS.KTLOPDaXoa(cboMaLop.Text.Trim()) == false)
                        {
                            if (_LopBUS.ThemLop(lop) == true)
                            {
                                MessageBox.Show(Constant.ThemTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Res();
                                LoadDSLop();
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
                            if (_LopBUS.ThemLopDaXoa(lop) == true)
                            {
                                MessageBox.Show(Constant.ThemTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Res();
                                LoadDSLop();
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
                        MessageBox.Show("Đã tồn tại lớp", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    

        private void radTenLop_CheckedChanged(object sender, EventArgs e)
        {
            if(radTenLop.Checked)
            {
                dgvLop.DataSource = _LopBUS.DSLOP_TenLop(cboTenLop.Text.Trim());
            }    
        }

        private void radMaLop_CheckedChanged(object sender, EventArgs e)
        {
            if(radMaLop.Checked)
            {
                dgvLop.DataSource = _LopBUS.DSLOP_MaLop(cboMaLop.Text.Trim());
            }    
        }

        private void cboMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radMaLop.Checked)
            {
                dgvLop.DataSource = _LopBUS.DSLOP_MaLop(cboMaLop.Text.Trim());
            }
        }

        private void cboTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radTenLop.Checked)
            {
                dgvLop.DataSource = _LopBUS.DSLOP_TenLop(cboTenLop.Text.Trim());
            }
        }

        private void cboTenNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radTenNganh.Checked)
            {
                if (!string.IsNullOrEmpty(cboTenNganh.Text.Trim()) && radTenNganh.Checked)
                {
                   
                    if (cboTenNganh.SelectedValue == null) { return; }
                    else
                    {
                        string a = cboTenNganh.SelectedValue.ToString();
                        if (_LopBUS.DSLOP_TenNganh(a) != null)
                        {
                            dgvLop.DataSource = _LopBUS.DSLOP_TenNganh(a);
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }
                    
                }
                else
                {
                    LoadDSLop();
                    return;
                }

            }
        }

        private void radTenNganh_CheckedChanged(object sender, EventArgs e)
        {
            if (radTenNganh.Checked)
            {
                if (!string.IsNullOrEmpty(cboTenNganh.Text.Trim()) && radTenNganh.Checked)
                {
                    
                    if (cboTenNganh.SelectedValue == null) { return; }
                    else
                    {
                        string a = cboTenNganh.SelectedValue.ToString();
                        if (_LopBUS.DSLOP_TenNganh(a) != null)
                        {
                            dgvLop.DataSource = _LopBUS.DSLOP_TenNganh(a);
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }
                    
                }
                else
                {
                    LoadDSLop();
                    return;
                }

            }
        }

        private void radNienKhoa_CheckedChanged(object sender, EventArgs e)
        {
            if (radNienKhoa.Checked)
            {
                if (!string.IsNullOrEmpty(cboNienKhoa.Text.Trim()) && radNienKhoa.Checked)
                {
                    if (cboNienKhoa.SelectedValue == null) { return; }
                    else
                    {
                        string a = cboNienKhoa.SelectedValue.ToString();
                        if (_LopBUS.DSLOP_MaNienKhoa(a) != null)
                        {
                            dgvLop.DataSource = _LopBUS.DSLOP_MaNienKhoa(a);
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }
                   
                }
                else
                {
                    LoadDSLop();
                    return;
                }

            }
        }

        private void cboNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radNienKhoa.Checked)
            {
                if (!string.IsNullOrEmpty(cboNienKhoa.Text.Trim()) && radNienKhoa.Checked)
                {
                    if (cboNienKhoa.SelectedValue == null) { return; }
                    else
                    {
                        string a = cboNienKhoa.SelectedValue.ToString();
                        if (_LopBUS.DSLOP_MaNienKhoa(a) != null)
                        {
                            dgvLop.DataSource = _LopBUS.DSLOP_MaNienKhoa(a);
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }

                }
                else
                {
                    LoadDSLop();
                    return;
                }

            }
        }

        private void radTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if(radTatCa.Checked)
            {
                dgvLop.DataSource = _LopBUS.DSLOP();
            }    
        }

        private void radGhiChu_CheckedChanged(object sender, EventArgs e)
        {
            if(radGhiChu.Checked)
            {
                dgvLop.DataSource = _LopBUS.DSLOP_GhiChu(txtGhiChu.Text.Trim());
            }    
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {
            if (radGhiChu.Checked)
            {
                dgvLop.DataSource = _LopBUS.DSLOP_GhiChu(txtGhiChu.Text.Trim());
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Res();
            LoadDSLop();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cboMaLop.Text.Trim()) && !string.IsNullOrEmpty(cboTenLop.Text.Trim()) && !string.IsNullOrEmpty(cboNienKhoa.Text.Trim()) && !string.IsNullOrEmpty(cboTenNganh.Text.Trim()))
            {
                if(cboNienKhoa.SelectedValue!=null&&cboTenNganh.SelectedValue!=null)
                {
                    LopDTO lop = new LopDTO()
                    {
                        MALOP = cboMaLop.Text.Trim(),
                        TENLOP = cboTenLop.Text.Trim(),
                        MANGANH = cboTenNganh.SelectedValue.ToString(),
                        MANIENKHOA = cboNienKhoa.SelectedValue.ToString(),
                        GHICHU = txtGhiChu.Text.Trim()
                    };

                    if (_LopBUS.KTLop(lop) == true)
                    {

                        if (_LopBUS.SuaLop(lop) == true)
                        {
                            MessageBox.Show(Constant.SuaTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Res();
                            LoadDSLop();
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
                        MessageBox.Show("Lớp không tồn tại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnXoa_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(Constant.HoiXoa, Constant.ThongBao, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(cboMaLop.Text.Trim()))
                {
                    LopDTO lop = new LopDTO();
                    {
                        lop.MALOP = cboMaLop.Text.Trim();
                    }
                    if (_LopBUS.KTLop(lop) == true)
                    {
                        if (_LopBUS.XoaLop(lop) == true)
                        {

                            MessageBox.Show(Constant.XoaTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Res();
                            LoadDSLop();

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
                        MessageBox.Show("Lớp không tồn tại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã lớp", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else
            {
                MessageBox.Show(Constant.HuyXoa, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void dgvLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex == -1) return;
            else if (dgvLop.SelectedRows.Count == 0)
            {
                dgvLop.ClearSelection();
                Res();
            }
            else
            {
                cboMaLop.Text = dgvLop.Rows[e.RowIndex].Cells[Constant.LOP_MaLop].Value.ToString();
                cboTenLop.Text = dgvLop.Rows[e.RowIndex].Cells[Constant.LOP_TenLop].Value.ToString();
                cboTenNganh.Text = dgvLop.Rows[e.RowIndex].Cells[Constant.LOP_TenNganh].Value.ToString();
                cboNienKhoa.Text = dgvLop.Rows[e.RowIndex].Cells[Constant.LOP_TenNienKhoa].Value.ToString();
                txtGhiChu.Text = dgvLop.Rows[e.RowIndex].Cells[Constant.LOP_GhiChu].Value.ToString();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void grpChucNang_Enter(object sender, EventArgs e)
        {

        }

        private void frmQLLop_Load(object sender, EventArgs e)
        {

        }
    }
}