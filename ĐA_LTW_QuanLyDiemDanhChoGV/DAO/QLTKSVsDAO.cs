using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class QLTKSVsDAO
    {

        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();

        public List<TaiKhoanSVDTO> DSTaiKhoanSV()
        {
            return DB.TAIKHOANSVs.Where(u => u.TRANGTHAI == false).Select(u => new TaiKhoanSVDTO
            {
                TAIKHOAN = u.TAIKHOAN,
                MATKHAU = u.MATKHAU,
                GHICHU = u.GHICHU,
            }).ToList();
        }

        public bool ThemTaiKhoan(TaiKhoanSVDTO newDT)

        {

            try
            {
                TAIKHOANSV tk = new TAIKHOANSV
                {
                    TAIKHOAN = newDT.TAIKHOAN,
                    MATKHAU = newDT.MATKHAU,
                    GHICHU = newDT.GHICHU,
                    TRANGTHAI = false
                };
                DB.TAIKHOANSVs.Add(tk);
                DB.SaveChanges();
                return true;
            }
            catch { return false; }

        }

        public bool SuaTaiKhoan(TaiKhoanSVDTO newDT)
        {
            try
            {
                TAIKHOANSV tk = DB.TAIKHOANSVs.SingleOrDefault(u => u.TAIKHOAN == newDT.TAIKHOAN && u.TRANGTHAI == false);
                {
                    tk.TAIKHOAN = newDT.TAIKHOAN;
                    tk.MATKHAU = newDT.MATKHAU;
                    tk.GHICHU = newDT.GHICHU;
                    tk.TRANGTHAI = false;
                }
                DB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool QuenMatKhau(TaiKhoanSVDTO newDT)
        {
            try
            {
                TAIKHOANSV tk = DB.TAIKHOANSVs.SingleOrDefault(u => u.TAIKHOAN == newDT.TAIKHOAN && u.TRANGTHAI == false);
                {
                    tk.GHICHU = newDT.GHICHU;
                    tk.TRANGTHAI = false;
                }
                DB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool KhoiPhucTaiKhoan(TaiKhoanSVDTO newDT)
        {
            try
            {
                TAIKHOANSV tk = DB.TAIKHOANSVs.SingleOrDefault(u => u.TAIKHOAN == newDT.TAIKHOAN && u.TRANGTHAI == true);
                {
                    tk.TAIKHOAN = newDT.TAIKHOAN;
                    tk.MATKHAU = newDT.MATKHAU;
                    tk.GHICHU = newDT.GHICHU;
                    tk.TRANGTHAI = false;
                }
                DB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool XoaTaiKhoan(TaiKhoanSVDTO newDT)
        {
            try
            {
                TAIKHOANSV tk = DB.TAIKHOANSVs.SingleOrDefault(u => u.TAIKHOAN == newDT.TAIKHOAN && u.TRANGTHAI == false);
                {
                    tk.TRANGTHAI = true;
                }
                DB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool KT(string newDT)
        {

            try
            {
                TAIKHOANSV tk = DB.TAIKHOANSVs.SingleOrDefault(u => u.TAIKHOAN == newDT && u.TRANGTHAI == false);
                if (tk == null) return false;
                else return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool KTTK(string newDT)
        {

            try
            {
                TAIKHOANSV tk = DB.TAIKHOANSVs.SingleOrDefault(u => u.TAIKHOAN == newDT && u.TRANGTHAI == false);
                if (tk == null) return false;
                else return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool KTMK(string newDT)
        {

            try
            {
                TAIKHOANSV tk = DB.TAIKHOANSVs.SingleOrDefault(u => u.MATKHAU == newDT && u.TRANGTHAI == false);
                if (tk == null) return false;
                else return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool KTTK1(string newDT, string newDT2)
        {

            try
            {
                TAIKHOANSV tk = DB.TAIKHOANSVs.SingleOrDefault(u=>u.TAIKHOAN==newDT&& u.MATKHAU==newDT2);
                if (tk == null) return false;
                else return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public bool KTKhoiPhuc(string newDT)
        {

            try
            {
                TAIKHOANSV tk = DB.TAIKHOANSVs.SingleOrDefault(u => u.TAIKHOAN == newDT && u.TRANGTHAI == true);
                if (tk == null) return false;
                else return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool KTMaSV(string newDT)
        {
            try
            {
                SINHVIEN gv = DB.SINHVIENs.SingleOrDefault(u => u.MSSV == newDT);
                if (gv == null) return false;
                else return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }

        public List<TaiKhoanSVDTO> DSTaiKhoanSV_TaiKhoan(string newDT)
        {
            return DB.TAIKHOANSVs.Where(u => u.TAIKHOAN.Contains(newDT) && u.TRANGTHAI == false).Select(p => new TaiKhoanSVDTO()
            {
                TAIKHOAN = p.TAIKHOAN,
                MATKHAU = p.MATKHAU,
                GHICHU = p.GHICHU,
            }).ToList();
        }

        public List<TaiKhoanSVDTO> DSTaiKhoanSV_GhiChu(string newDT)
        {
            return DB.TAIKHOANSVs.Where(u => u.GHICHU.Contains(newDT) && u.TRANGTHAI == false).Select(p => new TaiKhoanSVDTO()
            {
                TAIKHOAN = p.TAIKHOAN,
                MATKHAU = p.MATKHAU,
                GHICHU = p.GHICHU,
            }).ToList();
        }
    }
}
