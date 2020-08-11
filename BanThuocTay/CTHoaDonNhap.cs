using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanThuocTay
{
    public class CTHoaDonNhap : Context
    {
        public List<CHITIETHOADON_NHAP> LoadCTHDN()
        {
            return ql.CHITIETHOADON_NHAPs.Select(t => t).ToList<CHITIETHOADON_NHAP>();
        }

        public virtual HoaDonNhap HoaDonNhap
        {
            get;
            set;
        }
        public virtual Thuoc Thuoc
        {
            get;
            set;
        }
        public virtual int SoLuong
        {
            get;
            set;
        }
    }
}
