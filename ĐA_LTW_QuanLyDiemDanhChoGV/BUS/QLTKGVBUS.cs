using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QLTKGVBUS
    {

        QLTKGVsDAO _taiKhoanGVDAO = new QLTKGVsDAO();
        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();

        public List<TaiKhoanGVDTO> DSTaiKhoanGV()
        {
            return _taiKhoanGVDAO.DSTaiKhoanGV();
        }

        public bool QuenMatKhau(TaiKhoanGVDTO newDT)
        {
            return _taiKhoanGVDAO.QuenMatKhau(newDT);
        }


        public bool ThemTaiKhoan(TaiKhoanGVDTO newDT)
        {
            return _taiKhoanGVDAO.ThemTaiKhoan(newDT);
        }
        public bool SuaTaiKhoan(TaiKhoanGVDTO newDT)
        {
            return _taiKhoanGVDAO.SuaTaiKhoan(newDT);
        }

        public bool XoaTaiKhoan(TaiKhoanGVDTO newDT)
        {
            return _taiKhoanGVDAO.XoaTaiKhoan(newDT);
        }

        public bool KTMaGV(string newDT)
        {
            return _taiKhoanGVDAO.KTMaGV(newDT);
        }

        public bool TenGV(GiangVienDTO newDT)
        {
            return _taiKhoanGVDAO.TenGV(newDT);
        }

        public bool XoaLoaiTaiKhoan(TaiKhoanGVDTO newDT)
        {
            return _taiKhoanGVDAO.XoaTaiKhoan(newDT);
        }

        public List<TaiKhoanGVDTO> DSTaiKhoan_TaiKhoan(string newDT)
        {
            return _taiKhoanGVDAO.DSTaiKhoanGV_TaiKhoan(newDT);
        }

        public List<TaiKhoanGVDTO> DSTaiKhoan_GhiChu(string newDT)
        {
            return _taiKhoanGVDAO.DSTaiKhoanGV_GhiChu(newDT);
        }

        public bool KT(string newDT)
        {
            return _taiKhoanGVDAO.KT(newDT);
        }

        public bool KTTK(string newDT)
        {
            return _taiKhoanGVDAO.KTTK(newDT);
        }

        public bool KTTK1(string newDT, string newDT2)
        {
            return _taiKhoanGVDAO.KTTK1(newDT,newDT2);
        }
        public bool KTMK(string newDT)
        {
            return _taiKhoanGVDAO.KTMK(newDT);
        }
        public bool KTKhoiPhuc(string newDT)
        {
            return _taiKhoanGVDAO.KTKhoiPhuc(newDT);
        }

        public bool KhoiPhucTaiKhoan(TaiKhoanGVDTO newDT)
        {
            return _taiKhoanGVDAO.KhoiPhucTaiKhoan(newDT);
        }

        public List<TaiKhoanGVDTO> DSTaiKhoanGV_TaiKhoan(string newDT)
        {
            return _taiKhoanGVDAO.DSTaiKhoanGV_TaiKhoan(newDT);
        }

        public List<TaiKhoanGVDTO> DSDSTaiKhoanGV_GhiChu(string newDT)
        {
            return _taiKhoanGVDAO.DSTaiKhoanGV_GhiChu(newDT);
        }
        public List<TaiKhoanGVDTO> DSDSTaiKhoanGV_LTK(int newDT)
        {
            return _taiKhoanGVDAO.DSTaiKhoanGV_LTK(newDT);
        }

        public bool DoiMatKhau(TaiKhoanGVDTO newDT)
        {
            return _taiKhoanGVDAO.DoiMatKhau(newDT);
        }

        public bool KTMKCu(string newDT,string newDT2)
        {
            return _taiKhoanGVDAO.KTMKCu(newDT,newDT2);
        }

        public string LayMaLoaiTaiKhoan(string newDT)
        {
            return _taiKhoanGVDAO.LayMaLoaiTaiKhoan(newDT);
        }
    }
}
