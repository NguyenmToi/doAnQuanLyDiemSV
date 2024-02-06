using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    
    public class KhoaBUS
    {
        KhoaDAO _KhoaDAO = new KhoaDAO();
        public List<KhoaDTO> DSKhoa()
        {
            return _KhoaDAO.DSKhoa();
        }
        public bool KTKhoa(KhoaDTO newKhoa)
        {
            return _KhoaDAO.KT(newKhoa);
        }
        public bool ThemKhoa(KhoaDTO newKhoa)
        {
            return _KhoaDAO.ThemKhoa(newKhoa);
        }
        public bool XoaKhoa(KhoaDTO newKhoa)
        {
            return _KhoaDAO.XoaKhoa(newKhoa);
        }
        public bool SuaKhoa(KhoaDTO newKhoa)
        {
            return _KhoaDAO.SuaKhoa(newKhoa);
        }
        public bool KTKhoaDaXoa(string newKhoa)
        {
            return _KhoaDAO.KTKhoaDaXoa(newKhoa);
        }
        public bool ThemKhoaDaXoa(KhoaDTO newKhoa)
        {
            return _KhoaDAO.ThemKhoaDaXoa(newKhoa);
        }

        public List<KhoaDTO> DSKHOA_MaKhoa(string MaKhoa)
        {
            return _KhoaDAO.TK_KHOA_MaKhoa(MaKhoa);
        }

        public List<KhoaDTO> DSKHOA_TenKhoa(string TenKhoa)
        {
            return _KhoaDAO.TK_KHOA_TenKhoa(TenKhoa);
        }

        public List<KhoaDTO> DSKHOA_GhiChu(string GhiChu)
        {
            return _KhoaDAO.TK_KHOA_GhiChu(GhiChu);
        }
    }
}
