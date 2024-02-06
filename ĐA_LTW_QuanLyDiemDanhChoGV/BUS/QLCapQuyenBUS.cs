using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QLCapQuyenBUS
    {
        QLCapQuyenDAO _phanQuyenTKDAO = new QLCapQuyenDAO();
        public List<TaiKhoanGVDTO> DSQLTaiKhoan()
        {
            return _phanQuyenTKDAO.DSQLTaiKhoanGV();
        }

        public bool CapQuyenTK(TaiKhoanGVDTO newDT)
        {
            return _phanQuyenTKDAO.CapQuyenTaiKhoan(newDT);
        }

        public bool KT(String newDT)
        {
            return _phanQuyenTKDAO.KT(newDT);
        }


        public List<TaiKhoanGVDTO> DSTaiKhoanSV_TaiKhoan(string newDT)
        {
            return _phanQuyenTKDAO.DSTaiKhoanGV_TaiKhoan(newDT);
        }

        public List<TaiKhoanGVDTO> DSTaiKhoanSV_GhiChu(string newDT)
        {
            return _phanQuyenTKDAO.DSTaiKhoanGV_GhiChu(newDT);
        }


        public List<TaiKhoanGVDTO> DSTaiKhoanSV_LoaiTaiKhoan(int newDT)
        {
            return _phanQuyenTKDAO.DSTaiKhoanGV_LoaiTaiKhoan(newDT);
        }
    }
}
