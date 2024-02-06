using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SinhVienDTO
    {
        public string MSSV { get; set; }
        public string HOTEN { get; set; }
        public bool GIOITINH { get; set; }
        public string TENGIOITINH { get; set ; }
        public DateTime NGAYSINH { get; set; }
        public string MALOP { get; set; }

        public string TENLOP { get; set; }
        public string CCCD { get; set; }
        public string DANTOC { get; set; }
        public string DIACHI { get; set; }
        public string EMAIL { get; set; }

        public string NIENKHOA { get; set; }
        public string TENNIENKHOA { get; set; }
        public bool TRANGTHAI { get; set; }
        public string GHICHU { get; set; }
        public string NGANH { get; set; }

        public string TENNGANH { get; set; }
    }
}
