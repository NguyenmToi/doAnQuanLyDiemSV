using DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class QLTKGVsDAO
    {
        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();

        public List<TaiKhoanGVDTO> TTDN(string tk)
        {
            return DB.TAIKHOANGVs.Where(u => u.TRANGTHAI == false&&u.TAIKHOAN==tk).Select(u => new TaiKhoanGVDTO
            {
                TAIKHOAN = u.TAIKHOAN,
                LOAITAIKHOAN = u.LOAITAIKHOAN,
                MATKHAU = u.MATKHAU,
                GHICHU = u.GHICHU,
            }).ToList();
        }

        public List<TaiKhoanGVDTO> DSTaiKhoanGV()
        {
            return DB.TAIKHOANGVs.Where(u => u.TRANGTHAI == false).Select(u => new TaiKhoanGVDTO
            {
                TAIKHOAN = u.TAIKHOAN,
                LOAITAIKHOAN = u.LOAITAIKHOAN,
                MATKHAU = u.MATKHAU,
                GHICHU = u.GHICHU,
            }).ToList();
        }

        public bool TenGV(GiangVienDTO newDT)
        {
            try
            {
                GIANGVIEN gv = DB.GIANGVIENs.SingleOrDefault(u => u.MAGV == newDT.MAGV && u.TRANGTHAI == false);
                {
                    gv.MAGV = newDT.MAGV;
                    newDT.HOTENGV = gv.HOTENGV;
                }
                DB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }


        public bool ThemTaiKhoan(TaiKhoanGVDTO newDT)

        {

            try
            {
                TAIKHOANGV tk = new TAIKHOANGV
                {
                    TAIKHOAN = newDT.TAIKHOAN,
                    MATKHAU = newDT.MATKHAU,
                    GHICHU = newDT.GHICHU,
                    TRANGTHAI = false,
                    LOAITAIKHOAN = 1

                };
                DB.TAIKHOANGVs.Add(tk);
                DB.SaveChanges();
                return true;
            }
            catch { return false; }

        }

        public bool SuaTaiKhoan(TaiKhoanGVDTO newDT)
        {
            try
            {
                TAIKHOANGV tk = DB.TAIKHOANGVs.SingleOrDefault(u => u.TAIKHOAN == newDT.TAIKHOAN && u.TRANGTHAI == false);
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
        public bool KTMKCu(string newDT, string newDT2)
        {
            try
            {
                TAIKHOANGV tk = DB.TAIKHOANGVs.SingleOrDefault(u => u.TAIKHOAN == newDT &&u.MATKHAU==newDT2 && u.TRANGTHAI == false);
                if (tk == null) return false; 
                else return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public string LayMaLoaiTaiKhoan(string maGV)
        {
            var gv = DB.TAIKHOANGVs.FirstOrDefault(u => u.TAIKHOAN == maGV);
            if (gv != null)
            {
                return gv.LOAITAIKHOAN.ToString();
            }
            else
            {
                return null;
            }

        }
        public bool DoiMatKhau(TaiKhoanGVDTO newDT)
        {
            try
            {
                TAIKHOANGV tk = DB.TAIKHOANGVs.SingleOrDefault(u => u.TAIKHOAN == newDT.TAIKHOAN && u.TRANGTHAI == false);
                {
                    tk.MATKHAU = newDT.MATKHAU;
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


        public bool KhoiPhucTaiKhoan(TaiKhoanGVDTO newDT)
        {
            try
            {
                TAIKHOANGV tk = DB.TAIKHOANGVs.SingleOrDefault(u => u.TAIKHOAN == newDT.TAIKHOAN && u.TRANGTHAI == true);
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

        public bool XoaTaiKhoan(TaiKhoanGVDTO newDT)
        {
            try
            {
                TAIKHOANGV tk = DB.TAIKHOANGVs.SingleOrDefault(u => u.TAIKHOAN == newDT.TAIKHOAN && u.TRANGTHAI == false);
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



        public bool KTKhoiPhuc(string newDT)
        {

            try
            {
                TAIKHOANGV tk = DB.TAIKHOANGVs.SingleOrDefault(u => u.TAIKHOAN == newDT && u.TRANGTHAI == true);
                if (tk == null) return false;
                else return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool KTMaGV(string newDT)
        {
            try
            {
                GIANGVIEN gv = DB.GIANGVIENs.SingleOrDefault(u => u.MAGV == newDT);
                if (gv == null) return false;
                else return true;
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
                TAIKHOANGV gv = DB.TAIKHOANGVs.SingleOrDefault(u => u.TAIKHOAN == newDT && u.TRANGTHAI == false);
                if (gv == null) return false;
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
                TAIKHOANGV gv = DB.TAIKHOANGVs.SingleOrDefault(u => u.TAIKHOAN == newDT && u.TRANGTHAI == false);
                if (gv == null) return false;
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
                TAIKHOANGV tk = DB.TAIKHOANGVs.SingleOrDefault(u => u.TAIKHOAN == newDT && u.MATKHAU==newDT2);
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
                TAIKHOANGV gv = DB.TAIKHOANGVs.SingleOrDefault(u => u.MATKHAU == newDT && u.TRANGTHAI == false);
                if (gv == null) return false;
                else return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool QuenMatKhau(TaiKhoanGVDTO newDT)
        {
            try
            {
                TAIKHOANGV tk = DB.TAIKHOANGVs.SingleOrDefault(u => u.TAIKHOAN == newDT.TAIKHOAN && u.TRANGTHAI == false);
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

        public List<TaiKhoanGVDTO> DSTaiKhoanGV_LTK(int newDT)
        {
            return DB.TAIKHOANGVs.Where(u => u.LOAITAIKHOAN==newDT && u.TRANGTHAI == false).Select(p => new TaiKhoanGVDTO()
            {
                TAIKHOAN = p.TAIKHOAN,
                MATKHAU = p.MATKHAU,
                LOAITAIKHOAN = p.LOAITAIKHOAN,
                GHICHU = p.GHICHU,
            }).ToList();
        }

    }
}
