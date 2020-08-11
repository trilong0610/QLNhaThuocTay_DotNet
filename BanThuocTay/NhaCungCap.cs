using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanThuocTay
{
    public class NhaCungCap : Context
    {
        public List<NHACUNGCAP> LoadNCC()
        {
            return ql.NHACUNGCAPs.Select(t => t).ToList<NHACUNGCAP>();
        }
        public virtual object MaNhaCungCap
        {
            get;
            set;
        }
        public virtual object TenNhaCungCap
        {
            get;
            set;

        }
        public virtual object HotLine
        {
            get;
            set;

        }
        public virtual object DiaChi
        {
            get;
            set;
        }
        public virtual LoaiThuoc LoaiThuoc
        {
            get;
            set;
        }
        public virtual IEnumerable<HoaDonNhap> HoaDonNhap
        {
            get;
            set;
        }
    }
}