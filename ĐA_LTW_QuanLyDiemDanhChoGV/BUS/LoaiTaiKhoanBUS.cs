using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoaiTaiKhoanBUS
    {
        LoaiTaiKhoanDAO _loaiTaiKhoanDAO = new LoaiTaiKhoanDAO();
        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();

        public List<LoaiTaiKhoanDTO>DSLoaiTaiKhoan()
        {
            return _loaiTaiKhoanDAO.DSLOAITAIKHOAN();
        }

        public bool ThemLoaiTaiKhoan(LoaiTaiKhoanDTO newDT)
        {
            return _loaiTaiKhoanDAO.ThemLoaiTaiKhoan(newDT);
        }
        public bool SuaLoaiTaiKhoan(LoaiTaiKhoanDTO newDT)
        {
            return _loaiTaiKhoanDAO.SuaLoaiTaiKhoan(newDT);
        }

        public bool XoaLoaiTaiKhoan(LoaiTaiKhoanDTO newDT)
        {
            return _loaiTaiKhoanDAO.XoaLoaiTaiKhoan(newDT);
        }

        public List<LoaiTaiKhoanDTO>DSLoaiTaiKhoan_MaLoaiTaiKhoan(int newDT)
        {
            return _loaiTaiKhoanDAO.DSLoaiTaiKhoan_MaLoaiTaiKhoan(newDT);
        }

        public List<LoaiTaiKhoanDTO> DSLoaiTaiKhoan_TenLoaiTaiKhoan(string newDT)
        {
            return _loaiTaiKhoanDAO.DSLoaiTaiKhoan_TenLoaiTaiKhoan(newDT);
        }

        public List<LoaiTaiKhoanDTO> DSLoaiTaiKhoan_GhiChu(string newDT)
        {
            return _loaiTaiKhoanDAO.DSLoaiTaiKhoan_GhiChu(newDT);
        }

        public bool KT(int newDT)
        {
            return _loaiTaiKhoanDAO.KT(newDT);
        }

        public  bool KTLTKDaXoa(int newDT)
        {
            return _loaiTaiKhoanDAO.KTLTKDaXoa(newDT);
        }

        public bool ThemLTKDaXoa(LoaiTaiKhoanDTO
            newDT)
        {
            return _loaiTaiKhoanDAO.ThemLTKDaXoa(newDT);
        }


    }
}
