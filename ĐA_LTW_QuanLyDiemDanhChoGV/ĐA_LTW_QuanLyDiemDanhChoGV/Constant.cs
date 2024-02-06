using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐA_LTW_QuanLyDiemDanhChoGV
{
    public class Constant
    {
        public static string HOCKY_MaHocKy = "colHOCKY_MaHocKy";
        public static string HOCKY_TenHocKy = "colHOCKY_TenHocKy";
        public static string HOCKY_GhiChu = "colHOCKY_GhiChu";

        public static string KHOA_MaKhoa = "colKHOA_MaKhoa";
        public static string KHOA_TenKhoa = "colKHOA_TenKhoa";
        public static string KHOA_GhiChu = "colKHOA_GhiChu";

        public static string LOP_MaLop = "colLOP_MaLop";
        public static string LOP_TenLop = "colLOP_TenLop";
        public static string LOP_MaNganh = "colLOP_MaNganh";
        public static string LOP_TenNganh = "colLOP_TenNganh";
        public static string LOP_MaNienKhoa = "colLOP_MaNienKhoa";
        public static string LOP_TenNienKhoa = "colLOP_TenNienKhoa";
        public static string LOP_GhiChu = "colLOP_GhiChu";

        public static string NIENKHOA_MaNienKhoa = "colNIENKHOA_MaNienKhoa";
        public static string NIENKHOA_TenNienKhoa = "colNIENKHOA_TenNienKhoa";
        public static string NIENKHOA_GhiChu = "colNIENKHOA_GhiChu";

        public static string NGANH_MaNganh = "colNGANH_MaNganh";
        public static string NGANH_TenNganh = "colNGANH_TenNganh";
        public static string NGANH_TenKhoa = "colNGANH_TenKhoa";
        public static string NGANH_GhiChu = "colNGANH_GhiChu";

        public static string GV_MaGV = "colGV_MaGV";
        public static string GV_HoTenGV = "colGV_HoTenGV";
        public static string GV_Khoa = "colGV_Khoa";
        public static string GV_GhiChu = "colGV_GhiChu";
        public static string GV_GioiTinh = "colGV_GT";
        public static string GV_TenGioiTinh = "colGV_TenGT";

        public static string SV_MSSV = "colSV_MSSV";
        public static string SV_HoTen = "colSV_HoTen";
        public static string SV_GIOITINH = "colSV_GT";
        public static string SV_DanToc = "colSV_DanToc";
        public static string SV_DiaChi = "colSV_DiaChi";
        public static string SV_CCCD = "colSV_CCCD";
        public static string SV_Lop = "colSV_TenLop";
        public static string SV_NgaySinh = "colSV_NgaySinh";
        public static string SV_Email = "colSV_Email";
        public static string SV_Nganh = "colSV_TenNganh";
        public static string SV_NienKhoa = "colSV_TenNienKhoa";
        public static string SV_GhiChu = "colSV_GhiChu";


        public static string MONHOC_MaMonHoc = "colMONHOC_MaMonHoc";
        public static string MONHOC_TenMonHoc = "colMONHOC_TenMonHoc";
        public static string MONHOC_SoTinChi = "colMONHOC_SoTinChi";
        public static string MONHOC_GhiChu = "colMONHOC_GhiChu";

        public static string LTK_MaLoaiTaiKhoan = "colLTK_MaLoaiTaiKhoan";
        public static string LTK_TenLoaiTaiKhoan = "colLTK_TenLoaiTaiKhoan";
        public static string LTK_GhiChu = "colLTK_GhiChu";

        public static string TKGV_TaiKhoan = "colTKGV_TK";
        public static string TKGV_MatKhau = "colTKGV_MK";
        public static string GhiChu = "GhiChu";

        public static string TKPQ_TaiKhoan = "colPQ_TaiKhoan";
        public static string TKPQ_LoaiTaiKhoan = "colPQ_LoaiTaiKhoan";
        public static string TKPQ_GhiChu = "colPQ_GhiChu";

        public static string TKSV_TaiKhoan = "colTKSV_TK";
        public static string TKSV_MatKhau = "colTKSV_MK";
        public static string TKSV_GhiChu = "GhiChu";

        public static string ThemTC = "Thêm thành công";
        public static string ThemTB = "Thêm thất bại";
        public static string XoaTC = "Xóa thành công";
        public static string XoaTB = "Xóa thất bại";
        public static string SuaTC = "Sửa thành công";
        public static string SuaTB = "Sửa thất bại";

        public static string HoiXoa = "Bạn có muốn xóa không ?";
        public static string ThongBao = "Thông báo";
        public static string DTX_KhongTonTai = "Đối tượng xóa không tồn tại";
        public static string HuyXoa = "Đã hủy xóa";
        public static string DaTonTaiMa = "Đã tồn tại mã";
        public static string MaDoiTuong_KTT = "Đối tượng không tồn tại";
        public static string nhapChuaDuThongTin = "Vui lòng nhập đầy đủ thông tin";

        public static string matKhauNhapLaiKhac = "Mật khẩu mới và nhập lại mật khẩu phải giống nhau";
        public static string doiMatKhau_TC = "Đổi mật khẩu thành công";
        public static string doiMatKhau_TB = "Đổi Mật khẩu thất bại";
        public static string toiThieuMatKhau = "Mật khẩu phải có tối thiểu 6 ký tự";
        public static string kiemTraMKCuSai = "Mật khẩu cũ sai";
        public static string EmailSaiDinhDang = "Email sai định dạng";
        public static string CCCDSai = "Căn cước công dân không hợp lệ";
        public static string NgaySinhSai = "Ngày sinh không hợp lệ"; 



    }
}
