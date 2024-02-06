using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class GiangVienBUS
    {
        GiangVienDAO _gvDAO = new GiangVienDAO();
        public List<GiangVienDTO> DSGiangVien()
        {
            return _gvDAO.DSGiangVien();
        }
        public bool ThemGV(GiangVienDTO newDT)
        {
            return _gvDAO.ThemGiangVien(newDT);
        }
        public bool SuaGV(GiangVienDTO newDT)
        {
            return _gvDAO.SuaGV(newDT);
        }
        public bool ThemGVDaXoa(GiangVienDTO newDT)
        {
            return _gvDAO.ThemGVXoa(newDT);
        }

        public bool KTGVDaXoa(GiangVienDTO newDT)
        {
            return _gvDAO.KTGVDaXoa(newDT);
        }
        public bool XoaGV(GiangVienDTO newDT)
        {
            return _gvDAO.XoaGV(newDT);
        }
        public bool KTGV(GiangVienDTO newDT)
        {
            return _gvDAO.KTGV(newDT);
        }

        public bool KTKhoa(string newDT)
        {
            return _gvDAO.KTKhoa(newDT);
        }
        public List<GiangVienDTO> DSGiangVien_MaGV(string newDT)
        {
            return _gvDAO.DSGV_MaGV(newDT);
        }
        public List<GiangVienDTO> DSGiangVien_HoTenGV(string newDT)
        {
            return _gvDAO.DSGV_HoTenGV(newDT);
        }

        public List<GiangVienDTO> DSGiangVien_Khoa(string newDT)
        {
            return _gvDAO.DSGV_KhoaGV(newDT);
        }

        public List<GiangVienDTO> DSGiangVien_GhiChu(string newDT)
        {
            return _gvDAO.DSGV_GhiChu(newDT);
        }

        public string LayTenGV(string newDT)
        {
            return _gvDAO.LayTenGiangVien(newDT);
        }

    }
}
