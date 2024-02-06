using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class GiangVienDAO
    {
        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();

        public List<GiangVienDTO> DSGiangVien()
        {
            return DB.GIANGVIENs.Where(u => u.TRANGTHAI == false).Select(u => new GiangVienDTO
            {
                MAGV = u.MAGV,
                HOTENGV = u.HOTENGV,
                TENKHOA = u.KHOA1.TENKHOA,
                GIOITINH = u.GIOITINH == null ? false : u.GIOITINH,
                TENGIOITINH = u.GIOITINH ==true ? "Nam":"Nữ",
                GHICHU = u.GHICHU,
            }).ToList();

        }

        public bool ThemGiangVien(GiangVienDTO newDT)
        {
            try
            {
                GIANGVIEN gv = new GIANGVIEN
                {
                    MAGV = newDT.MAGV,
                    HOTENGV = newDT.HOTENGV,
                    KHOA = newDT.KHOA,
                    GIOITINH = newDT.GIOITINH,
                    GHICHU = newDT.GHICHU,
                    TRANGTHAI = false
                };
                DB.GIANGVIENs.Add(gv);
                DB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }



        public string LayTenGiangVien(string maGV)
        {
            
                var gv = DB.GIANGVIENs.FirstOrDefault(u => u.MAGV == maGV);

                if (gv != null)
                {
                    return gv.HOTENGV;
                
                }
                else
                {
                    return null;
                }
            
        }
        public bool SuaGV(GiangVienDTO newDT)
        {
            try
            {
                GIANGVIEN gv = DB.GIANGVIENs.SingleOrDefault(u => u.MAGV == newDT.MAGV&&u.TRANGTHAI==false);
                {
                    gv.MAGV = newDT.MAGV;
                    gv.HOTENGV = newDT.HOTENGV;
                    gv.KHOA = newDT.KHOA;
                    gv.GIOITINH = newDT.GIOITINH;
                    gv.GHICHU = newDT.GHICHU;
                    gv.TRANGTHAI = false;
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

        public bool KhoiPhuc(GiangVienDTO  newDT)
        {
            try
            {
                GIANGVIEN gv = DB.GIANGVIENs.SingleOrDefault(u => u.MAGV == newDT.MAGV && u.TRANGTHAI == true);
                {
                    gv.MAGV = newDT.MAGV;
                    gv.HOTENGV = newDT.HOTENGV;
                    gv.KHOA = newDT.KHOA;
                    gv.GIOITINH = newDT.GIOITINH;
                    gv.GHICHU = newDT.GHICHU;
                    gv.TRANGTHAI = false;
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

        public bool XoaGV(GiangVienDTO newDT)
        {
            try
            {
                GIANGVIEN gv = DB.GIANGVIENs.SingleOrDefault(u => u.MAGV == newDT.MAGV && u.TRANGTHAI == false);
                {
                    gv.TRANGTHAI = true;
                }
                DB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            { return false; }

   
        }

        public bool KTGV(GiangVienDTO newDT)
        {
            try
            {
                GIANGVIEN gv = DB.GIANGVIENs.SingleOrDefault(u => u.MAGV == newDT.MAGV&&u.TRANGTHAI==false);
                if (gv == null) return false;
                else return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool KTGVDaXoa(GiangVienDTO newDT)
        {
            try
            {
                GIANGVIEN gv = DB.GIANGVIENs.SingleOrDefault(u => u.MAGV == newDT.MAGV && u.TRANGTHAI == true);
                if (gv == null) return false;
                else return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool ThemGVXoa(GiangVienDTO newDT)
        {
            try
            {
                GIANGVIEN gv = DB.GIANGVIENs.SingleOrDefault(u => u.MAGV == newDT.MAGV && u.TRANGTHAI == true);
                {
                    gv.HOTENGV = newDT.HOTENGV;
                    gv.KHOA = newDT.KHOA;
                    gv.GIOITINH = newDT.GIOITINH;
                    gv.GHICHU = newDT.GHICHU;
                    gv.TRANGTHAI = false;
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



        public bool KTKhoa(string newDT)
        {
            try
            {
                KHOA kh = DB.KHOAs.SingleOrDefault(u => u.MAKHOA == newDT);
                if (kh == null) return false;
                else return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<GiangVienDTO> DSGV_MaGV(string newDT)
        {
            return DB.GIANGVIENs.Where(u => u.MAGV.Contains(newDT) && u.TRANGTHAI == false).Select(p => new GiangVienDTO()
            {
                MAGV = p.MAGV,
                HOTENGV = p.HOTENGV,
                TENKHOA = p.KHOA1.TENKHOA,
                TENGIOITINH = p.GIOITINH == true ? "Nam" : "Nữ",
                GIOITINH = p.GIOITINH,
                GHICHU = p.GHICHU

            }).ToList();
        }
        public List<GiangVienDTO> DSGV_HoTenGV(string newDT)
        {
            return DB.GIANGVIENs.Where(u => u.HOTENGV.Contains(newDT) && u.TRANGTHAI == false).Select(p => new GiangVienDTO()
            {
                MAGV = p.MAGV,
                HOTENGV = p.HOTENGV,
                TENKHOA = p.KHOA1.TENKHOA,
                TENGIOITINH = p.GIOITINH == true ? "Nam" : "Nữ",
                GIOITINH = p.GIOITINH,
                GHICHU = p.GHICHU

            }).ToList();
        }
        public List<GiangVienDTO> DSGV_KhoaGV(string newDT)
        {
            return DB.GIANGVIENs.Where(u => u.KHOA.Contains(newDT) && u.TRANGTHAI == false).Select(p => new GiangVienDTO()
            {
                MAGV = p.MAGV,
                HOTENGV = p.HOTENGV,
                TENKHOA = p.KHOA1.TENKHOA,
                TENGIOITINH = p.GIOITINH == true ? "Nam" : "Nữ",
                GIOITINH = p.GIOITINH,
                GHICHU = p.GHICHU

            }).ToList();
        }
        public List<GiangVienDTO> DSGV_GhiChu(string newDT)
        {
            return DB.GIANGVIENs.Where(u => u.GHICHU.Contains(newDT) && u.TRANGTHAI == false).Select(p => new GiangVienDTO()
            {
                MAGV = p.MAGV,
                HOTENGV = p.HOTENGV,
                TENKHOA = p.KHOA1.TENKHOA,
                TENGIOITINH = p.GIOITINH == true ? "Nam" : "Nữ",
                GIOITINH = p.GIOITINH,
                GHICHU = p.GHICHU

            }).ToList();
        }

        
    }
}
