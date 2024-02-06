using DTO;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NienKhoaDAO
    {
        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();
        public List<NienKhoaDTO> DSNienKhoa()
        {
            return DB.NIENKHOAs.Where(u=>u.TRANGTHAI==false).Select(u=> new NienKhoaDTO
            {
                MANIENKHOA = u.MANIENKHOA,
                TENNIENKHOA = u.TENNIENKHOA,
                GHICHU = u.GHICHU,
            }).ToList();
        }
        public bool ThemNienKhoa(NienKhoaDTO newDT)
        {
            NIENKHOA nienkhoa = new NIENKHOA
            {
                MANIENKHOA = newDT.MANIENKHOA,
                TENNIENKHOA = newDT.TENNIENKHOA,
                GHICHU = newDT.GHICHU,
                TRANGTHAI = false
            };

            DB.NIENKHOAs.Add(nienkhoa);
            DB.SaveChanges();
            return true;
        }
        public bool SuaNienKhoa(NienKhoaDTO newDT)
        {
            try
            {
                NIENKHOA nienkhoa = DB.NIENKHOAs.SingleOrDefault(u => u.MANIENKHOA == newDT.MANIENKHOA&&u.TRANGTHAI==false);
                    {
                    nienkhoa.MANIENKHOA = newDT.MANIENKHOA;
                    nienkhoa.TENNIENKHOA = newDT.TENNIENKHOA;
                    nienkhoa.GHICHU = newDT.GHICHU;
                    nienkhoa.TRANGTHAI = false;
                    }
                DB.SaveChanges();
                return true;
            }
            catch
            (Exception ex)
            {
                return false;
            }
             
        }


        public bool ThemDaXoa(NienKhoaDTO newDT)
        {
            try
            {
                NIENKHOA nienkhoa = DB.NIENKHOAs.SingleOrDefault(u => u.MANIENKHOA == newDT.MANIENKHOA && u.TRANGTHAI == true);
                {
                    nienkhoa.MANIENKHOA = newDT.MANIENKHOA;
                    nienkhoa.TENNIENKHOA = newDT.TENNIENKHOA;
                    nienkhoa.GHICHU = newDT.GHICHU;
                    nienkhoa.TRANGTHAI = false;
                }
                DB.SaveChanges();
                return true;
            }
            catch
            (Exception ex)
            {
                return false;
            }

        }
        public bool XoaNienkhoa(NienKhoaDTO newDT)
        {
            try
            {
                NIENKHOA nienkhoa = DB.NIENKHOAs.SingleOrDefault(u => u.MANIENKHOA == newDT.MANIENKHOA&&u.TRANGTHAI==false);
                {
                    nienkhoa.TRANGTHAI = true;
                }
            }
            catch (Exception ex)
            { return false; }

            DB.SaveChanges();
            return true;
        }    
        public bool KTNienKhoa(string newDT)

        {
            try
            {
                NIENKHOA nienkhoa = DB.NIENKHOAs.SingleOrDefault(u => u.MANIENKHOA == newDT&&u.TRANGTHAI ==false);
                if (nienkhoa == null) return false;
                else return true;
            }
            catch
            {
                return false;
            }
        }

        public bool KTDaXoa(string newDT)
        {
            try
            {
                NIENKHOA nienkhoa = DB.NIENKHOAs.SingleOrDefault(u => u.MANIENKHOA == newDT && u.TRANGTHAI == true);
                if (nienkhoa == null) return false;
                else return true;
            }
            catch
            {
                return false;
            }
        }

        public List<NienKhoaDTO>DSNienKhoa_MaNienKhoa(string newDT)
        {
            return DB.NIENKHOAs.Where(u=>u.MANIENKHOA.Contains(newDT)&& u.TRANGTHAI==false).Select(p=> new NienKhoaDTO ()
                {
                MANIENKHOA = p.MANIENKHOA,
                TENNIENKHOA = p.TENNIENKHOA,
                GHICHU = p.GHICHU

            }).ToList();
        }
        public List<NienKhoaDTO>DSNienKhoa_TenNienKhoa(string newDT)
        {
            return DB.NIENKHOAs.Where(u=>u.TENNIENKHOA.Contains(newDT)&&u.TRANGTHAI==false).Select(p=> new NienKhoaDTO()
            {
               MANIENKHOA= p.MANIENKHOA,
               TENNIENKHOA = p.TENNIENKHOA,
               GHICHU= p.GHICHU
            }).ToList();
        }
        public List<NienKhoaDTO>DSNienKhoa_GhiChu(string newDT)
        {
            return DB.NIENKHOAs.Where(u=>u.GHICHU.Contains(newDT)&&u.TRANGTHAI==false).Select(p=> new NienKhoaDTO()
            {
                MANIENKHOA = p.MANIENKHOA,
                TENNIENKHOA = p.TENNIENKHOA,
                GHICHU = p.GHICHU
            }).ToList();
        }
    }
}
