using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LopBUS
    {
        LopDAO _LopDAO = new LopDAO();
        public List<LopDTO> DSLOP()
        {
            return _LopDAO.DSLop();
        }

        public bool ThemLop(LopDTO newDT)
        {
            return _LopDAO.ThemLop(newDT);
        }
        public bool ThemLopDaXoa(LopDTO newDT)
        {
            return _LopDAO.ThemLopDaXoa(newDT);
        }

        public bool SuaLop(LopDTO newDT)
        {
            return _LopDAO.SuaLop(newDT);
        }
        public bool XoaLop(LopDTO newDT)
        {
            return _LopDAO.XoaLop(newDT);
        }

        public List<LopDTO> DSLOP_MaLop(string MaLop)
        {
            return _LopDAO.TK_LOP_MaLop(MaLop);
        }

        public List<LopDTO> DSLOP_TenLop(string TenLop)
        {
            return _LopDAO.TK_LOP_TenLop(TenLop);
        }
        public bool KTLop(LopDTO newDT)
        {
            return _LopDAO.KT(newDT);
        }

        public List<LopDTO> DSLOP_MaNganh(string MaNganh)
        {
            return _LopDAO.TK_LOP_MaNganh(MaNganh);
        }

        public List<LopDTO> DSLOP_TenNganh(string TenNganh)
        {
            return _LopDAO.TK_LOP_TenNganh(TenNganh);
        }

        public List<LopDTO> DSLOP_MaNienKhoa(string MaNienKhoa)
        {
            return _LopDAO.TK_LOP_MaNienKhoa(MaNienKhoa);
        }

        public List<LopDTO> DSLOP_TenNienKhoa(string TenNienKhoa)
        {
            return _LopDAO.TK_LOP_TenNienKhoa(TenNienKhoa);
        }

        public List<LopDTO> DSLOP_GhiChu(string GhiChu)
        {
            return _LopDAO.TK_LOP_GhiChu(GhiChu);
        }

        public bool KTLOPDaXoa(string newDT)
        {
            return _LopDAO.KTLOPDaXoa(newDT);
        }


    }
}
