using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class QLCapQuyenDAO
    {

        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();

        public List<TaiKhoanGVDTO> DSQLTaiKhoanGV()
        {
            return DB.TAIKHOANGVs.Where(u => u.TRANGTHAI == false).Select(u => new TaiKhoanGVDTO
            {
                TAIKHOAN = u.TAIKHOAN,
                LOAITAIKHOAN = u.LOAITAIKHOAN == null ? 1 : u.LOAITAIKHOAN,
                TENLOAITAIKHOAN = u.LOAITAIKHOAN1.TENLOAITAIKHOAN,
                TRANGTHAI = false,
                GHICHU = u.GHICHU,

            }).ToList();
        }

        public bool KT(string newDT)
        {

            try
            {
                TAIKHOANGV tk = DB.TAIKHOANGVs.SingleOrDefault(u => u.TAIKHOAN == newDT && u.TRANGTHAI == false);
                if (tk == null) return false;
                else return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool CapQuyenTaiKhoan(TaiKhoanGVDTO newDT)
        {
            try
            {
                TAIKHOANGV gv = DB.TAIKHOANGVs.SingleOrDefault(u => u.TAIKHOAN == newDT.TAIKHOAN && u.TRANGTHAI == false);
                {
                    gv.LOAITAIKHOAN = newDT.LOAITAIKHOAN;
                }
                DB.SaveChanges();
                return true;
            }
            catch (Exception ex) { return false; }
        }

        public List<TaiKhoanGVDTO> DSTaiKhoanGV_TaiKhoan(string newDT)
        {
            return DB.TAIKHOANGVs.Where(u => u.TAIKHOAN.Contains(newDT) && u.TRANGTHAI == false).Select(p => new TaiKhoanGVDTO()
            {
                TAIKHOAN = p.TAIKHOAN,
                MATKHAU = p.MATKHAU,
                GHICHU = p.GHICHU,
            }).ToList();
        }

        public List<TaiKhoanGVDTO> DSTaiKhoanGV_GhiChu(string newDT)
        {
            return DB.TAIKHOANGVs.Where(u => u.GHICHU.Contains(newDT) && u.TRANGTHAI == false).Select(p => new TaiKhoanGVDTO()
            {
                TAIKHOAN = p.TAIKHOAN,
                MATKHAU = p.MATKHAU,
                GHICHU = p.GHICHU,
            }).ToList();
        }
        public List<TaiKhoanGVDTO> DSTaiKhoanGV_LoaiTaiKhoan(int newDT)
        {
            return DB.TAIKHOANGVs.Where(u => u.LOAITAIKHOAN==newDT && u.TRANGTHAI == false).Select(p => new TaiKhoanGVDTO()
            {
                TAIKHOAN = p.TAIKHOAN,
                MATKHAU = p.MATKHAU,
                GHICHU = p.GHICHU,
            }).ToList();
        }

    }
}
