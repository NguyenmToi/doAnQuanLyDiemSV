
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HocKyDAO
    {
        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();
        public List<HocKYDTO> DSHocKY()
        {
            return DB.HOCKies.Where(u => u.TRANGTHAI == false).Select(u => new HocKYDTO
            {
                MAHOCKY = u.MAHOCKY,
                TENHOCKY = u.TENHOCKY,
                GHICHU = u.GHICHU,

            }).ToList();

        }
        public bool ThemHK(HocKYDTO newHK)
        {
            try
            {
                HOCKY hk = new HOCKY
                {
                    MAHOCKY = newHK.MAHOCKY,
                    TENHOCKY = newHK.TENHOCKY,
                    GHICHU = newHK.GHICHU,
                    TRANGTHAI = newHK.TRANGTHAI
                };
                DB.HOCKies.Add(hk);
                DB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool XoaHK(HocKYDTO newHK)
        {
            try
            {
                HOCKY hk = DB.HOCKies.SingleOrDefault(u => u.MAHOCKY == newHK.MAHOCKY&&u.TRANGTHAI==false);
                hk.TRANGTHAI = true;

                DB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool SuaHK(HocKYDTO newHK)
        {
            try
            {
                HOCKY hk = DB.HOCKies.SingleOrDefault(u => u.MAHOCKY == newHK.MAHOCKY&&u.TRANGTHAI==false);
                {
                    hk.MAHOCKY = newHK.MAHOCKY;
                    hk.TENHOCKY = newHK.TENHOCKY;
                    hk.TRANGTHAI = false;
                    hk.GHICHU = newHK.GHICHU;
                }
                DB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool KT(HocKYDTO newHK)
        {
            try
            {
                HOCKY HocKy = DB.HOCKies.SingleOrDefault(u => u.MAHOCKY == newHK.MAHOCKY && u.TRANGTHAI == false);
                if (HocKy == null) return false;
                else return true;
            }
            catch (Exception ex) { return false; }
        }

        public bool KTHKDaXoa(string newHK)
        {
            try
            {
                HOCKY HocKy = DB.HOCKies.SingleOrDefault(u => u.MAHOCKY == newHK&&u.TRANGTHAI==true);
                if (HocKy == null) return false;
                else return true;
            }
            catch (Exception ex) { return false; }
        }

        public bool ThemHKDaXoa(HocKYDTO newHK)
        {
            try
            {
                HOCKY hk = DB.HOCKies.SingleOrDefault(u => u.MAHOCKY == newHK.MAHOCKY && u.TRANGTHAI == true);
                {
                    hk.MAHOCKY = newHK.MAHOCKY;
                    hk.TENHOCKY = newHK.TENHOCKY;
                    hk.TRANGTHAI = false;
                    hk.GHICHU = newHK.GHICHU;
                }
                DB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<HocKYDTO> TK_HOCKY_MaHocKy(string MaHocKy)
        {
            return DB.HOCKies.Where(u => u.MAHOCKY.Contains(MaHocKy) && u.TRANGTHAI == false).Select(p => new HocKYDTO
            {
                MAHOCKY = p.MAHOCKY,
                TENHOCKY = p.TENHOCKY,
                GHICHU = p.GHICHU
            }).ToList();
        }
        public List<HocKYDTO> TK_HOCKY_TenHocKy(string TenHocKy)
        {
            return DB.HOCKies.Where(u => u.TENHOCKY.Contains(TenHocKy) && u.TRANGTHAI == false).Select(p => new HocKYDTO
            {
                MAHOCKY = p.MAHOCKY,
                TENHOCKY = p.TENHOCKY,
                GHICHU = p.GHICHU
            }).ToList();
        }
        public List<HocKYDTO> TK_KHOA_GhiChu(string GhiChu)
        {
            return DB.HOCKies.Where(u => u.GHICHU.Contains(GhiChu) && u.TRANGTHAI == false).Select(p => new HocKYDTO
            {
                MAHOCKY = p.MAHOCKY,
                TENHOCKY = p.TENHOCKY,
                GHICHU = p.GHICHU
            }).ToList();
        }
    }
}




