using BUS;
using DAO;
using DevExpress.XtraEditors;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐA_LTW_QuanLyDiemDanhChoGV.Quan_ly
{
    public partial class frmQLGiangVien : DevExpress.XtraEditors.XtraForm
    {
        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();
        GiangVienBUS _giangVienBUS = new GiangVienBUS();
        public frmQLGiangVien()
        {
            InitializeComponent();
            LoadCN();
        }
        public void LoadDSGV()
        {
            dgvGiangVien.DataSource = _giangVienBUS.DSGiangVien();

        }

        public void LoadCN()
        {
            LoadCBOGiangVien();
            LoadDSGV();
            Res();
        }
        public void LoadCBOGiangVien()
        {
            cboKhoa.DataSource = DB.KHOAs.Where(u => u.TRANGTHAI == false).ToList();
            cboKhoa.DisplayMember = "TENKHOA";
            cboKhoa.ValueMember = "MAKHOA";
        }

        public void Res()
        {
            cboKhoa.SelectedIndex = 0;
            txtGhiChu.Text = string.Empty;
            txtHoTenGiangVien.Text = string.Empty;
            txtMaGiangVien.Text = string.Empty;

            radKhoa.Checked = false;
            radGhiChu.Checked = false;
            radTatCa.Checked = false;
            radHoTenGiangVien.Checked = false;
            radMaGiangVien.Checked = false;

        }

        private void dgvGiangVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            else
            {
                txtMaGiangVien.Text = dgvGiangVien.Rows[e.RowIndex].Cells[Constant.GV_MaGV].Value.ToString();
                txtHoTenGiangVien.Text = dgvGiangVien.Rows[e.RowIndex].Cells[Constant.GV_HoTenGV].Value.ToString();
                txtGhiChu.Text = dgvGiangVien.Rows[e.RowIndex].Cells[Constant.GV_GhiChu].Value.ToString();
                cboKhoa.Text = dgvGiangVien.Rows[e.RowIndex].Cells[Constant.GV_Khoa].Value.ToString();
                bool gt = bool.Parse(dgvGiangVien.Rows[e.RowIndex].Cells[Constant.GV_GioiTinh].Value.ToString());
                if (gt == true )
                {radNam.Checked=true; } else { radNu.Checked=true; }    
            }

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadCN();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrEmpty(txtMaGiangVien.Text.Trim()) && !string.IsNullOrEmpty(txtHoTenGiangVien.Text.Trim()) && !string.IsNullOrEmpty(cboKhoa.Text.Trim()))
            {
                if (cboKhoa.SelectedValue != null)
                {
                    GiangVienDTO gv = new GiangVienDTO();
                    {
                        gv.MAGV = txtMaGiangVien.Text.Trim();
                        gv.HOTENGV = txtHoTenGiangVien.Text.Trim();
                        gv.KHOA = cboKhoa.SelectedValue.ToString();
                        gv.GHICHU = txtGhiChu.Text.Trim();
                        gv.GIOITINH = radNam.Checked ? true : false;
                    }
                    if (_giangVienBUS.KTGV(gv) == false)
                    {
                        if (_giangVienBUS.KTKhoa(cboKhoa.SelectedValue.ToString()) == true)
                        {
                            if(_giangVienBUS.KTGVDaXoa(gv)==false)
                            {
                                if (_giangVienBUS.ThemGV(gv))
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
                                if (_giangVienBUS.ThemGVDaXoa(gv))
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
                            MessageBox.Show("Khoa không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Giảng viên đã tồn tại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void btnSua_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrEmpty(txtMaGiangVien.Text.Trim()) && !string.IsNullOrEmpty(txtHoTenGiangVien.Text.Trim()) && !string.IsNullOrEmpty(cboKhoa.Text.Trim()))
            {
                if(cboKhoa.SelectedValue!=null){
                    GiangVienDTO gv = new GiangVienDTO()
                    {
                        MAGV = txtMaGiangVien.Text.Trim(),
                        HOTENGV = txtHoTenGiangVien.Text.Trim(),
                        GIOITINH = radNam.Checked ? true : false,
                        GHICHU = txtGhiChu.Text.Trim(),
                        KHOA = cboKhoa.SelectedValue.ToString(),
                    };
                    if (_giangVienBUS.KTGV(gv) == true)
                    {
                        if (_giangVienBUS.KTKhoa(cboKhoa.SelectedValue.ToString()) == true)
                        {
                            if (_giangVienBUS.SuaGV(gv))
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
                            MessageBox.Show("Khoa không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Giảng viên không tồn tại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(Constant.HoiXoa, Constant.ThongBao, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if(!string.IsNullOrEmpty(txtMaGiangVien.Text.Trim()))
                {
                    GiangVienDTO gv = new GiangVienDTO()
                    {
                        MAGV = txtMaGiangVien.Text
                    };
                    if (_giangVienBUS.KTGV(gv) == true)
                    {
                        if (_giangVienBUS.XoaGV(gv))
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
                        MessageBox.Show("Giảng viên không tồn tại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã giảng viên", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else
            {
                MessageBox.Show(Constant.HuyXoa, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


        }
        private void radGhiChu_CheckedChanged(object sender, EventArgs e)
        {
            if (radGhiChu.Checked)
            {
                dgvGiangVien.DataSource = _giangVienBUS.DSGiangVien_GhiChu(txtGhiChu.Text);
            }
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {
            if (radGhiChu.Checked)
            {
                dgvGiangVien.DataSource = _giangVienBUS.DSGiangVien_GhiChu(txtGhiChu.Text);
            }
        }

        private void radTatCa_CheckedChanged(object sender, EventArgs e)
        {
            LoadDSGV();
        }


        private void radMaGiangVien_CheckedChanged(object sender, EventArgs e)
        {
                if (radMaGiangVien.Checked)
                {
                    dgvGiangVien.DataSource = _giangVienBUS.DSGiangVien_MaGV(txtMaGiangVien.Text.Trim());
                }
        }

        private void txtMaGiangVien_TextChanged(object sender, EventArgs e)
        {
            if (radMaGiangVien.Checked)
            {
                dgvGiangVien.DataSource = _giangVienBUS.DSGiangVien_MaGV(txtMaGiangVien.Text.Trim());
            }
        }

        private void radHoTenGiangVien_CheckedChanged(object sender, EventArgs e)
        {
            if (radHoTenGiangVien.Checked)
            {
                dgvGiangVien.DataSource = _giangVienBUS.DSGiangVien_HoTenGV(txtHoTenGiangVien.Text.Trim());
            }
        }

        private void txtHoTenGiangVien_TextChanged(object sender, EventArgs e)
        {
            if (radHoTenGiangVien.Checked)
            {
                dgvGiangVien.DataSource = _giangVienBUS.DSGiangVien_HoTenGV(txtHoTenGiangVien.Text.Trim());
            }
        }

        private void radKhoa_CheckedChanged(object sender, EventArgs e)
        {
            if (radKhoa.Checked)
            {
                if (!string.IsNullOrEmpty(cboKhoa.Text.Trim()) && radKhoa.Checked)
                {
                    {

                      
                        if (cboKhoa.SelectedValue == null) { return; }
                        else
                        {
                            string a = cboKhoa.SelectedValue.ToString();
                            if (_giangVienBUS.DSGiangVien_Khoa(a) != null)
                            {
                                dgvGiangVien.DataSource = _giangVienBUS.DSGiangVien_Khoa(a);
                                return;
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                }
                else
                {
                    LoadDSGV();
                    return;
                }

            }
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radKhoa.Checked)
            {
                if (!string.IsNullOrEmpty(cboKhoa.Text.Trim()) && radKhoa.Checked)
                {

                    if (cboKhoa.SelectedValue == null) { return; }
                    else
                    {
                        string a = cboKhoa.SelectedValue.ToString();
                        if (_giangVienBUS.DSGiangVien_Khoa(a) != null)
                        {
                            dgvGiangVien.DataSource = _giangVienBUS.DSGiangVien_Khoa(a);
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
                    LoadDSGV();
                    return;
                }

            }

        }


    }
}