

using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LopDAO
    {
        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();
        public List<LopDTO> DSLop()
        {
            return DB.LOPs.Where(u => u.TRANGTHAI == false).Select(u => new LopDTO
            {
                MALOP = u.MALOP,
                TENLOP = u.TENLOP,
                MANGANH = u.MANGANH,
                MANIENKHOA = u.MANIENKHOA,
                TENNGANH = u.NGANH.TENNGANH,
                TENNIENKHOA = u.NIENKHOA.TENNIENKHOA,
                GHICHU = u.GHICHU,

            }).ToList();

        }


        public bool ThemLop(LopDTO NewDT)
        {
            LOP Lop = new LOP
            {
                MALOP = NewDT.MALOP,
                TENLOP = NewDT.TENLOP,
                TRANGTHAI = NewDT.TRANGTHAI,
                MANGANH = NewDT.MANGANH,
                MANIENKHOA = NewDT.MANIENKHOA,
                GHICHU = NewDT.GHICHU
            };
            DB.LOPs.Add(Lop);
            DB.SaveChanges();
            return true;
        }

        public bool XoaLop(LopDTO newDT)
        {
            LOP lop = DB.LOPs.SingleOrDefault(u => u.MALOP == newDT.MALOP &&u.TRANGTHAI==false);
            lop.TRANGTHAI = true;

            DB.SaveChanges();
            return true;
        }

        public bool SuaLop(LopDTO newDT)
        {
            try
            {
                LOP lop = DB.LOPs.SingleOrDefault(u => u.MALOP == newDT.MALOP&& u.TRANGTHAI==false);
                {
                    lop.MALOP = newDT.MALOP;
                    lop.TENLOP = newDT.TENLOP;
                    lop.TRANGTHAI = false;
                    lop.MANGANH = newDT.MANGANH;
                    lop.MANIENKHOA = newDT.MANIENKHOA;
                    lop.GHICHU = newDT.GHICHU;

                }
                DB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ThemLopDaXoa(LopDTO newDT)
        {
            try
            {
                LOP lop = DB.LOPs.SingleOrDefault(u => u.MALOP == newDT.MALOP && u.TRANGTHAI == true);
                {
                    lop.MALOP = newDT.MALOP;
                    lop.TENLOP = newDT.TENLOP;
                    lop.TRANGTHAI = false;
                    lop.MANGANH = newDT.MANGANH;
                    lop.MANIENKHOA = newDT.MANIENKHOA;
                    lop.GHICHU = newDT.GHICHU;

                }
                DB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool KT(LopDTO newDT)
        {
            try
            {
                LOP lop = DB.LOPs.SingleOrDefault(u => u.MALOP == newDT.MALOP && u.TRANGTHAI == false);
                if (lop == null) return false;
                else return true;
            }
            catch (Exception ex) { return false; }
        }

        public bool KTLOPDaXoa(string newDT)
        {
            try
            {
                LOP lop = DB.LOPs.SingleOrDefault(u => u.MALOP == newDT && u.TRANGTHAI == true);
                if (lop == null) return false;
                else return true;
            }
            catch (Exception ex) { return false; }
        }

        public List<LopDTO> TK_LOP_MaLop(string MaLop)
        {
            return DB.LOPs.Where(u => u.MALOP.Contains(MaLop) && u.TRANGTHAI == false).Select(p => new LopDTO
            {
                MALOP = p.MALOP,
                TENLOP = p.TENLOP,
                MANGANH = p.MANGANH,
                MANIENKHOA = p.MANIENKHOA,
                TENNGANH = p.NGANH.TENNGANH,
                TENNIENKHOA = p.NIENKHOA.TENNIENKHOA,
                GHICHU = p.GHICHU

            }).ToList();
        }
        public List<LopDTO> TK_LOP_TenLop(string TenLop)
        {
            return DB.LOPs.Where(u => u.TENLOP.Contains(TenLop) && u.TRANGTHAI == false).Select(p => new LopDTO
            {
                MALOP = p.MALOP,
                TENLOP = p.TENLOP,
                MANGANH = p.MANGANH,
                MANIENKHOA = p.MANIENKHOA,
                TENNGANH = p.NGANH.TENNGANH,
                TENNIENKHOA = p.NIENKHOA.TENNIENKHOA,
                GHICHU = p.GHICHU
            }).ToList();
        }
        public List<LopDTO> TK_LOP_MaNganh(string MaNganh)
        {
            return DB.LOPs.Where(u => u.MANGANH.Contains(MaNganh) && u.TRANGTHAI == false).Select(p => new LopDTO
            {
                MALOP = p.MALOP,
                TENLOP = p.TENLOP,
                MANGANH = p.MANGANH,
                MANIENKHOA = p.MANIENKHOA,
                TENNGANH = p.NGANH.TENNGANH,
                TENNIENKHOA = p.NIENKHOA.TENNIENKHOA,
                GHICHU = p.GHICHU
            }).ToList();
        }

        public List<LopDTO> TK_LOP_TenNganh(string TenNganh)
        {
            return DB.LOPs.Where(u => u.NGANH.TENNGANH.Contains(TenNganh) && u.TRANGTHAI == false).Select(p => new LopDTO
            {
                MALOP = p.MALOP,
                TENLOP = p.TENLOP,
                MANGANH = p.MANGANH,
                MANIENKHOA = p.MANIENKHOA,
                TENNGANH = p.NGANH.TENNGANH,
                TENNIENKHOA = p.NIENKHOA.TENNIENKHOA,
                GHICHU = p.GHICHU

            }).ToList();
        }
        public List<LopDTO> TK_LOP_MaNienKhoa(string MaNienKhoa)
        {
            return DB.LOPs.Where(u => u.MANIENKHOA.Contains(MaNienKhoa) && u.TRANGTHAI == false).Select(p => new LopDTO
            {
                MALOP = p.MALOP,
                TENLOP = p.TENLOP,
                MANGANH = p.MANGANH,
                MANIENKHOA = p.MANIENKHOA,
                TENNGANH = p.NGANH.TENNGANH,
                TENNIENKHOA = p.NIENKHOA.TENNIENKHOA,
                GHICHU = p.GHICHU
            }).ToList();
        }

        public List<LopDTO> TK_LOP_TenNienKhoa(string TenNienKhoa)
        {
            return DB.LOPs.Where(u => u.NIENKHOA.TENNIENKHOA.Contains(TenNienKhoa) && u.TRANGTHAI == false).Select(p => new LopDTO
            {
                MALOP = p.MALOP,
                TENLOP = p.TENLOP,
                MANGANH = p.MANGANH,
                MANIENKHOA = p.MANIENKHOA,
                TENNGANH = p.NGANH.TENNGANH,
                TENNIENKHOA = p.NIENKHOA.TENNIENKHOA,
                GHICHU = p.GHICHU
            }).ToList();
        }

        public List<LopDTO> TK_LOP_GhiChu(string GhiChu)
        {
            return DB.LOPs.Where(u => u.GHICHU.Contains(GhiChu) && u.TRANGTHAI == false).Select(p => new LopDTO
            {
                MALOP = p.MALOP,
                TENLOP = p.TENLOP,
                MANGANH = p.MANGANH,
                MANIENKHOA = p.MANIENKHOA,
                TENNGANH = p.NGANH.TENNGANH,
                TENNIENKHOA = p.NIENKHOA.TENNIENKHOA,
                GHICHU = p.GHICHU
            }).ToList();
        }
    }
}
