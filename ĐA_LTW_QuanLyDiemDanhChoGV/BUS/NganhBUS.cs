using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NganhBUS
    {

        NganhDAO _nganhDAO = new NganhDAO();
        public List<NganhDTO> DSNganh()
        {
            return _nganhDAO.DSNganh();
        }
        public bool ThemNganh(NganhDTO newDT)
        {
            return _nganhDAO.ThemNganh(newDT);
        }
        public bool ThemNganhDaXoa(NganhDTO newDT)
        {
            return _nganhDAO.ThemDaXoa(newDT);
        }
        public bool KTNganhDaXoa(string newDT)
        {
            return _nganhDAO.KTDaXoa(newDT);
        }

        public bool SuaNganh(NganhDTO newDT)
        {
            return _nganhDAO.SuaNganh(newDT);
        }
        public bool XoaNgah(NganhDTO newDT)
        {
            return _nganhDAO.XoaNganh(newDT);
        }
        public bool KTNganh(NganhDTO newDT)
        {
            return _nganhDAO.KTNganh(newDT);
        }
        public List<NganhDTO> DSNganh_MaNganh(string newDT)
        {
            return _nganhDAO.DSNganh_MaNganh(newDT);
        }
        public List<NganhDTO> DSNganh_TenNganh(string newDT)
        {
            return _nganhDAO.DSNganh_TenNganh(newDT);
        }
        public List<NganhDTO> DSNganh_GhiChu(string newDT)
        {
            return _nganhDAO.DSNganh_GhiChu(newDT);
        }

        public List<NganhDTO> DSNganh_TenKhoa(string newDT)
        {
            return _nganhDAO.DSNganh_TenKhoa(newDT);
        }
    }
}
