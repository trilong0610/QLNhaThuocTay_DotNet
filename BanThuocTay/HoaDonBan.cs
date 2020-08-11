using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanThuocTay
{
    public class HoaDonBan : Context
    {
        public List<HOADON_BAN> LoadHDB()
        {
            return ql.HOADON_BANs.Select(t => t).ToList<HOADON_BAN>();
        }

        public virtual object MaHDBan
        {
            get;
            set;
        }
        public virtual KhachHang KhachHang
        {
            get;
            set;
        }
        public virtual DateTime NgayBan
        {
            get;
            set;
        }
        public virtual NhanVien NhanVien
        {
            get;
            set;
        }
        public virtual IEnumerable<CTHoaDonBan> CTHoaDonBan
        {
            get;
            set;
        }
    }
}
