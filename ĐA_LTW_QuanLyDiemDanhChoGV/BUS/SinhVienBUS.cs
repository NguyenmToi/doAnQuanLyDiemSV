using DAO;
using DTO;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SinhVienBUS
    {
        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();
        SinhVienDAO _sinhVienDAO = new SinhVienDAO();

        public List<SinhVienDTO> DSSinhVien()
        {
            return _sinhVienDAO.DSSinhVien();
        }
        public bool ThemSinhVien(SinhVienDTO newDT)
        {
            return _sinhVienDAO.ThemSinhVien(newDT);
        }
        public bool SuaSinhVien(SinhVienDTO newDT)
        {
            return _sinhVienDAO.SuaSV(newDT);
        }

        public bool KTSV(SinhVienDTO newDT)
        {
            return _sinhVienDAO.KTSV(newDT);
        }

        public bool KTLop(string newDT)
        {
            return _sinhVienDAO.KTLop(newDT);
        }
        public bool KTNganh(string newDT)
        {
            return _sinhVienDAO.KTNganh(newDT);
        }
        public bool KTNienKhoa(string newDT)
        {
            return _sinhVienDAO.KTNienKhoa(newDT);
        }

        public bool KTEmail(string newDT)
        {
            return _sinhVienDAO.KTEmail(newDT);
        }

        public bool XoaSV(string newDT)
        {
            return _sinhVienDAO.XoaSV(newDT);
        }

        public bool KTNgaySinh(string newDT)
        {
            return _sinhVienDAO.KTNgaySinh(newDT);
        }

        public bool KTSVDaXoa(string newDT)
        {
            return _sinhVienDAO.KTSVDaXoa(newDT);
        }
        public bool ThemSVDaXoa(SinhVienDTO newDT)
        {
            return _sinhVienDAO.KhoiPhucSVDaXoa(newDT);
        }

        public List<SinhVienDTO> DSSinhVien_MSSV(string newDT)
        {
            return _sinhVienDAO.DSSV_MaSV(newDT);
        }
        public List<SinhVienDTO> DSSinhVien_HoTen(string newDT)
        {
            return _sinhVienDAO.DSSV_HoTenSV(newDT);
        }
        public List<SinhVienDTO> DSSinhVien_CCCD(string newDT)
        {
            return _sinhVienDAO.DSSV_CCCD(newDT);
        }
        public List<SinhVienDTO> DSSinhVien_Email(string newDT)
        {
            return _sinhVienDAO.DSSV_Email(newDT);
        }
        public List<SinhVienDTO> DSSinhVien_Lop(string newDT)
        {
            return _sinhVienDAO.DSSV_Lop(newDT);
        }
        public List<SinhVienDTO> DSSinhVien_Nganh(string newDT)
        {
            return _sinhVienDAO.DSSV_Nganh(newDT);
        }
        public List<SinhVienDTO> DSSinhVien_NienKhoa(string newDT)
        {
            return _sinhVienDAO.DSSV_NienKhoa(newDT);
        }
        public List<SinhVienDTO> DSSinhVien_DiaChi(string newDT)
        {
            return _sinhVienDAO.DSSV_DiaChi(newDT);
        }
        public List<SinhVienDTO> DSSinhVien_DanToc(string newDT)
        {
            return _sinhVienDAO.DSSV_DanToc(newDT);
        }
        public List<SinhVienDTO> DSSinhVien_GhiChu(string newDT)
        {
            return _sinhVienDAO.DSSV_GhiChu(newDT);
        }


    }
}
