//using BUS;
//using DAO;
//using DTO;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace ĐA_LTW_QuanLyDiemDanhChoGV.Quan_ly
//{
//    public partial class UserQuanLyTKGiangVien : UserControl
//    {
//        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();
//        TaiKhoanGVBUS _taiKhoanGVBUS = new TaiKhoanGVBUS();
//        public UserQuanLyTKGiangVien()
//        {
//            InitializeComponent();
//            DSTaiKhoan();
//        }




//        public void DSTaiKhoan()
//        {
//            dgvTaiKhoanSV.DataSource = _taiKhoanGVBUS.DSTaiKhoanGV();

//        }

//        public void LOADCN()
//        {
//            DSTaiKhoan();
//            Rs();
//        }

//        public void Rs()
//        {
//            txtTaiKhoan.Text = string.Empty;
//            txtMatKhau.Text = string.Empty;
//            txtGhiChu.Text = string.Empty;
//            cboTimKiem.SelectedIndex = 0;
//        }

//        private void dgvTaiKhoanGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {
//            if (e.RowIndex >= 0)
//            {
//                txtTaiKhoan.Text = dgvTaiKhoanSV.Rows[e.RowIndex].Cells[Constant.TKGV_TaiKhoan].Value.ToString();
//                txtMatKhau.Text = dgvTaiKhoanSV.Rows[e.RowIndex].Cells[Constant.TKGV_MatKhau].Value.ToString();
//                txtGhiChu.Text = dgvTaiKhoanSV.Rows[e.RowIndex].Cells[Constant.GhiChu].Value.ToString();
//            }
//        }
//        private void btnThem_Click(object sender, EventArgs e)
//        {

//            if (!string.IsNullOrEmpty(txtTaiKhoan.Text.Trim()))
//            {
//                if (!string.IsNullOrEmpty(txtMatKhau.Text.Trim()))
//                {
//                    if (txtMatKhau.Text.Trim().Length > 5)
//                    {

//                        TaiKhoanGVDTO tk = new TaiKhoanGVDTO();
//                        {
//                            tk.TAIKHOAN = txtTaiKhoan.Text.Trim();
//                            tk.MATKHAU = txtMatKhau.Text.Trim();
//                            tk.GHICHU = txtGhiChu.Text.Trim();
//                            tk.TRANGTHAI = false;

//                        }
//                        if (_taiKhoanGVBUS.KT(txtTaiKhoan.Text.Trim()) == false)
//                        {
//                            if (_taiKhoanGVBUS.KTMaGV(txtTaiKhoan.Text.Trim()) == true)
//                            {
//                                if (_taiKhoanGVBUS.ThemTaiKhoan(tk) == true)
//                                {
//                                    MessageBox.Show(Constant.ThemTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
//                                    LOADCN();
//                                    return;
//                                }
//                                else
//                                {
//                                    MessageBox.Show(Constant.ThemTB, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                                    txtTaiKhoan.Focus();
//                                    return;
//                                }
//                            }
//                            else
//                            {
//                                MessageBox.Show("Tài khoản không tồn tại trong danh sách được tạo", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                                txtTaiKhoan.Focus();
//                                return;
//                            }
//                        }
//                        else
//                        {
//                            MessageBox.Show("Tài khoản đã tồn tại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                            txtTaiKhoan.Focus();
//                            return;
//                        }
//                    }
//                    else
//                    {
//                        MessageBox.Show("Mật khẩu phải có tối thiểu 6 ký tự", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                        txtMatKhau.Text = txtMatKhau.Text.Trim();
//                        txtMatKhau.Focus();
//                        return;
//                    }

//                }
//                else
//                {
//                    MessageBox.Show("Vui lòng nhập mật khẩu", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                    txtMatKhau.Focus();
//                    return;
//                }
//            }
//            else
//            {
//                MessageBox.Show("Vui lòng nhập tài khoản", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                txtTaiKhoan.Focus();
//                return;
//            }

//        }

//        private void btnSua_Click(object sender, EventArgs e)
//        {
//            if (!string.IsNullOrEmpty(txtTaiKhoan.Text.Trim()))
//            {
//                if (!string.IsNullOrEmpty(txtMatKhau.Text.Trim()))
//                {
//                    if (txtMatKhau.Text.Trim().Length > 5)
//                    {
//                        TaiKhoanGVDTO tk = new TaiKhoanGVDTO()
//                        {
//                            TAIKHOAN = txtTaiKhoan.Text.Trim(),
//                            MATKHAU = txtMatKhau.Text.Trim(),
//                            GHICHU = txtGhiChu.Text.Trim(),
//                        };
//                        if (_taiKhoanGVBUS.KT(txtTaiKhoan.Text.Trim()) == true)
//                        {
//                            if (_taiKhoanGVBUS.SuaTaiKhoan(tk) == true)
//                            {
//                                MessageBox.Show(Constant.SuaTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
//                                LOADCN();
//                                return;
//                            }
//                            else
//                            {
//                                MessageBox.Show("Sửa thất bại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                                txtTaiKhoan.Focus();
//                                return;
//                            }
//                        }
//                        else
//                        {
//                            MessageBox.Show("Tài khoản không tồn tại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                            txtTaiKhoan.Focus();
//                            return;
//                        }
//                    }
//                    else
//                    {
//                        MessageBox.Show("Mật khẩu phải có tối thiểu 6 ký tự", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                        txtMatKhau.Text = txtMatKhau.Text.Trim();
//                        txtMatKhau.Focus();
//                        return;
//                    }

//                }
//                else
//                {
//                    MessageBox.Show("Vui lòng nhập mật khẩu", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                    txtMatKhau.Focus();
//                    return;
//                }
//            }
//            else
//            {
//                MessageBox.Show("Vui lòng nhập tài khoản", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                txtTaiKhoan.Focus();
//                return;
//            }
//        }

//        private void btnXoa_Click(object sender, EventArgs e)
//        {
//            TaiKhoanGVDTO tk = new TaiKhoanGVDTO();
//            {
//                tk.TAIKHOAN = txtTaiKhoan.Text.Trim();
//            }
//            string a = txtTaiKhoan.Text.Trim();
//            DialogResult result = MessageBox.Show(Constant.HoiXoa, Constant.ThongBao, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
//            if (result == DialogResult.Yes)
//            {
//                if (!string.IsNullOrEmpty(txtTaiKhoan.Text.Trim()))
//                {
//                    if (_taiKhoanGVBUS.KT(a))
//                    {
//                        if (_taiKhoanGVBUS.XoaTaiKhoan(tk))
//                        {
//                            MessageBox.Show(Constant.XoaTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
//                            LOADCN();
//                            return;
//                        }
//                        else
//                        {
//                            MessageBox.Show(Constant.XoaTB, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                            return;
//                        }
//                    }
//                    else
//                    {
//                        MessageBox.Show("Tài khoản không tồn tại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                        return;
//                    }
//                }
//                else
//                {
//                    MessageBox.Show("Vui lòng nhập mã loại tài khoản", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                    return;
//                }
//            }
//            else
//            {
//                MessageBox.Show(Constant.HuyXoa, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
//                LOADCN();
//                return;
//            }
//        }

//        private void groupBox1_Enter(object sender, EventArgs e)
//        {

//        }

//        private void btnKhoiPhucTaiKhoan_Click(object sender, EventArgs e)
//        {
//            if (!string.IsNullOrEmpty(txtTaiKhoan.Text.Trim()))
//            {
//                if (!string.IsNullOrEmpty(txtMatKhau.Text.Trim()))
//                {
//                    if (txtMatKhau.Text.Trim().Length > 5)
//                    {
//                        TaiKhoanGVDTO tk = new TaiKhoanGVDTO()
//                        {
//                            TAIKHOAN = txtTaiKhoan.Text.Trim(),
//                            MATKHAU = txtMatKhau.Text.Trim(),
//                            GHICHU = txtGhiChu.Text.Trim(),
//                        };
//                        if (_taiKhoanGVBUS.KT(txtTaiKhoan.Text.Trim()) == false)
//                        {
//                            if (_taiKhoanGVBUS.KTKhoiPhuc(txtTaiKhoan.Text.Trim()) == true)
//                            {

//                                if (_taiKhoanGVBUS.KhoiPhucTaiKhoan(tk) == true)
//                                {
//                                    MessageBox.Show("Khôi phục tài khoản thành công", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
//                                    LOADCN();
//                                    return;
//                                }
//                                else
//                                {
//                                    MessageBox.Show("Khôi phục tài khoản thất bại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                                    txtTaiKhoan.Focus();
//                                    return;
//                                }

//                            }
//                            else
//                            {
//                                MessageBox.Show("Tài khoản không tồn tại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                                txtTaiKhoan.Focus();
//                                return;
//                            }
//                        }
//                        else
//                        {
//                            MessageBox.Show("Tài khoản này đang được sử dụng", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                            txtTaiKhoan.Focus();
//                            return;
//                        }
//                    }
//                    else
//                    {
//                        MessageBox.Show("Mật khẩu phải có tối thiểu 6 ký tự", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                        txtMatKhau.Text = txtMatKhau.Text.Trim();
//                        txtMatKhau.Focus();
//                        return;
//                    }

//                }
//                else
//                {
//                    MessageBox.Show("Vui lòng nhập mật khẩu", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                    txtMatKhau.Focus();
//                    return;
//                }
//            }
//            else
//            {
//                MessageBox.Show("Vui lòng nhập tài khoản", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                txtTaiKhoan.Focus();
//                return;
//            }
//        }

//        private void btnTimKiem_Click(object sender, EventArgs e)
//        {
//            if (cboTimKiem.SelectedIndex == 0)
//            {
//                dgvTaiKhoanSV.DataSource = _taiKhoanGVBUS.DSTaiKhoanGV_TaiKhoan(txtTaiKhoan.Text.Trim());
//            }
//            else if (cboTimKiem.SelectedIndex == 1)
//            {
//                dgvTaiKhoanSV.DataSource = _taiKhoanGVBUS.DSDSTaiKhoanGV_GhiChu(txtGhiChu.Text.Trim());
//            }
//        }

//        private void UserQLTKGiangvien_Load(object sender, EventArgs e)
//        {
//            cboTimKiem.SelectedIndex = 0;
//            txtTaiKhoan.Focus();
//        }

//        private void btnLamMoi_Click(object sender, EventArgs e)
//        {
//            Rs();
//            DSTaiKhoan();
//        }

//        private void UserQuanLyTKGiangVien_Load(object sender, EventArgs e)
//        {

//        }

//        private void dgvTaiKhoanSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {

//        }

//        private void InitializeComponent()
//        {
//            this.SuspendLayout();

//            UserQuanLyTKGiangVien


//            this.Name = "UserQuanLyTKGiangVien";
//            this.Load += new System.EventHandler(this.UserQuanLyTKGiangVien_Load_1);
//            this.ResumeLayout(false);

//        }

//        private void UserQuanLyTKGiangVien_Load_1(object sender, EventArgs e)
//        {

//        }
//    }
//}
