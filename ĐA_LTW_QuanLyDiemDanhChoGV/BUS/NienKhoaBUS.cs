using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    
    public class NienKhoaBUS
    {
        NienKhoaDAO _nienKhoaDAO = new NienKhoaDAO();

        public List<NienKhoaDTO> DSNienKhoa()
        {
            return _nienKhoaDAO.DSNienKhoa();
        }
        public bool ThemNienKhoa(NienKhoaDTO newDT)
        {
            return _nienKhoaDAO.ThemNienKhoa(newDT);
        }
        public bool SuaNienKhoa(NienKhoaDTO newDT)
        {
            return _nienKhoaDAO.SuaNienKhoa(newDT);
        }
        public bool XoaNienKhoa(NienKhoaDTO newDT)
        {
            return _nienKhoaDAO.XoaNienkhoa(newDT);
        }
        public bool KTNienKhoa(string newDT)
        {
            return _nienKhoaDAO.KTNienKhoa(newDT);
        }
        public bool KTNienKhoaDaXoa(string newDT)
        {
            return _nienKhoaDAO.KTDaXoa(newDT);
        }
        public bool ThemNienKhoaDaXoa(NienKhoaDTO newDT)
        {
            return _nienKhoaDAO.ThemDaXoa(newDT);
        }

        public List<NienKhoaDTO>DSNienKhoa_MaNienKhoa(string newDT)
        {
            return _nienKhoaDAO.DSNienKhoa_MaNienKhoa(newDT);
        }
        public List<NienKhoaDTO>DSNienKhoa_TenNienKhoa(string newDT)
        {
            return _nienKhoaDAO.DSNienKhoa_TenNienKhoa(newDT);
        }
        public List<NienKhoaDTO>DSNienKhoa_GhiChu(string newDT)
        {
            return _nienKhoaDAO.DSNienKhoa_GhiChu(newDT);
        }

    }
}
