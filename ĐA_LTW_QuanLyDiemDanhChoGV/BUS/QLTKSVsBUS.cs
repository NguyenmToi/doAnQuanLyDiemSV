using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QLTKSVsBUS
    {
		QLTKSVsDAO _taiKhoanSVDAO = new QLTKSVsDAO();
		QL_DIEMSVEntities DB = new QL_DIEMSVEntities();

		public List<TaiKhoanSVDTO> DSTaiKhoanSV()
		{
			return _taiKhoanSVDAO.DSTaiKhoanSV();
		}

		public bool ThemTaiKhoan(TaiKhoanSVDTO newDT)
		{
			return _taiKhoanSVDAO.ThemTaiKhoan(newDT);
		}
		public bool SuaTaiKhoan(TaiKhoanSVDTO newDT)
		{
			return _taiKhoanSVDAO.SuaTaiKhoan(newDT);
		}

		public bool XoaTaiKhoan(TaiKhoanSVDTO newDT)
		{
			return _taiKhoanSVDAO.XoaTaiKhoan(newDT);
		}


		public bool KTMaSV(string newDT)
		{
			return _taiKhoanSVDAO.KTMaSV(newDT);
		}

		public bool KT(string newDT)
		{
			return _taiKhoanSVDAO.KT(newDT);
		}

        public bool KTTKMK(string newDT,string newDT2)
        {
            return _taiKhoanSVDAO.KTTK1(newDT,newDT2);
        }

        public bool KTMK(string newDT)
        {
            return _taiKhoanSVDAO.KTMK(newDT);
        }
        public bool KTKhoiPhuc(string newDT)
		{
			return _taiKhoanSVDAO.KTKhoiPhuc(newDT);
		}

        public bool QuenMatKhau(TaiKhoanSVDTO newDT)
        {
            return _taiKhoanSVDAO.QuenMatKhau(newDT);
        }
        public bool KhoiPhucTaiKhoan(TaiKhoanSVDTO newDT)
		{
			return _taiKhoanSVDAO.KhoiPhucTaiKhoan(newDT);
		}

		public List<TaiKhoanSVDTO> DSTaiKhoanSV_TaiKhoan(string newDT)
		{
			return _taiKhoanSVDAO.DSTaiKhoanSV_TaiKhoan(newDT);
		}

		public List<TaiKhoanSVDTO> DSTaiKhoanSV_GhiChu(string newDT)
		{
			return _taiKhoanSVDAO.DSTaiKhoanSV_GhiChu(newDT);
		}
	}
}
