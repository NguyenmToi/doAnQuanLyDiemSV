using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhoaDAO
    {
        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();
        public List<KhoaDTO> DSKhoa()
        {
            return DB.KHOAs.Where(u => u.TRANGTHAI == false).Select(u => new KhoaDTO
            {
                MAKHOA = u.MAKHOA,
                TENKHOA = u.TENKHOA,
                GHICHU = u.GHICHU,
            }).ToList();

        }

        public bool ThemKhoa(KhoaDTO newKhoa)
        {
            try
            {
                KHOA khoa = new KHOA()
                {
                    MAKHOA = newKhoa.MAKHOA,
                    TENKHOA = newKhoa.TENKHOA,
                    GHICHU = newKhoa.GHICHU,
                    TRANGTHAI = false
                };

                DB.KHOAs.Add(khoa);
                DB.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool SuaKhoa(KhoaDTO newKhoa)
        {
            try
            {
                KHOA khoa = DB.KHOAs.SingleOrDefault(u => u.MAKHOA == newKhoa.MAKHOA&&u.TRANGTHAI==false);

                {
                    khoa.MAKHOA = newKhoa.MAKHOA;
                    khoa.TENKHOA = newKhoa.TENKHOA;
                    khoa.GHICHU = newKhoa.GHICHU;
                    khoa.TRANGTHAI = false;

                }
                DB.SaveChanges() ;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool KTKhoaDaXoa(string newHK)
        {
            try
            {
                KHOA kh = DB.KHOAs.SingleOrDefault(u => u.MAKHOA == newHK && u.TRANGTHAI == true);
                if (kh == null) return false;
                else return true;
            }
            catch (Exception ex) { return false; }
        }

        public bool ThemKhoaDaXoa(KhoaDTO newHK)
        {
            try
            {
                KHOA kh = DB.KHOAs.SingleOrDefault(u => u.MAKHOA == newHK.MAKHOA && u.TRANGTHAI == true);
                {
                    kh.MAKHOA = newHK.MAKHOA;
                    kh.TENKHOA = newHK.TENKHOA;
                    kh.TRANGTHAI = false;
                    kh.GHICHU = newHK.GHICHU;
                }
                DB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool XoaKhoa(KhoaDTO newKhoa)
        {
            try
            {
                KHOA khoa = DB.KHOAs.SingleOrDefault(u => u.MAKHOA == newKhoa.MAKHOA&&u.TRANGTHAI==false);
                khoa.TRANGTHAI = true;

                DB.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        public bool KT(KhoaDTO newKhoa)
        {
            try
            {
                KHOA khoa = DB.KHOAs.SingleOrDefault(u => u.MAKHOA == newKhoa.MAKHOA && u.TRANGTHAI == false);
                if (khoa == null) return false;
                else return true;
            }
            catch { return false; }
        }

        public List<KhoaDTO> TK_KHOA_MaKhoa(string MaKhoa)
        {
            return DB.KHOAs.Where(u => u.MAKHOA.Contains(MaKhoa) && u.TRANGTHAI == false).Select(p => new KhoaDTO
            {
                MAKHOA = p.MAKHOA,
                TENKHOA = p.TENKHOA,
                GHICHU = p.GHICHU
            }).ToList();
        }
        public List<KhoaDTO> TK_KHOA_TenKhoa(string TenKhoa)
        {
            return DB.KHOAs.Where(u => u.TENKHOA.Contains(TenKhoa) && u.TRANGTHAI == false).Select(p => new KhoaDTO
            {
                MAKHOA = p.MAKHOA,
                TENKHOA = p.TENKHOA,
                GHICHU = p.GHICHU
            }).ToList();
        }
        public List<KhoaDTO> TK_KHOA_GhiChu(string GhiChu)
        {
            return DB.KHOAs.Where(u => u.GHICHU.Contains(GhiChu) && u.TRANGTHAI == false).Select(p => new KhoaDTO
            {
                MAKHOA = p.MAKHOA,
                TENKHOA = p.TENKHOA,
                GHICHU = p.GHICHU
            }).ToList();
        }
    }
}
