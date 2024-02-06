using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LoaiTaiKhoanDAO
    {
        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();

        public List<LoaiTaiKhoanDTO> DSLOAITAIKHOAN()
        {
            return DB.LOAITAIKHOANs.Where(u=>u.TRANGTHAI==false).Select(u=> new LoaiTaiKhoanDTO
            {
               MALOAITAIKHOAN = u.MALOAITAIKHOAN,
               TENLOAITAIKHOAN = u.TENLOAITAIKHOAN,
               GHICHU = u.GHICHU
            }).ToList();
        }

        public bool ThemLoaiTaiKhoan(LoaiTaiKhoanDTO newDT)
        {
            try
            {
                LOAITAIKHOAN ltk = new LOAITAIKHOAN
                {
                    MALOAITAIKHOAN = newDT.MALOAITAIKHOAN,
                    TENLOAITAIKHOAN = newDT.TENLOAITAIKHOAN,
                    GHICHU = newDT.GHICHU
                };
                DB.LOAITAIKHOANs.Add(ltk);
                DB.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }



        public bool SuaLoaiTaiKhoan(LoaiTaiKhoanDTO newDT)
        {
            try
            {
                LOAITAIKHOAN ltk = DB.LOAITAIKHOANs.SingleOrDefault(u => u.MALOAITAIKHOAN == newDT.MALOAITAIKHOAN && u.TRANGTHAI == false);
                {
                    ltk.MALOAITAIKHOAN = newDT.MALOAITAIKHOAN;
                    ltk.TENLOAITAIKHOAN = newDT.TENLOAITAIKHOAN;
                    ltk.GHICHU = newDT.GHICHU;
                    ltk.TRANGTHAI = false;
                }
                DB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool XoaLoaiTaiKhoan(LoaiTaiKhoanDTO newDT)
        {
            try
            {
                LOAITAIKHOAN ltk = DB.LOAITAIKHOANs.SingleOrDefault(u => u.MALOAITAIKHOAN == newDT.MALOAITAIKHOAN && u.TRANGTHAI == false);
                {
                    ltk.TRANGTHAI = true;
                }
                DB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool KT(int newDT)
        {
            try
            {
                LOAITAIKHOAN ltk = DB.LOAITAIKHOANs.SingleOrDefault(u => u.MALOAITAIKHOAN == newDT&&u.TRANGTHAI==false);
                if (ltk == null) return false;
                else return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool KTLTKDaXoa(int newDT)
        {
            try
            {
                LOAITAIKHOAN ltk = DB.LOAITAIKHOANs.SingleOrDefault(u => u.MALOAITAIKHOAN == newDT && u.TRANGTHAI == true);
                if (ltk == null) return false;
                else return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ThemLTKDaXoa(LoaiTaiKhoanDTO newDT)
        {
            try
            {
                LOAITAIKHOAN ltk = DB.LOAITAIKHOANs.SingleOrDefault(u => u.MALOAITAIKHOAN == newDT.MALOAITAIKHOAN && u.TRANGTHAI == true);
                {
                    ltk.MALOAITAIKHOAN = newDT.MALOAITAIKHOAN;
                    ltk.TENLOAITAIKHOAN = newDT.TENLOAITAIKHOAN;
                    ltk.GHICHU = newDT.GHICHU;
                    ltk.TRANGTHAI = false;
                }
                DB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public List<LoaiTaiKhoanDTO>DSLoaiTaiKhoan_MaLoaiTaiKhoan(int newDT) {

            return DB.LOAITAIKHOANs.Where(u=>u.MALOAITAIKHOAN==newDT&&u.TRANGTHAI==false).Select(u=> new LoaiTaiKhoanDTO() { 
                 MALOAITAIKHOAN = u.MALOAITAIKHOAN,
                 TENLOAITAIKHOAN = u.TENLOAITAIKHOAN,
                 GHICHU = u.GHICHU,
            }).ToList();
        }

        public List<LoaiTaiKhoanDTO> DSLoaiTaiKhoan_TenLoaiTaiKhoan(string newDT)
        {

            return DB.LOAITAIKHOANs.Where(u => u.TENLOAITAIKHOAN.Contains(newDT) && u.TRANGTHAI == false).Select(u => new LoaiTaiKhoanDTO()
            {
                MALOAITAIKHOAN = u.MALOAITAIKHOAN,
                TENLOAITAIKHOAN = u.TENLOAITAIKHOAN,
                GHICHU = u.GHICHU,
            }).ToList();
        }

        public List<LoaiTaiKhoanDTO> DSLoaiTaiKhoan_GhiChu(string newDT)
        {

            return DB.LOAITAIKHOANs.Where(u => u.GHICHU.Contains(newDT) && u.TRANGTHAI == false).Select(u => new LoaiTaiKhoanDTO()
            {
                MALOAITAIKHOAN = u.MALOAITAIKHOAN,
                TENLOAITAIKHOAN = u.TENLOAITAIKHOAN,
                GHICHU = u.GHICHU,
            }).ToList();
        }
    }
}
