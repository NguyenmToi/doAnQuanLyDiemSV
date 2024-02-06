
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MonHocDAO
        
    {
        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();

        public List<MonHocDTO> DSMonHoc()
        {
            return DB.MONHOCs.Where(u=>u.TRANGTHAI==false).Select(u=>new MonHocDTO
            {
                MAMH = u.MAMH,
                TENMH = u.TENMH,
                SOTINCHI = u.SOTINCHI,
                GHICHU = u.GHICHU

            }).ToList();
        }

        public bool ThemMonHoc(MonHocDTO newDT)
        {
            try
            {
                MONHOC mh = new MONHOC
                {
                    MAMH = newDT.MAMH,
                    TENMH = newDT.TENMH,
                    SOTINCHI = newDT.SOTINCHI,
                    GHICHU = newDT.GHICHU,
                    TRANGTHAI = false
                    
                };
                DB.MONHOCs.Add(mh);
                DB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool SuaMonHoc(MonHocDTO newDT)
        {
            try
            {
                MONHOC mh = DB.MONHOCs.SingleOrDefault(u => u.MAMH == newDT.MAMH && u.TRANGTHAI == false);
                {
                    mh.MAMH = newDT.MAMH;
                    mh.TENMH = newDT.TENMH;
                    mh.SOTINCHI = newDT.SOTINCHI;
                    mh.GHICHU = newDT .GHICHU;
                    mh.TRANGTHAI = false;
                }
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
                MONHOC mh = DB.MONHOCs.SingleOrDefault(u => u.MAMH == newDT && u.TRANGTHAI == true);
                if (mh == null) return false;
                else return true;
            }
            catch { return false; }
        }

        public bool ThemDaXoa(MonHocDTO newDT)
        {
            try
            {
                MONHOC mh = DB.MONHOCs.SingleOrDefault(u => u.MAMH == newDT.MAMH && u.TRANGTHAI == true);
                {
                    mh.MAMH = newDT.MAMH;
                    mh.TENMH = newDT.TENMH;
                    mh.SOTINCHI = newDT.SOTINCHI;
                    mh.GHICHU = newDT.GHICHU;
                    mh.TRANGTHAI = false;
                }
                DB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool XoaMonHoc(MonHocDTO newDT)
        {
            try
            {
                MONHOC mh = DB.MONHOCs.SingleOrDefault(u => u.MAMH == newDT.MAMH&&u.TRANGTHAI==false);
                {
                    mh.TRANGTHAI = true;
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
                MONHOC mh = DB.MONHOCs.SingleOrDefault(u => u.MAMH == newDT&&u.TRANGTHAI==false);
                if (mh == null)
                    return false;
                else return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public List<MonHocDTO> DSMonHoc_MaMonHoc(string newDT)
        {
            return DB.MONHOCs.Where(u => u.MAMH.Contains(newDT) && u.TRANGTHAI == false).Select(p => new MonHocDTO()
            {
                MAMH = p.MAMH,
                TENMH = p.TENMH,
                SOTINCHI = p.SOTINCHI,
                GHICHU = p.GHICHU

            }).ToList();
        }
        public List<MonHocDTO> DSMonHoc_TenMonHoc(string newDT)
        {
            return DB.MONHOCs.Where(u => u.TENMH.Contains(newDT) && u.TRANGTHAI == false).Select(p => new MonHocDTO()
            {
                MAMH = p.MAMH,
                TENMH = p.TENMH,
                SOTINCHI = p.SOTINCHI,
                GHICHU = p.GHICHU

            }).ToList();
        }

        public List<MonHocDTO> DSMonHoc_SoTinChi(int newDT)
        {
            return DB.MONHOCs.Where(u => u.SOTINCHI==newDT && u.TRANGTHAI == false).Select(p => new MonHocDTO()
            {
                MAMH = p.MAMH,
                TENMH = p.TENMH,
                SOTINCHI = p.SOTINCHI,
                GHICHU = p.GHICHU

            }).ToList();
        }

        public bool cx(int a)
        {
            try
            {
                if (DSMonHoc_SoTinChi(a) != null)
                {
                    return true;
                }
                return true; 
            }
            catch { return false; }
        }

        public List<MonHocDTO> DSMonHoc_GhiChu(string newDT)
        {
            return DB.MONHOCs.Where(u => u.GHICHU.Contains(newDT) && u.TRANGTHAI == false).Select(p => new MonHocDTO()
            {
                MAMH = p.MAMH,
                TENMH = p.TENMH,
                SOTINCHI = p.SOTINCHI,
                GHICHU = p.GHICHU

            }).ToList();
        }



    }
}
