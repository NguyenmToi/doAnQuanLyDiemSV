using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    
    public class HocKyBUS
    {
        HocKyDAO _HocKyDAO = new HocKyDAO();
        public List<HocKYDTO> DSHocKy()
        {
            return _HocKyDAO.DSHocKY();
        }

        public bool ThemHocKy(HocKYDTO newHK)
        {
            return _HocKyDAO.ThemHK(newHK);
        }

        public bool SuaHK(HocKYDTO newHK)
        {
            return _HocKyDAO.SuaHK(newHK);
        }

        public bool ThemHKDaXoa(HocKYDTO newHK)
        {
            return _HocKyDAO.ThemHKDaXoa(newHK);
        }

        public bool KTHKDaXoa(string newHK)
        {
            return _HocKyDAO.KTHKDaXoa(newHK);
        }

        public bool XoaHK(HocKYDTO newHK)
        {
            return _HocKyDAO.XoaHK(newHK);
        }
        public List<HocKYDTO> DSHOCKY_MaHocKy(string MaHocKy)
        {
            return _HocKyDAO.TK_HOCKY_MaHocKy(MaHocKy);
        }

        public List<HocKYDTO> DSHOCKY_TenHocKy(string TenHocKy)
        {
            return _HocKyDAO.TK_HOCKY_TenHocKy(TenHocKy);
        }

        public List<HocKYDTO> DSHOCKY_GhiChu(string GhiChu)
        {
            return _HocKyDAO.TK_KHOA_GhiChu(GhiChu);
        }
        public bool KTHocKy(HocKYDTO newHocKy)
        {
            return _HocKyDAO.KT(newHocKy);
        }
    }
}
