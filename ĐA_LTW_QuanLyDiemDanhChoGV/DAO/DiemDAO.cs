using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DiemDAO
    {
        QL_DIEMSVEntities DB = new QL_DIEMSVEntities();
        public List<DiemDTO> DSDiem()
        {
            return DB.DIEMs.Where(u=>u.TRANGTHAI==false).Select(u=> new DiemDTO
            {
                MSSV = u.MSSV,
                HOTEN = u.HOTEN,
                MONHOC = u.MONHOC,
                DIEMCC =u .DIEMCC.Value,
                DIEMTBKT = u.DIEMTBKT.Value,
                DIEMTHIL1 = u.DIEMTHIL1.Value,
                DIEMTHIL2 = u.DIEMTHIL2.Value,
                DIEMTHINHAN = u.DIEMTHINHAN.Value,
                DIEMTONGKETMON = u.DIEMTONGKETMON.Value,
                NGANH = u.NGANH,
                TENNGANH = u.NGANH1.TENNGANH,
                TENHOCKY = u.HOCKY1.TENHOCKY,
                TENLOP = u.LOP1.TENLOP,
                LOP = u.LOP,
                HOCKY=u.HOCKY,
                GHICHU = u.GHICHU
            }).ToList();
        }

        public bool ThemDiem(DiemDTO newDT)
        {
            try
            {
                DIEM d = new DIEM
                {
                    MSSV = newDT.MSSV,
                    HOCKY = newDT.HOCKY,
                    LOP = newDT.LOP,
                    NGANH=newDT.NGANH,
                    HOTEN = newDT.HOTEN,
                    DIEMCC = newDT.DIEMCC,
                    DIEMTBKT = newDT.DIEMTBKT,
                    DIEMTHIL1 = newDT.DIEMTHIL1,
                    DIEMTHIL2 = newDT.DIEMTHIL2,
                    DIEMTHINHAN = newDT.DIEMTHINHAN,
                    DIEMTONGKETMON = newDT.DIEMTONGKETMON
                };

                DB.DIEMs.Add(d);
                DB.SaveChanges();
                return true;

            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool SuaDiem(DiemDTO newDT)
        {
            try
            {
                DIEM d = DB.DIEMs.SingleOrDefault(u => u.MSSV == newDT.MSSV && u.TRANGTHAI == false);
                {
                    d.MSSV = newDT.MSSV;
                    d.HOCKY = newDT.HOCKY;
                    d.LOP = newDT.LOP;
                    d.NGANH = newDT.NGANH;
                    d.HOTEN = newDT.HOTEN;
                    d.DIEMCC = newDT.DIEMCC;
                    d.DIEMTBKT = newDT.DIEMTBKT;
                    d.DIEMTHIL1 = newDT.DIEMTHIL1;
                    d.DIEMTHIL2 = newDT.DIEMTHIL2;
                    d.DIEMTHINHAN = newDT.DIEMTHINHAN;
                    d.DIEMTONGKETMON = newDT.DIEMTONGKETMON;
                }
                DB.SaveChanges();
                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool KT(string newDT)
        {
            try
            {
                DIEM d = DB.DIEMs.Single(u => u.MSSV == newDT && u.TRANGTHAI == false);
                if (d == null) return false;
                else return true;
            }
            catch (Exception ex) { return false; }
        }
    }
}
