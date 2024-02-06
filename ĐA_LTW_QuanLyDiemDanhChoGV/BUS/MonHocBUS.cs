using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class MonHocBUS
    {
        MonHocDAO _monHocDAO = new MonHocDAO();
        public List<MonHocDTO> DSMonHoc()
        {
            return _monHocDAO.DSMonHoc();
        }
        public bool ThemMonHoc(MonHocDTO newDT)
        {
            return _monHocDAO.ThemMonHoc(newDT);
        }

        public bool XoaMonHoc(MonHocDTO newDT)
        {
            return _monHocDAO.XoaMonHoc(newDT);
        }
        public bool SuaMonHoc(MonHocDTO newDT)
        {
            return _monHocDAO.SuaMonHoc(newDT);
        }

        public List<MonHocDTO> DSMonHoc_MaMonHoc(string newDT)
        {
            return _monHocDAO.DSMonHoc_MaMonHoc(newDT);
        }
        public List<MonHocDTO> DSMonHoc_TenMonHoc(string newDT)
        {
            return _monHocDAO.DSMonHoc_TenMonHoc(newDT);
        }
        public List<MonHocDTO> DSMonHoc_GhiChu(string newDT)
        {
            return _monHocDAO.DSMonHoc_GhiChu(newDT);
        }

        public List<MonHocDTO> DSMonHoc_SoTinChi(int newDT)
        {
            return _monHocDAO.DSMonHoc_SoTinChi(newDT);
        }

        public bool KT (string newDT)
        {
            return _monHocDAO.KT(newDT);

        }

        public bool KTDaXoa(string newDT)
        {
            return _monHocDAO.KTDaXoa(newDT);

        }

        public bool ThemMonHocDaXoa(MonHocDTO newDT)
        {
            return _monHocDAO.ThemDaXoa(newDT);

        }

    }
}
