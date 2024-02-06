using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NganhDAO
    {
        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();
        public List<NganhDTO> DSNganh()
        {
            return DB.NGANHs.Where(u => u.TRANGTHAI == false).Select(u => new NganhDTO
            {
                MANGANH = u.MANGANH,
                TENNGANH = u.TENNGANH,
                TENKHOA = u.KHOA.TENKHOA,
                GHICHU = u.GHICHU,
            }).ToList();
        }
        public bool ThemNganh(NganhDTO newDT)
        {
            try
            {
                NGANH nganh = new NGANH
                {
                    MANGANH = newDT.MANGANH,
                    TENNGANH = newDT.TENNGANH,
                    MAKHOA = newDT.MAKHOA,
                    GHICHU = newDT.GHICHU,
                    TRANGTHAI = false
                };

                DB.NGANHs.Add(nganh);
                DB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool KTDaXoa(string newDT)
        {
            try
            {
                NGANH nganh = DB.NGANHs.SingleOrDefault(u => u.MANGANH == newDT&& u.TRANGTHAI==true);
                if (nganh == null) return false;
                else return true;
            }
            catch { return false; }
        }

        public bool ThemDaXoa(NganhDTO newDT)
        {
            try
            {
                NGANH nganh = DB.NGANHs.SingleOrDefault(u => u.MANGANH == newDT.MANGANH&&u.TRANGTHAI==true);
                {
                    nganh.TENNGANH = newDT.TENNGANH;
                    nganh.MAKHOA = newDT.MAKHOA;
                    nganh.GHICHU = newDT.GHICHU;
                    nganh.TRANGTHAI = false;
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

        public bool SuaNganh(NganhDTO newDT)
        {
            try
            {
                NGANH nganh = DB.NGANHs.SingleOrDefault(u => u.MANGANH == newDT.MANGANH);
                {
                    nganh.MANGANH = newDT.MANGANH;
                    nganh.TENNGANH = newDT.TENNGANH;
                    nganh.MAKHOA = newDT.MAKHOA;
                    nganh.GHICHU = newDT.GHICHU;
                    nganh.TRANGTHAI = false;
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
        public bool XoaNganh(NganhDTO newDT)
        {
            try
            {
                NGANH nganh = DB.NGANHs.SingleOrDefault(u => u.MANGANH == newDT.MANGANH&&u.TRANGTHAI==false);
                {
                    nganh.TRANGTHAI = true;
                }

                DB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            { return false; }

        }

        public bool KTNganh(NganhDTO newDT)
        {
            try
            {
                NGANH nganh = DB.NGANHs.SingleOrDefault(u => u.MANGANH == newDT.MANGANH&&u.TRANGTHAI==false);
                if (nganh == null) return false;
                else return true;
            }
            catch { return false; }
        }

        public List<NganhDTO> DSNganh_MaNganh(string newDT)
        {
            return DB.NGANHs.Where(u => u.MANGANH.Contains(newDT) && u.TRANGTHAI == false).Select(p => new NganhDTO()
            {
                MANGANH = p.MANGANH,
                TENNGANH = p.TENNGANH,
                MAKHOA = p.MAKHOA,
                GHICHU = p.GHICHU

            }).ToList();
        }
        public List<NganhDTO> DSNganh_TenNganh(string newDT)
        {
            return DB.NGANHs.Where(u => u.TENNGANH.Contains(newDT) && u.TRANGTHAI == false).Select(p => new NganhDTO()
            {
                MANGANH = p.MANGANH,
                TENNGANH = p.TENNGANH,
                MAKHOA = p.MAKHOA,
                GHICHU = p.GHICHU
            }).ToList();
        }
        public List<NganhDTO> DSNganh_GhiChu(string newDT)
        {
            return DB.NGANHs.Where(u => u.GHICHU.Contains(newDT) && u.TRANGTHAI == false).Select(p => new NganhDTO()
            {
                MANGANH = p.MANGANH,
                TENNGANH = p.TENNGANH,
                MAKHOA = p.MAKHOA,
                GHICHU = p.GHICHU
            }).ToList();
        }
        public List<NganhDTO> DSNganh_TenKhoa(string newDT)
        {
            return DB.NGANHs.Where(u => u.MAKHOA.Contains(newDT) && u.TRANGTHAI == false).Select(p => new NganhDTO()
            {
                MANGANH = p.MANGANH,
                TENNGANH = p.TENNGANH,
                MAKHOA = p.MAKHOA,
                GHICHU = p.GHICHU
            }).ToList();
        }

    }
    
}
