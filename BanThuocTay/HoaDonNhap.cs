using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanThuocTay
{
    public class HoaDonNhap : Context
    {
        public List<HOADON_NHAP> LoadHDN()
        {
            return ql.HOADON_NHAPs.Select(t => t).ToList<HOADON_NHAP>();
        }

        public virtual object MaHDNhap
        {
            get;
            set;
        }
        public virtual NhaCungCap NhaCungCap
        {
            get;
            set;
        }
        public virtual DateTime NgayLapHD
        {
            get;
            set;
        }
        public virtual Double TongTien
        {
            get;
            set;
        }
        public virtual NhanVien NhanVien
        {
            get;
            set;
        }
        public virtual IEnumerable<CTHoaDonNhap> CTHoaDonNhap
        {
            get;
            set;
        }
    }
}
