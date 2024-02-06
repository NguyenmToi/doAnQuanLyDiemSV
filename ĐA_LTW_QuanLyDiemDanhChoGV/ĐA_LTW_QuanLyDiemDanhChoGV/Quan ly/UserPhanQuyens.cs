//using BUS;
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
//    public partial class UserPhanQuyens : UserControl
//    {
//        TaiKhoanGVBUS _taiKhoanGVBUS = new TaiKhoanGVBUS();
//        PhanQuyenTKBUS _phanQuyenTaiKhoanBUS = new PhanQuyenTKBUS();
//        public UserPhanQuyens()
//        {
//            InitializeComponent();
//            LoadDSTK();
//        }


//        public void LoadDSTK()
//        {

//            dgvPhanQuyen.DataSource = _phanQuyenTaiKhoanBUS.DSQLTaiKhoan();
//        }
//        private void UserPhanQuyen_Load(object sender, EventArgs e)
//        {
//            LoadDSTK();
//        }

//        public void Rs()
//        {
//            txtTaiKhoan.Text = string.Empty;
//            txtGhiChu.Text = string.Empty;
//            radAdmin.Checked = true;
//            cboTimKiem.SelectedIndex = 0;
//        }
//        private void groupBox2_Enter(object sender, EventArgs e)
//        {

//        }

//        private void dgvPhanQuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {

//        }

//        private void btnCapQuyen_Click(object sender, EventArgs e)
//        {
//            if (!string.IsNullOrEmpty(txtTaiKhoan.Text.Trim()))
//            {


//                    TaiKhoanGVDTO tk = new TaiKhoanGVDTO();
//                    {
//                        tk.TAIKHOAN = txtTaiKhoan.Text.Trim();
//                        tk.GHICHU = txtGhiChu.Text.Trim();
//                        tk.LOAITAIKHOAN = Int32.Parse(lblLTK.Text.Trim());
//                        tk.TRANGTHAI = false;

//                    }
//                    if (_phanQuyenTaiKhoanBUS.KT(txtTaiKhoan.Text.Trim()) == false)
//                    {

//                            if (_phanQuyenTaiKhoanBUS.CapQuyenTK(tk) == true)
//                            {
//                                MessageBox.Show(Constant.ThemTC, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
//                                LoadDSTK();
//                                Rs();
//                                return;
//                            }
//                            else
//                            {
//                                MessageBox.Show(Constant.ThemTB, Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                                txtTaiKhoan.Focus();
//                                return;
//                            }

//                    }
//                    else
//                    {
//                        MessageBox.Show("Tài khoản đã tồn tại", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                        txtTaiKhoan.Focus();
//                        return;
//                    }
//            }
//            else
//            {
//                MessageBox.Show("Vui lòng nhập tài khoản", Constant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
//                txtTaiKhoan.Focus();
//                return;
//            }
//        }

//        private void btnLamMoi_Click(object sender, EventArgs e)
//        {
//            Rs();
//        }

//        private void btnTimKiemTK_Click(object sender, EventArgs e)
//        {
//            if(cboTimKiem.SelectedIndex==0)
//            {
//                dgvPhanQuyen.DataSource = _taiKhoanGVBUS.DSTaiKhoanGV_TaiKhoan(txtTaiKhoan.Text.Trim());
//            }
//            else
//            {
//                dgvPhanQuyen.DataSource = _taiKhoanGVBUS.DSDSTaiKhoanGV_GhiChu(txtGhiChu.Text.Trim());
//            }    
//        }
//    }
//}
