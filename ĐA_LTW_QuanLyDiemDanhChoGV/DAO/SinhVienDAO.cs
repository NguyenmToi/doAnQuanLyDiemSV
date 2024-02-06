using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAO
{
    public class SinhVienDAO
    {
        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();
        public List<SinhVienDTO> DSSinhVien()
        {
            return DB.SINHVIENs.Where(u => u.TRANGTHAI == false).Select(u => new SinhVienDTO
            {
                MSSV = u.MSSV,
                HOTEN = u.HOTEN,
                NGAYSINH = u.NGAYSINH.Value,
                DANTOC =u.DANTOC,
                DIACHI = u.DIACHI,
                EMAIL = u.EMAIL,
                CCCD =u.CCCD,
                MALOP = u.LOP.MALOP,
                TENLOP = u.LOP.TENLOP,
                NIENKHOA = u.NIENKHOA,
                TENNIENKHOA = u.NIENKHOA1.TENNIENKHOA,
                TENNGANH = u.NGANH1.TENNGANH,
                NGANH = u.NGANH,
                GIOITINH = u.GIOITINH == true ? true : false,
                TENGIOITINH = u.GIOITINH == true ? "Nam" : "Nữ",

                GHICHU = u.GHICHU
            }).ToList();

        }

        public bool ThemSinhVien(SinhVienDTO newDT)
        {
            try
            {
                SINHVIEN sv = new SINHVIEN
                {
                    MSSV = newDT.MSSV,
                    HOTEN = newDT.HOTEN,
                    CCCD =newDT.CCCD,
                    NGAYSINH = newDT.NGAYSINH,
                    DANTOC = newDT.DANTOC,
                    DIACHI = newDT.DIACHI,
                    EMAIL = newDT.EMAIL,
                    MALOP = newDT.MALOP,
                    NIENKHOA = newDT.NIENKHOA,
                    NGANH = newDT.NGANH,
                    GIOITINH = newDT.GIOITINH,
                    GHICHU = newDT.GHICHU,
                    TRANGTHAI = false,

                };
                DB.SINHVIENs.Add(sv);
                DB.SaveChanges();
                return true;
        }
            catch (Exception ex)
            {
                return false;
            }
}

        public bool SuaSV(SinhVienDTO newDT)
        {
            try
            {
                SINHVIEN sv = DB.SINHVIENs.SingleOrDefault(u => u.MSSV == newDT.MSSV && u.TRANGTHAI == false);
                {
                    sv.MSSV = newDT.MSSV;
                    sv.HOTEN = newDT.HOTEN;
                    sv.NGAYSINH = newDT.NGAYSINH;
                    sv.DANTOC = newDT.DANTOC;
                    sv.CCCD = newDT.CCCD;
                    sv.DIACHI = newDT.DIACHI;
                    sv.EMAIL = newDT.EMAIL;
                    sv.MALOP = newDT.MALOP;
                    sv.NIENKHOA = newDT.NIENKHOA;
                    sv.NGANH = newDT.NGANH;
                    sv.GIOITINH = newDT.GIOITINH;
                    sv.GHICHU = newDT.GHICHU;
                    sv.TRANGTHAI = false;
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

        public bool KTSVDaXoa(string newDT)
        {
            try
            {
                SINHVIEN sv = DB.SINHVIENs.SingleOrDefault(u => u.MSSV == newDT && u.TRANGTHAI == true);
                if (sv == null) return false;
                else return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool KhoiPhucSVDaXoa(SinhVienDTO newDT)
        {
            try
            {
                SINHVIEN sv = DB.SINHVIENs.SingleOrDefault(u => u.MSSV == newDT.MSSV && u.TRANGTHAI == true);
                {
                    sv.MSSV = newDT.MSSV;
                    sv.HOTEN = newDT.HOTEN;
                    sv.NGAYSINH = newDT.NGAYSINH;
                    sv.DANTOC = newDT.DANTOC;
                    sv.CCCD = newDT.CCCD;
                    sv.DIACHI = newDT.DIACHI;
                    sv.EMAIL = newDT.EMAIL;
                    sv.MALOP = newDT.MALOP;
                    sv.NIENKHOA = newDT.NIENKHOA;
                    sv.NGANH = newDT.NGANH;
                    sv.GIOITINH = newDT.GIOITINH;
                    sv.GHICHU = newDT.GHICHU;
                    sv.TRANGTHAI = false;
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



        public bool XoaSV(string newDT)
        {
            try
            {
                SINHVIEN sv = DB.SINHVIENs.SingleOrDefault(u => u.MSSV == newDT && u.TRANGTHAI == false);
                {
                    sv.TRANGTHAI = true;
                }
                DB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            { return false; }


        }

        public bool KTSV(SinhVienDTO newDT)
        {
            try
            {
                SINHVIEN sv = DB.SINHVIENs.SingleOrDefault(u => u.MSSV == newDT.MSSV&&u.TRANGTHAI==false);
                if (sv == null) return false;
                else return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public bool KTEmail(string newDT)
        {
            try
            {
                var regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                if (regex.IsMatch(newDT) == true)

                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
 


        public bool KTLop(string newDT)
        {
            try
            {
                LOP gv = DB.LOPs.SingleOrDefault(u => u.MALOP == newDT);
                if (gv == null) return false;
                else return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool KTNganh(string newDT)
        {
            try
            {
                NGANH gv = DB.NGANHs.SingleOrDefault(u => u.MANGANH == newDT);
                if (gv == null) return false;
                else return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool KTNienKhoa(string newDT)
        {
            try
            {
                NIENKHOA gv = DB.NIENKHOAs.SingleOrDefault(u => u.MANIENKHOA == newDT);
                if (gv == null) return false;
                else return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool KTNgaySinh(string newDT)
        {
            DateTime date;

            try
            {
                DateTime.TryParse(newDT, out date);
                DateTime minDate = new DateTime(2004, 1, 1);

                if (date <= minDate)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch(Exception ex)
            {
                return false;
            }
        }





        public List<SinhVienDTO> DSSV_MaSV(string newDT)
        {
            return DB.SINHVIENs.Where(u => u.MSSV.Contains(newDT) && u.TRANGTHAI == false).Select(p => new SinhVienDTO()
            {
                MSSV = p.MSSV,
                HOTEN = p.HOTEN,
                CCCD = p.CCCD,
                NGAYSINH = p.NGAYSINH.Value,
                DANTOC = p.DANTOC,
                DIACHI = p.DIACHI,
                EMAIL = p.EMAIL,
                MALOP = p.MALOP,
                TENLOP = p.LOP.TENLOP,
                NIENKHOA = p.NIENKHOA,
                TENNIENKHOA = p.NIENKHOA1.TENNIENKHOA,
                NGANH = p.NGANH,
                TENNGANH = p.NGANH1.TENNGANH,
                GIOITINH = p.GIOITINH.Value,
                TENGIOITINH =p.GIOITINH.Value== true ?"Nam":"Nữ",
                GHICHU = p.GHICHU,
                TRANGTHAI = false,
            }).ToList();
        }
        public List<SinhVienDTO> DSSV_HoTenSV(string newDT)
        {
            return DB.SINHVIENs.Where(u => u.HOTEN .Contains(newDT) && u.TRANGTHAI == false).Select(p => new SinhVienDTO()
            {
                MSSV = p.MSSV,
                HOTEN = p.HOTEN,
                CCCD = p.CCCD,
                NGAYSINH = p.NGAYSINH.Value,
                DANTOC = p.DANTOC,
                DIACHI = p.DIACHI,
                EMAIL = p.EMAIL,
                MALOP = p.MALOP,
                TENLOP = p.LOP.TENLOP,
                NIENKHOA = p.NIENKHOA,
                TENNIENKHOA = p.NIENKHOA1.TENNIENKHOA,
                NGANH = p.NGANH,
                TENNGANH = p.NGANH1.TENNGANH,
                GIOITINH = p.GIOITINH.Value,
                TENGIOITINH = p.GIOITINH.Value == true ? "Nam" : "Nữ",
                GHICHU = p.GHICHU,
                TRANGTHAI = false,
            }).ToList();
        }
        public List<SinhVienDTO> DSSV_CCCD(string newDT)
        {
            return DB.SINHVIENs.Where(u => u.CCCD.Contains (newDT) && u.TRANGTHAI == false).Select(p => new SinhVienDTO()
            {
                MSSV = p.MSSV,
                HOTEN = p.HOTEN,
                CCCD = p.CCCD,
                NGAYSINH = p.NGAYSINH.Value,
                DANTOC = p.DANTOC,
                DIACHI = p.DIACHI,
                EMAIL = p.EMAIL,
                MALOP = p.MALOP,
                TENLOP = p.LOP.TENLOP,
                NIENKHOA = p.NIENKHOA,
                TENNIENKHOA = p.NIENKHOA1.TENNIENKHOA,
                NGANH = p.NGANH,
                TENNGANH = p.NGANH1.TENNGANH,
                GIOITINH = p.GIOITINH.Value,
                TENGIOITINH = p.GIOITINH.Value == true ? "Nam" : "Nữ",
                GHICHU = p.GHICHU,
                TRANGTHAI = false,
            }).ToList();
        }
        public List<SinhVienDTO> DSSV_Email(string newDT)
        {
            return DB.SINHVIENs.Where(u => u.EMAIL.Contains(newDT) && u.TRANGTHAI == false).Select(p => new SinhVienDTO()
            {
                MSSV = p.MSSV,
                HOTEN = p.HOTEN,
                CCCD = p.CCCD,
                NGAYSINH = p.NGAYSINH.Value,
                DANTOC = p.DANTOC,
                DIACHI = p.DIACHI,
                EMAIL = p.EMAIL,
                MALOP = p.MALOP,
                TENLOP = p.LOP.TENLOP,
                NIENKHOA = p.NIENKHOA,
                TENNIENKHOA = p.NIENKHOA1.TENNIENKHOA,
                NGANH = p.NGANH,
                TENNGANH = p.NGANH1.TENNGANH,
                GIOITINH = p.GIOITINH.Value,
                TENGIOITINH = p.GIOITINH.Value == true ? "Nam" : "Nữ",
                GHICHU = p.GHICHU,
                TRANGTHAI = false,
            }).ToList();
        }
        public List<SinhVienDTO> DSSV_Lop(string newDT)
        {
            return DB.SINHVIENs.Where(u => u.MALOP == newDT && u.TRANGTHAI == false).Select(p => new SinhVienDTO()
            {
                MSSV = p.MSSV,
                HOTEN = p.HOTEN,
                CCCD = p.CCCD,
                NGAYSINH = p.NGAYSINH.Value,
                DANTOC = p.DANTOC,
                DIACHI = p.DIACHI,
                EMAIL = p.EMAIL,
                MALOP = p.MALOP,
                TENLOP = p.LOP.TENLOP,
                NIENKHOA = p.NIENKHOA,
                TENNIENKHOA = p.NIENKHOA1.TENNIENKHOA,
                NGANH = p.NGANH,
                TENNGANH = p.NGANH1.TENNGANH,
                GIOITINH = p.GIOITINH.Value,
                TENGIOITINH = p.GIOITINH.Value == true ? "Nam" : "Nữ",
                GHICHU = p.GHICHU,
                TRANGTHAI = false,
            }).ToList();
        }
        public List<SinhVienDTO> DSSV_Nganh(string newDT)
        {
            return DB.SINHVIENs.Where(u => u.NGANH == newDT && u.TRANGTHAI == false).Select(p => new SinhVienDTO()
            {
                MSSV = p.MSSV,
                HOTEN = p.HOTEN,
                CCCD = p.CCCD,
                NGAYSINH = p.NGAYSINH.Value,
                DANTOC = p.DANTOC,
                DIACHI = p.DIACHI,
                EMAIL = p.EMAIL,
                MALOP = p.MALOP,
                TENLOP = p.LOP.TENLOP,
                NIENKHOA = p.NIENKHOA,
                TENNIENKHOA = p.NIENKHOA1.TENNIENKHOA,
                NGANH = p.NGANH,
                TENNGANH = p.NGANH1.TENNGANH,
                GIOITINH = p.GIOITINH.Value,
                TENGIOITINH = p.GIOITINH.Value == true ? "Nam" : "Nữ",
                GHICHU = p.GHICHU,
                TRANGTHAI = false,
            }).ToList();
        }
        public List<SinhVienDTO> DSSV_NienKhoa(string newDT)
        {
            return DB.SINHVIENs.Where(u => u.NIENKHOA == newDT && u.TRANGTHAI == false).Select(p => new SinhVienDTO()
            {
                MSSV = p.MSSV,
                HOTEN = p.HOTEN,
                CCCD = p.CCCD,
                NGAYSINH = p.NGAYSINH.Value,
                DANTOC = p.DANTOC,
                DIACHI = p.DIACHI,
                EMAIL = p.EMAIL,
                MALOP = p.MALOP,
                TENLOP = p.LOP.TENLOP,
                NIENKHOA = p.NIENKHOA,
                TENNIENKHOA = p.NIENKHOA1.TENNIENKHOA,
                NGANH = p.NGANH,
                TENNGANH = p.NGANH1.TENNGANH,
                GIOITINH = p.GIOITINH.Value,
                TENGIOITINH = p.GIOITINH.Value == true ? "Nam" : "Nữ",
                GHICHU = p.GHICHU,
                TRANGTHAI = false,
            }).ToList();
        }

        public List<SinhVienDTO> DSSV_DanToc(string newDT)
        {
            return DB.SINHVIENs.Where(u => u.DANTOC.Contains(newDT) && u.TRANGTHAI == false).Select(p => new SinhVienDTO()
            {
                MSSV = p.MSSV,
                HOTEN = p.HOTEN,
                CCCD = p.CCCD,
                NGAYSINH = p.NGAYSINH.Value,
                DANTOC = p.DANTOC,
                DIACHI = p.DIACHI,
                EMAIL = p.EMAIL,
                MALOP = p.MALOP,
                TENLOP = p.LOP.TENLOP,
                NIENKHOA = p.NIENKHOA,
                TENNIENKHOA = p.NIENKHOA1.TENNIENKHOA,
                NGANH = p.NGANH,
                TENNGANH = p.NGANH1.TENNGANH,
                GIOITINH = p.GIOITINH.Value,
                TENGIOITINH = p.GIOITINH.Value == true ? "Nam" : "Nữ",
                GHICHU = p.GHICHU,
                TRANGTHAI = false,
            }).ToList();
        }
        public List<SinhVienDTO> DSSV_DiaChi(string newDT)
        {
            return DB.SINHVIENs.Where(u => u.DIACHI.Contains(newDT) && u.TRANGTHAI == false).Select(p => new SinhVienDTO()
            {
                MSSV = p.MSSV,
                HOTEN = p.HOTEN,
                CCCD = p.CCCD,
                NGAYSINH = p.NGAYSINH.Value,
                DANTOC = p.DANTOC,
                DIACHI = p.DIACHI,
                EMAIL = p.EMAIL,
                MALOP = p.MALOP,
                TENLOP = p.LOP.TENLOP,
                NIENKHOA = p.NIENKHOA,
                TENNIENKHOA = p.NIENKHOA1.TENNIENKHOA,
                NGANH = p.NGANH,
                TENNGANH = p.NGANH1.TENNGANH,
                GIOITINH = p.GIOITINH.Value,
                TENGIOITINH = p.GIOITINH.Value == true ? "Nam" : "Nữ",
                GHICHU = p.GHICHU,
                TRANGTHAI = false,
            }).ToList();
        }
        public List<SinhVienDTO> DSSV_GhiChu(string newDT)
        {
            return DB.SINHVIENs.Where(u => u.GHICHU.Contains(newDT) && u.TRANGTHAI == false).Select(p => new SinhVienDTO()
            {
                MSSV = p.MSSV,
                HOTEN = p.HOTEN,
                CCCD = p.CCCD,
                NGAYSINH = p.NGAYSINH.Value,
                DANTOC = p.DANTOC,
                DIACHI = p.DIACHI,
                EMAIL = p.EMAIL,
                MALOP = p.MALOP,
                TENLOP = p.LOP.TENLOP,
                NIENKHOA = p.NIENKHOA,
                TENNIENKHOA = p.NIENKHOA1.TENNIENKHOA,
                NGANH = p.NGANH,
                TENNGANH = p.NGANH1.TENNGANH,
                GIOITINH = p.GIOITINH.Value,
                TENGIOITINH = p.GIOITINH.Value == true ? "Nam" : "Nữ",
                GHICHU = p.GHICHU,
                TRANGTHAI = false,
            }).ToList();
        }

    }
}
